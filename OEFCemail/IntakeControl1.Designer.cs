﻿
namespace OEFCemail
{
    partial class IntakeControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxRadioBtn = new System.Windows.Forms.GroupBox();
            this.radioButtonOH = new System.Windows.Forms.RadioButton();
            this.radioButtonAR = new System.Windows.Forms.RadioButton();
            this.radioButtonPrj = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxProject = new System.Windows.Forms.TextBox();
            this.buttonAppend = new System.Windows.Forms.Button();
            this.buttonSaveEmail = new System.Windows.Forms.Button();
            this.buttonAutoFill = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAttach = new System.Windows.Forms.TextBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.textBoxReceiver = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBoxRadioBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxSubject);
            this.panel1.Controls.Add(this.groupBoxRadioBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxProject);
            this.panel1.Controls.Add(this.buttonAppend);
            this.panel1.Controls.Add(this.buttonSaveEmail);
            this.panel1.Controls.Add(this.buttonAutoFill);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxAttach);
            this.panel1.Controls.Add(this.textBoxContent);
            this.panel1.Controls.Add(this.textBoxTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxSender);
            this.panel1.Controls.Add(this.textBoxReceiver);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 778);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // groupBoxRadioBtn
            // 
            this.groupBoxRadioBtn.Controls.Add(this.radioButtonOH);
            this.groupBoxRadioBtn.Controls.Add(this.radioButtonAR);
            this.groupBoxRadioBtn.Controls.Add(this.radioButtonPrj);
            this.groupBoxRadioBtn.Location = new System.Drawing.Point(23, 562);
            this.groupBoxRadioBtn.Name = "groupBoxRadioBtn";
            this.groupBoxRadioBtn.Size = new System.Drawing.Size(125, 80);
            this.groupBoxRadioBtn.TabIndex = 24;
            this.groupBoxRadioBtn.TabStop = false;
            // 
            // radioButtonOH
            // 
            this.radioButtonOH.AutoSize = true;
            this.radioButtonOH.Location = new System.Drawing.Point(6, 56);
            this.radioButtonOH.Name = "radioButtonOH";
            this.radioButtonOH.Size = new System.Drawing.Size(72, 17);
            this.radioButtonOH.TabIndex = 26;
            this.radioButtonOH.TabStop = true;
            this.radioButtonOH.Text = "Overhead";
            this.radioButtonOH.UseVisualStyleBackColor = true;
            // 
            // radioButtonAR
            // 
            this.radioButtonAR.AutoSize = true;
            this.radioButtonAR.Location = new System.Drawing.Point(6, 33);
            this.radioButtonAR.Name = "radioButtonAR";
            this.radioButtonAR.Size = new System.Drawing.Size(59, 17);
            this.radioButtonAR.TabIndex = 25;
            this.radioButtonAR.TabStop = true;
            this.radioButtonAR.Text = "At Risk";
            this.radioButtonAR.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrj
            // 
            this.radioButtonPrj.AutoSize = true;
            this.radioButtonPrj.Checked = true;
            this.radioButtonPrj.Location = new System.Drawing.Point(6, 10);
            this.radioButtonPrj.Name = "radioButtonPrj";
            this.radioButtonPrj.Size = new System.Drawing.Size(63, 17);
            this.radioButtonPrj.TabIndex = 24;
            this.radioButtonPrj.TabStop = true;
            this.radioButtonPrj.Text = "Projects";
            this.radioButtonPrj.UseVisualStyleBackColor = true;
            this.radioButtonPrj.CheckedChanged += new System.EventHandler(this.RadioButtonPrj_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 654);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Project #";
            // 
            // textBoxProject
            // 
            this.textBoxProject.Location = new System.Drawing.Point(23, 670);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(125, 20);
            this.textBoxProject.TabIndex = 19;
            // 
            // buttonAppend
            // 
            this.buttonAppend.Location = new System.Drawing.Point(23, 750);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Size = new System.Drawing.Size(125, 25);
            this.buttonAppend.TabIndex = 17;
            this.buttonAppend.Text = "Save to Notes";
            this.buttonAppend.UseVisualStyleBackColor = true;
            this.buttonAppend.Click += new System.EventHandler(this.ButtonAppend_Click);
            // 
            // buttonSaveEmail
            // 
            this.buttonSaveEmail.Location = new System.Drawing.Point(23, 708);
            this.buttonSaveEmail.Name = "buttonSaveEmail";
            this.buttonSaveEmail.Size = new System.Drawing.Size(125, 25);
            this.buttonSaveEmail.TabIndex = 15;
            this.buttonSaveEmail.Text = "Save Email To File";
            this.buttonSaveEmail.UseVisualStyleBackColor = true;
            this.buttonSaveEmail.Click += new System.EventHandler(this.ButtonSaveEmail_Click);
            // 
            // buttonAutoFill
            // 
            this.buttonAutoFill.Location = new System.Drawing.Point(22, 533);
            this.buttonAutoFill.Name = "buttonAutoFill";
            this.buttonAutoFill.Size = new System.Drawing.Size(125, 25);
            this.buttonAutoFill.TabIndex = 14;
            this.buttonAutoFill.Text = "AutoFill";
            this.buttonAutoFill.UseVisualStyleBackColor = true;
            this.buttonAutoFill.Click += new System.EventHandler(this.ButtonAutoFill_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Attachments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Content";
            // 
            // textBoxAttach
            // 
            this.textBoxAttach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAttach.Location = new System.Drawing.Point(23, 443);
            this.textBoxAttach.Multiline = true;
            this.textBoxAttach.Name = "textBoxAttach";
            this.textBoxAttach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAttach.Size = new System.Drawing.Size(323, 71);
            this.textBoxAttach.TabIndex = 11;
            // 
            // textBoxContent
            // 
            this.textBoxContent.AcceptsReturn = true;
            this.textBoxContent.AcceptsTab = true;
            this.textBoxContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContent.Location = new System.Drawing.Point(23, 215);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContent.Size = new System.Drawing.Size(323, 199);
            this.textBoxContent.TabIndex = 10;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTime.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTime.Location = new System.Drawing.Point(88, 170);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(258, 20);
            this.textBoxTime.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Receiver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sender";
            // 
            // textBoxSender
            // 
            this.textBoxSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSender.Location = new System.Drawing.Point(88, 63);
            this.textBoxSender.Multiline = true;
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(258, 30);
            this.textBoxSender.TabIndex = 2;
            // 
            // textBoxReceiver
            // 
            this.textBoxReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReceiver.Location = new System.Drawing.Point(88, 99);
            this.textBoxReceiver.Multiline = true;
            this.textBoxReceiver.Name = "textBoxReceiver";
            this.textBoxReceiver.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceiver.Size = new System.Drawing.Size(258, 65);
            this.textBoxReceiver.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Subject";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSubject.Location = new System.Drawing.Point(88, 13);
            this.textBoxSubject.Multiline = true;
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSubject.Size = new System.Drawing.Size(258, 44);
            this.textBoxSubject.TabIndex = 25;
            // 
            // IntakeControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Name = "IntakeControl1";
            this.Size = new System.Drawing.Size(366, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxRadioBtn.ResumeLayout(false);
            this.groupBoxRadioBtn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSender;
        private System.Windows.Forms.TextBox textBoxReceiver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAttach;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Button buttonAutoFill;
        private System.Windows.Forms.Button buttonAppend;
        private System.Windows.Forms.Button buttonSaveEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxProject;
        private System.Windows.Forms.GroupBox groupBoxRadioBtn;
        private System.Windows.Forms.RadioButton radioButtonOH;
        private System.Windows.Forms.RadioButton radioButtonAR;
        private System.Windows.Forms.RadioButton radioButtonPrj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSubject;
    }
}
