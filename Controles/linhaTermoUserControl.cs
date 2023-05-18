using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using termo_win_app.Dominio;

namespace termo_win_app.Controles
{
    public partial class linhaTermoUserControl : UserControl
    {

        private int indiceAtual = 0;
        public linhaTermoUserControl()
        {
            InitializeComponent();
        }

        public bool EstaPrenchida
        {
            get { return indiceAtual == 5; }
        }

        internal void Digitar(string letra)
        {
            if (EstaPrenchida)
            {
                return;
            }

            List<Label> controles = gridColunas.Controls.Cast<Label>().Reverse().ToList();

            controles[indiceAtual].Text = letra;
            indiceAtual++;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        public override string ToString()
        {
            string palavraCompleta = "";
            foreach (Label label in gridColunas.Controls.Cast<Label>().Reverse())
            {
                palavraCompleta += label.Text;

            }
            return palavraCompleta;
        }

        public void ColorirLabels(Termo.AvaliacaoLetra[] avaliacoes)
        {
            List<Label> controles = gridColunas.Controls.Cast<Label>().Reverse().ToList();

            for (int i = 0; i < avaliacoes.Length; i++)
            {
                Label labelSelecionado = controles[i];
                switch (avaliacoes[i])
                {
                    case Termo.AvaliacaoLetra.Correta:
                        labelSelecionado.BackColor = Color.Green;
                        break;
                    case Termo.AvaliacaoLetra.Incorreta:
                        labelSelecionado.BackColor = Color.Goldenrod;
                        break;
                    case Termo.AvaliacaoLetra.NaoExistente:
                        labelSelecionado.BackColor = Color.Red;
                        break;
                }
            }
        }

        internal void Apagar()
        {
            if (indiceAtual <= 0)
            {
                return;
            }
            indiceAtual--;
            Label labelSelecionado = (Label)gridColunas.Controls.Cast<Label>().Reverse().ToList()[indiceAtual];

            labelSelecionado.Text = "";
        }

        internal void limpar()
        {
            indiceAtual = 0;

            foreach (Label label in gridColunas.Controls)
            {
                label.Text = "";
                label.BackColor = SystemColors.GrayText;


            }
        }
    }
}