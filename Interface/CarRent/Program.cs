using System.ComponentModel;
using System.Globalization;
using CarRent.Services;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Enter rental data: ");
            System.Console.WriteLine("Car model: ");
            string model = Console.ReadLine();
            System.Console.WriteLine("Pickup (dd/MM/yyyy hh:ss): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            System.Console.WriteLine("Return (dd/MM/yyyy hh:ss): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            System.Console.WriteLine("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var carRental = new CarRental(start, finish, new Vehicle(model));
            var rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);
            System.Console.WriteLine("Invoice");
            System.Console.WriteLine(carRental.Invoice);

        }
    }
}