namespace ParqueoAdministrator
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.panelData = new System.Windows.Forms.Panel();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.panelHead = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.comboVehicleType = new System.Windows.Forms.ComboBox();
            this.comboTypeLicensePlate = new System.Windows.Forms.ComboBox();
            this.txtFilterOwner = new System.Windows.Forms.TextBox();
            this.panelCreateParking = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelParkingFields = new System.Windows.Forms.Panel();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.splitParking = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvParqueos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelCreateParking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelParkingFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitParking)).BeginInit();
            this.splitParking.Panel2.SuspendLayout();
            this.splitParking.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParqueos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVehiculos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVehiculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehiculos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehiculos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvVehiculos.Location = new System.Drawing.Point(15, 15);
            this.dgvVehiculos.MultiSelect = false;
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvVehiculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVehiculos.RowHeadersVisible = false;
            this.dgvVehiculos.Size = new System.Drawing.Size(580, 380);
            this.dgvVehiculos.TabIndex = 0;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.White;
            this.panelData.Controls.Add(this.dgvVehiculos);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelData.Location = new System.Drawing.Point(0, 107);
            this.panelData.Name = "panelData";
            this.panelData.Padding = new System.Windows.Forms.Padding(15);
            this.panelData.Size = new System.Drawing.Size(610, 410);
            this.panelData.TabIndex = 1;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.BackColor = System.Drawing.Color.Indigo;
            this.splitMain.Panel1.ForeColor = System.Drawing.Color.White;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.panelHead);
            this.splitMain.Panel2.Controls.Add(this.panelData);
            this.splitMain.Size = new System.Drawing.Size(921, 517);
            this.splitMain.SplitterDistance = 307;
            this.splitMain.TabIndex = 2;
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.White;
            this.panelHead.Controls.Add(this.splitContainer2);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Padding = new System.Windows.Forms.Padding(15);
            this.panelHead.Size = new System.Drawing.Size(610, 107);
            this.panelHead.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(15, 15);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnClearFilters);
            this.splitContainer2.Panel2.Controls.Add(this.comboVehicleType);
            this.splitContainer2.Panel2.Controls.Add(this.comboTypeLicensePlate);
            this.splitContainer2.Panel2.Controls.Add(this.txtFilterOwner);
            this.splitContainer2.Size = new System.Drawing.Size(580, 77);
            this.splitContainer2.SplitterDistance = 38;
            this.splitContainer2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehiculos";
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackColor = System.Drawing.Color.DimGray;
            this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilters.ForeColor = System.Drawing.Color.White;
            this.btnClearFilters.Location = new System.Drawing.Point(479, 5);
            this.btnClearFilters.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(98, 23);
            this.btnClearFilters.TabIndex = 2;
            this.btnClearFilters.Text = "Clear Filter";
            this.btnClearFilters.UseVisualStyleBackColor = false;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // comboVehicleType
            // 
            this.comboVehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboVehicleType.FormattingEnabled = true;
            this.comboVehicleType.Location = new System.Drawing.Point(163, 7);
            this.comboVehicleType.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.comboVehicleType.Name = "comboVehicleType";
            this.comboVehicleType.Size = new System.Drawing.Size(121, 21);
            this.comboVehicleType.TabIndex = 1;
            this.comboVehicleType.Text = "Type";
            this.comboVehicleType.SelectedValueChanged += new System.EventHandler(this.comboVehicleType_SelectedValueChanged);
            // 
            // comboTypeLicensePlate
            // 
            this.comboTypeLicensePlate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTypeLicensePlate.FormattingEnabled = true;
            this.comboTypeLicensePlate.Location = new System.Drawing.Point(292, 7);
            this.comboTypeLicensePlate.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.comboTypeLicensePlate.Name = "comboTypeLicensePlate";
            this.comboTypeLicensePlate.Size = new System.Drawing.Size(121, 21);
            this.comboTypeLicensePlate.TabIndex = 3;
            this.comboTypeLicensePlate.Text = "License Plate Type";
            this.comboTypeLicensePlate.SelectedValueChanged += new System.EventHandler(this.comboTypeLicensePlate_SelectedValueChanged);
            // 
            // txtFilterOwner
            // 
            this.txtFilterOwner.Location = new System.Drawing.Point(3, 7);
            this.txtFilterOwner.Name = "txtFilterOwner";
            this.txtFilterOwner.Size = new System.Drawing.Size(152, 20);
            this.txtFilterOwner.TabIndex = 0;
            this.txtFilterOwner.TextChanged += new System.EventHandler(this.txtFilterOwner_TextChanged);
            // 
            // panelCreateParking
            // 
            this.panelCreateParking.Controls.Add(this.splitContainer1);
            this.panelCreateParking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCreateParking.Location = new System.Drawing.Point(0, 0);
            this.panelCreateParking.Name = "panelCreateParking";
            this.panelCreateParking.Size = new System.Drawing.Size(921, 517);
            this.panelCreateParking.TabIndex = 0;
            this.panelCreateParking.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelParkingFields);
            this.splitContainer1.Size = new System.Drawing.Size(921, 517);
            this.splitContainer1.SplitterDistance = 434;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelParkingFields
            // 
            this.panelParkingFields.Controls.Add(this.radio4);
            this.panelParkingFields.Controls.Add(this.radio2);
            this.panelParkingFields.Controls.Add(this.radio3);
            this.panelParkingFields.Controls.Add(this.radio1);
            this.panelParkingFields.Controls.Add(this.txtName);
            this.panelParkingFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParkingFields.Location = new System.Drawing.Point(0, 0);
            this.panelParkingFields.Name = "panelParkingFields";
            this.panelParkingFields.Size = new System.Drawing.Size(921, 434);
            this.panelParkingFields.TabIndex = 0;
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Location = new System.Drawing.Point(467, 152);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(14, 13);
            this.radio4.TabIndex = 4;
            this.radio4.TabStop = true;
            this.radio4.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(467, 110);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(14, 13);
            this.radio2.TabIndex = 3;
            this.radio2.TabStop = true;
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(303, 152);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(14, 13);
            this.radio3.TabIndex = 2;
            this.radio3.TabStop = true;
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(303, 110);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(14, 13);
            this.radio1.TabIndex = 1;
            this.radio1.TabStop = true;
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(301, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(319, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Tag = "Name";
            // 
            // splitParking
            // 
            this.splitParking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitParking.Location = new System.Drawing.Point(0, 0);
            this.splitParking.Name = "splitParking";
            // 
            // splitParking.Panel1
            // 
            this.splitParking.Panel1.BackColor = System.Drawing.Color.Indigo;
            this.splitParking.Panel1.ForeColor = System.Drawing.Color.White;
            // 
            // splitParking.Panel2
            // 
            this.splitParking.Panel2.Controls.Add(this.panel1);
            this.splitParking.Panel2.Controls.Add(this.panel2);
            this.splitParking.Size = new System.Drawing.Size(921, 517);
            this.splitParking.SplitterDistance = 307;
            this.splitParking.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.splitContainer4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(610, 107);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(15, 15);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.button1);
            this.splitContainer4.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer4.Panel2.Controls.Add(this.comboBox2);
            this.splitContainer4.Panel2.Controls.Add(this.textBox1);
            this.splitContainer4.Size = new System.Drawing.Size(580, 77);
            this.splitContainer4.SplitterDistance = 38;
            this.splitContainer4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parqueos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(479, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear Filter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 7);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Type";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(292, 7);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "License Plate Type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvParqueos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(610, 410);
            this.panel2.TabIndex = 1;
            // 
            // dgvParqueos
            // 
            this.dgvParqueos.AllowUserToAddRows = false;
            this.dgvParqueos.AllowUserToDeleteRows = false;
            this.dgvParqueos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvParqueos.BackgroundColor = System.Drawing.Color.White;
            this.dgvParqueos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParqueos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParqueos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvParqueos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParqueos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvParqueos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParqueos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvParqueos.Location = new System.Drawing.Point(15, 15);
            this.dgvParqueos.MultiSelect = false;
            this.dgvParqueos.Name = "dgvParqueos";
            this.dgvParqueos.ReadOnly = true;
            this.dgvParqueos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvParqueos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParqueos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvParqueos.RowHeadersVisible = false;
            this.dgvParqueos.Size = new System.Drawing.Size(580, 380);
            this.dgvParqueos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 517);
            this.Controls.Add(this.splitParking);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.panelCreateParking);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.panelData.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelCreateParking.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelParkingFields.ResumeLayout(false);
            this.panelParkingFields.PerformLayout();
            this.splitParking.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitParking)).EndInit();
            this.splitParking.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParqueos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panelCreateParking;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelParkingFields;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.TextBox txtFilterOwner;
        private System.Windows.Forms.ComboBox comboVehicleType;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.ComboBox comboTypeLicensePlate;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitParking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvParqueos;
    }
}

