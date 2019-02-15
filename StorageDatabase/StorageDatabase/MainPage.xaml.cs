using PCLStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StorageDatabase
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btEscreverArquivo.Clicked += async (sender, args) => {
                Util.StorageManagement.SaveFile("file.txt", enConteudo.Text);
            };

            btLerArquivo.Clicked += async (sender, args) => {
                lbArquivo.Text =  await Util.StorageManagement.ReadFile("file.txt");
            };
        }
    }
}
