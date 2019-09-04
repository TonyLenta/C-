using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Vendedor:Persona
    {
        //Atributos
        private string tipoContrato;
        private Double sueldo;

        //Propiedades
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public string TipoContrato { get => tipoContrato; set => tipoContrato = value; }

        //Operaciones
        public void calcularSueldo(Double sueldoBase)
        {
            if(this.TipoContrato=="C")
            {
                this.Sueldo = sueldoBase + 350;
            }
            else if(this.TipoContrato=="N")
            {
                this.Sueldo = sueldo + 750;
            }
            else
            {
                this.sueldo = 0;
            }
        }
    }
}
