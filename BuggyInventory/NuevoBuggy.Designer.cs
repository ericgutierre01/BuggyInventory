namespace BuggyInventory
{
    partial class NuevoBuggy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre_tb = new System.Windows.Forms.TextBox();
            this.ano_tb = new System.Windows.Forms.TextBox();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.descripcion_tb = new System.Windows.Forms.RichTextBox();
            this.atras_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Buggy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año del buggy";
            // 
            // nombre_tb
            // 
            this.nombre_tb.Location = new System.Drawing.Point(12, 116);
            this.nombre_tb.Name = "nombre_tb";
            this.nombre_tb.Size = new System.Drawing.Size(329, 31);
            this.nombre_tb.TabIndex = 4;
            // 
            // ano_tb
            // 
            this.ano_tb.Location = new System.Drawing.Point(12, 347);
            this.ano_tb.Name = "ano_tb";
            this.ano_tb.Size = new System.Drawing.Size(329, 31);
            this.ano_tb.TabIndex = 6;
            // 
            // guardar_btn
            // 
            this.guardar_btn.BackColor = System.Drawing.Color.Blue;
            this.guardar_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guardar_btn.Location = new System.Drawing.Point(12, 405);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(329, 59);
            this.guardar_btn.TabIndex = 7;
            this.guardar_btn.Text = "Guardar";
            this.guardar_btn.UseVisualStyleBackColor = false;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // descripcion_tb
            // 
            this.descripcion_tb.Location = new System.Drawing.Point(12, 190);
            this.descripcion_tb.Name = "descripcion_tb";
            this.descripcion_tb.Size = new System.Drawing.Size(329, 114);
            this.descripcion_tb.TabIndex = 8;
            this.descripcion_tb.Text = "";
            // 
            // atras_btn
            // 
            this.atras_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.atras_btn.Location = new System.Drawing.Point(12, 12);
            this.atras_btn.Name = "atras_btn";
            this.atras_btn.Size = new System.Drawing.Size(61, 58);
            this.atras_btn.TabIndex = 9;
            this.atras_btn.Text = "X";
            this.atras_btn.UseVisualStyleBackColor = false;
            this.atras_btn.Click += new System.EventHandler(this.atras_btn_Click);
            // 
            // NuevoBuggy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 489);
            this.Controls.Add(this.atras_btn);
            this.Controls.Add(this.descripcion_tb);
            this.Controls.Add(this.guardar_btn);
            this.Controls.Add(this.ano_tb);
            this.Controls.Add(this.nombre_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoBuggy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoBuggy";
            this.Load += new System.EventHandler(this.NuevoBuggy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre_tb;
        private System.Windows.Forms.TextBox ano_tb;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.RichTextBox descripcion_tb;
        private System.Windows.Forms.Button atras_btn;
    }
}