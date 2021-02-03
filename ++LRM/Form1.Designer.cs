namespace __LRM
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
            this.tvRoomInfor = new System.Windows.Forms.TreeView();
            this.dgvComputer = new System.Windows.Forms.DataGridView();
            this.computerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hardDiskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vGADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lRMDataSet = new @__LRM.LRMDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.computerTableAdapter = new @__LRM.LRMDataSetTableAdapters.ComputerTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtMornitor = new System.Windows.Forms.TextBox();
            this.txtVGA = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtHardDisk = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.txtComputerID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lRMDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvRoomInfor
            // 
            this.tvRoomInfor.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tvRoomInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvRoomInfor.FullRowSelect = true;
            this.tvRoomInfor.Location = new System.Drawing.Point(12, 46);
            this.tvRoomInfor.Name = "tvRoomInfor";
            this.tvRoomInfor.Size = new System.Drawing.Size(192, 465);
            this.tvRoomInfor.TabIndex = 0;
            this.tvRoomInfor.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRoomInfor_AfterSelect);
            // 
            // dgvComputer
            // 
            this.dgvComputer.AutoGenerateColumns = false;
            this.dgvComputer.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvComputer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComputer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.computerIDDataGridViewTextBoxColumn,
            this.cPUDataGridViewTextBoxColumn,
            this.hardDiskDataGridViewTextBoxColumn,
            this.rAMDataGridViewTextBoxColumn,
            this.vGADataGridViewTextBoxColumn,
            this.monitorDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.roomIDDataGridViewTextBoxColumn});
            this.dgvComputer.DataSource = this.computerBindingSource;
            this.dgvComputer.Location = new System.Drawing.Point(210, 46);
            this.dgvComputer.Name = "dgvComputer";
            this.dgvComputer.Size = new System.Drawing.Size(926, 201);
            this.dgvComputer.TabIndex = 1;
            this.dgvComputer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComputer_CellContentClick);
            // 
            // computerIDDataGridViewTextBoxColumn
            // 
            this.computerIDDataGridViewTextBoxColumn.DataPropertyName = "Computer_ID";
            this.computerIDDataGridViewTextBoxColumn.HeaderText = "Computer_ID";
            this.computerIDDataGridViewTextBoxColumn.Name = "computerIDDataGridViewTextBoxColumn";
            this.computerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPUDataGridViewTextBoxColumn
            // 
            this.cPUDataGridViewTextBoxColumn.DataPropertyName = "CPU";
            this.cPUDataGridViewTextBoxColumn.HeaderText = "CPU";
            this.cPUDataGridViewTextBoxColumn.Name = "cPUDataGridViewTextBoxColumn";
            // 
            // hardDiskDataGridViewTextBoxColumn
            // 
            this.hardDiskDataGridViewTextBoxColumn.DataPropertyName = "Hard_Disk";
            this.hardDiskDataGridViewTextBoxColumn.HeaderText = "Hard_Disk";
            this.hardDiskDataGridViewTextBoxColumn.Name = "hardDiskDataGridViewTextBoxColumn";
            // 
            // rAMDataGridViewTextBoxColumn
            // 
            this.rAMDataGridViewTextBoxColumn.DataPropertyName = "RAM";
            this.rAMDataGridViewTextBoxColumn.HeaderText = "RAM";
            this.rAMDataGridViewTextBoxColumn.Name = "rAMDataGridViewTextBoxColumn";
            // 
            // vGADataGridViewTextBoxColumn
            // 
            this.vGADataGridViewTextBoxColumn.DataPropertyName = "VGA";
            this.vGADataGridViewTextBoxColumn.HeaderText = "VGA";
            this.vGADataGridViewTextBoxColumn.Name = "vGADataGridViewTextBoxColumn";
            // 
            // monitorDataGridViewTextBoxColumn
            // 
            this.monitorDataGridViewTextBoxColumn.DataPropertyName = "Monitor";
            this.monitorDataGridViewTextBoxColumn.HeaderText = "Monitor";
            this.monitorDataGridViewTextBoxColumn.Name = "monitorDataGridViewTextBoxColumn";
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "Room_Name";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "Room_Name";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            // 
            // computerBindingSource
            // 
            this.computerBindingSource.DataMember = "Computer";
            this.computerBindingSource.DataSource = this.lRMDataSet;
            // 
            // lRMDataSet
            // 
            this.lRMDataSet.DataSetName = "LRMDataSet";
            this.lRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lab Room Management Systems";
            // 
            // computerTableAdapter
            // 
            this.computerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThemSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtRoomID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtRoomName);
            this.groupBox1.Controls.Add(this.txtMornitor);
            this.groupBox1.Controls.Add(this.txtVGA);
            this.groupBox1.Controls.Add(this.txtRAM);
            this.groupBox1.Controls.Add(this.txtHardDisk);
            this.groupBox1.Controls.Add(this.txtCPU);
            this.groupBox1.Controls.Add(this.txtComputerID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(201, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 258);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details Information";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(345, 143);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 31);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(345, 102);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 31);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemSua
            // 
            this.btnThemSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSua.ForeColor = System.Drawing.Color.Black;
            this.btnThemSua.Location = new System.Drawing.Point(345, 59);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(95, 31);
            this.btnThemSua.TabIndex = 16;
            this.btnThemSua.Text = "Lưu Mới";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(345, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 31);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(101, 214);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(226, 22);
            this.txtRoomID.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(27, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Room_ID:";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(101, 186);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(226, 22);
            this.txtRoomName.TabIndex = 13;
            // 
            // txtMornitor
            // 
            this.txtMornitor.Location = new System.Drawing.Point(101, 158);
            this.txtMornitor.Name = "txtMornitor";
            this.txtMornitor.Size = new System.Drawing.Size(226, 22);
            this.txtMornitor.TabIndex = 12;
            // 
            // txtVGA
            // 
            this.txtVGA.Location = new System.Drawing.Point(101, 130);
            this.txtVGA.Name = "txtVGA";
            this.txtVGA.Size = new System.Drawing.Size(226, 22);
            this.txtVGA.TabIndex = 11;
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(101, 102);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(226, 22);
            this.txtRAM.TabIndex = 10;
            // 
            // txtHardDisk
            // 
            this.txtHardDisk.Location = new System.Drawing.Point(101, 74);
            this.txtHardDisk.Name = "txtHardDisk";
            this.txtHardDisk.Size = new System.Drawing.Size(226, 22);
            this.txtHardDisk.TabIndex = 9;
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(101, 46);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(226, 22);
            this.txtCPU.TabIndex = 8;
            // 
            // txtComputerID
            // 
            this.txtComputerID.Location = new System.Drawing.Point(101, 18);
            this.txtComputerID.Name = "txtComputerID";
            this.txtComputerID.Size = new System.Drawing.Size(226, 22);
            this.txtComputerID.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Room_Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(36, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mornitor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(56, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "VGA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(54, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "RAM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hard_Disk:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(56, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "CPU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Computer_ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(172, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = ".Develop by Anthony Luận";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 547);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvComputer);
            this.Controls.Add(this.tvRoomInfor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lRMDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvRoomInfor;
        private System.Windows.Forms.DataGridView dgvComputer;
        private System.Windows.Forms.Label label1;
        private LRMDataSet lRMDataSet;
        private System.Windows.Forms.BindingSource computerBindingSource;
        private LRMDataSetTableAdapters.ComputerTableAdapter computerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardDiskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vGADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtMornitor;
        private System.Windows.Forms.TextBox txtVGA;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtHardDisk;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.TextBox txtComputerID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label10;
    }
}

