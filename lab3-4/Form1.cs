using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string Data_poczatek = monthCalendar3.SelectionRange.Start.Date.ToString("yyyy-MM-dd");
            string Data_koniec = monthCalendar4.SelectionRange.Start.Date.ToString("yyyy-MM-dd");

           
          
            
            string[] tablica = new string[10];




            textBox2.Text = Data_poczatek;
            textBox2.Text += Environment.NewLine + Data_koniec;
            
        }
    }
}
