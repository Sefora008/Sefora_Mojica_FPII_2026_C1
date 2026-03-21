using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Wire events for buttons created in designer
            this.buttonAgregarJugador.Click += ButtonAgregarJugador_Click;
            this.buttonJugar.Click += ButtonJugar_Click;
        }

        private void buttonCrearNuevaJugada_Click(object sender, EventArgs e)
        {
            // When creating a new jugada, set the maximum allowed number to the limit value
            int limit = (int)numericUpDownLimit.Value;
            numericUpDownNumber.Maximum = limit;

            // Optional: reset selected number to 0 or keep within range
            if (numericUpDownNumber.Value > numericUpDownNumber.Maximum)
            {
                numericUpDownNumber.Value = numericUpDownNumber.Maximum;
            }

            labelStatus.Text = $"Jugada activa (límite {limit})";
            MessageBox.Show($"Nueva jugada creada. Límite de números: {limit}", "Jugada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numericUpDownLimit_ValueChanged(object sender, EventArgs e)
        {
            // When the limit changes, update the maximum of the number control so user cannot select beyond the limit
            if (numericUpDownNumber == null) return;

            int limit = (int)numericUpDownLimit.Value;
            numericUpDownNumber.Maximum = limit;

            if (numericUpDownNumber.Value > numericUpDownNumber.Maximum)
            {
                numericUpDownNumber.Value = numericUpDownNumber.Maximum;
            }
        }

        private void ButtonAgregarJugador_Click(object sender, EventArgs e)
        {
            // Basic validation
            var nombre = textBoxNombre.Text.Trim();
            var cantidadText = textBoxCantidad.Text.Trim();
            int numero = (int)numericUpDownNumber.Value;
            decimal cantidad;
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese el nombre del jugador.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(cantidadText, out cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prevent duplicate numbers: check existing rows for the same number
            for (int i = 0; i < dataGridViewJugadores.Rows.Count; i++)
            {
                var cellValue = dataGridViewJugadores.Rows[i].Cells[1].Value;
                if (cellValue != null)
                {
                    int existingNumber;
                    if (int.TryParse(cellValue.ToString(), out existingNumber))
                    {
                        if (existingNumber == numero)
                        {
                            MessageBox.Show($"Ya existe un jugador con el número {numero}. Elija otro número.", "Número duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            // Add to DataGridView
            this.dataGridViewJugadores.Rows.Add(nombre, numero.ToString(), cantidad.ToString());

            // Clear inputs
            textBoxNombre.Clear();
            textBoxCantidad.Clear();
            numericUpDownNumber.Value = 0;
        }

        private void ButtonJugar_Click(object sender, EventArgs e)
        {
            // Simple random draw: pick a winning number between 0 and limit
            int limit = (int)numericUpDownLimit.Value;
            var rand = new Random();
            int winningNumber = rand.Next(0, limit + 1);

            listBoxGanadores.Items.Clear();

            // find matches in DataGridView
            for (int i = 0; i < dataGridViewJugadores.Rows.Count; i++)
            {
                var row = dataGridViewJugadores.Rows[i];
                if (row.Cells[1].Value != null)
                {
                    int playerNumber;
                    if (int.TryParse(row.Cells[1].Value.ToString(), out playerNumber))
                    {
                        if (playerNumber == winningNumber)
                        {
                            var playerName = row.Cells[0].Value?.ToString() ?? "";
                            var amount = row.Cells[2].Value?.ToString() ?? "";
                            listBoxGanadores.Items.Add($"{playerName} - Premio por número {amount}");
                        }
                    }
                }
            }

            if (listBoxGanadores.Items.Count == 0)
            {
                listBoxGanadores.Items.Add($"Nadie ganó. Número ganador: {winningNumber}");
            }
            else
            {
                listBoxGanadores.Items.Insert(0, $"Número ganador: {winningNumber}");
            }
        }
    }
}
