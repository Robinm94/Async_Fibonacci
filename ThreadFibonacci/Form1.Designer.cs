namespace ThreadFibonacci
{
    partial class Form1
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
            this.txtNumInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstFibResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNumInput
            // 
            this.txtNumInput.Location = new System.Drawing.Point(34, 29);
            this.txtNumInput.Name = "txtNumInput";
            this.txtNumInput.Size = new System.Drawing.Size(235, 26);
            this.txtNumInput.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(275, 24);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 37);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Generate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lstFibResult
            // 
            this.lstFibResult.FormattingEnabled = true;
            this.lstFibResult.ItemHeight = 20;
            this.lstFibResult.Location = new System.Drawing.Point(34, 67);
            this.lstFibResult.Name = "lstFibResult";
            this.lstFibResult.Size = new System.Drawing.Size(429, 564);
            this.lstFibResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 658);
            this.Controls.Add(this.lstFibResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstFibResult;
    }
}

