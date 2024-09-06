namespace Grifindo_Lanka_Toys_Leave_Management_System
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            btnempregister = new Button();
            btnleaveallocation = new Button();
            btnleavereports = new Button();
            btnmanageleaverecords = new Button();
            linkLabel1 = new LinkLabel();
            btnapplyleave = new Button();
            btnempleavebalance = new Button();
            label1 = new Label();
            btnroaster = new Button();
            btnleavehistory = new Button();
            SuspendLayout();
            // 
            // btnempregister
            // 
            btnempregister.BackColor = Color.WhiteSmoke;
            btnempregister.Cursor = Cursors.Hand;
            btnempregister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnempregister.Location = new Point(9, 193);
            btnempregister.Name = "btnempregister";
            btnempregister.Size = new Size(128, 67);
            btnempregister.TabIndex = 0;
            btnempregister.Text = "Emp Register";
            btnempregister.UseVisualStyleBackColor = false;
            btnempregister.Click += btnempregister_Click;
            // 
            // btnleaveallocation
            // 
            btnleaveallocation.BackColor = Color.WhiteSmoke;
            btnleaveallocation.Cursor = Cursors.Hand;
            btnleaveallocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnleaveallocation.Location = new Point(152, 194);
            btnleaveallocation.Name = "btnleaveallocation";
            btnleaveallocation.Size = new Size(128, 67);
            btnleaveallocation.TabIndex = 2;
            btnleaveallocation.Text = "Leave Allocation";
            btnleaveallocation.UseVisualStyleBackColor = false;
            btnleaveallocation.Click += btnleaveallocation_Click;
            // 
            // btnleavereports
            // 
            btnleavereports.BackColor = Color.WhiteSmoke;
            btnleavereports.Cursor = Cursors.Hand;
            btnleavereports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnleavereports.Location = new Point(567, 193);
            btnleavereports.Name = "btnleavereports";
            btnleavereports.Size = new Size(128, 67);
            btnleavereports.TabIndex = 3;
            btnleavereports.Text = "Leave Reports";
            btnleavereports.UseVisualStyleBackColor = false;
            btnleavereports.Click += btnleavereports_Click;
            // 
            // btnmanageleaverecords
            // 
            btnmanageleaverecords.BackColor = Color.WhiteSmoke;
            btnmanageleaverecords.Cursor = Cursors.Hand;
            btnmanageleaverecords.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmanageleaverecords.Location = new Point(433, 193);
            btnmanageleaverecords.Name = "btnmanageleaverecords";
            btnmanageleaverecords.Size = new Size(128, 67);
            btnmanageleaverecords.TabIndex = 4;
            btnmanageleaverecords.Text = "Manage Leave Records";
            btnmanageleaverecords.UseVisualStyleBackColor = false;
            btnmanageleaverecords.Click += btnmanageleaverecords_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(14, 319);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log Out";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnapplyleave
            // 
            btnapplyleave.BackColor = Color.WhiteSmoke;
            btnapplyleave.Cursor = Cursors.Hand;
            btnapplyleave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnapplyleave.Location = new Point(9, 101);
            btnapplyleave.Name = "btnapplyleave";
            btnapplyleave.Size = new Size(128, 67);
            btnapplyleave.TabIndex = 6;
            btnapplyleave.Text = "Apply Leave";
            btnapplyleave.UseVisualStyleBackColor = false;
            btnapplyleave.Click += btnapplyleave_Click;
            // 
            // btnempleavebalance
            // 
            btnempleavebalance.BackColor = Color.WhiteSmoke;
            btnempleavebalance.Cursor = Cursors.Hand;
            btnempleavebalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnempleavebalance.Location = new Point(293, 101);
            btnempleavebalance.Name = "btnempleavebalance";
            btnempleavebalance.Size = new Size(128, 67);
            btnempleavebalance.TabIndex = 7;
            btnempleavebalance.Text = "Emp Leave Balance";
            btnempleavebalance.UseVisualStyleBackColor = false;
            btnempleavebalance.Click += btnviewstatus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(549, 33);
            label1.TabIndex = 0;
            label1.Text = "Grifindo Leave Management Dashboard";
            // 
            // btnroaster
            // 
            btnroaster.BackColor = Color.WhiteSmoke;
            btnroaster.Cursor = Cursors.Hand;
            btnroaster.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnroaster.Location = new Point(293, 193);
            btnroaster.Name = "btnroaster";
            btnroaster.Size = new Size(128, 67);
            btnroaster.TabIndex = 9;
            btnroaster.Text = "Roaster";
            btnroaster.UseVisualStyleBackColor = false;
            btnroaster.Click += btnroaster_Click;
            // 
            // btnleavehistory
            // 
            btnleavehistory.BackColor = Color.WhiteSmoke;
            btnleavehistory.Cursor = Cursors.Hand;
            btnleavehistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnleavehistory.Location = new Point(567, 101);
            btnleavehistory.Name = "btnleavehistory";
            btnleavehistory.Size = new Size(128, 67);
            btnleavehistory.TabIndex = 8;
            btnleavehistory.Text = "Leave History";
            btnleavehistory.UseVisualStyleBackColor = false;
            btnleavehistory.Click += btnleavehistory_Click;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(705, 361);
            Controls.Add(btnroaster);
            Controls.Add(label1);
            Controls.Add(btnleavehistory);
            Controls.Add(btnempleavebalance);
            Controls.Add(btnapplyleave);
            Controls.Add(linkLabel1);
            Controls.Add(btnmanageleaverecords);
            Controls.Add(btnleavereports);
            Controls.Add(btnleaveallocation);
            Controls.Add(btnempregister);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_Menu";
            Load += Main_Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnempregister;
        private Button btnleaveallocation;
        private Button btnleavereports;
        private Button btnmanageleaverecords;
        private LinkLabel linkLabel1;
        private Button btnapplyleave;
        private Button btnempleavebalance;
        private Label label1;
        private Button btnroaster;
        private Button btnleavehistory;
    }
}