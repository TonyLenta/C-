using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp23
{
    public class Perro
    {
        //Atributos
        private String nombre;
        private String raza;
        private String altura;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public string Altura { get => altura; set => altura = value +"cm"; }

        //Operaciones
        public String comer(String carne)
        {
            return this.Nombre + " mide " + this.Altura + " y va a comer " + carne;
        }
        public void dormir()
        {

        }
        public void ladrar()
        {

        }
        //Constructor
        public Perro()
        {

        }
        public Perro(String nombre, String raza, String altura)
        {
            this.Nombre = nombre;
            this.Raza = raza;
            this.Altura = altura;

        }
    }
}
