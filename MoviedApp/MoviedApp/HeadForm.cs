using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.TMDb;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HashingTest;
using MoviedApp.Properties;
using RatingControls;
using Image = System.Drawing.Image;
using Resources = MoviedApp.Properties.Resources;

namespace MoviedApp
{
    public partial class HeadForm : Form
    {
        private FontFamily _quicksandLight;
        private FontFamily _quicksandRegular;
        private FontFamily _quicksandBold;

        private MovieApiCalls apiCalls;

        private static string apiKey = "c84acd026332c3ab0c37200ff32e6f07";

        public HeadForm()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.FormBorderStyle = FormBorderStyle.None;

            this.apiCalls = new MovieApiCalls("c84acd026332c3ab0c37200ff32e6f07");

            CargoPrivateFontCollection();
            Fonts();

            clearAllPanels();

            libraryTable.AutoScroll = false;
            libraryTable.HorizontalScroll.Enabled = false;
            libraryTable.HorizontalScroll.Visible = false;
            libraryTable.HorizontalScroll.Maximum = 0;
            libraryTable.AutoScroll = true;

            filmInfoTable.AutoScroll = false;
            filmInfoTable.HorizontalScroll.Enabled = false;
            filmInfoTable.HorizontalScroll.Visible = false;
            filmInfoTable.HorizontalScroll.Maximum = 0;
            filmInfoTable.AutoScroll = true;

            SetPlaceHolder(searchTextBox, "search");
            SetPlaceHolder(searchTextBox2, "search");
            SetPlaceHolder(usernameTextBox, "username");
            SetPlaceHolder(passwordTextBox, "password");
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            const UInt32 WM_NCHITTEST = 0x0084;
            const UInt32 WM_MOUSEMOVE = 0x0200;

            const UInt32 HTLEFT = 10;
            const UInt32 HTRIGHT = 11;
            const UInt32 HTBOTTOMRIGHT = 17;
            const UInt32 HTBOTTOM = 15;
            const UInt32 HTBOTTOMLEFT = 16;
            const UInt32 HTTOP = 12;
            const UInt32 HTTOPLEFT = 13;
            const UInt32 HTTOPRIGHT = 14;

