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
    public partial class FmrInteres : Form
    {
        public IINteresServices iNteresServices;
     
        public FmrInteres(IINteresServices iNteres)
        {
            
            InitializeComponent();
            this.cmbcapitalanual.Items.AddRange(Enum.GetValues(typeof(Producto)).Cast<object>().ToArray());
            this.cmbcapcuatrimestre.Items.AddRange(Enum.GetValues(typeof(CapMensualmente)).Cast<object>().ToArray());
            this.cmbcapsemestre.Items.AddRange(Enum.GetValues(typeof(CAPSemestral)).Cast<object>().ToArray());
            this.cmbcaptrimsestr.Items.AddRange(Enum.GetValues(typeof(CAPtrimestal)).Cast<object>().ToArray());


            this.iNteresServices = iNteres;
            this.cmbmostrasr.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbcapitalanual.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbcaptrimsestr.Visible = false;
            cmbcapsemestre.Visible = false;
            cmbcapcuatrimestre.Visible = false;

            groupBox1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public double COsemestral()
        {
            double t = 0;
            if(cmbcapsemestre.SelectedIndex == 0)
            {
                t = 1 / 0.5; /*años*/
                return t;
            }
            else
            {
                if(cmbcapsemestre.SelectedIndex == 1)
                {
                    t = 1 / 1.5;  /*cuatrimestres*/
                    return t;
                }
                else
                {
                    if (cmbcapsemestre.SelectedIndex == 2)
                    {
                        t = 1 / 2;  
                        return t;
                    }
                    else
                    {
                        if(cmbcapsemestre.SelectedIndex == 3)
                        {
                            t = 1 / 6;
                            return t;
                        }
                        else
                        {
                            if(cmbcapsemestre.SelectedIndex == 4)
                            {
                                t = 1 / 26.071428571428573;
                                return t;
                            }
                            else
                            {

                                if(cmbcapsemestre.SelectedIndex == 5)
                                {
                                    t = 1 / 182.5;
                                    return t;
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

                    return 1/0.5; /*semestres*/
                }
                else
                {
                    if (cmbcaptrimsestr.SelectedIndex == 2)
                    {
                        
                        return  0.3333333333; /*meses*/
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
  
        public  double Convertaño()
        {
            double a = 0;

            if(cmbcapcuatrimestre.SelectedIndex == 0)
            {
                a = 1;
                return a;

            }
            else
            {
                if(cmbcapcuatrimestre.SelectedIndex == 1)
                {
                    a = 1 / 30;
                    return a;
                }
                else
                {
                    if(cmbcapcuatrimestre.SelectedIndex == 2)
                    {
                        a = 7 / 1;
                        return a;
                    }
                    else
                    {
                        if(cmbcapcuatrimestre.SelectedIndex == 3)
                        {
                            a = 1 / 365;
                            return a;
                        }
                        else
                        {
                            if(cmbcapcuatrimestre.SelectedIndex == 4)
                            {
                                a = 365 / 1;
                                return a;
                            }
                            else
                            {
                                if(cmbcapcuatrimestre.SelectedIndex == 5)
                                {
                                    a = 12 / 1;
                                    return a;
                                }
                                else
                                {
                                    if(cmbcapcuatrimestre.SelectedIndex == 5)
                                    {
                                        a = 1 / 12;
                                        return a;
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
        }
        public double  ConvertM()
        {

            if (cmbcapitalanual.SelectedIndex == 0)
            {
                return  1;
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

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convertaño();
            double m = ConvertM();
            double pruebar = CoTrimestral();
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
                label1.Text = iNteresServices.Getfuturo(double.Parse(txtinteres.Text),m,double.Parse(txtpresente.Text),double.Parse(txtxaños.Text)).ToString();
            }
            else
            {
                if(cmbmostrasr.SelectedIndex == 1)
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

                    label1.Text = iNteresServices.GetPresente(double.Parse(txtinteres.Text), m, double.Parse(txtfuturo.Text), double.Parse(txtxaños.Text)).ToString();
                }
                else
                {
                    if(cmbmostrasr.SelectedIndex == 2)
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
   

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("NO SE PUEDEN LETRAS");
            }
        }

    

        private void label13_Click(object sender, EventArgs e)
        {

        }

 

        private void cmbmostrasr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbmostrasr.SelectedIndex == 0)
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
                if(cmbmostrasr.SelectedIndex == 1)
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
                    if(cmbmostrasr.SelectedIndex == 2)
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
                        if(cmbmostrasr.SelectedIndex == 3)
                        {
                            groupBox1.Visible = false;
                            FmrConvertidor fmr = new FmrConvertidor(iNteresServices);
                            fmr.ShowDialog();

                        }
                    }
                }
            }
        }

        private void Clean()
        {
            txtfuturo.Clear();
            txtinteres.Clear();
            txtpresente.Clear();
            txtxaños.Clear();
            cmbcapitalanual.SelectedIndex =- 1;
        }

        private void txtfuturo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
