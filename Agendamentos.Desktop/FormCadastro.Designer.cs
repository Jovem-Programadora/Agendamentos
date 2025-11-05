namespace SalaoBeleza.Desktop
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            barraTopo = new Panel();
            btnVoltar = new Button();
            lblTitulo = new Label();
            lblConfirmarSenha = new Label();
            txtConfirmarSenha = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            btnCadastrar = new Button();
            pnlDivisao = new TableLayoutPanel();
            pnlFormulario = new TableLayoutPanel();
            pnlNome = new TableLayoutPanel();
            pnlEmail = new TableLayoutPanel();
            pnlSenha = new TableLayoutPanel();
            pnlConfirmarSenha = new TableLayoutPanel();
            barraTopo.SuspendLayout();
            pnlDivisao.SuspendLayout();
            pnlFormulario.SuspendLayout();
            pnlNome.SuspendLayout();
            pnlEmail.SuspendLayout();
            pnlSenha.SuspendLayout();
            pnlConfirmarSenha.SuspendLayout();
            SuspendLayout();
            // 
            // barraTopo
            // 
            barraTopo.Controls.Add(btnVoltar);
            barraTopo.Controls.Add(lblTitulo);
            barraTopo.Dock = DockStyle.Top;
            barraTopo.Location = new Point(12, 12);
            barraTopo.Margin = new Padding(0, 0, 0, 12);
            barraTopo.Name = "barraTopo";
            barraTopo.Size = new Size(476, 48);
            barraTopo.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.Dock = DockStyle.Right;
            btnVoltar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnVoltar.Location = new Point(380, 0);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(96, 48);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += FecharCadastro;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(184, 149, 46);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(476, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Beauty Hair";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblConfirmarSenha.ForeColor = Color.FromArgb(178, 175, 182);
            lblConfirmarSenha.Location = new Point(0, 0);
            lblConfirmarSenha.Margin = new Padding(0, 0, 0, 8);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(162, 25);
            lblConfirmarSenha.TabIndex = 0;
            lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Dock = DockStyle.Top;
            txtConfirmarSenha.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtConfirmarSenha.Location = new Point(0, 33);
            txtConfirmarSenha.Margin = new Padding(0);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(464, 29);
            txtConfirmarSenha.TabIndex = 1;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblSenha.ForeColor = Color.FromArgb(178, 175, 182);
            lblSenha.Location = new Point(0, 0);
            lblSenha.Margin = new Padding(0, 0, 0, 8);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(66, 25);
            lblSenha.TabIndex = 0;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Dock = DockStyle.Top;
            txtSenha.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.Location = new Point(0, 33);
            txtSenha.Margin = new Padding(0);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(464, 29);
            txtSenha.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(178, 175, 182);
            lblEmail.Location = new Point(0, 0);
            lblEmail.Margin = new Padding(0, 0, 0, 8);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Top;
            txtEmail.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.Location = new Point(0, 33);
            txtEmail.Margin = new Padding(0);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(464, 29);
            txtEmail.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblNome.ForeColor = Color.FromArgb(178, 175, 182);
            lblNome.Location = new Point(0, 0);
            lblNome.Margin = new Padding(0, 0, 0, 8);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(158, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Completo";
            // 
            // txtNome
            // 
            txtNome.Dock = DockStyle.Top;
            txtNome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.Location = new Point(0, 33);
            txtNome.Margin = new Padding(0);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(464, 29);
            txtNome.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSize = true;
            btnCadastrar.Dock = DockStyle.Bottom;
            btnCadastrar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnCadastrar.Location = new Point(12, 578);
            btnCadastrar.Margin = new Padding(0);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(476, 40);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += CadastrarUsuario;
            // 
            // pnlDivisao
            // 
            pnlDivisao.BackColor = Color.FromArgb(25, 24, 27);
            pnlDivisao.ColumnCount = 1;
            pnlDivisao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlDivisao.Controls.Add(barraTopo, 0, 0);
            pnlDivisao.Controls.Add(pnlFormulario, 0, 1);
            pnlDivisao.Controls.Add(btnCadastrar, 0, 2);
            pnlDivisao.Dock = DockStyle.Fill;
            pnlDivisao.Location = new Point(0, 0);
            pnlDivisao.Name = "pnlDivisao";
            pnlDivisao.Padding = new Padding(12);
            pnlDivisao.RowCount = 4;
            pnlDivisao.RowStyles.Add(new RowStyle());
            pnlDivisao.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlDivisao.RowStyles.Add(new RowStyle());
            pnlDivisao.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlDivisao.Size = new Size(500, 650);
            pnlDivisao.TabIndex = 3;
            // 
            // pnlFormulario
            // 
            pnlFormulario.ColumnCount = 1;
            pnlFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlFormulario.Controls.Add(pnlNome, 0, 0);
            pnlFormulario.Controls.Add(pnlEmail, 0, 1);
            pnlFormulario.Controls.Add(pnlSenha, 0, 2);
            pnlFormulario.Controls.Add(pnlConfirmarSenha, 0, 3);
            pnlFormulario.Dock = DockStyle.Fill;
            pnlFormulario.Location = new Point(15, 75);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.RowCount = 5;
            pnlFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlFormulario.Size = new Size(470, 500);
            pnlFormulario.TabIndex = 2;
            // 
            // pnlNome
            // 
            pnlNome.ColumnCount = 1;
            pnlNome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlNome.Controls.Add(lblNome, 0, 0);
            pnlNome.Controls.Add(txtNome, 0, 1);
            pnlNome.Dock = DockStyle.Fill;
            pnlNome.Location = new Point(3, 3);
            pnlNome.Name = "pnlNome";
            pnlNome.RowCount = 2;
            pnlNome.RowStyles.Add(new RowStyle());
            pnlNome.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlNome.Size = new Size(464, 114);
            pnlNome.TabIndex = 2;
            // 
            // pnlEmail
            // 
            pnlEmail.ColumnCount = 1;
            pnlEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlEmail.Controls.Add(lblEmail, 0, 0);
            pnlEmail.Controls.Add(txtEmail, 0, 1);
            pnlEmail.Dock = DockStyle.Fill;
            pnlEmail.Location = new Point(3, 123);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.RowCount = 2;
            pnlEmail.RowStyles.Add(new RowStyle());
            pnlEmail.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlEmail.Size = new Size(464, 114);
            pnlEmail.TabIndex = 2;
            // 
            // pnlSenha
            // 
            pnlSenha.ColumnCount = 1;
            pnlSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlSenha.Controls.Add(lblSenha, 0, 0);
            pnlSenha.Controls.Add(txtSenha, 0, 1);
            pnlSenha.Dock = DockStyle.Fill;
            pnlSenha.Location = new Point(3, 243);
            pnlSenha.Name = "pnlSenha";
            pnlSenha.RowCount = 2;
            pnlSenha.RowStyles.Add(new RowStyle());
            pnlSenha.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlSenha.Size = new Size(464, 114);
            pnlSenha.TabIndex = 2;
            // 
            // pnlConfirmarSenha
            // 
            pnlConfirmarSenha.ColumnCount = 1;
            pnlConfirmarSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlConfirmarSenha.Controls.Add(lblConfirmarSenha, 0, 0);
            pnlConfirmarSenha.Controls.Add(txtConfirmarSenha, 0, 1);
            pnlConfirmarSenha.Dock = DockStyle.Fill;
            pnlConfirmarSenha.Location = new Point(3, 363);
            pnlConfirmarSenha.Name = "pnlConfirmarSenha";
            pnlConfirmarSenha.RowCount = 2;
            pnlConfirmarSenha.RowStyles.Add(new RowStyle());
            pnlConfirmarSenha.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlConfirmarSenha.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlConfirmarSenha.Size = new Size(464, 114);
            pnlConfirmarSenha.TabIndex = 4;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 5, 5);
            ClientSize = new Size(500, 650);
            Controls.Add(pnlDivisao);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormCadastro";
            barraTopo.ResumeLayout(false);
            pnlDivisao.ResumeLayout(false);
            pnlDivisao.PerformLayout();
            pnlFormulario.ResumeLayout(false);
            pnlNome.ResumeLayout(false);
            pnlNome.PerformLayout();
            pnlEmail.ResumeLayout(false);
            pnlEmail.PerformLayout();
            pnlSenha.ResumeLayout(false);
            pnlSenha.PerformLayout();
            pnlConfirmarSenha.ResumeLayout(false);
            pnlConfirmarSenha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel barraTopo;
        private Label lblTitulo;
        private Button btnVoltar;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblSenha;
        private TextBox txtSenha;
        private Label lblConfirmarSenha;
        private TextBox txtConfirmarSenha;
        private Button btnCadastrar;
        private TableLayoutPanel pnlDivisao;
        private TableLayoutPanel pnlFormulario;
        private TableLayoutPanel pnlConfirmarSenha;
        private TableLayoutPanel pnlSenha;
        private TableLayoutPanel pnlEmail;
        private TableLayoutPanel pnlNome;
    }
}