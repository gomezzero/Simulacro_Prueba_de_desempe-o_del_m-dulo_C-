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
        protected Customer(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string adreess, string membershipLevel, string preferredPaymentMethod) : base(name, lastName, typeDocument, identificationNumber, birthdate, email, phoneNumber, adreess)
        {
                MembershipLevel = membershipLevel;
                PreferredPaymentMethod = preferredPaymentMethod;
        }

        public void UpdateMembershipLevel()
        { }
    }
}