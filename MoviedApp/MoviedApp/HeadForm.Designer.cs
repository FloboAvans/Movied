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
            this.checkinPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.checkinConfirmButton = new System.Windows.Forms.Label();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.reviewTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.ratingTitleLabel = new System.Windows.Forms.Label();
            this.checkinRating = new RatingControls.Rating();
            this.filmInfoPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.addCheckinButton = new System.Windows.Forms.Label();
            this.addWishlistButton = new System.Windows.Forms.Label();
            this.trailerButton = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.filmImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filmInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.overviewText = new System.Windows.Forms.TextBox();
            this.overviewTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.revenueTitleLabel = new System.Windows.Forms.Label();
            this.budgetTitleLabel = new System.Windows.Forms.Label();
            this.homepageTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.factsTitleLabel = new System.Windows.Forms.Label();
            this.statusTitleLabel = new System.Windows.Forms.Label();
            this.languageTitleLabel = new System.Windows.Forms.Label();
            this.runtimeTitleLabel = new System.Windows.Forms.Label();
            this.releaseTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.crewTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.castTitleLabel = new System.Windows.Forms.Label();
            this.wishlistPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.watchedPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.friendsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timelinePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.wishlistLabel = new System.Windows.Forms.Label();
            this.timelineLabel = new System.Windows.Forms.Label();
            this.libraryLabel = new System.Windows.Forms.Label();
            this.watchedLabel = new System.Windows.Forms.Label();
            this.friendsLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.filmInfoHeaderPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.searchTextBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.filmNameLabel = new System.Windows.Forms.Label();
            this.libraryHeaderPanel = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.filterButton = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.timelineHeaderPanel = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.titleBar = new System.Windows.Forms.TableLayoutPanel();
            this.consolBox = new System.Windows.Forms.TableLayoutPanel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Label();
            this.alreadyloginError = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Label();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.reviewTitleLabel = new System.Windows.Forms.Label();
            this.Layout.SuspendLayout();
            this.headPanel.SuspendLayout();
            this.checkinPanel.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.filmInfoPanel.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.filmInfoTable.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.wishlistPanel.SuspendLayout();
            this.watchedPanel.SuspendLayout();
            this.friendsPanel.SuspendLayout();
            this.timelinePanel.SuspendLayout();
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
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.filmInfoHeaderPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            this.tableLayoutPanel11.SuspendLayout();
            this.libraryHeaderPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.timelineHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.titleBar.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.tableLayoutPanel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // Layout
            // 
            this.Layout.BackColor = System.Drawing.Color.Transparent;
            this.Layout.ColumnCount = 2;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.Controls.Add(this.headPanel, 1, 2);
            this.Layout.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.Layout.Controls.Add(this.headerPanel, 1, 1);
            this.Layout.Controls.Add(this.userPictureBox, 0, 1);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Enabled = false;
            this.Layout.Location = new System.Drawing.Point(2, 2);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 3;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.Size = new System.Drawing.Size(949, 543);
            this.Layout.TabIndex = 0;
            this.Layout.Visible = false;
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.Transparent;
            this.headPanel.Controls.Add(this.checkinPanel);
            this.headPanel.Controls.Add(this.filmInfoPanel);
            this.headPanel.Controls.Add(this.wishlistPanel);
            this.headPanel.Controls.Add(this.watchedPanel);
            this.headPanel.Controls.Add(this.friendsPanel);
            this.headPanel.Controls.Add(this.timelinePanel);
            this.headPanel.Controls.Add(this.libraryPanel);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headPanel.Location = new System.Drawing.Point(153, 115);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(793, 425);
            this.headPanel.TabIndex = 3;
            // 
            // checkinPanel
            // 
            this.checkinPanel.Controls.Add(this.tableLayoutPanel13);
            this.checkinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkinPanel.Location = new System.Drawing.Point(0, 0);
            this.checkinPanel.Name = "checkinPanel";
            this.checkinPanel.Size = new System.Drawing.Size(793, 425);
            this.checkinPanel.TabIndex = 23;
            this.checkinPanel.Visible = false;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel14, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel15, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(793, 425);
            this.tableLayoutPanel13.TabIndex = 2;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 4;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel14.Controls.Add(this.checkinConfirmButton, 3, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 387);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(787, 35);
            this.tableLayoutPanel14.TabIndex = 1;
            // 
            // checkinConfirmButton
            // 
            this.checkinConfirmButton.AutoSize = true;
            this.checkinConfirmButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkinConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinConfirmButton.ForeColor = System.Drawing.Color.White;
            this.checkinConfirmButton.Location = new System.Drawing.Point(654, 0);
            this.checkinConfirmButton.Name = "checkinConfirmButton";
            this.checkinConfirmButton.Size = new System.Drawing.Size(130, 35);
            this.checkinConfirmButton.TabIndex = 11;
            this.checkinConfirmButton.Text = "Check in";
            this.checkinConfirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.AutoScroll = true;
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.00378F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.99622F));
            this.tableLayoutPanel15.Controls.Add(this.pictureBox20, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(787, 378);
            this.tableLayoutPanel15.TabIndex = 0;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(10, 10);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(208, 288);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.tableLayoutPanel16);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(231, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(553, 372);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel17, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel18, 0, 2);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 5;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(553, 372);
            this.tableLayoutPanel16.TabIndex = 1;
            // 
            // reviewTextBox
            // 
            this.reviewTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.reviewTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reviewTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewTextBox.ForeColor = System.Drawing.Color.White;
            this.reviewTextBox.Location = new System.Drawing.Point(3, 23);
            this.reviewTextBox.Multiline = true;
            this.reviewTextBox.Name = "reviewTextBox";
            this.reviewTextBox.Size = new System.Drawing.Size(541, 70);
            this.reviewTextBox.TabIndex = 2;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Controls.Add(this.ratingTitleLabel, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.checkinRating, 0, 1);
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel17.Size = new System.Drawing.Size(547, 81);
            this.tableLayoutPanel17.TabIndex = 6;
            // 
            // ratingTitleLabel
            // 
            this.ratingTitleLabel.AutoSize = true;
            this.ratingTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingTitleLabel.ForeColor = System.Drawing.Color.White;
            this.ratingTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.ratingTitleLabel.Name = "ratingTitleLabel";
            this.ratingTitleLabel.Size = new System.Drawing.Size(56, 20);
            this.ratingTitleLabel.TabIndex = 5;
            this.ratingTitleLabel.Text = "Rating";
            // 
            // checkinRating
            // 
            this.checkinRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkinRating.BottomMargin = 2;
            this.checkinRating.HoverColor = System.Drawing.Color.White;
            this.checkinRating.LeftMargin = 2;
            this.checkinRating.Location = new System.Drawing.Point(18, 30);
            this.checkinRating.Margin = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.checkinRating.Name = "checkinRating";
            this.checkinRating.OutlineColor = System.Drawing.Color.White;
            this.checkinRating.OutlineThickness = 1;
            this.checkinRating.RightMargin = 2;
            this.checkinRating.SelectedColor = System.Drawing.Color.White;
            this.checkinRating.Size = new System.Drawing.Size(511, 41);
            this.checkinRating.StarCount = 10;
            this.checkinRating.StarSpacing = 8;
            this.checkinRating.TabIndex = 1;
            this.checkinRating.Text = "Rating";
            this.checkinRating.TopMargin = 2;
            // 
            // filmInfoPanel
            // 
            this.filmInfoPanel.Controls.Add(this.tableLayoutPanel12);
            this.filmInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.filmInfoPanel.Name = "filmInfoPanel";
            this.filmInfoPanel.Size = new System.Drawing.Size(793, 425);
            this.filmInfoPanel.TabIndex = 22;
            this.filmInfoPanel.Visible = false;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(793, 425);
            this.tableLayoutPanel12.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.Controls.Add(this.addCheckinButton, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.addWishlistButton, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.trailerButton, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 387);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(787, 35);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // addCheckinButton
            // 
            this.addCheckinButton.AutoSize = true;
            this.addCheckinButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCheckinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCheckinButton.ForeColor = System.Drawing.Color.White;
            this.addCheckinButton.Location = new System.Drawing.Point(654, 0);
            this.addCheckinButton.Name = "addCheckinButton";
            this.addCheckinButton.Size = new System.Drawing.Size(130, 35);
            this.addCheckinButton.TabIndex = 11;
            this.addCheckinButton.Text = "Check in";
            this.addCheckinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addCheckinButton.Click += new System.EventHandler(this.addCheckinButton_Click);
            this.addCheckinButton.MouseEnter += new System.EventHandler(this.addCheckinButton_MouseEnter);
            this.addCheckinButton.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // addWishlistButton
            // 
            this.addWishlistButton.AutoSize = true;
            this.addWishlistButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addWishlistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWishlistButton.ForeColor = System.Drawing.Color.White;
            this.addWishlistButton.Location = new System.Drawing.Point(521, 0);
            this.addWishlistButton.Name = "addWishlistButton";
            this.addWishlistButton.Size = new System.Drawing.Size(127, 35);
            this.addWishlistButton.TabIndex = 12;
            this.addWishlistButton.Text = "Wishlist";
            this.addWishlistButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addWishlistButton.MouseEnter += new System.EventHandler(this.addWishlistButton_MouseEnter);
            this.addWishlistButton.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // trailerButton
            // 
            this.trailerButton.AutoSize = true;
            this.trailerButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.trailerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trailerButton.ForeColor = System.Drawing.Color.White;
            this.trailerButton.Location = new System.Drawing.Point(254, 0);
            this.trailerButton.Name = "trailerButton";
            this.trailerButton.Size = new System.Drawing.Size(73, 35);
            this.trailerButton.TabIndex = 13;
            this.trailerButton.Text = "Trailer";
            this.trailerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.trailerButton.MouseEnter += new System.EventHandler(this.trailerButton_MouseEnter);
            this.trailerButton.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.00378F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.99622F));
            this.tableLayoutPanel3.Controls.Add(this.filmImage, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(787, 378);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // filmImage
            // 
            this.filmImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.filmImage.Image = ((System.Drawing.Image)(resources.GetObject("filmImage.Image")));
            this.filmImage.Location = new System.Drawing.Point(10, 10);
            this.filmImage.Margin = new System.Windows.Forms.Padding(10);
            this.filmImage.Name = "filmImage";
            this.filmImage.Size = new System.Drawing.Size(208, 288);
            this.filmImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.filmImage.TabIndex = 0;
            this.filmImage.TabStop = false;
            this.filmImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filmImage_MouseClick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.filmInfoTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(231, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 372);
            this.panel1.TabIndex = 1;
            // 
            // filmInfoTable
            // 
            this.filmInfoTable.ColumnCount = 1;
            this.filmInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filmInfoTable.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.filmInfoTable.Controls.Add(this.tableLayoutPanel10, 0, 4);
            this.filmInfoTable.Controls.Add(this.tableLayoutPanel8, 0, 3);
            this.filmInfoTable.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.filmInfoTable.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.filmInfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmInfoTable.Location = new System.Drawing.Point(0, 0);
            this.filmInfoTable.Name = "filmInfoTable";
            this.filmInfoTable.RowCount = 5;
            this.filmInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.filmInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.filmInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.filmInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.filmInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.filmInfoTable.Size = new System.Drawing.Size(553, 372);
            this.filmInfoTable.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.overviewText, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.overviewTitleLabel, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(547, 81);
            this.tableLayoutPanel9.TabIndex = 6;
            // 
            // overviewText
            // 
            this.overviewText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.overviewText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.overviewText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewText.ForeColor = System.Drawing.Color.White;
            this.overviewText.Location = new System.Drawing.Point(3, 23);
            this.overviewText.Multiline = true;
            this.overviewText.Name = "overviewText";
            this.overviewText.Size = new System.Drawing.Size(541, 143);
            this.overviewText.TabIndex = 7;
            this.overviewText.Text = "d\r\nd\r\nd\r\nd\r\nd\r\ndd\r\ndd\r\nd\r\nd\r\nd";
            // 
            // overviewTitleLabel
            // 
            this.overviewTitleLabel.AutoSize = true;
            this.overviewTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewTitleLabel.ForeColor = System.Drawing.Color.White;
            this.overviewTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.overviewTitleLabel.Name = "overviewTitleLabel";
            this.overviewTitleLabel.Size = new System.Drawing.Size(72, 20);
            this.overviewTitleLabel.TabIndex = 5;
            this.overviewTitleLabel.Text = "Overview";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.Controls.Add(this.revenueTitleLabel, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.budgetTitleLabel, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.homepageTitleLabel, 2, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 390);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(547, 74);
            this.tableLayoutPanel10.TabIndex = 7;
            // 
            // revenueTitleLabel
            // 
            this.revenueTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.revenueTitleLabel.AutoSize = true;
            this.revenueTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueTitleLabel.ForeColor = System.Drawing.Color.White;
            this.revenueTitleLabel.Location = new System.Drawing.Point(185, 0);
            this.revenueTitleLabel.Name = "revenueTitleLabel";
            this.revenueTitleLabel.Size = new System.Drawing.Size(176, 37);
            this.revenueTitleLabel.TabIndex = 9;
            this.revenueTitleLabel.Text = "Revenue";
            this.revenueTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // budgetTitleLabel
            // 
            this.budgetTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budgetTitleLabel.AutoSize = true;
            this.budgetTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetTitleLabel.ForeColor = System.Drawing.Color.White;
            this.budgetTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.budgetTitleLabel.Name = "budgetTitleLabel";
            this.budgetTitleLabel.Size = new System.Drawing.Size(176, 37);
            this.budgetTitleLabel.TabIndex = 8;
            this.budgetTitleLabel.Text = "Budget";
            this.budgetTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homepageTitleLabel
            // 
            this.homepageTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homepageTitleLabel.AutoSize = true;
            this.homepageTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageTitleLabel.ForeColor = System.Drawing.Color.White;
            this.homepageTitleLabel.Location = new System.Drawing.Point(367, 0);
            this.homepageTitleLabel.Name = "homepageTitleLabel";
            this.homepageTitleLabel.Size = new System.Drawing.Size(177, 37);
            this.homepageTitleLabel.TabIndex = 10;
            this.homepageTitleLabel.Text = "Homepage";
            this.homepageTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Controls.Add(this.factsTitleLabel, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.statusTitleLabel, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.languageTitleLabel, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.runtimeTitleLabel, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.releaseTitleLabel, 3, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 290);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(547, 94);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // factsTitleLabel
            // 
            this.factsTitleLabel.AutoSize = true;
            this.factsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factsTitleLabel.ForeColor = System.Drawing.Color.White;
            this.factsTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.factsTitleLabel.Name = "factsTitleLabel";
            this.factsTitleLabel.Size = new System.Drawing.Size(49, 20);
            this.factsTitleLabel.TabIndex = 4;
            this.factsTitleLabel.Text = "Facts";
            // 
            // statusTitleLabel
            // 
            this.statusTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTitleLabel.AutoSize = true;
            this.statusTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTitleLabel.ForeColor = System.Drawing.Color.White;
            this.statusTitleLabel.Location = new System.Drawing.Point(3, 20);
            this.statusTitleLabel.Name = "statusTitleLabel";
            this.statusTitleLabel.Size = new System.Drawing.Size(130, 37);
            this.statusTitleLabel.TabIndex = 5;
            this.statusTitleLabel.Text = "Status";
            this.statusTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // languageTitleLabel
            // 
            this.languageTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languageTitleLabel.AutoSize = true;
            this.languageTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageTitleLabel.ForeColor = System.Drawing.Color.White;
            this.languageTitleLabel.Location = new System.Drawing.Point(139, 20);
            this.languageTitleLabel.Name = "languageTitleLabel";
            this.languageTitleLabel.Size = new System.Drawing.Size(130, 37);
            this.languageTitleLabel.TabIndex = 6;
            this.languageTitleLabel.Text = "Original Language";
            this.languageTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // runtimeTitleLabel
            // 
            this.runtimeTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runtimeTitleLabel.AutoSize = true;
            this.runtimeTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runtimeTitleLabel.ForeColor = System.Drawing.Color.White;
            this.runtimeTitleLabel.Location = new System.Drawing.Point(275, 20);
            this.runtimeTitleLabel.Name = "runtimeTitleLabel";
            this.runtimeTitleLabel.Size = new System.Drawing.Size(130, 37);
            this.runtimeTitleLabel.TabIndex = 7;
            this.runtimeTitleLabel.Text = "Runtime";
            this.runtimeTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // releaseTitleLabel
            // 
            this.releaseTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.releaseTitleLabel.AutoSize = true;
            this.releaseTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseTitleLabel.ForeColor = System.Drawing.Color.White;
            this.releaseTitleLabel.Location = new System.Drawing.Point(411, 20);
            this.releaseTitleLabel.Name = "releaseTitleLabel";
            this.releaseTitleLabel.Size = new System.Drawing.Size(133, 37);
            this.releaseTitleLabel.TabIndex = 9;
            this.releaseTitleLabel.Text = "Release Date";
            this.releaseTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel7.Controls.Add(this.crewTitleLabel, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 190);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(547, 94);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // crewTitleLabel
            // 
            this.crewTitleLabel.AutoSize = true;
            this.crewTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crewTitleLabel.ForeColor = System.Drawing.Color.White;
            this.crewTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.crewTitleLabel.Name = "crewTitleLabel";
            this.crewTitleLabel.Size = new System.Drawing.Size(114, 20);
            this.crewTitleLabel.TabIndex = 4;
            this.crewTitleLabel.Text = "Featured Crew";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.Controls.Add(this.castTitleLabel, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 90);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(547, 94);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // castTitleLabel
            // 
            this.castTitleLabel.AutoSize = true;
            this.castTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castTitleLabel.ForeColor = System.Drawing.Color.White;
            this.castTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.castTitleLabel.Name = "castTitleLabel";
            this.castTitleLabel.Size = new System.Drawing.Size(42, 20);
            this.castTitleLabel.TabIndex = 4;
            this.castTitleLabel.Text = "Cast";
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
            this.watchedPanel.Location = new System.Drawing.Point(-2, 0);
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
            this.libraryTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.libraryTable_MouseClick);
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
            this.headerPanel.Controls.Add(this.filmInfoHeaderPanel);
            this.headerPanel.Controls.Add(this.libraryHeaderPanel);
            this.headerPanel.Controls.Add(this.timelineHeaderPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(153, 31);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(793, 78);
            this.headerPanel.TabIndex = 4;
            // 
            // filmInfoHeaderPanel
            // 
            this.filmInfoHeaderPanel.Controls.Add(this.panel2);
            this.filmInfoHeaderPanel.Controls.Add(this.tableLayoutPanel11);
            this.filmInfoHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmInfoHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.filmInfoHeaderPanel.Name = "filmInfoHeaderPanel";
            this.filmInfoHeaderPanel.Size = new System.Drawing.Size(793, 78);
            this.filmInfoHeaderPanel.TabIndex = 4;
            this.filmInfoHeaderPanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.panel2.Controls.Add(this.pictureBox17);
            this.panel2.Controls.Add(this.pictureBox18);
            this.panel2.Controls.Add(this.searchTextBox2);
            this.panel2.Location = new System.Drawing.Point(551, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 33);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox17.BackgroundImage = global::MoviedApp.Properties.Resources.filterButton;
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox17.Location = new System.Drawing.Point(174, 8);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(18, 17);
            this.pictureBox17.TabIndex = 5;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox18.BackgroundImage = global::MoviedApp.Properties.Resources.searchButton;
            this.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox18.Location = new System.Drawing.Point(199, 8);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(18, 17);
            this.pictureBox18.TabIndex = 4;
            this.pictureBox18.TabStop = false;
            // 
            // searchTextBox2
            // 
            this.searchTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.searchTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox2.ForeColor = System.Drawing.Color.White;
            this.searchTextBox2.Location = new System.Drawing.Point(9, 2);
            this.searchTextBox2.Name = "searchTextBox2";
            this.searchTextBox2.Size = new System.Drawing.Size(159, 28);
            this.searchTextBox2.TabIndex = 3;
            this.searchTextBox2.Text = "search";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.filmNameLabel, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.05128F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.94872F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(793, 78);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // filmNameLabel
            // 
            this.filmNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.filmNameLabel.AutoSize = true;
            this.filmNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmNameLabel.ForeColor = System.Drawing.Color.White;
            this.filmNameLabel.Location = new System.Drawing.Point(236, 24);
            this.filmNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.filmNameLabel.Name = "filmNameLabel";
            this.filmNameLabel.Size = new System.Drawing.Size(557, 54);
            this.filmNameLabel.TabIndex = 2;
            this.filmNameLabel.Text = "STAR TREK BEYOND";
            this.filmNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // libraryHeaderPanel
            // 
            this.libraryHeaderPanel.Controls.Add(this.searchPanel);
            this.libraryHeaderPanel.Controls.Add(this.genreLabel);
            this.libraryHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.libraryHeaderPanel.Name = "libraryHeaderPanel";
            this.libraryHeaderPanel.Size = new System.Drawing.Size(793, 78);
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
            this.genreLabel.Location = new System.Drawing.Point(304, 22);
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
            this.timelineHeaderPanel.Size = new System.Drawing.Size(793, 78);
            this.timelineHeaderPanel.TabIndex = 2;
            this.timelineHeaderPanel.Visible = false;
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.ForeColor = System.Drawing.Color.White;
            this.homeLabel.Location = new System.Drawing.Point(283, 23);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(519, 69);
            this.homeLabel.TabIndex = 1;
            this.homeLabel.Text = "WELCOME BACK";
            // 
            // userPictureBox
            // 
            this.userPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.userPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userPictureBox.Image")));
            this.userPictureBox.Location = new System.Drawing.Point(37, 34);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(75, 75);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 5;
            this.userPictureBox.TabStop = false;
            this.userPictureBox.Click += new System.EventHandler(this.userPictureBox_Click);
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
            this.titleBar.Size = new System.Drawing.Size(949, 28);
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
            this.consolBox.Size = new System.Drawing.Size(99, 22);
            this.consolBox.TabIndex = 0;
            this.consolBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.consolBox_MouseClick);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.Controls.Add(this.tableLayoutPanel5);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(2, 2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(949, 543);
            this.loginPanel.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.pictureBox19, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.passwordTextBox, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.usernameTextBox, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.usernameError, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.passwordError, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.loginButton, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.alreadyloginError, 1, 7);
            this.tableLayoutPanel5.Controls.Add(this.createButton, 1, 8);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 10;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(949, 543);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox19.Image = global::MoviedApp.Properties.Resources.logo_movied;
            this.pictureBox19.Location = new System.Drawing.Point(352, 129);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(244, 50);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 7;
            this.pictureBox19.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(352, 285);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(244, 28);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "password";
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(352, 230);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(244, 28);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Text = "username";
            // 
            // usernameError
            // 
            this.usernameError.AutoSize = true;
            this.usernameError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameError.ForeColor = System.Drawing.Color.Red;
            this.usernameError.Location = new System.Drawing.Point(352, 212);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(244, 15);
            this.usernameError.TabIndex = 8;
            this.usernameError.Text = "Username is incorrect";
            this.usernameError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameError.Visible = false;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordError.ForeColor = System.Drawing.Color.Red;
            this.passwordError.Location = new System.Drawing.Point(352, 267);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(244, 15);
            this.passwordError.TabIndex = 9;
            this.passwordError.Text = "Password is incorrect";
            this.passwordError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordError.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(352, 322);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(244, 40);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.MouseEnter += new System.EventHandler(this.loginButton_MouseEnter);
            this.loginButton.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // alreadyloginError
            // 
            this.alreadyloginError.AutoSize = true;
            this.alreadyloginError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alreadyloginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alreadyloginError.ForeColor = System.Drawing.Color.Red;
            this.alreadyloginError.Location = new System.Drawing.Point(352, 362);
            this.alreadyloginError.Name = "alreadyloginError";
            this.alreadyloginError.Size = new System.Drawing.Size(244, 15);
            this.alreadyloginError.TabIndex = 10;
            this.alreadyloginError.Text = "Your already logged in on another device";
            this.alreadyloginError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alreadyloginError.Visible = false;
            // 
            // createButton
            // 
            this.createButton.AutoSize = true;
            this.createButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(352, 377);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(244, 40);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "create";
            this.createButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            this.createButton.MouseEnter += new System.EventHandler(this.createButton_MouseEnter);
            this.createButton.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 1;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Controls.Add(this.reviewTextBox, 0, 1);
            this.tableLayoutPanel18.Controls.Add(this.reviewTitleLabel, 0, 0);
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 2;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.Size = new System.Drawing.Size(547, 81);
            this.tableLayoutPanel18.TabIndex = 8;
            // 
            // reviewTitleLabel
            // 
            this.reviewTitleLabel.AutoSize = true;
            this.reviewTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewTitleLabel.ForeColor = System.Drawing.Color.White;
            this.reviewTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.reviewTitleLabel.Name = "reviewTitleLabel";
            this.reviewTitleLabel.Size = new System.Drawing.Size(60, 20);
            this.reviewTitleLabel.TabIndex = 5;
            this.reviewTitleLabel.Text = "Review";
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
            this.Controls.Add(this.loginPanel);
            this.Name = "HeadForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "HeadForm";
            this.ResizeEnd += new System.EventHandler(this.HeadForm_ResizeEnd);
            this.Layout.ResumeLayout(false);
            this.headPanel.ResumeLayout(false);
            this.checkinPanel.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.filmInfoPanel.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filmImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.filmInfoTable.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.wishlistPanel.ResumeLayout(false);
            this.wishlistPanel.PerformLayout();
            this.watchedPanel.ResumeLayout(false);
            this.watchedPanel.PerformLayout();
            this.friendsPanel.ResumeLayout(false);
            this.friendsPanel.PerformLayout();
            this.timelinePanel.ResumeLayout(false);
            this.timelinePanel.PerformLayout();
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
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.filmInfoHeaderPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.libraryHeaderPanel.ResumeLayout(false);
            this.libraryHeaderPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.timelineHeaderPanel.ResumeLayout(false);
            this.timelineHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
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
        private Panel filmInfoPanel;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel filmInfoHeaderPanel;
        private PictureBox filmImage;
        private Panel panel1;
        private TableLayoutPanel filmInfoTable;
        private TableLayoutPanel tableLayoutPanel6;
        private Label addCheckinButton;
        private Label addWishlistButton;
        private Label trailerButton;
        private TableLayoutPanel tableLayoutPanel9;
        private Label overviewTitleLabel;
        private TableLayoutPanel tableLayoutPanel8;
        private Label factsTitleLabel;
        private Label statusTitleLabel;
        private Label languageTitleLabel;
        private Label runtimeTitleLabel;
        private Label releaseTitleLabel;
        private TableLayoutPanel tableLayoutPanel7;
        private Label crewTitleLabel;
        private Label castTitleLabel;
        private TableLayoutPanel tableLayoutPanel10;
        private Label revenueTitleLabel;
        private Label budgetTitleLabel;
        private Label homepageTitleLabel;
        private TextBox overviewText;
        private Panel loginPanel;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label loginButton;
        private PictureBox pictureBox19;
        private Label usernameError;
        private Label passwordError;
        private PictureBox userPictureBox;
        private Label alreadyloginError;
        private Label createButton;
        private Panel panel2;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private TextBox searchTextBox2;
        private TableLayoutPanel tableLayoutPanel11;
        private Label filmNameLabel;
        private TableLayoutPanel tableLayoutPanel12;
        private Panel checkinPanel;
        private TableLayoutPanel tableLayoutPanel13;
        private TableLayoutPanel tableLayoutPanel14;
        private Label checkinConfirmButton;
        private TableLayoutPanel tableLayoutPanel15;
        private PictureBox pictureBox20;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel16;
        private TextBox reviewTextBox;
        private TableLayoutPanel tableLayoutPanel17;
        private Label ratingTitleLabel;
        private RatingControls.Rating checkinRating;
        private TableLayoutPanel tableLayoutPanel18;
        private Label reviewTitleLabel;
    }
}