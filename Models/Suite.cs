using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reserva_hotel.Models
{
    public class Suite
    {
        public Suite(string tipoSuite, int Capacidade, decimal ValorDiaria) 
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;

        }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria {get; set; }

        
    }
}