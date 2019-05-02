namespace proyecto_refaccionaria.Interfaz
{
    partial class Frm_modificar
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
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.btnBuscarI = new System.Windows.Forms.Button();
            this.pbproductos = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ruta = new System.Windows.Forms.TextBox();
            this.Tproductos = new System.Windows.Forms.DataGridView();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarC.Location = new System.Drawing.Point(777, 334);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(223, 37);
            this.btnGuardarC.TabIndex = 2;
            this.btnGuardarC.Text = "guardar cambios";
            this.btnGuardarC.UseVisualStyleBackColor = true;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre: ";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(113, 123);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(147, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Imagen(opcional):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Marca:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Descripcion:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(113, 303);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(147, 20);
            this.txtprecio.TabIndex = 13;
            this.txtprecio.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(113, 215);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(147, 20);
            this.txtmarca.TabIndex = 14;
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "Retornable",
            "no-retornable"});
            this.cbtipo.Location = new System.Drawing.Point(113, 260);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(147, 21);
            this.cbtipo.TabIndex = 15;
            // 
            // btnBuscarI
            // 
            this.btnBuscarI.Location = new System.Drawing.Point(16, 405);
            this.btnBuscarI.Name = "btnBuscarI";
            this.btnBuscarI.Size = new System.Drawing.Size(114, 23);
            this.btnBuscarI.TabIndex = 17;
            this.btnBuscarI.Text = "buscar imagen";
            this.btnBuscarI.UseVisualStyleBackColor = true;
            this.btnBuscarI.Click += new System.EventHandler(this.btnBuscarI_Click);
            // 
            // pbproductos
            // 
            this.pbproductos.Image = global::proyecto_refaccionaria.Properties.Resources.SIN_IMG;
            this.pbproductos.Location = new System.Drawing.Point(777, 121);
            this.pbproductos.Name = "pbproductos";
            this.pbproductos.Size = new System.Drawing.Size(223, 184);
            this.pbproductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbproductos.TabIndex = 6;
            this.pbproductos.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proyecto_refaccionaria.Properties.Resources._0593d958_1b01_4ab9_9426_31d01a84e1c5;
            this.pictureBox2.Location = new System.Drawing.Point(3, 446);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1011, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyecto_refaccionaria.Properties.Resources._7da67201_a30e_4d22_b120_d00dac3092f1;
            this.pictureBox1.Location = new System.Drawing.Point(154, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ruta
            // 
            this.ruta.Location = new System.Drawing.Point(154, 351);
            this.ruta.Name = "ruta";
            this.ruta.Size = new System.Drawing.Size(106, 20);
            this.ruta.TabIndex = 18;
            this.ruta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Tproductos
            // 
            this.Tproductos.AllowUserToAddRows = false;
            this.Tproductos.AllowUserToDeleteRows = false;
            this.Tproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tproductos.Location = new System.Drawing.Point(306, 121);
            this.Tproductos.Name = "Tproductos";
            this.Tproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tproductos.Size = new System.Drawing.Size(449, 307);
            this.Tproductos.TabIndex = 19;
            this.Tproductos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tproductos_MouseClick);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(113, 171);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(147, 20);
            this.txtdescripcion.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(777, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.Tproductos);
            this.Controls.Add(this.ruta);
            this.Controls.Add(this.btnBuscarI);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbproductos);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarC);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_modificar";
            this.Text = "Frm_modificar";
            this.Activated += new System.EventHandler(this.Frm_modificar_Activated);
            this.Load += new System.EventHandler(this.Frm_modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGuardarC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.PictureBox pbproductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.Button btnBuscarI;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox ruta;
        private System.Windows.Forms.DataGridView Tproductos;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button button1;
    }
}