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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelData = new System.Windows.Forms.Panel();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.panelCreateParking = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelParkingFields = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.txtFilterOwner = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.panelCreateParking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelParkingFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(610, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dataGridView1);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelData.Location = new System.Drawing.Point(0, 107);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(610, 410);
            this.panelData.TabIndex = 1;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.panelFilters);
            this.splitMain.Panel2.Controls.Add(this.panelData);
            this.splitMain.Size = new System.Drawing.Size(921, 517);
            this.splitMain.SplitterDistance = 307;
            this.splitMain.TabIndex = 2;
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.White;
            this.panelFilters.Controls.Add(this.txtFilterOwner);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(610, 100);
            this.panelFilters.TabIndex = 2;
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
            this.panelCreateParking.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCreateParking_Paint);
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(301, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(319, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Tag = "Name";
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
            // txtFilterOwner
            // 
            this.txtFilterOwner.Location = new System.Drawing.Point(3, 66);
            this.txtFilterOwner.Name = "txtFilterOwner";
            this.txtFilterOwner.Size = new System.Drawing.Size(152, 20);
            this.txtFilterOwner.TabIndex = 0;
            this.txtFilterOwner.TextChanged += new System.EventHandler(this.txtFilterOwner_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 517);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.panelCreateParking);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelData.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.panelCreateParking.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelParkingFields.ResumeLayout(false);
            this.panelParkingFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Panel panelCreateParking;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelParkingFields;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.TextBox txtFilterOwner;
    }
}

