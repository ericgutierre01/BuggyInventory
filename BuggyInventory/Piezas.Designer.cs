namespace BuggyInventory
{
    partial class Piezas
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
            this.Piezas_dgv = new System.Windows.Forms.DataGridView();
            this.PieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PieNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PieDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PieCantidadInve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PieFechaActualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PieFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PieCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PieCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PieFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atras_btn = new System.Windows.Forms.Button();
            this.agregar_btn = new System.Windows.Forms.Button();
            this.editar_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filtro_btn = new System.Windows.Forms.Button();
            this.filtro_tb = new System.Windows.Forms.TextBox();
            this.filtro_cb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Piezas_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Piezas_dgv
            // 
            this.Piezas_dgv.AllowUserToAddRows = false;
            this.Piezas_dgv.AllowUserToDeleteRows = false;
            this.Piezas_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Piezas_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Piezas_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PieId,
            this.PieNombre,
            this.PieDescripcion,
            this.PieCantidadInve,
            this.PieFechaActualizacion,
            this.PieFechaCreacion,
            this.PieCodigo,
            this.PieCosto,
            this.PieFoto});
            this.Piezas_dgv.Location = new System.Drawing.Point(3, 180);
            this.Piezas_dgv.MultiSelect = false;
            this.Piezas_dgv.Name = "Piezas_dgv";
            this.Piezas_dgv.ReadOnly = true;
            this.Piezas_dgv.RowHeadersVisible = false;
            this.Piezas_dgv.RowHeadersWidth = 62;
            this.Piezas_dgv.RowTemplate.Height = 33;
            this.Piezas_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Piezas_dgv.Size = new System.Drawing.Size(797, 270);
            this.Piezas_dgv.TabIndex = 0;
            // 
            // PieId
            // 
            this.PieId.DataPropertyName = "PieId";
            this.PieId.FillWeight = 24.78383F;
            this.PieId.HeaderText = "ID";
            this.PieId.MinimumWidth = 8;
            this.PieId.Name = "PieId";
            this.PieId.ReadOnly = true;
            // 
            // PieNombre
            // 
            this.PieNombre.DataPropertyName = "PieNombre";
            this.PieNombre.FillWeight = 69.60228F;
            this.PieNombre.HeaderText = "Nombre";
            this.PieNombre.MinimumWidth = 8;
            this.PieNombre.Name = "PieNombre";
            this.PieNombre.ReadOnly = true;
            // 
            // PieDescripcion
            // 
            this.PieDescripcion.DataPropertyName = "PieDescripcion";
            this.PieDescripcion.FillWeight = 92.01379F;
            this.PieDescripcion.HeaderText = "Descripción";
            this.PieDescripcion.MinimumWidth = 8;
            this.PieDescripcion.Name = "PieDescripcion";
            this.PieDescripcion.ReadOnly = true;
            // 
            // PieCantidadInve
            // 
            this.PieCantidadInve.DataPropertyName = "PieCantidadInve";
            this.PieCantidadInve.FillWeight = 36.3274F;
            this.PieCantidadInve.HeaderText = "Disponible";
            this.PieCantidadInve.MinimumWidth = 8;
            this.PieCantidadInve.Name = "PieCantidadInve";
            this.PieCantidadInve.ReadOnly = true;
            // 
            // PieFechaActualizacion
            // 
            this.PieFechaActualizacion.DataPropertyName = "PieFechaActualizacion";
            this.PieFechaActualizacion.HeaderText = "PieFechaActualizacion";
            this.PieFechaActualizacion.MinimumWidth = 8;
            this.PieFechaActualizacion.Name = "PieFechaActualizacion";
            this.PieFechaActualizacion.ReadOnly = true;
            this.PieFechaActualizacion.Visible = false;
            // 
            // PieFechaCreacion
            // 
            this.PieFechaCreacion.DataPropertyName = "PieFechaCreacion";
            this.PieFechaCreacion.HeaderText = "Fecha";
            this.PieFechaCreacion.MinimumWidth = 8;
            this.PieFechaCreacion.Name = "PieFechaCreacion";
            this.PieFechaCreacion.ReadOnly = true;
            this.PieFechaCreacion.Visible = false;
            // 
            // PieCodigo
            // 
            this.PieCodigo.DataPropertyName = "PieCodigo";
            this.PieCodigo.HeaderText = "Codigo";
            this.PieCodigo.MinimumWidth = 8;
            this.PieCodigo.Name = "PieCodigo";
            this.PieCodigo.ReadOnly = true;
            this.PieCodigo.Visible = false;
            // 
            // PieCosto
            // 
            this.PieCosto.DataPropertyName = "PieCosto";
            this.PieCosto.HeaderText = "Costo";
            this.PieCosto.MinimumWidth = 8;
            this.PieCosto.Name = "PieCosto";
            this.PieCosto.ReadOnly = true;
            this.PieCosto.Visible = false;
            // 
            // PieFoto
            // 
            this.PieFoto.DataPropertyName = "PieFoto";
            this.PieFoto.HeaderText = "PieFoto";
            this.PieFoto.MinimumWidth = 8;
            this.PieFoto.Name = "PieFoto";
            this.PieFoto.ReadOnly = true;
            this.PieFoto.Visible = false;
            // 
            // atras_btn
            // 
            this.atras_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.atras_btn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.atras_btn.Location = new System.Drawing.Point(12, 25);
            this.atras_btn.Name = "atras_btn";
            this.atras_btn.Size = new System.Drawing.Size(112, 34);
            this.atras_btn.TabIndex = 1;
            this.atras_btn.Text = "Atras";
            this.atras_btn.UseVisualStyleBackColor = false;
            this.atras_btn.Click += new System.EventHandler(this.atras_btn_Click);
            // 
            // agregar_btn
            // 
            this.agregar_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.agregar_btn.Location = new System.Drawing.Point(12, 128);
            this.agregar_btn.Name = "agregar_btn";
            this.agregar_btn.Size = new System.Drawing.Size(190, 46);
            this.agregar_btn.TabIndex = 2;
            this.agregar_btn.Text = "Agregar  Pieza";
            this.agregar_btn.UseVisualStyleBackColor = false;
            this.agregar_btn.Click += new System.EventHandler(this.agregar_btn_Click);
            // 
            // editar_btn
            // 
            this.editar_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editar_btn.Location = new System.Drawing.Point(350, 128);
            this.editar_btn.Name = "editar_btn";
            this.editar_btn.Size = new System.Drawing.Size(228, 46);
            this.editar_btn.TabIndex = 3;
            this.editar_btn.Text = "Editar Pieza";
            this.editar_btn.UseVisualStyleBackColor = false;
            this.editar_btn.Click += new System.EventHandler(this.editar_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(584, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar Inventario";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filtros de busqueda";
            // 
            // filtro_btn
            // 
            this.filtro_btn.Location = new System.Drawing.Point(643, 53);
            this.filtro_btn.Name = "filtro_btn";
            this.filtro_btn.Size = new System.Drawing.Size(112, 34);
            this.filtro_btn.TabIndex = 11;
            this.filtro_btn.Text = "Filtrar";
            this.filtro_btn.UseVisualStyleBackColor = true;
            this.filtro_btn.Click += new System.EventHandler(this.filtro_btn_Click);
            // 
            // filtro_tb
            // 
            this.filtro_tb.Location = new System.Drawing.Point(487, 53);
            this.filtro_tb.Name = "filtro_tb";
            this.filtro_tb.Size = new System.Drawing.Size(150, 31);
            this.filtro_tb.TabIndex = 10;
            // 
            // filtro_cb
            // 
            this.filtro_cb.FormattingEnabled = true;
            this.filtro_cb.IntegralHeight = false;
            this.filtro_cb.Items.AddRange(new object[] {
            "Todos",
            "ID",
            "Nombre"});
            this.filtro_cb.Location = new System.Drawing.Point(299, 53);
            this.filtro_cb.Name = "filtro_cb";
            this.filtro_cb.Size = new System.Drawing.Size(182, 33);
            this.filtro_cb.TabIndex = 9;
            this.filtro_cb.TabStop = false;
            // 
            // Piezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtro_btn);
            this.Controls.Add(this.filtro_tb);
            this.Controls.Add(this.filtro_cb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editar_btn);
            this.Controls.Add(this.agregar_btn);
            this.Controls.Add(this.atras_btn);
            this.Controls.Add(this.Piezas_dgv);
            this.Name = "Piezas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piezas";
            this.Load += new System.EventHandler(this.Piezas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Piezas_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Piezas_dgv;
        private System.Windows.Forms.Button atras_btn;
        private System.Windows.Forms.Button agregar_btn;
        private System.Windows.Forms.Button editar_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filtro_btn;
        private System.Windows.Forms.TextBox filtro_tb;
        private System.Windows.Forms.ComboBox filtro_cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieCantidadInve;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieFechaActualizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieFechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieFoto;
    }
}