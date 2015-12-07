namespace ReaperAdminTools
{
    partial class SuperAdminOptions
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addAnAdminTab = new System.Windows.Forms.TabPage();
            this.whiteListGroupBox = new System.Windows.Forms.GroupBox();
            this.whiteListMedicalOfficers = new System.Windows.Forms.CheckBox();
            this.whiteListPoliceOfficer = new System.Windows.Forms.CheckBox();
            this.restrictionsGroupBox = new System.Windows.Forms.GroupBox();
            this.restrictSuperAdmin = new System.Windows.Forms.CheckBox();
            this.restrictMarquee = new System.Windows.Forms.CheckBox();
            this.restrictGarageView = new System.Windows.Forms.CheckBox();
            this.restrictGarageComp = new System.Windows.Forms.CheckBox();
            this.restrictWhitelisting = new System.Windows.Forms.CheckBox();
            this.restrictCompensation = new System.Windows.Forms.CheckBox();
            this.restrictBanning = new System.Windows.Forms.CheckBox();
            this.restrictKicking = new System.Windows.Forms.CheckBox();
            this.addAnAdminClearFieldsBtn = new System.Windows.Forms.Button();
            this.addAnAdminBtn = new System.Windows.Forms.Button();
            this.addAnAdminPassword = new System.Windows.Forms.TextBox();
            this.addAnAdminUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modifyAnAdminTab = new System.Windows.Forms.TabPage();
            this.clearModifyUserFields = new System.Windows.Forms.Button();
            this.modifyWhiteListGroupBox = new System.Windows.Forms.GroupBox();
            this.modifyUserCanWhitelistMed = new System.Windows.Forms.CheckBox();
            this.modifyUserCanWhitelistCop = new System.Windows.Forms.CheckBox();
            this.modifyRestrictionsGroupBox = new System.Windows.Forms.GroupBox();
            this.modifySuperAdmin = new System.Windows.Forms.CheckBox();
            this.modifyMarquee = new System.Windows.Forms.CheckBox();
            this.modifyRestrictGarageView = new System.Windows.Forms.CheckBox();
            this.modifyRestrictGarageComp = new System.Windows.Forms.CheckBox();
            this.modifyRestrictWhitelisting = new System.Windows.Forms.CheckBox();
            this.modifyRestrictCompensation = new System.Windows.Forms.CheckBox();
            this.modifyRestrictBanning = new System.Windows.Forms.CheckBox();
            this.modifyRestrictKicking = new System.Windows.Forms.CheckBox();
            this.modifyAnAdminModifyBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.modifyAnAdminUsername = new System.Windows.Forms.ComboBox();
            this.removeAnAdminTab = new System.Windows.Forms.TabPage();
            this.removeAnAdminRemoveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.removeAnAdminUsername = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.setAnnouncmentText = new System.Windows.Forms.Button();
            this.announcmentText = new System.Windows.Forms.TextBox();
            this.expellAllAdmins = new System.Windows.Forms.Button();
            this.startPassowrdHasher = new System.Windows.Forms.Button();
            this.openLogsBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.addAnAdminTab.SuspendLayout();
            this.whiteListGroupBox.SuspendLayout();
            this.restrictionsGroupBox.SuspendLayout();
            this.modifyAnAdminTab.SuspendLayout();
            this.modifyWhiteListGroupBox.SuspendLayout();
            this.modifyRestrictionsGroupBox.SuspendLayout();
            this.removeAnAdminTab.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addAnAdminTab);
            this.tabControl1.Controls.Add(this.modifyAnAdminTab);
            this.tabControl1.Controls.Add(this.removeAnAdminTab);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(329, 301);
            this.tabControl1.TabIndex = 0;
            // 
            // addAnAdminTab
            // 
            this.addAnAdminTab.Controls.Add(this.whiteListGroupBox);
            this.addAnAdminTab.Controls.Add(this.restrictionsGroupBox);
            this.addAnAdminTab.Controls.Add(this.addAnAdminClearFieldsBtn);
            this.addAnAdminTab.Controls.Add(this.addAnAdminBtn);
            this.addAnAdminTab.Controls.Add(this.addAnAdminPassword);
            this.addAnAdminTab.Controls.Add(this.addAnAdminUserName);
            this.addAnAdminTab.Controls.Add(this.label2);
            this.addAnAdminTab.Controls.Add(this.label1);
            this.addAnAdminTab.Location = new System.Drawing.Point(4, 22);
            this.addAnAdminTab.Name = "addAnAdminTab";
            this.addAnAdminTab.Padding = new System.Windows.Forms.Padding(3);
            this.addAnAdminTab.Size = new System.Drawing.Size(321, 275);
            this.addAnAdminTab.TabIndex = 0;
            this.addAnAdminTab.Text = "Add a User";
            this.addAnAdminTab.UseVisualStyleBackColor = true;
            // 
            // whiteListGroupBox
            // 
            this.whiteListGroupBox.Controls.Add(this.whiteListMedicalOfficers);
            this.whiteListGroupBox.Controls.Add(this.whiteListPoliceOfficer);
            this.whiteListGroupBox.Location = new System.Drawing.Point(6, 72);
            this.whiteListGroupBox.Name = "whiteListGroupBox";
            this.whiteListGroupBox.Size = new System.Drawing.Size(303, 74);
            this.whiteListGroupBox.TabIndex = 2;
            this.whiteListGroupBox.TabStop = false;
            this.whiteListGroupBox.Text = "White list Controls";
            // 
            // whiteListMedicalOfficers
            // 
            this.whiteListMedicalOfficers.AutoSize = true;
            this.whiteListMedicalOfficers.Location = new System.Drawing.Point(7, 42);
            this.whiteListMedicalOfficers.Name = "whiteListMedicalOfficers";
            this.whiteListMedicalOfficers.Size = new System.Drawing.Size(164, 17);
            this.whiteListMedicalOfficers.TabIndex = 1;
            this.whiteListMedicalOfficers.Text = "Can whitelist Medical Officers";
            this.whiteListMedicalOfficers.UseVisualStyleBackColor = true;
            // 
            // whiteListPoliceOfficer
            // 
            this.whiteListPoliceOfficer.AutoSize = true;
            this.whiteListPoliceOfficer.Location = new System.Drawing.Point(7, 19);
            this.whiteListPoliceOfficer.Name = "whiteListPoliceOfficer";
            this.whiteListPoliceOfficer.Size = new System.Drawing.Size(159, 17);
            this.whiteListPoliceOfficer.TabIndex = 0;
            this.whiteListPoliceOfficer.Text = "Can Whitelist Police Officers";
            this.whiteListPoliceOfficer.UseVisualStyleBackColor = true;
            // 
            // restrictionsGroupBox
            // 
            this.restrictionsGroupBox.Controls.Add(this.restrictSuperAdmin);
            this.restrictionsGroupBox.Controls.Add(this.restrictMarquee);
            this.restrictionsGroupBox.Controls.Add(this.restrictGarageView);
            this.restrictionsGroupBox.Controls.Add(this.restrictGarageComp);
            this.restrictionsGroupBox.Controls.Add(this.restrictWhitelisting);
            this.restrictionsGroupBox.Controls.Add(this.restrictCompensation);
            this.restrictionsGroupBox.Controls.Add(this.restrictBanning);
            this.restrictionsGroupBox.Controls.Add(this.restrictKicking);
            this.restrictionsGroupBox.Location = new System.Drawing.Point(6, 152);
            this.restrictionsGroupBox.Name = "restrictionsGroupBox";
            this.restrictionsGroupBox.Size = new System.Drawing.Size(303, 117);
            this.restrictionsGroupBox.TabIndex = 3;
            this.restrictionsGroupBox.TabStop = false;
            this.restrictionsGroupBox.Text = "Restrictions";
            // 
            // restrictSuperAdmin
            // 
            this.restrictSuperAdmin.AutoSize = true;
            this.restrictSuperAdmin.Location = new System.Drawing.Point(144, 88);
            this.restrictSuperAdmin.Name = "restrictSuperAdmin";
            this.restrictSuperAdmin.Size = new System.Drawing.Size(121, 17);
            this.restrictSuperAdmin.TabIndex = 7;
            this.restrictSuperAdmin.Text = "User is Super Admin";
            this.restrictSuperAdmin.UseVisualStyleBackColor = true;
            // 
            // restrictMarquee
            // 
            this.restrictMarquee.AutoSize = true;
            this.restrictMarquee.Location = new System.Drawing.Point(144, 65);
            this.restrictMarquee.Name = "restrictMarquee";
            this.restrictMarquee.Size = new System.Drawing.Size(110, 17);
            this.restrictMarquee.TabIndex = 6;
            this.restrictMarquee.Text = "Can use Marquee";
            this.restrictMarquee.UseVisualStyleBackColor = true;
            // 
            // restrictGarageView
            // 
            this.restrictGarageView.AutoSize = true;
            this.restrictGarageView.Location = new System.Drawing.Point(144, 19);
            this.restrictGarageView.Name = "restrictGarageView";
            this.restrictGarageView.Size = new System.Drawing.Size(126, 17);
            this.restrictGarageView.TabIndex = 4;
            this.restrictGarageView.Text = "Restrict Garage View";
            this.restrictGarageView.UseVisualStyleBackColor = true;
            // 
            // restrictGarageComp
            // 
            this.restrictGarageComp.AutoSize = true;
            this.restrictGarageComp.Location = new System.Drawing.Point(144, 42);
            this.restrictGarageComp.Name = "restrictGarageComp";
            this.restrictGarageComp.Size = new System.Drawing.Size(130, 17);
            this.restrictGarageComp.TabIndex = 5;
            this.restrictGarageComp.Text = "Restrict Garage Comp";
            this.restrictGarageComp.UseVisualStyleBackColor = true;
            // 
            // restrictWhitelisting
            // 
            this.restrictWhitelisting.AutoSize = true;
            this.restrictWhitelisting.Location = new System.Drawing.Point(6, 88);
            this.restrictWhitelisting.Name = "restrictWhitelisting";
            this.restrictWhitelisting.Size = new System.Drawing.Size(119, 17);
            this.restrictWhitelisting.TabIndex = 3;
            this.restrictWhitelisting.Text = "Restrict Whitelisting";
            this.restrictWhitelisting.UseVisualStyleBackColor = true;
            // 
            // restrictCompensation
            // 
            this.restrictCompensation.AutoSize = true;
            this.restrictCompensation.Location = new System.Drawing.Point(6, 65);
            this.restrictCompensation.Name = "restrictCompensation";
            this.restrictCompensation.Size = new System.Drawing.Size(132, 17);
            this.restrictCompensation.TabIndex = 2;
            this.restrictCompensation.Text = "Restrict Compensation";
            this.restrictCompensation.UseVisualStyleBackColor = true;
            // 
            // restrictBanning
            // 
            this.restrictBanning.AutoSize = true;
            this.restrictBanning.Location = new System.Drawing.Point(6, 42);
            this.restrictBanning.Name = "restrictBanning";
            this.restrictBanning.Size = new System.Drawing.Size(104, 17);
            this.restrictBanning.TabIndex = 1;
            this.restrictBanning.Text = "Restrict Banning";
            this.restrictBanning.UseVisualStyleBackColor = true;
            // 
            // restrictKicking
            // 
            this.restrictKicking.AutoSize = true;
            this.restrictKicking.Location = new System.Drawing.Point(6, 19);
            this.restrictKicking.Name = "restrictKicking";
            this.restrictKicking.Size = new System.Drawing.Size(100, 17);
            this.restrictKicking.TabIndex = 0;
            this.restrictKicking.Text = "Restrict Kicking";
            this.restrictKicking.UseVisualStyleBackColor = true;
            // 
            // addAnAdminClearFieldsBtn
            // 
            this.addAnAdminClearFieldsBtn.Location = new System.Drawing.Point(234, 40);
            this.addAnAdminClearFieldsBtn.Name = "addAnAdminClearFieldsBtn";
            this.addAnAdminClearFieldsBtn.Size = new System.Drawing.Size(75, 23);
            this.addAnAdminClearFieldsBtn.TabIndex = 5;
            this.addAnAdminClearFieldsBtn.Text = "Clear Fields";
            this.addAnAdminClearFieldsBtn.UseVisualStyleBackColor = true;
            this.addAnAdminClearFieldsBtn.Click += new System.EventHandler(this.addAnAdminClearFieldsBtn_Click);
            // 
            // addAnAdminBtn
            // 
            this.addAnAdminBtn.Location = new System.Drawing.Point(234, 14);
            this.addAnAdminBtn.Name = "addAnAdminBtn";
            this.addAnAdminBtn.Size = new System.Drawing.Size(75, 23);
            this.addAnAdminBtn.TabIndex = 4;
            this.addAnAdminBtn.Text = "Add";
            this.addAnAdminBtn.UseVisualStyleBackColor = true;
            this.addAnAdminBtn.Click += new System.EventHandler(this.addAnAdminBtn_Click);
            // 
            // addAnAdminPassword
            // 
            this.addAnAdminPassword.Location = new System.Drawing.Point(72, 42);
            this.addAnAdminPassword.Name = "addAnAdminPassword";
            this.addAnAdminPassword.Size = new System.Drawing.Size(156, 20);
            this.addAnAdminPassword.TabIndex = 1;
            // 
            // addAnAdminUserName
            // 
            this.addAnAdminUserName.Location = new System.Drawing.Point(72, 16);
            this.addAnAdminUserName.Name = "addAnAdminUserName";
            this.addAnAdminUserName.Size = new System.Drawing.Size(156, 20);
            this.addAnAdminUserName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // modifyAnAdminTab
            // 
            this.modifyAnAdminTab.Controls.Add(this.clearModifyUserFields);
            this.modifyAnAdminTab.Controls.Add(this.modifyWhiteListGroupBox);
            this.modifyAnAdminTab.Controls.Add(this.modifyRestrictionsGroupBox);
            this.modifyAnAdminTab.Controls.Add(this.modifyAnAdminModifyBtn);
            this.modifyAnAdminTab.Controls.Add(this.label4);
            this.modifyAnAdminTab.Controls.Add(this.modifyAnAdminUsername);
            this.modifyAnAdminTab.Location = new System.Drawing.Point(4, 22);
            this.modifyAnAdminTab.Name = "modifyAnAdminTab";
            this.modifyAnAdminTab.Padding = new System.Windows.Forms.Padding(3);
            this.modifyAnAdminTab.Size = new System.Drawing.Size(321, 275);
            this.modifyAnAdminTab.TabIndex = 1;
            this.modifyAnAdminTab.Text = "Modify a User";
            this.modifyAnAdminTab.UseVisualStyleBackColor = true;
            // 
            // clearModifyUserFields
            // 
            this.clearModifyUserFields.Location = new System.Drawing.Point(234, 43);
            this.clearModifyUserFields.Name = "clearModifyUserFields";
            this.clearModifyUserFields.Size = new System.Drawing.Size(75, 23);
            this.clearModifyUserFields.TabIndex = 4;
            this.clearModifyUserFields.Text = "Clear Fields";
            this.clearModifyUserFields.UseVisualStyleBackColor = true;
            this.clearModifyUserFields.Click += new System.EventHandler(this.clearModifyUserFields_Click);
            // 
            // modifyWhiteListGroupBox
            // 
            this.modifyWhiteListGroupBox.Controls.Add(this.modifyUserCanWhitelistMed);
            this.modifyWhiteListGroupBox.Controls.Add(this.modifyUserCanWhitelistCop);
            this.modifyWhiteListGroupBox.Location = new System.Drawing.Point(6, 72);
            this.modifyWhiteListGroupBox.Name = "modifyWhiteListGroupBox";
            this.modifyWhiteListGroupBox.Size = new System.Drawing.Size(303, 74);
            this.modifyWhiteListGroupBox.TabIndex = 1;
            this.modifyWhiteListGroupBox.TabStop = false;
            this.modifyWhiteListGroupBox.Text = "White list Controls";
            // 
            // modifyUserCanWhitelistMed
            // 
            this.modifyUserCanWhitelistMed.AutoSize = true;
            this.modifyUserCanWhitelistMed.Location = new System.Drawing.Point(7, 42);
            this.modifyUserCanWhitelistMed.Name = "modifyUserCanWhitelistMed";
            this.modifyUserCanWhitelistMed.Size = new System.Drawing.Size(164, 17);
            this.modifyUserCanWhitelistMed.TabIndex = 1;
            this.modifyUserCanWhitelistMed.Text = "Can whitelist Medical Officers";
            this.modifyUserCanWhitelistMed.UseVisualStyleBackColor = true;
            // 
            // modifyUserCanWhitelistCop
            // 
            this.modifyUserCanWhitelistCop.AutoSize = true;
            this.modifyUserCanWhitelistCop.Location = new System.Drawing.Point(7, 19);
            this.modifyUserCanWhitelistCop.Name = "modifyUserCanWhitelistCop";
            this.modifyUserCanWhitelistCop.Size = new System.Drawing.Size(159, 17);
            this.modifyUserCanWhitelistCop.TabIndex = 0;
            this.modifyUserCanWhitelistCop.Text = "Can Whitelist Police Officers";
            this.modifyUserCanWhitelistCop.UseVisualStyleBackColor = true;
            // 
            // modifyRestrictionsGroupBox
            // 
            this.modifyRestrictionsGroupBox.Controls.Add(this.modifySuperAdmin);
            this.modifyRestrictionsGroupBox.Controls.Add(this.modifyMarquee);
            this.modifyRestrictionsGroupBox.Controls.Add(this.modifyRestrictGarageView);
            this.modifyRestrictionsGroupBox.Controls.Add(this.modifyRestrictGarageComp);
            this.modifyRestrictionsGroupBox.Controls.Add(this.modifyRestrictWhitelisting);
            this.modifyRestrictionsGroupBox.Controls.Add(this.modifyRestrictCompensation);
            this.modifyRestrictionsGroupBox.Controls.Add(this.modifyRestrictBanning);
            this.modifyRestrictionsGroupBox.Controls.Add(this.modifyRestrictKicking);
            this.modifyRestrictionsGroupBox.Location = new System.Drawing.Point(6, 152);
            this.modifyRestrictionsGroupBox.Name = "modifyRestrictionsGroupBox";
            this.modifyRestrictionsGroupBox.Size = new System.Drawing.Size(303, 117);
            this.modifyRestrictionsGroupBox.TabIndex = 2;
            this.modifyRestrictionsGroupBox.TabStop = false;
            this.modifyRestrictionsGroupBox.Text = "Restrictions";
            // 
            // modifySuperAdmin
            // 
            this.modifySuperAdmin.AutoSize = true;
            this.modifySuperAdmin.Location = new System.Drawing.Point(144, 88);
            this.modifySuperAdmin.Name = "modifySuperAdmin";
            this.modifySuperAdmin.Size = new System.Drawing.Size(121, 17);
            this.modifySuperAdmin.TabIndex = 7;
            this.modifySuperAdmin.Text = "User is Super Admin";
            this.modifySuperAdmin.UseVisualStyleBackColor = true;
            // 
            // modifyMarquee
            // 
            this.modifyMarquee.AutoSize = true;
            this.modifyMarquee.Location = new System.Drawing.Point(144, 65);
            this.modifyMarquee.Name = "modifyMarquee";
            this.modifyMarquee.Size = new System.Drawing.Size(110, 17);
            this.modifyMarquee.TabIndex = 6;
            this.modifyMarquee.Text = "Can use Marquee";
            this.modifyMarquee.UseVisualStyleBackColor = true;
            // 
            // modifyRestrictGarageView
            // 
            this.modifyRestrictGarageView.AutoSize = true;
            this.modifyRestrictGarageView.Location = new System.Drawing.Point(144, 19);
            this.modifyRestrictGarageView.Name = "modifyRestrictGarageView";
            this.modifyRestrictGarageView.Size = new System.Drawing.Size(126, 17);
            this.modifyRestrictGarageView.TabIndex = 4;
            this.modifyRestrictGarageView.Text = "Restrict Garage View";
            this.modifyRestrictGarageView.UseVisualStyleBackColor = true;
            // 
            // modifyRestrictGarageComp
            // 
            this.modifyRestrictGarageComp.AutoSize = true;
            this.modifyRestrictGarageComp.Location = new System.Drawing.Point(144, 42);
            this.modifyRestrictGarageComp.Name = "modifyRestrictGarageComp";
            this.modifyRestrictGarageComp.Size = new System.Drawing.Size(130, 17);
            this.modifyRestrictGarageComp.TabIndex = 5;
            this.modifyRestrictGarageComp.Text = "Restrict Garage Comp";
            this.modifyRestrictGarageComp.UseVisualStyleBackColor = true;
            // 
            // modifyRestrictWhitelisting
            // 
            this.modifyRestrictWhitelisting.AutoSize = true;
            this.modifyRestrictWhitelisting.Location = new System.Drawing.Point(6, 88);
            this.modifyRestrictWhitelisting.Name = "modifyRestrictWhitelisting";
            this.modifyRestrictWhitelisting.Size = new System.Drawing.Size(119, 17);
            this.modifyRestrictWhitelisting.TabIndex = 3;
            this.modifyRestrictWhitelisting.Text = "Restrict Whitelisting";
            this.modifyRestrictWhitelisting.UseVisualStyleBackColor = true;
            // 
            // modifyRestrictCompensation
            // 
            this.modifyRestrictCompensation.AutoSize = true;
            this.modifyRestrictCompensation.Location = new System.Drawing.Point(6, 65);
            this.modifyRestrictCompensation.Name = "modifyRestrictCompensation";
            this.modifyRestrictCompensation.Size = new System.Drawing.Size(132, 17);
            this.modifyRestrictCompensation.TabIndex = 2;
            this.modifyRestrictCompensation.Text = "Restrict Compensation";
            this.modifyRestrictCompensation.UseVisualStyleBackColor = true;
            // 
            // modifyRestrictBanning
            // 
            this.modifyRestrictBanning.AutoSize = true;
            this.modifyRestrictBanning.Location = new System.Drawing.Point(6, 42);
            this.modifyRestrictBanning.Name = "modifyRestrictBanning";
            this.modifyRestrictBanning.Size = new System.Drawing.Size(104, 17);
            this.modifyRestrictBanning.TabIndex = 1;
            this.modifyRestrictBanning.Text = "Restrict Banning";
            this.modifyRestrictBanning.UseVisualStyleBackColor = true;
            // 
            // modifyRestrictKicking
            // 
            this.modifyRestrictKicking.AutoSize = true;
            this.modifyRestrictKicking.Location = new System.Drawing.Point(6, 19);
            this.modifyRestrictKicking.Name = "modifyRestrictKicking";
            this.modifyRestrictKicking.Size = new System.Drawing.Size(100, 17);
            this.modifyRestrictKicking.TabIndex = 0;
            this.modifyRestrictKicking.Text = "Restrict Kicking";
            this.modifyRestrictKicking.UseVisualStyleBackColor = true;
            // 
            // modifyAnAdminModifyBtn
            // 
            this.modifyAnAdminModifyBtn.Location = new System.Drawing.Point(234, 14);
            this.modifyAnAdminModifyBtn.Name = "modifyAnAdminModifyBtn";
            this.modifyAnAdminModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.modifyAnAdminModifyBtn.TabIndex = 3;
            this.modifyAnAdminModifyBtn.Text = "Modify";
            this.modifyAnAdminModifyBtn.UseVisualStyleBackColor = true;
            this.modifyAnAdminModifyBtn.Click += new System.EventHandler(this.modifyAnAdminModifyBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // modifyAnAdminUsername
            // 
            this.modifyAnAdminUsername.FormattingEnabled = true;
            this.modifyAnAdminUsername.Location = new System.Drawing.Point(70, 16);
            this.modifyAnAdminUsername.Name = "modifyAnAdminUsername";
            this.modifyAnAdminUsername.Size = new System.Drawing.Size(158, 21);
            this.modifyAnAdminUsername.TabIndex = 0;
            this.modifyAnAdminUsername.SelectedIndexChanged += new System.EventHandler(this.modifyAnAdminUsername_SelectedIndexChanged);
            // 
            // removeAnAdminTab
            // 
            this.removeAnAdminTab.Controls.Add(this.removeAnAdminRemoveBtn);
            this.removeAnAdminTab.Controls.Add(this.label3);
            this.removeAnAdminTab.Controls.Add(this.removeAnAdminUsername);
            this.removeAnAdminTab.Location = new System.Drawing.Point(4, 22);
            this.removeAnAdminTab.Name = "removeAnAdminTab";
            this.removeAnAdminTab.Padding = new System.Windows.Forms.Padding(3);
            this.removeAnAdminTab.Size = new System.Drawing.Size(321, 275);
            this.removeAnAdminTab.TabIndex = 2;
            this.removeAnAdminTab.Text = "Remove a User";
            this.removeAnAdminTab.UseVisualStyleBackColor = true;
            // 
            // removeAnAdminRemoveBtn
            // 
            this.removeAnAdminRemoveBtn.Location = new System.Drawing.Point(233, 14);
            this.removeAnAdminRemoveBtn.Name = "removeAnAdminRemoveBtn";
            this.removeAnAdminRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.removeAnAdminRemoveBtn.TabIndex = 1;
            this.removeAnAdminRemoveBtn.Text = "Remove";
            this.removeAnAdminRemoveBtn.UseVisualStyleBackColor = true;
            this.removeAnAdminRemoveBtn.Click += new System.EventHandler(this.removeAnAdminRemoveBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // removeAnAdminUsername
            // 
            this.removeAnAdminUsername.FormattingEnabled = true;
            this.removeAnAdminUsername.Location = new System.Drawing.Point(70, 16);
            this.removeAnAdminUsername.Name = "removeAnAdminUsername";
            this.removeAnAdminUsername.Size = new System.Drawing.Size(157, 21);
            this.removeAnAdminUsername.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.setAnnouncmentText);
            this.tabPage4.Controls.Add(this.announcmentText);
            this.tabPage4.Controls.Add(this.expellAllAdmins);
            this.tabPage4.Controls.Add(this.startPassowrdHasher);
            this.tabPage4.Controls.Add(this.openLogsBtn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(321, 275);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Extra Options";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // setAnnouncmentText
            // 
            this.setAnnouncmentText.Location = new System.Drawing.Point(67, 32);
            this.setAnnouncmentText.Name = "setAnnouncmentText";
            this.setAnnouncmentText.Size = new System.Drawing.Size(198, 23);
            this.setAnnouncmentText.TabIndex = 1;
            this.setAnnouncmentText.Text = "Click to Set Announcment";
            this.setAnnouncmentText.UseVisualStyleBackColor = true;
            // 
            // announcmentText
            // 
            this.announcmentText.Location = new System.Drawing.Point(6, 6);
            this.announcmentText.Name = "announcmentText";
            this.announcmentText.Size = new System.Drawing.Size(309, 20);
            this.announcmentText.TabIndex = 0;
            // 
            // expellAllAdmins
            // 
            this.expellAllAdmins.Location = new System.Drawing.Point(67, 119);
            this.expellAllAdmins.Name = "expellAllAdmins";
            this.expellAllAdmins.Size = new System.Drawing.Size(198, 23);
            this.expellAllAdmins.TabIndex = 4;
            this.expellAllAdmins.Text = "Force log out all admins";
            this.expellAllAdmins.UseVisualStyleBackColor = true;
            // 
            // startPassowrdHasher
            // 
            this.startPassowrdHasher.Location = new System.Drawing.Point(67, 90);
            this.startPassowrdHasher.Name = "startPassowrdHasher";
            this.startPassowrdHasher.Size = new System.Drawing.Size(198, 23);
            this.startPassowrdHasher.TabIndex = 3;
            this.startPassowrdHasher.Text = "Click to open Password Hasher";
            this.startPassowrdHasher.UseVisualStyleBackColor = true;
            this.startPassowrdHasher.Click += new System.EventHandler(this.startPassowrdHasher_Click);
            // 
            // openLogsBtn
            // 
            this.openLogsBtn.Location = new System.Drawing.Point(67, 61);
            this.openLogsBtn.Name = "openLogsBtn";
            this.openLogsBtn.Size = new System.Drawing.Size(198, 23);
            this.openLogsBtn.TabIndex = 2;
            this.openLogsBtn.Text = "Click to see compensation Logs";
            this.openLogsBtn.UseVisualStyleBackColor = true;
            // 
            // SuperAdminOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 320);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "SuperAdminOptions";
            this.Text = "Super Admin Options";
            this.Load += new System.EventHandler(this.SuperAdminOptions_Load);
            this.tabControl1.ResumeLayout(false);
            this.addAnAdminTab.ResumeLayout(false);
            this.addAnAdminTab.PerformLayout();
            this.whiteListGroupBox.ResumeLayout(false);
            this.whiteListGroupBox.PerformLayout();
            this.restrictionsGroupBox.ResumeLayout(false);
            this.restrictionsGroupBox.PerformLayout();
            this.modifyAnAdminTab.ResumeLayout(false);
            this.modifyAnAdminTab.PerformLayout();
            this.modifyWhiteListGroupBox.ResumeLayout(false);
            this.modifyWhiteListGroupBox.PerformLayout();
            this.modifyRestrictionsGroupBox.ResumeLayout(false);
            this.modifyRestrictionsGroupBox.PerformLayout();
            this.removeAnAdminTab.ResumeLayout(false);
            this.removeAnAdminTab.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addAnAdminTab;
        private System.Windows.Forms.TabPage modifyAnAdminTab;
        private System.Windows.Forms.TabPage removeAnAdminTab;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox addAnAdminPassword;
        private System.Windows.Forms.TextBox addAnAdminUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addAnAdminBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox removeAnAdminUsername;
        private System.Windows.Forms.Button modifyAnAdminModifyBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox modifyAnAdminUsername;
        private System.Windows.Forms.Button removeAnAdminRemoveBtn;
        private System.Windows.Forms.Button openLogsBtn;
        private System.Windows.Forms.GroupBox restrictionsGroupBox;
        private System.Windows.Forms.CheckBox restrictBanning;
        private System.Windows.Forms.CheckBox restrictKicking;
        private System.Windows.Forms.GroupBox whiteListGroupBox;
        private System.Windows.Forms.CheckBox whiteListMedicalOfficers;
        private System.Windows.Forms.CheckBox whiteListPoliceOfficer;
        private System.Windows.Forms.CheckBox restrictSuperAdmin;
        private System.Windows.Forms.CheckBox restrictMarquee;
        private System.Windows.Forms.CheckBox restrictGarageComp;
        private System.Windows.Forms.CheckBox restrictWhitelisting;
        private System.Windows.Forms.CheckBox restrictCompensation;
        private System.Windows.Forms.Button addAnAdminClearFieldsBtn;
        private System.Windows.Forms.CheckBox restrictGarageView;
        private System.Windows.Forms.Button clearModifyUserFields;
        private System.Windows.Forms.GroupBox modifyWhiteListGroupBox;
        private System.Windows.Forms.CheckBox modifyUserCanWhitelistMed;
        private System.Windows.Forms.CheckBox modifyUserCanWhitelistCop;
        private System.Windows.Forms.GroupBox modifyRestrictionsGroupBox;
        private System.Windows.Forms.CheckBox modifySuperAdmin;
        private System.Windows.Forms.CheckBox modifyMarquee;
        private System.Windows.Forms.CheckBox modifyRestrictGarageView;
        private System.Windows.Forms.CheckBox modifyRestrictGarageComp;
        private System.Windows.Forms.CheckBox modifyRestrictWhitelisting;
        private System.Windows.Forms.CheckBox modifyRestrictCompensation;
        private System.Windows.Forms.CheckBox modifyRestrictBanning;
        private System.Windows.Forms.CheckBox modifyRestrictKicking;
        private System.Windows.Forms.Button setAnnouncmentText;
        private System.Windows.Forms.TextBox announcmentText;
        private System.Windows.Forms.Button startPassowrdHasher;
        private System.Windows.Forms.Button expellAllAdmins;
    }
}