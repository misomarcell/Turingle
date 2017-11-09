namespace Turingle
{
    partial class TuringleGUI
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
            this.apiKey = new System.Windows.Forms.TextBox();
            this.botOutput = new System.Windows.Forms.TextBox();
            this.botInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTestBot = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.siteInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonTestSite = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CID = new System.Windows.Forms.TextBox();
            this.buttonNewConv = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.siteSelector = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.autoReply = new System.Windows.Forms.CheckBox();
            this.buttonStartNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // apiKey
            // 
            this.apiKey.Location = new System.Drawing.Point(64, 19);
            this.apiKey.Name = "apiKey";
            this.apiKey.Size = new System.Drawing.Size(257, 20);
            this.apiKey.TabIndex = 0;
            // 
            // botOutput
            // 
            this.botOutput.Location = new System.Drawing.Point(64, 157);
            this.botOutput.Name = "botOutput";
            this.botOutput.ReadOnly = true;
            this.botOutput.Size = new System.Drawing.Size(257, 20);
            this.botOutput.TabIndex = 1;
            // 
            // botInput
            // 
            this.botInput.Location = new System.Drawing.Point(64, 183);
            this.botInput.Name = "botInput";
            this.botInput.Size = new System.Drawing.Size(257, 20);
            this.botInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "API Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input";
            // 
            // buttonTestBot
            // 
            this.buttonTestBot.Enabled = false;
            this.buttonTestBot.Location = new System.Drawing.Point(203, 209);
            this.buttonTestBot.Name = "buttonTestBot";
            this.buttonTestBot.Size = new System.Drawing.Size(118, 23);
            this.buttonTestBot.TabIndex = 6;
            this.buttonTestBot.Text = "Send test message";
            this.buttonTestBot.UseVisualStyleBackColor = true;
            this.buttonTestBot.Click += new System.EventHandler(this.buttonTestBot_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(345, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(619, 494);
            this.webBrowser1.TabIndex = 7;
            // 
            // siteInput
            // 
            this.siteInput.Location = new System.Drawing.Point(64, 46);
            this.siteInput.Name = "siteInput";
            this.siteInput.Size = new System.Drawing.Size(257, 20);
            this.siteInput.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Input";
            // 
            // buttonTestSite
            // 
            this.buttonTestSite.Location = new System.Drawing.Point(203, 72);
            this.buttonTestSite.Name = "buttonTestSite";
            this.buttonTestSite.Size = new System.Drawing.Size(118, 23);
            this.buttonTestSite.TabIndex = 11;
            this.buttonTestSite.Text = "Send test message";
            this.buttonTestSite.UseVisualStyleBackColor = true;
            this.buttonTestSite.Click += new System.EventHandler(this.buttonTestSite_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(6, 19);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(315, 23);
            this.buttonSend.TabIndex = 12;
            this.buttonSend.Text = "Send response";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CID);
            this.groupBox1.Controls.Add(this.buttonNewConv);
            this.groupBox1.Controls.Add(this.buttonHelp);
            this.groupBox1.Controls.Add(this.buttonCreate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.apiKey);
            this.groupBox1.Controls.Add(this.botOutput);
            this.groupBox1.Controls.Add(this.botInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonTestBot);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 241);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cleverbot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "CID";
            // 
            // CID
            // 
            this.CID.Location = new System.Drawing.Point(64, 74);
            this.CID.Multiline = true;
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            this.CID.Size = new System.Drawing.Size(257, 62);
            this.CID.TabIndex = 10;
            // 
            // buttonNewConv
            // 
            this.buttonNewConv.Location = new System.Drawing.Point(93, 45);
            this.buttonNewConv.Name = "buttonNewConv";
            this.buttonNewConv.Size = new System.Drawing.Size(104, 23);
            this.buttonNewConv.TabIndex = 9;
            this.buttonNewConv.Text = "New Conversation";
            this.buttonNewConv.UseVisualStyleBackColor = true;
            this.buttonNewConv.Click += new System.EventHandler(this.buttonNewConv_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(64, 45);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(23, 23);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(203, 45);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(118, 23);
            this.buttonCreate.TabIndex = 7;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.siteSelector);
            this.groupBox2.Controls.Add(this.siteInput);
            this.groupBox2.Controls.Add(this.buttonTestSite);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 106);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chat site";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Site";
            // 
            // siteSelector
            // 
            this.siteSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siteSelector.FormattingEnabled = true;
            this.siteSelector.Items.AddRange(new object[] {
            "7strangers.com"});
            this.siteSelector.Location = new System.Drawing.Point(64, 19);
            this.siteSelector.Name = "siteSelector";
            this.siteSelector.Size = new System.Drawing.Size(257, 21);
            this.siteSelector.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.autoReply);
            this.groupBox3.Controls.Add(this.buttonStartNew);
            this.groupBox3.Controls.Add(this.buttonSend);
            this.groupBox3.Location = new System.Drawing.Point(12, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 77);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conversation";
            // 
            // autoReply
            // 
            this.autoReply.AutoSize = true;
            this.autoReply.Checked = true;
            this.autoReply.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoReply.Location = new System.Drawing.Point(248, 49);
            this.autoReply.Name = "autoReply";
            this.autoReply.Size = new System.Drawing.Size(73, 17);
            this.autoReply.TabIndex = 16;
            this.autoReply.Text = "Auto reply";
            this.autoReply.UseVisualStyleBackColor = true;
            // 
            // buttonStartNew
            // 
            this.buttonStartNew.Location = new System.Drawing.Point(6, 45);
            this.buttonStartNew.Name = "buttonStartNew";
            this.buttonStartNew.Size = new System.Drawing.Size(118, 23);
            this.buttonStartNew.TabIndex = 16;
            this.buttonStartNew.Text = "New chat";
            this.buttonStartNew.UseVisualStyleBackColor = true;
            this.buttonStartNew.Click += new System.EventHandler(this.buttonStartNew_Click);
            // 
            // TuringleGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 518);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "TuringleGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turingle - Talk with robots!";
            this.Load += new System.EventHandler(this.TuringleGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox apiKey;
        private System.Windows.Forms.TextBox botOutput;
        private System.Windows.Forms.TextBox botInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTestBot;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox siteInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonTestSite;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox siteSelector;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonNewConv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CID;
        private System.Windows.Forms.Button buttonStartNew;
        private System.Windows.Forms.CheckBox autoReply;
    }
}

