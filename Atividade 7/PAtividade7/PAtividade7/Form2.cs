using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade7
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void frmExercicio1_Load(object sender, EventArgs e)
        {

        }

        private void btnEspacosBranco_Click(object sender, EventArgs e)
        {
            int espacoBranco = 0;
            int tamanho;
            int i;
            tamanho = rchTxtFrase.Text.Length;
            for (i = 0; i < tamanho; i++)
            {
                if (rchTxtFrase.Text[i] == ' ')
                {
                    espacoBranco++;
                }
            }
            MessageBox.Show($"Existem {espacoBranco} espaços em branco.");
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            int letrasR = 0;
            int tamanho;
            int i;
            tamanho = rchTxtFrase.Text.Length;
            for (i = 0; i < tamanho; i++)
            {
                if (rchTxtFrase.Text[i] == 'r' || rchTxtFrase.Text[i] == 'R')
                {
                    letrasR++;
                }
            }
            MessageBox.Show($"A letra R aparece {letrasR} vezes.");
        }

        private void btnParLetra_Click(object sender, EventArgs e)
        {

        }
    }
}
