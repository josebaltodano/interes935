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
            this.cmbcapital.Items.AddRange(Enum.GetValues(typeof(Producto)).Cast<object>().ToArray());
            this.iNteresServices = iNteres;
            this.cmbactual.Items.AddRange(Enum.GetValues(typeof(Producto)).Cast<object>().ToArray());
            this.cmbdespues.Items.AddRange(Enum.GetValues(typeof(Producto)).Cast<object>().ToArray());
            txtpresente.Visible = false;
            llbpresente.Visible = false;
            txtfuturo.Visible = false;
            lblfuturo.Visible = false;
            lblinteres.Visible = false;
            txtinteres.Visible = false;
            txtxaños.Visible = false;
            lblaños.Visible = false;
            llbcapital.Visible = false;
            cmbcapital.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public double  ConvertM()
        {

            if (cmbcapital.SelectedIndex == 0)
            {
                double M = 1;
                return M;
            }
            else
            {
                if (cmbcapital.SelectedIndex == 1)
                {
                    return 4;
                }
                else
                {
                    if (cmbcapital.SelectedIndex == 2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (cmbcapital.SelectedIndex == 3)
                        {
                            return 12;
                        }
                        else
                        {
                            if (cmbcapital.SelectedIndex == 4)
                            {
                                return 2;
                            }
                            else
                            {
                                if (cmbcapital.SelectedIndex == 5)
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
            if (string.IsNullOrEmpty(txtfuturo.Text) || string.IsNullOrEmpty(txtpresente.Text) || string.IsNullOrEmpty(txtinteres.Text))
            {
                MessageBox.Show("Tienes que rellenar todos los formularios.");
                return;
            }
            if (double.Parse(txtfuturo.Text) >= 0
                || double.Parse(txtpresente.Text) >= 0
                || double.Parse(txtinteres.Text) >= 0
                || double.Parse(txtxaños.Text) >= 0)
            {
                MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                return;
            }
            //validar();
            double m =ConvertM();
            //label1.Text = iNteresServices.Getfuturo(double.Parse(textBox4.Text), m, double.Parse(txtpresente.Text), double.Parse(textBox3.Text)).ToString();
          
            label1.Text = iNteresServices.GeTPeriodo(double.Parse(txtinteres.Text),m,double.Parse(txtpresente.Text),double.Parse(txtfuturo.Text)).ToString();
        }
        //public void validar()
        //{
        //    if (string.IsNullOrEmpty(txtfuturo.Text) || string.IsNullOrEmpty(txtpresente.Text) || string.IsNullOrEmpty(txtinteres.Text))
        //    {
        //        MessageBox.Show("Tienes que rellenar todos los formularios.");
        //        return;
        //    }
        //    if (double.Parse(txtfuturo.Text) >= 0
        //        || double.Parse(txtpresente.Text) >= 0
        //        || double.Parse(txtinteres.Text) >= 0
        //        || double.Parse(txtxaños.Text) >= 0)
        //    {
        //        MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
        //        return;
        //    }
        //}

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
            Interes interes = new Interes
            {
                nominal = Convert.ToDouble(texnominal.Text)
            };
            label7.Text = iNteresServices.ConvertEfectiva(interes).ToString();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Interes inte = new Interes()
            {
                nominal = Convert.ToDouble(textBox7.Text),
            };
            label14.Text = iNteresServices.ConvertExponencial(inte).ToString();
        }

        private void cmbmostrasr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbmostrasr.SelectedIndex == 0)
            {
                 txtfuturo.Visible = false;
                lblfuturo.Visible = false;
                txtpresente.Visible = true;
                llbpresente.Visible = true;
                lblinteres.Visible = true;
                txtinteres.Visible = true;
                txtxaños.Visible = true;
                lblaños.Visible = true;
                llbcapital.Visible = true;
                cmbcapital.Visible = true;

            }
            else
            {
                if(cmbmostrasr.SelectedIndex == 1)
                {
                    txtpresente.Visible = false;
                    llbpresente.Visible = false;
                    txtfuturo.Visible = true;
                    lblfuturo.Visible = true;
                    lblinteres.Visible = true;
                    txtinteres.Visible = true;
                    txtxaños.Visible = true;
                    lblaños.Visible = true;
                    llbcapital.Visible = true;
                    cmbcapital.Visible = true;
                }
                else
                {
                    if(cmbmostrasr.SelectedIndex == 2)
                    {
                        txtpresente.Visible = true;
                        llbpresente.Visible = true;
                        txtfuturo.Visible = true;
                        lblfuturo.Visible = true;
                        lblinteres.Visible = true;
                        txtinteres.Visible = true;
                        txtxaños.Visible = false;
                        lblaños.Visible = false;
                        llbcapital.Visible = true;
                        cmbcapital.Visible = true;
                    }
                    else
                    {
                        if(cmbmostrasr.SelectedIndex == 3)
                        {
                            txtpresente.Visible = false;
                            llbpresente.Visible = false;
                            txtfuturo.Visible = false;
                            lblfuturo.Visible = false;
                            lblinteres.Visible = false;
                            txtinteres.Visible = false;
                            txtxaños.Visible = false;
                            lblaños.Visible = false;
                            llbcapital.Visible = false;
                            cmbcapital.Visible = false;


                        }
                    }
                }
            }
        }
    }
}
