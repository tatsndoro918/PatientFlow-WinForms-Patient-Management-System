namespace WFAPatientTracker
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpPatientInfo = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cmbStatus = new ComboBox();
            cmbPriority = new ComboBox();
            txtCondition = new TextBox();
            txtAge = new TextBox();
            txtPatientName = new TextBox();
            lblPriority = new Label();
            lblStatus = new Label();
            lblCondition = new Label();
            lblAge = new Label();
            lblPatientName = new Label();
            grpPatientRecords = new GroupBox();
            dgvPatients = new DataGridView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblTitle = new Label();
            grpPatientInfo.SuspendLayout();
            grpPatientRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // grpPatientInfo
            // 
            grpPatientInfo.Controls.Add(btnClear);
            grpPatientInfo.Controls.Add(btnDelete);
            grpPatientInfo.Controls.Add(btnUpdate);
            grpPatientInfo.Controls.Add(btnAdd);
            grpPatientInfo.Controls.Add(cmbStatus);
            grpPatientInfo.Controls.Add(cmbPriority);
            grpPatientInfo.Controls.Add(txtCondition);
            grpPatientInfo.Controls.Add(txtAge);
            grpPatientInfo.Controls.Add(txtPatientName);
            grpPatientInfo.Controls.Add(lblPriority);
            grpPatientInfo.Controls.Add(lblStatus);
            grpPatientInfo.Controls.Add(lblCondition);
            grpPatientInfo.Controls.Add(lblAge);
            grpPatientInfo.Controls.Add(lblPatientName);
            grpPatientInfo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPatientInfo.Location = new Point(24, 66);
            grpPatientInfo.Name = "grpPatientInfo";
            grpPatientInfo.Size = new Size(409, 453);
            grpPatientInfo.TabIndex = 0;
            grpPatientInfo.TabStop = false;
            grpPatientInfo.Text = "Patient Information";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.AppWorkspace;
            btnClear.Location = new Point(234, 290);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 38);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(26, 290);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 38);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Location = new Point(234, 222);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(138, 38);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(26, 222);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 38);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(124, 155);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 25);
            cmbStatus.TabIndex = 9;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(124, 121);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(121, 25);
            cmbPriority.TabIndex = 8;
            // 
            // txtCondition
            // 
            txtCondition.Location = new Point(124, 87);
            txtCondition.Name = "txtCondition";
            txtCondition.Size = new Size(268, 25);
            txtCondition.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(124, 60);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(268, 25);
            txtAge.TabIndex = 6;
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(124, 33);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(268, 25);
            txtPatientName.TabIndex = 5;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(13, 124);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(55, 17);
            lblPriority.TabIndex = 4;
            lblPriority.Text = "Priority:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(13, 158);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 17);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status:";
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Location = new Point(13, 95);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(70, 17);
            lblCondition.TabIndex = 2;
            lblCondition.Text = "Condition:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(13, 68);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(39, 17);
            lblAge.TabIndex = 1;
            lblAge.Text = "Age: ";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(13, 41);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(98, 17);
            lblPatientName.TabIndex = 0;
            lblPatientName.Text = "Patient Name: ";
            // 
            // grpPatientRecords
            // 
            grpPatientRecords.Controls.Add(dgvPatients);
            grpPatientRecords.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPatientRecords.Location = new Point(439, 66);
            grpPatientRecords.Name = "grpPatientRecords";
            grpPatientRecords.Size = new Size(717, 453);
            grpPatientRecords.TabIndex = 1;
            grpPatientRecords.TabStop = false;
            grpPatientRecords.Text = "Patient Records";
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.BackgroundColor = SystemColors.ScrollBar;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new Point(9, 33);
            dgvPatients.MultiSelect = false;
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersVisible = false;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(702, 414);
            dgvPatients.TabIndex = 2;
            dgvPatients.CellClick += dgvPatients_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(913, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(243, 25);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(803, 40);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(104, 17);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search Patients:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(37, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(177, 30);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "🏥 PatientFlow  ";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1188, 563);
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Controls.Add(grpPatientRecords);
            Controls.Add(lblSearch);
            Controls.Add(grpPatientInfo);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientFlow";
            Load += frmMain_Load;
            grpPatientInfo.ResumeLayout(false);
            grpPatientInfo.PerformLayout();
            grpPatientRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpPatientInfo;
        private Label lblPatientName;
        private GroupBox grpPatientRecords;
        private Label lblPriority;
        private Label lblStatus;
        private Label lblCondition;
        private Label lblAge;
        private TextBox txtCondition;
        private TextBox txtAge;
        private TextBox txtPatientName;
        private ComboBox cmbStatus;
        private ComboBox cmbPriority;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnClear;
        private DataGridView dgvPatients;
        private TextBox txtSearch;
        private Label lblSearch;
        private Label lblTitle;
    }
}
