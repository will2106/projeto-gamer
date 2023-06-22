using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_gamer.Models
{
    public class Equipe 
    {
        [Key] //pega somente a de baixo (data annotation)
        public int IdEquipe { get; set; }

        public string Nome { get; set; }
        public string Imagem { get; set; }

        public ICollection<Jogador> Jogador { get; set; } //referência a classe equipe vai ter acesso a classe (collection) jogador
    }
}