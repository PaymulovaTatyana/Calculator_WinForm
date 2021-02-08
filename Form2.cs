using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;

namespace SimpleCalculator
{
    public partial class Form2 : SimpleCalculator.CalcUI
    {
        public Form2()
        {
            InitializeComponent();
        }

        protected void exponentiatoin_Click(object sender, EventArgs e)
        {
            Calculator.CalcEngine.CalcOperation(CalcEngine.Operator1.eexponentiatoin);
            
        }

        protected void ExtractSquare_Click(object sender, EventArgs e)
        {
            Calculator.CalcEngine.CalcOperation(CalcEngine.Operator1.eExtractSquare);

        }

        protected void Reverse_Click(object sender, EventArgs e)
        {
            Calculator.CalcEngine.CalcOperation(CalcEngine.Operator1.eReverse);
        }

        protected void SquareNumber_Click(object sender, EventArgs e)
        {
            Calculator.CalcEngine.CalcOperation(CalcEngine.Operator1.eSquareNumber);
        }


    }
}
