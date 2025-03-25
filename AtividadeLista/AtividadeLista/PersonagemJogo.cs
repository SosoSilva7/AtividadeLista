using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLista
{
   internal class PersonagemJogo
    {
        public string Nome { get; set; }
        public string Historia { get; set; }
        public string Poder { get; set; }
        public string Caracteristicas { get; set; }
        public string Origem { get; set; }

        public static List<PersonagemJogo> Lista
        {
            get
            {
                List<PersonagemJogo> lista = new List<PersonagemJogo>();
                lista.Add(new PersonagemJogo() { Nome = "Jones", Historia = "Professor do Fernando Prestes que sai em uma jornada para salvar seus colegas",
                Poder = "Jones pode aprender a usar qualquer habilidade de qualquer pessoa", 
                Caracteristicas = "Muito carisma e determinação", Origem = "Terra" });
                
                lista.Add(new PersonagemJogo() { Nome = "Alex", Historia = "Professor do Fernando Prestes que foi corrompido",
                Poder = "Alex consegue usar seu cabelo incrível para atacar e se defender", 
                Caracteristicas = "Cabelos longos, loiros e sedosos, porém mortais", Origem = "Terra" }); 
                
                lista.Add(new PersonagemJogo() { Nome = "Fernando Prestes", Historia = "Entidade que deu origem a escola de prodígios Fernando Prestes",
                Poder = "Dizem as lendas que ele é capaz de criar e destruir planetas inteiros com sua força", 
                Caracteristicas = "Desconhecidas", Origem = "Desconhecida" });
                
                lista.Add(new PersonagemJogo() { Nome = "Maycon", Historia = "Ser maligno com motivações desconhecidas",
                Poder = "Maycon é capaz de tudo, mas é conhecido por alguns como Deus da destruição", 
                Caracteristicas = "Desconhecidas", Origem = "Desconhecida" });
                
                lista.Add(new PersonagemJogo() { Nome = "Monge", Historia = "Desconhecida",
                Poder = "O Monge, no seu auge do poder, fez coisas que muitos dizem serem impossíveis ", 
                Caracteristicas = "Desconhecidas", Origem = "Desconhecida" });

                lista.Add(new PersonagemJogo() { Nome = "Deuses do Badmintom", Historia = "A dupla profissional responsável por criar o esporte sagrado badminton e que transcendeu os limites do jogo",
                Poder = "Os deuses do badmintom podem resignificar esse esporte e tranformá-lo em um campo de batalha", 
                Caracteristicas = "Profissionais de badminton", Origem = "Terra" });
                return lista;
            }
        }

    }
}
