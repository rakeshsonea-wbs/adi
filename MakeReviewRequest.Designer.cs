namespace PeerReviewSample
{
    partial class MakeReviewRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.chkListSpecialisms = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelMinGrade = new System.Windows.Forms.Panel();
            this.dGridViewMinGrade = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panelMinGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewMinGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Link";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(134, 43);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(256, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(134, 84);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(256, 20);
            this.txtLink.TabIndex = 3;
            this.txtLink.Text = "http://www.research.com/";
            // 
            // chkListSpecialisms
            // 
            this.chkListSpecialisms.FormattingEnabled = true;
            this.chkListSpecialisms.Location = new System.Drawing.Point(134, 171);
            this.chkListSpecialisms.Name = "chkListSpecialisms";
            this.chkListSpecialisms.Size = new System.Drawing.Size(256, 199);
            this.chkListSpecialisms.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Specialisms:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(231, 408);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelMinGrade
            // 
            this.panelMinGrade.Controls.Add(this.dGridViewMinGrade);
            this.panelMinGrade.Controls.Add(this.btnSubmit);
            this.panelMinGrade.Location = new System.Drawing.Point(12, 11);
            this.panelMinGrade.Name = "panelMinGrade";
            this.panelMinGrade.Size = new System.Drawing.Size(421, 441);
            this.panelMinGrade.TabIndex = 7;
            this.panelMinGrade.Visible = false;
            // 
            // dGridViewMinGrade
            // 
            this.dGridViewMinGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewMinGrade.Location = new System.Drawing.Point(36, 32);
            this.dGridViewMinGrade.Name = "dGridViewMinGrade";
            this.dGridViewMinGrade.Size = new System.Drawing.Size(353, 270);
            this.dGridViewMinGrade.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(162, 387);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // MakeReviewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 464);
            this.Controls.Add(this.panelMinGrade);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkListSpecialisms);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MakeReviewRequest";
            this.Text = "MakeReviewRequest";
            this.Load += new System.EventHandler(this.MakeReviewRequest_Load);
            this.panelMinGrade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewMinGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.CheckedListBox chkListSpecialisms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panelMinGrade;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dGridViewMinGrade;
    }
}