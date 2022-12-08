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
        enum TOperation { Add, Subtract, Multiply, Divide };
        TOperation Operation;
        public Calculator()
        {
            InitializeComponent();
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            WriteNumber("1");
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            WriteNumber("2");
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            WriteNumber("3");
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            WriteNumber("4");
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            WriteNumber("5");
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            WriteNumber("6");
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            WriteNumber("7");
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            WriteNumber("8");
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            WriteNumber("9");
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            if (TxtTile.Text != "0")
                TxtTile.Text += "0";
        }
        private void BtnPoint_Click(object sender, EventArgs e)
        {
                TxtTile.Text += ",";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddOperation('+');
            Operation = TOperation.Add;
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            AddOperation('-');
            Operation = TOperation.Subtract;
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            AddOperation('*');
            Operation = TOperation.Multiply;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            AddOperation('/');
            Operation = TOperation.Divide;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            SecondStep = Convert.ToDouble(TxtTile.Text);
            switch (Operation)
            {
                case TOperation.Add:
                    Result = (FirstStep + SecondStep);
                    EqualOperation();
                    break;
                case TOperation.Subtract:
                    Result = (FirstStep - SecondStep);
                    EqualOperation();
                    break;
                case TOperation.Multiply:
                    Result = (FirstStep * SecondStep);
                    EqualOperation();
                    break;
                case TOperation.Divide:
                    if (SecondStep == 0)
                        TxtTile.Text = "Cannot divide by zero";
                    else
                    {
                        Result = (FirstStep / SecondStep);
                        EqualOperation();
                    }
                    break;
                default:
                    break;
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtTile.Text = "0";
            FirstStep = 0;
            SecondStep = 0;
        }

        public void WriteNumber(string Number)
        {
            if (TxtTile.Text == "0")
                TxtTile.Text = Number;
            else
                TxtTile.Text += Number;
        }
        public void AddOperation(char Operator)
        {
            FirstStep = Convert.ToDouble(TxtTile.Text);
            TxtTile.Text = "0";
            LblUp.Text = FirstStep.ToString() + Operator;
        }
        public void EqualOperation() 
        {
            TxtTile.Text = Convert.ToString(Result);
            FirstStep = Result;
            LblUp.Text += SecondStep.ToString();
        }
    }
}
