namespace Grifindo_Lanka_Toys_Leave_Management_System
{
    partial class Apply_Leave_Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apply_Leave_Request));
            panel1 = new Panel();
            label12 = new Label();
            groupBox1 = new GroupBox();
            btnsearch = new Button();
            txtallocationid = new TextBox();
            txteid = new TextBox();
            cmbstatus = new ComboBox();
            txtreason = new TextBox();
            dtpleavestart = new DateTimePicker();
            cmbtypename = new ComboBox();
            label3 = new Label();
            label10 = new Label();
            txtduration = new TextBox();
            dtpleaveend = new DateTimePicker();
            txtleaveid = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            btndelete = new Button();
            btninsert = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 61);
            panel1.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(35, 18);
            label12.Name = "label12";
            label12.Size = new Size(297, 33);
            label12.TabIndex = 0;
            label12.Text = "Apply Leave Request";
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(btnsearch);
            groupBox1.Controls.Add(txtallocationid);
            groupBox1.Controls.Add(txteid);
            groupBox1.Controls.Add(cmbstatus);
            groupBox1.Controls.Add(txtreason);
            groupBox1.Controls.Add(dtpleavestart);
            groupBox1.Controls.Add(cmbtypename);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtduration);
            groupBox1.Controls.Add(dtpleaveend);
            groupBox1.Controls.Add(txtleaveid);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 517);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Leave Request";
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.DimGray;
            btnsearch.FlatStyle = FlatStyle.System;
            btnsearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsearch.ForeColor = SystemColors.ButtonFace;
            btnsearch.Location = new Point(243, 32);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(68, 23);
            btnsearch.TabIndex = 34;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtallocationid
            // 
            txtallocationid.Location = new Point(122, 469);
            txtallocationid.Name = "txtallocationid";
            txtallocationid.Size = new Size(100, 23);
            txtallocationid.TabIndex = 31;
            // 
            // txteid
            // 
            txteid.Location = new Point(122, 416);
            txteid.Name = "txteid";
            txteid.Size = new Size(100, 23);
            txteid.TabIndex = 30;
            // 
            // cmbstatus
            // 
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Items.AddRange(new object[] { "Pending", "", "" });
            cmbstatus.Location = new Point(121, 359);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(100, 23);
            cmbstatus.TabIndex = 29;
            cmbstatus.Text = "Pending";
            // 
            // txtreason
            // 
            txtreason.Location = new Point(121, 304);
            txtreason.Multiline = true;
            txtreason.Name = "txtreason";
            txtreason.Size = new Size(100, 23);
            txtreason.TabIndex = 28;
            // 
            // dtpleavestart
            // 
            dtpleavestart.Location = new Point(121, 136);
            dtpleavestart.Name = "dtpleavestart";
            dtpleavestart.RightToLeft = RightToLeft.No;
            dtpleavestart.Size = new Size(190, 23);
            dtpleavestart.TabIndex = 27;
            // 
            // cmbtypename
            // 
            cmbtypename.FormattingEnabled = true;
            cmbtypename.Items.AddRange(new object[] { "Annual Leave", "Casual Leave", "Short Leave" });
            cmbtypename.Location = new Point(121, 79);
            cmbtypename.Name = "cmbtypename";
            cmbtypename.Size = new Size(100, 23);
            cmbtypename.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 85);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 25;
            label3.Text = "Type Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(27, 475);
            label10.Name = "label10";
            label10.Size = new Size(89, 17);
            label10.TabIndex = 20;
            label10.Text = "Allocation ID";
            // 
            // txtduration
            // 
            txtduration.Location = new Point(121, 255);
            txtduration.Name = "txtduration";
            txtduration.Size = new Size(100, 23);
            txtduration.TabIndex = 16;
            // 
            // dtpleaveend
            // 
            dtpleaveend.Location = new Point(121, 197);
            dtpleaveend.Name = "dtpleaveend";
            dtpleaveend.Size = new Size(190, 23);
            dtpleaveend.TabIndex = 15;
            // 
            // txtleaveid
            // 
            txtleaveid.Location = new Point(121, 34);
            txtleaveid.Name = "txtleaveid";
            txtleaveid.Size = new Size(100, 23);
            txtleaveid.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(27, 422);
            label8.Name = "label8";
            label8.Size = new Size(33, 17);
            label8.TabIndex = 7;
            label8.Text = "E ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 365);
            label7.Name = "label7";
            label7.Size = new Size(46, 17);
            label7.TabIndex = 6;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 310);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 5;
            label6.Text = "Reason";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 261);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 4;
            label5.Text = "Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 203);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 3;
            label4.Text = "Leave End";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 142);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 1;
            label2.Text = "Leave Start";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 40);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 0;
            label1.Text = "Leave ID";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(15, 679);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(32, 15);
            linkLabel1.TabIndex = 38;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.DimGray;
            btndelete.FlatStyle = FlatStyle.System;
            btndelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = SystemColors.ButtonFace;
            btndelete.Location = new Point(15, 624);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(85, 32);
            btndelete.TabIndex = 37;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btninsert
            // 
            btninsert.BackColor = Color.DimGray;
            btninsert.FlatStyle = FlatStyle.System;
            btninsert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btninsert.ForeColor = SystemColors.ButtonFace;
            btninsert.Location = new Point(264, 624);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(84, 32);
            btninsert.TabIndex = 36;
            btninsert.Text = "APPLY";
            btninsert.UseVisualStyleBackColor = false;
            btninsert.Click += btninsert_Click;
            // 
            // Apply_Leave_Request
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(365, 703);
            Controls.Add(linkLabel1);
            Controls.Add(btndelete);
            Controls.Add(btninsert);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "Apply_Leave_Request";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apply_Leave_Request";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label12;
        private GroupBox groupBox1;
        private TextBox txtallocationid;
        private TextBox txteid;
        private ComboBox cmbstatus;
        private TextBox txtreason;
        private DateTimePicker dtpleavestart;
        private ComboBox cmbtypename;
        private Label label3;
        private Label label10;
        private TextBox txtduration;
        private DateTimePicker dtpleaveend;
        private TextBox txtleaveid;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnsearch;
        private LinkLabel linkLabel1;
        private Button btndelete;
        private Button btninsert;
    }
}