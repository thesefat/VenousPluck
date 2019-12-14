namespace VenousPluck.UI
{
    partial class DonorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorForm));
            this.DonorDeleteButton = new System.Windows.Forms.Button();
            this.DonorCreateButton = new System.Windows.Forms.Button();
            this.DonorImageChooseButton = new System.Windows.Forms.Button();
            this.donorPictureBox = new System.Windows.Forms.PictureBox();
            this.donorUserNameTextBox = new System.Windows.Forms.TextBox();
            this.donorAddressTextBox = new System.Windows.Forms.TextBox();
            this.donorBloodGroupTextBox = new System.Windows.Forms.TextBox();
            this.donorPasswordTextBox = new System.Windows.Forms.TextBox();
            this.donorEmailTextBox = new System.Windows.Forms.TextBox();
            this.donorContactNoTextBox = new System.Windows.Forms.TextBox();
            this.donorLastNameTextBox = new System.Windows.Forms.TextBox();
            this.donorSearchTextBox = new System.Windows.Forms.TextBox();
            this.donorFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.donorDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorsViewDataSet = new VenousPluck.DonorsViewDataSet();
            this.donorsTableAdapter = new VenousPluck.DonorsViewDataSetTableAdapters.DonorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.donorPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsViewDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DonorDeleteButton
            // 
            this.DonorDeleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorDeleteButton.Location = new System.Drawing.Point(181, 714);
            this.DonorDeleteButton.Name = "DonorDeleteButton";
            this.DonorDeleteButton.Size = new System.Drawing.Size(110, 53);
            this.DonorDeleteButton.TabIndex = 28;
            this.DonorDeleteButton.Text = "Delete";
            this.DonorDeleteButton.UseVisualStyleBackColor = true;
            this.DonorDeleteButton.Click += new System.EventHandler(this.DonorDeleteButton_Click);
            // 
            // DonorCreateButton
            // 
            this.DonorCreateButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorCreateButton.Location = new System.Drawing.Point(332, 714);
            this.DonorCreateButton.Name = "DonorCreateButton";
            this.DonorCreateButton.Size = new System.Drawing.Size(120, 53);
            this.DonorCreateButton.TabIndex = 27;
            this.DonorCreateButton.Text = "Create";
            this.DonorCreateButton.UseVisualStyleBackColor = true;
            this.DonorCreateButton.Click += new System.EventHandler(this.DonorCreateButton_Click);
            // 
            // DonorImageChooseButton
            // 
            this.DonorImageChooseButton.Font = new System.Drawing.Font("Agency FB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorImageChooseButton.Location = new System.Drawing.Point(387, 63);
            this.DonorImageChooseButton.Name = "DonorImageChooseButton";
            this.DonorImageChooseButton.Size = new System.Drawing.Size(68, 36);
            this.DonorImageChooseButton.TabIndex = 26;
            this.DonorImageChooseButton.Text = "Upload";
            this.DonorImageChooseButton.UseVisualStyleBackColor = true;
            this.DonorImageChooseButton.Click += new System.EventHandler(this.DonorImageChooseButton_Click);
            // 
            // donorPictureBox
            // 
            this.donorPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("donorPictureBox.Image")));
            this.donorPictureBox.Location = new System.Drawing.Point(181, 56);
            this.donorPictureBox.Name = "donorPictureBox";
            this.donorPictureBox.Size = new System.Drawing.Size(200, 183);
            this.donorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.donorPictureBox.TabIndex = 25;
            this.donorPictureBox.TabStop = false;
            // 
            // donorUserNameTextBox
            // 
            this.donorUserNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorUserNameTextBox.Location = new System.Drawing.Point(181, 550);
            this.donorUserNameTextBox.Name = "donorUserNameTextBox";
            this.donorUserNameTextBox.Size = new System.Drawing.Size(271, 39);
            this.donorUserNameTextBox.TabIndex = 23;
            // 
            // donorAddressTextBox
            // 
            this.donorAddressTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorAddressTextBox.Location = new System.Drawing.Point(181, 489);
            this.donorAddressTextBox.Name = "donorAddressTextBox";
            this.donorAddressTextBox.Size = new System.Drawing.Size(271, 39);
            this.donorAddressTextBox.TabIndex = 22;
            // 
            // donorBloodGroupTextBox
            // 
            this.donorBloodGroupTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorBloodGroupTextBox.Location = new System.Drawing.Point(181, 669);
            this.donorBloodGroupTextBox.Name = "donorBloodGroupTextBox";
            this.donorBloodGroupTextBox.Size = new System.Drawing.Size(271, 39);
            this.donorBloodGroupTextBox.TabIndex = 21;
            // 
            // donorPasswordTextBox
            // 
            this.donorPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorPasswordTextBox.Location = new System.Drawing.Point(181, 608);
            this.donorPasswordTextBox.Name = "donorPasswordTextBox";
            this.donorPasswordTextBox.PasswordChar = '*';
            this.donorPasswordTextBox.Size = new System.Drawing.Size(271, 39);
            this.donorPasswordTextBox.TabIndex = 20;
            // 
            // donorEmailTextBox
            // 
            this.donorEmailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorEmailTextBox.Location = new System.Drawing.Point(181, 364);
            this.donorEmailTextBox.Name = "donorEmailTextBox";
            this.donorEmailTextBox.Size = new System.Drawing.Size(271, 39);
            this.donorEmailTextBox.TabIndex = 19;
            // 
            // donorContactNoTextBox
            // 
            this.donorContactNoTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorContactNoTextBox.Location = new System.Drawing.Point(181, 431);
            this.donorContactNoTextBox.Name = "donorContactNoTextBox";
            this.donorContactNoTextBox.Size = new System.Drawing.Size(271, 39);
            this.donorContactNoTextBox.TabIndex = 18;
            // 
            // donorLastNameTextBox
            // 
            this.donorLastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorLastNameTextBox.Location = new System.Drawing.Point(181, 303);
            this.donorLastNameTextBox.Name = "donorLastNameTextBox";
            this.donorLastNameTextBox.Size = new System.Drawing.Size(271, 39);
            this.donorLastNameTextBox.TabIndex = 24;
            // 
            // donorSearchTextBox
            // 
            this.donorSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorSearchTextBox.Location = new System.Drawing.Point(957, 128);
            this.donorSearchTextBox.Name = "donorSearchTextBox";
            this.donorSearchTextBox.Size = new System.Drawing.Size(271, 39);
            this.donorSearchTextBox.TabIndex = 17;
            // 
            // donorFirstNameTextBox
            // 
            this.donorFirstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorFirstNameTextBox.Location = new System.Drawing.Point(181, 245);
            this.donorFirstNameTextBox.Name = "donorFirstNameTextBox";
            this.donorFirstNameTextBox.Size = new System.Drawing.Size(271, 39);
            this.donorFirstNameTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(678, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donors Manager";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 550);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "User Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 669);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "BG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 608);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(835, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Contact No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Profile Picture";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1657, 57);
            this.panel1.TabIndex = 5;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Teal;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1591, 6);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(50, 48);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 7;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.PictureBoxClose_Click);
            // 
            // donorDataGridView
            // 
            this.donorDataGridView.AllowUserToResizeColumns = false;
            this.donorDataGridView.AllowUserToResizeRows = false;
            this.donorDataGridView.AutoGenerateColumns = false;
            this.donorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.donorDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.donorDataGridView.ColumnHeadersHeight = 36;
            this.donorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.addedDateDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.donorDataGridView.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.donorDataGridView.DataSource = this.donorsBindingSource;
            this.donorDataGridView.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.donorDataGridView.Location = new System.Drawing.Point(513, 245);
            this.donorDataGridView.Name = "donorDataGridView";
            this.donorDataGridView.RowHeadersWidth = 62;
            this.donorDataGridView.RowTemplate.Height = 28;
            this.donorDataGridView.Size = new System.Drawing.Size(1119, 517);
            this.donorDataGridView.TabIndex = 29;
            this.donorDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DonorDataGridView_RowHeaderMouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // addedDateDataGridViewTextBoxColumn
            // 
            this.addedDateDataGridViewTextBoxColumn.DataPropertyName = "AddedDate";
            this.addedDateDataGridViewTextBoxColumn.HeaderText = "AddedDate";
            this.addedDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addedDateDataGridViewTextBoxColumn.Name = "addedDateDataGridViewTextBoxColumn";
            this.addedDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // donorsBindingSource
            // 
            this.donorsBindingSource.DataMember = "Donors";
            this.donorsBindingSource.DataSource = this.donorsViewDataSet;
            // 
            // donorsViewDataSet
            // 
            this.donorsViewDataSet.DataSetName = "DonorsViewDataSet";
            this.donorsViewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorsTableAdapter
            // 
            this.donorsTableAdapter.ClearBeforeFill = true;
            // 
            // DonorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1657, 774);
            this.Controls.Add(this.donorDataGridView);
            this.Controls.Add(this.DonorDeleteButton);
            this.Controls.Add(this.DonorCreateButton);
            this.Controls.Add(this.DonorImageChooseButton);
            this.Controls.Add(this.donorPictureBox);
            this.Controls.Add(this.donorUserNameTextBox);
            this.Controls.Add(this.donorAddressTextBox);
            this.Controls.Add(this.donorBloodGroupTextBox);
            this.Controls.Add(this.donorPasswordTextBox);
            this.Controls.Add(this.donorEmailTextBox);
            this.Controls.Add(this.donorContactNoTextBox);
            this.Controls.Add(this.donorLastNameTextBox);
            this.Controls.Add(this.donorSearchTextBox);
            this.Controls.Add(this.donorFirstNameTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonorForm";
            this.Text = "DonorForm";
            this.Load += new System.EventHandler(this.DonorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.donorPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsViewDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DonorDeleteButton;
        private System.Windows.Forms.Button DonorCreateButton;
        private System.Windows.Forms.Button DonorImageChooseButton;
        private System.Windows.Forms.PictureBox donorPictureBox;
        private System.Windows.Forms.TextBox donorUserNameTextBox;
        private System.Windows.Forms.TextBox donorAddressTextBox;
        private System.Windows.Forms.TextBox donorBloodGroupTextBox;
        private System.Windows.Forms.TextBox donorPasswordTextBox;
        private System.Windows.Forms.TextBox donorEmailTextBox;
        private System.Windows.Forms.TextBox donorContactNoTextBox;
        private System.Windows.Forms.TextBox donorLastNameTextBox;
        private System.Windows.Forms.TextBox donorSearchTextBox;
        private System.Windows.Forms.TextBox donorFirstNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.DataGridView donorDataGridView;
        private DonorsViewDataSet donorsViewDataSet;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private DonorsViewDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}