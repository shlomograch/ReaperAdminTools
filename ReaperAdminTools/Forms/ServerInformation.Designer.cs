namespace ReaperAdminTools
{
    partial class ServerInformationForm
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
            this.bottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.ipConnectedTo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.playersOnline = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.banPlayerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchForPlayer = new System.Windows.Forms.TextBox();
            this.kickPlayerBtn = new System.Windows.Forms.Button();
            this.searchForPlaerName = new System.Windows.Forms.Button();
            this.playerListView = new System.Windows.Forms.ListView();
            this.playerNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerGUID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerPing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bottomToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomToolStrip
            // 
            this.bottomToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ipConnectedTo,
            this.toolStripSeparator2,
            this.playersOnline,
            this.toolStripSeparator1});
            this.bottomToolStrip.Location = new System.Drawing.Point(0, 450);
            this.bottomToolStrip.Name = "bottomToolStrip";
            this.bottomToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bottomToolStrip.Size = new System.Drawing.Size(757, 25);
            this.bottomToolStrip.TabIndex = 2;
            this.bottomToolStrip.Text = "toolStrip1";
            // 
            // ipConnectedTo
            // 
            this.ipConnectedTo.Name = "ipConnectedTo";
            this.ipConnectedTo.Size = new System.Drawing.Size(82, 22);
            this.ipConnectedTo.Text = "Connected to:";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // playersOnline
            // 
            this.playersOnline.Name = "playersOnline";
            this.playersOnline.Size = new System.Drawing.Size(85, 22);
            this.playersOnline.Text = "Players Online:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // banPlayerBtn
            // 
            this.banPlayerBtn.Location = new System.Drawing.Point(531, 432);
            this.banPlayerBtn.Name = "banPlayerBtn";
            this.banPlayerBtn.Size = new System.Drawing.Size(104, 23);
            this.banPlayerBtn.TabIndex = 3;
            this.banPlayerBtn.Text = "Ban";
            this.banPlayerBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search for Player by Name:";
            // 
            // searchForPlayer
            // 
            this.searchForPlayer.Location = new System.Drawing.Point(154, 12);
            this.searchForPlayer.Name = "searchForPlayer";
            this.searchForPlayer.Size = new System.Drawing.Size(133, 20);
            this.searchForPlayer.TabIndex = 5;
            // 
            // kickPlayerBtn
            // 
            this.kickPlayerBtn.Location = new System.Drawing.Point(641, 432);
            this.kickPlayerBtn.Name = "kickPlayerBtn";
            this.kickPlayerBtn.Size = new System.Drawing.Size(104, 23);
            this.kickPlayerBtn.TabIndex = 6;
            this.kickPlayerBtn.Text = "Kick";
            this.kickPlayerBtn.UseVisualStyleBackColor = true;
            // 
            // searchForPlaerName
            // 
            this.searchForPlaerName.Location = new System.Drawing.Point(293, 10);
            this.searchForPlaerName.Name = "searchForPlaerName";
            this.searchForPlaerName.Size = new System.Drawing.Size(79, 23);
            this.searchForPlaerName.TabIndex = 3;
            this.searchForPlaerName.Text = "Search";
            this.searchForPlaerName.UseVisualStyleBackColor = true;
            this.searchForPlaerName.Click += new System.EventHandler(this.searchForPlaerName_Click);
            // 
            // playerListView
            // 
            this.playerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerNumber,
            this.playerName,
            this.playerGUID,
            this.playerIP,
            this.playerPing});
            this.playerListView.Location = new System.Drawing.Point(12, 44);
            this.playerListView.Name = "playerListView";
            this.playerListView.Size = new System.Drawing.Size(733, 382);
            this.playerListView.TabIndex = 7;
            this.playerListView.UseCompatibleStateImageBehavior = false;
            this.playerListView.View = System.Windows.Forms.View.Details;
            // 
            // playerNumber
            // 
            this.playerNumber.Text = "#";
            this.playerNumber.Width = 32;
            // 
            // playerName
            // 
            this.playerName.Text = "Player Name";
            this.playerName.Width = 213;
            // 
            // playerGUID
            // 
            this.playerGUID.Text = "GUID";
            this.playerGUID.Width = 296;
            // 
            // playerIP
            // 
            this.playerIP.Text = "IP";
            this.playerIP.Width = 150;
            // 
            // playerPing
            // 
            this.playerPing.Text = "Ping";
            this.playerPing.Width = 38;
            // 
            // ServerInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(757, 475);
            this.Controls.Add(this.playerListView);
            this.Controls.Add(this.kickPlayerBtn);
            this.Controls.Add(this.searchForPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchForPlaerName);
            this.Controls.Add(this.banPlayerBtn);
            this.Controls.Add(this.bottomToolStrip);
            this.Text = "Server Information";
            this.bottomToolStrip.ResumeLayout(false);
            this.bottomToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip bottomToolStrip;
        private System.Windows.Forms.ToolStripLabel ipConnectedTo;
        private System.Windows.Forms.ToolStripLabel playersOnline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button banPlayerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchForPlayer;
        private System.Windows.Forms.Button kickPlayerBtn;
        private System.Windows.Forms.Button searchForPlaerName;
        private System.Windows.Forms.ListView playerListView;
        private System.Windows.Forms.ColumnHeader playerNumber;
        private System.Windows.Forms.ColumnHeader playerName;
        private System.Windows.Forms.ColumnHeader playerGUID;
        private System.Windows.Forms.ColumnHeader playerIP;
        private System.Windows.Forms.ColumnHeader playerPing;

    }
}