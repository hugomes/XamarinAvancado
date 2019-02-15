using ListView.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListView.Data
{
    public static class GrupoData
    {
        public static List<Grupo> ListarGrupos()
        {
            return new List<Grupo>{
                new Grupo("Meios de Rede", "Centrais") {
                    new Pessoa { Nome = "Hugo", EstaJogando = true, Numero = 7},
                    new Pessoa { Nome = "Nininho", EstaJogando = false, Numero = 11},
                    new Pessoa { Nome = "Walter", EstaJogando = false, Numero = 8},
                    new Pessoa {Nome = "Georgio", EstaJogando = true, Numero = 4}
                },
                new Grupo("Entrada de Rede", "Ponteiros") {
                    new Pessoa { Nome = "Tom", EstaJogando = true, Numero = 1},
                    new Pessoa { Nome = "Adriano", EstaJogando = false, Numero = 5},
                    new Pessoa { Nome = "Lama", EstaJogando = false, Numero = 6},
                    new Pessoa { Nome = "George", EstaJogando = true, Numero = 3}
                },
                new Grupo("Levantador", "Levantador") {
                    new Pessoa { Nome = "Soares", EstaJogando = true, Numero = 2},
                    new Pessoa { Nome = "Roy", EstaJogando = false, Numero = 12}
                },
                new Grupo("Saída de Rede", "Oposto") {
                    new Pessoa { Nome = "Mano", EstaJogando = true, Numero = 13},
                    new Pessoa { Nome = "Geléia", EstaJogando = false, Numero = 10}
                },
                new Grupo("Líberos", "Líberos") {
                    new Pessoa { Nome = "Bruno", EstaJogando = true, Numero = 17},
                    new Pessoa { Nome = "Matoso", EstaJogando = false, Numero = 16}
                }
            };
        }
    }
}
