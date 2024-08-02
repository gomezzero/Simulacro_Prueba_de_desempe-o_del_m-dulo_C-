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
        { }

        protected int CalculateAge()
        { return 0;}

        protected void SohwAge()
        { }

    }
}