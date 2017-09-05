namespace myCart
{
    partial class myGoogle
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(593, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Tag = "tb1";
            this.textBox1.Text = "Enter keywork to be searched?";
            this.textBox1.VisibleChanged += new System.EventHandler(this.textBox1_VisibleChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser3
            // 
            this.webBrowser3.Location = new System.Drawing.Point(24, 57);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(695, 415);
            this.webBrowser3.TabIndex = 2;
            this.webBrowser3.Visible = false;
            this.webBrowser3.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser3_DocumentCompleted);
            this.webBrowser3.VisibleChanged += new System.EventHandler(this.webBrowser3_VisibleChanged);
            // 
            // myGoogle
            // 
            this.ClientSize = new System.Drawing.Size(746, 484);
            this.Controls.Add(this.webBrowser3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "myGoogle";
            this.Text = "Welcome to personalised google!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.TextBox Search_tb;
        private System.Windows.Forms.Label Search_label;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser3;
    }
}

