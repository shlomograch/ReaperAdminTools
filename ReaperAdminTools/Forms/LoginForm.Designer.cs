namespace ReaperAdminTools
{
    partial class LoginForm
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
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stealthMode = new System.Windows.Forms.CheckBox();
            this.forceClientUpdate = new System.Windows.Forms.CheckBox();
            this.serverInformation = new System.Windows.Forms.CheckBox();
            this.compensation = new System.Windows.Forms.CheckBox();
            this.superAdminOptions = new System.Windows.Forms.CheckBox();
            this.clearFormBtn = new System.Windows.Forms.Button();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.reaperLogo = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.currentVersionToolStripLbl = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reaperLogo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Location = new System.Drawing.Point(72, 191);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(182, 20);
            this.userNameTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.Location = new System.Drawing.Point(72, 244);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(101, 17);
            this.rememberMeCheckBox.TabIndex = 2;
            this.rememberMeCheckBox.Text = "Remember Me?";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(179, 240);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stealthMode);
            this.groupBox1.Controls.Add(this.forceClientUpdate);
            this.groupBox1.Controls.Add(this.serverInformation);
            this.groupBox1.Controls.Add(this.compensation);
            this.groupBox1.Controls.Add(this.superAdminOptions);
            this.groupBox1.Location = new System.Drawing.Point(260, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 134);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Launch Parameters";
            // 
            // stealthMode
            // 
            this.stealthMode.AutoSize = true;
            this.stealthMode.Location = new System.Drawing.Point(4, 113);
            this.stealthMode.Name = "stealthMode";
            this.stealthMode.Size = new System.Drawing.Size(123, 17);
            this.stealthMode.TabIndex = 4;
            this.stealthMode.Text = "Run in Stealth Mode";
            this.stealthMode.UseVisualStyleBackColor = true;
            // 
            // forceClientUpdate
            // 
            this.forceClientUpdate.AutoSize = true;
            this.forceClientUpdate.Location = new System.Drawing.Point(5, 90);
            this.forceClientUpdate.Name = "forceClientUpdate";
            this.forceClientUpdate.Size = new System.Drawing.Size(120, 17);
            this.forceClientUpdate.TabIndex = 3;
            this.forceClientUpdate.Text = "Force Client Update";
            this.forceClientUpdate.UseVisualStyleBackColor = true;
            // 
            // serverInformation
            // 
            this.serverInformation.AutoSize = true;
            this.serverInformation.Location = new System.Drawing.Point(4, 67);
            this.serverInformation.Name = "serverInformation";
            this.serverInformation.Size = new System.Drawing.Size(112, 17);
            this.serverInformation.TabIndex = 2;
            this.serverInformation.Text = "Server Information";
            this.serverInformation.UseVisualStyleBackColor = true;
            // 
            // compensation
            // 
            this.compensation.AutoSize = true;
            this.compensation.Location = new System.Drawing.Point(5, 44);
            this.compensation.Name = "compensation";
            this.compensation.Size = new System.Drawing.Size(93, 17);
            this.compensation.TabIndex = 1;
            this.compensation.Text = "Compensation";
            this.compensation.UseVisualStyleBackColor = true;
            // 
            // superAdminOptions
            // 
            this.superAdminOptions.AutoSize = true;
            this.superAdminOptions.Checked = true;
            this.superAdminOptions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.superAdminOptions.Location = new System.Drawing.Point(5, 20);
            this.superAdminOptions.Name = "superAdminOptions";
            this.superAdminOptions.Size = new System.Drawing.Size(125, 17);
            this.superAdminOptions.TabIndex = 0;
            this.superAdminOptions.Text = "Super Admin Options";
            this.superAdminOptions.UseVisualStyleBackColor = true;
            // 
            // clearFormBtn
            // 
            this.clearFormBtn.Location = new System.Drawing.Point(179, 268);
            this.clearFormBtn.Name = "clearFormBtn";
            this.clearFormBtn.Size = new System.Drawing.Size(75, 23);
            this.clearFormBtn.TabIndex = 4;
            this.clearFormBtn.Text = "Clear Form";
            this.clearFormBtn.UseVisualStyleBackColor = true;
            this.clearFormBtn.Click += new System.EventHandler(this.clearFormBtn_Click);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(72, 218);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(182, 20);
            this.passwordTxtBox.TabIndex = 1;
            // 
            // reaperLogo
            // 
            this.reaperLogo.Image = global::ReaperAdminTools.Properties.Resources.logo;
            this.reaperLogo.Location = new System.Drawing.Point(12, 12);
            this.reaperLogo.Name = "reaperLogo";
            this.reaperLogo.Size = new System.Drawing.Size(379, 165);
            this.reaperLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reaperLogo.TabIndex = 0;
            this.reaperLogo.TabStop = false;
            this.reaperLogo.Click += new System.EventHandler(this.reaperLogo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentVersionToolStripLbl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 319);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(403, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // currentVersionToolStripLbl
            // 
            this.currentVersionToolStripLbl.Name = "currentVersionToolStripLbl";
            this.currentVersionToolStripLbl.Size = new System.Drawing.Size(95, 22);
            this.currentVersionToolStripLbl.Text = "Current Version: ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 344);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearFormBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.rememberMeCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.reaperLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reaper Gaming Network";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reaperLogo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox reaperLogo;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox forceClientUpdate;
        private System.Windows.Forms.CheckBox serverInformation;
        private System.Windows.Forms.CheckBox compensation;
        private System.Windows.Forms.CheckBox superAdminOptions;
        private System.Windows.Forms.Button clearFormBtn;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.CheckBox stealthMode;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel currentVersionToolStripLbl;
    }
}