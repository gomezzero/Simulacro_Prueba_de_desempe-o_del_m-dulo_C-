using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Simulacro_Prueba_de_desempe_o_del_m_dulo_C_.Models
{
    public class TransRiwi
    {
        public static List<Driver> ListDrivers = new List<Driver>();
        public static List<Vehicle> ListVehicles = new List<Vehicle>();
        public static List<Customer> ListCustomers = new List<Customer>();

        public static Driver CreateDriver()
        {
            Console.WriteLine("Ingrese el Nombre del Conductor");
            string GetName = Console.ReadLine();

            Console.WriteLine("Ingrese el Apellido del Conductor");
            string GetLastName = Console.ReadLine();

            Console.WriteLine("Ingrese el Tipo De Documento");
            string GetTypeDocument = Console.ReadLine();

            Console.WriteLine("Ingrese el Numero De Identificacion");
            string GetIdentificationNumber = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de macimiento del conductor");
            DateOnly GetBirthdate = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el email del conductor");
            string GetEmail = Console.ReadLine();

            Console.WriteLine("Ingrese el numero de telefo del Conductor");
            string GetPhoneNumber = Console.ReadLine();

            Console.WriteLine("Ingrese la direccion del Conductor");
            string GetAdreess = Console.ReadLine();

            Console.WriteLine("Ingrese el numero de licencia del Conductor");
            string licenseNumber = Console.ReadLine();

            Console.WriteLine("Ingrese ingrese el tipo de licencia del conductor");
            string licenseCategory = Console.ReadLine();

            Console.WriteLine("Ingrese ingrese el tipo de licencia del conductor");
            int driverExperience = Console.Read();

            return new Driver(GetName, GetLastName, GetTypeDocument, GetIdentificationNumber, GetBirthdate, GetEmail, GetPhoneNumber, GetAdreess, licenseNumber, licenseCategory, driverExperience);
        }

        public static Customer CreateCustomer()
        {
            Console.WriteLine("Ingrese el Nombre del Usuario");
            string GetName = Console.ReadLine();

            Console.WriteLine("Ingrese el Apellido del Usuario");
            string GetLastName = Console.ReadLine();

            Console.WriteLine("Ingrese el Tipo De Documento");
            string GetTypeDocument = Console.ReadLine();

            Console.WriteLine("Ingrese el Numero De Identificacion");
            string GetIdentificationNumber = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de macimiento del Usuario");
            DateOnly GetBirthdate = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el email del Usuario");
            string GetEmail = Console.ReadLine();

            Console.WriteLine("Ingrese el numero de telefo del Usuario");
            string GetPhoneNumber = Console.ReadLine();

            Console.WriteLine("Ingrese la direccion del Usuario");
            string GetAdreess = Console.ReadLine();

            Console.WriteLine("Ingrese el numero de membresia del Usuario (1. basica, 2. platimum, 3. premium)");
            string membershipLevel = Console.ReadLine();

            Console.WriteLine("Inrgesa el metodo de pago");
            string preferredPaymentMethod = Console.ReadLine();


            return new Customer(GetName, GetLastName, GetTypeDocument, GetIdentificationNumber, GetBirthdate, GetEmail, GetPhoneNumber, GetAdreess, membershipLevel, preferredPaymentMethod);
        }

        public static Vehicle CreateVehicle()
        {
            Console.WriteLine("Ingrese el ID del Vehiculo");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Placa del Vehiculo");
            string placa = Console.ReadLine();

            Console.WriteLine("Ingrese el Tipo del Vehiculo");
            string tipo = Console.ReadLine();

            Console.WriteLine("Ingrese el Numero de Motor del Vehiculo");
            string engineNumber = Console.ReadLine();

            Console.WriteLine("Ingrese la Capacidad de Personas del Vehiculo");
            byte peopleCapacity = byte.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero de identificacion del Conductor del Vehiculo");
            string identificationNumber = Console.ReadLine();
            var driver = Vehicle.CarOwner(identificationNumber);

            return new Vehicle(id, placa, tipo, engineNumber, peopleCapacity, driver);
        }
    }
}