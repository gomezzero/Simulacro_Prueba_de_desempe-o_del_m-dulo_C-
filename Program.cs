using Simulacro_Prueba_de_desempe_o_del_m_dulo_C_.Models;

var driver1 = new Driver("Pablo", "perez", "cc", "122253q", new DateOnly(2000, 3, 22), "ferdds|@gmail.com", "dfafasd", "dsada", "12424234", "A2", 12);
var vehicle1 = new Vehicle(1, "perez", "cc", "1222353q", 2, driver1);
var customer1 = new Customer("david", "perez", "cc", "12321", new DateOnly(2000, 2, 11), "ferdds|@gmail.com", "dfafdasd", "basic", "12", "dsada");

TransRiwi.ListDrivers = new List<Driver>();
TransRiwi.ListDrivers.Add(driver1);
TransRiwi.ListVehicles = new List<Vehicle>();
TransRiwi.ListVehicles.Add(vehicle1);
TransRiwi.ListCustomers = new List<Customer>();
TransRiwi.ListCustomers.Add(customer1);

while (true)
{
    Console.Clear();
    Console.WriteLine("----- administrador transRiwi -----");
    Console.WriteLine("1. Conductores");
    Console.WriteLine("2. Veiculos");
    Console.WriteLine("3. Constomer");
    Console.WriteLine("4. Ejercicion");
    Console.WriteLine("0. Salir");
    Console.Write("Selecciona una opción: ");

    switch (Console.ReadLine())
    {
        case "1":

            break;

        case "2":

            break;

        case "3":

            break;

        case "4":

            break;

        case "0":
            return;
        default:
            Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
            break;
    }
}

