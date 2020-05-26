using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindowForm.Clases
{
    public partial class ventanahist : Form
    {
        
        public ventanahist()
        {
            InitializeComponent();
        }

        Clases.Mult obj1 = new Clases.Mult();
        Clases.Div obj2 = new Clases.Div();
        Clases.Suma obj3 = new Clases.Suma();
        Clases.Resta obj4 = new Clases.Resta();


        public IEnumerable<string> Hist { get; private set; }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (string x in Hist) 
            {
                lsthist.Items.Add(x);
            }

            
        }
    }
}
