using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_Prueba_de_desempe_o_del_m_dulo_C_.Models
{
    public class Driver : User
    {
        public string LicenseNumber { get; set; }
        public string LicenseCategory { get; set; }
        public int DriverExperience { get; set; }

        protected Driver(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string adreess, string licenseNumber, string licenseCategory, int driverExperience) : base(name, lastName, typeDocument, identificationNumber, birthdate, email, phoneNumber, adreess)
        {
            LicenseNumber = licenseNumber;
            LicenseCategory = licenseCategory;
            DriverExperience = driverExperience;
        }

        public void UpdateLicenseCategory(string newCategory)
        { }

        public void AddExperience(int years)
        { }
    }
}