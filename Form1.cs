using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculdoraVectorial
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        double i, j, k, ii, jj, kk;

        private void MultiplicacionBtn_Click(object sender, EventArgs e)
        {
            ITxt.Clear();
            JTxt.Clear();
            KTxt.Clear();
            IITxt.Clear();
            JJTxt.Clear();
            KKTxt.Clear();

            

            RVecLbl.Text = "";
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OtroBtn_Click(object sender, EventArgs e)
        {
           ITxt.Clear();
           JTxt.Clear();
           KTxt.Clear();
           IITxt.Clear();
           JJTxt.Clear();
           KKTxt.Clear();

           RVecLbl.Text = "";
        }

        private void RestaBtn_Click(object sender, EventArgs e)
        {

            double Restai;
            double Restaj;
            double Restak;

            i = Convert.ToDouble(ITxt.Text);
            j = Convert.ToDouble(JTxt.Text);
            k = Convert.ToDouble(KTxt.Text);
            ii = Convert.ToDouble(IITxt.Text);
            jj = Convert.ToDouble(JJTxt.Text);
            kk = Convert.ToDouble(KKTxt.Text);

            Restai = i - ii;
            Restaj = j - jj;
            Restak = k - kk;

            RVecLbl.Text = $" La suma de vectores fue: " + Restai + " i " + Restaj + " j " + Restak + " k ";

        }



        private void SumaBtn_Click(object sender, EventArgs e)
        {

            double Sumai;
            double Sumaj;
            double Sumak;

            i = Convert.ToDouble(ITxt.Text);
            j = Convert.ToDouble(JTxt.Text);
            k = Convert.ToDouble(KTxt.Text);
            ii = Convert.ToDouble(IITxt.Text);
            jj = Convert.ToDouble(JJTxt.Text);
            kk = Convert.ToDouble(KKTxt.Text);

            Sumai = i + ii;
            Sumaj = j + jj;
            Sumak = k + kk;

            RVecLbl.Text=$" La suma de vectores fue: " +Sumai + " i " +Sumaj + " j " +Sumak + " k ";

        }

        
    }
}
