using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pssc
{
    public partial class Form1 : Form
    {  

        List<Facultate> Facultati = new List<Facultate>();
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facultati.Add(new Facultate(textBox1.Text));
            ShowFac();
        }
        public void ShowFac() 
        {
            label1.Text = "";
            foreach (Facultate f in Facultati)
            {
                label1.Text += f.nume_fac + "\n";

            }
        }
    }
    public class Facultate
    {
        
        public string nume_fac { set; get; }
        List<Studenti> studenti = new List<Studenti>();
        public Facultate(string nume)
        {
            nume_fac = nume;
        }
    }
    public class Studenti
    {
     
        private string nume_stud { set; get; }
        public Catalog catalog { set; get; }
        public Studenti(string nume_sutd)
        {
            this.nume_stud = nume_stud;

        }


    }
    public class Profesori
    {
        private string nume_profi { set; get; }

        public Profesori(string nume_profi)
        {
            this.nume_profi = nume_profi;
        }

    }
   
    }


