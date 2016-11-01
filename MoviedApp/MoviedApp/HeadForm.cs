using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviedApp
{
    public partial class HeadForm : Form
    {
        //Resize resize = new Resize();

        public HeadForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
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

        private void tableLayoutPanel2_MouseHover(object sender, EventArgs e)
        {
            Console.WriteLine("test");
            int cellPos = GetRowColIndex(
                consolBox,
                consolBox.PointToClient(Cursor.Position));
            switch (cellPos)
            {
                case 0:
                    this.timelineLabel.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    break;
                case 1:
                    this.libraryLabel.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    break;
                case 2:
                    this.friendsLabel.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    break;
                case 3:
                    this.watchedLabel.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    break;
                case 4:
                    this.wishlistLabel.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    break;
            }
        }

        private void timelineLabel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello?");
        }
    }
}