            const int RESIZE_HANDLE_SIZE = 10;
            bool handled = false;
            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
            {
                Size formSize = this.Size;
                Point screenPoint = new Point(m.LParam.ToInt32());
                Point clientPoint = this.PointToClient(screenPoint);

                Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>() {
        {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
        {HTBOTTOM, new Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
        {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
        {HTRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)},
        {HTTOPRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
        {HTTOP, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
        {HTTOPLEFT, new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
        {HTLEFT, new Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE) }
            };

                foreach (KeyValuePair<UInt32, Rectangle> hitBox in boxes)
                {
                    if (this.WindowState != FormWindowState.Maximized
                        && hitBox.Value.Contains(clientPoint))
                    {
                        m.Result = (IntPtr)hitBox.Key;
                        handled = true;
                        break;
                    }
                }
            }

            if (!handled)
                base.WndProc(ref m);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void titleBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private Point GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return new Point(999, 999); ;

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            return new Point(col, row);
        }

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private void CargoPrivateFontCollection()
        {
            int count = 0;
            // Create the byte array and get its length
            while (count < 3)
            {
                byte[] fontArray;
                int dataLength;
                if (count == 1)
                {
                    fontArray = Resources.Quicksand_Regular;
                    dataLength = Resources.Quicksand_Regular.Length;
                }
                else if (count == 2)
                {
                    fontArray = Resources.Quicksand_Bold;
                    dataLength = Resources.Quicksand_Bold.Length;
                }
                else
                {
                   fontArray = Resources.Quicksand_Light;
                   dataLength = Resources.Quicksand_Light.Length;
                }

                // ASSIGN MEMORY AND COPY  BYTE[] ON THAT MEMORY ADDRESS
                var ptrData = Marshal.AllocCoTaskMem(dataLength);
                Marshal.Copy(fontArray, 0, ptrData, dataLength);

                uint cFonts = 0;
                AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

                var pfc = new PrivateFontCollection();
                //PASS THE FONT TO THE  PRIVATEFONTCOLLECTION OBJECT
                pfc.AddMemoryFont(ptrData, dataLength);

                //FREE THE  "UNSAFE" MEMORY
                Marshal.FreeCoTaskMem(ptrData);
                if (count == 1)
                {
                    _quicksandRegular = pfc.Families[0];
                }
                else if (count == 2)
                {
                    _quicksandBold = pfc.Families[0];
                }
                else
                {
                    _quicksandLight = pfc.Families[0];
                }
                count++;
            }
            
        }

        private void Fonts()
        {
            timelineLabel.Font = new Font(_quicksandRegular, 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            libraryLabel.Font = new Font(_quicksandRegular, 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            friendsLabel.Font = new Font(_quicksandRegular, 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            watchedLabel.Font = new Font(_quicksandRegular, 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            wishlistLabel.Font = new Font(_quicksandRegular, 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            homeLabel.Font = new Font(_quicksandLight, 45F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            genreLabel.Font = new Font(_quicksandLight, 45F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            filmNameLabel.Font = new Font(_quicksandLight, 45F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            overviewTitleLabel.Font = new Font(_quicksandRegular, 12F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            castTitleLabel.Font = new Font(_quicksandRegular, 12F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            crewTitleLabel.Font = new Font(_quicksandRegular, 12F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            factsTitleLabel.Font = new Font(_quicksandRegular, 12F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));

            overviewFilm.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            statusTitleLabel.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            languageTitleLabel.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            runtimeTitleLabel.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            releaseTitleLabel.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            budgetTitleLabel.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            revenueTitleLabel.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            homepageTitleLabel.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            
            castName1.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            castName2.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            castName3.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            roleName1.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            roleName2.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            roleName3.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            crewName1.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            crewName2.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            crewName3.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            functionName1.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            functionName2.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            functionName3.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            statusFilm.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            languageFilm.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            runtimeFilm.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            releaseFilm.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            budgetFilm.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            revenueFilm.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            homepageFilm.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            trailerButton.Font = new Font(_quicksandRegular, 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            addWishlistButton.Font = new Font(_quicksandRegular, 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            addCheckinButton.Font = new Font(_quicksandRegular, 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            loginButton.Font = new Font(_quicksandRegular, 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            createButton.Font = new Font(_quicksandRegular, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            usernameError.Font = new Font(_quicksandRegular, 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            passwordError.Font = new Font(_quicksandRegular, 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            alreadyloginError.Font = new Font(_quicksandRegular, 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            searchTextBox.Font = new Font(_quicksandRegular, 17.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            searchTextBox2.Font = new Font(_quicksandRegular, 17.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            usernameTextBox.Font = new Font(_quicksandRegular, 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            passwordTextBox.Font = new Font(_quicksandRegular, 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void clearAllPanels()
        {
            timelinePanel.Enabled = false;
            timelinePanel.Visible = false;
            libraryPanel.Enabled = false;
            libraryPanel.Visible = false;
            friendsPanel.Enabled = false;
            friendsPanel.Visible = false;
            watchedPanel.Enabled = false;
            watchedPanel.Visible = false;
            wishlistPanel.Enabled = false;
            wishlistPanel.Visible = false;
            filmInfoPanel.Enabled = false;
            filmInfoPanel.Visible = false;

            timelineHeaderPanel.Enabled = false;
            timelineHeaderPanel.Visible = false;
            libraryHeaderPanel.Enabled = false;
            libraryHeaderPanel.Visible = false;
            filmInfoHeaderPanel.Enabled = false;
            filmInfoHeaderPanel.Visible = false;
        }

        public void SetPlaceHolder(Control control, string PlaceHolderText)
        {
            control.Text = PlaceHolderText;
            control.GotFocus += delegate (object sender, EventArgs args) {
                if (control.Text == PlaceHolderText)
                {
                    control.Text = "";
                }
            };
            control.LostFocus += delegate (object sender, EventArgs args) {
                if (control.Text.Length == 0)
                {
                    control.Text = PlaceHolderText;
                }
            };
        }

        private static Image DrawReflection(Image img, Color toBG) // img is the original image.
        {
            //This is the static function that generates the reflection...
            int height = img.Height + 100; //Added height from the original height of the image.
            Bitmap bmp = new Bitmap(img.Width, height, PixelFormat.Format64bppPArgb); //A new 
                                                                                      //bitmap.
                                                                                      //The Brush that generates the fading effect to a specific color of your background.
            Brush brsh = new LinearGradientBrush(new Rectangle(0, 0, img.Width + 10,
              height), Color.Transparent, toBG, LinearGradientMode.Vertical);
            bmp.SetResolution(img.HorizontalResolution, img.VerticalResolution); //Sets the new 
                                                                                 //bitmap's resolution.
            using (Graphics grfx = Graphics.FromImage(bmp)) //A graphics to be generated 
                                                            //from an image (here, the new Bitmap we've created (BMP)).
            {
                Bitmap bm = (Bitmap)img; //Generates a bitmap from the original image (img).
                grfx.DrawImage(bm, 0, 0, img.Width, img.Height); //Draws the generated 
                                                                 //bitmap (bm) to the new bitmap (bmp).
                Bitmap bm1 = (Bitmap)img;   //Generates a bitmap again 
                                            //from the original image (img).
                bm1.RotateFlip(RotateFlipType.Rotate180FlipX); //Flips and rotates the 
                                                               //image (bm1).
                grfx.DrawImage(bm1, 0, img.Height);     //Draws (bm1) below (bm) so it serves 
                                                        //as the reflection image.
                Rectangle rt = new Rectangle(0, img.Height, img.Width, 100); //A new rectangle 
                                                                             //to paint our gradient effect.
                grfx.FillRectangle(brsh, rt); //Brushes the gradient on (rt).
            }
            return bmp; //Returns the (bmp) with the generated image.
        }

        public static Image CropToCircle(Image srcImage, Color backGround)
        {
            Bitmap bitmap = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);
            bitmap.MakeTransparent(Color.Black);
            Image dstImage = bitmap;
            Graphics g = Graphics.FromImage(dstImage);
            using (Brush br = new SolidBrush(backGround))
            {
                g.FillRectangle(br, 0, 0, dstImage.Width, dstImage.Height);
            }
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, dstImage.Width, dstImage.Height);
            g.SetClip(path);
            g.DrawImage(srcImage, 0, 0);
            return dstImage;
        }

        private void FillLibraryTable(Movies movies)
        {
            this.libraryTable.Controls.Clear();
            this.libraryTable.ColumnCount = 6;
            this.libraryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.libraryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.libraryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.libraryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.libraryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.libraryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.libraryTable.RowCount = 5;
            this.libraryTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.libraryTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.libraryTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.libraryTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.libraryTable.RowStyles.Add(new System.Windows.Forms.RowStyle());

            foreach (Movie m in movies.Results)
            {
                PictureBox p = new PictureBox();
                p.Dock = System.Windows.Forms.DockStyle.Fill;
                p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                p.Height = 205;

                if (m.Poster == null)
                    continue;
                p.ImageLocation = Path.Combine("https://image.tmdb.org/t/p/w500" + m.Poster);
                p.MouseClick += (s, e) =>
                {
                    FillFilmInfoTable(m);
                    clearAllPanels();
                    filmInfoPanel.Enabled = true;
                    filmInfoPanel.Visible = true;
                    filmInfoHeaderPanel.Visible = true;
                };
                libraryTable.Controls.Add(p);
            }
        }

        private void FillFilmInfoTable(Movie thumbMovie)
        {
            Movie movie = thumbMovie;
            Task t = Task.Factory.StartNew(() =>
            {
                var client = new ServiceClient(apiKey);
                movie = client.Movies.GetAsync(thumbMovie.Id, null, true, new CancellationToken(false)).Result;
            });

            t.Wait();
            //Movie movie 
            filmImage.ImageLocation = Path.Combine("https://image.tmdb.org/t/p/w500" + movie.Poster);

            filmNameLabel.Text = movie.Title.ToUpper();
            overviewFilm.Text = movie.Overview;

            List<MediaCast> cast = new List<MediaCast>();
            foreach (MediaCast c in movie.Credits.Cast.Take(3))
            {
                cast.Add(c);
            }
            castName1.Text = cast[0].Name;
            castName2.Text = cast[1].Name;
            castName3.Text = cast[2].Name;
            roleName1.Text = cast[0].Character;
            roleName2.Text = cast[1].Character;
            roleName3.Text = cast[2].Character;

            List<MediaCrew> crew = new List<MediaCrew>();
            foreach (MediaCrew c in movie.Credits.Crew.Take(3))
            {
                crew.Add(c);
            }
            crewName1.Text = crew[0].Name;
            crewName2.Text = crew[1].Name;
            crewName3.Text = crew[2].Name;
            functionName1.Text = crew[0].Job;
            functionName2.Text = crew[1].Job;
            functionName3.Text = crew[2].Job;

            statusFilm.Text = movie.Status;
            languageFilm.Text = movie.Languages.First().Name;
            runtimeFilm.Text = movie.Runtime.ToString();
            releaseFilm.Text = movie.ReleaseDate.ToString(); //"dd MMMM, yyyy"
            budgetFilm.Text = "$" + movie.Budget;
            revenueFilm.Text = "$" + movie.Revenue;
            homepageFilm.Text = movie.HomePage;
            homepageFilm.Links.Add(1, homepageFilm.Text.Length, movie.HomePage);
        }

        void loginPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            usernameError.Visible = false;
            passwordError.Visible = false;
            alreadyloginError.Visible = false;

            ServerHandler.instance.SendMessage(new Shared_Code.Message(
                ServerHandler.instance.clientID,
                ServerHandler.instance.serverNodeID,
                Shared_Code.Message.Trace.GenerateTrace(100),
                Shared_Code.Message.Type.ClientServer.Login.saltRequest,
                true,
                false,
                new {username = usernameTextBox.Text}
            ), m1 =>
            {
                if (m1.succes == false)
                {
                    usernameError.Invoke(new Action(() => usernameError.Visible = true));
                    return;
                }
                byte[] salt = Convert.FromBase64String((string) m1.message.salt);
                passwordTextBox.Invoke(new Action(() =>
                {
                    byte[] hash = PasswordBank.HashPasword(passwordTextBox.Text, salt);
                    ServerHandler.instance.SendMessage(new Shared_Code.Message(
                            ServerHandler.instance.clientID,
                            ServerHandler.instance.serverNodeID,
                            Shared_Code.Message.Trace.GenerateTrace(100),
                            Shared_Code.Message.Type.ClientServer.Login.checkHash,
                            true,
                            false,
                            new {username = m1.message.username, hash = Convert.ToBase64String(hash)}),
                        m2 =>
                        {
                            if (m2.succes)
                            {
                                loginPanel.Invoke(new Action(() =>
                                {
                                    loginPanel.Enabled = false;
                                    loginPanel.Visible = false;
                                }));
                                Layout.Invoke(new Action(() =>
                                {
                                    Layout.Enabled = true;
                                    Layout.Visible = true;
                                }));

                            }
                            else
                            {
                                if (m2.message.response == PasswordBank.Response.HASH_MISMATCH)
                                    passwordError.Invoke(new Action(() => passwordError.Visible = true));
                                else
                                alreadyloginError.Invoke(new Action(() => alreadyloginError.Visible = true));
                            }
                        });
                }));
            });
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != "password")
                passwordTextBox.PasswordChar = '\u25CF';
            else
            {
                passwordTextBox.PasswordChar = '\0';
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {

        }

        private void consolBox_MouseClick(object sender, EventArgs e)
        {
            Point cellPos = GetRowColIndex(consolBox,consolBox.PointToClient(Cursor.Position));
            switch (cellPos.X)
            {
                case 0:
                    WindowState = FormWindowState.Minimized;
                    break;
                case 1:
                    if (WindowState == FormWindowState.Maximized)
                    {
                        consolBox.BackgroundImage = MoviedApp.Properties.Resources.consolBox;
                        WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        consolBox.BackgroundImage = MoviedApp.Properties.Resources.consolBox_2;
                        WindowState = FormWindowState.Maximized;
                    }
                    break;
                case 2:
                    Close();
                    break;
            }
        }

        private void timelineLabel_MouseEnter(object sender, EventArgs e)
        {
            timelineLabel.Font = new Font(_quicksandBold, 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }

        private void libraryLabel_MouseEnter(object sender, EventArgs e)
        {
            libraryLabel.Font = new Font(_quicksandBold, 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }

        private void friendsLabel_MouseEnter(object sender, EventArgs e)
        {
            friendsLabel.Font = new Font(_quicksandBold, 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }

        private void watchedLabel_MouseEnter(object sender, EventArgs e)
        {
            watchedLabel.Font = new Font(_quicksandBold, 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }

        private void wishlistLabel_MouseEnter(object sender, EventArgs e)
        {
            wishlistLabel.Font = new Font(_quicksandBold, 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }
        private void trailerButton_MouseEnter(object sender, EventArgs e)
        {
            trailerButton.Font = new Font(_quicksandRegular, 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }

        private void addWishlistButton_MouseEnter(object sender, EventArgs e)
        {
            addWishlistButton.Font = new Font(_quicksandRegular, 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }

        private void addCheckinButton_MouseEnter(object sender, EventArgs e)
        {
            addCheckinButton.Font = new Font(_quicksandRegular, 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }
        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.Font = new Font(_quicksandRegular, 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }
        private void createButton_MouseEnter(object sender, EventArgs e)
        {
            createButton.Font = new Font(_quicksandRegular, 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }
        private void label_MouseLeave(object sender, EventArgs e)
        {
            Fonts();
        }

        private void HeadForm_ResizeEnd(object sender, EventArgs e)
        {
            if (libraryPanel.Enabled && libraryPanel.Visible)
            {
                int columns = libraryPanel.Width/132;
                while (libraryTable.ColumnCount != columns)
                {
                    Console.WriteLine(columns);
                    if (libraryTable.ColumnCount < columns)
                    {
                        float percent = libraryPanel.Width/libraryTable.ColumnCount;
                        libraryTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, percent));
                        libraryTable.ColumnCount++;
                        for (int i = 0; i < libraryTable.ColumnStyles.Count - 1; i++)
                        {
                            libraryTable.ColumnStyles[i] = new ColumnStyle(SizeType.Absolute, percent);
                        }
                    }


                    if (libraryTable.ColumnCount > columns)
                    {
                        libraryTable.ColumnStyles.RemoveAt(libraryTable.ColumnCount - 1);
                        libraryTable.ColumnCount--;
                    }
                    libraryTable.Refresh();
                }
                libraryTable.Width = libraryPanel.Width;

            }
        }
        
        private void libraryLabel_Click(object sender, EventArgs e)
        {
            if (!(libraryPanel.Visible && libraryPanel.Enabled))
            {
                clearAllPanels();
                FillLibraryTable(apiCalls.getPopularMovies());
                libraryHeaderPanel.Visible = true;
                libraryHeaderPanel.Enabled = true;
                libraryPanel.Visible = true;
                libraryPanel.Enabled = true;
            }
        }


        private void timelineLabel_Click(object sender, EventArgs e)
        {
            if (!(timelinePanel.Visible && timelinePanel.Enabled))
            {
                clearAllPanels();
                timelineHeaderPanel.Visible = true;
                timelineHeaderPanel.Enabled = true;
                timelinePanel.Visible = true;
                timelinePanel.Enabled = true;
            }
        }

        private void friendsLabel_Click(object sender, EventArgs e)
        {
            if (!(friendsPanel.Visible && friendsPanel.Enabled))
            {
                clearAllPanels();
                friendsPanel.Visible = true;
                friendsPanel.Enabled = true;
            }
        }

        private void watchedLabel_Click(object sender, EventArgs e)
        {
            if (!(watchedPanel.Visible && watchedPanel.Enabled))
            {
                clearAllPanels();
                watchedPanel.Visible = true;
                watchedPanel.Enabled = true;
            }
        }

        private void wishlistLabel_Click(object sender, EventArgs e)
        {
            if (!(wishlistPanel.Visible && wishlistPanel.Enabled))
            {
                clearAllPanels();
                wishlistPanel.Visible = true;
                wishlistPanel.Enabled = true;
            }
        }

        private void addCheckinButton_Click(object sender, EventArgs e)
        {
            clearAllPanels();
            checkinPanel.Visible = true;
            checkinPanel.Enabled = true;
        }

        private void filmImage_MouseClick(object sender, MouseEventArgs e)
        {
            //TODO implement in load
            filmImage.Image = DrawReflection(filmImage.Image, Color.FromArgb(11, 19, 29));
        }

        private void userPictureBox_Click(object sender, EventArgs e)
        {
            //TODO implement in load
            userPictureBox.Image = CropToCircle(userPictureBox.Image, Color.Transparent);
        }

        private void homepageFilm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
    
}
