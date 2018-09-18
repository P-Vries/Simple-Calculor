using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    public partial class frmRekenmachine : Form
    {
        public bool isFirst = true;
        public bool isSecond = false;
        public bool isFirstCijfer = true;
        public double cijfer01;
        public double cijfer02;
        public double cijfer03;
        private double prevAns;
        public bool Plus;
        public bool Min;
        public bool Deel;
        public bool Keer;

        public frmRekenmachine()
        {
            InitializeComponent();
        }

        //
        //Methodes
        //
        private void Cijfer01()
        {
            if (isFirst)
            {
                try { cijfer01 = double.Parse(txbIO.Text); }
                catch (Exception e) { MessageBox.Show("ERROR" + e); }
                isFirst = false;
                isSecond = true;
                Clear();
            }
            if (isSecond)
            {
                isFirst = true;
                isSecond = false;
                Clear();
            }
        }
        private void Verwijder()
        {
            Clear();
            cijfer01 = 0;
            cijfer02 = 0;
        }
        private void Clear()
        {
            txbIO.Text = "0";
            isFirstCijfer = true;
        }
        private void Clean()
        {
            cijfer01 = 0;
            cijfer02 = 0;
            isFirstCijfer = true;
        }
        private void IOPlus()
        {
            if (txbIO.Text.Length > 13)
            {
                txbIO.Text = txbIO.Text.Remove(0, 1);
            }
        }
        private void AddCijfer(char inputCijfer)
        {
            if (isFirst)
            {
                if (isFirstCijfer)
                {
                    txbIO.Text = inputCijfer.ToString();
                    isFirstCijfer = false;
                }
                else { txbIO.Text = txbIO.Text + inputCijfer.ToString(); IOPlus(); }
            }
            if (isSecond)
            {
                if (isFirstCijfer)
                {
                    txbIO.Text = inputCijfer.ToString();
                    isFirstCijfer = false;
                }
                else { txbIO.Text = txbIO.Text + inputCijfer.ToString(); IOPlus(); }
            }

        }
        private void Antwoordt()
        {
            try { cijfer02 = double.Parse(txbIO.Text); }
            catch (Exception e) { MessageBox.Show("ERROR" + e); }
            if (Plus)
            {
                cijfer03 = cijfer01 + cijfer02;
                isFirst = true;
                isSecond = false;
                Plus = false;
            }
            if (Min)
            {
                cijfer03 = cijfer01 - cijfer02;
                isFirst = true;
                isSecond = false;
                Min = false;
            }
            if (Keer)
            {
                cijfer03 = cijfer01 * cijfer02;
                isFirst = true;
                isSecond = false;
                Keer = false;
            }
            if (Deel)
            {
                cijfer03 = cijfer01 / cijfer02;
                isFirst = true;
                isSecond = false;
                Deel = false;
            }
            Clean();
            txbIO.Text = cijfer03.ToString();
            prevAns = cijfer03;
            cijfer03 = 0;
        }

        //
        //In/Out
        //
        private void btn1_Click(object sender, EventArgs e)
        {
            AddCijfer('1');
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AddCijfer('2');
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddCijfer('3');
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddCijfer('4');
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddCijfer('5');
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddCijfer('6');
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddCijfer('7');
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddCijfer('8');
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddCijfer('9');
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AddCijfer('0');
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            AddCijfer(',');
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Verwijder();
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            Cijfer01();
            Plus = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Cijfer01();
            Min = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Antwoordt();
        }

        private void btnKeer_Click(object sender, EventArgs e)
        {
            Cijfer01();
            Keer = true;
        }

        private void btnDeel_Click(object sender, EventArgs e)
        {
            Cijfer01();
            Deel = true;
        }


    }
}

//
// Input
//      -Cijfers
//      -Plus, Min etc.
//
//Output
//      -Temp-Antwoord
//      -Antwoord
//
//
//
//
//
//
//
//