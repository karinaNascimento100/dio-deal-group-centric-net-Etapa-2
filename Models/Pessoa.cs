using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_deal_group_centric_net_Etapa_2.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}