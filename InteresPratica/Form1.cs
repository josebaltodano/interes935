using App.Core.Iserveices;
using Domain.interes.Entities;
using Domain.interes.Enum;
using Infraestructure.interes.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteresPratica
{
    public partial class Form1 : Form
    {
        public IINteresServices iNteresServices;
        private static double E = 0;
        public Form1(IINteresServices iNteres)
        {
            
            InitializeComponent();
            this.comboBox1.Items.AddRange(Enum.GetValues(typeof(Producto)).Cast<object>().ToArray());
            this.iNteresServices = iNteres;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public double  ConvertM()
        {

            if (comboBox1.SelectedIndex == 0)
            {
                double M = 1;
                return M;
            }
            else
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    return 4;
                }
                else
                {
                    if (comboBox1.SelectedIndex == 2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (comboBox1.SelectedIndex == 3)
                        {
                            return 12;
                        }
                        else
                        {
                            if (comboBox1.SelectedIndex == 4)
                            {
                                return 2;
                            }
                            else
                            {
                                if (comboBox1.SelectedIndex == 5)
                                {
                                    return 52;
                                }
                                else
                                {
                                    return -1;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m =ConvertM();
            label1.Text = iNteresServices.Getfuturo(double.Parse(textBox4.Text), m, double.Parse(textBox1.Text), double.Parse(textBox3.Text)).ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("NO SE PUEDEN LETRAS");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }
    }
}
