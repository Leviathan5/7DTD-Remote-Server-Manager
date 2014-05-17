﻿namespace _7DTD_Remote_Server_Manager
{
    partial class RemoteServerWindow
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

        public void refreshData()
        {
            listPlayers.DataSource = PlayerList.lPlayers;
            listPlayers.DisplayMember = "sName";
            listPlayers.ValueMember = "userID";
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnTelnetConnect = new System.Windows.Forms.Button();
            this.chkCredentials = new System.Windows.Forms.CheckBox();
            this.txtTelnetPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelnetPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.grpSSHCommands = new System.Windows.Forms.GroupBox();
            this.btnKillServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.grpServerCommands = new System.Windows.Forms.GroupBox();
            this.btnTelnetExit = new System.Windows.Forms.Button();
            this.btnTelnetShutdown = new System.Windows.Forms.Button();
            this.txtPermission = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnKick = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listPlayers = new System.Windows.Forms.ListBox();
            this.txtSetTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.grpLogin.SuspendLayout();
            this.grpSSHCommands.SuspendLayout();
            this.grpServerCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP:";
            // 
            // grpLogin
            // 
            this.grpLogin.AutoSize = true;
            this.grpLogin.Controls.Add(this.btnTelnetConnect);
            this.grpLogin.Controls.Add(this.chkCredentials);
            this.grpLogin.Controls.Add(this.txtTelnetPort);
            this.grpLogin.Controls.Add(this.btnConnect);
            this.grpLogin.Controls.Add(this.label8);
            this.grpLogin.Controls.Add(this.btnClear);
            this.grpLogin.Controls.Add(this.txtPass);
            this.grpLogin.Controls.Add(this.label3);
            this.grpLogin.Controls.Add(this.txtTelnetPass);
            this.grpLogin.Controls.Add(this.label4);
            this.grpLogin.Controls.Add(this.txtUser);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.txtServerIP);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Location = new System.Drawing.Point(12, 12);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(230, 229);
            this.grpLogin.TabIndex = 1;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "SSH/Telnet Login";
            // 
            // btnTelnetConnect
            // 
            this.btnTelnetConnect.Location = new System.Drawing.Point(111, 158);
            this.btnTelnetConnect.Name = "btnTelnetConnect";
            this.btnTelnetConnect.Size = new System.Drawing.Size(100, 23);
            this.btnTelnetConnect.TabIndex = 8;
            this.btnTelnetConnect.Text = "Telnet Connect";
            this.btnTelnetConnect.UseVisualStyleBackColor = true;
            this.btnTelnetConnect.Click += new System.EventHandler(this.btnTelnetConnect_Click);
            // 
            // chkCredentials
            // 
            this.chkCredentials.AutoSize = true;
            this.chkCredentials.Location = new System.Drawing.Point(20, 191);
            this.chkCredentials.Name = "chkCredentials";
            this.chkCredentials.Size = new System.Drawing.Size(72, 17);
            this.chkCredentials.TabIndex = 6;
            this.chkCredentials.Text = "Save Info";
            this.chkCredentials.UseVisualStyleBackColor = true;
            this.chkCredentials.CheckedChanged += new System.EventHandler(this.chkCredentials_CheckedChanged);
            // 
            // txtTelnetPort
            // 
            this.txtTelnetPort.Location = new System.Drawing.Point(111, 123);
            this.txtTelnetPort.Name = "txtTelnetPort";
            this.txtTelnetPort.Size = new System.Drawing.Size(100, 20);
            this.txtTelnetPort.TabIndex = 10;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(111, 187);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "SSH Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Telnet Port:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(8, 158);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(111, 71);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 5;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // txtTelnetPass
            // 
            this.txtTelnetPass.Location = new System.Drawing.Point(111, 97);
            this.txtTelnetPass.Name = "txtTelnetPass";
            this.txtTelnetPass.Size = new System.Drawing.Size(100, 20);
            this.txtTelnetPass.TabIndex = 5;
            this.txtTelnetPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "7DTD Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(111, 45);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(111, 19);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(100, 20);
            this.txtServerIP.TabIndex = 1;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(63, 79);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(104, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // grpSSHCommands
            // 
            this.grpSSHCommands.Controls.Add(this.btnKillServer);
            this.grpSSHCommands.Controls.Add(this.btnStartServer);
            this.grpSSHCommands.Controls.Add(this.btnDisconnect);
            this.grpSSHCommands.Enabled = false;
            this.grpSSHCommands.Location = new System.Drawing.Point(12, 247);
            this.grpSSHCommands.Name = "grpSSHCommands";
            this.grpSSHCommands.Size = new System.Drawing.Size(230, 115);
            this.grpSSHCommands.TabIndex = 3;
            this.grpSSHCommands.TabStop = false;
            this.grpSSHCommands.Text = "SSH Commands";
            // 
            // btnKillServer
            // 
            this.btnKillServer.Enabled = false;
            this.btnKillServer.Location = new System.Drawing.Point(63, 50);
            this.btnKillServer.Name = "btnKillServer";
            this.btnKillServer.Size = new System.Drawing.Size(104, 23);
            this.btnKillServer.TabIndex = 5;
            this.btnKillServer.Text = "Kill 7DTD Server";
            this.btnKillServer.UseVisualStyleBackColor = true;
            this.btnKillServer.Click += new System.EventHandler(this.btnKillServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Enabled = false;
            this.btnStartServer.Location = new System.Drawing.Point(63, 21);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(104, 23);
            this.btnStartServer.TabIndex = 4;
            this.btnStartServer.Text = "Start 7DTD Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // grpServerCommands
            // 
            this.grpServerCommands.Controls.Add(this.btnTelnetExit);
            this.grpServerCommands.Controls.Add(this.btnTelnetShutdown);
            this.grpServerCommands.Controls.Add(this.txtPermission);
            this.grpServerCommands.Controls.Add(this.label9);
            this.grpServerCommands.Controls.Add(this.txtSay);
            this.grpServerCommands.Controls.Add(this.label6);
            this.grpServerCommands.Controls.Add(this.button5);
            this.grpServerCommands.Controls.Add(this.btnAdmin);
            this.grpServerCommands.Controls.Add(this.btnMod);
            this.grpServerCommands.Controls.Add(this.btnBan);
            this.grpServerCommands.Controls.Add(this.btnKick);
            this.grpServerCommands.Controls.Add(this.label7);
            this.grpServerCommands.Controls.Add(this.listPlayers);
            this.grpServerCommands.Controls.Add(this.txtSetTime);
            this.grpServerCommands.Controls.Add(this.label5);
            this.grpServerCommands.Controls.Add(this.btnSetTime);
            this.grpServerCommands.Enabled = false;
            this.grpServerCommands.Location = new System.Drawing.Point(248, 12);
            this.grpServerCommands.Name = "grpServerCommands";
            this.grpServerCommands.Size = new System.Drawing.Size(318, 350);
            this.grpServerCommands.TabIndex = 4;
            this.grpServerCommands.TabStop = false;
            this.grpServerCommands.Text = "Server Commands";
            // 
            // btnTelnetExit
            // 
            this.btnTelnetExit.Location = new System.Drawing.Point(92, 67);
            this.btnTelnetExit.Name = "btnTelnetExit";
            this.btnTelnetExit.Size = new System.Drawing.Size(103, 23);
            this.btnTelnetExit.TabIndex = 15;
            this.btnTelnetExit.Text = "Telnet Exit Session";
            this.btnTelnetExit.UseVisualStyleBackColor = false;
            this.btnTelnetExit.Click += new System.EventHandler(this.btnTelnetExit_Click);
            // 
            // btnTelnetShutdown
            // 
            this.btnTelnetShutdown.Location = new System.Drawing.Point(201, 67);
            this.btnTelnetShutdown.Name = "btnTelnetShutdown";
            this.btnTelnetShutdown.Size = new System.Drawing.Size(103, 23);
            this.btnTelnetShutdown.TabIndex = 14;
            this.btnTelnetShutdown.Text = "Telnet Shutdown";
            this.btnTelnetShutdown.UseVisualStyleBackColor = true;
            this.btnTelnetShutdown.Click += new System.EventHandler(this.btnTelnetShutdown_Click);
            // 
            // txtPermission
            // 
            this.txtPermission.Location = new System.Drawing.Point(229, 240);
            this.txtPermission.Name = "txtPermission";
            this.txtPermission.Size = new System.Drawing.Size(75, 20);
            this.txtPermission.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Permission Level";
            // 
            // txtSay
            // 
            this.txtSay.Location = new System.Drawing.Point(45, 41);
            this.txtSay.Name = "txtSay";
            this.txtSay.Size = new System.Drawing.Size(175, 20);
            this.txtSay.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Say:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(229, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Send";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(229, 293);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 8;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(229, 266);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 7;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnBan
            // 
            this.btnBan.Location = new System.Drawing.Point(145, 194);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(75, 23);
            this.btnBan.TabIndex = 6;
            this.btnBan.Text = "Ban";
            this.btnBan.UseVisualStyleBackColor = true;
            // 
            // btnKick
            // 
            this.btnKick.Location = new System.Drawing.Point(64, 194);
            this.btnKick.Name = "btnKick";
            this.btnKick.Size = new System.Drawing.Size(75, 23);
            this.btnKick.TabIndex = 5;
            this.btnKick.Text = "Kick";
            this.btnKick.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Player List";
            // 
            // listPlayers
            // 
            this.listPlayers.Location = new System.Drawing.Point(6, 223);
            this.listPlayers.Name = "listPlayers";
            this.listPlayers.Size = new System.Drawing.Size(214, 121);
            this.listPlayers.Sorted = true;
            this.listPlayers.TabIndex = 3;
            this.listPlayers.SelectedIndexChanged += new System.EventHandler(this.listPlayers_SelectedIndexChanged);
            // 
            // txtSetTime
            // 
            this.txtSetTime.Location = new System.Drawing.Point(45, 15);
            this.txtSetTime.Name = "txtSetTime";
            this.txtSetTime.Size = new System.Drawing.Size(175, 20);
            this.txtSetTime.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Time:";
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(229, 13);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(75, 23);
            this.btnSetTime.TabIndex = 0;
            this.btnSetTime.Text = "Set Time";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // RemoteServerWindow
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(580, 371);
            this.Controls.Add(this.grpServerCommands);
            this.Controls.Add(this.grpSSHCommands);
            this.Controls.Add(this.grpLogin);
            this.MaximizeBox = false;
            this.Name = "RemoteServerWindow";
            this.Text = "7DTD Remote Server Manager";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpSSHCommands.ResumeLayout(false);
            this.grpServerCommands.ResumeLayout(false);
            this.grpServerCommands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkCredentials;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox grpSSHCommands;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Button btnKillServer;
        private System.Windows.Forms.GroupBox grpServerCommands;
        private System.Windows.Forms.TextBox txtSetTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.Button btnTelnetConnect;
        private System.Windows.Forms.TextBox txtTelnetPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listPlayers;
        private System.Windows.Forms.TextBox txtTelnetPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPermission;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button btnKick;
        private System.Windows.Forms.Button btnTelnetShutdown;
        private System.Windows.Forms.Button btnTelnetExit;

    }
}

