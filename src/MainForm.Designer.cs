namespace PublishContent
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.lvBrokerIcons = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbContentURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.cbDeliveryGroup = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbUploadImage = new System.Windows.Forms.ToolStripButton();
            this.tsbPublish = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tbExistingContentURL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbExistingDesc = new System.Windows.Forms.TextBox();
            this.tbExistingDisplayName = new System.Windows.Forms.TextBox();
            this.lbExistingContent = new System.Windows.Forms.ListBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbListContent = new System.Windows.Forms.ToolStripButton();
            this.ilImages = new System.Windows.Forms.ImageList(this.components);
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbExistingUUID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbExistingCLA = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lvBrokerIcons);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbContentURL);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbDescription);
            this.tabPage1.Controls.Add(this.tbDisplayName);
            this.tabPage1.Controls.Add(this.cbDeliveryGroup);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(711, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New URL Content";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Application Icons";
            // 
            // lvBrokerIcons
            // 
            this.lvBrokerIcons.Enabled = false;
            this.lvBrokerIcons.LargeImageList = this.ilImages;
            this.lvBrokerIcons.Location = new System.Drawing.Point(9, 346);
            this.lvBrokerIcons.MultiSelect = false;
            this.lvBrokerIcons.Name = "lvBrokerIcons";
            this.lvBrokerIcons.Size = new System.Drawing.Size(439, 162);
            this.lvBrokerIcons.SmallImageList = this.ilImages;
            this.lvBrokerIcons.TabIndex = 21;
            this.lvBrokerIcons.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Content URL";
            // 
            // tbContentURL
            // 
            this.tbContentURL.Enabled = false;
            this.tbContentURL.Location = new System.Drawing.Point(6, 275);
            this.tbContentURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbContentURL.Name = "tbContentURL";
            this.tbContentURL.Size = new System.Drawing.Size(442, 22);
            this.tbContentURL.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Display Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Delivery Group for Content";
            // 
            // tbDescription
            // 
            this.tbDescription.Enabled = false;
            this.tbDescription.Location = new System.Drawing.Point(6, 215);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(442, 22);
            this.tbDescription.TabIndex = 15;
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Enabled = false;
            this.tbDisplayName.Location = new System.Drawing.Point(6, 154);
            this.tbDisplayName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(442, 22);
            this.tbDisplayName.TabIndex = 14;
            // 
            // cbDeliveryGroup
            // 
            this.cbDeliveryGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeliveryGroup.Enabled = false;
            this.cbDeliveryGroup.FormattingEnabled = true;
            this.cbDeliveryGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbDeliveryGroup.Location = new System.Drawing.Point(6, 97);
            this.cbDeliveryGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDeliveryGroup.Name = "cbDeliveryGroup";
            this.cbDeliveryGroup.Size = new System.Drawing.Size(442, 24);
            this.cbDeliveryGroup.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbUploadImage,
            this.tsbPublish});
            this.toolStrip1.Location = new System.Drawing.Point(2, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(707, 59);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::PublishContent.Properties.Resources.add32;
            this.tsbAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(41, 56);
            this.tsbAdd.Text = "Add";
            this.tsbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbUploadImage
            // 
            this.tsbUploadImage.Image = global::PublishContent.Properties.Resources.image32;
            this.tsbUploadImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUploadImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUploadImage.Name = "tsbUploadImage";
            this.tsbUploadImage.Size = new System.Drawing.Size(108, 56);
            this.tsbUploadImage.Text = "Upload Image";
            this.tsbUploadImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUploadImage.Click += new System.EventHandler(this.tsbUploadImage_Click);
            // 
            // tsbPublish
            // 
            this.tsbPublish.Image = global::PublishContent.Properties.Resources.publish32;
            this.tsbPublish.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPublish.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPublish.Name = "tsbPublish";
            this.tsbPublish.Size = new System.Drawing.Size(60, 56);
            this.tsbPublish.Text = "Publish";
            this.tsbPublish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPublish.Click += new System.EventHandler(this.tsbPublish_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbExistingCLA);
            this.tabPage2.Controls.Add(this.lbExistingUUID);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbExistingContentURL);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbExistingDesc);
            this.tabPage2.Controls.Add(this.tbExistingDisplayName);
            this.tabPage2.Controls.Add(this.lbExistingContent);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(711, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Existing URL Content";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Content URL";
            // 
            // tbExistingContentURL
            // 
            this.tbExistingContentURL.Location = new System.Drawing.Point(254, 252);
            this.tbExistingContentURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbExistingContentURL.Name = "tbExistingContentURL";
            this.tbExistingContentURL.Size = new System.Drawing.Size(442, 22);
            this.tbExistingContentURL.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Display Name";
            // 
            // tbExistingDesc
            // 
            this.tbExistingDesc.Location = new System.Drawing.Point(254, 192);
            this.tbExistingDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbExistingDesc.Name = "tbExistingDesc";
            this.tbExistingDesc.Size = new System.Drawing.Size(442, 22);
            this.tbExistingDesc.TabIndex = 22;
            // 
            // tbExistingDisplayName
            // 
            this.tbExistingDisplayName.Location = new System.Drawing.Point(254, 131);
            this.tbExistingDisplayName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbExistingDisplayName.Name = "tbExistingDisplayName";
            this.tbExistingDisplayName.Size = new System.Drawing.Size(442, 22);
            this.tbExistingDisplayName.TabIndex = 21;
            // 
            // lbExistingContent
            // 
            this.lbExistingContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbExistingContent.FormattingEnabled = true;
            this.lbExistingContent.ItemHeight = 16;
            this.lbExistingContent.Location = new System.Drawing.Point(2, 61);
            this.lbExistingContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbExistingContent.Name = "lbExistingContent";
            this.lbExistingContent.Size = new System.Drawing.Size(247, 462);
            this.lbExistingContent.TabIndex = 1;
            this.lbExistingContent.Click += new System.EventHandler(this.lbExistingContent_Click);
            this.lbExistingContent.SelectedIndexChanged += new System.EventHandler(this.lbExistingContent_SelectedIndexChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbListContent});
            this.toolStrip2.Location = new System.Drawing.Point(2, 2);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(707, 59);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbListContent
            // 
            this.tsbListContent.Image = global::PublishContent.Properties.Resources.list32;
            this.tsbListContent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbListContent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbListContent.Name = "tsbListContent";
            this.tsbListContent.Size = new System.Drawing.Size(91, 56);
            this.tsbListContent.Text = "List Content";
            this.tsbListContent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbListContent.Click += new System.EventHandler(this.tsbListContent_Click);
            // 
            // ilImages
            // 
            this.ilImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilImages.ImageSize = new System.Drawing.Size(16, 16);
            this.ilImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.miniToolStrip.Location = new System.Drawing.Point(463, 32);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(1056, 103);
            this.miniToolStrip.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Icon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(257, 431);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 77);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "UUID";
            // 
            // lbExistingUUID
            // 
            this.lbExistingUUID.Location = new System.Drawing.Point(254, 87);
            this.lbExistingUUID.Name = "lbExistingUUID";
            this.lbExistingUUID.Size = new System.Drawing.Size(442, 23);
            this.lbExistingUUID.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Command Line Args";
            // 
            // tbExistingCLA
            // 
            this.tbExistingCLA.Location = new System.Drawing.Point(254, 314);
            this.tbExistingCLA.Margin = new System.Windows.Forms.Padding(4);
            this.tbExistingCLA.Name = "tbExistingCLA";
            this.tbExistingCLA.Size = new System.Drawing.Size(442, 22);
            this.tbExistingCLA.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Desktop Group";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(254, 372);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 24);
            this.comboBox1.TabIndex = 36;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 554);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Publish URL Content";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbListContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbExistingContentURL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbExistingDesc;
        private System.Windows.Forms.ListBox lbExistingContent;
        private System.Windows.Forms.ImageList ilImages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvBrokerIcons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbContentURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.ComboBox cbDeliveryGroup;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbUploadImage;
        private System.Windows.Forms.ToolStripButton tsbPublish;
        private System.Windows.Forms.TextBox tbExistingDisplayName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbExistingUUID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbExistingCLA;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
    }
}