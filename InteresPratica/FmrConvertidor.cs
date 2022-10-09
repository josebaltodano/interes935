using App.Core.Iserveices;
using Domain.interes.Enum;
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
    public partial class FmrConvertidor : Form
    {
        public IINteresServices iNteresServices;
        public FmrConvertidor(IINteresServices  iNteres)
        {
            InitializeComponent();
            this.iNteresServices = iNteres;
            this.cmbactual.Items.AddRange(Enum.GetValues(typeof(Producto)).Cast<object>().ToArray());
            this.cmbdespues.Items.AddRange(Enum.GetValues(typeof(Producto)).Cast<object>().ToArray());
            this.cmbnominal.Items.AddRange(Enum.GetValues(typeof(Producto)).Cast<object>().ToArray());
            this.cmbactual.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbdespues.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbnominal.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void texnominal_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("NO SE PUEDEN LETRAS");
                }
            }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("NO SE PUEDEN LETRAS");
            }
        }

        private void txtxotranominal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtxotranominal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("NO SE PUEDEN LETRAS");
            }
        }

        private void txtefectivacontinua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("NO SE PUEDEN LETRAS");
            }
        }

        public double capitalizable()
        {

            if (cmbactual.SelectedIndex == 0)
            {
                
                return 1;
            }
            else
            {
                if (cmbactual.SelectedIndex == 1)
                {
                    return 4;
                }
                else
                {
                    if (cmbactual.SelectedIndex == 2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (cmbactual.SelectedIndex == 3)
                        {
                            return 12;
                        }
                        else
                        {
                            if (cmbactual.SelectedIndex == 4)
                            {
                                return 2;
                            }
                            else
                            {
                                if (cmbactual.SelectedIndex == 5)
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
        public double cmxd()
        {
            if (cmbnominal.SelectedIndex == 0)
            {
               
                return 1;
            }
            else
            {
                if (cmbnominal.SelectedIndex == 1)
                {
                    return 4;
                }
                else
                {
                    if (cmbnominal.SelectedIndex == 2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (cmbnominal.SelectedIndex == 3)
                        {
                            return 12;
                        }
                        else
                        {
                            if (cmbnominal.SelectedIndex == 4)
                            {
                                return 2;
                            }
                            else
                            {
                                if (cmbnominal.SelectedIndex == 5)
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
        public double ConvertM1()
        {

            if (cmbdespues.SelectedIndex == 0)
            {
                double M1 = 1;
                return M1;
            }
            else
            {
                if (cmbdespues.SelectedIndex == 1)
                {
                    return 4;
                }
                else
                {
                    if (cmbdespues.SelectedIndex == 2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (cmbdespues.SelectedIndex == 3)
                        {
                            return 12;
                        }
                        else
                        {
                            if (cmbdespues.SelectedIndex == 4)
                            {
                                return 2;
                            }
                            else
                            {
                                if (cmbdespues.SelectedIndex == 5)
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

        public double ConvertM2()
        {

            if (cmbnominal.SelectedIndex == 0)
            {
                double M2 = 1;
                return M2;
            }
            else
            {
                if (cmbnominal.SelectedIndex == 1)
                {
                    return 4;
                }
                else
                {
                    if (cmbnominal.SelectedIndex == 2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (cmbnominal.SelectedIndex == 3)
                        {
                            return 12;
                        }
                        else
                        {
                            if (cmbnominal.SelectedIndex == 4)
                            {
                                return 2;
                            }
                            else
                            {
                                if (cmbnominal.SelectedIndex == 5)
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

       
        private void btnnominal_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrEmpty(texnominal.Text))
            {
                MessageBox.Show("Tienes que rellenar todos los formularios.");
                return;
            }
            if (double.Parse(texnominal.Text) <= 0)
            {
                MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                return;
            }
            double xd = cmxd();
            label12.Text = iNteresServices.ConvertEfectiva(double.Parse(texnominal.Text), xd).ToString();
          
        }

        private void btnotratasa_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtxotranominal.Text))
            {
                MessageBox.Show("Tienes que rellenar todos los formularios.");
                return;
            }
            if (double.Parse(txtxotranominal.Text) <=0)
            {
                MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                return;
            }
            double m1 = capitalizable();
            double m2 = ConvertM1();
            label16.Text = iNteresServices.ConvetNominal(double.Parse(txtxotranominal.Text), m1, m2).ToString();
            
        }

        private void btnefectiva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtefectiva.Text))
            {
                MessageBox.Show("Tienes que rellenar todos los formularios.");
                return;
            }
            if (double.Parse(txtefectiva.Text) <= 0)
            {
                MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                return;
            }
            label14.Text = iNteresServices.ConvertExponencial(double.Parse(txtefectiva.Text)).ToString();
            if (string.IsNullOrEmpty(txtefectiva.Text))
            {
                MessageBox.Show("Tienes que rellenar todos los formularios.");
                return;
            }
            if (double.Parse(txtefectiva.Text) <= 0)
            {
                MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                return;
            }
        }

        private void bntcontefec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtefectivacontinua.Text))
            {
                MessageBox.Show("Tienes que rellenar todos los formularios.");
                return;
            }
            if (double.Parse(txtefectivacontinua.Text) <= 0)
            {
                MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                return;
            }
            label2.Text = iNteresServices.EfectivaContinua(double.Parse(txtefectivacontinua.Text)).ToString();
          
        }
    }
}
