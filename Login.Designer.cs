namespace Karaoke_PopRock
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tfUsername = new System.Windows.Forms.TextBox();
            this.tfPassword = new System.Windows.Forms.TextBox();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tfUsername
            // 
            this.tfUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tfUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tfUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfUsername.Location = new System.Drawing.Point(842, 402);
            this.tfUsername.Name = "tfUsername";
            this.tfUsername.Size = new System.Drawing.Size(358, 31);
            this.tfUsername.TabIndex = 0;
            // 
            // tfPassword
            // 
            this.tfPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tfPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfPassword.Location = new System.Drawing.Point(842, 527);
            this.tfPassword.Name = "tfPassword";
            this.tfPassword.PasswordChar = '*';
            this.tfPassword.Size = new System.Drawing.Size(358, 31);
            this.tfPassword.TabIndex = 1;
            // 
            // btnMasuk
            // 
            this.btnMasuk.BackColor = System.Drawing.SystemColors.Window;
            this.btnMasuk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMasuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasuk.ForeColor = System.Drawing.Color.Transparent;
            this.btnMasuk.Location = new System.Drawing.Point(824, 624);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(392, 75);
            this.btnMasuk.TabIndex = 2;
            this.btnMasuk.UseMnemonic = false;
            this.btnMasuk.UseVisualStyleBackColor = false;
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1440, 1024);
            this.ControlBox = false;
            this.Controls.Add(this.tfPassword);
            this.Controls.Add(this.tfUsername);
            this.Controls.Add(this.btnMasuk);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Karaoke PopRock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tfUsername;
        private System.Windows.Forms.TextBox tfPassword;
        private System.Windows.Forms.Button btnMasuk;
    }
}

