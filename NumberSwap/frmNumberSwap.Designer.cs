namespace week2activity
{
    partial class frmNumberSwap
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
            this.lstLeft = new System.Windows.Forms.ListBox();
            this.lstRight = new System.Windows.Forms.ListBox();
            this.btnSwapNumber = new System.Windows.Forms.Button();
            this.btnSwapList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLeft
            // 
            this.lstLeft.FormattingEnabled = true;
            this.lstLeft.Location = new System.Drawing.Point(16, 15);
            this.lstLeft.Name = "lstLeft";
            this.lstLeft.Size = new System.Drawing.Size(120, 121);
            this.lstLeft.TabIndex = 0;
            // 
            // lstRight
            // 
            this.lstRight.FormattingEnabled = true;
            this.lstRight.Location = new System.Drawing.Point(241, 14);
            this.lstRight.Name = "lstRight";
            this.lstRight.Size = new System.Drawing.Size(120, 121);
            this.lstRight.TabIndex = 1;
            // 
            // btnSwapNumber
            // 
            this.btnSwapNumber.Location = new System.Drawing.Point(142, 49);
            this.btnSwapNumber.Name = "btnSwapNumber";
            this.btnSwapNumber.Size = new System.Drawing.Size(93, 23);
            this.btnSwapNumber.TabIndex = 2;
            this.btnSwapNumber.Text = "Swap Number";
            this.btnSwapNumber.UseVisualStyleBackColor = true;
            this.btnSwapNumber.Click += new System.EventHandler(this.btnSwapNumber_Click);
            // 
            // btnSwapList
            // 
            this.btnSwapList.Location = new System.Drawing.Point(142, 78);
            this.btnSwapList.Name = "btnSwapList";
            this.btnSwapList.Size = new System.Drawing.Size(93, 23);
            this.btnSwapList.TabIndex = 3;
            this.btnSwapList.Text = "Swap List";
            this.btnSwapList.UseVisualStyleBackColor = true;
            this.btnSwapList.Click += new System.EventHandler(this.btnSwapList_Click);
            // 
            // frmNumberSwap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 151);
            this.Controls.Add(this.btnSwapList);
            this.Controls.Add(this.btnSwapNumber);
            this.Controls.Add(this.lstRight);
            this.Controls.Add(this.lstLeft);
            this.Name = "frmNumberSwap";
            this.Text = "Number Swap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLeft;
        private System.Windows.Forms.ListBox lstRight;
        private System.Windows.Forms.Button btnSwapNumber;
        private System.Windows.Forms.Button btnSwapList;
    }
}

