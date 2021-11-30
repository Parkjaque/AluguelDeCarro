using System;
using System.Globalization;
using Aluguel_de_Carros.Entidades;
using Aluguel_de_Carros.Servicos;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com os dados da locação:");

        Console.Write("modelo: ");

        string model = Console.ReadLine();

        Console.Write("Check -in (dd/MM/yyyy HH:mm): ");

        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.Write("Check -out (dd/MM/yyyy HH:mm): ");

        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.Write("Entre com o preço por hora: ");

        double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Entre com preço por dia: ");

        double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        AluguelCarro carRental = new AluguelCarro(start, finish, new Veiculo(model));

        ServicoLocacao rentalService = new ServicoLocacao(hour, day, new TaxaServicoBR());

        rentalService.ProcessInvoice(carRental);

        Console.WriteLine("FATURA: ");

        Console.WriteLine(carRental.Invoice);
    }
}