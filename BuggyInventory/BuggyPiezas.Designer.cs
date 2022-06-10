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
            this.label3 = new System.Windows.Forms.Label();
            this.filtro_btn = new System.Windows.Forms.Button();
            this.filtro_tb = new System.Windows.Forms.TextBox();
            this.filtro_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 187);
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
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.PieCantidadActual,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(20, 361);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
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
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // PieCantidadActual
            // 
            this.PieCantidadActual.DataPropertyName = "PieCantidadActual";
            this.PieCantidadActual.HeaderText = "PieCantidadActual";
            this.PieCantidadActual.MinimumWidth = 8;
            this.PieCantidadActual.Name = "PieCantidadActual";
            this.PieCantidadActual.ReadOnly = true;
            this.PieCantidadActual.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PieNombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PieCantidadInve";
            this.dataGridViewTextBoxColumn3.HeaderText = "Agregadas";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(591, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar pieza";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cantidad_tb
            // 
            this.cantidad_tb.Location = new System.Drawing.Point(667, 218);
            this.cantidad_tb.Name = "cantidad_tb";
            this.cantidad_tb.PlaceholderText = "0";
            this.cantidad_tb.Size = new System.Drawing.Size(113, 31);
            this.cantidad_tb.TabIndex = 3;
            this.cantidad_tb.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(312, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 54);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(20, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(766, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // atras_btn
            // 
            this.atras_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.atras_btn.Location = new System.Drawing.Point(20, 50);
            this.atras_btn.Name = "atras_btn";
            this.atras_btn.Size = new System.Drawing.Size(112, 34);
            this.atras_btn.TabIndex = 8;
            this.atras_btn.Text = "Atras";
            this.atras_btn.UseVisualStyleBackColor = false;
            this.atras_btn.Click += new System.EventHandler(this.atras_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Filtros de busqueda";
            // 
            // filtro_btn
            // 
            this.filtro_btn.Location = new System.Drawing.Point(529, 130);
            this.filtro_btn.Name = "filtro_btn";
            this.filtro_btn.Size = new System.Drawing.Size(112, 34);
            this.filtro_btn.TabIndex = 15;
            this.filtro_btn.Text = "Filtrar";
            this.filtro_btn.UseVisualStyleBackColor = true;
            this.filtro_btn.Click += new System.EventHandler(this.filtro_btn_Click);
            // 
            // filtro_tb
            // 
            this.filtro_tb.Location = new System.Drawing.Point(373, 130);
            this.filtro_tb.Name = "filtro_tb";
            this.filtro_tb.Size = new System.Drawing.Size(150, 31);
            this.filtro_tb.TabIndex = 14;
            this.filtro_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filtro_KeyPress);
            // 
            // filtro_cb
            // 
            this.filtro_cb.FormattingEnabled = true;
            this.filtro_cb.IntegralHeight = false;
            this.filtro_cb.Items.AddRange(new object[] {
            "Todos",
            "ID",
            "Nombre"});
            this.filtro_cb.Location = new System.Drawing.Point(185, 130);
            this.filtro_cb.Name = "filtro_cb";
            this.filtro_cb.Size = new System.Drawing.Size(182, 33);
            this.filtro_cb.TabIndex = 13;
            this.filtro_cb.TabStop = false;
            this.filtro_cb.SelectedValueChanged += new System.EventHandler(this.filtro_cb_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Piezas agregadas";
            // 
            // BuggyPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.atras_btn;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filtro_btn);
            this.Controls.Add(this.filtro_tb);
            this.Controls.Add(this.filtro_cb);
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
        private System.Windows.Forms.Button atras_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieCantidadActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button filtro_btn;
        private System.Windows.Forms.TextBox filtro_tb;
        private System.Windows.Forms.ComboBox filtro_cb;
        private System.Windows.Forms.Label label4;
    }
}