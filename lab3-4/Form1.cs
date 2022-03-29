using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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
        public kantor context = new kantor();

        async void polaczenie_API(string wybrana_data) 
        {
            string call = "https://openexchangerates.org/api/historical/" + wybrana_data + ".json?app_id=ad43c3ac08cd40948da0f20581ce08ff";
            //textBox2.Text = call;
           // string call = "https://openexchangerates.org/api/historical/2012-07-10.json?app_id=ad43c3ac08cd40948da0f20581ce08ff";
            HttpClient httpclient = new HttpClient();
            string response = await httpclient.GetStringAsync(call);
           // textBox2.Text = response;
             Waluty waluty = JsonConvert.DeserializeObject<Waluty>(response);
              
               textBox2.Text += "wartosc z " + wybrana_data + ": " + waluty.rates["PLN"] + Environment.NewLine;



            context.Baza_Danych.Add(new info_walut {DataDb = wybrana_data, WartoscDb = waluty.rates["PLN"].ToString() });

        }














        private void button2_Click(object sender, EventArgs e)
        {

            string Data_poczatek = monthCalendar3.SelectionRange.Start.Date.ToString("yyyy-MM-dd");
            string Data_koniec = monthCalendar4.SelectionRange.Start.Date.ToString("yyyy-MM-dd");
            var Data_pocz = monthCalendar3.SelectionRange.Start.Date;
            var Data_kon = monthCalendar4.SelectionRange.Start.Date;


            string[] tablica = new string[10];


            List<string> data = new List<string>();
   
            
            while (Data_pocz <= Data_kon)
            { 
                Data_poczatek = Data_pocz.ToString("yyyy-MM-dd");

                polaczenie_API(Data_poczatek);

                data.Add(Data_poczatek);
                Data_pocz = Data_pocz.AddDays(1);
            }
            //foreach (string daty in data) {textBox2.Text += daty + Environment.NewLine;}
            context.SaveChanges();

            var info = context.Baza_Danych.SqlQuery("select * from Baza_Danych").ToList<info_walut>();
            textBox1.Text += info.ToString() + Environment.NewLine;
        }
    }
}
