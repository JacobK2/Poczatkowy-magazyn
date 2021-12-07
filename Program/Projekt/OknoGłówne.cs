using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class OknoGłówne : Form
    {
        public OknoGłówne()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text== "")
            {
                MessageBox.Show("Proszę wpisać imię i nazwisko.");
                return;
            }

            Pracownik p = new Pracownik();
            p.Imie = textBox1.Text;
            p.Nazwisko = textBox2.Text;
            p.Wiek = (int)numericUpDown1.Value;
            p.Doświadczenie = checkBox1.Checked;
            Pracownik.ListaPracowników.Add(p);
            refreshPracownicy();
            refreshPrzedmioty();
        }

        void refreshPracownicy()
        {
            comboBox1.Items.Clear();
            dataGridView2.Rows.Clear();
            foreach (Pracownik p in Pracownik.ListaPracowników)
            {
                comboBox1.Items.Add(p);
                dataGridView2.Rows.Add(p.ObjTblPracownicy);
            }
        }

        void refreshPrzedmioty()
        {
            dataGridView1.Rows.Clear();
            foreach (Przedmiot p in Przedmiot.ListaWszystkichPrzedmiotów)
            {
                dataGridView1.Rows.Add(p.ObjTblPrzedmioty);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Przedmiot p = new Przedmiot((Pracownik)comboBox1.SelectedItem);
                if (textBox3.Text!="" && numericUpDown2.Value!=0)
                {
                    p.NazwaPrzedmiotu = textBox3.Text;
                    p.Waga = numericUpDown2.Value;
                    p.Delikatny = checkBox2.Checked;
                    Przedmiot.ListaWszystkichPrzedmiotów.Add(p);
                }
                else
                MessageBox.Show("Proszę wprowadzić nazwę składowanego przedmiotu i odpowiednią wagę.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proszę wskazać prawidłowe wartości. \n" +"("+ ex.Message+")");
            }
            
            refreshPracownicy();
            refreshPrzedmioty();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshPracownicy();
            refreshPrzedmioty();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Dniówka 120zł\nPremie dla pracowników: \nDoświadczenie w pracy 110% premii. \nWaga przedmiotu powyżej 50kg +2zł \nPrzedmiot delikatny +3zł \nPowyżej 15 przedmiotów +5zł");
        }
    }
}
