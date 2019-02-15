using ListView.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListView.Data
{
    public static class PessoaData
    {
        public static IList<Pessoa> GetFuncionarios()
        {
            return new List<Pessoa>(){
                new Pessoa { Nome = "Hugo" },
                new Pessoa { Nome = "Diana" },
                new Pessoa { Nome = "Camila" },
                new Pessoa { Nome = "Arthur" },
                new Pessoa { Nome = "Onélia" }
            };
        }
    }
}
