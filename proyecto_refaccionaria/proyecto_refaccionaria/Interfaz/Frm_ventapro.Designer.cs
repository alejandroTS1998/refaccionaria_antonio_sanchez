namespace proyecto_refaccionaria.Interfaz
{
    partial class Frm_ventapro
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.tproductos = new System.Windows.Forms.DataGridView();
            this.Btnagregarc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cantidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.carrito = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpventa = new System.Windows.Forms.DateTimePicker();
            this.btnComprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrito)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyecto_refaccionaria.Properties.Resources._7da67201_a30e_4d22_b120_d00dac3092f1;
            this.pictureBox1.Location = new System.Drawing.Point(196, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(7, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(7, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(85, 85);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(109, 20);
            this.txtname.TabIndex = 5;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(85, 128);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(109, 20);
            this.txtmarca.TabIndex = 6;
            this.txtmarca.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tproductos
            // 
            this.tproductos.AllowUserToAddRows = false;
            this.tproductos.AllowUserToDeleteRows = false;
            this.tproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tproductos.Location = new System.Drawing.Point(212, 87);
            this.tproductos.Name = "tproductos";
            this.tproductos.Size = new System.Drawing.Size(738, 187);
            this.tproductos.TabIndex = 8;
            this.tproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.tproductos.SelectionChanged += new System.EventHandler(this.tproductos_SelectionChanged);
            // 
            // Btnagregarc
            // 
            this.Btnagregarc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btnagregarc.Location = new System.Drawing.Point(11, 266);
            this.Btnagregarc.Name = "Btnagregarc";
            this.Btnagregarc.Size = new System.Drawing.Size(182, 32);
            this.Btnagregarc.TabIndex = 10;
            this.Btnagregarc.Text = "Agregar al carrito";
            this.Btnagregarc.UseVisualStyleBackColor = true;
            this.Btnagregarc.Click += new System.EventHandler(this.Btnagregarc_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(13, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cantidad
            // 
            this.cantidad.FormattingEnabled = true;
            this.cantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cantidad.Location = new System.Drawing.Point(84, 163);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(109, 21);
            this.cantidad.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(7, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "cantidad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(11, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proyecto_refaccionaria.Properties.Resources._0593d958_1b01_4ab9_9426_31d01a84e1c5;
            this.pictureBox2.Location = new System.Drawing.Point(-14, 452);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(990, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // carrito
            // 
            this.carrito.AllowUserToAddRows = false;
            this.carrito.AllowUserToDeleteRows = false;
            this.carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.Nombre,
            this.tipo,
            this.descripcion,
            this.precio,
            this.marca,
            this.cantidad1});
            this.carrito.Location = new System.Drawing.Point(207, 290);
            this.carrito.Name = "carrito";
            this.carrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carrito.Size = new System.Drawing.Size(743, 156);
            this.carrito.TabIndex = 16;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "id";
            this.id_producto.Name = "id_producto";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            // 
            // cantidad1
            // 
            this.cantidad1.HeaderText = "cantidad";
            this.cantidad1.Name = "cantidad1";
            // 
            // dtpventa
            // 
            this.dtpventa.Location = new System.Drawing.Point(854, 61);
            this.dtpventa.Name = "dtpventa";
            this.dtpventa.Size = new System.Drawing.Size(10, 20);
            this.dtpventa.TabIndex = 17;
            this.dtpventa.Visible = false;
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnComprar.Location = new System.Drawing.Point(13, 320);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(180, 61);
            this.btnComprar.TabIndex = 18;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // Frm_ventapro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 509);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.dtpventa);
            this.Controls.Add(this.carrito);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btnagregarc);
            this.Controls.Add(this.tproductos);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_ventapro";
            this.Text = "venta";
            this.Activated += new System.EventHandler(this.Frm_ventapro_Activated);
            this.Load += new System.EventHandler(this.Frm_ventapro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.DataGridView tproductos;
        private System.Windows.Forms.Button Btnagregarc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView carrito;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad1;
        public System.Windows.Forms.DateTimePicker dtpventa;
    }
}