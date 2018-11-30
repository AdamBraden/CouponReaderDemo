namespace CouponReaderDemo.Forms
{
    partial class CouponReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CouponReader));
            this.headerGroupBox = new System.Windows.Forms.GroupBox();
            this.historyButton = new System.Windows.Forms.Button();
            this.txtInputCode = new System.Windows.Forms.TextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.scanButton = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inkCanvas1 = new Microsoft.Toolkit.Forms.UI.Controls.InkCanvas();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.couponDetailsControl1 = new CouponReaderDemo.Forms.CouponDetailsControl();
            this.couponHistoryControl1 = new CouponReaderDemo.Forms.CouponHistoryControl();
            this.headerGroupBox.SuspendLayout();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerGroupBox
            // 
            this.headerGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.headerGroupBox.Controls.Add(this.historyButton);
            this.headerGroupBox.Controls.Add(this.txtInputCode);
            this.headerGroupBox.Controls.Add(this.titleLbl);
            this.headerGroupBox.Controls.Add(this.clearButton);
            this.headerGroupBox.Controls.Add(this.scanButton);
            this.headerGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerGroupBox.Location = new System.Drawing.Point(0, 0);
            this.headerGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.headerGroupBox.Name = "headerGroupBox";
            this.headerGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.headerGroupBox.Size = new System.Drawing.Size(917, 65);
            this.headerGroupBox.TabIndex = 6;
            this.headerGroupBox.TabStop = false;
            // 
            // historyButton
            // 
            this.historyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.historyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.Location = new System.Drawing.Point(831, 19);
            this.historyButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(69, 29);
            this.historyButton.TabIndex = 3;
            this.historyButton.Text = "&History";
            this.historyButton.UseVisualStyleBackColor = false;
            // 
            // txtInputCode
            // 
            this.txtInputCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputCode.Location = new System.Drawing.Point(117, 21);
            this.txtInputCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtInputCode.Name = "txtInputCode";
            this.txtInputCode.Size = new System.Drawing.Size(546, 26);
            this.txtInputCode.TabIndex = 0;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.DimGray;
            this.titleLbl.Location = new System.Drawing.Point(13, 22);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(148, 20);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "Enter coupon code:";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(756, 19);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(69, 29);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // scanButton
            // 
            this.scanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scanButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.scanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanButton.Location = new System.Drawing.Point(683, 19);
            this.scanButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(69, 29);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "&Scan";
            this.scanButton.UseVisualStyleBackColor = false;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.pictureBox1);
            this.loginPanel.Controls.Add(this.button1);
            this.loginPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPanel.Location = new System.Drawing.Point(121, 369);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(722, 354);
            this.loginPanel.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(99, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnLogonButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 492);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.couponDetailsControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(909, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inkCanvas1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 187);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signature";
            // 
            // inkCanvas1
            // 
            this.inkCanvas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inkCanvas1.Location = new System.Drawing.Point(6, 20);
            this.inkCanvas1.Name = "inkCanvas1";
            this.inkCanvas1.Size = new System.Drawing.Size(891, 155);
            this.inkCanvas1.TabIndex = 0;
            this.inkCanvas1.Text = "inkCanvas1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.couponHistoryControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(903, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // couponDetailsControl1
            // 
            this.couponDetailsControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.couponDetailsControl1.Location = new System.Drawing.Point(3, 3);
            this.couponDetailsControl1.Name = "couponDetailsControl1";
            this.couponDetailsControl1.Size = new System.Drawing.Size(903, 273);
            this.couponDetailsControl1.TabIndex = 8;
            // 
            // couponHistoryControl1
            // 
            this.couponHistoryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.couponHistoryControl1.Location = new System.Drawing.Point(3, 3);
            this.couponHistoryControl1.Name = "couponHistoryControl1";
            this.couponHistoryControl1.Size = new System.Drawing.Size(897, 462);
            this.couponHistoryControl1.TabIndex = 9;
            // 
            // CouponReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(917, 557);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.headerGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CouponReader";
            this.Text = "Tailwind Traders Coupon Reader";
            this.headerGroupBox.ResumeLayout(false);
            this.headerGroupBox.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox headerGroupBox;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.TextBox txtInputCode;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private CouponDetailsControl couponDetailsControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private CouponHistoryControl couponHistoryControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Toolkit.Forms.UI.Controls.InkCanvas inkCanvas1;
    }
}

