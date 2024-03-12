namespace CalculadoraWindowsForms
{
    public partial class Form1 : Form
    {
        private Operacao OperacaoSelecionada { get; set; }
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void VerificaResultado()
        {
            if (lblOperacao.Text.Contains("="))
            {
                txtResultado.Clear();
                lblOperacao.Text = "";
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            VerificaResultado();
            txtResultado.Text += "0";        
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            VerificaResultado();
            txtResultado.Text += "1";           
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            VerificaResultado();
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            VerificaResultado();
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            VerificaResultado();
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            VerificaResultado();
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            VerificaResultado();
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            VerificaResultado();
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            VerificaResultado();
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            VerificaResultado();
            txtResultado.Text += "9";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            lblOperacao.Text = "";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = decimal.Parse(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "+";

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = decimal.Parse(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "-";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = decimal.Parse(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = decimal.Parse(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                switch (OperacaoSelecionada)
                {
                    case Operacao.Adicao:
                        Resultado = Valor + decimal.Parse(txtResultado.Text);
                        break;
                    case Operacao.Subtracao:
                        Resultado = Valor - decimal.Parse(txtResultado.Text);
                        break;
                    case Operacao.Multiplicacao:
                        Resultado = Valor * decimal.Parse(txtResultado.Text);
                        break;
                    case Operacao.Divisao:
                        Resultado = Valor / decimal.Parse(txtResultado.Text);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtResultado.Clear();
            }
            txtResultado.Text = Resultado.ToString();
            lblOperacao.Text = "=";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
        }
    }
}
