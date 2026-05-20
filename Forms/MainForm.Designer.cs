namespace MY_Class_Project.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoginout = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnViewBooking = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(937, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoginout
            // 
            this.btnLoginout.BackColor = System.Drawing.Color.White;
            this.btnLoginout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginout.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnLoginout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginout.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLoginout.Location = new System.Drawing.Point(754, 10);
            this.btnLoginout.Name = "btnLoginout";
            this.btnLoginout.Size = new System.Drawing.Size(160, 35);
            this.btnLoginout.TabIndex = 3;
            this.btnLoginout.Text = "Logout";
            this.btnLoginout.UseVisualStyleBackColor = false;
            this.btnLoginout.Click += new System.EventHandler(this.btnLoginout_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.White;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCustomer.Location = new System.Drawing.Point(588, 10);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(160, 35);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnViewBooking
            // 
            this.btnViewBooking.BackColor = System.Drawing.Color.White;
            this.btnViewBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBooking.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnViewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBooking.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnViewBooking.Location = new System.Drawing.Point(422, 10);
            this.btnViewBooking.Name = "btnViewBooking";
            this.btnViewBooking.Size = new System.Drawing.Size(160, 35);
            this.btnViewBooking.TabIndex = 5;
            this.btnViewBooking.Text = "View Booking";
            this.btnViewBooking.UseVisualStyleBackColor = false;
            this.btnViewBooking.Click += new System.EventHandler(this.btnViewBooking_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.White;
            this.btnBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooking.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBooking.Location = new System.Drawing.Point(256, 10);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(160, 35);
            this.btnBooking.TabIndex = 6;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Marriage Hall";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnViewBooking);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnLoginout);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoginout;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnViewBooking;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Label label1;
    }
}