namespace WindowsFormsApp7
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
            this.lbTipo = new System.Windows.Forms.Label();
            this.pnGeral = new System.Windows.Forms.Panel();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lbLado = new System.Windows.Forms.Label();
            this.lbCor = new System.Windows.Forms.Label();
            this.tbMedida = new System.Windows.Forms.TextBox();
            this.pnCor = new System.Windows.Forms.Panel();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.pnGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(25, 38);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(31, 13);
            this.lbTipo.TabIndex = 0;
            this.lbTipo.Text = "Tipo:";
            // 
            // pnGeral
            // 
            this.pnGeral.Controls.Add(this.cbCor);
            this.pnGeral.Controls.Add(this.btFechar);
            this.pnGeral.Controls.Add(this.btLimpar);
            this.pnGeral.Controls.Add(this.btCalcular);
            this.pnGeral.Controls.Add(this.lbResultado);
            this.pnGeral.Controls.Add(this.tbResultado);
            this.pnGeral.Controls.Add(this.pnCor);
            this.pnGeral.Controls.Add(this.tbMedida);
            this.pnGeral.Controls.Add(this.lbCor);
            this.pnGeral.Controls.Add(this.lbLado);
            this.pnGeral.Controls.Add(this.cbTipo);
            this.pnGeral.Controls.Add(this.lbTipo);
            this.pnGeral.Location = new System.Drawing.Point(10, 12);
            this.pnGeral.Name = "pnGeral";
            this.pnGeral.Size = new System.Drawing.Size(464, 355);
            this.pnGeral.TabIndex = 1;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Quadrado",
            "Círculo"});
            this.cbTipo.Location = new System.Drawing.Point(66, 35);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 1;
            // 
            // lbLado
            // 
            this.lbLado.AutoSize = true;
            this.lbLado.Location = new System.Drawing.Point(18, 99);
            this.lbLado.Name = "lbLado";
            this.lbLado.Size = new System.Drawing.Size(42, 13);
            this.lbLado.TabIndex = 2;
            this.lbLado.Text = "Medida";
            // 
            // lbCor
            // 
            this.lbCor.AutoSize = true;
            this.lbCor.Location = new System.Drawing.Point(28, 149);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(26, 13);
            this.lbCor.TabIndex = 3;
            this.lbCor.Text = "Cor:";
            // 
            // tbMedida
            // 
            this.tbMedida.Location = new System.Drawing.Point(66, 96);
            this.tbMedida.Name = "tbMedida";
            this.tbMedida.Size = new System.Drawing.Size(121, 20);
            this.tbMedida.TabIndex = 4;
            // 
            // pnCor
            // 
            this.pnCor.Location = new System.Drawing.Point(303, 31);
            this.pnCor.Name = "pnCor";
            this.pnCor.Size = new System.Drawing.Size(125, 118);
            this.pnCor.TabIndex = 6;
            this.pnCor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCor_Paint);
            // 
            // tbResultado
            // 
            this.tbResultado.Enabled = false;
            this.tbResultado.Location = new System.Drawing.Point(303, 197);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(109, 20);
            this.tbResultado.TabIndex = 7;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(333, 171);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(60, 13);
            this.lbResultado.TabIndex = 8;
            this.lbResultado.Text = "Resulltado:";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(28, 293);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 9;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(160, 293);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 10;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(303, 293);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 11;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // cbCor
            // 
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Items.AddRange(new object[] {
            "Vermelho",
            "Azul",
            "Verde",
            "Rosa",
            "Laranja"});
            this.cbCor.Location = new System.Drawing.Point(66, 140);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(121, 21);
            this.cbCor.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnGeral);
            this.Name = "Form1";
            this.Text = "Figura";
            this.pnGeral.ResumeLayout(false);
            this.pnGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Panel pnGeral;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Panel pnCor;
        private System.Windows.Forms.TextBox tbMedida;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.Label lbLado;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbCor;
    }
}

