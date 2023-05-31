
using reserva_hotel.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Reserva reserva = new Reserva();

        // Cadastrar hóspedes
        List<Pessoa> hospedes = new List<Pessoa>
        {
            new Pessoa("João", "Silva"),
            new Pessoa("Maria", "Santos")
        };
        reserva.CadastrarHospedes(hospedes);

        // Cadastrar suíte
        Suite suite = new Suite(2, 100.0m);
        reserva.CadastrarSuite(suite);

        // Definir dias reservados
        reserva.DiasReservados = 5;

        // Exibir informações da reserva
        Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");

        // Aguardar a entrada do usuário para fechar a janela do console
        Console.ReadLine();
    }
}