using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_2021119
{
   
    public partial class Form1 : Form
    {
        private List<osoba> ucty;
        private osoba ucet;
        public Form1()
        {
            InitializeComponent();
            numVybrat.Maximum = int.MaxValue;
            numMaxStavUctu.Maximum = int.MaxValue;
            numVlozit.Maximum = int.MaxValue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucty = new List<osoba>();
            if(ucet == null)
            {
                groupBox1.Enabled = false;
            }
        }

        private void UkazUcet(osoba ucet)
        {
            lblJmeno.Text = ucet.Jmeno;
            lblMaxStavUctu.Text = $"{ucet.MaximalniStav}";
            lblAktualniStavUctu.Text = $"{ucet.Vlozeno}";
            
        }

        private void numMaxStavUctu_ValueChanged(object sender, EventArgs e)
        {
           btnVytvoritUcet.Enabled = txtJmeno.Text.Trim().Length > 0 && numMaxStavUctu.Value > 0;
        }

        private void txtJmeno_TextChanged(object sender, EventArgs e)
        {
            btnVytvoritUcet.Enabled = txtJmeno.Text.Trim().Length > 0 && numMaxStavUctu.Value > 0;
        }

        private void Vytvorit_Click(object sender, EventArgs e)
        {
            ucty.Add(new osoba(txtJmeno.Text, Convert.ToInt32(numMaxStavUctu.Value)));
            groupBox2.Visible = false;
            UkazUcty();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void UkazUcty()
        {
            vypisUctu.Items.Clear();

            foreach(var n in ucty)
            {
                vypisUctu.Items.Add($"{n.Jmeno}(max peněz na účtu: {n.MaximalniStav}) CZK");
            }
        }

        private void btnVlozit_Click(object sender, EventArgs e)
        {
            var vlozeno = ucet.Vloz(Convert.ToInt32(numVlozit.Value));
            MessageBox.Show($"Vloženo {vlozeno} CZK");
            UkazUcet(ucet);
        }

        private void btnVybrat_Click(object sender, EventArgs e)
        {
            var vlozeno = ucet.Vyber(Convert.ToInt32(numVybrat.Value));
            MessageBox.Show($"Vybráno {vlozeno} CZK");
            UkazUcet(ucet);
        }

        private void btnVytvoritUcet_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            txtJmeno.Text = " ";
            numMaxStavUctu.Value = 0;
        }

        private void vypisUctu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucet = ucty[vypisUctu.SelectedIndex];
            UkazUcet(ucet);
            groupBox1.Enabled = true;
        }
    }
}
