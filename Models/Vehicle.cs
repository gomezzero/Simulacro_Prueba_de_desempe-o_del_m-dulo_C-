using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Simulacro_Prueba_de_desempe_o_del_m_dulo_C_.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public string EngineNumber { get; set; }
        public byte PeopleCapacity { get; set; }
        public Driver Owner { get; set; }

        // constructor
        public Vehicle(int id, string placa, string tipo, string engineNumber, byte peopleCapacity, Driver owner)
        {
            Id = id;
            Placa = placa;
            Tipo = tipo;
            EngineNumber = engineNumber;
            PeopleCapacity = peopleCapacity;
            Owner = owner;
        }
        public void DelateVehicle(int id)
        {
          if ( Owner == null)
          {
            TransRiwi.ListVehicles.RemoveAll(x => x.Id == id);
          }
        }

        public static Driver CarOwner(string IdentificationNumber)
        {
            return TransRiwi.ListDrivers.FirstOrDefault(x => x.cc() == IdentificationNumber);
        }
    }
}