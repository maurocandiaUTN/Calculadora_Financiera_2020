namespace Calculadora_Financiera_2020
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
            this.but_punto = new System.Windows.Forms.Button();
            this.but_tres = new System.Windows.Forms.Button();
            this.but_dos = new System.Windows.Forms.Button();
            this.but_uno = new System.Windows.Forms.Button();
            this.but_mas = new System.Windows.Forms.Button();
            this.but_limpiar = new System.Windows.Forms.Button();
            this.but_mult = new System.Windows.Forms.Button();
            this.but_nueve = new System.Windows.Forms.Button();
            this.but_ocho = new System.Windows.Forms.Button();
            this.but_div = new System.Windows.Forms.Button();
            this.but_seis = new System.Windows.Forms.Button();
            this.but_cinco = new System.Windows.Forms.Button();
            this.but_cuatro = new System.Windows.Forms.Button();
            this.text_pantalla = new System.Windows.Forms.TextBox();
            this.but_siete = new System.Windows.Forms.Button();
            this.but_menos = new System.Windows.Forms.Button();
            this.but_igual = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_signo = new System.Windows.Forms.Button();
            this.comboBox_OP = new System.Windows.Forms.ComboBox();
            this.OPERACIONES = new System.Windows.Forms.Label();
            this.but_OPF = new System.Windows.Forms.Button();
            this.text_VALOR3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_VALOR2 = new System.Windows.Forms.TextBox();
            this.text_VALOR1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.but_cero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_punto
            // 
            this.but_punto.BackColor = System.Drawing.Color.Black;
            this.but_punto.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_punto.ForeColor = System.Drawing.Color.White;
            this.but_punto.Location = new System.Drawing.Point(136, 467);
            this.but_punto.Name = "but_punto";
            this.but_punto.Size = new System.Drawing.Size(108, 37);
            this.but_punto.TabIndex = 0;
            this.but_punto.Text = ".";
            this.but_punto.UseVisualStyleBackColor = false;
            this.but_punto.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_tres
            // 
            this.but_tres.BackColor = System.Drawing.SystemColors.WindowText;
            this.but_tres.ForeColor = System.Drawing.SystemColors.Window;
            this.but_tres.Location = new System.Drawing.Point(259, 414);
            this.but_tres.Name = "but_tres";
            this.but_tres.Size = new System.Drawing.Size(108, 34);
            this.but_tres.TabIndex = 4;
            this.but_tres.Text = "3";
            this.but_tres.UseVisualStyleBackColor = false;
            this.but_tres.Click += new System.EventHandler(this.but_tres_Click);
            // 
            // but_dos
            // 
            this.but_dos.BackColor = System.Drawing.SystemColors.WindowText;
            this.but_dos.ForeColor = System.Drawing.SystemColors.Window;
            this.but_dos.Location = new System.Drawing.Point(136, 414);
            this.but_dos.Name = "but_dos";
            this.but_dos.Size = new System.Drawing.Size(108, 34);
            this.but_dos.TabIndex = 5;
            this.but_dos.Text = "2";
            this.but_dos.UseVisualStyleBackColor = false;
            this.but_dos.Click += new System.EventHandler(this.but_dos_Click);
            // 
            // but_uno
            // 
            this.but_uno.BackColor = System.Drawing.SystemColors.WindowText;
            this.but_uno.ForeColor = System.Drawing.SystemColors.Info;
            this.but_uno.Location = new System.Drawing.Point(17, 414);
            this.but_uno.Name = "but_uno";
            this.but_uno.Size = new System.Drawing.Size(108, 34);
            this.but_uno.TabIndex = 6;
            this.but_uno.Text = "1";
            this.but_uno.UseVisualStyleBackColor = false;
            this.but_uno.Click += new System.EventHandler(this.but_uno_Click);
            // 
            // but_mas
            // 
            this.but_mas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_mas.Location = new System.Drawing.Point(382, 467);
            this.but_mas.Name = "but_mas";
            this.but_mas.Size = new System.Drawing.Size(108, 34);
            this.but_mas.TabIndex = 7;
            this.but_mas.Text = "+";
            this.but_mas.UseVisualStyleBackColor = false;
            this.but_mas.Click += new System.EventHandler(this.but_mas_Click);
            // 
            // but_limpiar
            // 
            this.but_limpiar.BackColor = System.Drawing.Color.Red;
            this.but_limpiar.ForeColor = System.Drawing.Color.White;
            this.but_limpiar.Location = new System.Drawing.Point(259, 271);
            this.but_limpiar.Name = "but_limpiar";
            this.but_limpiar.Size = new System.Drawing.Size(108, 34);
            this.but_limpiar.TabIndex = 9;
            this.but_limpiar.Text = "AC";
            this.but_limpiar.UseVisualStyleBackColor = false;
            this.but_limpiar.Click += new System.EventHandler(this.but_limpiar_Click);
            // 
            // but_mult
            // 
            this.but_mult.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_mult.Location = new System.Drawing.Point(382, 311);
            this.but_mult.Name = "but_mult";
            this.but_mult.Size = new System.Drawing.Size(108, 34);
            this.but_mult.TabIndex = 10;
            this.but_mult.Text = "x";
            this.but_mult.UseVisualStyleBackColor = false;
            this.but_mult.Click += new System.EventHandler(this.but_mult_Click);
            // 
            // but_nueve
            // 
            this.but_nueve.BackColor = System.Drawing.SystemColors.WindowText;
            this.but_nueve.ForeColor = System.Drawing.SystemColors.Info;
            this.but_nueve.Location = new System.Drawing.Point(259, 311);
            this.but_nueve.Name = "but_nueve";
            this.but_nueve.Size = new System.Drawing.Size(108, 34);
            this.but_nueve.TabIndex = 11;
            this.but_nueve.Text = "9";
            this.but_nueve.UseVisualStyleBackColor = false;
            this.but_nueve.Click += new System.EventHandler(this.but_nueve_Click);
            // 
            // but_ocho
            // 
            this.but_ocho.BackColor = System.Drawing.SystemColors.WindowText;
            this.but_ocho.ForeColor = System.Drawing.SystemColors.Info;
            this.but_ocho.Location = new System.Drawing.Point(136, 311);
            this.but_ocho.Name = "but_ocho";
            this.but_ocho.Size = new System.Drawing.Size(108, 34);
            this.but_ocho.TabIndex = 12;
            this.but_ocho.Text = "8";
            this.but_ocho.UseVisualStyleBackColor = false;
            this.but_ocho.Click += new System.EventHandler(this.but_ocho_Click);
            // 
            // but_div
            // 
            this.but_div.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_div.Location = new System.Drawing.Point(382, 361);
            this.but_div.Name = "but_div";
            this.but_div.Size = new System.Drawing.Size(108, 34);
            this.but_div.TabIndex = 14;
            this.but_div.Text = "÷";
            this.but_div.UseVisualStyleBackColor = false;
            this.but_div.Click += new System.EventHandler(this.but_div_Click);
            // 
            // but_seis
            // 
            this.but_seis.BackColor = System.Drawing.SystemColors.WindowText;
            this.but_seis.ForeColor = System.Drawing.SystemColors.Info;
            this.but_seis.Location = new System.Drawing.Point(259, 361);
            this.but_seis.Name = "but_seis";
            this.but_seis.Size = new System.Drawing.Size(108, 34);
            this.but_seis.TabIndex = 15;
            this.but_seis.Text = "6";
            this.but_seis.UseVisualStyleBackColor = false;
            this.but_seis.Click += new System.EventHandler(this.but_seis_Click);
            // 
            // but_cinco
            // 
            this.but_cinco.BackColor = System.Drawing.SystemColors.WindowText;
            this.but_cinco.ForeColor = System.Drawing.SystemColors.Info;
            this.but_cinco.Location = new System.Drawing.Point(136, 361);
            this.but_cinco.Name = "but_cinco";
            this.but_cinco.Size = new System.Drawing.Size(108, 34);
            this.but_cinco.TabIndex = 16;
            this.but_cinco.Text = "5";
            this.but_cinco.UseVisualStyleBackColor = false;
            this.but_cinco.Click += new System.EventHandler(this.but_cinco_Click);
            // 
            // but_cuatro
            // 
            this.but_cuatro.BackColor = System.Drawing.SystemColors.WindowText;
            this.but_cuatro.ForeColor = System.Drawing.SystemColors.Window;
            this.but_cuatro.Location = new System.Drawing.Point(17, 361);
            this.but_cuatro.Name = "but_cuatro";
            this.but_cuatro.Size = new System.Drawing.Size(108, 34);
            this.but_cuatro.TabIndex = 17;
            this.but_cuatro.Text = "4";
            this.but_cuatro.UseVisualStyleBackColor = false;
            this.but_cuatro.Click += new System.EventHandler(this.but_cuatro_Click);
            // 
            // text_pantalla
            // 
            this.text_pantalla.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.text_pantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_pantalla.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pantalla.ForeColor = System.Drawing.Color.White;
            this.text_pantalla.Location = new System.Drawing.Point(91, 181);
            this.text_pantalla.Multiline = true;
            this.text_pantalla.Name = "text_pantalla";
            this.text_pantalla.ReadOnly = true;
            this.text_pantalla.ShortcutsEnabled = false;
            this.text_pantalla.Size = new System.Drawing.Size(392, 64);
            this.text_pantalla.TabIndex = 18;
            this.text_pantalla.TextChanged += new System.EventHandler(this.text_pantalla_TextChanged);
            // 
            // but_siete
            // 
            this.but_siete.BackColor = System.Drawing.SystemColors.WindowText;
            this.but_siete.ForeColor = System.Drawing.SystemColors.Info;
            this.but_siete.Location = new System.Drawing.Point(22, 311);
            this.but_siete.Name = "but_siete";
            this.but_siete.Size = new System.Drawing.Size(108, 34);
            this.but_siete.TabIndex = 24;
            this.but_siete.Text = "7";
            this.but_siete.UseVisualStyleBackColor = false;
            this.but_siete.Click += new System.EventHandler(this.but_siete_Click);
            // 
            // but_menos
            // 
            this.but_menos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_menos.Location = new System.Drawing.Point(382, 414);
            this.but_menos.Name = "but_menos";
            this.but_menos.Size = new System.Drawing.Size(108, 34);
            this.but_menos.TabIndex = 26;
            this.but_menos.Text = "-";
            this.but_menos.UseVisualStyleBackColor = false;
            this.but_menos.Click += new System.EventHandler(this.but_menos_Click);
            // 
            // but_igual
            // 
            this.but_igual.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_igual.Location = new System.Drawing.Point(259, 467);
            this.but_igual.Name = "but_igual";
            this.but_igual.Size = new System.Drawing.Size(108, 34);
            this.but_igual.TabIndex = 27;
            this.but_igual.Text = "=";
            this.but_igual.UseVisualStyleBackColor = false;
            this.but_igual.Click += new System.EventHandler(this.but_igual_Click);
            // 
            // but_delete
            // 
            this.but_delete.BackColor = System.Drawing.Color.Red;
            this.but_delete.ForeColor = System.Drawing.Color.White;
            this.but_delete.Location = new System.Drawing.Point(136, 271);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(108, 34);
            this.but_delete.TabIndex = 28;
            this.but_delete.Text = "DEL";
            this.but_delete.UseVisualStyleBackColor = false;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_signo
            // 
            this.but_signo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_signo.Location = new System.Drawing.Point(382, 271);
            this.but_signo.Name = "but_signo";
            this.but_signo.Size = new System.Drawing.Size(108, 34);
            this.but_signo.TabIndex = 29;
            this.but_signo.Text = "(-)";
            this.but_signo.UseVisualStyleBackColor = false;
            this.but_signo.Click += new System.EventHandler(this.but_signo_Click);
            // 
            // comboBox_OP
            // 
            this.comboBox_OP.FormattingEnabled = true;
            this.comboBox_OP.Items.AddRange(new object[] {
            "INTERES SIMPLE",
            "INTERES COMPUESTO",
            "DESCUENTO SIMPLE",
            "MONTO"});
            this.comboBox_OP.Location = new System.Drawing.Point(176, 17);
            this.comboBox_OP.Name = "comboBox_OP";
            this.comboBox_OP.Size = new System.Drawing.Size(191, 21);
            this.comboBox_OP.TabIndex = 30;
            // 
            // OPERACIONES
            // 
            this.OPERACIONES.AutoSize = true;
            this.OPERACIONES.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OPERACIONES.Location = new System.Drawing.Point(12, 20);
            this.OPERACIONES.Name = "OPERACIONES";
            this.OPERACIONES.Size = new System.Drawing.Size(158, 13);
            this.OPERACIONES.TabIndex = 31;
            this.OPERACIONES.Text = "OPERACIONES FINANCIERAS";
            // 
            // but_OPF
            // 
            this.but_OPF.BackColor = System.Drawing.Color.Red;
            this.but_OPF.ForeColor = System.Drawing.Color.White;
            this.but_OPF.Location = new System.Drawing.Point(22, 271);
            this.but_OPF.Name = "but_OPF";
            this.but_OPF.Size = new System.Drawing.Size(108, 34);
            this.but_OPF.TabIndex = 32;
            this.but_OPF.Text = "OPF";
            this.but_OPF.UseVisualStyleBackColor = false;
            this.but_OPF.Click += new System.EventHandler(this.but_OPF_Click);
            // 
            // text_VALOR3
            // 
            this.text_VALOR3.Location = new System.Drawing.Point(84, 139);
            this.text_VALOR3.Name = "text_VALOR3";
            this.text_VALOR3.Size = new System.Drawing.Size(191, 20);
            this.text_VALOR3.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "VALOR 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "VALOR 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(14, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "VALOR 3";
            // 
            // text_VALOR2
            // 
            this.text_VALOR2.Location = new System.Drawing.Point(84, 103);
            this.text_VALOR2.Name = "text_VALOR2";
            this.text_VALOR2.Size = new System.Drawing.Size(191, 20);
            this.text_VALOR2.TabIndex = 40;
            // 
            // text_VALOR1
            // 
            this.text_VALOR1.Location = new System.Drawing.Point(84, 65);
            this.text_VALOR1.Name = "text_VALOR1";
            this.text_VALOR1.Size = new System.Drawing.Size(191, 20);
            this.text_VALOR1.TabIndex = 41;
            this.text_VALOR1.TextChanged += new System.EventHandler(this.text_VALOR1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "RESULTADO";
            // 
            // but_cero
            // 
            this.but_cero.BackColor = System.Drawing.SystemColors.WindowText;
            this.but_cero.ForeColor = System.Drawing.SystemColors.Window;
            this.but_cero.Location = new System.Drawing.Point(17, 467);
            this.but_cero.Name = "but_cero";
            this.but_cero.Size = new System.Drawing.Size(108, 34);
            this.but_cero.TabIndex = 43;
            this.but_cero.Text = "0";
            this.but_cero.UseVisualStyleBackColor = false;
            this.but_cero.Click += new System.EventHandler(this.but_cero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(505, 517);
            this.Controls.Add(this.but_cero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_VALOR1);
            this.Controls.Add(this.text_VALOR2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_VALOR3);
            this.Controls.Add(this.but_OPF);
            this.Controls.Add(this.OPERACIONES);
            this.Controls.Add(this.comboBox_OP);
            this.Controls.Add(this.but_signo);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_igual);
            this.Controls.Add(this.but_menos);
            this.Controls.Add(this.but_siete);
            this.Controls.Add(this.text_pantalla);
            this.Controls.Add(this.but_cuatro);
            this.Controls.Add(this.but_cinco);
            this.Controls.Add(this.but_seis);
            this.Controls.Add(this.but_div);
            this.Controls.Add(this.but_ocho);
            this.Controls.Add(this.but_nueve);
            this.Controls.Add(this.but_mult);
            this.Controls.Add(this.but_limpiar);
            this.Controls.Add(this.but_mas);
            this.Controls.Add(this.but_uno);
            this.Controls.Add(this.but_dos);
            this.Controls.Add(this.but_tres);
            this.Controls.Add(this.but_punto);
            this.Name = "Form1";
            this.Text = "Calculadora Financiera 2020";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_punto;
        private System.Windows.Forms.Button but_tres;
        private System.Windows.Forms.Button but_dos;
        private System.Windows.Forms.Button but_uno;
        private System.Windows.Forms.Button but_mas;
        private System.Windows.Forms.Button but_limpiar;
        private System.Windows.Forms.Button but_mult;
        private System.Windows.Forms.Button but_nueve;
        private System.Windows.Forms.Button but_ocho;
        private System.Windows.Forms.Button but_div;
        private System.Windows.Forms.Button but_seis;
        private System.Windows.Forms.Button but_cinco;
        private System.Windows.Forms.Button but_cuatro;
        private System.Windows.Forms.TextBox text_pantalla;
        private System.Windows.Forms.Button but_siete;
        private System.Windows.Forms.Button but_menos;
        private System.Windows.Forms.Button but_igual;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_signo;
        private System.Windows.Forms.ComboBox comboBox_OP;
        private System.Windows.Forms.Label OPERACIONES;
        private System.Windows.Forms.Button but_OPF;
        private System.Windows.Forms.TextBox text_VALOR3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_VALOR2;
        private System.Windows.Forms.TextBox text_VALOR1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but_cero;
    }
}

