using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Calculator
{
    public partial class Calculator : Form
    {
        double FirstStep, SecondStep, Result;
        enum TOperation {add, subtract, multiply, divide};
        TOperation Operation;
        public Calculator()
        {
            InitializeComponent();
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            if (TxtTile.Text == "0")
                TxtTile.Text = "1";
            else
                TxtTile.Text += "1"; 
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            if (TxtTile.Text == "0")
                TxtTile.Text = "2";
            else
                TxtTile.Text += "2";
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            if (TxtTile.Text == "0")
                TxtTile.Text = "3";
            else
                TxtTile.Text += "3";
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            if (TxtTile.Text == "0")
                TxtTile.Text = "4";
            else
                TxtTile.Text += "4";
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            if (TxtTile.Text == "0")
                TxtTile.Text = "5";
            else
                TxtTile.Text += "5";
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            if (TxtTile.Text == "0")
                TxtTile.Text = "6";
            else
                TxtTile.Text += "6";
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            if (TxtTile.Text == "0")
                TxtTile.Text = "7";
            else
                TxtTile.Text += "7";
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            if (TxtTile.Text == "0")
                TxtTile.Text = "8";
            else
                TxtTile.Text += "8";
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            if (TxtTile.Text == "0")
                TxtTile.Text = "9";
            else
                TxtTile.Text += "9";
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            if (TxtTile.Text == "0")
                TxtTile.Text = "0";
            else
                TxtTile.Text += "0";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FirstStep = Convert.ToDouble(TxtTile.Text);
            TxtTile.Text = "0";
            Operation = TOperation.add;
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            FirstStep = Convert.ToDouble(TxtTile.Text);
            TxtTile.Text = "0";
            Operation = TOperation.subtract;
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            FirstStep = Convert.ToDouble(TxtTile.Text);
            TxtTile.Text ="0";
            Operation = TOperation.multiply;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            FirstStep = Convert.ToDouble(TxtTile.Text);
            TxtTile.Text = "0";
            Operation = TOperation.divide;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            SecondStep= Convert.ToDouble(TxtTile.Text);
            if (Operation == TOperation.add)
            {
                Result = (FirstStep + SecondStep);
                TxtTile.Text = Convert.ToString(Result);
                FirstStep = Result;
            }
            else if (Operation == TOperation.subtract)
            {
                Result = (FirstStep - SecondStep);
                TxtTile.Text = Convert.ToString(Result);
                FirstStep = Result;
            }
            else if (Operation == TOperation.multiply) 
            {
                Result = (FirstStep * SecondStep);
                TxtTile.Text = Convert.ToString(Result);
                FirstStep = Result;
            }
            else if (Operation == TOperation.divide) 
            {
                if (SecondStep == 0)
                {
                    TxtTile.Text = "Sıfıra bölemeyiz";
                }
                else
                {
                    Result = (FirstStep / SecondStep);
                    TxtTile.Text = Convert.ToString(Result);
                    FirstStep = Result;
                }
            }

        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtTile.Text = "0";
        }
    }
}
