
namespace 新悦管理系统
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiButton_login = new Sunny.UI.UIButton();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiTextBox_pwd = new Sunny.UI.UITextBox();
            this.uiTextBox_name = new Sunny.UI.UITextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.uiGroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uiGroupBox1.Controls.Add(this.uiButton_login);
            this.uiGroupBox1.Controls.Add(this.uiAvatar1);
            this.uiGroupBox1.Controls.Add(this.uiTextBox_pwd);
            this.uiGroupBox1.Controls.Add(this.uiTextBox_name);
            this.uiGroupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiGroupBox1.FillColor = System.Drawing.Color.White;
            this.uiGroupBox1.FillColor2 = System.Drawing.Color.White;
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.ForeColor = System.Drawing.Color.Silver;
            this.uiGroupBox1.Location = new System.Drawing.Point(310, 47);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Radius = 10;
            this.uiGroupBox1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiGroupBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.uiGroupBox1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiGroupBox1.Size = new System.Drawing.Size(289, 364);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox1.StyleCustomMode = true;
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.TabStop = false;
            this.uiGroupBox1.Text = null;
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiButton_login
            // 
            this.uiButton_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_login.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton_login.Location = new System.Drawing.Point(39, 299);
            this.uiButton_login.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_login.Name = "uiButton_login";
            this.uiButton_login.Radius = 15;
            this.uiButton_login.Size = new System.Drawing.Size(229, 29);
            this.uiButton_login.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton_login.TabIndex = 4;
            this.uiButton_login.Text = "Login";
            this.uiButton_login.TipsFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton_login.Click += new System.EventHandler(this.uiButton_login_Click);
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.BackColor = System.Drawing.Color.White;
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.Location = new System.Drawing.Point(105, 35);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(97, 96);
            this.uiAvatar1.StyleCustomMode = true;
            this.uiAvatar1.SymbolSize = 50;
            this.uiAvatar1.TabIndex = 3;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            // uiTextBox_pwd
            // 
            this.uiTextBox_pwd.ButtonSymbolOffset = new System.Drawing.Point(0, 1);
            this.uiTextBox_pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_pwd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiTextBox_pwd.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiTextBox_pwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_pwd.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(103)))));
            this.uiTextBox_pwd.Icon = ((System.Drawing.Image)(resources.GetObject("uiTextBox_pwd.Icon")));
            this.uiTextBox_pwd.Location = new System.Drawing.Point(39, 237);
            this.uiTextBox_pwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_pwd.Maximum = 2147483647D;
            this.uiTextBox_pwd.Minimum = -2147483648D;
            this.uiTextBox_pwd.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_pwd.Name = "uiTextBox_pwd";
            this.uiTextBox_pwd.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.uiTextBox_pwd.PasswordChar = '*';
            this.uiTextBox_pwd.Radius = 15;
            this.uiTextBox_pwd.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.uiTextBox_pwd.Size = new System.Drawing.Size(229, 29);
            this.uiTextBox_pwd.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox_pwd.TabIndex = 2;
            this.uiTextBox_pwd.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.uiTextBox_pwd.Watermark = "Password";
            this.uiTextBox_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uiTextBox_pwd_KeyPress);
            // 
            // uiTextBox_name
            // 
            this.uiTextBox_name.ButtonSymbolOffset = new System.Drawing.Point(0, 1);
            this.uiTextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_name.DoubleValue = 1001D;
            this.uiTextBox_name.EnterAsTab = true;
            this.uiTextBox_name.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiTextBox_name.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiTextBox_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_name.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(103)))));
            this.uiTextBox_name.Icon = ((System.Drawing.Image)(resources.GetObject("uiTextBox_name.Icon")));
            this.uiTextBox_name.IntValue = 1001;
            this.uiTextBox_name.Location = new System.Drawing.Point(39, 175);
            this.uiTextBox_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_name.Maximum = 2147483647D;
            this.uiTextBox_name.Minimum = -2147483648D;
            this.uiTextBox_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_name.Name = "uiTextBox_name";
            this.uiTextBox_name.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.uiTextBox_name.Radius = 15;
            this.uiTextBox_name.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.uiTextBox_name.Size = new System.Drawing.Size(229, 29);
            this.uiTextBox_name.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox_name.TabIndex = 1;
            this.uiTextBox_name.Text = "1001";
            this.uiTextBox_name.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.uiTextBox_name.Watermark = "UserName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 364);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AllowAddControlOnTitle = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(620, 440);
            this.ControlBoxCloseFillHoverColor = System.Drawing.Color.Salmon;
            this.ControlBoxFillHoverColor = System.Drawing.SystemColors.Control;
            this.ControlBoxForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiGroupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.RectColor = System.Drawing.SystemColors.Control;
            this.ShowIcon = false;
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "login";
            this.TitleColor = System.Drawing.SystemColors.Control;
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UITextBox uiTextBox_pwd;
        private Sunny.UI.UITextBox uiTextBox_name;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIButton uiButton_login;
    }
}

