using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reserva_hotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados, Suite suite, int DiasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
        {
            Hospedes = hospedes;
        }
        else
        {
            // Retornar uma exceção caso a capacidade seja menor que o número de hóspedes recebido
            throw new ArgumentException("A capacidade da suíte é menor do que o número de hóspedes.");
        }
        }

        
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes?.Count ?? 0;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria = Suite.ValorDiaria;
            decimal valorTotal = valorDiaria * DiasReservados;

            if (DiasReservados >= 10)
            {
                valorTotal -= (valorTotal * 0.1m); 
            }

            return valorTotal;
        }
    }

    
}