namespace SalaoBeleza.Desktop
{
    partial class FormDashboard
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
            tblDivisao = new TableLayoutPanel();
            pnlAgendamentos = new TableLayoutPanel();
            lblAgendamentos = new Label();
            lblSubAgendamentos = new Label();
            dgvDados = new DataGridView();
            pnlAgendar = new Panel();
            btnAgendar = new Button();
            tblFormulario = new TableLayoutPanel();
            lblServico = new Label();
            cbxServico = new ComboBox();
            lblData = new Label();
            dtpData = new DateTimePicker();
            lblHorario = new Label();
            cbxHorario = new ComboBox();
            lblCliente = new Label();
            textBox1 = new TextBox();
            lblSub = new Label();
            lblTitulo = new Label();
            tblDivisao.SuspendLayout();
            pnlAgendamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            pnlAgendar.SuspendLayout();
            tblFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // tblDivisao
            // 
            tblDivisao.ColumnCount = 2;
            tblDivisao.ColumnStyles.Add(new ColumnStyle());
            tblDivisao.ColumnStyles.Add(new ColumnStyle());
            tblDivisao.Controls.Add(pnlAgendamentos, 1, 0);
            tblDivisao.Controls.Add(pnlAgendar, 0, 0);
            tblDivisao.Dock = DockStyle.Fill;
            tblDivisao.Location = new Point(8, 8);
            tblDivisao.Name = "tblDivisao";
            tblDivisao.RowCount = 1;
            tblDivisao.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblDivisao.Size = new Size(1248, 665);
            tblDivisao.TabIndex = 0;
            // 
            // pnlAgendamentos
            // 
            pnlAgendamentos.ColumnCount = 1;
            pnlAgendamentos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlAgendamentos.Controls.Add(lblAgendamentos, 0, 0);
            pnlAgendamentos.Controls.Add(lblSubAgendamentos, 0, 1);
            pnlAgendamentos.Controls.Add(dgvDados, 0, 2);
            pnlAgendamentos.Dock = DockStyle.Fill;
            pnlAgendamentos.Location = new Point(386, 0);
            pnlAgendamentos.Margin = new Padding(12, 0, 0, 0);
            pnlAgendamentos.Name = "pnlAgendamentos";
            pnlAgendamentos.Padding = new Padding(20);
            pnlAgendamentos.RowCount = 2;
            pnlAgendamentos.RowStyles.Add(new RowStyle());
            pnlAgendamentos.RowStyles.Add(new RowStyle());
            pnlAgendamentos.RowStyles.Add(new RowStyle());
            pnlAgendamentos.Size = new Size(862, 665);
            pnlAgendamentos.TabIndex = 3;
            // 
            // lblAgendamentos
            // 
            lblAgendamentos.AutoSize = true;
            lblAgendamentos.Dock = DockStyle.Top;
            lblAgendamentos.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblAgendamentos.ForeColor = Color.White;
            lblAgendamentos.Location = new Point(20, 20);
            lblAgendamentos.Margin = new Padding(0);
            lblAgendamentos.Name = "lblAgendamentos";
            lblAgendamentos.Size = new Size(822, 32);
            lblAgendamentos.TabIndex = 0;
            lblAgendamentos.Text = "Seus agendamentos";
            // 
            // lblSubAgendamentos
            // 
            lblSubAgendamentos.AutoSize = true;
            lblSubAgendamentos.Dock = DockStyle.Top;
            lblSubAgendamentos.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSubAgendamentos.ForeColor = Color.FromArgb(152, 149, 157);
            lblSubAgendamentos.Location = new Point(20, 52);
            lblSubAgendamentos.Margin = new Padding(0, 0, 0, 12);
            lblSubAgendamentos.Name = "lblSubAgendamentos";
            lblSubAgendamentos.Size = new Size(822, 21);
            lblSubAgendamentos.TabIndex = 1;
            lblSubAgendamentos.Text = "Consulte abaixo os seus últimos agendamentos";
            // 
            // dgvDados
            // 
            dgvDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(20, 85);
            dgvDados.Margin = new Padding(0);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(822, 560);
            dgvDados.TabIndex = 2;
            // 
            // pnlAgendar
            // 
            pnlAgendar.BackColor = Color.FromArgb(35, 34, 37);
            pnlAgendar.Controls.Add(btnAgendar);
            pnlAgendar.Controls.Add(tblFormulario);
            pnlAgendar.Controls.Add(lblSub);
            pnlAgendar.Controls.Add(lblTitulo);
            pnlAgendar.Dock = DockStyle.Fill;
            pnlAgendar.Location = new Point(0, 0);
            pnlAgendar.Margin = new Padding(0);
            pnlAgendar.MaximumSize = new Size(498, 0);
            pnlAgendar.Name = "pnlAgendar";
            pnlAgendar.Padding = new Padding(20);
            pnlAgendar.Size = new Size(374, 665);
            pnlAgendar.TabIndex = 0;
            // 
            // btnAgendar
            // 
            btnAgendar.Dock = DockStyle.Bottom;
            btnAgendar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnAgendar.Location = new Point(20, 605);
            btnAgendar.Margin = new Padding(0);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(334, 40);
            btnAgendar.TabIndex = 3;
            btnAgendar.Text = "Agendar Horário";
            btnAgendar.UseVisualStyleBackColor = true;
            // 
            // tblFormulario
            // 
            tblFormulario.AutoSize = true;
            tblFormulario.ColumnCount = 1;
            tblFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblFormulario.Controls.Add(lblServico, 0, 0);
            tblFormulario.Controls.Add(cbxServico, 0, 1);
            tblFormulario.Controls.Add(lblData, 0, 2);
            tblFormulario.Controls.Add(dtpData, 0, 3);
            tblFormulario.Controls.Add(lblHorario, 0, 4);
            tblFormulario.Controls.Add(cbxHorario, 0, 5);
            tblFormulario.Controls.Add(lblCliente, 0, 6);
            tblFormulario.Controls.Add(textBox1, 0, 7);
            tblFormulario.Dock = DockStyle.Top;
            tblFormulario.Location = new Point(20, 96);
            tblFormulario.Margin = new Padding(0);
            tblFormulario.Name = "tblFormulario";
            tblFormulario.RowCount = 8;
            tblFormulario.RowStyles.Add(new RowStyle());
            tblFormulario.RowStyles.Add(new RowStyle());
            tblFormulario.RowStyles.Add(new RowStyle());
            tblFormulario.RowStyles.Add(new RowStyle());
            tblFormulario.RowStyles.Add(new RowStyle());
            tblFormulario.RowStyles.Add(new RowStyle());
            tblFormulario.RowStyles.Add(new RowStyle());
            tblFormulario.RowStyles.Add(new RowStyle());
            tblFormulario.Size = new Size(334, 340);
            tblFormulario.TabIndex = 2;
            // 
            // lblServico
            // 
            lblServico.AutoSize = true;
            lblServico.Dock = DockStyle.Top;
            lblServico.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblServico.ForeColor = Color.FromArgb(178, 175, 182);
            lblServico.Location = new Point(0, 32);
            lblServico.Margin = new Padding(0, 32, 0, 8);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(334, 21);
            lblServico.TabIndex = 0;
            lblServico.Text = "Serviço";
            // 
            // cbxServico
            // 
            cbxServico.Dock = DockStyle.Top;
            cbxServico.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbxServico.FormattingEnabled = true;
            cbxServico.Items.AddRange(new object[] { "Cabelo", "Unha", "Hidratação" });
            cbxServico.Location = new Point(0, 61);
            cbxServico.Margin = new Padding(0, 0, 0, 32);
            cbxServico.Name = "cbxServico";
            cbxServico.Size = new Size(334, 29);
            cbxServico.TabIndex = 3;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblData.ForeColor = Color.FromArgb(178, 175, 182);
            lblData.Location = new Point(0, 122);
            lblData.Margin = new Padding(0, 0, 0, 8);
            lblData.Name = "lblData";
            lblData.Size = new Size(46, 21);
            lblData.TabIndex = 1;
            lblData.Text = "Data";
            // 
            // dtpData
            // 
            dtpData.Dock = DockStyle.Top;
            dtpData.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(0, 151);
            dtpData.Margin = new Padding(0, 0, 0, 12);
            dtpData.MinDate = new DateTime(2025, 10, 1, 0, 0, 0, 0);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(334, 29);
            dtpData.TabIndex = 4;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblHorario.ForeColor = Color.FromArgb(178, 175, 182);
            lblHorario.Location = new Point(0, 192);
            lblHorario.Margin = new Padding(0, 0, 0, 8);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(68, 21);
            lblHorario.TabIndex = 2;
            lblHorario.Text = "Horário";
            // 
            // cbxHorario
            // 
            cbxHorario.Dock = DockStyle.Top;
            cbxHorario.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbxHorario.FormattingEnabled = true;
            cbxHorario.Location = new Point(0, 221);
            cbxHorario.Margin = new Padding(0, 0, 0, 32);
            cbxHorario.Name = "cbxHorario";
            cbxHorario.Size = new Size(334, 29);
            cbxHorario.TabIndex = 5;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCliente.ForeColor = Color.FromArgb(178, 175, 182);
            lblCliente.Location = new Point(0, 282);
            lblCliente.Margin = new Padding(0, 0, 0, 8);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(64, 21);
            lblCliente.TabIndex = 6;
            lblCliente.Text = "Cliente";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox1.Location = new Point(0, 311);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 29);
            textBox1.TabIndex = 7;
            // 
            // lblSub
            // 
            lblSub.Dock = DockStyle.Top;
            lblSub.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            lblSub.ForeColor = Color.FromArgb(152, 149, 157);
            lblSub.Location = new Point(20, 54);
            lblSub.Margin = new Padding(0);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(334, 42);
            lblSub.TabIndex = 1;
            lblSub.Text = "Selecione o serviço, a data e informe o horário para criar o agendamento";
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(334, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agende um atendimento";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 24, 27);
            ClientSize = new Size(1264, 681);
            Controls.Add(tblDivisao);
            MinimumSize = new Size(1280, 720);
            Name = "FormDashboard";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salão de Beleza - Agendamento";
            tblDivisao.ResumeLayout(false);
            pnlAgendamentos.ResumeLayout(false);
            pnlAgendamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            pnlAgendar.ResumeLayout(false);
            pnlAgendar.PerformLayout();
            tblFormulario.ResumeLayout(false);
            tblFormulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblDivisao;
        private Panel pnlAgendar;
        private Label lblSub;
        private Label lblTitulo;
        private TableLayoutPanel tblFormulario;
        private Label lblServico;
        private Label lblHorario;
        private ComboBox cbxServico;
        private ComboBox cbxHorario;
        private Label lblData;
        private Button btnAgendar;
        private Label lblAgendamentos;
        private Label lblSubAgendamentos;
        private DataGridView dgvDados;
        private DateTimePicker dtpData;
        private Label lblCliente;
        private TextBox textBox1;
        private TableLayoutPanel pnlAgendamentos;
    }
}