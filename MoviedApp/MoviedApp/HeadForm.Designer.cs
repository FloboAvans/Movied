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
            this.filmImageCheckin = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.ratingTitleLabel = new System.Windows.Forms.Label();
            this.checkinRating = new RatingControls.Rating();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.reviewTextBox = new System.Windows.Forms.TextBox();
            this.reviewTitleLabel = new System.Windows.Forms.Label();
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
            this.overviewFilm = new System.Windows.Forms.TextBox();
            this.overviewTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.budgetFilm = new System.Windows.Forms.Label();
            this.revenueFilm = new System.Windows.Forms.Label();
            this.revenueTitleLabel = new System.Windows.Forms.Label();
            this.homepageFilm = new System.Windows.Forms.LinkLabel();
            this.budgetTitleLabel = new System.Windows.Forms.Label();
            this.homepageTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.languageFilm = new System.Windows.Forms.Label();
            this.factsTitleLabel = new System.Windows.Forms.Label();
            this.statusTitleLabel = new System.Windows.Forms.Label();
            this.languageTitleLabel = new System.Windows.Forms.Label();
            this.runtimeTitleLabel = new System.Windows.Forms.Label();
            this.releaseTitleLabel = new System.Windows.Forms.Label();
            this.releaseFilm = new System.Windows.Forms.Label();
            this.runtimeFilm = new System.Windows.Forms.Label();
            this.statusFilm = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.functionName1 = new System.Windows.Forms.Label();
            this.functionName3 = new System.Windows.Forms.Label();
            this.functionName2 = new System.Windows.Forms.Label();
            this.crewTitleLabel = new System.Windows.Forms.Label();
            this.crewName1 = new System.Windows.Forms.Label();
            this.crewName3 = new System.Windows.Forms.Label();
            this.crewName2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.roleName1 = new System.Windows.Forms.Label();
            this.roleName2 = new System.Windows.Forms.Label();
            this.roleName3 = new System.Windows.Forms.Label();
            this.castTitleLabel = new System.Windows.Forms.Label();
            this.castName1 = new System.Windows.Forms.Label();
            this.castName2 = new System.Windows.Forms.Label();
            this.castName3 = new System.Windows.Forms.Label();
            this.wishlistPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkinsPanel = new System.Windows.Forms.Panel();
            this.checkinsTable = new System.Windows.Forms.TableLayoutPanel();
            this.friendsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timelinePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.libraryPanel = new System.Windows.Forms.Panel();
            this.libraryTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.wishlistLabel = new System.Windows.Forms.Label();
            this.timelineLabel = new System.Windows.Forms.Label();
            this.libraryLabel = new System.Windows.Forms.Label();
            this.checkinsLabel = new System.Windows.Forms.Label();
            this.friendsLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.libraryHeaderPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.filterComingSoon = new System.Windows.Forms.Label();
            this.filterInTheater = new System.Windows.Forms.Label();
            this.filterMostPopular = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.filterButton = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.genreLabel = new System.Windows.Forms.Label();
            this.timelineHeaderPanel = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.filmInfoHeaderPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.searchTextBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.filmNameLabel = new System.Windows.Forms.Label();
            this.checkinsHeaderPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.filterLowestRatedCheckins = new System.Windows.Forms.Label();
            this.filterTopRatedCheckins = new System.Windows.Forms.Label();
            this.filterNewestCheckins = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.searchBoxCheckins = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.checkinsTitle = new System.Windows.Forms.Label();
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
            this.accountExistsError = new System.Windows.Forms.Label();
            this.Layout.SuspendLayout();
            this.headPanel.SuspendLayout();
            this.checkinPanel.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmImageCheckin)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
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
            this.checkinsPanel.SuspendLayout();
            this.friendsPanel.SuspendLayout();
            this.timelinePanel.SuspendLayout();
            this.libraryPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.libraryHeaderPanel.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.tableLayoutPanel20.SuspendLayout();
            this.timelineHeaderPanel.SuspendLayout();
            this.filmInfoHeaderPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            this.tableLayoutPanel11.SuspendLayout();
            this.checkinsHeaderPanel.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.titleBar.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
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
            this.headPanel.Controls.Add(this.checkinsPanel);
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
            this.checkinConfirmButton.Click += new System.EventHandler(this.checkinConfirmButton_Click);
            this.checkinConfirmButton.MouseEnter += new System.EventHandler(this.checkinConfirmButton_MouseEnter);
            this.checkinConfirmButton.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.AutoScroll = true;
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.00378F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.99622F));
            this.tableLayoutPanel15.Controls.Add(this.filmImageCheckin, 0, 0);
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
            // filmImageCheckin
            // 
            this.filmImageCheckin.Dock = System.Windows.Forms.DockStyle.Top;
            this.filmImageCheckin.Image = ((System.Drawing.Image)(resources.GetObject("filmImageCheckin.Image")));
            this.filmImageCheckin.Location = new System.Drawing.Point(10, 10);
            this.filmImageCheckin.Margin = new System.Windows.Forms.Padding(10);
            this.filmImageCheckin.Name = "filmImageCheckin";
            this.filmImageCheckin.Size = new System.Drawing.Size(208, 288);
            this.filmImageCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filmImageCheckin.TabIndex = 0;
            this.filmImageCheckin.TabStop = false;
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
            // reviewTextBox
            // 
            this.reviewTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.reviewTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reviewTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewTextBox.ForeColor = System.Drawing.Color.White;
            this.reviewTextBox.Location = new System.Drawing.Point(3, 23);
            this.reviewTextBox.Multiline = true;
            this.reviewTextBox.Name = "reviewTextBox";
            this.reviewTextBox.Size = new System.Drawing.Size(541, 70);
            this.reviewTextBox.TabIndex = 2;
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
            this.addWishlistButton.Click += new System.EventHandler(this.addWishlistButton_Click);
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
            this.filmImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.filmInfoTable.AutoScroll = true;
            this.filmInfoTable.ColumnCount = 1;
            this.filmInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filmInfoTable.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.filmInfoTable.Controls.Add(this.tableLayoutPanel10, 0, 8);
            this.filmInfoTable.Controls.Add(this.tableLayoutPanel8, 0, 6);
            this.filmInfoTable.Controls.Add(this.tableLayoutPanel7, 0, 4);
            this.filmInfoTable.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.filmInfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmInfoTable.Location = new System.Drawing.Point(0, 0);
            this.filmInfoTable.Name = "filmInfoTable";
            this.filmInfoTable.RowCount = 10;
            this.filmInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.filmInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.filmInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.filmInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.filmInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.filmInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.filmInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.filmInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.filmInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.filmInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.filmInfoTable.Size = new System.Drawing.Size(553, 372);
            this.filmInfoTable.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.overviewFilm, 0, 1);
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
            // overviewFilm
            // 
            this.overviewFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.overviewFilm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.overviewFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewFilm.ForeColor = System.Drawing.Color.White;
            this.overviewFilm.Location = new System.Drawing.Point(3, 23);
            this.overviewFilm.Multiline = true;
            this.overviewFilm.Name = "overviewFilm";
            this.overviewFilm.Size = new System.Drawing.Size(541, 143);
            this.overviewFilm.TabIndex = 7;
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
            this.tableLayoutPanel10.Controls.Add(this.budgetFilm, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.revenueFilm, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.revenueTitleLabel, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.homepageFilm, 2, 1);
            this.tableLayoutPanel10.Controls.Add(this.budgetTitleLabel, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.homepageTitleLabel, 2, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 430);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(547, 74);
            this.tableLayoutPanel10.TabIndex = 7;
            // 
            // budgetFilm
            // 
            this.budgetFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budgetFilm.AutoSize = true;
            this.budgetFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetFilm.ForeColor = System.Drawing.Color.White;
            this.budgetFilm.Location = new System.Drawing.Point(3, 37);
            this.budgetFilm.Name = "budgetFilm";
            this.budgetFilm.Size = new System.Drawing.Size(176, 37);
            this.budgetFilm.TabIndex = 13;
            this.budgetFilm.Text = "budgetFilm";
            this.budgetFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revenueFilm
            // 
            this.revenueFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.revenueFilm.AutoSize = true;
            this.revenueFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueFilm.ForeColor = System.Drawing.Color.White;
            this.revenueFilm.Location = new System.Drawing.Point(185, 37);
            this.revenueFilm.Name = "revenueFilm";
            this.revenueFilm.Size = new System.Drawing.Size(176, 37);
            this.revenueFilm.TabIndex = 12;
            this.revenueFilm.Text = "revenueFilm";
            this.revenueFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // homepageFilm
            // 
            this.homepageFilm.ActiveLinkColor = System.Drawing.Color.White;
            this.homepageFilm.AutoSize = true;
            this.homepageFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homepageFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageFilm.ForeColor = System.Drawing.Color.White;
            this.homepageFilm.LinkColor = System.Drawing.Color.White;
            this.homepageFilm.Location = new System.Drawing.Point(367, 37);
            this.homepageFilm.Name = "homepageFilm";
            this.homepageFilm.Size = new System.Drawing.Size(177, 37);
            this.homepageFilm.TabIndex = 14;
            this.homepageFilm.TabStop = true;
            this.homepageFilm.Text = "homepageFilm";
            this.homepageFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homepageFilm.VisitedLinkColor = System.Drawing.Color.White;
            this.homepageFilm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homepageFilm_LinkClicked);
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
            this.tableLayoutPanel8.Controls.Add(this.languageFilm, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.factsTitleLabel, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.statusTitleLabel, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.languageTitleLabel, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.runtimeTitleLabel, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.releaseTitleLabel, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.releaseFilm, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.runtimeFilm, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.statusFilm, 0, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 320);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(547, 94);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // languageFilm
            // 
            this.languageFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languageFilm.AutoSize = true;
            this.languageFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageFilm.ForeColor = System.Drawing.Color.White;
            this.languageFilm.Location = new System.Drawing.Point(139, 57);
            this.languageFilm.Name = "languageFilm";
            this.languageFilm.Size = new System.Drawing.Size(130, 37);
            this.languageFilm.TabIndex = 13;
            this.languageFilm.Text = "languageFilm";
            this.languageFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // releaseFilm
            // 
            this.releaseFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.releaseFilm.AutoSize = true;
            this.releaseFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseFilm.ForeColor = System.Drawing.Color.White;
            this.releaseFilm.Location = new System.Drawing.Point(411, 57);
            this.releaseFilm.Name = "releaseFilm";
            this.releaseFilm.Size = new System.Drawing.Size(133, 37);
            this.releaseFilm.TabIndex = 12;
            this.releaseFilm.Text = "releaseFilm";
            this.releaseFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // runtimeFilm
            // 
            this.runtimeFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runtimeFilm.AutoSize = true;
            this.runtimeFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runtimeFilm.ForeColor = System.Drawing.Color.White;
            this.runtimeFilm.Location = new System.Drawing.Point(275, 57);
            this.runtimeFilm.Name = "runtimeFilm";
            this.runtimeFilm.Size = new System.Drawing.Size(130, 37);
            this.runtimeFilm.TabIndex = 11;
            this.runtimeFilm.Text = "runtimeFilm";
            this.runtimeFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusFilm
            // 
            this.statusFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusFilm.AutoSize = true;
            this.statusFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusFilm.ForeColor = System.Drawing.Color.White;
            this.statusFilm.Location = new System.Drawing.Point(3, 57);
            this.statusFilm.Name = "statusFilm";
            this.statusFilm.Size = new System.Drawing.Size(130, 37);
            this.statusFilm.TabIndex = 10;
            this.statusFilm.Text = "statusFilm";
            this.statusFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel7.Controls.Add(this.functionName1, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.functionName3, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.functionName2, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.crewTitleLabel, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.crewName1, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.crewName3, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.crewName2, 1, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 210);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(547, 94);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // functionName1
            // 
            this.functionName1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionName1.AutoSize = true;
            this.functionName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionName1.ForeColor = System.Drawing.Color.White;
            this.functionName1.Location = new System.Drawing.Point(3, 57);
            this.functionName1.Name = "functionName1";
            this.functionName1.Size = new System.Drawing.Size(176, 37);
            this.functionName1.TabIndex = 12;
            this.functionName1.Text = "functionName1";
            this.functionName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // functionName3
            // 
            this.functionName3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionName3.AutoSize = true;
            this.functionName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionName3.ForeColor = System.Drawing.Color.White;
            this.functionName3.Location = new System.Drawing.Point(367, 57);
            this.functionName3.Name = "functionName3";
            this.functionName3.Size = new System.Drawing.Size(177, 37);
            this.functionName3.TabIndex = 11;
            this.functionName3.Text = "functionName3";
            this.functionName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // functionName2
            // 
            this.functionName2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionName2.AutoSize = true;
            this.functionName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionName2.ForeColor = System.Drawing.Color.White;
            this.functionName2.Location = new System.Drawing.Point(185, 57);
            this.functionName2.Name = "functionName2";
            this.functionName2.Size = new System.Drawing.Size(176, 37);
            this.functionName2.TabIndex = 10;
            this.functionName2.Text = "functionName2";
            this.functionName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // crewName1
            // 
            this.crewName1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crewName1.AutoSize = true;
            this.crewName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crewName1.ForeColor = System.Drawing.Color.White;
            this.crewName1.Location = new System.Drawing.Point(3, 20);
            this.crewName1.Name = "crewName1";
            this.crewName1.Size = new System.Drawing.Size(176, 37);
            this.crewName1.TabIndex = 9;
            this.crewName1.Text = "crewName1";
            this.crewName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crewName3
            // 
            this.crewName3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crewName3.AutoSize = true;
            this.crewName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crewName3.ForeColor = System.Drawing.Color.White;
            this.crewName3.Location = new System.Drawing.Point(367, 20);
            this.crewName3.Name = "crewName3";
            this.crewName3.Size = new System.Drawing.Size(177, 37);
            this.crewName3.TabIndex = 8;
            this.crewName3.Text = "crewName3";
            this.crewName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crewName2
            // 
            this.crewName2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crewName2.AutoSize = true;
            this.crewName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crewName2.ForeColor = System.Drawing.Color.White;
            this.crewName2.Location = new System.Drawing.Point(185, 20);
            this.crewName2.Name = "crewName2";
            this.crewName2.Size = new System.Drawing.Size(176, 37);
            this.crewName2.TabIndex = 7;
            this.crewName2.Text = "crewName2";
            this.crewName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.Controls.Add(this.roleName1, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.roleName2, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.roleName3, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.castTitleLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.castName1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.castName2, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.castName3, 2, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 100);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(547, 94);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // roleName1
            // 
            this.roleName1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roleName1.AutoSize = true;
            this.roleName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleName1.ForeColor = System.Drawing.Color.White;
            this.roleName1.Location = new System.Drawing.Point(3, 57);
            this.roleName1.Name = "roleName1";
            this.roleName1.Size = new System.Drawing.Size(176, 37);
            this.roleName1.TabIndex = 11;
            this.roleName1.Text = "roleName2";
            this.roleName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roleName2
            // 
            this.roleName2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roleName2.AutoSize = true;
            this.roleName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleName2.ForeColor = System.Drawing.Color.White;
            this.roleName2.Location = new System.Drawing.Point(185, 57);
            this.roleName2.Name = "roleName2";
            this.roleName2.Size = new System.Drawing.Size(176, 37);
            this.roleName2.TabIndex = 10;
            this.roleName2.Text = "roleName2";
            this.roleName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roleName3
            // 
            this.roleName3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roleName3.AutoSize = true;
            this.roleName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleName3.ForeColor = System.Drawing.Color.White;
            this.roleName3.Location = new System.Drawing.Point(367, 57);
            this.roleName3.Name = "roleName3";
            this.roleName3.Size = new System.Drawing.Size(177, 37);
            this.roleName3.TabIndex = 9;
            this.roleName3.Text = "roleName3";
            this.roleName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // castName1
            // 
            this.castName1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.castName1.AutoSize = true;
            this.castName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castName1.ForeColor = System.Drawing.Color.White;
            this.castName1.Location = new System.Drawing.Point(3, 20);
            this.castName1.Name = "castName1";
            this.castName1.Size = new System.Drawing.Size(176, 37);
            this.castName1.TabIndex = 6;
            this.castName1.Text = "castName1";
            this.castName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // castName2
            // 
            this.castName2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.castName2.AutoSize = true;
            this.castName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castName2.ForeColor = System.Drawing.Color.White;
            this.castName2.Location = new System.Drawing.Point(185, 20);
            this.castName2.Name = "castName2";
            this.castName2.Size = new System.Drawing.Size(176, 37);
            this.castName2.TabIndex = 7;
            this.castName2.Text = "castName2";
            this.castName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // castName3
            // 
            this.castName3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.castName3.AutoSize = true;
            this.castName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castName3.ForeColor = System.Drawing.Color.White;
            this.castName3.Location = new System.Drawing.Point(367, 20);
            this.castName3.Name = "castName3";
            this.castName3.Size = new System.Drawing.Size(177, 37);
            this.castName3.TabIndex = 8;
            this.castName3.Text = "castName3";
            this.castName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // checkinsPanel
            // 
            this.checkinsPanel.Controls.Add(this.checkinsTable);
            this.checkinsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkinsPanel.Location = new System.Drawing.Point(0, 0);
            this.checkinsPanel.Name = "checkinsPanel";
            this.checkinsPanel.Size = new System.Drawing.Size(793, 425);
            this.checkinsPanel.TabIndex = 21;
            this.checkinsPanel.Visible = false;
            // 
            // checkinsTable
            // 
            this.checkinsTable.AutoScroll = true;
            this.checkinsTable.BackColor = System.Drawing.Color.Transparent;
            this.checkinsTable.ColumnCount = 6;
            this.checkinsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.checkinsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.checkinsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.checkinsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.checkinsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.checkinsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.checkinsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkinsTable.Location = new System.Drawing.Point(0, 0);
            this.checkinsTable.Name = "checkinsTable";
            this.checkinsTable.RowCount = 5;
            this.checkinsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.checkinsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.checkinsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.checkinsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.checkinsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.checkinsTable.Size = new System.Drawing.Size(793, 425);
            this.checkinsTable.TabIndex = 1;
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
            this.libraryTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryTable.Location = new System.Drawing.Point(0, 0);
            this.libraryTable.Name = "libraryTable";
            this.libraryTable.RowCount = 5;
            this.libraryTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.libraryTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.libraryTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.libraryTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.libraryTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.libraryTable.Size = new System.Drawing.Size(793, 425);
            this.libraryTable.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.usernameLabel, 0, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 115);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(144, 425);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MoviedApp.Properties.Resources.logo_movied;
            this.pictureBox1.Location = new System.Drawing.Point(15, 402);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 20);
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
            this.tableLayoutPanel2.Controls.Add(this.checkinsLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.friendsLabel, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 107);
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
            // checkinsLabel
            // 
            this.checkinsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkinsLabel.AutoSize = true;
            this.checkinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinsLabel.ForeColor = System.Drawing.Color.White;
            this.checkinsLabel.Location = new System.Drawing.Point(3, 120);
            this.checkinsLabel.Name = "checkinsLabel";
            this.checkinsLabel.Size = new System.Drawing.Size(132, 40);
            this.checkinsLabel.TabIndex = 3;
            this.checkinsLabel.Text = "Check-ins";
            this.checkinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkinsLabel.Click += new System.EventHandler(this.checkinsLabel_Click);
            this.checkinsLabel.MouseEnter += new System.EventHandler(this.checkinsLabel_MouseEnter);
            this.checkinsLabel.MouseLeave += new System.EventHandler(this.label_MouseLeave);
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
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLabel.Location = new System.Drawing.Point(3, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(138, 15);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "no user";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.libraryHeaderPanel);
            this.headerPanel.Controls.Add(this.timelineHeaderPanel);
            this.headerPanel.Controls.Add(this.filmInfoHeaderPanel);
            this.headerPanel.Controls.Add(this.checkinsHeaderPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(153, 31);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(793, 78);
            this.headerPanel.TabIndex = 4;
            // 
            // libraryHeaderPanel
            // 
            this.libraryHeaderPanel.Controls.Add(this.tableLayoutPanel19);
            this.libraryHeaderPanel.Controls.Add(this.searchPanel);
            this.libraryHeaderPanel.Controls.Add(this.tableLayoutPanel20);
            this.libraryHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.libraryHeaderPanel.Name = "libraryHeaderPanel";
            this.libraryHeaderPanel.Size = new System.Drawing.Size(793, 78);
            this.libraryHeaderPanel.TabIndex = 3;
            this.libraryHeaderPanel.Visible = false;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 3;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel19.Controls.Add(this.filterComingSoon, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.filterInTheater, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.filterMostPopular, 0, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(793, 34);
            this.tableLayoutPanel19.TabIndex = 5;
            // 
            // filterComingSoon
            // 
            this.filterComingSoon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterComingSoon.AutoSize = true;
            this.filterComingSoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComingSoon.ForeColor = System.Drawing.Color.White;
            this.filterComingSoon.Location = new System.Drawing.Point(531, 0);
            this.filterComingSoon.Name = "filterComingSoon";
            this.filterComingSoon.Size = new System.Drawing.Size(259, 34);
            this.filterComingSoon.TabIndex = 3;
            this.filterComingSoon.Text = "coming soon";
            this.filterComingSoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filterComingSoon.Click += new System.EventHandler(this.filterComingSoon_Click);
            this.filterComingSoon.MouseEnter += new System.EventHandler(this.filterComingSoon_MouseEnter);
            this.filterComingSoon.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // filterInTheater
            // 
            this.filterInTheater.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterInTheater.AutoSize = true;
            this.filterInTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterInTheater.ForeColor = System.Drawing.Color.White;
            this.filterInTheater.Location = new System.Drawing.Point(267, 0);
            this.filterInTheater.Name = "filterInTheater";
            this.filterInTheater.Size = new System.Drawing.Size(258, 34);
            this.filterInTheater.TabIndex = 2;
            this.filterInTheater.Text = "in theater";
            this.filterInTheater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filterInTheater.Click += new System.EventHandler(this.filterInTheater_Click);
            this.filterInTheater.MouseEnter += new System.EventHandler(this.filterInTheater_MouseEnter);
            this.filterInTheater.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // filterMostPopular
            // 
            this.filterMostPopular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterMostPopular.AutoSize = true;
            this.filterMostPopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterMostPopular.ForeColor = System.Drawing.Color.White;
            this.filterMostPopular.Location = new System.Drawing.Point(3, 0);
            this.filterMostPopular.Name = "filterMostPopular";
            this.filterMostPopular.Size = new System.Drawing.Size(258, 34);
            this.filterMostPopular.TabIndex = 1;
            this.filterMostPopular.Text = "most popular";
            this.filterMostPopular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filterMostPopular.Click += new System.EventHandler(this.filterMostPopular_Click);
            this.filterMostPopular.MouseEnter += new System.EventHandler(this.filterMostPopular_MouseEnter);
            this.filterMostPopular.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.searchPanel.Controls.Add(this.filterButton);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Location = new System.Drawing.Point(3, 40);
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
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 1;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Controls.Add(this.genreLabel, 0, 1);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 2;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.05128F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.94872F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(793, 78);
            this.tableLayoutPanel20.TabIndex = 6;
            // 
            // genreLabel
            // 
            this.genreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.ForeColor = System.Drawing.Color.White;
            this.genreLabel.Location = new System.Drawing.Point(284, 24);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(506, 54);
            this.genreLabel.TabIndex = 0;
            this.genreLabel.Text = "MOST POPULAR";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            // filmInfoHeaderPanel
            // 
            this.filmInfoHeaderPanel.Controls.Add(this.backButton);
            this.filmInfoHeaderPanel.Controls.Add(this.panel2);
            this.filmInfoHeaderPanel.Controls.Add(this.tableLayoutPanel11);
            this.filmInfoHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmInfoHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.filmInfoHeaderPanel.Name = "filmInfoHeaderPanel";
            this.filmInfoHeaderPanel.Size = new System.Drawing.Size(793, 78);
            this.filmInfoHeaderPanel.TabIndex = 4;
            this.filmInfoHeaderPanel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(64, 29);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.label_MouseLeave);
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
            // checkinsHeaderPanel
            // 
            this.checkinsHeaderPanel.Controls.Add(this.tableLayoutPanel21);
            this.checkinsHeaderPanel.Controls.Add(this.panel5);
            this.checkinsHeaderPanel.Controls.Add(this.tableLayoutPanel22);
            this.checkinsHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkinsHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.checkinsHeaderPanel.Name = "checkinsHeaderPanel";
            this.checkinsHeaderPanel.Size = new System.Drawing.Size(793, 78);
            this.checkinsHeaderPanel.TabIndex = 5;
            this.checkinsHeaderPanel.Visible = false;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 3;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel21.Controls.Add(this.filterLowestRatedCheckins, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.filterTopRatedCheckins, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.filterNewestCheckins, 0, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(793, 34);
            this.tableLayoutPanel21.TabIndex = 5;
            // 
            // filterLowestRatedCheckins
            // 
            this.filterLowestRatedCheckins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterLowestRatedCheckins.AutoSize = true;
            this.filterLowestRatedCheckins.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLowestRatedCheckins.ForeColor = System.Drawing.Color.White;
            this.filterLowestRatedCheckins.Location = new System.Drawing.Point(531, 0);
            this.filterLowestRatedCheckins.Name = "filterLowestRatedCheckins";
            this.filterLowestRatedCheckins.Size = new System.Drawing.Size(259, 34);
            this.filterLowestRatedCheckins.TabIndex = 3;
            this.filterLowestRatedCheckins.Text = "lowest rated";
            this.filterLowestRatedCheckins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filterLowestRatedCheckins.Click += new System.EventHandler(this.filterLowestRatedCheckins_Click);
            this.filterLowestRatedCheckins.MouseEnter += new System.EventHandler(this.filterLowestRatedCheckins_MouseEnter);
            this.filterLowestRatedCheckins.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // filterTopRatedCheckins
            // 
            this.filterTopRatedCheckins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterTopRatedCheckins.AutoSize = true;
            this.filterTopRatedCheckins.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTopRatedCheckins.ForeColor = System.Drawing.Color.White;
            this.filterTopRatedCheckins.Location = new System.Drawing.Point(267, 0);
            this.filterTopRatedCheckins.Name = "filterTopRatedCheckins";
            this.filterTopRatedCheckins.Size = new System.Drawing.Size(258, 34);
            this.filterTopRatedCheckins.TabIndex = 2;
            this.filterTopRatedCheckins.Text = "top rated";
            this.filterTopRatedCheckins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filterTopRatedCheckins.Click += new System.EventHandler(this.filterTopRatedCheckins_Click);
            this.filterTopRatedCheckins.MouseEnter += new System.EventHandler(this.filterTopRatedCheckins_MouseEnter);
            this.filterTopRatedCheckins.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // filterNewestCheckins
            // 
            this.filterNewestCheckins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterNewestCheckins.AutoSize = true;
            this.filterNewestCheckins.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterNewestCheckins.ForeColor = System.Drawing.Color.White;
            this.filterNewestCheckins.Location = new System.Drawing.Point(3, 0);
            this.filterNewestCheckins.Name = "filterNewestCheckins";
            this.filterNewestCheckins.Size = new System.Drawing.Size(258, 34);
            this.filterNewestCheckins.TabIndex = 1;
            this.filterNewestCheckins.Text = "newest";
            this.filterNewestCheckins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filterNewestCheckins.Click += new System.EventHandler(this.filterNewestCheckins_Click);
            this.filterNewestCheckins.MouseEnter += new System.EventHandler(this.filterNewestCheckins_MouseEnter);
            this.filterNewestCheckins.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.searchBoxCheckins);
            this.panel5.Location = new System.Drawing.Point(3, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(309, 34);
            this.panel5.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::MoviedApp.Properties.Resources.filterButton;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(258, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = global::MoviedApp.Properties.Resources.searchButton;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(283, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 18);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // searchBoxCheckins
            // 
            this.searchBoxCheckins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.searchBoxCheckins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBoxCheckins.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxCheckins.ForeColor = System.Drawing.Color.White;
            this.searchBoxCheckins.Location = new System.Drawing.Point(9, 2);
            this.searchBoxCheckins.Name = "searchBoxCheckins";
            this.searchBoxCheckins.Size = new System.Drawing.Size(243, 28);
            this.searchBoxCheckins.TabIndex = 3;
            this.searchBoxCheckins.Text = "search";
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 1;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Controls.Add(this.checkinsTitle, 0, 1);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 2;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.05128F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.94872F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(793, 78);
            this.tableLayoutPanel22.TabIndex = 6;
            // 
            // checkinsTitle
            // 
            this.checkinsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkinsTitle.AutoSize = true;
            this.checkinsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinsTitle.ForeColor = System.Drawing.Color.White;
            this.checkinsTitle.Location = new System.Drawing.Point(431, 24);
            this.checkinsTitle.Name = "checkinsTitle";
            this.checkinsTitle.Size = new System.Drawing.Size(359, 54);
            this.checkinsTitle.TabIndex = 0;
            this.checkinsTitle.Text = "CHECK-INS";
            this.checkinsTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            this.loginPanel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginPanel_KeyDown);
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
            this.tableLayoutPanel5.Controls.Add(this.accountExistsError, 1, 9);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 11;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(949, 543);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox19.Image = global::MoviedApp.Properties.Resources.logo_movied;
            this.pictureBox19.Location = new System.Drawing.Point(352, 121);
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
            this.passwordTextBox.Location = new System.Drawing.Point(352, 277);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(244, 28);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "password";
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
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
            this.usernameTextBox.Location = new System.Drawing.Point(352, 222);
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
            this.usernameError.Location = new System.Drawing.Point(352, 204);
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
            this.passwordError.Location = new System.Drawing.Point(352, 259);
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
            this.loginButton.Location = new System.Drawing.Point(352, 314);
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
            this.alreadyloginError.Location = new System.Drawing.Point(352, 354);
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
            this.createButton.Location = new System.Drawing.Point(352, 369);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(244, 40);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "create";
            this.createButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            this.createButton.MouseEnter += new System.EventHandler(this.createButton_MouseEnter);
            this.createButton.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // accountExistsError
            // 
            this.accountExistsError.AutoSize = true;
            this.accountExistsError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountExistsError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountExistsError.ForeColor = System.Drawing.Color.Red;
            this.accountExistsError.Location = new System.Drawing.Point(352, 409);
            this.accountExistsError.Name = "accountExistsError";
            this.accountExistsError.Size = new System.Drawing.Size(244, 15);
            this.accountExistsError.TabIndex = 12;
            this.accountExistsError.Text = "Account already exists";
            this.accountExistsError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accountExistsError.Visible = false;
            // 
            // HeadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MoviedApp.Properties.Resources.background_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 547);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.Layout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(969, 39);
            this.Name = "HeadForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "HeadForm";
            this.Layout.ResumeLayout(false);
            this.headPanel.ResumeLayout(false);
            this.checkinPanel.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filmImageCheckin)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
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
            this.checkinsPanel.ResumeLayout(false);
            this.friendsPanel.ResumeLayout(false);
            this.friendsPanel.PerformLayout();
            this.timelinePanel.ResumeLayout(false);
            this.timelinePanel.PerformLayout();
            this.libraryPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.libraryHeaderPanel.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.timelineHeaderPanel.ResumeLayout(false);
            this.timelineHeaderPanel.PerformLayout();
            this.filmInfoHeaderPanel.ResumeLayout(false);
            this.filmInfoHeaderPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.checkinsHeaderPanel.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel Layout;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label friendsLabel;
        private Label libraryLabel;
        private Label checkinsLabel;
        public Label wishlistLabel;
        public Label timelineLabel;
        private TableLayoutPanel titleBar;
        private TableLayoutPanel consolBox;
        private Panel headPanel;
        private Panel libraryPanel;
        private Panel headerPanel;
        private Panel friendsPanel;
        private Label label2;
        private Panel timelinePanel;
        private Label label1;
        private Panel wishlistPanel;
        private Label label4;
        private Panel checkinsPanel;
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
        private TextBox overviewFilm;
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
        private PictureBox filmImageCheckin;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel16;
        private TextBox reviewTextBox;
        private TableLayoutPanel tableLayoutPanel17;
        private Label ratingTitleLabel;
        private RatingControls.Rating checkinRating;
        private TableLayoutPanel tableLayoutPanel18;
        private Label reviewTitleLabel;
        private TableLayoutPanel libraryTable;
        private Label budgetFilm;
        private Label revenueFilm;
        private Label languageFilm;
        private Label releaseFilm;
        private Label runtimeFilm;
        private Label statusFilm;
        private Label functionName1;
        private Label functionName3;
        private Label functionName2;
        private Label crewName1;
        private Label crewName3;
        private Label crewName2;
        private Label roleName1;
        private Label roleName2;
        private Label roleName3;
        private Label castName1;
        private Label castName2;
        private Label castName3;
        private LinkLabel homepageFilm;
        private Label accountExistsError;
        private TableLayoutPanel tableLayoutPanel19;
        public Label filterComingSoon;
        public Label filterInTheater;
        public Label filterMostPopular;
        private Label backButton;
        private Label usernameLabel;
        private TableLayoutPanel tableLayoutPanel20;
        private TableLayoutPanel checkinsTable;
        private Panel checkinsHeaderPanel;
        private TableLayoutPanel tableLayoutPanel21;
        public Label filterLowestRatedCheckins;
        public Label filterTopRatedCheckins;
        public Label filterNewestCheckins;
        private Panel panel5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox searchBoxCheckins;
        private TableLayoutPanel tableLayoutPanel22;
        private Label checkinsTitle;
    }
}