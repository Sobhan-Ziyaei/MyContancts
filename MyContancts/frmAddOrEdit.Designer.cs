namespace MyContancts
{
    partial class frmAddOrEdit
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
            groupBox1 = new GroupBox();
            txtAge = new NumericUpDown();
            txtFamily = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            txtMobile = new TextBox();
            label5 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            label1 = new Label();
            btnSubmit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtFamily);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMobile);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات فرد";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(16, 60);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(206, 22);
            txtAge.TabIndex = 4;
            // 
            // txtFamily
            // 
            txtFamily.Location = new Point(16, 32);
            txtFamily.Name = "txtFamily";
            txtFamily.Size = new Size(206, 22);
            txtFamily.TabIndex = 3;
            txtFamily.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 63);
            label3.Name = "label3";
            label3.Size = new Size(40, 14);
            label3.TabIndex = 2;
            label3.Text = "سن : ";
            label3.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 35);
            label2.Name = "label2";
            label2.Size = new Size(84, 14);
            label2.TabIndex = 2;
            label2.Text = "نام خانوادگی : ";
            label2.Click += label2_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(16, 116);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(494, 103);
            txtAddress.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(16, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(494, 22);
            txtEmail.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(511, 119);
            label6.Name = "label6";
            label6.Size = new Size(47, 14);
            label6.TabIndex = 0;
            label6.Text = "آدرس : ";
            label6.Click += label4_Click;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(331, 60);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(179, 22);
            txtMobile.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(511, 91);
            label5.Name = "label5";
            label5.Size = new Size(45, 14);
            label5.TabIndex = 0;
            label5.Text = "ایمیل : ";
            label5.Click += label4_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(331, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(179, 22);
            txtName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(511, 63);
            label4.Name = "label4";
            label4.Size = new Size(49, 14);
            label4.TabIndex = 0;
            label4.Text = "موبایل : ";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(516, 35);
            label1.Name = "label1";
            label1.Size = new Size(29, 14);
            label1.TabIndex = 0;
            label1.Text = "نام :";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(447, 267);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "ثبت";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // frmAddOrEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(btnSubmit);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAddOrEdit";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAddOrEdit_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtFamily;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Label label3;
        private TextBox txtMobile;
        private Label label4;
        private NumericUpDown txtAge;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private Button btnSubmit;
    }
}