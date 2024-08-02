using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_Prueba_de_desempe_o_del_m_dulo_C_.Models
{
    public class Customer : User
    {
        public string MembershipLevel { get; set; }
        public string PreferredPaymentMethod { get; set; }

        // constructor
        public Customer(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string adreess, string membershipLevel, string preferredPaymentMethod) : base(name, lastName, typeDocument, identificationNumber, birthdate, email, phoneNumber, adreess)
        {
            MembershipLevel = membershipLevel;
            PreferredPaymentMethod = preferredPaymentMethod;
        }

        public void UpdateMembershipLevel(string membershipLevel)
        {
            if (membershipLevel == "premium")
            {
                MembershipLevel = "Premium";
                Console.WriteLine("Membership level updated successfully!");
            }
            else if (membershipLevel == "basic")
            {
                MembershipLevel = "Basic";
                Console.WriteLine("Membership level updated successfully!");
            }
            else if (membershipLevel == "platinum")
            {
                MembershipLevel = "Platinum";
                Console.WriteLine("Membership level updated successfully!");
            }
            else
            {
                Console.WriteLine("Invalid membership level");
            }
        }

        public string GetName()
        {
            return Name;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public string GetTypeDocument()
        {
            return TypeDocument;
        }

        public string GetIdentificationNumber()
        {
            return IdentificationNumber;
        }

        public DateOnly GetBirthdate()
        {
            return Birthdate;
        }

        public string GetEmail()
        {
            return Email;
        }

        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }

        public string GetAdreess()
        {
            return Adreess;
        }
    }
}