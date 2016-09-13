namespace qliqCloudApiCSharpSample
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
            this.startStopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.httpPortUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.repliesTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.requestsTextBox = new System.Windows.Forms.TextBox();
            this.errorsTab = new System.Windows.Forms.TabPage();
            this.errorsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.privateKeyFileTextBox = new System.Windows.Forms.TextBox();
            this.browserPrivateKeyFileButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.httpPortUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.errorsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(336, 41);
            this.startStopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(191, 26);
            this.startStopButton.TabIndex = 0;
            this.startStopButton.Text = "Start HTTP Server";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "HTTP Port:";
            // 
            // httpPortUpDown
            // 
            this.httpPortUpDown.Location = new System.Drawing.Point(102, 41);
            this.httpPortUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.httpPortUpDown.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.httpPortUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.httpPortUpDown.Name = "httpPortUpDown";
            this.httpPortUpDown.Size = new System.Drawing.Size(127, 22);
            this.httpPortUpDown.TabIndex = 2;
            this.httpPortUpDown.Value = new decimal(new int[] {
            18084,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "HTTP requests are saved to c:\\http_request_<timestamp>.txt";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.errorsTab);
            this.tabControl1.Location = new System.Drawing.Point(16, 96);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 310);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.repliesTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(556, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Received Replies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // repliesTextBox
            // 
            this.repliesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repliesTextBox.Location = new System.Drawing.Point(8, 7);
            this.repliesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.repliesTextBox.Multiline = true;
            this.repliesTextBox.Name = "repliesTextBox";
            this.repliesTextBox.Size = new System.Drawing.Size(536, 262);
            this.repliesTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.requestsTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(556, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HTTP Requests";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // requestsTextBox
            // 
            this.requestsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestsTextBox.Location = new System.Drawing.Point(8, 7);
            this.requestsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.requestsTextBox.Multiline = true;
            this.requestsTextBox.Name = "requestsTextBox";
            this.requestsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.requestsTextBox.Size = new System.Drawing.Size(536, 262);
            this.requestsTextBox.TabIndex = 1;
            // 
            // errorsTab
            // 
            this.errorsTab.Controls.Add(this.errorsTextBox);
            this.errorsTab.Location = new System.Drawing.Point(4, 25);
            this.errorsTab.Name = "errorsTab";
            this.errorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.errorsTab.Size = new System.Drawing.Size(556, 281);
            this.errorsTab.TabIndex = 2;
            this.errorsTab.Text = "Errors";
            this.errorsTab.UseVisualStyleBackColor = true;
            // 
            // errorsTextBox
            // 
            this.errorsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorsTextBox.Location = new System.Drawing.Point(10, 9);
            this.errorsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.errorsTextBox.Multiline = true;
            this.errorsTextBox.Name = "errorsTextBox";
            this.errorsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.errorsTextBox.Size = new System.Drawing.Size(536, 262);
            this.errorsTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Private Key File:";
            // 
            // privateKeyFileTextBox
            // 
            this.privateKeyFileTextBox.Location = new System.Drawing.Point(130, 7);
            this.privateKeyFileTextBox.Name = "privateKeyFileTextBox";
            this.privateKeyFileTextBox.Size = new System.Drawing.Size(366, 22);
            this.privateKeyFileTextBox.TabIndex = 6;
            // 
            // browserPrivateKeyFileButton
            // 
            this.browserPrivateKeyFileButton.Location = new System.Drawing.Point(503, 7);
            this.browserPrivateKeyFileButton.Name = "browserPrivateKeyFileButton";
            this.browserPrivateKeyFileButton.Size = new System.Drawing.Size(81, 23);
            this.browserPrivateKeyFileButton.TabIndex = 7;
            this.browserPrivateKeyFileButton.Text = "Browse...";
            this.browserPrivateKeyFileButton.UseVisualStyleBackColor = true;
            this.browserPrivateKeyFileButton.Click += new System.EventHandler(this.browserPrivateKeyFileButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "URL: /receive";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 421);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.browserPrivateKeyFileButton);
            this.Controls.Add(this.privateKeyFileTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.httpPortUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startStopButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Secure Texting Cloud API Sample";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.httpPortUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.errorsTab.ResumeLayout(false);
            this.errorsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown httpPortUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox repliesTextBox;
        private System.Windows.Forms.TextBox requestsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox privateKeyFileTextBox;
        private System.Windows.Forms.Button browserPrivateKeyFileButton;
        private System.Windows.Forms.TabPage errorsTab;
        private System.Windows.Forms.TextBox errorsTextBox;
        private System.Windows.Forms.Label label4;
    }
}

