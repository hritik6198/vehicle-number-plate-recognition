namespace Car_NumerPlate
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detectedPlatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carNumberPlateDBDataSet = new Car_NumerPlate.CarNumberPlateDBDataSet();
            this.detectedPlatesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carNumberPlateDBDataSet1 = new Car_NumerPlate.CarNumberPlateDBDataSet1();
            this.detectedPlatesTableAdapter = new Car_NumerPlate.CarNumberPlateDBDataSetTableAdapters.DetectedPlatesTableAdapter();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.detectedPlatesTableAdapter1 = new Car_NumerPlate.CarNumberPlateDBDataSet1TableAdapters.DetectedPlatesTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.carNumberPlateDBDataSet2 = new Car_NumerPlate.CarNumberPlateDBDataSet2();
            this.detectedPlatesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.detectedPlatesTableAdapter2 = new Car_NumerPlate.CarNumberPlateDBDataSet2TableAdapters.DetectedPlatesTableAdapter();
            this.carNumberPlateDBDataSet3 = new Car_NumerPlate.CarNumberPlateDBDataSet3();
            this.detectedPlatesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.detectedPlatesTableAdapter3 = new Car_NumerPlate.CarNumberPlateDBDataSet3TableAdapters.DetectedPlatesTableAdapter();
            this.plateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detectionTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectedPlatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberPlateDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectedPlatesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberPlateDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberPlateDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectedPlatesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberPlateDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectedPlatesBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1979, 1227);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(2004, 101);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(535, 358);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1409, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse Image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1409, 282);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(849, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "btnBrowseFolder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1187, 362);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(70, 36);
            this.listBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(354, 353);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plateNumberDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.FileName,
            this.detectionTimeDataGridViewTextBoxColumn,
            this.dataGridViewImageColumn1});
            this.dataGridView1.DataSource = this.detectedPlatesBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(51, 445);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(1206, 310);
            this.dataGridView1.TabIndex = 7;
            // 
            // detectedPlatesBindingSource
            // 
            this.detectedPlatesBindingSource.DataMember = "DetectedPlates";
            this.detectedPlatesBindingSource.DataSource = this.carNumberPlateDBDataSet;
            // 
            // carNumberPlateDBDataSet
            // 
            this.carNumberPlateDBDataSet.DataSetName = "CarNumberPlateDBDataSet";
            this.carNumberPlateDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detectedPlatesBindingSource1
            // 
            this.detectedPlatesBindingSource1.DataMember = "DetectedPlates";
            this.detectedPlatesBindingSource1.DataSource = this.carNumberPlateDBDataSet1;
            // 
            // carNumberPlateDBDataSet1
            // 
            this.carNumberPlateDBDataSet1.DataSetName = "CarNumberPlateDBDataSet1";
            this.carNumberPlateDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detectedPlatesTableAdapter
            // 
            this.detectedPlatesTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1347, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(233, 90);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // detectedPlatesTableAdapter1
            // 
            this.detectedPlatesTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1028, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // carNumberPlateDBDataSet2
            // 
            this.carNumberPlateDBDataSet2.DataSetName = "CarNumberPlateDBDataSet2";
            this.carNumberPlateDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detectedPlatesBindingSource2
            // 
            this.detectedPlatesBindingSource2.DataMember = "DetectedPlates";
            this.detectedPlatesBindingSource2.DataSource = this.carNumberPlateDBDataSet2;
            // 
            // detectedPlatesTableAdapter2
            // 
            this.detectedPlatesTableAdapter2.ClearBeforeFill = true;
            // 
            // carNumberPlateDBDataSet3
            // 
            this.carNumberPlateDBDataSet3.DataSetName = "CarNumberPlateDBDataSet3";
            this.carNumberPlateDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detectedPlatesBindingSource3
            // 
            this.detectedPlatesBindingSource3.DataMember = "DetectedPlates";
            this.detectedPlatesBindingSource3.DataSource = this.carNumberPlateDBDataSet3;
            // 
            // detectedPlatesTableAdapter3
            // 
            this.detectedPlatesTableAdapter3.ClearBeforeFill = true;
            // 
            // plateNumberDataGridViewTextBoxColumn
            // 
            this.plateNumberDataGridViewTextBoxColumn.DataPropertyName = "PlateNumber";
            this.plateNumberDataGridViewTextBoxColumn.FillWeight = 311.0597F;
            this.plateNumberDataGridViewTextBoxColumn.HeaderText = "PlateNumber";
            this.plateNumberDataGridViewTextBoxColumn.Name = "plateNumberDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 136.8732F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.FillWeight = 150.6207F;
            this.FileName.HeaderText = "FileName";
            this.FileName.Name = "FileName";
            // 
            // detectionTimeDataGridViewTextBoxColumn
            // 
            this.detectionTimeDataGridViewTextBoxColumn.DataPropertyName = "DetectionTime";
            this.detectionTimeDataGridViewTextBoxColumn.FillWeight = 493.4014F;
            this.detectionTimeDataGridViewTextBoxColumn.HeaderText = "DetectionTime";
            this.detectionTimeDataGridViewTextBoxColumn.Name = "detectionTimeDataGridViewTextBoxColumn";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "PlateImage";
            this.dataGridViewImageColumn1.FillWeight = 852.0467F;
            this.dataGridViewImageColumn1.HeaderText = "PlateImage";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 875);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectedPlatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberPlateDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectedPlatesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberPlateDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberPlateDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectedPlatesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberPlateDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectedPlatesBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CarNumberPlateDBDataSet carNumberPlateDBDataSet;
        private System.Windows.Forms.BindingSource detectedPlatesBindingSource;
        private CarNumberPlateDBDataSetTableAdapters.DetectedPlatesTableAdapter detectedPlatesTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CarNumberPlateDBDataSet1 carNumberPlateDBDataSet1;
        private System.Windows.Forms.BindingSource detectedPlatesBindingSource1;
        private CarNumberPlateDBDataSet1TableAdapters.DetectedPlatesTableAdapter detectedPlatesTableAdapter1;
        private System.Windows.Forms.Button button3;
        private CarNumberPlateDBDataSet2 carNumberPlateDBDataSet2;
        private System.Windows.Forms.BindingSource detectedPlatesBindingSource2;
        private CarNumberPlateDBDataSet2TableAdapters.DetectedPlatesTableAdapter detectedPlatesTableAdapter2;
        private CarNumberPlateDBDataSet3 carNumberPlateDBDataSet3;
        private System.Windows.Forms.BindingSource detectedPlatesBindingSource3;
        private CarNumberPlateDBDataSet3TableAdapters.DetectedPlatesTableAdapter detectedPlatesTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn detectionTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}

