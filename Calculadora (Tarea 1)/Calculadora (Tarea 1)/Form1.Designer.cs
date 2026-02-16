namespace Calculadora__Tarea_1_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnUno = new Button();
            btnDos = new Button();
            btnTres = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnCuatro = new Button();
            btnQuitar = new Button();
            btnBorrartodo = new Button();
            btnBorrar = new Button();
            btnNueve = new Button();
            btnOcho = new Button();
            btnSiete = new Button();
            btnElevaralcuadrado = new Button();
            btnRaizcuadrada = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnRestar = new Button();
            btnSumar = new Button();
            btnResultado = new Button();
            btnPunto = new Button();
            btnCero = new Button();
            bntSigno = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(1, 1);
            txtResultado.Margin = new Padding(2);
            txtResultado.MaxLength = 21;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(347, 54);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            btnUno.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUno.Location = new Point(11, 258);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(61, 46);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += agregarNumero;
            // 
            // btnDos
            // 
            btnDos.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDos.Location = new Point(78, 258);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(59, 46);
            btnDos.TabIndex = 2;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += agregarNumero;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTres.Location = new Point(143, 258);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(59, 46);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += agregarNumero;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeis.Location = new Point(143, 195);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(59, 46);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += agregarNumero;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCinco.Location = new Point(78, 195);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(59, 46);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += agregarNumero;
            // 
            // btnCuatro
            // 
            btnCuatro.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCuatro.Location = new Point(11, 195);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(61, 46);
            btnCuatro.TabIndex = 4;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += agregarNumero;
            // 
            // btnQuitar
            // 
            btnQuitar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuitar.Location = new Point(143, 76);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(59, 46);
            btnQuitar.TabIndex = 12;
            btnQuitar.Text = "<-";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnBorrartodo
            // 
            btnBorrartodo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrartodo.Location = new Point(78, 76);
            btnBorrartodo.Name = "btnBorrartodo";
            btnBorrartodo.Size = new Size(59, 46);
            btnBorrartodo.TabIndex = 11;
            btnBorrartodo.Text = "C";
            btnBorrartodo.UseVisualStyleBackColor = true;
            btnBorrartodo.Click += btnBorrartodo_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(11, 76);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(61, 46);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnNueve
            // 
            btnNueve.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNueve.Location = new Point(143, 139);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(59, 46);
            btnNueve.TabIndex = 9;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = true;
            btnNueve.Click += agregarNumero;
            // 
            // btnOcho
            // 
            btnOcho.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOcho.Location = new Point(78, 139);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(59, 46);
            btnOcho.TabIndex = 8;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            btnOcho.Click += agregarNumero;
            // 
            // btnSiete
            // 
            btnSiete.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiete.Location = new Point(11, 139);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(61, 46);
            btnSiete.TabIndex = 7;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += agregarNumero;
            // 
            // btnElevaralcuadrado
            // 
            btnElevaralcuadrado.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnElevaralcuadrado.Location = new Point(289, 76);
            btnElevaralcuadrado.Name = "btnElevaralcuadrado";
            btnElevaralcuadrado.Size = new Size(59, 46);
            btnElevaralcuadrado.TabIndex = 20;
            btnElevaralcuadrado.Tag = "²";
            btnElevaralcuadrado.Text = "x²";
            btnElevaralcuadrado.UseVisualStyleBackColor = true;
            btnElevaralcuadrado.Click += clickOperador;
            // 
            // btnRaizcuadrada
            // 
            btnRaizcuadrada.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRaizcuadrada.Location = new Point(224, 76);
            btnRaizcuadrada.Name = "btnRaizcuadrada";
            btnRaizcuadrada.Size = new Size(59, 46);
            btnRaizcuadrada.TabIndex = 19;
            btnRaizcuadrada.Tag = "√";
            btnRaizcuadrada.Text = "√";
            btnRaizcuadrada.UseVisualStyleBackColor = true;
            btnRaizcuadrada.Click += clickOperador;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicar.Location = new Point(289, 139);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(59, 46);
            btnMultiplicar.TabIndex = 18;
            btnMultiplicar.Tag = "X";
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += clickOperador;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(224, 139);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(59, 46);
            btnDividir.TabIndex = 17;
            btnDividir.Tag = "∕";
            btnDividir.Text = "∕";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += clickOperador;
            // 
            // btnRestar
            // 
            btnRestar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestar.Location = new Point(289, 195);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(59, 46);
            btnRestar.TabIndex = 16;
            btnRestar.Tag = "-";
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += clickOperador;
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSumar.Location = new Point(224, 195);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(59, 46);
            btnSumar.TabIndex = 15;
            btnSumar.Tag = "+";
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += clickOperador;
            // 
            // btnResultado
            // 
            btnResultado.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResultado.Location = new Point(224, 258);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(122, 107);
            btnResultado.TabIndex = 13;
            btnResultado.Text = "꞊";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPunto.Location = new Point(143, 319);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(59, 46);
            btnPunto.TabIndex = 23;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnCero
            // 
            btnCero.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCero.Location = new Point(78, 319);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(59, 46);
            btnCero.TabIndex = 22;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += agregarNumero;
            // 
            // bntSigno
            // 
            bntSigno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntSigno.Location = new Point(11, 319);
            bntSigno.Name = "bntSigno";
            bntSigno.Size = new Size(61, 46);
            bntSigno.TabIndex = 21;
            bntSigno.Text = "+∕­";
            bntSigno.UseVisualStyleBackColor = true;
            bntSigno.Click += bntSigno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 377);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(bntSigno);
            Controls.Add(btnElevaralcuadrado);
            Controls.Add(btnRaizcuadrada);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(btnResultado);
            Controls.Add(btnQuitar);
            Controls.Add(btnBorrartodo);
            Controls.Add(btnBorrar);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(txtResultado);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora by Sefora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnUno;
        private Button btnDos;
        private Button btnTres;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnCuatro;
        private Button btnQuitar;
        private Button btnBorrartodo;
        private Button btnBorrar;
        private Button btnNueve;
        private Button btnOcho;
        private Button btnSiete;
        private Button btnElevaralcuadrado;
        private Button btnRaizcuadrada;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnRestar;
        private Button btnSumar;
        private Button btnResultado;
        private Button btnPunto;
        private Button btnCero;
        private Button bntSigno;
    }
}
