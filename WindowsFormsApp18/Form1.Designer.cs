﻿namespace WindowsFormsApp18
{
    partial class Form1
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
            this.ServerIPtextBox = new System.Windows.Forms.TextBox();
            this.ClientIPtextBox = new System.Windows.Forms.TextBox();
            this.ClientPorttextBox = new System.Windows.Forms.TextBox();
            this.ServerPorttextBox = new System.Windows.Forms.TextBox();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChatScreentextBox = new System.Windows.Forms.TextBox();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ServerIPtextBox
            // 
            this.ServerIPtextBox.Location = new System.Drawing.Point(157, 85);
            this.ServerIPtextBox.Name = "ServerIPtextBox";
            this.ServerIPtextBox.Size = new System.Drawing.Size(163, 20);
            this.ServerIPtextBox.TabIndex = 0;
            // 
            // ClientIPtextBox
            // 
            this.ClientIPtextBox.Location = new System.Drawing.Point(157, 161);
            this.ClientIPtextBox.Name = "ClientIPtextBox";
            this.ClientIPtextBox.Size = new System.Drawing.Size(163, 20);
            this.ClientIPtextBox.TabIndex = 1;
            // 
            // ClientPorttextBox
            // 
            this.ClientPorttextBox.Location = new System.Drawing.Point(422, 161);
            this.ClientPorttextBox.Name = "ClientPorttextBox";
            this.ClientPorttextBox.Size = new System.Drawing.Size(163, 20);
            this.ClientPorttextBox.TabIndex = 2;
            // 
            // ServerPorttextBox
            // 
            this.ServerPorttextBox.Location = new System.Drawing.Point(422, 85);
            this.ServerPorttextBox.Name = "ServerPorttextBox";
            this.ServerPorttextBox.Size = new System.Drawing.Size(163, 20);
            this.ServerPorttextBox.TabIndex = 3;
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(591, 82);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(75, 23);
            this.Startbutton.TabIndex = 4;
            this.Startbutton.Text = "START";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Connectbutton
            // 
            this.Connectbutton.Location = new System.Drawing.Point(591, 158);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(75, 23);
            this.Connectbutton.TabIndex = 5;
            this.Connectbutton.Text = "CONNECT";
            this.Connectbutton.UseVisualStyleBackColor = true;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CLIENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "IP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "PORT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "PORT:";
            // 
            // ChatScreentextBox
            // 
            this.ChatScreentextBox.Location = new System.Drawing.Point(111, 227);
            this.ChatScreentextBox.Multiline = true;
            this.ChatScreentextBox.Name = "ChatScreentextBox";
            this.ChatScreentextBox.Size = new System.Drawing.Size(555, 116);
            this.ChatScreentextBox.TabIndex = 7;
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Location = new System.Drawing.Point(111, 374);
            this.MessagetextBox.Multiline = true;
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(555, 64);
            this.MessagetextBox.TabIndex = 8;
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(672, 374);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(75, 64);
            this.Sendbutton.TabIndex = 9;
            this.Sendbutton.Text = "SEND";
            this.Sendbutton.UseVisualStyleBackColor = true;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 545);
            this.Controls.Add(this.Sendbutton);
            this.Controls.Add(this.MessagetextBox);
            this.Controls.Add(this.ChatScreentextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connectbutton);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.ServerPorttextBox);
            this.Controls.Add(this.ClientPorttextBox);
            this.Controls.Add(this.ClientIPtextBox);
            this.Controls.Add(this.ServerIPtextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerIPtextBox;
        private System.Windows.Forms.TextBox ClientIPtextBox;
        private System.Windows.Forms.TextBox ClientPorttextBox;
        private System.Windows.Forms.TextBox ServerPorttextBox;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ChatScreentextBox;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.Button Sendbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

