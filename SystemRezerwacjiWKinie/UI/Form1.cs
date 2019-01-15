using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using SystemRezerwacjiWKinie;

namespace UI
{
    public partial class Form1 : Form
    {
        List<Seans> lista_seansow;
        List<Rezerwacja> lista_rezerwacji= new List<Rezerwacja>();


        public Form1()
        {
            InitializeComponent();

            Film f1 = new Film("Bumblebee", new TimeSpan(0, 114, 0), "film o transformersach...");
            Film f2 = new Film("Harry Potter", new TimeSpan(0, 140, 0), "film o harrym potterze...");
            Film f3 = new Film("Kill Bill", new TimeSpan(0, 140, 0), "film quentina tarantnio...");
            Film f4 = new Film("Auta 2", new TimeSpan(0, 140, 0), "film o gadajacych autach...");

            Sala s1 = new Sala(8, 10);
            Sala s2 = new Sala(4, 6);

            lista_seansow = new List<Seans>();
            Seans sea11 = new Seans(f1, s1, new DateTime(2020, 01, 11, 14, 0, 0));
            lista_seansow.Add(sea11);
            Seans sea12 = new Seans(f2, s2, new DateTime(2020, 01, 11, 16, 0, 0));
            lista_seansow.Add(sea12);
            Seans sea21 = new Seans(f3, s1, new DateTime(2020, 01, 11, 17, 0, 0));
            lista_seansow.Add(sea21);
            Seans sea22 = new Seans(f4, s2, new DateTime(2020, 01, 11, 19, 0, 0));
            lista_seansow.Add(sea22);
            Seans sea31 = new Seans(f1, s1, new DateTime(2020, 01, 12, 12, 0, 0));
            lista_seansow.Add(sea31);
            Seans sea32 = new Seans(f2, s2, new DateTime(2020, 01, 12, 14, 0, 0));
            lista_seansow.Add(sea32);
            Seans sea41 = new Seans(f3, s1, new DateTime(2020, 01, 12, 19, 0, 0));
            lista_seansow.Add(sea41);
            Seans sea42 = new Seans(f4, s2, new DateTime(2020, 01, 12, 20, 0, 0));
            lista_seansow.Add(sea42);

            
            

            

            foreach (Seans s in lista_seansow)
            {
                comboBox1.Items.Add(s);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Klient k1 = new Klient(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text);

            Rezerwacja r1 = new Rezerwacja(k1, lista_seansow[comboBox1.SelectedIndex],(Int32)numericUpDown1.Value, (Int32)numericUpDown2.Value,false);
            if(checkbox_ulg.Checked)
            {
                r1.Ulga = true;
            }
            lista_rezerwacji.Add(r1);
            textBox5.Text = "Dodano rezerwacje:\r\n"+r1.ToString().Replace("\n", "\r\n");
            textBox5.Text += "\r\n"+lista_seansow[comboBox1.SelectedIndex].sala.ToString().Replace("\n", "\r\n");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = lista_seansow[comboBox1.SelectedIndex].sala.ToString().Replace("\n", "\r\n");
        }

        private void checkbox_ulg_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "Podsumowanie twoich rezerwacji:\r\n\r\n";
            foreach(Rezerwacja r in lista_rezerwacji)
            {
                textBox5.Text += r.ToString().Replace("\n", "\r\n")+ "\r\n\r\n";
            }
        }
    }
}
