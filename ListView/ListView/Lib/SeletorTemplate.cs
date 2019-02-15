using ListView.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ListView.Lib
{
    public class SeletorTemplate : DataTemplateSelector
    {
        DataTemplate campoObrigatorio;
        DataTemplate campoNaoObrigatorio;

        public SeletorTemplate()
        {
            campoNaoObrigatorio = new DataTemplate(typeof(Template.ItemPessoaNaoObrigatorioViewCell));
            campoObrigatorio = new DataTemplate(typeof(Template.ItemPessoaObrigatorioViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Pessoa pessoa = item as Pessoa;

            if (pessoa.EstaJogando)
            {
                return campoObrigatorio;
            }
            else
            {
                return campoNaoObrigatorio;
            }
        }
    }
}
