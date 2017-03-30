namespace TimeConverter.WinFormsApp
{
    partial class MainForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startTimeMelbTextBox = new System.Windows.Forms.TextBox();
            this.endTimeMelbTextBox = new System.Windows.Forms.TextBox();
            this.endTimeUtcTextBox = new System.Windows.Forms.TextBox();
            this.startTimeUtcTextBox = new System.Windows.Forms.TextBox();
            this.convertToUtcButton = new System.Windows.Forms.Button();
            this.convertToMelbButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Melbourne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UTC ISO-8601";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start Time";
            // 
            // startTimeMelbTextBox
            // 
            this.startTimeMelbTextBox.Location = new System.Drawing.Point(92, 54);
            this.startTimeMelbTextBox.Name = "startTimeMelbTextBox";
            this.startTimeMelbTextBox.Size = new System.Drawing.Size(199, 20);
            this.startTimeMelbTextBox.TabIndex = 4;
            // 
            // endTimeMelbTextBox
            // 
            this.endTimeMelbTextBox.Location = new System.Drawing.Point(297, 54);
            this.endTimeMelbTextBox.Name = "endTimeMelbTextBox";
            this.endTimeMelbTextBox.Size = new System.Drawing.Size(199, 20);
            this.endTimeMelbTextBox.TabIndex = 5;
            // 
            // endTimeUtcTextBox
            // 
            this.endTimeUtcTextBox.Location = new System.Drawing.Point(297, 80);
            this.endTimeUtcTextBox.Name = "endTimeUtcTextBox";
            this.endTimeUtcTextBox.Size = new System.Drawing.Size(199, 20);
            this.endTimeUtcTextBox.TabIndex = 7;
            // 
            // startTimeUtcTextBox
            // 
            this.startTimeUtcTextBox.Location = new System.Drawing.Point(92, 80);
            this.startTimeUtcTextBox.Name = "startTimeUtcTextBox";
            this.startTimeUtcTextBox.Size = new System.Drawing.Size(199, 20);
            this.startTimeUtcTextBox.TabIndex = 6;
            // 
            // convertToUtcButton
            // 
            this.convertToUtcButton.Location = new System.Drawing.Point(502, 52);
            this.convertToUtcButton.Name = "convertToUtcButton";
            this.convertToUtcButton.Size = new System.Drawing.Size(129, 23);
            this.convertToUtcButton.TabIndex = 8;
            this.convertToUtcButton.Text = "Convert To UTC";
            this.convertToUtcButton.UseVisualStyleBackColor = true;
            this.convertToUtcButton.Click += new System.EventHandler(this.convertToUtcButton_Click);
            // 
            // convertToMelbButton
            // 
            this.convertToMelbButton.Location = new System.Drawing.Point(502, 78);
            this.convertToMelbButton.Name = "convertToMelbButton";
            this.convertToMelbButton.Size = new System.Drawing.Size(129, 23);
            this.convertToMelbButton.TabIndex = 9;
            this.convertToMelbButton.Text = "Convert To Melbourne";
            this.convertToMelbButton.UseVisualStyleBackColor = true;
            this.convertToMelbButton.Click += new System.EventHandler(this.convertToMelbButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 114);
            this.Controls.Add(this.convertToMelbButton);
            this.Controls.Add(this.convertToUtcButton);
            this.Controls.Add(this.endTimeUtcTextBox);
            this.Controls.Add(this.startTimeUtcTextBox);
            this.Controls.Add(this.endTimeMelbTextBox);
            this.Controls.Add(this.startTimeMelbTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startTimeMelbTextBox;
        private System.Windows.Forms.TextBox endTimeMelbTextBox;
        private System.Windows.Forms.TextBox endTimeUtcTextBox;
        private System.Windows.Forms.TextBox startTimeUtcTextBox;
        private System.Windows.Forms.Button convertToUtcButton;
        private System.Windows.Forms.Button convertToMelbButton;
    }
}

