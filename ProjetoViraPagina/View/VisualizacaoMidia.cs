using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_ViraPagina.View
{
    public partial class VisualizacaoMidia : Form
    {
        public VisualizacaoMidia()
        {
            InitializeComponent();
        }
        private void ColorirLinhasAlternadas()
        {
            for (int i = 0; i < dgvVisualizacaoMidia.Rows.Count; i++)
            {
                if (i % 2 == 0) // Linhas pares (0, 2, 4...) = Bege amarronzado (#A67B5B)
                {
                    dgvVisualizacaoMidia.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#A67B5B");
                }
                else // Linhas ímpares (1, 3, 5...) = Vermelho escuro (#8B0000)
                {
                    dgvVisualizacaoMidia.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8B0000");
                    dgvVisualizacaoMidia.Rows[i].DefaultCellStyle.ForeColor = Color.White; // Texto branco para contraste
                }
            }
        }

        private void VisualizacaoMidia_Load(object sender, EventArgs e)
        {
            ColorirLinhasAlternadas();
        }
    }
}
