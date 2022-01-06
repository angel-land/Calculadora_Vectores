using System;
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



            ResultLbl.Text = "";
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void OtroBtn_Click(object sender, EventArgs e)
        {
            ITxt.Clear();
            JTxt.Clear();
            KTxt.Clear();
            IITxt.Clear();
            JJTxt.Clear();
            KKTxt.Clear();

            ResultLbl.Text = "";
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

            ResultLbl.Text = $" La suma de vectores fue: " + Restai + " i " + Restaj + " j " + Restak + " k ";

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

            ResultLbl.Text = $" La suma de vectores fue: " + Sumai + " i " + Sumaj + " j " + Sumak + " k ";

        }

        private void CoordCilindBtn_Click(object sender, EventArgs e)
        {
            double coordx;
            double coordy;
            double coordz;

            i = Convert.ToDouble(ITxt.Text);
            j = Convert.ToDouble(JTxt.Text);
            k = Convert.ToDouble(KTxt.Text);
            ii = Convert.ToDouble(IITxt.Text);
            jj = Convert.ToDouble(JJTxt.Text);
            kk = Convert.ToDouble(KKTxt.Text);

            coordx = Math.Sin(i); // conv x a radio
            coordy = Math.Cos(j); //y a angulo 
            coordz = k; //z = z

            ResultLbl.Text = $"(" + coordx + ", " + coordy + ", " + coordz + ")";

        }
        private void CoordRectBtn_Click(object sender, EventArgs e)
        {
            double coordx;
            double coordy;
            double coordz;

            i = Convert.ToDouble(ITxt.Text);
            j = Convert.ToDouble(JTxt.Text);
            k = Convert.ToDouble(KTxt.Text);
            ii = Convert.ToDouble(IITxt.Text);
            jj = Convert.ToDouble(JJTxt.Text);
            kk = Convert.ToDouble(KKTxt.Text);

            coordx = Math.Pow(Math.Pow(i, 2.0) + Math.Pow(j, 2.0), 2); //r^2=x^2+y^2
            coordy = Math.Atan(j / i); //tan(angulo)=y/c
            coordz = k;

            ResultLbl.Text = $"(" + coordx + ", " + coordy + ", " + coordz + ")";
        }

    }
}
