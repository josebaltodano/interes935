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
            this.comboBox3.Items.AddRange(Enum.GetValues(typeof(CapMensualmente)).Cast<object>().ToArray());
            this.cmbcaptrimsestr.Items.AddRange(Enum.GetValues(typeof(CAPtrimestal)).Cast<object>().ToArray());
            this.comboBox1.Items.AddRange(Enum.GetValues(typeof(Tiempo)).Cast<object>().ToArray());
            this.iNteresServices = iNteres;
            groupBox1.Visible = false;
            cmbcapcuatrimestre.Visible = false;
            cmbcaptrimsestr.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;

        }
        public double pruebar;
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
        public double COSemestral()
        {
            return 0;
        }
        public double semestral()
        {
            if (comboBox2.SelectedIndex == 0)
            {

                return 1 / 0.5; /*años*/
            }
            else
            {
                if (comboBox2.SelectedIndex == 1)
                {

                    return 1 / 1.5; /*cuatrimestres*/
                }
                else
                {
                    if (comboBox2.SelectedIndex == 2)
                    {

                        return 1 / 2;/*trimestres*/
                    }
                    else
                    {
                        if (comboBox2.SelectedIndex == 3)
                        {

                            return 1 / 6;/*meses*/
                        }
                        else
                        {
                            if (comboBox2.SelectedIndex == 4)
                            {

                                return 1 / 26.071428571428573; /*semanas*/
                            }
                            else
                            {

                                if (comboBox2.SelectedIndex == 5)
                                {

                                    return 1 / 182.5;/* dias*/
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
        public double cuatrimestral()
        {
            if (cmbcapcuatrimestre.SelectedIndex == 0)
            {

                return 1 / 0.3333333333333333; /*años*/
            }
            else
            {
                if (cmbcapcuatrimestre.SelectedIndex == 1)
                {

                    return 1 / 0.6666666666666666; /*semestres*/
                }
                else
                {
                    if (cmbcapcuatrimestre.SelectedIndex == 2)
                    {

                        return 1 / 1.3333333333333333; /*trimestres*/
                    }
                    else
                    {
                        if (cmbcapcuatrimestre.SelectedIndex == 3)
                        {

                            return 1 / 4; /*meses*/
                        }
                        else
                        {
                            if (cmbcapcuatrimestre.SelectedIndex == 4)
                            {

                                return 1 / 17.38095238095238; /*semanas*/
                            }
                            else
                            {

                                if (cmbcapcuatrimestre.SelectedIndex == 5)
                                {

                                    return 1 / 121.66666666666667;/* dias*/
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
        public double anual()
        {
            if (comboBox3.SelectedIndex == 0)
            {

                return 1 / 2; /*semestres*/
            }
            else
            {
                if (comboBox3.SelectedIndex == 1)
                {

                    return 1 / 4; /*trismestres*/
                }
                else
                {
                    if (comboBox3.SelectedIndex == 2)
                    {

                        return 1 / 3; /*cuatrimestres*/
                    }
                    else
                    {
                        if (comboBox3.SelectedIndex == 3)
                        {

                            return 1 / 12; /*Mensual*/
                        }
                        else
                        {
                            if (comboBox3.SelectedIndex == 4)
                            {

                                return 1 / 52; /*semanas*/
                            }
                            else
                            {

                                if (cmbcapcuatrimestre.SelectedIndex == 5)
                                {

                                    return 1 / 365;/* dias*/
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
               
                
                return pruebar;
            }
            else
            {
                if(comboBox1.SelectedIndex == 1)
                {
                    
                    return pruebar;
                }
                else
                {
                    if(comboBox1.SelectedIndex == 2)
                    {
                        

                        return CoTrimestral();
                    }
                    else
                    {
                        if(comboBox1.SelectedIndex == 3)
                        {
                            return anual();
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }
        }
        public void exdd()
        {
            if (cmbcaptrimsestr.SelectedIndex == -1 && comboBox2.SelectedIndex == -1 && comboBox3.SelectedIndex ==-1)
            {
                pruebar = cuatrimestral();
            }else if (cmbcapcuatrimestre.SelectedIndex == -1 && cmbcaptrimsestr.SelectedIndex == -1 && comboBox3.SelectedIndex == -1)
            {
                pruebar = semestral();
            }
            if (cmbcapcuatrimestre.SelectedIndex == -1 && comboBox2.SelectedIndex == -1 && comboBox3.SelectedIndex == -1)
            {
                pruebar = CoTrimestral();
            }else if(cmbcapcuatrimestre.SelectedIndex == -1 && comboBox2.SelectedIndex == -1 && cmbcaptrimsestr.SelectedIndex == -1)
            {
                pruebar = anual();
            }
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            double m = ConvertM();
            ////double pruebar = CoTrimestral();
            //double tiemppo = periodo();
            exdd();
           
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
                label1.Text = iNteresServices.prueba(double.Parse(txtinteres.Text), m, double.Parse(txtxaños.Text), double.Parse(txtpresente.Text),pruebar).ToString();
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
            comboBox1.SelectedIndex = -1;
            cmbcapcuatrimestre.SelectedIndex = -1;
            cmbcaptrimsestr.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;


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
                    }else if(comboBox1.SelectedIndex == 3)
                    {
                        cmbcapcuatrimestre.Visible = false;
                        cmbcaptrimsestr.Visible = false;
                        comboBox2.Visible = false;
                        comboBox3.Visible = true;
                    }
                }
            }
        }
    }
}
