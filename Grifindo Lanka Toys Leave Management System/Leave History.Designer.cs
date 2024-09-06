namespace Grifindo_Lanka_Toys_Leave_Management_System
{
    partial class Leave_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leave_History));
            linkLabel1 = new LinkLabel();
            label12 = new Label();
            panel1 = new Panel();
            dtpenddate = new DateTimePicker();
            dtpstartdate = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            btnsearch = new Button();
            txteid = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(25, 603);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(32, 15);
            linkLabel1.TabIndex = 47;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(210, 15);
            label12.Name = "label12";
            label12.Size = new Size(303, 33);
            label12.TabIndex = 0;
            label12.Text = "Leave History/Status";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 61);
            panel1.TabIndex = 44;
            // 
            // dtpenddate
            // 
            dtpenddate.Location = new Point(413, 86);
            dtpenddate.Name = "dtpenddate";
            dtpenddate.Size = new Size(190, 23);
            dtpenddate.TabIndex = 40;
            // 
            // dtpstartdate
            // 
            dtpstartdate.Location = new Point(104, 86);
            dtpstartdate.Name = "dtpstartdate";
            dtpstartdate.Size = new Size(190, 23);
            dtpstartdate.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(327, 92);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 37;
            label3.Text = "End Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 92);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 35;
            label2.Text = "Start Date";
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.DimGray;
            btnsearch.FlatStyle = FlatStyle.System;
            btnsearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsearch.ForeColor = SystemColors.ButtonFace;
            btnsearch.Location = new Point(193, 27);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(68, 23);
            btnsearch.TabIndex = 34;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // txteid
            // 
            txteid.Location = new Point(104, 27);
            txteid.Name = "txteid";
            txteid.Size = new Size(73, 23);
            txteid.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 33);
            label1.Name = "label1";
            label1.Size = new Size(33, 17);
            label1.TabIndex = 13;
            label1.Text = "E ID";
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(dtpenddate);
            groupBox1.Controls.Add(dtpstartdate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnsearch);
            groupBox1.Controls.Add(txteid);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(667, 141);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Leave History";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 270);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(524, 298);
            dataGridView1.TabIndex = 45;
            // 
            // Leave_History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(720, 644);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Leave_History";
            Text = "Leave_History";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label12;
        private Panel panel1;
        private DateTimePicker dtpenddate;
        private DateTimePicker dtpstartdate;
        private Label label3;
        private Label label2;
        private Button btnsearch;
        private TextBox txteid;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}