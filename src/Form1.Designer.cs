namespace PublishContent
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
            this.components = new System.ComponentModel.Container();
            this.cbDeliveryGroup = new System.Windows.Forms.ComboBox();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbContentURL = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.btnPublish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDeliveryGroup
            // 
            this.cbDeliveryGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeliveryGroup.FormattingEnabled = true;
            this.cbDeliveryGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbDeliveryGroup.Location = new System.Drawing.Point(43, 48);
            this.cbDeliveryGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cbDeliveryGroup.Name = "cbDeliveryGroup";
            this.cbDeliveryGroup.Size = new System.Drawing.Size(442, 24);
            this.cbDeliveryGroup.TabIndex = 1;
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(43, 105);
            this.tbDisplayName.Margin = new System.Windows.Forms.Padding(4);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(442, 22);
            this.tbDisplayName.TabIndex = 2;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(43, 166);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(442, 22);
            this.tbDescription.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delivery Group for Content";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Display Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Content URL";
            // 
            // tbContentURL
            // 
            this.tbContentURL.Location = new System.Drawing.Point(43, 226);
            this.tbContentURL.Margin = new System.Windows.Forms.Padding(4);
            this.tbContentURL.Name = "tbContentURL";
            this.tbContentURL.Size = new System.Drawing.Size(442, 22);
            this.tbContentURL.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(46, 297);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(439, 162);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Application Icons";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(47, 465);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(130, 32);
            this.btnAddImage.TabIndex = 13;
            this.btnAddImage.Text = "Add new image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(47, 514);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(438, 34);
            this.btnPublish.TabIndex = 14;
            this.btnPublish.Text = "Publish URL Content";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 560);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbContentURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbDisplayName);
            this.Controls.Add(this.cbDeliveryGroup);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Publishing URL Content Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbDeliveryGroup;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbContentURL;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnPublish;
    }
}

