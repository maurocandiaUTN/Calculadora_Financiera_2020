using System;
using System.Windows.Forms;

namespace Calculadora_Financiera_2020
{
    public partial class Form1 : Form
    {

        double ope;
        double num1;
        double num2;
        double num3;
        double resultado = 0;
        double signo;




        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_pantalla.Text.IndexOf(".") > 0)
                {
                    Console.Beep();
                }
                else
                {
                    text_pantalla.Text = text_pantalla.Text + ".";
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

      


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void but_cero_Click(object sender, EventArgs e)
        {
            text_pantalla.Text = text_pantalla.Text + "0";
            text_VALOR1.Text = text_VALOR1.Text + "0";
           
        }

        private void but_uno_Click(object sender, EventArgs e)
        {
            text_pantalla.Text = text_pantalla.Text + "1";
            text_VALOR1.Text = text_VALOR1.Text + "1";
           
        }

        private void text_pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_dos_Click(object sender, EventArgs e)
        {
            text_pantalla.Text = text_pantalla.Text + "2";
            text_VALOR1.Text = text_VALOR1.Text + "2";
           
        }

        private void but_tres_Click(object sender, EventArgs e)
        {
            text_pantalla.Text = text_pantalla.Text + "3";
            text_VALOR1.Text = text_VALOR1.Text + "3";
            text_VALOR2.Text = text_VALOR2.Text + "3";
            text_VALOR3.Text = text_VALOR3.Text + "3";
        }

        private void but_cuatro_Click(object sender, EventArgs e)
        {
            text_pantalla.Text = text_pantalla.Text + "4";
            text_VALOR1.Text = text_VALOR1.Text + "4";
            text_VALOR2.Text = text_VALOR2.Text + "4";
            text_VALOR3.Text = text_VALOR3.Text + "4";
        }

        private void but_cinco_Click(object sender, EventArgs e)
        {
            text_pantalla.Text = text_pantalla.Text + "5";
            text_VALOR1.Text = text_VALOR1.Text + "5";
            text_VALOR2.Text = text_VALOR2.Text + "5";
            text_VALOR3.Text = text_VALOR3.Text + "5";
        }

        private void but_seis_Click(object sender, EventArgs e)
        {
            text_pantalla.Text = text_pantalla.Text + "6";
            text_VALOR1.Text = text_VALOR1.Text + "6";
            text_VALOR2.Text = text_VALOR2.Text + "6";
            text_VALOR3.Text = text_VALOR3.Text + "6";
        }
        private void but_siete_Click(object sender, EventArgs e)
        {
            text_pantalla.Text = text_pantalla.Text + "7";
            text_VALOR1.Text = text_VALOR1.Text + "7";
            text_VALOR2.Text = text_VALOR2.Text + "7";
            text_VALOR3.Text = text_VALOR3.Text + "7";
        }

        private void but_ocho_Click(object sender, EventArgs e)
        {
            text_pantalla.Text = text_pantalla.Text + "8";
            text_VALOR1.Text = text_VALOR1.Text + "8";
            text_VALOR2.Text = text_VALOR2.Text + "8";
            text_VALOR3.Text = text_VALOR3.Text + "8";
        }
        private void but_nueve_Click(object sender, EventArgs e)
        {
            text_pantalla.Text = text_pantalla.Text + "9";
            text_VALOR1.Text = text_VALOR1.Text + "9";
            text_VALOR2.Text = text_VALOR2.Text + "9";
            text_VALOR3.Text = text_VALOR3.Text + "9";
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            if (text_pantalla.TextLength >= 1)
            {
                text_pantalla.Text = text_pantalla.Text.Remove(text_pantalla.Text.Length - 1, 1);
            }
        }
        private void but_limpiar_Click(object sender, EventArgs e)
        {
            text_pantalla.Text = "";
            
        }
        private void but_signo_Click(object sender, EventArgs e)
        {

            signo = Convert.ToDouble(text_pantalla.Text);//paso el texto a double
            signo = signo - (signo * 2);
            text_pantalla.Text = signo.ToString();//paso el double a texto para que me demuestre el cambio de signo

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        //OPERACIONES BASICAS
        //SUMA
        private void but_mas_Click(object sender, EventArgs e)
        {
            ope = 1;
            num1 = Convert.ToDouble(text_pantalla.Text);

            text_pantalla.Clear();

         


        }

        //RESTA
        private void but_menos_Click(object sender, EventArgs e)
        {
            ope = 2;
            num1 = Convert.ToDouble(text_pantalla.Text);

            text_pantalla.Clear();

           
        }

        //MULTIPLICACION
        private void but_mult_Click(object sender, EventArgs e)
        {
            ope = 4;
            num1 = Convert.ToDouble(text_pantalla.Text);
            text_pantalla.Clear();

           
        }

        //DIVISION
        private void but_div_Click(object sender, EventArgs e)
        {
            ope = 3;
            num1 = Convert.ToDouble(text_pantalla.Text);
            text_pantalla.Clear();
           
        }


        //MEDIANTE LAS OPCIONES PREDETERMINADAS INGRESAMOS A LAS DISTINTAS OPERACIONES BASICAS 
        private void but_igual_Click(object sender, EventArgs e)
        {

            num2 = Convert.ToDouble(text_pantalla.Text);

            if (ope == 1)
            {
                resultado = num1 + num2;
                text_pantalla.Text = "SUMA = " + Convert.ToString(resultado);
                
            }
            else if (ope == 2)
            {
                resultado = num1 - num2;
                text_pantalla.Text = Convert.ToString(resultado);
                
            }
            else if (ope == 3)
            {
                resultado = num1 / num2;
                text_pantalla.Text = Convert.ToString(resultado);
               
            }
            else if (ope == 4)
            {
                resultado = num1 * num2;
                text_pantalla.Text = Convert.ToString(resultado);
              
            }

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void but_OPF_Click(object sender, EventArgs e)
        {
            string opf = comboBox_OP.Text;
         
            switch (opf)
            {

                case "INTERES SIMPLE":

                    

                        num1 = Convert.ToDouble(text_pantalla.Text);
                        
                        num2 = Convert.ToDouble(text_pantalla.Text);
                    
                        num3 = Convert.ToDouble(text_pantalla.Text);

                    resultado = num1 * num2 * num3;

                    text_pantalla.Text = "VA * n * i = " + resultado;
                   
                    break;
                case "INTERES COMPUESTO":

                    



                    break;
                case "DESCUENTO SIMPLE":
                    
                    
                    
                    
                    
                    
                    
                    break;
                default:
                    break;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_VALOR1_TextChanged(object sender, EventArgs e)
        {
    }
}

