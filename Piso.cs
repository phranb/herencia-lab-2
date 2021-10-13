using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia12
{
    class Piso : Inmueble
    {
        private int _npiso;
      

        public int NPiso
        {
            get => _npiso;
            set => _npiso = value;
        }
        
        override public double CalcularPrecio()
        {
            double calculated = 0;
            if (Age < 15)
            {
                calculated = calculated + Precio - Precio * 0.01;
            }

            if (Age > 15)
            {
                calculated = calculated + Precio - Precio * 0.02;
            }

            if (NPiso >= 3)
            {
                calculated = calculated + Precio + Precio * 0.02;
            }
            
            return calculated;
        }
    }
}
