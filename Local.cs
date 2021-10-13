namespace Herencia12
{
    public class Local : Inmueble
    {
        override public double CalcularPrecio()
        {
            double calculated = 0;
            if (Area > 50)
            {
                calculated = calculated + Precio * 1.01;
            }

            if (Ventanas <= 1)
            {
                calculated = calculated + Precio - Precio * 0.02;
            }

            if (Ventanas > 4)
            {
                calculated = calculated + Precio * 1.02;
            }
            return calculated;
        }
    }
}