
namespace Crud
{
    partial class TelaCrud
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
			this.tblRegistros = new System.Windows.Forms.DataGridView();
			this.btnProcurar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtUni = new System.Windows.Forms.TextBox();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtQtd = new System.Windows.Forms.TextBox();
			this.txtProduto = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.tblRegistros)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tblRegistros
			// 
			this.tblRegistros.BackgroundColor = System.Drawing.Color.Tan;
			this.tblRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblRegistros.Location = new System.Drawing.Point(166, 225);
			this.tblRegistros.Name = "tblRegistros";
			this.tblRegistros.RowTemplate.Height = 25;
			this.tblRegistros.Size = new System.Drawing.Size(600, 202);
			this.tblRegistros.TabIndex = 0;
			this.tblRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblRegistros_CellContentClick);
			this.tblRegistros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblRegistros_CellDoubleClick);
			// 
			// btnProcurar
			// 
			this.btnProcurar.BackColor = System.Drawing.SystemColors.Window;
			this.btnProcurar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnProcurar.Location = new System.Drawing.Point(44, 328);
			this.btnProcurar.Name = "btnProcurar";
			this.btnProcurar.Size = new System.Drawing.Size(79, 29);
			this.btnProcurar.TabIndex = 1;
			this.btnProcurar.Text = "Procurar";
			this.btnProcurar.UseVisualStyleBackColor = false;
			this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(327, 167);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 30);
			this.label1.TabIndex = 2;
			this.label1.Text = "Lista de Registros";
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(32, 299);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(100, 23);
			this.txtPesquisa.TabIndex = 3;
			this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Tan;
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtTotal);
			this.groupBox1.Controls.Add(this.txtUni);
			this.groupBox1.Controls.Add(this.btnCadastrar);
			this.groupBox1.Controls.Add(this.btnAlterar);
			this.groupBox1.Controls.Add(this.btnExcluir);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtQtd);
			this.groupBox1.Controls.Add(this.txtProduto);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtCliente);
			this.groupBox1.Location = new System.Drawing.Point(32, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(734, 117);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label9.Location = new System.Drawing.Point(428, 15);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(115, 17);
			this.label9.TabIndex = 18;
			this.label9.Text = "Preço Unitário R$";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(545, 15);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(96, 17);
			this.label8.TabIndex = 16;
			this.label8.Text = "Valor total  R$";
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(543, 35);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 23);
			this.txtTotal.TabIndex = 14;
			this.txtTotal.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// txtUni
			// 
			this.txtUni.Location = new System.Drawing.Point(437, 35);
			this.txtUni.Name = "txtUni";
			this.txtUni.Size = new System.Drawing.Size(100, 23);
			this.txtUni.TabIndex = 13;
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.BackColor = System.Drawing.SystemColors.Window;
			this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCadastrar.Location = new System.Drawing.Point(397, 77);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(92, 34);
			this.btnCadastrar.TabIndex = 6;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackColor = System.Drawing.SystemColors.Window;
			this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnAlterar.Location = new System.Drawing.Point(162, 77);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(92, 34);
			this.btnAlterar.TabIndex = 7;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = false;
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.SystemColors.Window;
			this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnExcluir.Location = new System.Drawing.Point(280, 77);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(92, 34);
			this.btnExcluir.TabIndex = 8;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(325, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 17);
			this.label6.TabIndex = 12;
			this.label6.Text = "Qtd do Produto";
			// 
			// txtQtd
			// 
			this.txtQtd.Location = new System.Drawing.Point(331, 35);
			this.txtQtd.Name = "txtQtd";
			this.txtQtd.Size = new System.Drawing.Size(100, 23);
			this.txtQtd.TabIndex = 11;
			// 
			// txtProduto
			// 
			this.txtProduto.Location = new System.Drawing.Point(119, 35);
			this.txtProduto.Name = "txtProduto";
			this.txtProduto.Size = new System.Drawing.Size(100, 23);
			this.txtProduto.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(140, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Produto";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(12, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Nome do Cliente";
			// 
			// txtCliente
			// 
			this.txtCliente.Location = new System.Drawing.Point(13, 35);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(100, 23);
			this.txtCliente.TabIndex = 7;
			this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(16, 275);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 21);
			this.label2.TabIndex = 5;
			this.label2.Text = "Nome do cliente";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Window;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(505, 77);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 34);
			this.button1.TabIndex = 21;
			this.button1.Text = "Salvar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// TelaCrud
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Bisque;
			this.ClientSize = new System.Drawing.Size(804, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnProcurar);
			this.Controls.Add(this.tblRegistros);
			this.Name = "TelaCrud";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.TelaCrud_Load);
			((System.ComponentModel.ISupportInitialize)(this.tblRegistros)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblRegistros;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtUni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button button1;
	}
}

