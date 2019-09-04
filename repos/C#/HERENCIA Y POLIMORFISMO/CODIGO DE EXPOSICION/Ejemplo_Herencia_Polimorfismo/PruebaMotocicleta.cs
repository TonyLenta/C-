using System;

 class PruebaMotocicleta : MotoCicleta {

    //LLamas al meotodo Obtener velocidad de la clase Motocicleta y le modifica el valor de la velcidad por 200.25
    public override double ObtenerVelocidad() {
        return 200.35;
            }

    //creamos el metodo principal para que se ejecute el programa
    static void Main() {
        int gas, millas, velocidad;
        PruebaMotocicleta moto = new PruebaMotocicleta();
        moto.ArrancarMoto();
        moto.AgregarGas();
        moto.Conducir(5,20);
        double velocidad = moto.ObtenerVelocidad();
        Console.WriteLine("My velocidad maxima es {0}", velocidad);

    }
}
