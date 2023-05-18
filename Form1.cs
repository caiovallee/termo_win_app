using termo_win_app.Dominio;
using termo_win_app.Controles;
using static termo_win_app.Dominio.Termo;

namespace termo_win_app
{
    public partial class Form1 : Form
    {
        private Termo jogo;

        public linhaTermoUserControl LinhaAtual
        {
            get
            {
                return (linhaTermoUserControl)gridPrincipal.Controls[jogo.tentativas];
            }
        }
        public Form1()
        {
            InitializeComponent();
            RegistrarEventos();
            jogo = new Termo();

        }

        public void RegistrarEventos()
        {
            foreach (Button botao in panel1.Controls)
            {
                if (botao.Name == "btnEnter" || botao.Name == "btnReniciar" || botao.Name == "btnApagar")
                {
                    continue;
                }

                botao.Click += DigitarLetra;
            }
            btnEnter.Click += AvaliarPalavra;

            btnApagar.Click += ApagarLetra;

            btnReset.Click += ReniciarJogo;
        }

        private void ReniciarJogo(object? sender,EventArgs e)
        {
            jogo = new Termo();

            panel1.Enabled = true;

            btnReset.Visible = false;
        }

        private void ApagarLetra(object? sender, EventArgs e)
        {
            LinhaAtual.Apagar();
        }

        private void AvaliarPalavra(object? sender, EventArgs e)
        {

            linhaTermoUserControl linha = LinhaAtual;
            string palavraCompleta = linha.ToString();

            AvaliacaoLetra[] avaliacoes = jogo.Avaliar(palavraCompleta);

            linha.ColorirLabels(avaliacoes);


            if (jogo.JogadorAcertou(palavraCompleta) || jogo.JogadorPerdeu())
            {
                panel1.Enabled = false;
                btnReset.Visible = true;

                foreach(linhaTermoUserControl linhacor in gridPrincipal.Controls)
                {
                    linhacor.limpar();
                }
            }


        }

        private void DigitarLetra(object sender, EventArgs e)
        {
            Button botaclicado = (Button)sender;

            LinhaAtual.Digitar(botaclicado.Text);
        }

        private void linhaTermoUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}