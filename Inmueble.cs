using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia12
{
    public abstract class Inmueble
    {
       
        protected double _precio;
        protected string _direccion;
        protected double _area;
        protected int _zipcode;
        protected int _age;
        protected int _ventanas;
        
        
        public abstract double CalcularPrecio();
       
        public double Precio
        {
            get => _precio;
            set => _precio = value;

        }

        public string Direccion {
            get => _direccion; 
            set => _direccion = value;
        }
        public double Area { get => _area; set => _area = value; }
        public int ZipCode { get =>_zipcode; set =>_zipcode = value; }
        public int Age { get => _age; set => _age = value; }
        public int Ventanas { get => _ventanas; set => _ventanas = value; }


    }
}
