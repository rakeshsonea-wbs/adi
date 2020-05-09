namespace PeerReviewSample
{
    partial class Dashboard
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
            this.btnMakeReviewRequest = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnReviewTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMakeReviewRequest
            // 
            this.btnMakeReviewRequest.Location = new System.Drawing.Point(72, 125);
            this.btnMakeReviewRequest.Name = "btnMakeReviewRequest";
            this.btnMakeReviewRequest.Size = new System.Drawing.Size(100, 91);
            this.btnMakeReviewRequest.TabIndex = 0;
            this.btnMakeReviewRequest.Text = "Create Review Request";
            this.btnMakeReviewRequest.UseVisualStyleBackColor = true;
            this.btnMakeReviewRequest.Click += new System.EventHandler(this.btnMakeReviewRequest_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(688, 12);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(74, 39);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnReviewTasks
            // 
            this.btnReviewTasks.Location = new System.Drawing.Point(208, 125);
            this.btnReviewTasks.Name = "btnReviewTasks";
            this.btnReviewTasks.Size = new System.Drawing.Size(97, 91);
            this.btnReviewTasks.TabIndex = 3;
            this.btnReviewTasks.Text = "Review Tasks";
            this.btnReviewTasks.UseVisualStyleBackColor = true;
            this.btnReviewTasks.Click += new System.EventHandler(this.btnReviewTasks_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReviewTasks);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnMakeReviewRequest);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMakeReviewRequest;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReviewTasks;
    }
}