namespace parcial2lab2_FioriTomas_CabanayMauro
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
            this.label2 = new System.Windows.Forms.Label();
            this.rbtmCamisa = new System.Windows.Forms.RadioButton();
            this.rbtmPantalon = new System.Windows.Forms.RadioButton();
            this.cbxManga_corta = new System.Windows.Forms.CheckBox();
            this.cbxBermuda = new System.Windows.Forms.CheckBox();
            this.rbtmStandard = new System.Windows.Forms.RadioButton();
            this.rbtmPremium = new System.Windows.Forms.RadioButton();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCalcular_precio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "VENTAS AL POR MAYOR";
            // 
            // rbtmCamisa
            // 
            this.rbtmCamisa.AutoSize = true;
            this.rbtmCamisa.Location = new System.Drawing.Point(46, 22);
            this.rbtmCamisa.Name = "rbtmCamisa";
            this.rbtmCamisa.Size = new System.Drawing.Size(75, 21);
            this.rbtmCamisa.TabIndex = 2;
            this.rbtmCamisa.TabStop = true;
            this.rbtmCamisa.Text = "Camisa";
            this.rbtmCamisa.UseVisualStyleBackColor = true;
            this.rbtmCamisa.CheckedChanged += new System.EventHandler(this.rbtmCamisa_CheckedChanged);
            // 
            // rbtmPantalon
            // 
            this.rbtmPantalon.AutoSize = true;
            this.rbtmPantalon.Location = new System.Drawing.Point(46, 50);
            this.rbtmPantalon.Name = "rbtmPantalon";
            this.rbtmPantalon.Size = new System.Drawing.Size(85, 21);
            this.rbtmPantalon.TabIndex = 3;
            this.rbtmPantalon.TabStop = true;
            this.rbtmPantalon.Text = "Pantalon";
            this.rbtmPantalon.UseVisualStyleBackColor = true;
            this.rbtmPantalon.CheckedChanged += new System.EventHandler(this.rbtmPantalon_CheckedChanged);
            // 
            // cbxManga_corta
            // 
            this.cbxManga_corta.AutoSize = true;
            this.cbxManga_corta.Location = new System.Drawing.Point(168, 22);
            this.cbxManga_corta.Name = "cbxManga_corta";
            this.cbxManga_corta.Size = new System.Drawing.Size(109, 21);
            this.cbxManga_corta.TabIndex = 4;
            this.cbxManga_corta.Text = "Manga corta";
            this.cbxManga_corta.UseVisualStyleBackColor = true;
            this.cbxManga_corta.CheckedChanged += new System.EventHandler(this.cbxManga_corta_CheckedChanged);
            // 
            // cbxBermuda
            // 
            this.cbxBermuda.AutoSize = true;
            this.cbxBermuda.Location = new System.Drawing.Point(168, 50);
            this.cbxBermuda.Name = "cbxBermuda";
            this.cbxBermuda.Size = new System.Drawing.Size(87, 21);
            this.cbxBermuda.TabIndex = 5;
            this.cbxBermuda.Text = "Bermuda";
            this.cbxBermuda.UseVisualStyleBackColor = true;
            this.cbxBermuda.CheckedChanged += new System.EventHandler(this.cbxBermuda_CheckedChanged);
            // 
            // rbtmStandard
            // 
            this.rbtmStandard.AutoSize = true;
            this.rbtmStandard.Location = new System.Drawing.Point(46, 21);
            this.rbtmStandard.Name = "rbtmStandard";
            this.rbtmStandard.Size = new System.Drawing.Size(87, 21);
            this.rbtmStandard.TabIndex = 7;
            this.rbtmStandard.TabStop = true;
            this.rbtmStandard.Text = "Standard";
            this.rbtmStandard.UseVisualStyleBackColor = true;
            // 
            // rbtmPremium
            // 
            this.rbtmPremium.AutoSize = true;
            this.rbtmPremium.Location = new System.Drawing.Point(168, 21);
            this.rbtmPremium.Name = "rbtmPremium";
            this.rbtmPremium.Size = new System.Drawing.Size(84, 21);
            this.rbtmPremium.TabIndex = 8;
            this.rbtmPremium.TabStop = true;
            this.rbtmPremium.Text = "Premium";
            this.rbtmPremium.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(18, 21);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 11;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(16, 21);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // btnCalcular_precio
            // 
            this.btnCalcular_precio.Location = new System.Drawing.Point(100, 292);
            this.btnCalcular_precio.Name = "btnCalcular_precio";
            this.btnCalcular_precio.Size = new System.Drawing.Size(159, 41);
            this.btnCalcular_precio.TabIndex = 13;
            this.btnCalcular_precio.Text = "Calcular precio final";
            this.btnCalcular_precio.UseVisualStyleBackColor = true;
            this.btnCalcular_precio.Click += new System.EventHandler(this.btnCalcular_precio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxBermuda);
            this.groupBox1.Controls.Add(this.cbxManga_corta);
            this.groupBox1.Controls.Add(this.rbtmPantalon);
            this.groupBox1.Controls.Add(this.rbtmCamisa);
            this.groupBox1.Location = new System.Drawing.Point(35, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 84);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de prenda:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtmPremium);
            this.groupBox2.Controls.Add(this.rbtmStandard);
            this.groupBox2.Location = new System.Drawing.Point(35, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 59);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad de prenda:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Location = new System.Drawing.Point(35, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 60);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCantidad);
            this.groupBox4.Location = new System.Drawing.Point(187, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(134, 60);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad:";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(356, 342);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular_precio);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Ventas al por mayor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtmCamisa;
        private System.Windows.Forms.RadioButton rbtmPantalon;
        private System.Windows.Forms.CheckBox cbxManga_corta;
        private System.Windows.Forms.CheckBox cbxBermuda;
        private System.Windows.Forms.RadioButton rbtmStandard;
        private System.Windows.Forms.RadioButton rbtmPremium;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCalcular_precio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

