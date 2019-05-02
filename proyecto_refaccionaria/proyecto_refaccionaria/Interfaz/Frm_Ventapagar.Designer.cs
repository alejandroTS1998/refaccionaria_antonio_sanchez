namespace proyecto_refaccionaria.Interfaz
{
    partial class Frm_Ventapagar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtefectivo = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.Cambiox = new System.Windows.Forms.Label();
            this.txttot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total a pagar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(37, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Efectivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(38, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cambio:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proyecto_refaccionaria.Properties.Resources._0593d958_1b01_4ab9_9426_31d01a84e1c5;
            this.pictureBox2.Location = new System.Drawing.Point(0, 393);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(456, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyecto_refaccionaria.Properties.Resources._7da67201_a30e_4d22_b120_d00dac3092f1;
            this.pictureBox1.Location = new System.Drawing.Point(56, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtefectivo
            // 
            this.txtefectivo.Location = new System.Drawing.Point(175, 184);
            this.txtefectivo.Name = "txtefectivo";
            this.txtefectivo.Size = new System.Drawing.Size(206, 20);
            this.txtefectivo.TabIndex = 7;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnaceptar.Location = new System.Drawing.Point(42, 305);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(132, 59);
            this.btnaceptar.TabIndex = 8;
            this.btnaceptar.Text = "aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(239, 305);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(142, 59);
            this.btncerrar.TabIndex = 9;
            this.btncerrar.Text = "cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Cambiox
            // 
            this.Cambiox.AutoSize = true;
            this.Cambiox.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cambiox.Location = new System.Drawing.Point(305, 260);
            this.Cambiox.Name = "Cambiox";
            this.Cambiox.Size = new System.Drawing.Size(0, 26);
            this.Cambiox.TabIndex = 10;
            // 
            // txttot
            // 
            this.txttot.AutoSize = true;
            this.txttot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttot.Location = new System.Drawing.Point(207, 105);
            this.txttot.Name = "txttot";
            this.txttot.Size = new System.Drawing.Size(0, 25);
            this.txttot.TabIndex = 11;
            // 
            // Frm_Ventapagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 455);
            this.Controls.Add(this.txttot);
            this.Controls.Add(this.Cambiox);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtefectivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Ventapagar";
            this.Text = "venta";
            this.Load += new System.EventHandler(this.Frm_Ventapagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtefectivo;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label Cambiox;
        public System.Windows.Forms.Label txttot;
    }
}