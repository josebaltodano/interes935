using App.Core.Iserveices;
using Domain.interes.Entities;
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
    public partial class Menu : Form
    {
        public IINteresServices iNteresServices;
        public Menu(IINteresServices iNteres)
        {
            InitializeComponent();
            this.iNteresServices = iNteres;
        }

        private void cmblogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmblogin.SelectedIndex== 0)
            {
                FmrInteres fmr = new FmrInteres(iNteresServices);
                fmr.ShowDialog();
            }
            else
            {
                if (cmblogin.SelectedIndex == 1)
                {
                    FmrInteresNosemejante fmrInteresNosemejante = new FmrInteresNosemejante(iNteresServices);
                    fmrInteresNosemejante.ShowDialog();
                }
            }
           
        }
    }
}
