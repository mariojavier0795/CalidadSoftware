namespace PROYECTO_SIGSJC
{
    partial class IUVisualizacionDeEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IUVisualizacionDeEventos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gBOpcBusqueda = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cBParametro = new System.Windows.Forms.ComboBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.tLPBotones = new System.Windows.Forms.TableLayoutPanel();
            this.bModificar = new System.Windows.Forms.Button();
            this.bRegresar = new System.Windows.Forms.Button();
            this.gBTipoEven = new System.Windows.Forms.GroupBox();
            this.tLPTipos = new System.Windows.Forms.TableLayoutPanel();
            this.rBAsamblea = new System.Windows.Forms.RadioButton();
            this.rBEmp = new System.Windows.Forms.RadioButton();
            this.rBMinga = new System.Windows.Forms.RadioButton();
            this.dGtabla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gBOpcBusqueda.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tLPBotones.SuspendLayout();
            this.gBTipoEven.SuspendLayout();
            this.tLPTipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGtabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda de Eventos";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.gBOpcBusqueda, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tLPBotones, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.gBTipoEven, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dGtabla, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 40);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(681, 416);
            this.tableLayoutPanel4.TabIndex = 4;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // gBOpcBusqueda
            // 
            this.gBOpcBusqueda.Controls.Add(this.tableLayoutPanel1);
            this.gBOpcBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBOpcBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBOpcBusqueda.Location = new System.Drawing.Point(3, 70);
            this.gBOpcBusqueda.Name = "gBOpcBusqueda";
            this.gBOpcBusqueda.Size = new System.Drawing.Size(675, 87);
            this.gBOpcBusqueda.TabIndex = 5;
            this.gBOpcBusqueda.TabStop = false;
            this.gBOpcBusqueda.Text = "Opciones de Búsqueda";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.97214F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.02786F));
            this.tableLayoutPanel1.Controls.Add(this.cBParametro, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtbusqueda, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 68);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cBParametro
            // 
            this.cBParametro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cBParametro.FormattingEnabled = true;
            this.cBParametro.Items.AddRange(new object[] {
            "Fecha",
            "Nombre"});
            this.cBParametro.Location = new System.Drawing.Point(3, 23);
            this.cBParametro.Name = "cBParametro";
            this.cBParametro.Size = new System.Drawing.Size(214, 24);
            this.cBParametro.TabIndex = 0;
            this.cBParametro.Text = "- Seleccionar Opción -";
            this.cBParametro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbusqueda.Location = new System.Drawing.Point(223, 23);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(443, 22);
            this.txtbusqueda.TabIndex = 1;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
            // 
            // tLPBotones
            // 
            this.tLPBotones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tLPBotones.ColumnCount = 2;
            this.tLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPBotones.Controls.Add(this.bModificar, 1, 0);
            this.tLPBotones.Controls.Add(this.bRegresar, 0, 0);
            this.tLPBotones.Location = new System.Drawing.Point(171, 356);
            this.tLPBotones.Name = "tLPBotones";
            this.tLPBotones.RowCount = 1;
            this.tLPBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPBotones.Size = new System.Drawing.Size(339, 40);
            this.tLPBotones.TabIndex = 8;
            // 
            // bModificar
            // 
            this.bModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Image = global::PROYECTO_SIGSJC.Properties.Resources.wrench;
            this.bModificar.Location = new System.Drawing.Point(172, 3);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(164, 34);
            this.bModificar.TabIndex = 1;
            this.bModificar.Text = "Modificar";
            this.bModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bRegresar
            // 
            this.bRegresar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegresar.Image = ((System.Drawing.Image)(resources.GetObject("bRegresar.Image")));
            this.bRegresar.Location = new System.Drawing.Point(3, 3);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(163, 34);
            this.bRegresar.TabIndex = 0;
            this.bRegresar.Text = "Regresar";
            this.bRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bRegresar.UseVisualStyleBackColor = true;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click);
            // 
            // gBTipoEven
            // 
            this.gBTipoEven.AutoSize = true;
            this.gBTipoEven.Controls.Add(this.tLPTipos);
            this.gBTipoEven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBTipoEven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBTipoEven.Location = new System.Drawing.Point(3, 3);
            this.gBTipoEven.Name = "gBTipoEven";
            this.gBTipoEven.Size = new System.Drawing.Size(675, 61);
            this.gBTipoEven.TabIndex = 4;
            this.gBTipoEven.TabStop = false;
            this.gBTipoEven.Text = "Tipo De Evento";
            // 
            // tLPTipos
            // 
            this.tLPTipos.AutoSize = true;
            this.tLPTipos.ColumnCount = 3;
            this.tLPTipos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLPTipos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLPTipos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLPTipos.Controls.Add(this.rBAsamblea, 0, 0);
            this.tLPTipos.Controls.Add(this.rBEmp, 1, 0);
            this.tLPTipos.Controls.Add(this.rBMinga, 2, 0);
            this.tLPTipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLPTipos.Location = new System.Drawing.Point(3, 16);
            this.tLPTipos.Name = "tLPTipos";
            this.tLPTipos.RowCount = 1;
            this.tLPTipos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPTipos.Size = new System.Drawing.Size(669, 42);
            this.tLPTipos.TabIndex = 1;
            // 
            // rBAsamblea
            // 
            this.rBAsamblea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBAsamblea.AutoSize = true;
            this.rBAsamblea.Location = new System.Drawing.Point(67, 11);
            this.rBAsamblea.Name = "rBAsamblea";
            this.rBAsamblea.Size = new System.Drawing.Size(88, 20);
            this.rBAsamblea.TabIndex = 0;
            this.rBAsamblea.Text = "Asamblea";
            this.rBAsamblea.UseVisualStyleBackColor = true;
            this.rBAsamblea.CheckedChanged += new System.EventHandler(this.rBAsamblea_CheckedChanged);
            // 
            // rBEmp
            // 
            this.rBEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rBEmp.AutoSize = true;
            this.rBEmp.Location = new System.Drawing.Point(266, 3);
            this.rBEmp.Name = "rBEmp";
            this.rBEmp.Size = new System.Drawing.Size(137, 36);
            this.rBEmp.TabIndex = 1;
            this.rBEmp.Text = "Empadronamiento";
            this.rBEmp.UseVisualStyleBackColor = true;
            this.rBEmp.CheckedChanged += new System.EventHandler(this.rBEmp_CheckedChanged);
            // 
            // rBMinga
            // 
            this.rBMinga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBMinga.AutoSize = true;
            this.rBMinga.Location = new System.Drawing.Point(526, 11);
            this.rBMinga.Name = "rBMinga";
            this.rBMinga.Size = new System.Drawing.Size(63, 20);
            this.rBMinga.TabIndex = 2;
            this.rBMinga.Text = "Minga";
            this.rBMinga.UseVisualStyleBackColor = true;
            this.rBMinga.CheckedChanged += new System.EventHandler(this.rBMinga_CheckedChanged);
            // 
            // dGtabla
            // 
            this.dGtabla.AllowUserToAddRows = false;
            this.dGtabla.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGtabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dGtabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGtabla.CausesValidation = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGtabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dGtabla.ColumnHeadersHeight = 24;
            this.dGtabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGtabla.DefaultCellStyle = dataGridViewCellStyle10;
            this.dGtabla.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dGtabla.Location = new System.Drawing.Point(3, 163);
            this.dGtabla.MultiSelect = false;
            this.dGtabla.Name = "dGtabla";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGtabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGtabla.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dGtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGtabla.Size = new System.Drawing.Size(675, 170);
            this.dGtabla.TabIndex = 6;
            this.dGtabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGtabla_CellClick);
            this.dGtabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGtabla_CellContentClick);
            this.dGtabla.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGtabla_CellMouseDoubleClick);
            this.dGtabla.DoubleClick += new System.EventHandler(this.dGtabla_DoubleClick);
            this.dGtabla.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dGtabla_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle9.Format = "D";
            dataGridViewCellStyle9.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column2.HeaderText = "Fecha";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripción";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Asistentes";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // IUVisualizacionDeEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 461);
            this.Controls.Add(this.groupBox1);
            this.Name = "IUVisualizacionDeEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Eventos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.gBOpcBusqueda.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tLPBotones.ResumeLayout(false);
            this.gBTipoEven.ResumeLayout(false);
            this.gBTipoEven.PerformLayout();
            this.tLPTipos.ResumeLayout(false);
            this.tLPTipos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGtabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox gBTipoEven;
        private System.Windows.Forms.GroupBox gBOpcBusqueda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cBParametro;
        private System.Windows.Forms.TableLayoutPanel tLPBotones;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bRegresar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.TableLayoutPanel tLPTipos;
        private System.Windows.Forms.RadioButton rBAsamblea;
        private System.Windows.Forms.RadioButton rBEmp;
        private System.Windows.Forms.RadioButton rBMinga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dGtabla;
    }
}