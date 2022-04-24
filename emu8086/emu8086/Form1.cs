using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emu8086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //all methods

        private void generateHex()          //generate random hex numbers
        {
            Random generate = new Random();
            textBoxAx.Text = generate.Next(0, 65535).ToString("X");
            textBoxBx.Text = generate.Next(0, 65535).ToString("X");
            textBoxCx.Text = generate.Next(0, 65535).ToString("X");
            textBoxDx.Text = generate.Next(0, 65535).ToString("X");

        }

        private void moveInstruction() //simulates the move instruction in Intel 8086

        {

            if (axFromButton.Checked && bxToButton.Checked)     //ax move instruction    
            {
                textBoxBx.Text = textBoxAx.Text;
            }
            else if (axFromButton.Checked && cxToButton.Checked)
            {
                textBoxCx.Text = textBoxAx.Text;
            }
            else if (axFromButton.Checked && dxToButton.Checked)
            {
                textBoxDx.Text = textBoxAx.Text;
            }


            if (bxFromButton.Checked && axToButton.Checked)     //bx move instuction
            {
                textBoxAx.Text = textBoxBx.Text;
            }
            else if (bxFromButton.Checked && cxToButton.Checked)
            {
                textBoxCx.Text = textBoxBx.Text;
            }
            else if (bxFromButton.Checked && dxToButton.Checked)
            {
                textBoxDx.Text = textBoxBx.Text;
            }

            

            if (cxFromButton.Checked && axToButton.Checked)     //cx move insturction
            {
                textBoxAx.Text = textBoxCx.Text;
            }
            else if (cxFromButton.Checked && bxToButton.Checked)
            {
                textBoxBx.Text = textBoxCx.Text;
            }
            else if (cxFromButton.Checked && dxToButton.Checked)
            {
                textBoxDx.Text = textBoxCx.Text;
            }
            

            if (dxFromButton.Checked && axToButton.Checked)     //dx move instrctuin
            {
                textBoxAx.Text = textBoxDx.Text;
            }
            else if (dxFromButton.Checked && bxToButton.Checked)
            {
                textBoxBx.Text = textBoxBx.Text;
            }
            else if (dxFromButton.Checked && cxToButton.Checked)
            {
                textBoxCx.Text = textBoxDx.Text;
            }
        }

        private void xchgInstruction()      //simulate the xchg instruction in Intel 8086
        {

            if (axFromButton.Checked && bxToButton.Checked)     //ax xchg intruction
            {
                string x1 = textBoxAx.Text;
                string x2 = textBoxBx.Text;
                textBoxAx.Text = x2;
                textBoxBx.Text = x1;
            }
            else if (axFromButton.Checked && cxToButton.Checked)
            {
                string x1 = textBoxAx.Text;
                string x2 = textBoxCx.Text;
                textBoxAx.Text = x2;
                textBoxCx.Text = x1;
            }
            else if (axFromButton.Checked && dxToButton.Checked)
            {
                string x1 = textBoxAx.Text;
                string x2 = textBoxDx.Text;
                textBoxAx.Text = x2;
                textBoxDx.Text = x1;
            }


            if (bxFromButton.Checked && axToButton.Checked)     //bx xchg intruction
            {
                string x1 = textBoxBx.Text;
                string x2 = textBoxAx.Text;
                textBoxBx.Text = x2;
                textBoxAx.Text = x1;
            }
            else if (bxFromButton.Checked && cxToButton.Checked)
            {
                string x1 = textBoxBx.Text;
                string x2 = textBoxCx.Text;
                textBoxBx.Text = x2;
                textBoxCx.Text = x1;
            }
            else if (bxFromButton.Checked && dxToButton.Checked)
            {
                string x1 = textBoxBx.Text;
                string x2 = textBoxDx.Text;
                textBoxBx.Text = x2;
                textBoxDx.Text = x1;
            }

            if (cxFromButton.Checked && axToButton.Checked)     //cx xchg intruction
            {
                string x1 = textBoxCx.Text;
                string x2 = textBoxAx.Text;
                textBoxCx.Text = x2;
                textBoxAx.Text = x1;
            }
            else if (cxFromButton.Checked && bxToButton.Checked)
            {
                string x1 = textBoxCx.Text;
                string x2 = textBoxBx.Text;
                textBoxCx.Text = x2;
                textBoxBx.Text = x1;
            }
            else if (cxFromButton.Checked && dxToButton.Checked)
            {
                string x1 = textBoxCx.Text;
                string x2 = textBoxDx.Text;
                textBoxCx.Text = x2;
                textBoxDx.Text = x1;
            }

            if (dxFromButton.Checked && axToButton.Checked)     //dx xchg intruction
            {
                string x1 = textBoxDx.Text;
                string x2 = textBoxAx.Text;
                textBoxDx.Text = x2;
                textBoxAx.Text = x1;
            }
            else if (dxFromButton.Checked && bxToButton.Checked)
            {
                string x1 = textBoxDx.Text;
                string x2 = textBoxBx.Text;
                textBoxDx.Text = x2;
                textBoxBx.Text = x1;
            }
            else if (dxFromButton.Checked && cxToButton.Checked)
            {
                string x1 = textBoxDx.Text;
                string x2 = textBoxCx.Text;
                textBoxDx.Text = x2;
                textBoxCx.Text = x1;
            }





        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            generateHex();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            moveInstruction();
        }

        private void xchgButton_Click(object sender, EventArgs e)
        {
            xchgInstruction();

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
