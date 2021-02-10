
namespace Gerador
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cbController = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStoredProcedure = new System.Windows.Forms.TextBox();
            this.gridEntrada = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exemplo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridSaida = new System.Windows.Forms.DataGridView();
            this.TipoSaida = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NomeSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbRetornaList = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoMetodo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSalvarEm = new System.Windows.Forms.TextBox();
            this.btnSalvarEm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeEndPoint = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFinalidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // cbController
            // 
            this.cbController.FormattingEnabled = true;
            this.cbController.Items.AddRange(new object[] {
            "Agency",
            "Bank",
            "BillingData",
            "Booking",
            "BookingPenalty",
            "CallCenter",
            "ContactDepartmentHotels",
            "Customer",
            "CustomerServiceProgress",
            "DisregardModalityChange",
            "ETickets",
            "Hotel",
            "IndicationsCustomers",
            "MonthlyPayment",
            "Negotiation",
            "Packages",
            "Plans",
            "Protocol",
            "SendSMS",
            "Voucher"});
            this.cbController.Location = new System.Drawing.Point(69, 22);
            this.cbController.Name = "cbController";
            this.cbController.Size = new System.Drawing.Size(214, 21);
            this.cbController.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salvar Em";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SP";
            // 
            // txtStoredProcedure
            // 
            this.txtStoredProcedure.Location = new System.Drawing.Point(346, 22);
            this.txtStoredProcedure.Name = "txtStoredProcedure";
            this.txtStoredProcedure.Size = new System.Drawing.Size(299, 20);
            this.txtStoredProcedure.TabIndex = 1;
            // 
            // gridEntrada
            // 
            this.gridEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Nome,
            this.Exemplo,
            this.Observacao});
            this.gridEntrada.Location = new System.Drawing.Point(15, 185);
            this.gridEntrada.Name = "gridEntrada";
            this.gridEntrada.Size = new System.Drawing.Size(560, 289);
            this.gridEntrada.TabIndex = 11;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Items.AddRange(new object[] {
            "int",
            "int?",
            "string",
            "bool",
            "DateTime",
            "DateTime?"});
            this.Tipo.Name = "Tipo";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Exemplo
            // 
            this.Exemplo.HeaderText = "Exemplo";
            this.Exemplo.Name = "Exemplo";
            // 
            // Observacao
            // 
            this.Observacao.HeaderText = "Observação";
            this.Observacao.Name = "Observacao";
            // 
            // gridSaida
            // 
            this.gridSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoSaida,
            this.NomeSaida});
            this.gridSaida.Location = new System.Drawing.Point(581, 185);
            this.gridSaida.Name = "gridSaida";
            this.gridSaida.Size = new System.Drawing.Size(325, 289);
            this.gridSaida.TabIndex = 12;
            // 
            // TipoSaida
            // 
            this.TipoSaida.HeaderText = "Tipo";
            this.TipoSaida.Items.AddRange(new object[] {
            "int",
            "int?",
            "string",
            "bool",
            "DateTime",
            "DateTime?"});
            this.TipoSaida.Name = "TipoSaida";
            // 
            // NomeSaida
            // 
            this.NomeSaida.HeaderText = "Nome";
            this.NomeSaida.Name = "NomeSaida";
            // 
            // cbRetornaList
            // 
            this.cbRetornaList.AutoSize = true;
            this.cbRetornaList.Location = new System.Drawing.Point(664, 24);
            this.cbRetornaList.Name = "cbRetornaList";
            this.cbRetornaList.Size = new System.Drawing.Size(83, 17);
            this.cbRetornaList.TabIndex = 2;
            this.cbRetornaList.Text = "Retorna List";
            this.cbRetornaList.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parâmetros de Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parâmetros de Saída";
            // 
            // cbTipoMetodo
            // 
            this.cbTipoMetodo.FormattingEnabled = true;
            this.cbTipoMetodo.Items.AddRange(new object[] {
            "HttpGet",
            "HttpPost",
            "HttpDelete",
            "HttpPut"});
            this.cbTipoMetodo.Location = new System.Drawing.Point(83, 58);
            this.cbTipoMetodo.Name = "cbTipoMetodo";
            this.cbTipoMetodo.Size = new System.Drawing.Size(200, 21);
            this.cbTipoMetodo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tipo Metodo";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSalvarEm
            // 
            this.txtSalvarEm.Location = new System.Drawing.Point(369, 58);
            this.txtSalvarEm.Name = "txtSalvarEm";
            this.txtSalvarEm.Size = new System.Drawing.Size(299, 20);
            this.txtSalvarEm.TabIndex = 4;
            this.txtSalvarEm.Text = "C:\\!";
            // 
            // btnSalvarEm
            // 
            this.btnSalvarEm.Location = new System.Drawing.Point(699, 57);
            this.btnSalvarEm.Name = "btnSalvarEm";
            this.btnSalvarEm.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEm.TabIndex = 5;
            this.btnSalvarEm.Text = "Salvar Em";
            this.btnSalvarEm.UseVisualStyleBackColor = true;
            this.btnSalvarEm.Click += new System.EventHandler(this.btnSalvarEm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Controller";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nome do EndPoint";
            // 
            // txtNomeEndPoint
            // 
            this.txtNomeEndPoint.Location = new System.Drawing.Point(395, 96);
            this.txtNomeEndPoint.Name = "txtNomeEndPoint";
            this.txtNomeEndPoint.Size = new System.Drawing.Size(299, 20);
            this.txtNomeEndPoint.TabIndex = 7;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(700, 95);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 8;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Namespace";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(80, 96);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(197, 20);
            this.txtNamespace.TabIndex = 6;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 135);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(80, 131);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(203, 20);
            this.txtDescricao.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Finalidade";
            // 
            // txtFinalidade
            // 
            this.txtFinalidade.Location = new System.Drawing.Point(364, 132);
            this.txtFinalidade.Name = "txtFinalidade";
            this.txtFinalidade.Size = new System.Drawing.Size(299, 20);
            this.txtFinalidade.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(671, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Retorno";
            // 
            // txtRetorno
            // 
            this.txtRetorno.Location = new System.Drawing.Point(715, 136);
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.Size = new System.Drawing.Size(191, 20);
            this.txtRetorno.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 490);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnSalvarEm);
            this.Controls.Add(this.cbRetornaList);
            this.Controls.Add(this.gridSaida);
            this.Controls.Add(this.gridEntrada);
            this.Controls.Add(this.txtSalvarEm);
            this.Controls.Add(this.txtRetorno);
            this.Controls.Add(this.txtFinalidade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNamespace);
            this.Controls.Add(this.txtNomeEndPoint);
            this.Controls.Add(this.txtStoredProcedure);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoMetodo);
            this.Controls.Add(this.cbController);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador EndPoint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbController;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStoredProcedure;
        private System.Windows.Forms.DataGridView gridEntrada;
        private System.Windows.Forms.DataGridView gridSaida;
        private System.Windows.Forms.CheckBox cbRetornaList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoMetodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSalvarEm;
        private System.Windows.Forms.Button btnSalvarEm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeEndPoint;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewComboBoxColumn TipoSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exemplo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFinalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRetorno;
    }
}

