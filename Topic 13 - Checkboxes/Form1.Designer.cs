namespace Topic_13___Checkboxes
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
            this.lblinstuctions = new System.Windows.Forms.Label();
            this.chkMath = new System.Windows.Forms.CheckBox();
            this.chkScience = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblRResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblinstuctions
            // 
            this.lblinstuctions.AutoSize = true;
            this.lblinstuctions.Location = new System.Drawing.Point(13, 13);
            this.lblinstuctions.Name = "lblinstuctions";
            this.lblinstuctions.Size = new System.Drawing.Size(52, 13);
            this.lblinstuctions.TabIndex = 0;
            this.lblinstuctions.Text = "Pick one!";
            // 
            // chkMath
            // 
            this.chkMath.AutoSize = true;
            this.chkMath.Location = new System.Drawing.Point(16, 42);
            this.chkMath.Name = "chkMath";
            this.chkMath.Size = new System.Drawing.Size(74, 17);
            this.chkMath.TabIndex = 1;
            this.chkMath.Text = "I like math";
            this.chkMath.UseVisualStyleBackColor = true;
            // 
            // chkScience
            // 
            this.chkScience.AutoSize = true;
            this.chkScience.Location = new System.Drawing.Point(320, 42);
            this.chkScience.Name = "chkScience";
            this.chkScience.Size = new System.Drawing.Size(88, 17);
            this.chkScience.TabIndex = 2;
            this.chkScience.Text = "I like science";
            this.chkScience.UseVisualStyleBackColor = true;
            this.chkScience.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(16, 91);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblRResult
            // 
            this.lblRResult.AutoSize = true;
            this.lblRResult.Location = new System.Drawing.Point(16, 143);
            this.lblRResult.Name = "lblRResult";
            this.lblRResult.Size = new System.Drawing.Size(40, 13);
            this.lblRResult.TabIndex = 4;
            this.lblRResult.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkScience);
            this.Controls.Add(this.chkMath);
            this.Controls.Add(this.lblinstuctions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinstuctions;
        private System.Windows.Forms.CheckBox chkMath;
        private System.Windows.Forms.CheckBox chkScience;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblRResult;
    }
}

