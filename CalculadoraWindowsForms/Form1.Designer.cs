namespace CalculadoraWindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnZero = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnVirgula = new Button();
            btnIgual = new Button();
            btnSoma = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnLimpar = new Button();
            lblOperacao = new Label();
            label2 = new Label();
            button18 = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(12, 49);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(385, 35);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnZero.Location = new Point(161, 309);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(58, 51);
            btnZero.TabIndex = 1;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnUm
            // 
            btnUm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUm.Location = new Point(97, 252);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(58, 51);
            btnUm.TabIndex = 2;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDois.Location = new Point(161, 252);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(58, 51);
            btnDois.TabIndex = 3;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTres.Location = new Point(225, 253);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(58, 51);
            btnTres.TabIndex = 4;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnQuatro.Location = new Point(97, 195);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(58, 51);
            btnQuatro.TabIndex = 5;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCinco.Location = new Point(161, 195);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(58, 51);
            btnCinco.TabIndex = 6;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSeis.Location = new Point(225, 195);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(58, 51);
            btnSeis.TabIndex = 7;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnSete
            // 
            btnSete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSete.Location = new Point(97, 138);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(58, 51);
            btnSete.TabIndex = 8;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOito.Location = new Point(161, 138);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(58, 51);
            btnOito.TabIndex = 9;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNove.Location = new Point(225, 138);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(58, 51);
            btnNove.TabIndex = 10;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVirgula.Location = new Point(97, 309);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(58, 51);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIgual.Location = new Point(225, 309);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(58, 51);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnSoma.Location = new Point(289, 138);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(58, 51);
            btnSoma.TabIndex = 13;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnSubtracao.Location = new Point(289, 195);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(58, 51);
            btnSubtracao.TabIndex = 14;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMultiplicacao.Location = new Point(289, 252);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(58, 51);
            btnMultiplicacao.TabIndex = 15;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDivisao.Location = new Point(289, 309);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(58, 51);
            btnDivisao.TabIndex = 16;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.White;
            btnLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpar.Location = new Point(289, 99);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(58, 33);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOperacao.Location = new Point(19, 56);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 21);
            lblOperacao.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 10);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 19;
            label2.Text = "Calculadora";
            // 
            // button18
            // 
            button18.BackColor = Color.Red;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.Location = new Point(396, 10);
            button18.Name = "button18";
            button18.Size = new Size(33, 34);
            button18.TabIndex = 20;
            button18.Text = "X";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(437, 381);
            Controls.Add(button18);
            Controls.Add(label2);
            Controls.Add(lblOperacao);
            Controls.Add(btnLimpar);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSoma);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnZero);
            Controls.Add(txtResultado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnZero;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnVirgula;
        private Button btnIgual;
        private Button btnSoma;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnLimpar;
        private Label lblOperacao;
        private Label label2;
        private Button button18;
    }
}
