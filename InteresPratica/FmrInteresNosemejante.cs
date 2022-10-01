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
    public partial class FmrInteresNosemejante : Form
    {
        public IINteresServices iNteresServices;
        public FmrInteresNosemejante(IINteresServices iNteres)
        {
            InitializeComponent();
            this.cmbcapitalanual.Items.AddRange(Enum.GetValues(typeof(Producto)).Cast<object>().ToArray());
            this.cmbcapcuatrimestre.Items.AddRange(Enum.GetValues(typeof(CAPCuatrimestral)).Cast<object>().ToArray());
            this.comboBox2.Items.AddRange(Enum.GetValues(typeof(CAPSemestral)).Cast<object>().ToArray());
            this.cmbcaptrimsestr.Items.AddRange(Enum.GetValues(typeof(CAPtrimestal)).Cast<object>().ToArray());
            this.comboBox1.Items.AddRange(Enum.GetValues(typeof(Tiempo)).Cast<object>().ToArray());
            this.iNteresServices = iNteres;
            groupBox1.Visible = false;
            cmbcapcuatrimestre.Visible = false;
            cmbcaptrimsestr.Visible = false;
            comboBox2.Visible = false;

        }

        public double CoTrimestral()
        {

            if (cmbcaptrimsestr.SelectedIndex == 0)
            {

                return 1 / 0.25; /*años*/
            }
            else
            {
                if (cmbcaptrimsestr.SelectedIndex == 1)
                {

                    return 1 / 0.5; /*semestres*/
                }
                else
                {
                    if (cmbcaptrimsestr.SelectedIndex == 2)
                    {

                        return 0.3333333333; /*meses*/
                    }
                    else
                    {
                        if (cmbcaptrimsestr.SelectedIndex == 3)
                        {

                            return 1 / 0.75; /*cuatrimestres*/
                        }
                        else
                        {
                            if (cmbcaptrimsestr.SelectedIndex == 4)
                            {

                                return 1 / 13.035714285714286; /*semanas*/
                            }
                            else
                            {

                                if (cmbcaptrimsestr.SelectedIndex == 5)
                                {

                                    return 1 / 91.25;/* dias*/
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

        public double ConvertM()
        {

            if (cmbcapitalanual.SelectedIndex == 0)
            {
                double M = 1;
                return M;
            }
            else
            {
                if (cmbcapitalanual.SelectedIndex == 1)
                {
                    return 4;
                }
                else
                {
                    if (cmbcapitalanual.SelectedIndex == 2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (cmbcapitalanual.SelectedIndex == 3)
                        {
                            return 12;
                        }
                        else
                        {
                            if (cmbcapitalanual.SelectedIndex == 4)
                            {
                                return 2;
                            }
                            else
                            {
                                if (cmbcapitalanual.SelectedIndex == 5)
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

        public double periodo()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                double semes = 2;
                return semes;
            }
            else
            {
                if(comboBox1.SelectedIndex == 1)
                {
                    double catry = 0;
                    return catry;
                }
                else
                {
                    if(comboBox1.SelectedIndex == 2)
                    {
                        double tri = CoTrimestral();
                        return tri;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double m = ConvertM();
            double pruebar = CoTrimestral();
            double tiemppo = periodo();

            //double año = double.Parse(txtxaños.Text) * Convertaño();
            if (cmbmostrasr.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txtpresente.Text) || string.IsNullOrEmpty(txtinteres.Text) || string.IsNullOrEmpty(txtxaños.Text))
                {
                    MessageBox.Show("Tienes que rellenar todos los formularios.");
                    return;
                }
                if (double.Parse(txtpresente.Text) <= 0
                    || double.Parse(txtinteres.Text) <= 0
                    || double.Parse(txtxaños.Text) <= 0)
                {
                    MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                    return;
                }
                label1.Text = iNteresServices.prueba(double.Parse(txtinteres.Text), m, double.Parse(txtxaños.Text), double.Parse(txtpresente.Text), pruebar).ToString();
            }
            else
            {
                if (cmbmostrasr.SelectedIndex == 1)
                {

                    if (string.IsNullOrEmpty(txtfuturo.Text) || string.IsNullOrEmpty(txtinteres.Text) || string.IsNullOrEmpty(txtxaños.Text))
                    {
                        MessageBox.Show("Tienes que rellenar todos los formularios.");
                        return;
                    }
                    if (double.Parse(txtfuturo.Text) <= 0
                        || double.Parse(txtinteres.Text) <= 0
                        || double.Parse(txtxaños.Text) <= 0)
                    {
                        MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                        return;
                    }

                    label1.Text = iNteresServices.prueba1(double.Parse(txtinteres.Text),m,double.Parse(txtxaños.Text),double.Parse(txtfuturo.Text),pruebar).ToString();
                }
                else
                {
                    if (cmbmostrasr.SelectedIndex == 2)
                    {

                        if (string.IsNullOrEmpty(txtpresente.Text) || string.IsNullOrEmpty(txtinteres.Text) || string.IsNullOrEmpty(txtpresente.Text))
                        {
                            MessageBox.Show("Tienes que rellenar todos los formularios.");
                            return;
                        }
                        if (double.Parse(txtfuturo.Text) <= 0
                            || double.Parse(txtinteres.Text) <= 0
                            || double.Parse(txtpresente.Text) <= 0)
                        {
                            MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                            return;
                        }

                        label1.Text = iNteresServices.GeTPeriodo(double.Parse(txtinteres.Text), m, double.Parse(txtpresente.Text), double.Parse(txtfuturo.Text)).ToString();
                        string v = Convert.ToString(double.Parse(txtinteres.Text));
                        label4.Text = v;
                    }
                }
            }
            Clean();
        }

        private void Clean()
        {
            txtfuturo.Clear();
            txtinteres.Clear();
            txtpresente.Clear();
            txtxaños.Clear();
            cmbcapitalanual.SelectedIndex = -1;
        }

        private void cmbmostrasr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmostrasr.SelectedIndex == 0)
            {
                txtfuturo.Visible = false;
                lblfuturo.Visible = false;
                llbpresente.Visible = true;
                txtpresente.Visible = true;
                lblaños.Visible = true;
                txtxaños.Visible = true;
                groupBox1.Visible = true;

            }
            else
            {
                if (cmbmostrasr.SelectedIndex == 1)
                {
                    txtpresente.Visible = false;
                    llbpresente.Visible = false;
                    lblfuturo.Visible = true;
                    txtfuturo.Visible = true;
                    lblaños.Visible = true;
                    txtxaños.Visible = true;
                    groupBox1.Visible = true;
                }
                else
                {
                    if (cmbmostrasr.SelectedIndex == 2)
                    {
                        groupBox1.Visible = true;
                        txtxaños.Visible = false;
                        lblaños.Visible = false;
                        txtfuturo.Visible = true;
                        lblfuturo.Visible = true;
                        llbpresente.Visible = true;
                        txtpresente.Visible = true;

                    }
                    else
                    {
                        if (cmbmostrasr.SelectedIndex == 3)
                        {
                            groupBox1.Visible = false;
                            FmrConvertidor fmr = new FmrConvertidor(iNteresServices);
                            fmr.ShowDialog();

                        }
                    }
                }
            }
        }

        private void txtfuturo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("NO SE PUEDEN LETRAS");
            }
        }

        private void txtpresente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("NO SE PUEDEN LETRAS");
            }
        }

        private void txtinteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("NO SE PUEDEN LETRAS");
            }
        }

        private void txtxaños_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("NO SE PUEDEN LETRAS");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                cmbcapcuatrimestre.Visible = false;
                cmbcaptrimsestr.Visible = false;
                comboBox2.Visible = true;
            }
            else
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    cmbcapcuatrimestre.Visible = true;
                    cmbcaptrimsestr.Visible = false;
                    comboBox2.Visible = false;
                }
                else
                {
                    if (comboBox1.SelectedIndex == 2)
                    {
                        cmbcapcuatrimestre.Visible = false;
                        cmbcaptrimsestr.Visible = true;
                        comboBox2.Visible = false;
                    }
                }
            }
        }
    }
}
