namespace BuggyInventory
{
    partial class NuevaPieza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.atras_btn = new System.Windows.Forms.Button();
            this.descripcion_tb = new System.Windows.Forms.RichTextBox();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.ano_tb = new System.Windows.Forms.TextBox();
            this.nombre_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Titulo_lb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nuevacantidad_tb = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // atras_btn
            // 
            this.atras_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.atras_btn.Location = new System.Drawing.Point(12, 9);
            this.atras_btn.Name = "atras_btn";
            this.atras_btn.Size = new System.Drawing.Size(61, 58);
            this.atras_btn.TabIndex = 18;
            this.atras_btn.Text = "X";
            this.atras_btn.UseVisualStyleBackColor = false;
            this.atras_btn.Click += new System.EventHandler(this.atras_btn_Click);
            // 
            // descripcion_tb
            // 
            this.descripcion_tb.Location = new System.Drawing.Point(12, 187);
            this.descripcion_tb.Name = "descripcion_tb";
            this.descripcion_tb.Size = new System.Drawing.Size(329, 114);
            this.descripcion_tb.TabIndex = 17;
            this.descripcion_tb.Text = "";
            // 
            // guardar_btn
            // 
            this.guardar_btn.BackColor = System.Drawing.Color.Blue;
            this.guardar_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guardar_btn.Location = new System.Drawing.Point(12, 402);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(329, 59);
            this.guardar_btn.TabIndex = 16;
            this.guardar_btn.Text = "Guardar";
            this.guardar_btn.UseVisualStyleBackColor = false;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // ano_tb
            // 
            this.ano_tb.Location = new System.Drawing.Point(12, 344);
            this.ano_tb.Name = "ano_tb";
            this.ano_tb.Size = new System.Drawing.Size(329, 31);
            this.ano_tb.TabIndex = 15;
            // 
            // nombre_tb
            // 
            this.nombre_tb.Location = new System.Drawing.Point(12, 113);
            this.nombre_tb.Name = "nombre_tb";
            this.nombre_tb.Size = new System.Drawing.Size(329, 31);
            this.nombre_tb.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cantidad Disponible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // Titulo_lb
            // 
            this.Titulo_lb.AutoSize = true;
            this.Titulo_lb.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo_lb.Location = new System.Drawing.Point(90, 21);
            this.Titulo_lb.Name = "Titulo_lb";
            this.Titulo_lb.Size = new System.Drawing.Size(201, 46);
            this.Titulo_lb.TabIndex = 10;
            this.Titulo_lb.Text = "Nueva Pieza";
            this.Titulo_lb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nuevacantidad_tb);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 311);
            this.panel1.TabIndex = 19;
            this.panel1.Visible = false;
            // 
            // nuevacantidad_tb
            // 
            this.nuevacantidad_tb.Location = new System.Drawing.Point(18, 174);
            this.nuevacantidad_tb.Name = "nuevacantidad_tb";
            this.nuevacantidad_tb.Size = new System.Drawing.Size(304, 31);
            this.nuevacantidad_tb.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(304, 31);
            this.textBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cantidad a Agregar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disponible ahora";
            // 
            // NuevaPieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.atras_btn);
            this.Controls.Add(this.descripcion_tb);
            this.Controls.Add(this.guardar_btn);
            this.Controls.Add(this.ano_tb);
            this.Controls.Add(this.nombre_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Titulo_lb);
            this.Name = "NuevaPieza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaPieza";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button atras_btn;
        private System.Windows.Forms.RichTextBox descripcion_tb;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.TextBox ano_tb;
        private System.Windows.Forms.TextBox nombre_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Titulo_lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nuevacantidad_tb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}