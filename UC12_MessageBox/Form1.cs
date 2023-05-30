using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12_MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMB_Click(object sender, EventArgs e)
        {
            DialogResult decisao = MessageBox.Show("Deseja Continuar?", "Opção", MessageBoxButtons.YesNo);

            DateTime HORA = System.DateTime.Now;
            string HORAstring = HORA.ToString("HH:mm");

            if (decisao == DialogResult.Yes)
            {
                MessageBox.Show("SIM! - " + HORAstring);
            } else
            {
                MessageBox.Show("NÃO!");
            }
        }
    }
}
