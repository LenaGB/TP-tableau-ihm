using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TP_note
{
    public partial class Produits : Form
    {

        private double pourcentage = 0;
        private string[] tableauReferences = { "reference1", "reference2", "reference3", "reference4", "reference5", "reference6", "reference7", "reference8", "reference9", "reference10" };
        public Produits()
        {
            InitializeComponent();
            foreach (string element in tableauReferences) {
            lstbensembleref.Items.Add(element);
            }
        }

        private void tbxprixht_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnadd_Click(sender, e);

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pourcentage = 10;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pourcentage = 2.1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rd55_CheckedChanged(object sender, EventArgs e)
        {
            pourcentage = 5.5;
        }

        private void rdtauxnormal_CheckedChanged(object sender, EventArgs e)
        {
            pourcentage = 20;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Boolean error = false;
            lblerrorref.Text = "";
            lblerrorprix.Text = "";
            tbxprixht.BackColor = Color.White;
            tbxref.BackColor = Color.White;
            lblinfos.ForeColor = Color.Black;

            if (tbxprixht.Text=="")
            {
                tbxprixht.BackColor= Color.Red;
                lblerrorprix.Visible= true;
                error = true;
                lblerrorprix.Text = "Veuillez entrer le prix";
            }
            else
            {
                if (!int.TryParse(tbxprixht.Text, out int value))
                {
                    tbxprixht.BackColor= Color.Red;
                    lblerrorprix.Visible = true;
                    error= true;
                    lblerrorprix.Text = "La valeur entrée doit être un nombre entier";
                }
            }
            if (tbxref.Text == "" )
            {
                tbxref.BackColor= Color.Red;
                lblerrorref.Visible = true;
                error = true;
                lblerrorref.Text = "Veuillez entrer une référence";
            }
            else if ( tbxref.Text.Length < 5)
            {
                tbxref.BackColor = Color.Red;
                lblerrorref.Visible = true;
                error = true;
                lblerrorref.Text = "La référence doit comporter au minimum 5 caractères";
            }
            foreach(string element in tableauReferences)
            {
                 if(element == tbxref.Text)
                {
                    error = true;
                    lblinfos.ForeColor = Color.Red;
                    lblinfos.Text = "La référence que vous avez entrée existe déjà.";
                    break;
                }
            }
            if (!error)
            {
                lblerrorref.Visible = false;
                lblerrorprix.Visible= false;
                lblinfos.Text = "La référence est "+ tbxref.Text +", le prix ht est "+ tbxprixht.Text +"€ le taux de TVA est de "+ pourcentage+"%"+ " et le prix TTC de "+(Convert.ToDouble(tbxprixht.Text)+(Convert.ToDouble(tbxprixht.Text)*(pourcentage/100)))+"€";
                lstbensembleref.Items.Add(tbxref.Text);
                Array.Resize(ref tableauReferences, tableauReferences.Length + 1);
                tableauReferences[tableauReferences.Length - 1] = tbxref.Text;
                tbxref.Text = "";
                tbxprixht.Text = "";
            }
          
        }

        private void txtbreferences_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblerrorprix_Click(object sender, EventArgs e)
        {

        }
        
}
}
