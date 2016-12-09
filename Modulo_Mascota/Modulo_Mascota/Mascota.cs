using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_Mascota
{
    public class Mascota
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string especie { get; set; }
        public string raza { get; set; }
        public string color { get; set; }
        public string peso { get; set; }
        public string sexo { get; set; }
        public string senasParticulares { get; set; }
        public string fechaNacimiento { get; set; }
        public string statuss { get; set; }

        public Mascota() { }

        public Mascota(int pidCliente, string pnombre, string pespecie, string praza, string pcolor,string ppeso,string psexo,string psenasParticulares, string pfechaNacimiento,string pstatuss)
   
        {
            this.idCliente = pidCliente;
            this.nombre = pnombre;
            this.especie = pespecie;
            this.raza = praza;
            this.color = pcolor;
            this.peso = ppeso;
            this.sexo = psexo;
            this.senasParticulares = psenasParticulares;
            this.fechaNacimiento = pfechaNacimiento;
            this.statuss = pstatuss;
        }



    }
}
