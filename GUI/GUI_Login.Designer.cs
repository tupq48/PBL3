namespace GUI
{
    partial class GUI_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Login));
            this.txttk = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(219, 220);
            this.txttk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttk.Name = "txttk";
            this.txttk.PlaceholderText = "username";
            this.txttk.Size = new System.Drawing.Size(261, 27);
            this.txttk.TabIndex = 0;
            this.txttk.TextChanged += new System.EventHandler(this.txttk_TextChanged);
            this.txttk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttk_KeyDown);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(219, 269);
            this.txtmk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.PlaceholderText = "password";
            this.txtmk.Size = new System.Drawing.Size(261, 27);
            this.txtmk.TabIndex = 1;
            this.txtmk.TextChanged += new System.EventHandler(this.txtmk_TextChanged);
            this.txtmk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmk_KeyPress);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.LightCoral;
            this.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlogin.Location = new System.Drawing.Point(291, 305);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(117, 36);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // GUI_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 413);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "GUI_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cửa Hàng Thú Cưng";
            this.Load += new System.EventHandler(this.GUI_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txttk;
        private TextBox txtmk;
        private Button btnlogin;
    }
}