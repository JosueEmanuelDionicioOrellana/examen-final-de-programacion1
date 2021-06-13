namespace Examen_final_de_programacion_1
{
    partial class Dormidos
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
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lugar = new System.Windows.Forms.Label();
            this.Pedidos = new System.Windows.Forms.Button();
            this.sucur = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.Crear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioPizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionPizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre_pizza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boton3 = new System.Windows.Forms.Button();
            this.ordenes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.descripcionV = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pizzaNombre = new System.Windows.Forms.Label();
            this.precios = new System.Windows.Forms.Label();
            this.ordenar = new System.Windows.Forms.Button();
            this.parte = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePizzaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regresar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(471, 141);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(95, 40);
            this.boton1.TabIndex = 0;
            this.boton1.Text = "Guatemala";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(249, 142);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(95, 38);
            this.boton2.TabIndex = 1;
            this.boton2.Text = "Progreso";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dormidos Pizza";
            // 
            // lugar
            // 
            this.lugar.AutoSize = true;
            this.lugar.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lugar.Location = new System.Drawing.Point(256, 82);
            this.lugar.Name = "lugar";
            this.lugar.Size = new System.Drawing.Size(103, 31);
            this.lugar.TabIndex = 4;
            this.lugar.Text = "sucursal";
            this.lugar.Visible = false;
            // 
            // Pedidos
            // 
            this.Pedidos.Location = new System.Drawing.Point(440, 16);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(110, 33);
            this.Pedidos.TabIndex = 5;
            this.Pedidos.Text = "Pedidos";
            this.Pedidos.UseVisualStyleBackColor = true;
            this.Pedidos.Click += new System.EventHandler(this.Pedidos_Click);
            // 
            // sucur
            // 
            this.sucur.AutoSize = true;
            this.sucur.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucur.Location = new System.Drawing.Point(28, 113);
            this.sucur.Name = "sucur";
            this.sucur.Size = new System.Drawing.Size(99, 23);
            this.sucur.TabIndex = 8;
            this.sucur.Text = "Sucursales";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.descripcion);
            this.panel1.Controls.Add(this.Crear);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Pedidos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.precio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nombre_pizza);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(32, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 290);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(152, 89);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(245, 36);
            this.descripcion.TabIndex = 8;
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(152, 131);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(110, 33);
            this.Crear.TabIndex = 7;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nombrePizza,
            this.precioPizza,
            this.descripcionPizza,
            this.sucursal});
            this.dataGridView1.Location = new System.Drawing.Point(6, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 103);
            this.dataGridView1.TabIndex = 5;
            // 
            // numero
            // 
            this.numero.HeaderText = "No. ";
            this.numero.Name = "numero";
            // 
            // nombrePizza
            // 
            this.nombrePizza.HeaderText = "Nombre";
            this.nombrePizza.Name = "nombrePizza";
            // 
            // precioPizza
            // 
            this.precioPizza.HeaderText = "Precio";
            this.precioPizza.Name = "precioPizza";
            // 
            // descripcionPizza
            // 
            this.descripcionPizza.HeaderText = "Descripción";
            this.descripcionPizza.Name = "descripcionPizza";
            // 
            // sucursal
            // 
            this.sucursal.HeaderText = "Sucursal";
            this.sucursal.Name = "sucursal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(152, 48);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(67, 20);
            this.precio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Precio";
            // 
            // nombre_pizza
            // 
            this.nombre_pizza.Location = new System.Drawing.Point(152, 15);
            this.nombre_pizza.Name = "nombre_pizza";
            this.nombre_pizza.Size = new System.Drawing.Size(245, 20);
            this.nombre_pizza.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de la pizza";
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(32, 141);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(95, 37);
            this.boton3.TabIndex = 2;
            this.boton3.Text = "Jalapa";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // ordenes
            // 
            this.ordenes.AutoSize = true;
            this.ordenes.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenes.Location = new System.Drawing.Point(94, 82);
            this.ordenes.Name = "ordenes";
            this.ordenes.Size = new System.Drawing.Size(104, 31);
            this.ordenes.TabIndex = 11;
            this.ordenes.Text = "Ordenes";
            this.ordenes.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.descripcionV);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.pizzaNombre);
            this.panel2.Controls.Add(this.precios);
            this.panel2.Controls.Add(this.ordenar);
            this.panel2.Controls.Add(this.parte);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.Regresar);
            this.panel2.Location = new System.Drawing.Point(32, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 289);
            this.panel2.TabIndex = 14;
            this.panel2.Visible = false;
            // 
            // descripcionV
            // 
            this.descripcionV.AutoSize = true;
            this.descripcionV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionV.Location = new System.Drawing.Point(24, 87);
            this.descripcionV.Name = "descripcionV";
            this.descripcionV.Size = new System.Drawing.Size(100, 21);
            this.descripcionV.TabIndex = 18;
            this.descripcionV.Text = "Descripción";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(314, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 43);
            this.listBox1.TabIndex = 17;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pizzaNombre
            // 
            this.pizzaNombre.AutoSize = true;
            this.pizzaNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaNombre.Location = new System.Drawing.Point(24, 51);
            this.pizzaNombre.Name = "pizzaNombre";
            this.pizzaNombre.Size = new System.Drawing.Size(154, 21);
            this.pizzaNombre.TabIndex = 16;
            this.pizzaNombre.Text = "Nombre de la pizza";
            // 
            // precios
            // 
            this.precios.AutoSize = true;
            this.precios.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precios.Location = new System.Drawing.Point(452, 94);
            this.precios.Name = "precios";
            this.precios.Size = new System.Drawing.Size(82, 31);
            this.precios.TabIndex = 14;
            this.precios.Text = "Q0.00";
            // 
            // ordenar
            // 
            this.ordenar.Location = new System.Drawing.Point(447, 148);
            this.ordenar.Name = "ordenar";
            this.ordenar.Size = new System.Drawing.Size(90, 24);
            this.ordenar.TabIndex = 13;
            this.ordenar.Text = "Ordenar";
            this.ordenar.UseVisualStyleBackColor = true;
            this.ordenar.Click += new System.EventHandler(this.ordenar_Click);
            // 
            // parte
            // 
            this.parte.AutoSize = true;
            this.parte.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parte.Location = new System.Drawing.Point(110, 10);
            this.parte.Name = "parte";
            this.parte.Size = new System.Drawing.Size(79, 23);
            this.parte.TabIndex = 12;
            this.parte.Text = "sucursal";
            this.parte.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Sucursal de ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "Pedidos";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NombrePizzaa,
            this.precioss,
            this.descripciones});
            this.dataGridView3.Location = new System.Drawing.Point(53, 180);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(443, 93);
            this.dataGridView3.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // NombrePizzaa
            // 
            this.NombrePizzaa.HeaderText = "Nombre";
            this.NombrePizzaa.Name = "NombrePizzaa";
            // 
            // precioss
            // 
            this.precioss.HeaderText = "Precio";
            this.precioss.Name = "precioss";
            // 
            // descripciones
            // 
            this.descripciones.HeaderText = "Descripción";
            this.descripciones.Name = "descripciones";
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(463, 10);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(90, 29);
            this.Regresar.TabIndex = 0;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(1, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(99, 13);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(507, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(112, 13);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(1, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(99, 13);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Location = new System.Drawing.Point(507, 48);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(112, 13);
            this.panel6.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.Location = new System.Drawing.Point(1, 466);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(661, 11);
            this.panel7.TabIndex = 18;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel8.Location = new System.Drawing.Point(1, 483);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(661, 11);
            this.panel8.TabIndex = 19;
            // 
            // Dormidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 513);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ordenes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sucur);
            this.Controls.Add(this.lugar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Name = "Dormidos";
            this.Text = "Dormidos Pizza";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lugar;
        private System.Windows.Forms.Button Pedidos;
        private System.Windows.Forms.Label sucur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre_pizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Label ordenes;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label precios;
        private System.Windows.Forms.Button ordenar;
        private System.Windows.Forms.Label parte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Label pizzaNombre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioPizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionPizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursal;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label descripcionV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePizzaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioss;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciones;
    }
}

