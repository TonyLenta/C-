using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN;

   


namespace DAL
{
    public class MotocicletaDAL
    {
        //Creamor tres metodo

        //Metodo 1: ArrancarMotor este no contiene parametros
        public void ArrancarMotor()
        {


        }

        //Metodo 2: AgregarGas este contiene como parametro  galones
        public void AgregarGas(int galones)
        {


        }

        //Metodo 3: Conducir este va  contener dos parametros millas y velocidad
        public virtual int Conducir(int millas, int velocidad)
        {

            return 1;
        }
        //implementa la velocidad en la clase PuebaMoto
        public abstract double ObtenerVelocidadMax() { }
    }
}
