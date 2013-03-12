namespace WinMailUtility.App
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.serverNameTextbox = new System.Windows.Forms.TextBox();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.serverPortLabel = new System.Windows.Forms.Label();
            this.serverPortTextbox = new System.Windows.Forms.TextBox();
            this.sourceEmailLabel = new System.Windows.Forms.Label();
            this.sourceEmailTextbox = new System.Windows.Forms.TextBox();
            this.destinationEmailLabel = new System.Windows.Forms.Label();
            this.destinationEmailTextbox = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.emailMessageTextbox = new System.Windows.Forms.TextBox();
            this.emailMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serverNameTextbox
            // 
            this.serverNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.serverNameTextbox.Location = new System.Drawing.Point(114, 13);
            this.serverNameTextbox.Name = "serverNameTextbox";
            this.serverNameTextbox.Size = new System.Drawing.Size(346, 20);
            this.serverNameTextbox.TabIndex = 0;
            this.serverNameTextbox.Text = "localhost";
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(12, 16);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(69, 13);
            this.serverNameLabel.TabIndex = 1;
            this.serverNameLabel.Text = "Server Name";
            // 
            // serverPortLabel
            // 
            this.serverPortLabel.AutoSize = true;
            this.serverPortLabel.Location = new System.Drawing.Point(12, 42);
            this.serverPortLabel.Name = "serverPortLabel";
            this.serverPortLabel.Size = new System.Drawing.Size(60, 13);
            this.serverPortLabel.TabIndex = 3;
            this.serverPortLabel.Text = "Server Port";
            // 
            // serverPortTextbox
            // 
            this.serverPortTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.serverPortTextbox.Location = new System.Drawing.Point(114, 39);
            this.serverPortTextbox.Name = "serverPortTextbox";
            this.serverPortTextbox.Size = new System.Drawing.Size(346, 20);
            this.serverPortTextbox.TabIndex = 2;
            this.serverPortTextbox.Text = "25";
            // 
            // sourceEmailLabel
            // 
            this.sourceEmailLabel.AutoSize = true;
            this.sourceEmailLabel.Location = new System.Drawing.Point(12, 68);
            this.sourceEmailLabel.Name = "sourceEmailLabel";
            this.sourceEmailLabel.Size = new System.Drawing.Size(69, 13);
            this.sourceEmailLabel.TabIndex = 5;
            this.sourceEmailLabel.Text = "Source Email";
            // 
            // sourceEmailTextbox
            // 
            this.sourceEmailTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceEmailTextbox.Location = new System.Drawing.Point(114, 65);
            this.sourceEmailTextbox.Name = "sourceEmailTextbox";
            this.sourceEmailTextbox.Size = new System.Drawing.Size(346, 20);
            this.sourceEmailTextbox.TabIndex = 4;
            // 
            // destinationEmailLabel
            // 
            this.destinationEmailLabel.AutoSize = true;
            this.destinationEmailLabel.Location = new System.Drawing.Point(12, 94);
            this.destinationEmailLabel.Name = "destinationEmailLabel";
            this.destinationEmailLabel.Size = new System.Drawing.Size(88, 13);
            this.destinationEmailLabel.TabIndex = 7;
            this.destinationEmailLabel.Text = "Destination Email";
            // 
            // destinationEmailTextbox
            // 
            this.destinationEmailTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationEmailTextbox.Location = new System.Drawing.Point(114, 91);
            this.destinationEmailTextbox.Name = "destinationEmailTextbox";
            this.destinationEmailTextbox.Size = new System.Drawing.Size(346, 20);
            this.destinationEmailTextbox.TabIndex = 6;
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(12, 120);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(71, 13);
            this.Subject.TabIndex = 9;
            this.Subject.Text = "Email Subject";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(114, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 20);
            this.textBox1.TabIndex = 8;
            // 
            // emailMessageTextbox
            // 
            this.emailMessageTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.emailMessageTextbox.Location = new System.Drawing.Point(114, 143);
            this.emailMessageTextbox.Multiline = true;
            this.emailMessageTextbox.Name = "emailMessageTextbox";
            this.emailMessageTextbox.Size = new System.Drawing.Size(346, 138);
            this.emailMessageTextbox.TabIndex = 10;
            // 
            // emailMessageLabel
            // 
            this.emailMessageLabel.AutoSize = true;
            this.emailMessageLabel.Location = new System.Drawing.Point(12, 146);
            this.emailMessageLabel.Name = "emailMessageLabel";
            this.emailMessageLabel.Size = new System.Drawing.Size(78, 13);
            this.emailMessageLabel.TabIndex = 11;
            this.emailMessageLabel.Text = "Email Message";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 293);
            this.Controls.Add(this.emailMessageLabel);
            this.Controls.Add(this.emailMessageTextbox);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.destinationEmailLabel);
            this.Controls.Add(this.destinationEmailTextbox);
            this.Controls.Add(this.sourceEmailLabel);
            this.Controls.Add(this.sourceEmailTextbox);
            this.Controls.Add(this.serverPortLabel);
            this.Controls.Add(this.serverPortTextbox);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.serverNameTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinMailUtility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverNameTextbox;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Label serverPortLabel;
        private System.Windows.Forms.TextBox serverPortTextbox;
        private System.Windows.Forms.Label sourceEmailLabel;
        private System.Windows.Forms.TextBox sourceEmailTextbox;
        private System.Windows.Forms.Label destinationEmailLabel;
        private System.Windows.Forms.TextBox destinationEmailTextbox;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox emailMessageTextbox;
        private System.Windows.Forms.Label emailMessageLabel;
    }
}

