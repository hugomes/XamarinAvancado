using RealmDatabase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.ComponentModel.DataAnnotations;
using Realms;

namespace RealmDatabase
{
    public partial class MainPage : ContentPage
    {
        private int? _produtoId { get; set; }

        public MainPage()
        {
            InitializeComponent();

            btSalvar.Clicked += delegate {
                Produto produto = new Produto() {
                    Item = enItem.Text,
                    Quantidade = int.Parse(enQtd.Text)
                };

                List<ValidationResult> validateList = new List<ValidationResult>();
                var contexto = new ValidationContext(produto);
                bool isValid = Validator.TryValidateObject(produto, contexto, validateList, true);

                if (!isValid)
                {
                    string mensagemErro = string.Empty;

                    foreach(ValidationResult erro in validateList)
                    {
                        mensagemErro += erro.ErrorMessage + "\n";
                    }
                    DisplayAlert("ERRO", mensagemErro, "Fechar");
                }
                else
                {
                    var realm = Realm.GetInstance();

                    var ultimoProdutoSalvo = realm.All<Produto>().OrderByDescending(o => o.Id).First();

                    if (ultimoProdutoSalvo != null)
                    {
                        produto.Id = ultimoProdutoSalvo.Id + 1;
                    }

                    realm.Write(()=>
                    {
                        if (_produtoId == null)
                        {
                            realm.Add(produto);
                        }
                        else
                        {
                            produto.Id = (int)_produtoId;
                            realm.Add(produto, true);
                            _produtoId = null;
                        }
                    });

                    lvListaItens.ItemsSource = realm.All<Produto>();
                    DisplayAlert("OK", "Salvo com sucesso. "+realm.All<Produto>().Count()+" produtos no total.", "Fechar");
                }
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var realm = Realm.GetInstance();
            lvListaItens.ItemsSource = realm.All<Produto>();
        }

        private void BtDelete_Clicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var produto = (Produto)menuItem.CommandParameter;

            var realm = Realm.GetInstance();
            realm.Write(() => {
                realm.Remove(produto);
            });
            lvListaItens.ItemsSource = realm.All<Produto>();
        }

        private void BtUpdate_Clicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var produto = (Produto)menuItem.CommandParameter;

            enItem.Text = produto.Item;
            enQtd.Text = produto.Quantidade.ToString();
            _produtoId = produto.Id;
        }
    }
}
