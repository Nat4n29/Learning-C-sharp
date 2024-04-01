namespace BookingApp
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.File = new System.Windows.Forms.TabPage();
            this.Sender = new System.Windows.Forms.GroupBox();
            this.Service = new System.Windows.Forms.GroupBox();
            this.Client = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.HotelTextBox = new System.Windows.Forms.ComboBox();
            this.CityTextBox = new System.Windows.Forms.ComboBox();
            this.Loc = new System.Windows.Forms.Label();
            this.ClientTextBox = new System.Windows.Forms.ComboBox();
            this.InfTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ChdTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AdtTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Names = new System.Windows.Forms.Label();
            this.Inf = new System.Windows.Forms.Label();
            this.Chd = new System.Windows.Forms.Label();
            this.Adt = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDatabaseDataSet = new BookingApp.BookDatabaseDataSet();
            this.paxTableAdapter = new BookingApp.BookDatabaseDataSetTableAdapters.PaxTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fileDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPaxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.File.SuspendLayout();
            this.Service.SuspendLayout();
            this.Client.SuspendLayout();
            this.Find.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1112, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "By Natan";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.File);
            this.tabControl1.Controls.Add(this.Find);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1151, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // File
            // 
            this.File.AccessibleName = "File";
            this.File.Controls.Add(this.Sender);
            this.File.Controls.Add(this.Service);
            this.File.Controls.Add(this.Client);
            this.File.Controls.Add(this.Save);
            this.File.Controls.Add(this.Delete);
            this.File.Controls.Add(this.New);
            this.File.Location = new System.Drawing.Point(4, 22);
            this.File.Name = "File";
            this.File.Padding = new System.Windows.Forms.Padding(3);
            this.File.Size = new System.Drawing.Size(1143, 454);
            this.File.TabIndex = 0;
            this.File.Text = "File";
            this.File.UseVisualStyleBackColor = true;
            // 
            // Sender
            // 
            this.Sender.Location = new System.Drawing.Point(851, 36);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(286, 412);
            this.Sender.TabIndex = 3;
            this.Sender.TabStop = false;
            this.Sender.Text = "Sender";
            // 
            // Service
            // 
            this.Service.Controls.Add(this.dataGridView2);
            this.Service.Location = new System.Drawing.Point(7, 276);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(837, 172);
            this.Service.TabIndex = 2;
            this.Service.TabStop = false;
            this.Service.Text = "Service";
            // 
            // Client
            // 
            this.Client.Controls.Add(this.label6);
            this.Client.Controls.Add(this.label5);
            this.Client.Controls.Add(this.label4);
            this.Client.Controls.Add(this.label3);
            this.Client.Controls.Add(this.label2);
            this.Client.Controls.Add(this.FDateTextBox);
            this.Client.Controls.Add(this.SDateTextBox);
            this.Client.Controls.Add(this.HotelTextBox);
            this.Client.Controls.Add(this.CityTextBox);
            this.Client.Controls.Add(this.Loc);
            this.Client.Controls.Add(this.ClientTextBox);
            this.Client.Controls.Add(this.InfTextBox);
            this.Client.Controls.Add(this.ChdTextBox);
            this.Client.Controls.Add(this.AdtTextBox);
            this.Client.Controls.Add(this.Names);
            this.Client.Controls.Add(this.Inf);
            this.Client.Controls.Add(this.Chd);
            this.Client.Controls.Add(this.Adt);
            this.Client.Controls.Add(this.NameTextBox);
            this.Client.Controls.Add(this.textBox2);
            this.Client.Location = new System.Drawing.Point(6, 36);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(838, 233);
            this.Client.TabIndex = 2;
            this.Client.TabStop = false;
            this.Client.Text = "Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hotel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Finish date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "to";
            // 
            // FDateTextBox
            // 
            this.FDateTextBox.Location = new System.Drawing.Point(497, 206);
            this.FDateTextBox.Mask = "00/00/0000";
            this.FDateTextBox.Name = "FDateTextBox";
            this.FDateTextBox.Size = new System.Drawing.Size(67, 20);
            this.FDateTextBox.TabIndex = 9;
            this.FDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // SDateTextBox
            // 
            this.SDateTextBox.Location = new System.Drawing.Point(404, 207);
            this.SDateTextBox.Mask = "00/00/0000";
            this.SDateTextBox.Name = "SDateTextBox";
            this.SDateTextBox.Size = new System.Drawing.Size(67, 20);
            this.SDateTextBox.TabIndex = 8;
            this.SDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // HotelTextBox
            // 
            this.HotelTextBox.FormattingEnabled = true;
            this.HotelTextBox.Location = new System.Drawing.Point(152, 206);
            this.HotelTextBox.Name = "HotelTextBox";
            this.HotelTextBox.Size = new System.Drawing.Size(246, 21);
            this.HotelTextBox.TabIndex = 7;
            // 
            // CityTextBox
            // 
            this.CityTextBox.FormattingEnabled = true;
            this.CityTextBox.Location = new System.Drawing.Point(6, 206);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(140, 21);
            this.CityTextBox.TabIndex = 6;
            // 
            // Loc
            // 
            this.Loc.AutoSize = true;
            this.Loc.Location = new System.Drawing.Point(112, 16);
            this.Loc.Name = "Loc";
            this.Loc.Size = new System.Drawing.Size(31, 13);
            this.Loc.TabIndex = 6;
            this.Loc.Text = "LOC:";
            // 
            // ClientTextBox
            // 
            this.ClientTextBox.FormattingEnabled = true;
            this.ClientTextBox.Location = new System.Drawing.Point(10, 33);
            this.ClientTextBox.Name = "ClientTextBox";
            this.ClientTextBox.Size = new System.Drawing.Size(92, 21);
            this.ClientTextBox.TabIndex = 0;
            // 
            // InfTextBox
            // 
            this.InfTextBox.Location = new System.Drawing.Point(74, 81);
            this.InfTextBox.Mask = "00000";
            this.InfTextBox.Name = "InfTextBox";
            this.InfTextBox.Size = new System.Drawing.Size(28, 20);
            this.InfTextBox.TabIndex = 4;
            this.InfTextBox.ValidatingType = typeof(int);
            // 
            // ChdTextBox
            // 
            this.ChdTextBox.Location = new System.Drawing.Point(42, 81);
            this.ChdTextBox.Mask = "00000";
            this.ChdTextBox.Name = "ChdTextBox";
            this.ChdTextBox.Size = new System.Drawing.Size(26, 20);
            this.ChdTextBox.TabIndex = 3;
            this.ChdTextBox.ValidatingType = typeof(int);
            // 
            // AdtTextBox
            // 
            this.AdtTextBox.Location = new System.Drawing.Point(10, 81);
            this.AdtTextBox.Mask = "0000000";
            this.AdtTextBox.Name = "AdtTextBox";
            this.AdtTextBox.Size = new System.Drawing.Size(26, 20);
            this.AdtTextBox.TabIndex = 2;
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.Location = new System.Drawing.Point(112, 61);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(38, 13);
            this.Names.TabIndex = 3;
            this.Names.Text = "Name:";
            // 
            // Inf
            // 
            this.Inf.AutoSize = true;
            this.Inf.Location = new System.Drawing.Point(78, 62);
            this.Inf.Name = "Inf";
            this.Inf.Size = new System.Drawing.Size(24, 13);
            this.Inf.TabIndex = 2;
            this.Inf.Text = "INF";
            this.Inf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chd
            // 
            this.Chd.AutoSize = true;
            this.Chd.Location = new System.Drawing.Point(42, 62);
            this.Chd.Name = "Chd";
            this.Chd.Size = new System.Drawing.Size(30, 13);
            this.Chd.TabIndex = 2;
            this.Chd.Text = "CHD";
            this.Chd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Adt
            // 
            this.Adt.AutoSize = true;
            this.Adt.Location = new System.Drawing.Point(7, 62);
            this.Adt.Name = "Adt";
            this.Adt.Size = new System.Drawing.Size(29, 13);
            this.Adt.TabIndex = 2;
            this.Adt.Text = "ADT";
            this.Adt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(112, 81);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(213, 20);
            this.NameTextBox.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(1062, 7);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(87, 6);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(7, 6);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 0;
            this.New.Text = "New";
            // 
            // Find
            // 
            this.Find.AccessibleName = "Find";
            this.Find.Controls.Add(this.dataGridView1);
            this.Find.Location = new System.Drawing.Point(4, 22);
            this.Find.Name = "Find";
            this.Find.Padding = new System.Windows.Forms.Padding(3);
            this.Find.Size = new System.Drawing.Size(1143, 454);
            this.Find.TabIndex = 1;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.finishDateDataGridViewTextBoxColumn,
            this.numPaxDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paxBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1131, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // fileDataGridViewTextBoxColumn
            // 
            this.fileDataGridViewTextBoxColumn.DataPropertyName = "File";
            this.fileDataGridViewTextBoxColumn.HeaderText = "File";
            this.fileDataGridViewTextBoxColumn.Name = "fileDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "Start Date";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // finishDateDataGridViewTextBoxColumn
            // 
            this.finishDateDataGridViewTextBoxColumn.DataPropertyName = "Finish Date";
            this.finishDateDataGridViewTextBoxColumn.HeaderText = "Finish Date";
            this.finishDateDataGridViewTextBoxColumn.Name = "finishDateDataGridViewTextBoxColumn";
            // 
            // numPaxDataGridViewTextBoxColumn
            // 
            this.numPaxDataGridViewTextBoxColumn.DataPropertyName = "Num Pax";
            this.numPaxDataGridViewTextBoxColumn.HeaderText = "Num Pax";
            this.numPaxDataGridViewTextBoxColumn.Name = "numPaxDataGridViewTextBoxColumn";
            // 
            // paxBindingSource
            // 
            this.paxBindingSource.DataMember = "Pax";
            this.paxBindingSource.DataSource = this.bookDatabaseDataSet;
            // 
            // bookDatabaseDataSet
            // 
            this.bookDatabaseDataSet.DataSetName = "BookDatabaseDataSet";
            this.bookDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paxTableAdapter
            // 
            this.paxTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.clientDataGridViewTextBoxColumn1,
            this.startDateDataGridViewTextBoxColumn1,
            this.finishDateDataGridViewTextBoxColumn1,
            this.numPaxDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.paxBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(822, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // fileDataGridViewTextBoxColumn1
            // 
            this.fileDataGridViewTextBoxColumn1.DataPropertyName = "File";
            this.fileDataGridViewTextBoxColumn1.HeaderText = "File";
            this.fileDataGridViewTextBoxColumn1.Name = "fileDataGridViewTextBoxColumn1";
            this.fileDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn1
            // 
            this.clientDataGridViewTextBoxColumn1.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn1.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn1.Name = "clientDataGridViewTextBoxColumn1";
            this.clientDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn1
            // 
            this.startDateDataGridViewTextBoxColumn1.DataPropertyName = "Start Date";
            this.startDateDataGridViewTextBoxColumn1.HeaderText = "Start Date";
            this.startDateDataGridViewTextBoxColumn1.Name = "startDateDataGridViewTextBoxColumn1";
            this.startDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // finishDateDataGridViewTextBoxColumn1
            // 
            this.finishDateDataGridViewTextBoxColumn1.DataPropertyName = "Finish Date";
            this.finishDateDataGridViewTextBoxColumn1.HeaderText = "Finish Date";
            this.finishDateDataGridViewTextBoxColumn1.Name = "finishDateDataGridViewTextBoxColumn1";
            this.finishDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numPaxDataGridViewTextBoxColumn1
            // 
            this.numPaxDataGridViewTextBoxColumn1.DataPropertyName = "Num Pax";
            this.numPaxDataGridViewTextBoxColumn1.HeaderText = "Num Pax";
            this.numPaxDataGridViewTextBoxColumn1.Name = "numPaxDataGridViewTextBoxColumn1";
            this.numPaxDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 517);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Booking App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.File.ResumeLayout(false);
            this.Service.ResumeLayout(false);
            this.Client.ResumeLayout(false);
            this.Client.PerformLayout();
            this.Find.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage File;
        private System.Windows.Forms.TabPage Find;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.GroupBox Sender;
        private System.Windows.Forms.GroupBox Service;
        private System.Windows.Forms.GroupBox Client;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Inf;
        private System.Windows.Forms.Label Chd;
        private System.Windows.Forms.Label Adt;
        private System.Windows.Forms.MaskedTextBox InfTextBox;
        private System.Windows.Forms.MaskedTextBox ChdTextBox;
        private System.Windows.Forms.MaskedTextBox AdtTextBox;
        private System.Windows.Forms.Label Names;
        private System.Windows.Forms.ComboBox ClientTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox FDateTextBox;
        private System.Windows.Forms.MaskedTextBox SDateTextBox;
        private System.Windows.Forms.ComboBox HotelTextBox;
        private System.Windows.Forms.ComboBox CityTextBox;
        private System.Windows.Forms.Label Loc;
        private BookDatabaseDataSet bookDatabaseDataSet;
        private System.Windows.Forms.BindingSource paxBindingSource;
        private BookDatabaseDataSetTableAdapters.PaxTableAdapter paxTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPaxDataGridViewTextBoxColumn1;
    }
}

