namespace GionPlayer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            NameBox = new TextBox();
            UrlBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnSendRadio = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 99);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(72, 121);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(270, 23);
            NameBox.TabIndex = 1;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // UrlBox
            // 
            UrlBox.Location = new Point(72, 169);
            UrlBox.Name = "UrlBox";
            UrlBox.Size = new Size(270, 23);
            UrlBox.TabIndex = 3;
            UrlBox.TextChanged += UrlBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 147);
            label2.Name = "label2";
            label2.Size = new Size(43, 19);
            label2.TabIndex = 2;
            label2.Text = "URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 25);
            label3.Name = "label3";
            label3.Size = new Size(264, 30);
            label3.TabIndex = 4;
            label3.Text = "Add new radio station";
            // 
            // btnSendRadio
            // 
            btnSendRadio.Location = new Point(149, 210);
            btnSendRadio.Name = "btnSendRadio";
            btnSendRadio.Size = new Size(75, 23);
            btnSendRadio.TabIndex = 5;
            btnSendRadio.Text = "OK";
            btnSendRadio.UseVisualStyleBackColor = true;
            btnSendRadio.Click += Ok_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(137, 70);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(122, 16);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Search links here!";
            linkLabel1.LinkClicked += RadioLinks_Clicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 266);
            Controls.Add(linkLabel1);
            Controls.Add(btnSendRadio);
            Controls.Add(label3);
            Controls.Add(UrlBox);
            Controls.Add(label2);
            Controls.Add(NameBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "New Radio Station";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameBox;
        private TextBox UrlBox;
        private Label label2;
        private Label label3;
        private Button btnSendRadio;
        private LinkLabel linkLabel1;
    }
}