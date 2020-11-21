using System;
using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel");
            Console.Write("Modelo do carro: ");
            var carModel = Console.ReadLine();
            Console.Write("Retirada: (dd/MM/yyyy hh:mm)");
            var retirada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Devolução: (dd/MM/yyyy hh:mm)");
            var devolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            var carRental = new CarRental(retirada,devolucao, new Vehicle(carModel));

            Console.Write("Digite o preço por hora: ");
            var hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o preço por dia: ");
            var day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var carRentalService = new RentalService(hour, day);

            carRentalService.ProcessInvoice(carRental);

            Console.Write("Invoice:  ");
            Console.WriteLine(carRental.Invoice);

        }
    }
}
