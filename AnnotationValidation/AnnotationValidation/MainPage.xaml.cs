using AnnotationValidation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnnotationValidation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            btSalvar.Clicked += delegate
            {
                Pessoa pessoa = new Pessoa()
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    CPF = txtCPF.Text
                };

                var validationList = new List<ValidationResult>();
                var contexto = new ValidationContext(pessoa);
                bool isValid = Validator.TryValidateObject(pessoa, contexto, validationList, true);

                if (validationList.Count > 0)
                {
                    lbMensagem.Text = string.Empty;

                    foreach (var erro in validationList)
                    {
                        lbMensagem.Text += string.Format(erro.ErrorMessage, erro.MemberNames);
                    }
                }
                else
                {
                    lbMensagem.Text = "Sucesso!";
                }
            };
        }
    }
}
