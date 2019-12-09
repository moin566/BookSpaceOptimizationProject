namespace bookSpaceOptimization
{
    partial class cupboard
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
            this.lblCupboard = new System.Windows.Forms.Label();
            this.txtCupboard = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCupboard
            // 
            this.lblCupboard.AutoSize = true;
            this.lblCupboard.Location = new System.Drawing.Point(84, 159);
            this.lblCupboard.Name = "lblCupboard";
            this.lblCupboard.Size = new System.Drawing.Size(90, 13);
            this.lblCupboard.TabIndex = 0;
            this.lblCupboard.Text = "No. of Cupboards";
            // 
            // txtCupboard
            // 
            this.txtCupboard.Location = new System.Drawing.Point(227, 152);
            this.txtCupboard.Name = "txtCupboard";
            this.txtCupboard.Size = new System.Drawing.Size(185, 20);
            this.txtCupboard.TabIndex = 1;
            this.txtCupboard.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(84, 213);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(102, 13);
            this.lblCapacity.TabIndex = 2;
            this.lblCapacity.Text = "Cupboards Capacity";
            this.lblCapacity.Click += new System.EventHandler(this.LblCapacity_Click);
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(227, 210);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(185, 20);
            this.txtCapacity.TabIndex = 3;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(272, 294);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Book Space Optimization";
            // 
            // cupboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtCupboard);
            this.Controls.Add(this.lblCupboard);
            this.Name = "cupboard";
            this.Text = "Cupboard";
            this.Load += new System.EventHandler(this.Cupboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCupboard;
        private System.Windows.Forms.TextBox txtCupboard;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
    }
}

