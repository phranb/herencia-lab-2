using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia12
{
    public partial class Form1 : Form
    {
        public int type = 0;
        private bool _npiso;
        private bool _ventanas;
        private bool _direccion;
        private bool _area;
        private bool _preciobase;
        private bool _npisoForm;
        
        public Form1()
        {
            InitializeComponent();
        }

        
        Piso myPiso = new Piso();
        Local myLocal = new Local();

        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = 1;
            textBox1.Enabled = true;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type = 2;
            textBox1.Enabled = false;
        }

        // numero de piso
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (type)
            {
                case 1:
                    try
                    {
                        myPiso.NPiso = Convert.ToInt32(textBox1.Text);
                    }
                    catch (Exception)
                    {
                
                    }
                   
                    break;
                case 2:
                    
                    break;
                
            }
        }

        //ventanass
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            switch (type)
            {
                case 1:
                    try
                    {
                        myPiso.Ventanas = Convert.ToInt32(textBox2.Text);
                    }
                    catch (Exception)
                    {
                    }
                    break;
                case 2:
                    try
                    {
                        myLocal.Ventanas = Convert.ToInt32(textBox2.Text);
                    }
                    catch (Exception)
                    {
                    }

                    break;
                
            }
            
         

            

        }
        //direccion
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            switch (type)
            {
                case 1:
                    try
                    {
                        myPiso.Direccion = textBox3.Text;
                    }
                    catch (Exception)
                    {
                    }

                    break;
                case 2:
                    try
                    {
                        myLocal.Direccion = textBox3.Text;
                    }
                    catch (Exception)
                    {
                    }

                    break;
            }
            
        }
        // area
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            switch (type)
            {
                case 1:
                    try
                    {
                        myPiso.Area = Convert.ToDouble(textBox4.Text);
                    }
                    catch (Exception)
                    {
                    }

                    break;
                case 2:
                    try
                    {
                        myLocal.Area = Convert.ToDouble(textBox4.Text);
                    }
                    catch (Exception)
                    {
                    }

                    break;
                
            }
            
        }

        // antiguedad
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            switch (type)
            { case 1:
                try
                {
                    myPiso.Age = Convert.ToInt32(textBox5.Text);
                }
                catch (Exception)
                {
                
                }

                break;
            case 2:
                try
                {
                    myLocal.Age = Convert.ToInt32(textBox5.Text);
                }
                catch (Exception)
                {
                
                }

                break;
                
            }
            
        }

        // precio base
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            switch (type)
            { case 1:
                try
                {

                    myPiso.Precio = Convert.ToDouble(textBox6.Text);
                }
                catch (Exception)
                {
                
                }

                break;
            case 2:
                try
                {

                    myLocal.Precio = Convert.ToDouble(textBox6.Text);
                }
                catch (Exception)
                {
                
                }

                break;
                
            }

            
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            // resultado es label7

            if (type == 1)
            {
                textBox7.Text = Convert.ToString(myPiso.CalcularPrecio());
            }
            if (type == 2)
            {
                textBox7.Text = Convert.ToString(myLocal.CalcularPrecio());
            }
        }
    }
}
