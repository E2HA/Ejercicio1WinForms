using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Se envía la información con un botón
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = ""; // después de que se agregue el item a la listBox, el textBox queda vacío
            textBox1.Select(); //después de que el textBox haya quedado vacío, automáticamente se selecciona el esapacio de textBox, lista para escribir otra información.
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Se envía la información presionando ENTER
            switch (e.KeyCode) //se crea un switch para que reciba como parámetro una tecla del computador, que será ENTER
            {
                case Keys.Enter: //cuando se presione ENTER
                    listBox1.Items.Add(textBox1.Text); //agregará automáticamente la info a la listBox.
                    textBox1.Text = "";
                    textBox1.Select();

                    break;
            }
        }
    }
}
