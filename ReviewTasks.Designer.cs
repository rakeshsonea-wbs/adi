namespace PeerReviewSample
{
    partial class ReviewTasks
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
            this.panelAllStatus = new System.Windows.Forms.Panel();
            this.panelAwaiting = new System.Windows.Forms.Panel();
            this.dGridAwaiting = new System.Windows.Forms.DataGridView();
            this.dGridAllStatus = new System.Windows.Forms.DataGridView();
            this.btnAwaiting = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.panelAllStatus.SuspendLayout();
            this.panelAwaiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAwaiting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAllStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAllStatus
            // 
            this.panelAllStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelAllStatus.BackColor = System.Drawing.Color.Red;
            this.panelAllStatus.Controls.Add(this.dGridAllStatus);
            this.panelAllStatus.Location = new System.Drawing.Point(12, 12);
            this.panelAllStatus.Name = "panelAllStatus";
            this.panelAllStatus.Size = new System.Drawing.Size(758, 426);
            this.panelAllStatus.TabIndex = 0;
            // 
            // panelAwaiting
            // 
            this.panelAwaiting.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelAwaiting.BackColor = System.Drawing.Color.Blue;
            this.panelAwaiting.Controls.Add(this.dGridAwaiting);
            this.panelAwaiting.Location = new System.Drawing.Point(15, 9);
            this.panelAwaiting.Name = "panelAwaiting";
            this.panelAwaiting.Size = new System.Drawing.Size(758, 426);
            this.panelAwaiting.TabIndex = 2;
            this.panelAwaiting.Visible = false;
            // 
            // dGridAwaiting
            // 
            this.dGridAwaiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridAwaiting.Location = new System.Drawing.Point(24, 14);
            this.dGridAwaiting.Name = "dGridAwaiting";
            this.dGridAwaiting.Size = new System.Drawing.Size(612, 340);
            this.dGridAwaiting.TabIndex = 1;
            this.dGridAwaiting.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGridAwaiting_CellMouseDoubleClick);
            // 
            // dGridAllStatus
            // 
            this.dGridAllStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridAllStatus.Location = new System.Drawing.Point(18, 18);
            this.dGridAllStatus.Name = "dGridAllStatus";
            this.dGridAllStatus.Size = new System.Drawing.Size(728, 394);
            this.dGridAllStatus.TabIndex = 1;
            // 
            // btnAwaiting
            // 
            this.btnAwaiting.Location = new System.Drawing.Point(182, 470);
            this.btnAwaiting.Name = "btnAwaiting";
            this.btnAwaiting.Size = new System.Drawing.Size(81, 39);
            this.btnAwaiting.TabIndex = 2;
            this.btnAwaiting.Text = "Awaiting";
            this.btnAwaiting.UseVisualStyleBackColor = true;
            this.btnAwaiting.Click += new System.EventHandler(this.btnAwaiting_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(314, 470);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(81, 39);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(443, 470);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(81, 39);
            this.btnLock.TabIndex = 4;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(591, 470);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 39);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(52, 470);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(81, 39);
            this.btnAll.TabIndex = 6;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // ReviewTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 521);
            this.Controls.Add(this.panelAwaiting);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnAwaiting);
            this.Controls.Add(this.panelAllStatus);
            this.Name = "ReviewTasks";
            this.Text = "ReviewTasks";
            this.Load += new System.EventHandler(this.ReviewTasks_Load);
            this.panelAllStatus.ResumeLayout(false);
            this.panelAwaiting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridAwaiting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAllStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAllStatus;
        private System.Windows.Forms.DataGridView dGridAllStatus;
        private System.Windows.Forms.Button btnAwaiting;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Panel panelAwaiting;
        private System.Windows.Forms.DataGridView dGridAwaiting;
    }
}