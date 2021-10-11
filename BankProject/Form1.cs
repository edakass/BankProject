using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace BankProject
{
    partial class Form1 : MetroForm{
        
        
        //public partial 
    
        public Form1()
        {
            InitializeComponent();
        }
        Banka banka = new Banka();

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormGiris formGiris = new FormGiris(banka);
            formGiris.TopLevel = false;
            panel1.Controls.Add(formGiris);
            formGiris.Show();
            formGiris.Dock = DockStyle.Fill; //Dock özelliği ile tüm ekranı kaplayacak şekilde ayarlıyoruz(Fill ile).



        }
    }
}
