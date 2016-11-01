using System;
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
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.wishlistLabel = new System.Windows.Forms.Label();
            this.timelineLabel = new System.Windows.Forms.Label();
            this.libraryLabel = new System.Windows.Forms.Label();
            this.watchedLabel = new System.Windows.Forms.Label();
            this.friendsLabel = new System.Windows.Forms.Label();
            this.headPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.TableLayoutPanel();
            this.consolBox = new System.Windows.Forms.TableLayoutPanel();
            this.Layout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.headPanel.SuspendLayout();
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
            this.Layout.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.Layout.Controls.Add(this.headPanel, 1, 1);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Location = new System.Drawing.Point(0, 0);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 2;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.Size = new System.Drawing.Size(991, 547);
            this.Layout.TabIndex = 0;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(144, 441);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MoviedApp.Properties.Resources.logo_movied;
            this.pictureBox1.Location = new System.Drawing.Point(15, 403);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 100);
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
            this.friendsLabel.MouseEnter += new System.EventHandler(this.friendsLabel_MouseEnter);
            this.friendsLabel.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // headPanel
            // 
            this.headPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headPanel.BackColor = System.Drawing.Color.LightGray;
            this.headPanel.Controls.Add(this.panel1);
            this.headPanel.Location = new System.Drawing.Point(153, 103);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(835, 441);
            this.headPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 441);
            this.panel1.TabIndex = 0;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Transparent;
            this.titleBar.ColumnCount = 1;
            this.titleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.titleBar.Controls.Add(this.consolBox, 0, 0);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.RowCount = 1;
            this.titleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.titleBar.Size = new System.Drawing.Size(991, 31);
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
            this.consolBox.Location = new System.Drawing.Point(889, 3);
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
            this.ClientSize = new System.Drawing.Size(991, 547);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.Layout);
            this.Name = "HeadForm";
            this.Opacity = 0.95D;
            this.Text = "HeadForm";
            this.Layout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.headPanel.ResumeLayout(false);
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
        private Panel panel1;
    }
}