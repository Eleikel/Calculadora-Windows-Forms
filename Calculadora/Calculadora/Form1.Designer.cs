
namespace Calculadora
{
    partial class Calculadora
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonCero = new System.Windows.Forms.Button();
            this.buttonPunto = new System.Windows.Forms.Button();
            this.buttonResultado = new System.Windows.Forms.Button();
            this.buttonDividir = new System.Windows.Forms.Button();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.buttonRestar = new System.Windows.Forms.Button();
            this.buttonSumar = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(86, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(160, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(12, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(86, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 43);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(160, 193);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 43);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(12, 135);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 43);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(86, 135);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 43);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(160, 135);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 43);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonCero
            // 
            this.buttonCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonCero.Location = new System.Drawing.Point(12, 311);
            this.buttonCero.Name = "buttonCero";
            this.buttonCero.Size = new System.Drawing.Size(68, 43);
            this.buttonCero.TabIndex = 9;
            this.buttonCero.Text = "0";
            this.buttonCero.UseVisualStyleBackColor = true;
            this.buttonCero.Click += new System.EventHandler(this.button_Cero);
            // 
            // buttonPunto
            // 
            this.buttonPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonPunto.Location = new System.Drawing.Point(86, 311);
            this.buttonPunto.Name = "buttonPunto";
            this.buttonPunto.Size = new System.Drawing.Size(68, 43);
            this.buttonPunto.TabIndex = 10;
            this.buttonPunto.Text = ".";
            this.buttonPunto.UseVisualStyleBackColor = true;
            this.buttonPunto.Click += new System.EventHandler(this.buttonPunto_Click);
            // 
            // buttonResultado
            // 
            this.buttonResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonResultado.Location = new System.Drawing.Point(160, 311);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(68, 43);
            this.buttonResultado.TabIndex = 11;
            this.buttonResultado.Text = "=";
            this.buttonResultado.UseVisualStyleBackColor = true;
            this.buttonResultado.Click += new System.EventHandler(this.buttonResultado_Click);
            // 
            // buttonDividir
            // 
            this.buttonDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonDividir.Location = new System.Drawing.Point(234, 311);
            this.buttonDividir.Name = "buttonDividir";
            this.buttonDividir.Size = new System.Drawing.Size(68, 43);
            this.buttonDividir.TabIndex = 12;
            this.buttonDividir.Text = "÷";
            this.buttonDividir.UseVisualStyleBackColor = true;
            this.buttonDividir.Click += new System.EventHandler(this.buttonDividir_Click);
            // 
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonMultiplicar.Location = new System.Drawing.Point(234, 252);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(68, 43);
            this.buttonMultiplicar.TabIndex = 13;
            this.buttonMultiplicar.Text = "X";
            this.buttonMultiplicar.UseVisualStyleBackColor = true;
            this.buttonMultiplicar.Click += new System.EventHandler(this.buttonMultiplicar_Click);
            // 
            // buttonRestar
            // 
            this.buttonRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonRestar.Location = new System.Drawing.Point(234, 193);
            this.buttonRestar.Name = "buttonRestar";
            this.buttonRestar.Size = new System.Drawing.Size(68, 43);
            this.buttonRestar.TabIndex = 14;
            this.buttonRestar.Text = "-";
            this.buttonRestar.UseVisualStyleBackColor = true;
            this.buttonRestar.Click += new System.EventHandler(this.buttonRestar_Click);
            // 
            // buttonSumar
            // 
            this.buttonSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSumar.Location = new System.Drawing.Point(234, 135);
            this.buttonSumar.Name = "buttonSumar";
            this.buttonSumar.Size = new System.Drawing.Size(68, 43);
            this.buttonSumar.TabIndex = 15;
            this.buttonSumar.Text = "+";
            this.buttonSumar.UseVisualStyleBackColor = true;
            this.buttonSumar.Click += new System.EventHandler(this.buttonSumar_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonReset.Location = new System.Drawing.Point(13, 86);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(88, 43);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "C";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Pantalla
            // 
            this.Pantalla.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Pantalla.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.Location = new System.Drawing.Point(8, 25);
            this.Pantalla.Multiline = true;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(290, 46);
            this.Pantalla.TabIndex = 17;
            this.Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Pantalla.TextChanged += new System.EventHandler(this.Pantalla_TextChanged);
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(12, 9);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(0, 13);
            this.lblHistorial.TabIndex = 18;
            this.lblHistorial.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(107, 86);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 43);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Stencil", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(44, 369);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(184, 16);
            this.label.TabIndex = 20;
            this.label.Text = "Esleiker\'s Calculator";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(310, 394);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSumar);
            this.Controls.Add(this.buttonRestar);
            this.Controls.Add(this.buttonMultiplicar);
            this.Controls.Add(this.buttonDividir);
            this.Controls.Add(this.buttonResultado);
            this.Controls.Add(this.buttonPunto);
            this.Controls.Add(this.buttonCero);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonCero;
        private System.Windows.Forms.Button buttonPunto;
        private System.Windows.Forms.Button buttonResultado;
        private System.Windows.Forms.Button buttonDividir;
        private System.Windows.Forms.Button buttonMultiplicar;
        private System.Windows.Forms.Button buttonRestar;
        private System.Windows.Forms.Button buttonSumar;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

