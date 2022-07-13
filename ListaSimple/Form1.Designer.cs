namespace ListaSimple
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
            this.Insertar = new System.Windows.Forms.Button();
            this.UltElem = new System.Windows.Forms.Button();
            this.anterior = new System.Windows.Forms.Button();
            this.Siguiente = new System.Windows.Forms.Button();
            this.PrimerElem = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.cHoras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Insertar
            // 
            this.Insertar.Location = new System.Drawing.Point(421, 73);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(127, 48);
            this.Insertar.TabIndex = 0;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // UltElem
            // 
            this.UltElem.Location = new System.Drawing.Point(52, 185);
            this.UltElem.Name = "UltElem";
            this.UltElem.Size = new System.Drawing.Size(163, 55);
            this.UltElem.TabIndex = 1;
            this.UltElem.Text = "UltElem";
            this.UltElem.UseVisualStyleBackColor = true;
            this.UltElem.Click += new System.EventHandler(this.UltElem_Click);
            // 
            // anterior
            // 
            this.anterior.Location = new System.Drawing.Point(236, 185);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(163, 55);
            this.anterior.TabIndex = 2;
            this.anterior.Text = "Anterior";
            this.anterior.UseVisualStyleBackColor = true;
            this.anterior.Click += new System.EventHandler(this.anterior_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.Location = new System.Drawing.Point(405, 185);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(163, 55);
            this.Siguiente.TabIndex = 3;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // PrimerElem
            // 
            this.PrimerElem.Location = new System.Drawing.Point(597, 185);
            this.PrimerElem.Name = "PrimerElem";
            this.PrimerElem.Size = new System.Drawing.Size(163, 55);
            this.PrimerElem.TabIndex = 4;
            this.PrimerElem.Text = "PrimElem";
            this.PrimerElem.UseVisualStyleBackColor = true;
            this.PrimerElem.Click += new System.EventHandler(this.PrimerElem_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(199, 246);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(170, 55);
            this.button6.TabIndex = 5;
            this.button6.Text = "EliminarPrimero";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(440, 246);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(163, 55);
            this.button7.TabIndex = 6;
            this.button7.Text = "EliminarUltimo";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(327, 307);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(163, 55);
            this.button8.TabIndex = 7;
            this.button8.Text = "Eliminar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(327, 368);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(163, 55);
            this.button9.TabIndex = 8;
            this.button9.Text = "EliminarLista";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(177, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(187, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "CantH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(264, 70);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(125, 27);
            this.nombre.TabIndex = 11;
            // 
            // cHoras
            // 
            this.cHoras.Location = new System.Drawing.Point(264, 106);
            this.cHoras.Name = "cHoras";
            this.cHoras.Size = new System.Drawing.Size(125, 27);
            this.cHoras.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(637, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 13;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cHoras);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.PrimerElem);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.anterior);
            this.Controls.Add(this.UltElem);
            this.Controls.Add(this.Insertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Insertar;
        private Button UltElem;
        private Button anterior;
        private Button Siguiente;
        private Button PrimerElem;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Label label2;
        private TextBox nombre;
        private TextBox cHoras;
        private Label label3;
    }
}