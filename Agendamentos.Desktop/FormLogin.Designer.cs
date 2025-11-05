using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;

namespace SalaoBeleza.Desktop;

partial class FormLogin
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
        lblEmail = new Label();
        txtEmail = new TextBox();
        btnFechar = new Button();
        lblTitulo = new Label();
        btnCadastrar = new Button();
        btnEntrar = new Button();
        chkLembrar = new CheckBox();
        txtSenha = new TextBox();
        lblSenha = new Label();
        pnlDivisao = new TableLayoutPanel();
        pnlForm = new TableLayoutPanel();
        pnlEmail = new TableLayoutPanel();
        pnlSenha = new TableLayoutPanel();
        pnlBotoes = new TableLayoutPanel();
        pnlTopo = new TableLayoutPanel();
        pnlDivisao.SuspendLayout();
        pnlForm.SuspendLayout();
        pnlEmail.SuspendLayout();
        pnlSenha.SuspendLayout();
        pnlBotoes.SuspendLayout();
        pnlTopo.SuspendLayout();
        SuspendLayout();
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Dock = DockStyle.Bottom;
        lblEmail.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
        lblEmail.ForeColor = Color.FromArgb(178, 175, 182);
        lblEmail.Location = new Point(0, 0);
        lblEmail.Margin = new Padding(0, 0, 0, 8);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(396, 21);
        lblEmail.TabIndex = 3;
        lblEmail.Text = "Email";
        // 
        // txtEmail
        // 
        txtEmail.Dock = DockStyle.Bottom;
        txtEmail.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        txtEmail.Location = new Point(0, 29);
        txtEmail.Margin = new Padding(0);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(396, 29);
        txtEmail.TabIndex = 4;
        // 
        // btnFechar
        // 
        btnFechar.BackColor = Color.FromArgb(220, 53, 69);
        btnFechar.Dock = DockStyle.Left;
        btnFechar.FlatAppearance.BorderColor = Color.FromArgb(220, 53, 69);
        btnFechar.FlatAppearance.BorderSize = 0;
        btnFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 53, 69);
        btnFechar.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 53, 69);
        btnFechar.FlatStyle = FlatStyle.Flat;
        btnFechar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnFechar.ForeColor = Color.White;
        btnFechar.Location = new Point(342, 0);
        btnFechar.Margin = new Padding(0);
        btnFechar.Name = "btnFechar";
        btnFechar.Size = new Size(48, 48);
        btnFechar.TabIndex = 1;
        btnFechar.Text = "X";
        btnFechar.UseVisualStyleBackColor = false;
        btnFechar.Click += FecharPrograma;
        // 
        // lblTitulo
        // 
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.Dock = DockStyle.Fill;
        lblTitulo.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitulo.ForeColor = Color.FromArgb(184, 149, 46);
        lblTitulo.Location = new Point(3, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Padding = new Padding(12, 0, 0, 0);
        lblTitulo.Size = new Size(336, 48);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Beauty Hair";
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnCadastrar
        // 
        btnCadastrar.Dock = DockStyle.Fill;
        btnCadastrar.Location = new Point(0, 56);
        btnCadastrar.Margin = new Padding(0, 6, 0, 0);
        btnCadastrar.Name = "btnCadastrar";
        btnCadastrar.Size = new Size(396, 44);
        btnCadastrar.TabIndex = 9;
        btnCadastrar.Text = "Cadastrar";
        btnCadastrar.UseVisualStyleBackColor = true;
        btnCadastrar.Click += CadastrarUsuario;
        // 
        // btnEntrar
        // 
        btnEntrar.Dock = DockStyle.Fill;
        btnEntrar.Location = new Point(0, 0);
        btnEntrar.Margin = new Padding(0, 0, 0, 6);
        btnEntrar.Name = "btnEntrar";
        btnEntrar.Size = new Size(396, 44);
        btnEntrar.TabIndex = 8;
        btnEntrar.Text = "Entrar";
        btnEntrar.UseVisualStyleBackColor = true;
        // 
        // chkLembrar
        // 
        chkLembrar.AutoSize = true;
        chkLembrar.Font = new Font("Segoe UI", 12F);
        chkLembrar.ForeColor = Color.FromArgb(178, 175, 182);
        chkLembrar.Location = new Point(3, 142);
        chkLembrar.Name = "chkLembrar";
        chkLembrar.Size = new Size(123, 25);
        chkLembrar.TabIndex = 7;
        chkLembrar.Text = "Lembrar-me?";
        chkLembrar.UseVisualStyleBackColor = true;
        // 
        // txtSenha
        // 
        txtSenha.Dock = DockStyle.Top;
        txtSenha.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        txtSenha.Location = new Point(0, 28);
        txtSenha.Margin = new Padding(0);
        txtSenha.Name = "txtSenha";
        txtSenha.PasswordChar = '•';
        txtSenha.Size = new Size(396, 29);
        txtSenha.TabIndex = 6;
        // 
        // lblSenha
        // 
        lblSenha.Dock = DockStyle.Top;
        lblSenha.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
        lblSenha.ForeColor = Color.FromArgb(178, 175, 182);
        lblSenha.Location = new Point(0, 0);
        lblSenha.Margin = new Padding(0, 0, 0, 8);
        lblSenha.Name = "lblSenha";
        lblSenha.Size = new Size(396, 20);
        lblSenha.TabIndex = 5;
        lblSenha.Text = "Senha";
        // 
        // pnlDivisao
        // 
        pnlDivisao.BackColor = Color.FromArgb(25, 24, 27);
        pnlDivisao.ColumnCount = 1;
        pnlDivisao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlDivisao.Controls.Add(pnlTopo, 0, 0);
        pnlDivisao.Controls.Add(pnlForm, 0, 1);
        pnlDivisao.Controls.Add(pnlBotoes, 0, 2);
        pnlDivisao.Dock = DockStyle.Fill;
        pnlDivisao.Location = new Point(0, 0);
        pnlDivisao.Margin = new Padding(0);
        pnlDivisao.Name = "pnlDivisao";
        pnlDivisao.Padding = new Padding(12);
        pnlDivisao.RowCount = 4;
        pnlDivisao.RowStyles.Add(new RowStyle());
        pnlDivisao.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        pnlDivisao.RowStyles.Add(new RowStyle());
        pnlDivisao.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlDivisao.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlDivisao.Size = new Size(420, 520);
        pnlDivisao.TabIndex = 7;
        // 
        // pnlForm
        // 
        pnlForm.ColumnCount = 1;
        pnlForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlForm.Controls.Add(pnlEmail, 0, 0);
        pnlForm.Controls.Add(pnlSenha, 0, 1);
        pnlForm.Controls.Add(chkLembrar, 0, 2);
        pnlForm.Dock = DockStyle.Fill;
        pnlForm.Location = new Point(12, 166);
        pnlForm.Margin = new Padding(0, 100, 0, 0);
        pnlForm.Name = "pnlForm";
        pnlForm.RowCount = 3;
        pnlForm.RowStyles.Add(new RowStyle());
        pnlForm.RowStyles.Add(new RowStyle());
        pnlForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        pnlForm.Size = new Size(396, 210);
        pnlForm.TabIndex = 8;
        // 
        // pnlEmail
        // 
        pnlEmail.AutoSize = true;
        pnlEmail.ColumnCount = 1;
        pnlEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlEmail.Controls.Add(lblEmail, 0, 0);
        pnlEmail.Controls.Add(txtEmail, 0, 1);
        pnlEmail.Dock = DockStyle.Bottom;
        pnlEmail.Location = new Point(0, 0);
        pnlEmail.Margin = new Padding(0, 0, 0, 12);
        pnlEmail.Name = "pnlEmail";
        pnlEmail.RowCount = 2;
        pnlEmail.RowStyles.Add(new RowStyle());
        pnlEmail.RowStyles.Add(new RowStyle());
        pnlEmail.Size = new Size(396, 58);
        pnlEmail.TabIndex = 8;
        // 
        // pnlSenha
        // 
        pnlSenha.AutoSize = true;
        pnlSenha.ColumnCount = 1;
        pnlSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlSenha.Controls.Add(lblSenha, 0, 0);
        pnlSenha.Controls.Add(txtSenha, 0, 1);
        pnlSenha.Dock = DockStyle.Fill;
        pnlSenha.Location = new Point(0, 70);
        pnlSenha.Margin = new Padding(0, 0, 0, 12);
        pnlSenha.Name = "pnlSenha";
        pnlSenha.RowCount = 2;
        pnlSenha.RowStyles.Add(new RowStyle());
        pnlSenha.RowStyles.Add(new RowStyle());
        pnlSenha.Size = new Size(396, 57);
        pnlSenha.TabIndex = 9;
        // 
        // pnlBotoes
        // 
        pnlBotoes.ColumnCount = 1;
        pnlBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        pnlBotoes.Controls.Add(btnEntrar, 0, 0);
        pnlBotoes.Controls.Add(btnCadastrar, 0, 1);
        pnlBotoes.Dock = DockStyle.Fill;
        pnlBotoes.Location = new Point(12, 388);
        pnlBotoes.Margin = new Padding(0, 12, 0, 0);
        pnlBotoes.Name = "pnlBotoes";
        pnlBotoes.RowCount = 2;
        pnlBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        pnlBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        pnlBotoes.Size = new Size(396, 100);
        pnlBotoes.TabIndex = 7;
        // 
        // pnlTopo
        // 
        pnlTopo.AutoSize = true;
        pnlTopo.ColumnCount = 2;
        pnlTopo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlTopo.ColumnStyles.Add(new ColumnStyle());
        pnlTopo.Controls.Add(lblTitulo, 0, 0);
        pnlTopo.Controls.Add(btnFechar, 1, 0);
        pnlTopo.Dock = DockStyle.Top;
        pnlTopo.Location = new Point(15, 15);
        pnlTopo.Name = "pnlTopo";
        pnlTopo.RowCount = 1;
        pnlTopo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        pnlTopo.Size = new Size(390, 48);
        pnlTopo.TabIndex = 2;
        // 
        // FormLogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(420, 520);
        Controls.Add(pnlDivisao);
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login do Sistema";
        pnlDivisao.ResumeLayout(false);
        pnlDivisao.PerformLayout();
        pnlForm.ResumeLayout(false);
        pnlForm.PerformLayout();
        pnlEmail.ResumeLayout(false);
        pnlEmail.PerformLayout();
        pnlSenha.ResumeLayout(false);
        pnlSenha.PerformLayout();
        pnlBotoes.ResumeLayout(false);
        pnlTopo.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Label lblEmail;
    private TextBox txtEmail;
    private Button btnFechar;
    private Label lblTitulo;
    private CheckBox chkLembrar;
    private TextBox txtSenha;
    private Label lblSenha;
    private Button btnEntrar;
    private Button btnCadastrar;
    private TableLayoutPanel pnlDivisao;
    private TableLayoutPanel pnlBotoes;
    private TableLayoutPanel pnlForm;
    private TableLayoutPanel pnlEmail;
    private TableLayoutPanel pnlSenha;
    private TableLayoutPanel pnlTopo;
}
