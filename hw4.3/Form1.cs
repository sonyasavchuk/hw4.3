using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw4._3
{
    public partial class Form1 : Form
    {
        abstract class Triangle
        {
            protected double a, b, alfa;
            public Triangle(double a,double b, double alfa)
            {
                this.a = a;
                this.b = b;
                this.alfa = alfa;
            }
            public virtual double Square()
            {
                return a * b * Math.Sin(alfa);
            }
            public virtual double Perimetr()
            {
                double c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(alfa));
                return (a + b + c);
            }
        }
        class Equ : Triangle
        {
            public Equ (double a ): base(a, a, Math.Sin(Math.PI / 3)) { }
            public override double Perimetr()
            {
                return 3*a;
            }
            public override double Square()
            {
                return base.Square();
            }
        }
        class SquareTr: Triangle
        {
            public SquareTr(double a, double b):base(a, b, Math.PI / 2) { }
            public override double Perimetr()
            {
                return base.Perimetr();
            }
            public override double Square()
            {
                return a*b;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            Equ t1 = new Equ(a);
            SquareTr t2 = new SquareTr(a, b);
            MessageBox.Show("for equ square = "+ t1.Square() + " perimetr = "
                +t1.Perimetr()+"\n for square triangle square = " + t2.Square()+ " perimetr = "+ t2.Perimetr());
        }
    }
}
