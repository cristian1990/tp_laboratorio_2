namespace MiCalculadora
{
    partial class LaCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.BtnOperar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnConvertirABinario = new System.Windows.Forms.Button();
            this.BtnConvertirADecimal = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.CmpOperador = new System.Windows.Forms.ComboBox();
            this.TtValidacion = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero1.Location = new System.Drawing.Point(55, 93);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(98, 29);
            this.txtNumero1.TabIndex = 0;
            this.txtNumero1.MouseHover += new System.EventHandler(this.txtNumero1_MouseHover);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.Location = new System.Drawing.Point(291, 93);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(97, 29);
            this.txtNumero2.TabIndex = 1;
            this.txtNumero2.MouseHover += new System.EventHandler(this.txtNumero2_MouseHover);
            // 
            // BtnOperar
            // 
            this.BtnOperar.Location = new System.Drawing.Point(55, 163);
            this.BtnOperar.Name = "BtnOperar";
            this.BtnOperar.Size = new System.Drawing.Size(98, 34);
            this.BtnOperar.TabIndex = 2;
            this.BtnOperar.Text = "Operar";
            this.BtnOperar.UseVisualStyleBackColor = true;
            this.BtnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(173, 163);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(98, 34);
            this.BtnLimpiar.TabIndex = 3;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(291, 163);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(98, 34);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnConvertirABinario
            // 
            this.BtnConvertirABinario.Location = new System.Drawing.Point(54, 220);
            this.BtnConvertirABinario.Name = "BtnConvertirABinario";
            this.BtnConvertirABinario.Size = new System.Drawing.Size(160, 34);
            this.BtnConvertirABinario.TabIndex = 5;
            this.BtnConvertirABinario.Text = "Convertir a Binario";
            this.BtnConvertirABinario.UseVisualStyleBackColor = true;
            this.BtnConvertirABinario.Click += new System.EventHandler(this.BtnConvertirABinario_Click);
            // 
            // BtnConvertirADecimal
            // 
            this.BtnConvertirADecimal.Location = new System.Drawing.Point(228, 220);
            this.BtnConvertirADecimal.Name = "BtnConvertirADecimal";
            this.BtnConvertirADecimal.Size = new System.Drawing.Size(160, 34);
            this.BtnConvertirADecimal.TabIndex = 6;
            this.BtnConvertirADecimal.Text = "Convertir a Decimal";
            this.BtnConvertirADecimal.UseVisualStyleBackColor = true;
            this.BtnConvertirADecimal.Click += new System.EventHandler(this.BtnConvertirADecimal_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(214, 44);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(175, 32);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmpOperador
            // 
            this.CmpOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmpOperador.FormattingEnabled = true;
            this.CmpOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.CmpOperador.Location = new System.Drawing.Point(175, 93);
            this.CmpOperador.Name = "CmpOperador";
            this.CmpOperador.Size = new System.Drawing.Size(96, 28);
            this.CmpOperador.TabIndex = 8;
            // 
            // LaCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 294);
            this.Controls.Add(this.CmpOperador);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.BtnConvertirADecimal);
            this.Controls.Add(this.BtnConvertirABinario);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnOperar);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LaCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Cristian Silva 2C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button BtnOperar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnConvertirABinario;
        private System.Windows.Forms.Button BtnConvertirADecimal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox CmpOperador;
        private System.Windows.Forms.ToolTip TtValidacion;
    }
}

