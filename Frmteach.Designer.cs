namespace Note_Record_Project
{
    partial class Frmteach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.masked1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txte1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txte3 = new System.Windows.Forms.TextBox();
            this.txte2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDE1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDE2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDE3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVERAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tBLSTDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_StudentDataSet = new Note_Record_Project.DB_StudentDataSet();
            this.tBL_STDTableAdapter = new Note_Record_Project.DB_StudentDataSetTableAdapters.TBL_STDTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.lblaverage = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_StudentDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtsurname);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.masked1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Add";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(131, 141);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(157, 29);
            this.txtsurname.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(131, 95);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(157, 29);
            this.txtname.TabIndex = 4;
            // 
            // masked1
            // 
            this.masked1.Location = new System.Drawing.Point(131, 48);
            this.masked1.Name = "masked1";
            this.masked1.Size = new System.Drawing.Size(157, 29);
            this.masked1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txte1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txte3);
            this.groupBox2.Controls.Add(this.txte2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(355, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 263);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exam Note";
            // 
            // txte1
            // 
            this.txte1.Location = new System.Drawing.Point(135, 50);
            this.txte1.Name = "txte1";
            this.txte1.Size = new System.Drawing.Size(157, 29);
            this.txte1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 57);
            this.button2.TabIndex = 6;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txte3
            // 
            this.txte3.Location = new System.Drawing.Point(135, 141);
            this.txte3.Name = "txte3";
            this.txte3.Size = new System.Drawing.Size(157, 29);
            this.txte3.TabIndex = 5;
            // 
            // txte2
            // 
            this.txte2.Location = new System.Drawing.Point(135, 97);
            this.txte2.Name = "txte2";
            this.txte2.Size = new System.Drawing.Size(157, 29);
            this.txte2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "EXAM 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "EXAM 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "EXAM 1:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(12, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1003, 248);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exam Notes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTDIDDataGridViewTextBoxColumn,
            this.sTDNUMBERDataGridViewTextBoxColumn,
            this.sTDNAMEDataGridViewTextBoxColumn,
            this.sTDSURNAMEDataGridViewTextBoxColumn,
            this.sTDE1DataGridViewTextBoxColumn,
            this.sTDE2DataGridViewTextBoxColumn,
            this.sTDE3DataGridViewTextBoxColumn,
            this.aVERAGEDataGridViewTextBoxColumn,
            this.eVENTDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLSTDBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(997, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sTDIDDataGridViewTextBoxColumn
            // 
            this.sTDIDDataGridViewTextBoxColumn.DataPropertyName = "STDID";
            this.sTDIDDataGridViewTextBoxColumn.HeaderText = "STDID";
            this.sTDIDDataGridViewTextBoxColumn.Name = "sTDIDDataGridViewTextBoxColumn";
            this.sTDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTDNUMBERDataGridViewTextBoxColumn
            // 
            this.sTDNUMBERDataGridViewTextBoxColumn.DataPropertyName = "STDNUMBER";
            this.sTDNUMBERDataGridViewTextBoxColumn.HeaderText = "STDNUMBER";
            this.sTDNUMBERDataGridViewTextBoxColumn.Name = "sTDNUMBERDataGridViewTextBoxColumn";
            // 
            // sTDNAMEDataGridViewTextBoxColumn
            // 
            this.sTDNAMEDataGridViewTextBoxColumn.DataPropertyName = "STDNAME";
            this.sTDNAMEDataGridViewTextBoxColumn.HeaderText = "STDNAME";
            this.sTDNAMEDataGridViewTextBoxColumn.Name = "sTDNAMEDataGridViewTextBoxColumn";
            // 
            // sTDSURNAMEDataGridViewTextBoxColumn
            // 
            this.sTDSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "STDSURNAME";
            this.sTDSURNAMEDataGridViewTextBoxColumn.HeaderText = "STDSURNAME";
            this.sTDSURNAMEDataGridViewTextBoxColumn.Name = "sTDSURNAMEDataGridViewTextBoxColumn";
            // 
            // sTDE1DataGridViewTextBoxColumn
            // 
            this.sTDE1DataGridViewTextBoxColumn.DataPropertyName = "STDE1";
            this.sTDE1DataGridViewTextBoxColumn.HeaderText = "STDE1";
            this.sTDE1DataGridViewTextBoxColumn.Name = "sTDE1DataGridViewTextBoxColumn";
            // 
            // sTDE2DataGridViewTextBoxColumn
            // 
            this.sTDE2DataGridViewTextBoxColumn.DataPropertyName = "STDE2";
            this.sTDE2DataGridViewTextBoxColumn.HeaderText = "STDE2";
            this.sTDE2DataGridViewTextBoxColumn.Name = "sTDE2DataGridViewTextBoxColumn";
            // 
            // sTDE3DataGridViewTextBoxColumn
            // 
            this.sTDE3DataGridViewTextBoxColumn.DataPropertyName = "STDE3";
            this.sTDE3DataGridViewTextBoxColumn.HeaderText = "STDE3";
            this.sTDE3DataGridViewTextBoxColumn.Name = "sTDE3DataGridViewTextBoxColumn";
            // 
            // aVERAGEDataGridViewTextBoxColumn
            // 
            this.aVERAGEDataGridViewTextBoxColumn.DataPropertyName = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.HeaderText = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.Name = "aVERAGEDataGridViewTextBoxColumn";
            // 
            // eVENTDataGridViewCheckBoxColumn
            // 
            this.eVENTDataGridViewCheckBoxColumn.DataPropertyName = "EVENT";
            this.eVENTDataGridViewCheckBoxColumn.HeaderText = "EVENT";
            this.eVENTDataGridViewCheckBoxColumn.Name = "eVENTDataGridViewCheckBoxColumn";
            // 
            // tBLSTDBindingSource
            // 
            this.tBLSTDBindingSource.DataMember = "TBL_STD";
            this.tBLSTDBindingSource.DataSource = this.dB_StudentDataSet;
            // 
            // dB_StudentDataSet
            // 
            this.dB_StudentDataSet.DataSetName = "DB_StudentDataSet";
            this.dB_StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_STDTableAdapter
            // 
            this.tBL_STDTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(26, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Student Avarage:";
            // 
            // lblaverage
            // 
            this.lblaverage.AutoSize = true;
            this.lblaverage.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblaverage.Location = new System.Drawing.Point(247, 57);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(34, 23);
            this.lblaverage.TabIndex = 7;
            this.lblaverage.Text = "00";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(45, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 127);
            this.button3.TabIndex = 10;
            this.button3.Text = "STUDENTS STATISTICA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.lblaverage);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(692, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 263);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exam Note";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Frmteach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1029, 533);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frmteach";
            this.Text = "Frmteach";
            this.Load += new System.EventHandler(this.Frmteach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_StudentDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.MaskedTextBox masked1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txte3;
        private System.Windows.Forms.TextBox txte2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_StudentDataSet dB_StudentDataSet;
        private System.Windows.Forms.BindingSource tBLSTDBindingSource;
        private DB_StudentDataSetTableAdapters.TBL_STDTableAdapter tBL_STDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDE1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDE2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDE3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVERAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eVENTDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox txte1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblaverage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}