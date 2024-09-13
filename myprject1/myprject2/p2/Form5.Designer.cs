namespace p4
{
    partial class sender
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
            this.device1 = new System.Windows.Forms.Label();
            this.device2 = new System.Windows.Forms.Label();
            this.btnyellow = new System.Windows.Forms.Button();
            this.butgren = new System.Windows.Forms.Button();
            this.btnred = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // device1
            // 
            this.device1.AutoSize = true;
            this.device1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.device1.Location = new System.Drawing.Point(203, 49);
            this.device1.Name = "device1";
            this.device1.Size = new System.Drawing.Size(50, 20);
            this.device1.TabIndex = 6;
            this.device1.Text = "جهاز1";
            // 
            // device2
            // 
            this.device2.AutoSize = true;
            this.device2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.device2.Location = new System.Drawing.Point(60, 49);
            this.device2.Name = "device2";
            this.device2.Size = new System.Drawing.Size(50, 20);
            this.device2.TabIndex = 7;
            this.device2.Text = "جهاز2";
            // 
            // btnyellow
            // 
            this.btnyellow.Location = new System.Drawing.Point(301, 94);
            this.btnyellow.Name = "btnyellow";
            this.btnyellow.Size = new System.Drawing.Size(75, 33);
            this.btnyellow.TabIndex = 8;
            this.btnyellow.Text = "اصفر";
            this.btnyellow.UseVisualStyleBackColor = true;
            // 
            // butgren
            // 
            this.butgren.Location = new System.Drawing.Point(166, 94);
            this.butgren.Name = "butgren";
            this.butgren.Size = new System.Drawing.Size(75, 33);
            this.butgren.TabIndex = 9;
            this.butgren.Text = "اخضر";
            this.butgren.UseVisualStyleBackColor = true;
            // 
            // btnred
            // 
            this.btnred.Location = new System.Drawing.Point(35, 94);
            this.btnred.Name = "btnred";
            this.btnred.Size = new System.Drawing.Size(75, 33);
            this.btnred.TabIndex = 10;
            this.btnred.Text = "احمر";
            this.btnred.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(166, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // sender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 238);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnred);
            this.Controls.Add(this.butgren);
            this.Controls.Add(this.btnyellow);
            this.Controls.Add(this.device2);
            this.Controls.Add(this.device1);
            this.Name = "sender";
            this.Text = "sender";
            this.Load += new System.EventHandler(this.sender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label device1;
        private System.Windows.Forms.Label device2;
        private System.Windows.Forms.Button btnyellow;
        private System.Windows.Forms.Button butgren;
        private System.Windows.Forms.Button btnred;
        private System.Windows.Forms.Button button4;
    }
}