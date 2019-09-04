using System;

abstract class MotoCicleta
{
    //Creamor tres metodo

        //Metodo 1: ArrancarMotor este no contiene parametros
    public void ArrancarMotor() {


    }

    //Metodo 2: AgregarGas este contiene como parametro  galones
    public void AgregarGas(int galones) {

        if (galones < 2)
            MessageBox.Show("Conbustible bajo");
        else MessageBox.Show("Buen conbustible");

    }

    //Metodo 3: Conducir este va  contener dos parametros millas y velocidad
    public virtual int Conducir(int millas,int velocidad)    {

        return 1;
    }
    //implementa la velocidad en la clase PuebaMoto
    public virtual double ObtenerVelocidadMax() { }

}
