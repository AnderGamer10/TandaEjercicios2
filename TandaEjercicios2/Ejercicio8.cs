using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace TandaEjercicios2
{
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void Ejercicio8_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if(txtAnyadirAmigos.Text != null && txtAnyadirAmigos.Text != "")
            {
                lboxAmigos.Items.Add(txtAnyadirAmigos.Text);
            }
            if(txtAnyadirAmigos.Text == null || txtAnyadirAmigos.Text == "")
            {
                Microsoft.VisualBasic.Interaction.MsgBox(
                    "Introduzca datos para poder añadirlos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (lboxAmigos.SelectedItem == null)
            {
                Microsoft.VisualBasic.Interaction.MsgBox(
                                    "Seleccione un dato para eliminarlo");
            }
            else
            {
                for (int x = lboxAmigos.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int var = lboxAmigos.SelectedIndices[x];
                    lboxAmigos.Items.RemoveAt(var);

                }

                if (lboxAmigos.Items.Count == 0)
                {
                    txtAmigoSelec.Text = "";
                }
            }
        }

        private void btnBorrarLista_Click(object sender, EventArgs e)
        {
            if(lboxAmigos.Items.Count == 0)
            {
                Microsoft.VisualBasic.Interaction.MsgBox(
                                    "La lista esta vacia");
            }
            else
            {
                lboxAmigos.Items.Clear();
                txtAmigoSelec.Text = "";
            }
            
        }

        private void lboxAmigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtAmigoSelec.Text != null || txtAmigoSelec.Text != "")
            {
                txtAmigoSelec.Text = ""; 
            }
            foreach (object item in lboxAmigos.SelectedItems)
            {
                txtAmigoSelec.Text += item.ToString() + " ";
            }
        }
    }
}
