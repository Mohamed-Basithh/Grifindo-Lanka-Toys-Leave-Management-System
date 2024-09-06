namespace Grifindo_Lanka_Toys_Leave_Management_System
{
    partial class Roaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roaster));
            label12 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            txteid = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtroasterid = new TextBox();
            btnupdate = new Button();
            btndelete = new Button();
            btninsert = new Button();
            groupBox1 = new GroupBox();
            dtpendtime = new DateTimePicker();
            dtpstarttime = new DateTimePicker();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(95, 18);
            label12.Name = "label12";
            label12.Size = new Size(121, 33);
            label12.TabIndex = 0;
            label12.Text = "Roaster";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 40);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 13;
            label1.Text = "Roaster ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 61);
            panel1.TabIndex = 30;
            // 
            // txteid
            // 
            txteid.Location = new Point(161, 205);
            txteid.Name = "txteid";
            txteid.Size = new Size(100, 23);
            txteid.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 211);
            label4.Name = "label4";
            label4.Size = new Size(33, 17);
            label4.TabIndex = 19;
            label4.Text = "E ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 154);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 17;
            label3.Text = "End Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 93);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 15;
            label2.Text = "Start Time";
            // 
            // txtroasterid
            // 
            txtroasterid.Location = new Point(161, 34);
            txtroasterid.Name = "txtroasterid";
            txtroasterid.Size = new Size(100, 23);
            txtroasterid.TabIndex = 14;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.DimGray;
            btnupdate.FlatStyle = FlatStyle.System;
            btnupdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.ForeColor = SystemColors.ButtonFace;
            btnupdate.Location = new Point(121, 383);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(84, 32);
            btnupdate.TabIndex = 34;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.DimGray;
            btndelete.FlatStyle = FlatStyle.System;
            btndelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = SystemColors.ButtonFace;
            btndelete.Location = new Point(15, 383);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(85, 32);
            btndelete.TabIndex = 33;
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
            btninsert.Location = new Point(222, 383);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(84, 32);
            btninsert.TabIndex = 32;
            btninsert.Text = "INSERT";
            btninsert.UseVisualStyleBackColor = false;
            btninsert.Click += btninsert_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(dtpendtime);
            groupBox1.Controls.Add(dtpstarttime);
            groupBox1.Controls.Add(txteid);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtroasterid);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 268);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Roaster Details";
            // 
            // dtpendtime
            // 
            dtpendtime.Format = DateTimePickerFormat.Short;
            dtpendtime.Location = new Point(161, 148);
            dtpendtime.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dtpendtime.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpendtime.Name = "dtpendtime";
            dtpendtime.Size = new Size(100, 23);
            dtpendtime.TabIndex = 22;
            // 
            // dtpstarttime
            // 
            dtpstarttime.Format = DateTimePickerFormat.Short;
            dtpstarttime.Location = new Point(161, 93);
            dtpstarttime.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dtpstarttime.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpstarttime.Name = "dtpstarttime";
            dtpstarttime.Size = new Size(100, 23);
            dtpstarttime.TabIndex = 21;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(15, 426);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(32, 15);
            linkLabel1.TabIndex = 35;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Roaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(326, 450);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(btnupdate);
            Controls.Add(btndelete);
            Controls.Add(btninsert);
            Controls.Add(groupBox1);
            Name = "Roaster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Roaster";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label1;
        private Panel panel1;
        private TextBox txteid;
        private Label label4;
        private TextBox txtcasualleaves;
        private Label label3;
        private TextBox txtannualleaves;
        private Label label2;
        private TextBox txtroasterid;
        private Button btnupdate;
        private Button btndelete;
        private Button btninsert;
        private GroupBox groupBox1;
        private DateTimePicker dtpendtime;
        private DateTimePicker dtpstarttime;
        private LinkLabel linkLabel1;
    }
}