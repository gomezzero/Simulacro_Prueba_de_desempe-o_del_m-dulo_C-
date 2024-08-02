using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_Prueba_de_desempe_o_del_m_dulo_C_.Models
{
    public class User
    {
        protected Guid Id { get; set; }
        protected string Name { get; set; }
        protected string LastName { get; set; }
        protected string TypeDocument { get; set; }
        protected string IdentificationNumber { get; set; }
        protected DateOnly Birthdate { get; set; }
        protected string Email { get; set; }
        protected string PhoneNumber { get; set; }
        protected string Adreess { get; set; }

        // Constructor
        protected User(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string adreess)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            TypeDocument = typeDocument;
            IdentificationNumber = identificationNumber;
            Birthdate = birthdate;
            Email = email;
            PhoneNumber = phoneNumber;
            Adreess = adreess;
        }

        protected void ShowDetails()
        { 
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Name} {LastName}");
            Console.WriteLine($"Tipo de documento: {TypeDocument}");
            Console.WriteLine($"Número de identificación: {IdentificationNumber}");
            Console.WriteLine($"Fecha de nacimiento: {Birthdate.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Correo electrónico: {Email}");
            Console.WriteLine($"Teléfono: {PhoneNumber}");
            Console.WriteLine($"Dirección: {Adreess}");
        }

        protected int CalculateAge()
        { 
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
            int age = currentDate.Year - Birthdate.Year;
            return age;
        }

        protected void ShowAge()
        {
            Console.WriteLine($"Edad: {CalculateAge()} años");
        }

        protected string cc()
        {
            return IdentificationNumber;
        }
    }
}