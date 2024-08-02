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

          public Driver(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string adreess, string licenseNumber, string licenseCategory, int driverExperience) : base(name, lastName, typeDocument, identificationNumber, birthdate, email, phoneNumber, adreess)
          {
               LicenseNumber = licenseNumber;
               LicenseCategory = licenseCategory;
               DriverExperience = driverExperience;
          }

          public void UpdateLicenseCategory(string newCategory)
          {
               LicenseCategory = newCategory;
          }

          public void AddExperience(int years)
          {
               DriverExperience += years;
          }

          // metodos que antes eran estaticos pasados a public para su posterior utilizacion
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
          public string IdentificacionDriver()
          {
               return base.Cc();
          }
     }
}