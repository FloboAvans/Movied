using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoviedApp.Properties;

namespace MoviedApp
{
    public partial class HeadForm : Form
    {
        private FontFamily _quicksandLight;
        private FontFamily _quicksandRegular;
        private FontFamily _quicksandBold;

        public HeadForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            CargoPrivateFontCollection();
            Fonts();
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

        private int GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return 999;

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            return col;
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
        }

        private void consolBox_MouseClick(object sender, EventArgs e)
        {
            int cellPos = GetRowColIndex(
                consolBox,
                consolBox.PointToClient(Cursor.Position));
            switch (cellPos)
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
        private void label_MouseLeave(object sender, EventArgs e)
        {
            Fonts();
        }

        private void timelineLabel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
