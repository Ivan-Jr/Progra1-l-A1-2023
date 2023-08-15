
namespace ejercicios
{
    partial class Form1
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
            this.btnConvertirConversores = new System.Windows.Forms.Button();
            this.lblDeCoversores = new System.Windows.Forms.Label();
            this.cboDeCoversores = new System.Windows.Forms.ComboBox();
            this.cboAConversores = new System.Windows.Forms.ComboBox();
            this.lblACoversores = new System.Windows.Forms.Label();
            this.lblRespuestaConversores = new System.Windows.Forms.Label();
            this.lblCantidadConversores = new System.Windows.Forms.Label();
            this.txtCantidadConversores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvertirConversores
            // 
            this.btnConvertirConversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirConversores.Location = new System.Drawing.Point(203, 277);
            this.btnConvertirConversores.Name = "btnConvertirConversores";
            this.btnConvertirConversores.Size = new System.Drawing.Size(124, 36);
            this.btnConvertirConversores.TabIndex = 0;
            this.btnConvertirConversores.Text = "Convertir";
            this.btnConvertirConversores.UseVisualStyleBackColor = true;
            this.btnConvertirConversores.Click += new System.EventHandler(this.btnConvertirConversores_Click);
            // 
            // lblDeCoversores
            // 
            this.lblDeCoversores.AutoSize = true;
            this.lblDeCoversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeCoversores.Location = new System.Drawing.Point(149, 28);
            this.lblDeCoversores.Name = "lblDeCoversores";
            this.lblDeCoversores.Size = new System.Drawing.Size(42, 22);
            this.lblDeCoversores.TabIndex = 1;
            this.lblDeCoversores.Text = "DE:";
            // 
            // cboDeCoversores
            // 
            this.cboDeCoversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeCoversores.FormattingEnabled = true;
            this.cboDeCoversores.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzales",
            "Lempiras",
            "Colón Salvadoreño",
            "Córdoba",
            "Pesos CR",
            "Yen",
            "Libras Esterlina",
            "Rupia India"});
            this.cboDeCoversores.Location = new System.Drawing.Point(197, 28);
            this.cboDeCoversores.Name = "cboDeCoversores";
            this.cboDeCoversores.Size = new System.Drawing.Size(168, 21);
            this.cboDeCoversores.TabIndex = 2;
            // 
            // cboAConversores
            // 
            this.cboAConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAConversores.FormattingEnabled = true;
            this.cboAConversores.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzales",
            "Lempiras",
            "Colón Salvadoreño",
            "Córdoba",
            "Pesos CR",
            "Yen",
            "Libras Esterlina",
            "Rupia India"});
            this.cboAConversores.Location = new System.Drawing.Point(197, 98);
            this.cboAConversores.Name = "cboAConversores";
            this.cboAConversores.Size = new System.Drawing.Size(168, 21);
            this.cboAConversores.TabIndex = 4;
            // 
            // lblACoversores
            // 
            this.lblACoversores.AutoSize = true;
            this.lblACoversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACoversores.Location = new System.Drawing.Point(149, 98);
            this.lblACoversores.Name = "lblACoversores";
            this.lblACoversores.Size = new System.Drawing.Size(28, 22);
            this.lblACoversores.TabIndex = 3;
            this.lblACoversores.Text = "A:";
            // 
            // lblRespuestaConversores
            // 
            this.lblRespuestaConversores.AutoSize = true;
            this.lblRespuestaConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversores.Location = new System.Drawing.Point(176, 218);
            this.lblRespuestaConversores.Name = "lblRespuestaConversores";
            this.lblRespuestaConversores.Size = new System.Drawing.Size(107, 22);
            this.lblRespuestaConversores.TabIndex = 5;
            this.lblRespuestaConversores.Text = "Respuesta:";
            // 
            // lblCantidadConversores
            // 
            this.lblCantidadConversores.AutoSize = true;
            this.lblCantidadConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadConversores.Location = new System.Drawing.Point(149, 164);
            this.lblCantidadConversores.Name = "lblCantidadConversores";
            this.lblCantidadConversores.Size = new System.Drawing.Size(90, 22);
            this.lblCantidadConversores.TabIndex = 6;
            this.lblCantidadConversores.Text = "Cantidad:";
            // 
            // txtCantidadConversores
            // 
            this.txtCantidadConversores.Location = new System.Drawing.Point(245, 164);
            this.txtCantidadConversores.Name = "txtCantidadConversores";
            this.txtCantidadConversores.Size = new System.Drawing.Size(120, 20);
            this.txtCantidadConversores.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 332);
            this.Controls.Add(this.txtCantidadConversores);
            this.Controls.Add(this.lblCantidadConversores);
            this.Controls.Add(this.lblRespuestaConversores);
            this.Controls.Add(this.cboAConversores);
            this.Controls.Add(this.lblACoversores);
            this.Controls.Add(this.cboDeCoversores);
            this.Controls.Add(this.lblDeCoversores);
            this.Controls.Add(this.btnConvertirConversores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertirConversores;
        private System.Windows.Forms.Label lblDeCoversores;
        private System.Windows.Forms.ComboBox cboDeCoversores;
        private System.Windows.Forms.ComboBox cboAConversores;
        private System.Windows.Forms.Label lblACoversores;
        private System.Windows.Forms.Label lblRespuestaConversores;
        private System.Windows.Forms.Label lblCantidadConversores;
        private System.Windows.Forms.TextBox txtCantidadConversores;
    }
}

