using System;
using System.Drawing;
using System.Windows.Forms;

namespace MoviedApp
{
    partial class HeadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadForm));
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.headPanel = new System.Windows.Forms.Panel();
            this.libraryPanel = new System.Windows.Forms.Panel();
            this.libraryTable = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.wishlistPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.watchedPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.friendsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timelinePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.wishlistLabel = new System.Windows.Forms.Label();
            this.timelineLabel = new System.Windows.Forms.Label();
            this.libraryLabel = new System.Windows.Forms.Label();
            this.watchedLabel = new System.Windows.Forms.Label();
            this.friendsLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.libraryHeaderPanel = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.filterButton = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.timelineHeaderPanel = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.titleBar = new System.Windows.Forms.TableLayoutPanel();
            this.consolBox = new System.Windows.Forms.TableLayoutPanel();
            this.Layout.SuspendLayout();
            this.headPanel.SuspendLayout();
            this.libraryPanel.SuspendLayout();
            this.libraryTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.wishlistPanel.SuspendLayout();
            this.watchedPanel.SuspendLayout();
            this.friendsPanel.SuspendLayout();
            this.timelinePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.libraryHeaderPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.timelineHeaderPanel.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Layout
            // 
            this.Layout.BackColor = System.Drawing.Color.Transparent;
            this.Layout.ColumnCount = 2;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout.Controls.Add(this.headPanel, 1, 1);
            this.Layout.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.Layout.Controls.Add(this.headerPanel, 1, 0);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Location = new System.Drawing.Point(2, 2);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 2;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout.Size = new System.Drawing.Size(949, 543);
            this.Layout.TabIndex = 0;
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.Transparent;
            this.headPanel.Controls.Add(this.libraryPanel);
            this.headPanel.Controls.Add(this.wishlistPanel);
            this.headPanel.Controls.Add(this.watchedPanel);
            this.headPanel.Controls.Add(this.friendsPanel);
            this.headPanel.Controls.Add(this.timelinePanel);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headPanel.Location = new System.Drawing.Point(153, 115);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(793, 425);
            this.headPanel.TabIndex = 3;
            // 
            // libraryPanel
            // 
            this.libraryPanel.AutoScroll = true;
            this.libraryPanel.BackColor = System.Drawing.Color.Transparent;
            this.libraryPanel.Controls.Add(this.libraryTable);
            this.libraryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryPanel.Location = new System.Drawing.Point(0, 0);
            this.libraryPanel.Name = "libraryPanel";
            this.libraryPanel.Size = new System.Drawing.Size(793, 425);
            this.libraryPanel.TabIndex = 0;
            // 
            // libraryTable
            // 
            this.libraryTable.AutoScroll = true;
            this.libraryTable.BackColor = System.Drawing.Color.Transparent;
            this.libraryTable.ColumnCount = 6;
            this.libraryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.libraryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.libraryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.libraryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.libraryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.libraryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.libraryTable.Controls.Add(this.pictureBox12, 0, 2);
            this.libraryTable.Controls.Add(this.pictureBox11, 0, 2);
            this.libraryTable.Controls.Add(this.pictureBox10, 0, 2);
            this.libraryTable.Controls.Add(this.pictureBox8, 0, 2);
            this.libraryTable.Controls.Add(this.pictureBox7, 0, 2);
            this.libraryTable.Controls.Add(this.pictureBox6, 0, 2);
            this.libraryTable.Controls.Add(this.pictureBox4, 2, 0);
            this.libraryTable.Controls.Add(this.pictureBox3, 1, 0);
            this.libraryTable.Controls.Add(this.pictureBox2, 0, 0);
            this.libraryTable.Controls.Add(this.pictureBox9, 0, 1);
            this.libraryTable.Controls.Add(this.pictureBox13, 1, 1);
            this.libraryTable.Controls.Add(this.pictureBox5, 4, 0);
            this.libraryTable.Controls.Add(this.pictureBox14, 5, 1);
            this.libraryTable.Controls.Add(this.pictureBox15, 3, 1);
            this.libraryTable.Controls.Add(this.pictureBox16, 5, 0);
            this.libraryTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryTable.Location = new System.Drawing.Point(0, 0);
            this.libraryTable.Name = "libraryTable";
            this.libraryTable.RowCount = 3;
            this.libraryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.libraryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.libraryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.libraryTable.Size = new System.Drawing.Size(793, 425);
            this.libraryTable.TabIndex = 0;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox12.BackgroundImage")));
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox12.Location = new System.Drawing.Point(3, 413);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(126, 199);
            this.pictureBox12.TabIndex = 10;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox11.Location = new System.Drawing.Point(135, 413);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(126, 199);
            this.pictureBox11.TabIndex = 9;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox10.Location = new System.Drawing.Point(663, 413);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(127, 199);
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox8.Location = new System.Drawing.Point(267, 413);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(126, 199);
            this.pictureBox8.TabIndex = 6;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Location = new System.Drawing.Point(399, 413);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(126, 199);
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Location = new System.Drawing.Point(531, 413);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(126, 199);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(267, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(126, 199);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(135, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(126, 199);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 199);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox9.Location = new System.Drawing.Point(3, 208);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(126, 199);
            this.pictureBox9.TabIndex = 11;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox13.BackgroundImage")));
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox13.Location = new System.Drawing.Point(135, 208);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(126, 199);
            this.pictureBox13.TabIndex = 12;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(531, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(126, 199);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox14.BackgroundImage")));
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox14.Location = new System.Drawing.Point(663, 208);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(127, 199);
            this.pictureBox14.TabIndex = 13;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox15.BackgroundImage")));
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox15.Location = new System.Drawing.Point(399, 208);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(126, 199);
            this.pictureBox15.TabIndex = 14;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox16.BackgroundImage")));
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox16.Location = new System.Drawing.Point(663, 3);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(127, 199);
            this.pictureBox16.TabIndex = 15;
            this.pictureBox16.TabStop = false;
            // 
            // wishlistPanel
            // 
            this.wishlistPanel.Controls.Add(this.label4);
            this.wishlistPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wishlistPanel.Location = new System.Drawing.Point(0, 0);
            this.wishlistPanel.Name = "wishlistPanel";
            this.wishlistPanel.Size = new System.Drawing.Size(793, 425);
            this.wishlistPanel.TabIndex = 20;
            this.wishlistPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(423, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Wishlist";
            // 
            // watchedPanel
            // 
            this.watchedPanel.Controls.Add(this.label3);
            this.watchedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watchedPanel.Location = new System.Drawing.Point(0, 0);
            this.watchedPanel.Name = "watchedPanel";
            this.watchedPanel.Size = new System.Drawing.Size(793, 425);
            this.watchedPanel.TabIndex = 21;
            this.watchedPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(423, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Watched";
            // 
            // friendsPanel
            // 
            this.friendsPanel.Controls.Add(this.label2);
            this.friendsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.friendsPanel.Location = new System.Drawing.Point(0, 0);
            this.friendsPanel.Name = "friendsPanel";
            this.friendsPanel.Size = new System.Drawing.Size(793, 425);
            this.friendsPanel.TabIndex = 18;
            this.friendsPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(423, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Friends";
            // 
            // timelinePanel
            // 
            this.timelinePanel.Controls.Add(this.label1);
            this.timelinePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timelinePanel.Location = new System.Drawing.Point(0, 0);
            this.timelinePanel.Name = "timelinePanel";
            this.timelinePanel.Size = new System.Drawing.Size(793, 425);
            this.timelinePanel.TabIndex = 17;
            this.timelinePanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(423, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timeline";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 115);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(144, 425);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MoviedApp.Properties.Resources.logo_movied;
            this.pictureBox1.Location = new System.Drawing.Point(15, 387);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.wishlistLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.timelineLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.libraryLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.watchedLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.friendsLabel, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 92);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(138, 199);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // wishlistLabel
            // 
            this.wishlistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wishlistLabel.AutoSize = true;
            this.wishlistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wishlistLabel.ForeColor = System.Drawing.Color.White;
            this.wishlistLabel.Location = new System.Drawing.Point(3, 160);
            this.wishlistLabel.Name = "wishlistLabel";
            this.wishlistLabel.Size = new System.Drawing.Size(132, 40);
            this.wishlistLabel.TabIndex = 4;
            this.wishlistLabel.Text = "Wishlist";
            this.wishlistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wishlistLabel.Click += new System.EventHandler(this.wishlistLabel_Click);
            this.wishlistLabel.MouseEnter += new System.EventHandler(this.wishlistLabel_MouseEnter);
            this.wishlistLabel.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // timelineLabel
            // 
            this.timelineLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timelineLabel.AutoSize = true;
            this.timelineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelineLabel.ForeColor = System.Drawing.Color.White;
            this.timelineLabel.Location = new System.Drawing.Point(3, 0);
            this.timelineLabel.Name = "timelineLabel";
            this.timelineLabel.Size = new System.Drawing.Size(132, 40);
            this.timelineLabel.TabIndex = 0;
            this.timelineLabel.Text = "Timeline";
            this.timelineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timelineLabel.Click += new System.EventHandler(this.timelineLabel_Click);
            this.timelineLabel.MouseEnter += new System.EventHandler(this.timelineLabel_MouseEnter);
            this.timelineLabel.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // libraryLabel
            // 
            this.libraryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.libraryLabel.AutoSize = true;
            this.libraryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libraryLabel.ForeColor = System.Drawing.Color.White;
            this.libraryLabel.Location = new System.Drawing.Point(3, 40);
            this.libraryLabel.Name = "libraryLabel";
            this.libraryLabel.Size = new System.Drawing.Size(132, 40);
            this.libraryLabel.TabIndex = 1;
            this.libraryLabel.Text = "Library";
            this.libraryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.libraryLabel.Click += new System.EventHandler(this.libraryLabel_Click);
            this.libraryLabel.MouseEnter += new System.EventHandler(this.libraryLabel_MouseEnter);
            this.libraryLabel.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // watchedLabel
            // 
            this.watchedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.watchedLabel.AutoSize = true;
            this.watchedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchedLabel.ForeColor = System.Drawing.Color.White;
            this.watchedLabel.Location = new System.Drawing.Point(3, 120);
            this.watchedLabel.Name = "watchedLabel";
            this.watchedLabel.Size = new System.Drawing.Size(132, 40);
            this.watchedLabel.TabIndex = 3;
            this.watchedLabel.Text = "Watched";
            this.watchedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.watchedLabel.Click += new System.EventHandler(this.watchedLabel_Click);
            this.watchedLabel.MouseEnter += new System.EventHandler(this.watchedLabel_MouseEnter);
            this.watchedLabel.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // friendsLabel
            // 
            this.friendsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendsLabel.AutoSize = true;
            this.friendsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsLabel.ForeColor = System.Drawing.Color.White;
            this.friendsLabel.Location = new System.Drawing.Point(3, 80);
            this.friendsLabel.Name = "friendsLabel";
            this.friendsLabel.Size = new System.Drawing.Size(132, 40);
            this.friendsLabel.TabIndex = 2;
            this.friendsLabel.Text = "Friends";
            this.friendsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.friendsLabel.Click += new System.EventHandler(this.friendsLabel_Click);
            this.friendsLabel.MouseEnter += new System.EventHandler(this.friendsLabel_MouseEnter);
            this.friendsLabel.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.libraryHeaderPanel);
            this.headerPanel.Controls.Add(this.timelineHeaderPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.headerPanel.Location = new System.Drawing.Point(153, 40);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(793, 69);
            this.headerPanel.TabIndex = 4;
            // 
            // libraryHeaderPanel
            // 
            this.libraryHeaderPanel.Controls.Add(this.searchPanel);
            this.libraryHeaderPanel.Controls.Add(this.genreLabel);
            this.libraryHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.libraryHeaderPanel.Name = "libraryHeaderPanel";
            this.libraryHeaderPanel.Size = new System.Drawing.Size(793, 69);
            this.libraryHeaderPanel.TabIndex = 3;
            this.libraryHeaderPanel.Visible = false;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.searchPanel.Controls.Add(this.filterButton);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Location = new System.Drawing.Point(3, 32);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(309, 34);
            this.searchPanel.TabIndex = 4;
            // 
            // filterButton
            // 
            this.filterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterButton.BackgroundImage = global::MoviedApp.Properties.Resources.filterButton;
            this.filterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filterButton.Location = new System.Drawing.Point(258, 8);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(18, 18);
            this.filterButton.TabIndex = 5;
            this.filterButton.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackgroundImage = global::MoviedApp.Properties.Resources.searchButton;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Location = new System.Drawing.Point(283, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(18, 18);
            this.searchButton.TabIndex = 4;
            this.searchButton.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.Color.White;
            this.searchTextBox.Location = new System.Drawing.Point(9, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(243, 28);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.Text = "search";
            // 
            // genreLabel
            // 
            this.genreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.ForeColor = System.Drawing.Color.White;
            this.genreLabel.Location = new System.Drawing.Point(304, 13);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(506, 69);
            this.genreLabel.TabIndex = 0;
            this.genreLabel.Text = "MOST POPULAR";
            // 
            // timelineHeaderPanel
            // 
            this.timelineHeaderPanel.Controls.Add(this.homeLabel);
            this.timelineHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timelineHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.timelineHeaderPanel.Name = "timelineHeaderPanel";
            this.timelineHeaderPanel.Size = new System.Drawing.Size(793, 69);
            this.timelineHeaderPanel.TabIndex = 2;
            this.timelineHeaderPanel.Visible = false;
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.ForeColor = System.Drawing.Color.White;
            this.homeLabel.Location = new System.Drawing.Point(283, 14);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(519, 69);
            this.homeLabel.TabIndex = 1;
            this.homeLabel.Text = "WELCOME BACK";
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Transparent;
            this.titleBar.ColumnCount = 1;
            this.titleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.titleBar.Controls.Add(this.consolBox, 0, 0);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(2, 2);
            this.titleBar.Name = "titleBar";
            this.titleBar.RowCount = 1;
            this.titleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.titleBar.Size = new System.Drawing.Size(949, 31);
            this.titleBar.TabIndex = 1;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // consolBox
            // 
            this.consolBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consolBox.BackgroundImage = global::MoviedApp.Properties.Resources.consolBox;
            this.consolBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.consolBox.ColumnCount = 3;
            this.consolBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.consolBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.consolBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.consolBox.Location = new System.Drawing.Point(847, 3);
            this.consolBox.Name = "consolBox";
            this.consolBox.RowCount = 1;
            this.consolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.consolBox.Size = new System.Drawing.Size(99, 25);
            this.consolBox.TabIndex = 0;
            this.consolBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.consolBox_MouseClick);
            // 
            // HeadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MoviedApp.Properties.Resources.background_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 547);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.Layout);
            this.Name = "HeadForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "HeadForm";
            this.ResizeEnd += new System.EventHandler(this.HeadForm_ResizeEnd);
            this.Layout.ResumeLayout(false);
            this.headPanel.ResumeLayout(false);
            this.libraryPanel.ResumeLayout(false);
            this.libraryTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.wishlistPanel.ResumeLayout(false);
            this.wishlistPanel.PerformLayout();
            this.watchedPanel.ResumeLayout(false);
            this.watchedPanel.PerformLayout();
            this.friendsPanel.ResumeLayout(false);
            this.friendsPanel.PerformLayout();
            this.timelinePanel.ResumeLayout(false);
            this.timelinePanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.libraryHeaderPanel.ResumeLayout(false);
            this.libraryHeaderPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.timelineHeaderPanel.ResumeLayout(false);
            this.timelineHeaderPanel.PerformLayout();
            this.titleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel Layout;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label friendsLabel;
        private Label libraryLabel;
        private Label watchedLabel;
        public Label wishlistLabel;
        public Label timelineLabel;
        private TableLayoutPanel titleBar;
        private TableLayoutPanel consolBox;
        private Panel headPanel;
        private Panel libraryPanel;
        private TableLayoutPanel libraryTable;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private Panel headerPanel;
        private Panel friendsPanel;
        private Label label2;
        private Panel timelinePanel;
        private Label label1;
        private Panel wishlistPanel;
        private Label label4;
        private Panel watchedPanel;
        private Label label3;
        private Panel libraryHeaderPanel;
        private Label genreLabel;
        private Panel timelineHeaderPanel;
        private TextBox searchTextBox;
        private Label homeLabel;
        private Panel searchPanel;
        private PictureBox searchButton;
        private PictureBox filterButton;
    }
}