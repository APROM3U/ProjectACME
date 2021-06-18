
namespace cad_voo
{
    partial class Ecma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.dtVoo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNivel = new System.Windows.Forms.Label();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.lblCaptura = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gvConsulta = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Location = new System.Drawing.Point(465, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(134, 22);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(122, 28);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(6, 22);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(122, 28);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSim);
            this.groupBox2.Controls.Add(this.txtNivel);
            this.groupBox2.Controls.Add(this.txtDistancia);
            this.groupBox2.Controls.Add(this.txtCusto);
            this.groupBox2.Controls.Add(this.dtVoo);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.lblNivel);
            this.groupBox2.Controls.Add(this.rbNao);
            this.groupBox2.Controls.Add(this.lblCaptura);
            this.groupBox2.Controls.Add(this.lblDistancia);
            this.groupBox2.Controls.Add(this.lblCusto);
            this.groupBox2.Controls.Add(this.lblData);
            this.groupBox2.Location = new System.Drawing.Point(465, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 315);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // rbSim
            // 
            this.rbSim.Location = new System.Drawing.Point(192, 106);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(61, 24);
            this.rbSim.TabIndex = 6;
            this.rbSim.Text = "Sim";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(125, 134);
            this.txtNivel.MaxLength = 2;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(131, 23);
            this.txtNivel.TabIndex = 7;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(125, 80);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(131, 23);
            this.txtDistancia.TabIndex = 4;
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(125, 51);
            this.txtCusto.MaxLength = 10;
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(131, 23);
            this.txtCusto.TabIndex = 3;
            this.txtCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtVoo
            // 
            this.dtVoo.Location = new System.Drawing.Point(125, 22);
            this.dtVoo.Name = "dtVoo";
            this.dtVoo.Size = new System.Drawing.Size(131, 23);
            this.dtVoo.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(155, 254);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(27, 254);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(122, 28);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(27, 142);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(55, 15);
            this.lblNivel.TabIndex = 6;
            this.lblNivel.Text = "Nível dor";
            // 
            // rbNao
            // 
            this.rbNao.Location = new System.Drawing.Point(125, 106);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(61, 24);
            this.rbNao.TabIndex = 5;
            this.rbNao.Text = "Não";
            // 
            // lblCaptura
            // 
            this.lblCaptura.AutoSize = true;
            this.lblCaptura.Location = new System.Drawing.Point(27, 111);
            this.lblCaptura.Name = "lblCaptura";
            this.lblCaptura.Size = new System.Drawing.Size(49, 15);
            this.lblCaptura.TabIndex = 3;
            this.lblCaptura.Text = "Captura";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(27, 88);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(55, 15);
            this.lblDistancia.TabIndex = 2;
            this.lblDistancia.Text = "Distância";
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(27, 59);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(38, 15);
            this.lblCusto.TabIndex = 1;
            this.lblCusto.Text = "Custo";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(27, 30);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(31, 15);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gvConsulta);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 382);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // gvConsulta
            // 
            this.gvConsulta.AllowUserToAddRows = false;
            this.gvConsulta.AllowUserToDeleteRows = false;
            this.gvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvConsulta.Location = new System.Drawing.Point(3, 19);
            this.gvConsulta.Name = "gvConsulta";
            this.gvConsulta.ReadOnly = true;
            this.gvConsulta.RowTemplate.Height = 25;
            this.gvConsulta.Size = new System.Drawing.Size(441, 360);
            this.gvConsulta.TabIndex = 0;
            this.gvConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvConsulta_CellDoubleClick);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(640, 400);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(131, 23);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.Visible = false;
            // 
            // Ecma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 463);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ecma";
            this.Text = "ACME FLIGHT MANAGER";
            this.Load += new System.EventHandler(this.Ecma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox dtVoo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblCaptura;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gvConsulta;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}

