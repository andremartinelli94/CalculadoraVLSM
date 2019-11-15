namespace Calculadora_VLSM_Redes_de_Computadores_
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblMaskBinario = new System.Windows.Forms.Label();
            this.txtIpBinario = new System.Windows.Forms.TextBox();
            this.richResult = new System.Windows.Forms.RichTextBox();
            this.btnAddHosts = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grpSubNet = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.numHosts = new System.Windows.Forms.NumericUpDown();
            this.txtMaskBinario = new System.Windows.Forms.TextBox();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMask = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskIP = new System.Windows.Forms.MaskedTextBox();
            this.lblIpBinario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpSubNet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHosts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblMaskBinario
            // 
            this.lblMaskBinario.AutoSize = true;
            this.lblMaskBinario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaskBinario.Location = new System.Drawing.Point(334, 164);
            this.lblMaskBinario.Name = "lblMaskBinario";
            this.lblMaskBinario.Size = new System.Drawing.Size(102, 15);
            this.lblMaskBinario.TabIndex = 66;
            this.lblMaskBinario.Text = "Mascara binario:";
            this.lblMaskBinario.Visible = false;
            // 
            // txtIpBinario
            // 
            this.txtIpBinario.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIpBinario.Location = new System.Drawing.Point(102, 161);
            this.txtIpBinario.Name = "txtIpBinario";
            this.txtIpBinario.Size = new System.Drawing.Size(210, 21);
            this.txtIpBinario.TabIndex = 67;
            this.txtIpBinario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIpBinario.Visible = false;
            // 
            // richResult
            // 
            this.richResult.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richResult.Location = new System.Drawing.Point(8, 425);
            this.richResult.Name = "richResult";
            this.richResult.Size = new System.Drawing.Size(826, 247);
            this.richResult.TabIndex = 69;
            this.richResult.Text = "";
            this.richResult.Visible = false;
            // 
            // btnAddHosts
            // 
            this.btnAddHosts.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddHosts.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHosts.Location = new System.Drawing.Point(358, 102);
            this.btnAddHosts.Name = "btnAddHosts";
            this.btnAddHosts.Size = new System.Drawing.Size(121, 31);
            this.btnAddHosts.TabIndex = 55;
            this.btnAddHosts.Text = "Adicionar";
            this.btnAddHosts.UseVisualStyleBackColor = false;
            this.btnAddHosts.Click += new System.EventHandler(this.btnAddHosts_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(358, 139);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 31);
            this.btnCalcular.TabIndex = 54;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grpSubNet
            // 
            this.grpSubNet.Controls.Add(this.btnAddHosts);
            this.grpSubNet.Controls.Add(this.btnCalcular);
            this.grpSubNet.Controls.Add(this.label6);
            this.grpSubNet.Controls.Add(this.dataGridView);
            this.grpSubNet.Controls.Add(this.numHosts);
            this.grpSubNet.Location = new System.Drawing.Point(8, 200);
            this.grpSubNet.Name = "grpSubNet";
            this.grpSubNet.Size = new System.Drawing.Size(509, 219);
            this.grpSubNet.TabIndex = 68;
            this.grpSubNet.TabStop = false;
            this.grpSubNet.Text = "Sub Redes";
            this.grpSubNet.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 52;
            this.label6.Text = "Quantidade de hosts:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 24);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(344, 172);
            this.dataGridView.TabIndex = 50;
            // 
            // numHosts
            // 
            this.numHosts.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHosts.Location = new System.Drawing.Point(359, 75);
            this.numHosts.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numHosts.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numHosts.Name = "numHosts";
            this.numHosts.Size = new System.Drawing.Size(120, 21);
            this.numHosts.TabIndex = 51;
            this.numHosts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numHosts.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txtMaskBinario
            // 
            this.txtMaskBinario.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaskBinario.Location = new System.Drawing.Point(442, 161);
            this.txtMaskBinario.Name = "txtMaskBinario";
            this.txtMaskBinario.Size = new System.Drawing.Size(210, 21);
            this.txtMaskBinario.TabIndex = 70;
            this.txtMaskBinario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaskBinario.Visible = false;
            // 
            // txtMask
            // 
            this.txtMask.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMask.Location = new System.Drawing.Point(442, 138);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(140, 21);
            this.txtMask.TabIndex = 65;
            this.txtMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMask.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(715, 102);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 31);
            this.btnReset.TabIndex = 64;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMask.Location = new System.Drawing.Point(333, 140);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(103, 15);
            this.lblMask.TabIndex = 62;
            this.lblMask.Text = "Mascara padrão:";
            this.lblMask.Visible = false;
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(442, 115);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(64, 20);
            this.txtClass.TabIndex = 61;
            this.txtClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClass.Visible = false;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(387, 118);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(49, 15);
            this.lblClass.TabIndex = 59;
            this.lblClass.Text = "Classe:";
            this.lblClass.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 19);
            this.label2.TabIndex = 58;
            this.label2.Text = "CALCULADORA VLSM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "REDES DE COMPUTADORES";
            // 
            // mskIP
            // 
            this.mskIP.Location = new System.Drawing.Point(145, 22);
            this.mskIP.Mask = "000.000.000.000";
            this.mskIP.Name = "mskIP";
            this.mskIP.Size = new System.Drawing.Size(140, 20);
            this.mskIP.TabIndex = 56;
            this.mskIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIpBinario
            // 
            this.lblIpBinario.AutoSize = true;
            this.lblIpBinario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpBinario.Location = new System.Drawing.Point(6, 53);
            this.lblIpBinario.Name = "lblIpBinario";
            this.lblIpBinario.Size = new System.Drawing.Size(63, 15);
            this.lblIpBinario.TabIndex = 49;
            this.lblIpBinario.Text = "IP binario:";
            this.lblIpBinario.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Informe o IP desejado:";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(588, 102);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 31);
            this.btnNext.TabIndex = 63;
            this.btnNext.Text = "Prosseguir";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskIP);
            this.groupBox1.Controls.Add(this.lblIpBinario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(27, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 81);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Início";
            // 
            // btnAlunos
            // 
            this.btnAlunos.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlunos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlunos.Location = new System.Drawing.Point(715, 388);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(121, 31);
            this.btnAlunos.TabIndex = 71;
            this.btnAlunos.Text = "Integrantes";
            this.btnAlunos.UseVisualStyleBackColor = false;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 27);
            this.panel1.TabIndex = 72;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 684);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.lblMaskBinario);
            this.Controls.Add(this.txtIpBinario);
            this.Controls.Add(this.richResult);
            this.Controls.Add(this.grpSubNet);
            this.Controls.Add(this.txtMaskBinario);
            this.Controls.Add(this.txtMask);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpSubNet.ResumeLayout(false);
            this.grpSubNet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHosts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblMaskBinario;
        private System.Windows.Forms.TextBox txtIpBinario;
        private System.Windows.Forms.RichTextBox richResult;
        private System.Windows.Forms.Button btnAddHosts;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grpSubNet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.NumericUpDown numHosts;
        private System.Windows.Forms.TextBox txtMaskBinario;
        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskIP;
        private System.Windows.Forms.Label lblIpBinario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Panel panel1;
    }
}

