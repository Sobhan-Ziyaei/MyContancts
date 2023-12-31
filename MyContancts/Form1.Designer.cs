﻿namespace MyContancts
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            btnNewContact = new ToolStripButton();
            btnRefresh = new ToolStripButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnEdit = new Button();
            dgContacts = new DataGridView();
            ContactId = new DataGridViewTextBoxColumn();
            MyName = new DataGridViewTextBoxColumn();
            Family = new DataGridViewTextBoxColumn();
            Mobile = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtSearch = new TextBox();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgContacts).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNewContact, btnRefresh });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(784, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNewContact
            // 
            btnNewContact.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNewContact.Image = (Image)resources.GetObject("btnNewContact.Image");
            btnNewContact.ImageTransparentColor = Color.Magenta;
            btnNewContact.Name = "btnNewContact";
            btnNewContact.Size = new Size(106, 22);
            btnNewContact.Text = "افزودن شخص جدید";
            btnNewContact.Click += btnNewContact_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(64, 22);
            btnRefresh.Text = "بروز رسانی";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 102);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(dgContacts);
            groupBox2.Location = new Point(12, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(760, 413);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "لیست";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(598, 384);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(679, 384);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dgContacts
            // 
            dgContacts.AllowUserToAddRows = false;
            dgContacts.AllowUserToDeleteRows = false;
            dgContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgContacts.Columns.AddRange(new DataGridViewColumn[] { ContactId, MyName, Family, Mobile, Email, Age });
            dgContacts.Location = new Point(6, 21);
            dgContacts.Name = "dgContacts";
            dgContacts.ReadOnly = true;
            dgContacts.RowTemplate.Height = 25;
            dgContacts.Size = new Size(748, 357);
            dgContacts.TabIndex = 0;
            // 
            // ContactId
            // 
            ContactId.DataPropertyName = "ContactId";
            ContactId.HeaderText = "کد شخص";
            ContactId.Name = "ContactId";
            ContactId.ReadOnly = true;
            // 
            // MyName
            // 
            MyName.DataPropertyName = "Name";
            MyName.HeaderText = "نام";
            MyName.Name = "MyName";
            MyName.ReadOnly = true;
            // 
            // Family
            // 
            Family.DataPropertyName = "Family";
            Family.HeaderText = "نام خانوادگی";
            Family.Name = "Family";
            Family.ReadOnly = true;
            // 
            // Mobile
            // 
            Mobile.DataPropertyName = "Mobile";
            Mobile.HeaderText = "شماره موبایل";
            Mobile.Name = "Mobile";
            Mobile.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "ایمیل";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Age
            // 
            Age.DataPropertyName = "Age";
            Age.HeaderText = "سن";
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(679, 47);
            label1.Name = "label1";
            label1.Size = new Size(57, 14);
            label1.TabIndex = 0;
            label1.Text = "جستجو : ";
            label1.Click += label1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(356, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(317, 22);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "دفترچه تلفن";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgContacts;
        private DataGridViewTextBoxColumn ContactId;
        private DataGridViewTextBoxColumn MyName;
        private DataGridViewTextBoxColumn Family;
        private DataGridViewTextBoxColumn Mobile;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Age;
        private ToolStripButton btnNewContact;
        private ToolStripButton btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Label label1;
        private TextBox txtSearch;
    }
}