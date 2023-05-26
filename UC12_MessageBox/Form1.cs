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

            if (decisao == DialogResult.Yes)
            {
                MessageBox.Show("Você clicou em Sim!");
            }
            else
            {
                MessageBox.Show("Você clicou em Não!");
            }
        }
    }
}
