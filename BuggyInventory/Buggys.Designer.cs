namespace BuggyInventory
{
    partial class Buggys
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
            this.button1 = new System.Windows.Forms.Button();
            this.ponerPiezas_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BuggyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuggyNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuggyDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuggyAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuggyFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuggyFechaActualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atrar_btn = new System.Windows.Forms.Button();
            this.verPiezas_btn = new System.Windows.Forms.Button();
            this.filtro_cb = new System.Windows.Forms.ComboBox();
            this.piezas_gd = new System.Windows.Forms.DataGridView();
            this.PieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PieNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BPCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BPFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BPid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreBuggy_lb = new System.Windows.Forms.Label();
            this.atrasPanel_btn = new System.Windows.Forms.Button();
            this.piezas_panel = new System.Windows.Forms.Panel();
            this.filtro_tb = new System.Windows.Forms.TextBox();
            this.filtro_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezas_gd)).BeginInit();
            this.piezas_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ponerPiezas_btn
            // 
            this.ponerPiezas_btn.Location = new System.Drawing.Point(305, 137);
            this.ponerPiezas_btn.Name = "ponerPiezas_btn";
            this.ponerPiezas_btn.Size = new System.Drawing.Size(203, 34);
            this.ponerPiezas_btn.TabIndex = 1;
            this.ponerPiezas_btn.Text = "Poner Piezas";
            this.ponerPiezas_btn.UseVisualStyleBackColor = true;
            this.ponerPiezas_btn.Click += new System.EventHandler(this.ponerPiezas_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuggyId,
            this.BuggyNombre,
            this.BuggyDescripcion,
            this.BuggyAno,
            this.BuggyFechaCreacion,
            this.BuggyFechaActualizacion});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 177);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(800, 273);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BuggyId
            // 
            this.BuggyId.DataPropertyName = "BuggyId";
            this.BuggyId.FillWeight = 113.6364F;
            this.BuggyId.HeaderText = "ID";
            this.BuggyId.MinimumWidth = 8;
            this.BuggyId.Name = "BuggyId";
            this.BuggyId.ReadOnly = true;
            this.BuggyId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BuggyNombre
            // 
            this.BuggyNombre.DataPropertyName = "BuggyNombre";
            this.BuggyNombre.FillWeight = 95.45454F;
            this.BuggyNombre.HeaderText = "Nombre";
            this.BuggyNombre.MinimumWidth = 8;
            this.BuggyNombre.Name = "BuggyNombre";
            this.BuggyNombre.ReadOnly = true;
            // 
            // BuggyDescripcion
            // 
            this.BuggyDescripcion.DataPropertyName = "BuggyDescripcion";
            this.BuggyDescripcion.FillWeight = 95.45454F;
            this.BuggyDescripcion.HeaderText = "Descripcion";
            this.BuggyDescripcion.MinimumWidth = 8;
            this.BuggyDescripcion.Name = "BuggyDescripcion";
            this.BuggyDescripcion.ReadOnly = true;
            // 
            // BuggyAno
            // 
            this.BuggyAno.DataPropertyName = "BuggyAno";
            this.BuggyAno.FillWeight = 95.45454F;
            this.BuggyAno.HeaderText = "Año";
            this.BuggyAno.MinimumWidth = 8;
            this.BuggyAno.Name = "BuggyAno";
            this.BuggyAno.ReadOnly = true;
            // 
            // BuggyFechaCreacion
            // 
            this.BuggyFechaCreacion.DataPropertyName = "BuggyFechaCreacion";
            this.BuggyFechaCreacion.HeaderText = "FechaCreacion";
            this.BuggyFechaCreacion.MinimumWidth = 8;
            this.BuggyFechaCreacion.Name = "BuggyFechaCreacion";
            this.BuggyFechaCreacion.ReadOnly = true;
            this.BuggyFechaCreacion.Visible = false;
            // 
            // BuggyFechaActualizacion
            // 
            this.BuggyFechaActualizacion.DataPropertyName = "BuggyFechaActualizacion";
            this.BuggyFechaActualizacion.HeaderText = "Actualizacion";
            this.BuggyFechaActualizacion.MinimumWidth = 8;
            this.BuggyFechaActualizacion.Name = "BuggyFechaActualizacion";
            this.BuggyFechaActualizacion.ReadOnly = true;
            this.BuggyFechaActualizacion.Visible = false;
            // 
            // atrar_btn
            // 
            this.atrar_btn.Location = new System.Drawing.Point(25, 12);
            this.atrar_btn.Name = "atrar_btn";
            this.atrar_btn.Size = new System.Drawing.Size(112, 34);
            this.atrar_btn.TabIndex = 3;
            this.atrar_btn.Text = "Atras";
            this.atrar_btn.UseVisualStyleBackColor = true;
            this.atrar_btn.Click += new System.EventHandler(this.atrar_btn_Click);
            // 
            // verPiezas_btn
            // 
            this.verPiezas_btn.Location = new System.Drawing.Point(585, 137);
            this.verPiezas_btn.Name = "verPiezas_btn";
            this.verPiezas_btn.Size = new System.Drawing.Size(203, 34);
            this.verPiezas_btn.TabIndex = 4;
            this.verPiezas_btn.Text = "Ver Piezas";
            this.verPiezas_btn.UseVisualStyleBackColor = true;
            this.verPiezas_btn.Click += new System.EventHandler(this.verPiezas_btn_Click);
            // 
            // filtro_cb
            // 
            this.filtro_cb.FormattingEnabled = true;
            this.filtro_cb.IntegralHeight = false;
            this.filtro_cb.Items.AddRange(new object[] {
            "Todos",
            "ID",
            "Nombre"});
            this.filtro_cb.Location = new System.Drawing.Point(241, 40);
            this.filtro_cb.Name = "filtro_cb";
            this.filtro_cb.Size = new System.Drawing.Size(182, 33);
            this.filtro_cb.TabIndex = 1;
            this.filtro_cb.TabStop = false;
            this.filtro_cb.SelectedValueChanged += new System.EventHandler(this.filtro_cb_SelectedValueChanged);
            // 
            // piezas_gd
            // 
            this.piezas_gd.AllowUserToAddRows = false;
            this.piezas_gd.AllowUserToDeleteRows = false;
            this.piezas_gd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.piezas_gd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.piezas_gd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PieId,
            this.PieNombre,
            this.BPCantidad,
            this.BPFechaCreacion,
            this.BPid,
            this.dataGridViewTextBoxColumn1});
            this.piezas_gd.Location = new System.Drawing.Point(12, 77);
            this.piezas_gd.MultiSelect = false;
            this.piezas_gd.Name = "piezas_gd";
            this.piezas_gd.ReadOnly = true;
            this.piezas_gd.RowHeadersVisible = false;
            this.piezas_gd.RowHeadersWidth = 62;
            this.piezas_gd.RowTemplate.Height = 33;
            this.piezas_gd.Size = new System.Drawing.Size(776, 358);
            this.piezas_gd.TabIndex = 0;
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
            this.PieNombre.HeaderText = "Pieza";
            this.PieNombre.MinimumWidth = 8;
            this.PieNombre.Name = "PieNombre";
            this.PieNombre.ReadOnly = true;
            // 
            // BPCantidad
            // 
            this.BPCantidad.DataPropertyName = "BPCantidad";
            this.BPCantidad.HeaderText = "Cantidad";
            this.BPCantidad.MinimumWidth = 8;
            this.BPCantidad.Name = "BPCantidad";
            this.BPCantidad.ReadOnly = true;
            // 
            // BPFechaCreacion
            // 
            this.BPFechaCreacion.DataPropertyName = "BPFechaCreacion";
            this.BPFechaCreacion.HeaderText = "Fecha";
            this.BPFechaCreacion.MinimumWidth = 8;
            this.BPFechaCreacion.Name = "BPFechaCreacion";
            this.BPFechaCreacion.ReadOnly = true;
            // 
            // BPid
            // 
            this.BPid.DataPropertyName = "BPid";
            this.BPid.HeaderText = "BPid";
            this.BPid.MinimumWidth = 8;
            this.BPid.Name = "BPid";
            this.BPid.ReadOnly = true;
            this.BPid.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BuggyId";
            this.dataGridViewTextBoxColumn1.HeaderText = "BuggyId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // nombreBuggy_lb
            // 
            this.nombreBuggy_lb.AutoSize = true;
            this.nombreBuggy_lb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreBuggy_lb.Location = new System.Drawing.Point(327, 25);
            this.nombreBuggy_lb.Name = "nombreBuggy_lb";
            this.nombreBuggy_lb.Size = new System.Drawing.Size(91, 38);
            this.nombreBuggy_lb.TabIndex = 1;
            this.nombreBuggy_lb.Text = "label1";
            this.nombreBuggy_lb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // atrasPanel_btn
            // 
            this.atrasPanel_btn.Location = new System.Drawing.Point(24, 25);
            this.atrasPanel_btn.Name = "atrasPanel_btn";
            this.atrasPanel_btn.Size = new System.Drawing.Size(112, 34);
            this.atrasPanel_btn.TabIndex = 2;
            this.atrasPanel_btn.Text = "Atras";
            this.atrasPanel_btn.UseVisualStyleBackColor = true;
            this.atrasPanel_btn.Click += new System.EventHandler(this.atrasPanel_btn_Click);
            // 
            // piezas_panel
            // 
            this.piezas_panel.Controls.Add(this.atrasPanel_btn);
            this.piezas_panel.Controls.Add(this.nombreBuggy_lb);
            this.piezas_panel.Controls.Add(this.piezas_gd);
            this.piezas_panel.Location = new System.Drawing.Point(0, 12);
            this.piezas_panel.Name = "piezas_panel";
            this.piezas_panel.Size = new System.Drawing.Size(800, 438);
            this.piezas_panel.TabIndex = 5;
            this.piezas_panel.TabStop = true;
            this.piezas_panel.Visible = false;
            // 
            // filtro_tb
            // 
            this.filtro_tb.Location = new System.Drawing.Point(429, 40);
            this.filtro_tb.Name = "filtro_tb";
            this.filtro_tb.Size = new System.Drawing.Size(150, 31);
            this.filtro_tb.TabIndex = 6;
            // 
            // filtro_btn
            // 
            this.filtro_btn.Location = new System.Drawing.Point(585, 40);
            this.filtro_btn.Name = "filtro_btn";
            this.filtro_btn.Size = new System.Drawing.Size(112, 34);
            this.filtro_btn.TabIndex = 7;
            this.filtro_btn.Text = "Filtrar";
            this.filtro_btn.UseVisualStyleBackColor = true;
            this.filtro_btn.Click += new System.EventHandler(this.filtro_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filtros de busqueda";
            // 
            // Buggys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.piezas_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtro_btn);
            this.Controls.Add(this.filtro_tb);
            this.Controls.Add(this.filtro_cb);
            this.Controls.Add(this.verPiezas_btn);
            this.Controls.Add(this.atrar_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ponerPiezas_btn);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Buggys";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buggys";
            this.Load += new System.EventHandler(this.Buggys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezas_gd)).EndInit();
            this.piezas_panel.ResumeLayout(false);
            this.piezas_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ponerPiezas_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuggyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuggyNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuggyDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuggyAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuggyFechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuggyFechaActualizacion;
        private System.Windows.Forms.Button atrar_btn;
        private System.Windows.Forms.Button verPiezas_btn;
        private System.Windows.Forms.ComboBox filtro_cb;
        private System.Windows.Forms.DataGridView piezas_gd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PieNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPFechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label nombreBuggy_lb;
        private System.Windows.Forms.Button atrasPanel_btn;
        private System.Windows.Forms.Panel piezas_panel;
        private System.Windows.Forms.TextBox filtro_tb;
        private System.Windows.Forms.Button filtro_btn;
        private System.Windows.Forms.Label label1;
    }
}