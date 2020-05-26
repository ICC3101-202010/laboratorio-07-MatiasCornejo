using CalculadoraWindowForm.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindowForm
{
    public partial class tbxPantalla : Form
    {
        double Op1;//aca definimos la primera y segunda operacion en numeros que recibira la calculadora
        double Op2;
        string Operacion;//defino el strign que me reflejara la operacion que realizo

        List<string> Hist = new List<string>(); //creo una nueva lista donde guardare el historial de resultados

        double op3;//guara el ultimo valor alcanzado

        public tbxPantalla()
        {
            InitializeComponent();
        }

        //instanciamos nuestra carpeta de clases con los metodos que creamos

        Clases.Mult obj1 = new Clases.Mult();
        Clases.Div obj2 = new Clases.Div();
        Clases.Suma obj3 = new Clases.Suma();
        Clases.Resta obj4 = new Clases.Resta();

        private void button12_Click(object sender, EventArgs e)
        {
            tbxPant.Text = tbxPant.Text + "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Operacion = "-";
            Op1 = double.Parse(tbxPant.Text);// el primer valor que recibe la calculadora lo transformamos decimal
            tbxPant.Clear();//luego de escribir nuestro numero se limpiara la pantalla

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            tbxPant.Text = tbxPant.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {

            tbxPant.Text = tbxPant.Text + "1";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tbxPant.Text = tbxPant.Text + ".";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            tbxPant.Text = tbxPant.Text+"3";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tbxPant.Text = op3.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Operacion = "+";
            Op1 = double.Parse(tbxPant.Text);// el primer valor que recibe la calculadora lo transformamos decimal
            tbxPant.Clear();//luego de escribir nuestro numero se limpiara la pantalla
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Op2 = double.Parse(tbxPant.Text);
            double Mult;
            double Div;
            double Sum;
            double Rest;
            if (Operacion == "x")
            {
                Mult = obj1.Multi(Op1 ,Op2);  //creo la operacion si es que sale mult , lo hare analogo para todas las operaciones
                tbxPant.Text = Mult.ToString();
                op3 = Mult;
                Hist.Add(Mult.ToString());


            }
            else if (Operacion == "/")
            {
             
                Div = obj2.Divi(Op1, Op2);  //creo la operacion si es que sale mult , lo hare analogo para todas las operaciones
            

                if (Op2 != 0)
                {
                    tbxPant.Text = Div.ToString();
                    op3 = Div;
                    Hist.Add(Div.ToString());
                    
                }
                else if (Op2 == 0)
                {
                    tbxPant.Text = "match ERORR";
                    
                }
                
                

                
                


            }
            else if (Operacion == "+")
            {
                Sum = obj3.Sumar(Op1, Op2);  //creo la operacion si es que sale mult , lo hare analogo para todas las operaciones
                tbxPant.Text = Sum.ToString();
                op3 = Sum;
                Hist.Add(Sum.ToString());

            }
            else if (Operacion == "-")
            {
                Rest = obj4.Restar(Op1, Op2);  //creo la operacion si es que sale mult , lo hare analogo para todas las operaciones
                tbxPant.Text = Rest.ToString();
                op3 = Rest;
                Hist.Add(Rest.ToString());
            
            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            tbxPant.Text = tbxPant.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbxPant.Text = tbxPant.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tbxPant.Text = tbxPant.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Operacion = "x";
            Op1 = double.Parse(tbxPant.Text);// el primer valor que recibe la calculadora lo transformamos decimal
            tbxPant.Clear();//luego de escribir nuestro numero se limpiara la pantalla
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Operacion = "/";
            Op1 = double.Parse(tbxPant.Text);// el primer valor que recibe la calculadora lo transformamos decimal
            tbxPant.Clear();//luego de escribir nuestro numero se limpiara la pantalla
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbxPant.Text = tbxPant.Text + "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbxPant.Text = tbxPant.Text + "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxPant.Text = tbxPant.Text + "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbxPant.Text.Length == 1)
                tbxPant.Text = "";
            else
                tbxPant.Text = tbxPant.Text.Substring(0, tbxPant.Text.Length - 1);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbxPant.Clear();


        }

        private void btnhist_Click(object sender, EventArgs e)
        {
            ventanahist ventanahist = new ventanahist();
            ventanahist.Show();


        }
    }
}
