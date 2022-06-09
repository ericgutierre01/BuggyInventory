namespace BuggyInventory
{
    partial class BuggyPiezas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PieNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PieCantidadInve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PieCantidadActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cantidad_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.atras_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PieId,
            this.PieNombre,
            this.PieCantidadInve});
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(16, 134);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(552, 131);
            this.dataGridView1.TabIndex = 0;
            // 
            // PieId
            // 
            this.PieId.DataPropertyName = "PieId";
            this.PieId.HeaderText = "ID";
            this.PieId.MinimumWidth = 8;
            this.PieId.Name = "PieId";
            this.PieId.ReadOnly = true;
            // 
            // PieNombre
            // 
            this.PieNombre.DataPropertyName = "PieNombre";
            this.PieNombre.HeaderText = "Nombre";
            this.PieNombre.MinimumWidth = 8;
            this.PieNombre.Name = "PieNombre";
            this.PieNombre.ReadOnly = true;
            // 
            // PieCantidadInve
            // 
            this.PieCantidadInve.DataPropertyName = "PieCantidadInve";
            this.PieCantidadInve.HeaderText = "Disponible";
            this.PieCantidadInve.MinimumWidth = 8;
            this.PieCantidadInve.Name = "PieCantidadInve";
            this.PieCantidadInve.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.PieCantidadActual,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(16, 283);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(766, 154);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PieId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // PieCantidadActual
            // 
            this.PieCantidadActual.DataPropertyName = "PieCantidadActual";
            this.PieCantidadActual.HeaderText = "PieCantidadActual";
            this.PieCantidadActual.MinimumWidth = 8;
            this.PieCantidadActual.Name = "PieCantidadActual";
            this.PieCantidadActual.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PieNombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PieCantidadInve";
            this.dataGridViewTextBoxColumn3.HeaderText = "Agregada";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar pieza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cantidad_tb
            // 
            this.cantidad_tb.Location = new System.Drawing.Point(663, 165);
            this.cantidad_tb.Name = "cantidad_tb";
            this.cantidad_tb.PlaceholderText = "0";
            this.cantidad_tb.Size = new System.Drawing.Size(113, 31);
            this.cantidad_tb.TabIndex = 3;
            this.cantidad_tb.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(308, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 54);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(766, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // atras_btn
            // 
            this.atras_btn.Location = new System.Drawing.Point(20, 50);
            this.atras_btn.Name = "atras_btn";
            this.atras_btn.Size = new System.Drawing.Size(112, 34);
            this.atras_btn.TabIndex = 8;
            this.atras_btn.Text = "Atras";
            this.atras_btn.UseVisualStyleBackColor = true;
            this.atras_btn.Click += new System.EventHandler(this.atras_btn_Click);
            // 
            // BuggyPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.atras_btn;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.atras_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantidad_tb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BuggyPiezas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuggyPiezas";
            this.Load += new System.EventHandler(this.BuggyPiezas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cantidad_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuggyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuggyNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuggyDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieCantidadInve;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieCantidadActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button atras_btn;
    }
}