using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vincic_Alen_PPZ02
{
    public partial class Form1 : Form
    {
        List<Pica> listaPica = new List<Pica>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            Pica pica = new Pica(txtNaziv.Text, cmbPakiranje.Text, txtCijena.Text, cmbKolicina.Text);

            listaPica.Add(pica);
            MessageBox.Show("Uspješan unos", "Uspjeh",MessageBoxButtons.OK,MessageBoxIcon.Information);
            


            
        }

        private void trckPostotak_Scroll(object sender, EventArgs e)
        {
            lblAlk.Text = trckPostotak.Value.ToString();
        }

       

        private void rbAlkoholna_CheckedChanged(object sender, EventArgs e)
        {
            trckPostotak.Enabled = rbAlkoholna.Checked;
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            rtbIspis.Clear();


            foreach (Pica pica in listaPica)
            {
                if (trckPostotak.Enabled)
                {
                    rtbIspis.AppendText(pica.ToString() + "\n"+"Postotak: "+lblAlk.Text+"%" + "\n");
                }

                else
                {
                    rtbIspis.AppendText(pica.ToString()+ "\n");
                }
                
            }
            




        }
    } 
}
