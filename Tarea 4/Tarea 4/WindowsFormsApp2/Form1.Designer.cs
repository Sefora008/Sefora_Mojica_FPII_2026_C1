namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Text = "Jugada - Tarea 4";

            // Title label (mimic black image header)
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTitle.Text = "TAREA 4";
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 8);

            // Status label
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatus.Text = "Sin jugada activa";
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(420, 22);
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 10F);

            // Create new jugada button
            this.buttonCrearNuevaJugada = new System.Windows.Forms.Button();
            this.buttonCrearNuevaJugada.Text = "Crear nueva jugada";
            this.buttonCrearNuevaJugada.Size = new System.Drawing.Size(160, 30);
            this.buttonCrearNuevaJugada.Location = new System.Drawing.Point(12, 60);
            this.buttonCrearNuevaJugada.Click += new System.EventHandler(this.buttonCrearNuevaJugada_Click);

            // Limit numeric up down
            this.labelLimit = new System.Windows.Forms.Label();
            this.labelLimit.Text = "Límite (máx)";
            this.labelLimit.Location = new System.Drawing.Point(190, 45);
            this.labelLimit.AutoSize = true;

            this.numericUpDownLimit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).BeginInit();
            this.numericUpDownLimit.Minimum = 1;
            this.numericUpDownLimit.Maximum = 1000;
            this.numericUpDownLimit.Value = 100;
            this.numericUpDownLimit.Size = new System.Drawing.Size(90, 23);
            this.numericUpDownLimit.Location = new System.Drawing.Point(190, 62);
            this.numericUpDownLimit.ValueChanged += new System.EventHandler(this.numericUpDownLimit_ValueChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).EndInit();

            // Left side: GroupBox for "Agregar apuesta"
            this.groupBoxAgregar = new System.Windows.Forms.GroupBox();
            this.groupBoxAgregar.Text = "Agregar apuesta";
            this.groupBoxAgregar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBoxAgregar.Size = new System.Drawing.Size(520, 120);
            this.groupBoxAgregar.Location = new System.Drawing.Point(12, 110);

            // Inside group: Nombre
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNombre.Text = "Nombre:";
            this.labelNombre.Location = new System.Drawing.Point(12, 28);
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxNombre.Location = new System.Drawing.Point(80, 25);
            this.textBoxNombre.Size = new System.Drawing.Size(380, 23);

            // Número
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelNumero.Text = "Número:";
            this.labelNumero.Location = new System.Drawing.Point(12, 62);
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            this.numericUpDownNumber.Location = new System.Drawing.Point(80, 60);
            this.numericUpDownNumber.Minimum = 0;
            this.numericUpDownNumber.Maximum = 100; // initial
            this.numericUpDownNumber.Size = new System.Drawing.Size(80, 23);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();

            // Cantidad
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelCantidad.Text = "Cantidad:";
            this.labelCantidad.Location = new System.Drawing.Point(180, 62);
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxCantidad.Location = new System.Drawing.Point(250, 60);
            this.textBoxCantidad.Size = new System.Drawing.Size(120, 23);
            this.textBoxCantidad.Text = "100"; // default value set to 100

            // Agregar jugador button
            this.buttonAgregarJugador = new System.Windows.Forms.Button();
            this.buttonAgregarJugador.Text = "Agregar jugador";
            this.buttonAgregarJugador.Size = new System.Drawing.Size(120, 28);
            this.buttonAgregarJugador.Location = new System.Drawing.Point(390, 58);

            // Add inner controls to group
            this.groupBoxAgregar.Controls.Add(this.labelNombre);
            this.groupBoxAgregar.Controls.Add(this.textBoxNombre);
            this.groupBoxAgregar.Controls.Add(this.labelNumero);
            this.groupBoxAgregar.Controls.Add(this.numericUpDownNumber);
            this.groupBoxAgregar.Controls.Add(this.labelCantidad);
            this.groupBoxAgregar.Controls.Add(this.textBoxCantidad);
            this.groupBoxAgregar.Controls.Add(this.buttonAgregarJugador);

            // DataGridView for players
            this.dataGridViewJugadores = new System.Windows.Forms.DataGridView();
            this.dataGridViewJugadores.Location = new System.Drawing.Point(12, 245);
            this.dataGridViewJugadores.Size = new System.Drawing.Size(760, 330);
            this.dataGridViewJugadores.AllowUserToAddRows = false;
            this.dataGridViewJugadores.RowHeadersVisible = false;
            this.dataGridViewJugadores.AllowUserToResizeRows = false;

            // Columns
            var colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNombre.HeaderText = "Nombre";
            colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            var colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNumero.HeaderText = "Número";
            colNumero.Width = 120;
            var colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Width = 120;

            this.dataGridViewJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colNombre, colNumero, colCantidad
            });

            // Right panel: Jugar button and Ganadores list
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelRight.Location = new System.Drawing.Point(790, 60);
            this.panelRight.Size = new System.Drawing.Size(200, 515);

            this.buttonJugar = new System.Windows.Forms.Button();
            this.buttonJugar.Text = "Jugar";
            this.buttonJugar.Size = new System.Drawing.Size(140, 40);
            this.buttonJugar.Location = new System.Drawing.Point(30, 10);

            this.labelGanadores = new System.Windows.Forms.Label();
            this.labelGanadores.Text = "Ganadores";
            this.labelGanadores.Location = new System.Drawing.Point(30, 70);
            this.labelGanadores.AutoSize = true;

            this.listBoxGanadores = new System.Windows.Forms.ListBox();
            this.listBoxGanadores.Location = new System.Drawing.Point(15, 94);
            this.listBoxGanadores.Size = new System.Drawing.Size(170, 400);

            this.panelRight.Controls.Add(this.buttonJugar);
            this.panelRight.Controls.Add(this.labelGanadores);
            this.panelRight.Controls.Add(this.listBoxGanadores);

            // Add controls to the form
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonCrearNuevaJugada);
            this.Controls.Add(this.labelLimit);
            this.Controls.Add(this.numericUpDownLimit);
            this.Controls.Add(this.groupBoxAgregar);
            this.Controls.Add(this.dataGridViewJugadores);
            this.Controls.Add(this.panelRight);

            // Final form tweaks
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonCrearNuevaJugada;
        private System.Windows.Forms.Label labelLimit;
        private System.Windows.Forms.NumericUpDown numericUpDownLimit;
        private System.Windows.Forms.GroupBox groupBoxAgregar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Button buttonAgregarJugador;
        private System.Windows.Forms.DataGridView dataGridViewJugadores;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.Label labelGanadores;
        private System.Windows.Forms.ListBox listBoxGanadores;
    }
}

