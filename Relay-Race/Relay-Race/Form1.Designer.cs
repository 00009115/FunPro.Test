namespace Relay_Race
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxRunner1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRunner2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Runner 1:";
            // 
            // tbxRunner1
            // 
            this.tbxRunner1.Location = new System.Drawing.Point(137, 64);
            this.tbxRunner1.Name = "tbxRunner1";
            this.tbxRunner1.Size = new System.Drawing.Size(143, 22);
            this.tbxRunner1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Runner 2:";
            // 
            // tbxRunner2
            // 
            this.tbxRunner2.Location = new System.Drawing.Point(137, 97);
            this.tbxRunner2.Name = "tbxRunner2";
            this.tbxRunner2.Size = new System.Drawing.Size(143, 22);
            this.tbxRunner2.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(198, 142);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(82, 33);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 196);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbxRunner2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxRunner1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Total Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxRunner1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRunner2;
        private System.Windows.Forms.Button btnCalculate;
    }
}

