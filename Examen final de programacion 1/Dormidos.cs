using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final_de_programacion_1
{
    public partial class Dormidos : Form
    {
        public Dormidos()
        {
            InitializeComponent();
        }

        int identificador;
        int identificador2;
        pizzas[] sucursales = new pizzas[10];
        pizzas registro = new pizzas(0, null, null, null, null);
        pizzas pedidosP = new pizzas(0, null, null, null, null);
        pizzas[] pedidosJalapa = new pizzas[20];
        pizzas[] pedidosProgreso = new pizzas[20];
        pizzas[] pedidosGuatemala = new pizzas[20];



        public string nombre;
        public int jalapaContador = 0;
        public int progresoContador = 0;
        public int guatemalaContador = 0;
        private void boton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            lugar.Visible = true;
            lugar.Text = "Guatemala";
            nombre = "Guatemala";
            
            
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            lugar.Visible = true;
            lugar.Text = "Progreso";
            nombre = "Progreso";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            lugar.Visible = true;
            lugar.Text = "Jalapa";
            nombre = "Jalapa";
            
         
        }



        private void Pedidos_Click(object sender, EventArgs e)
        {
            ordenes.Visible = true;
            panel2.Visible = true;
            parte.Text = nombre;
            parte.Visible = true;
            panel1.Visible = false;
            boton1.Visible = false;
            boton2.Visible = false;
            boton3.Visible = false;
            lugar.Visible = false;
            sucur.Visible = false;

            
            for (int i = 0; i < registro.Id + 1; i++)
            {
                pizzas registro = sucursales[i];
                if (parte.Text==registro.sucursal)
                {
                    listBox1.Items.Add(registro.nombre);
                }
                
            }

            if (jalapaContador > 0)
            {
                if (parte.Text == "Jalapa")
                {
                    int valor = pedidosP.Id;
                    for (int i = 0; i < valor + 1; i++)
                    {
                        pizzas pedidosP = pedidosJalapa[i];

                        identificador2 = dataGridView3.Rows.Add();
                        dataGridView3.Rows[identificador2].Cells[0].Value = identificador2 + 1;
                        dataGridView3.Rows[identificador2].Cells[1].Value = pedidosP.nombre;
                        dataGridView3.Rows[identificador2].Cells[2].Value = pedidosP.precio;
                        dataGridView3.Rows[identificador2].Cells[3].Value = pedidosP.descripcion;
                    }
                }
            }
            if (progresoContador > 0)
            {
                if (parte.Text == "Progreso")
                {
                    int valor = pedidosP.Id;
                    for (int i = 0; i < valor + 1; i++)
                    {
                        pizzas pedidosP = pedidosProgreso[i];

                        identificador2 = dataGridView3.Rows.Add();
                        dataGridView3.Rows[identificador2].Cells[0].Value = identificador2 + 1;
                        dataGridView3.Rows[identificador2].Cells[1].Value = pedidosP.nombre;
                        dataGridView3.Rows[identificador2].Cells[2].Value = pedidosP.precio;
                        dataGridView3.Rows[identificador2].Cells[3].Value = pedidosP.descripcion;
                    }
                }
            }
            if (guatemalaContador > 0)
            {
                if (parte.Text == "Guatemala")
                {
                    int valor = pedidosP.Id;
                    for (int i = 0; i < valor + 1; i++)
                    {
                        pizzas pedidosP = pedidosGuatemala[i];

                        identificador2 = dataGridView3.Rows.Add();
                        dataGridView3.Rows[identificador2].Cells[0].Value = identificador2 + 1;
                        dataGridView3.Rows[identificador2].Cells[1].Value = pedidosP.nombre;
                        dataGridView3.Rows[identificador2].Cells[2].Value = pedidosP.precio;
                        dataGridView3.Rows[identificador2].Cells[3].Value = pedidosP.descripcion;
                    }
                }
            }
        }


        private void Regresar_Click_1(object sender, EventArgs e)
        {
            ordenes.Visible = false;
            panel2.Visible = false;
            boton1.Visible = true;
            boton2.Visible = true;
            boton3.Visible = true;
            lugar.Visible = true;
            sucur.Visible = true;
            lugar.Visible = false;
            listBox1.Items.Clear();

            dataGridView3.Rows.Clear();



        }

        private void Crear_Click(object sender, EventArgs e)
        {

            identificador = dataGridView1.Rows.Add();
            registro = new pizzas(identificador, nombre_pizza.Text,precio.Text,descripcion.Text,nombre);
            dataGridView1.Rows[identificador].Cells[0].Value = identificador + 1;
            dataGridView1.Rows[identificador].Cells[1].Value = nombre_pizza.Text;
            dataGridView1.Rows[identificador].Cells[2].Value = precio.Text;
            dataGridView1.Rows[identificador].Cells[3].Value = descripcion.Text;
            dataGridView1.Rows[identificador].Cells[4].Value = nombre;
            sucursales[identificador] = registro;
            

            nombre_pizza.Clear();
            precio.Clear();
            descripcion.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            pizzaNombre.Visible = true;
            pizzaNombre.Text = (string)listBox1.Items[listBox1.SelectedIndex];
            for (int i = 0; i < registro.Id + 1; i++)
            {
                pizzas registro = sucursales[i];
                if (pizzaNombre.Text == registro.nombre)
                {
                    descripcionV.Text = registro.descripcion;
                    precios.Text = registro.precio;
                }
            }
        }

        private void ordenar_Click(object sender, EventArgs e)
        {
            string nombre = pizzaNombre.Text;
            string precio = precios.Text;
            string descripcion = descripcionV.Text;
            string ubicacion = parte.Text;

            pizzaNombre.Text = "Nombre de la pizza";
            descripcionV.Text = "Descripcion";
            precios.Text = "Q0.00";

            if (ubicacion == "Jalapa")
            {
                int valor = pedidosP.Id;
                
                pizzas pedidosjal = new pizzas(identificador2, nombre, precio, descripcion, ubicacion);
                pedidosJalapa[identificador2] = pedidosjal;
                jalapaContador++;

                for (int i = 0; i < valor + 1; i++)
                {
                    pizzas jal = pedidosJalapa[i];

                    identificador2 = dataGridView3.Rows.Add();
                    dataGridView3.Rows[identificador2].Cells[0].Value = identificador2 + 1;
                    dataGridView3.Rows[identificador2].Cells[1].Value = jal.nombre;
                    dataGridView3.Rows[identificador2].Cells[2].Value = jal.precio;
                    dataGridView3.Rows[identificador2].Cells[3].Value = jal.descripcion;
                }

            if (ubicacion == "Progreso")
            {
                
                pizzas pedidospro = new pizzas(identificador2, nombre, precio, descripcion, ubicacion);
                pedidosProgreso[identificador2] = pedidospro;
                progresoContador++;
                for (int i = 0; i < valor + 1; i++)
                    {
                        pizzas pro= pedidosProgreso[i];

                        identificador2 = dataGridView3.Rows.Add();
                        dataGridView3.Rows[identificador2].Cells[0].Value = identificador2 + 1;
                        dataGridView3.Rows[identificador2].Cells[1].Value = pro.nombre;
                        dataGridView3.Rows[identificador2].Cells[2].Value = pro.precio;
                        dataGridView3.Rows[identificador2].Cells[3].Value = pro.descripcion;
                    }
                }


            if (ubicacion == "Guatemala")
            {
                    
                pizzas pedidosgua = new pizzas(identificador2, nombre, precio, descripcion, ubicacion);
                pedidosGuatemala[identificador2] = pedidosgua;
                guatemalaContador++;

                for (int i = 0; i < valor + 1; i++)
                    {
                        pizzas gua = pedidosGuatemala[i];

                        identificador2 = dataGridView3.Rows.Add();
                        dataGridView3.Rows[identificador2].Cells[0].Value = identificador2 + 1;
                        dataGridView3.Rows[identificador2].Cells[1].Value = gua.nombre;
                        dataGridView3.Rows[identificador2].Cells[2].Value = gua.precio;
                        dataGridView3.Rows[identificador2].Cells[3].Value = gua.descripcion;
                    }
                }
            }
        }
    }

    class pizzas
    {

        public int Id = 0;
        public string nombre;
        public string precio;
        public string descripcion;
        public string sucursal;

        public pizzas(int id, string nombre, string precio, string descripcion, string sucursal)
        {
            this.Id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
            this.sucursal = sucursal;

        }

    }
}
