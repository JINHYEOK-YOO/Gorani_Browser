using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoraniBrowser
{
    enum DRAW_MODE : int
    {
        PENMODE = 0,        // 펜 모드
        NOTEMODE = 1,      // 노트 모드
        EDITMODE = 2        // 그 외 편집 모드
    }

    public partial class frmMemo : Form
    {
        private int curMode;    // 현재 커서 모드
        private Color curColor = Color.Black;   // 선 색깔
        private int curLineSize = 1;    // 선 굵기
        private Point p;    // 마우스 좌표 저장
        private Bitmap pictureBoxBmp;   // 선 그려지는 이미지

        public Image pnlBoardImage
        {
            get
            {
                return pnlBoard.BackgroundImage;
            }
            set
            {
                pnlBoard.BackgroundImage = value;
            }
        }

        public frmMemo()
        {
            InitializeComponent();
            pnlShowColor.BackColor = curColor;
            SetDrawMode((int)DRAW_MODE.PENMODE);
            pictureBoxBmp = new Bitmap(picMemo.Width, picMemo.Height);
        }

        // 그리기 모드 변경
        private void SetDrawMode(int mode)
        {
            switch (mode)
            {
                case (int)DRAW_MODE.PENMODE:    // 펜 모드
                    curMode = (int)DRAW_MODE.PENMODE;
                    MemoryStream cursorMemoryStream = new MemoryStream(Properties.Resources.PenCursor_small);
                    Cursor = new Cursor(cursorMemoryStream);
                    break;
                case (int)DRAW_MODE.NOTEMODE:   // 노트 모드
                    curMode = (int)DRAW_MODE.NOTEMODE;
                    Cursor = Cursors.Hand;
                    break;
                case (int)DRAW_MODE.EDITMODE:   // 그외
                    Cursor = Cursors.Default;
                    break;
                default:
                    Cursor = Cursors.Default;
                    break;
            }
        }

        // 펜 버튼 클릭 시 펜 모드로 변경
        private void btnDrawing_Click(object sender, EventArgs e) => SetDrawMode((int)DRAW_MODE.PENMODE);

        // 지우개 버튼 클릭 시 이미지 지우고 새로 그림
        private void btnEraser_Click(object sender, EventArgs e)
        {
            picMemo.Dispose();
            picMemo = new PictureBox();
            picMemo.BackColor = Color.Transparent;
            picMemo.Dock = DockStyle.Fill;
            picMemo.Location = new Point(0, 0);
            picMemo.Name = "picMemo";
            picMemo.Size = new Size(1160, 571);
            picMemo.TabIndex = 0;
            picMemo.TabStop = false;
            picMemo.MouseDown += new MouseEventHandler(picMemo_MouseDown);
            picMemo.MouseEnter += new EventHandler(picMemo_MouseEnter);
            picMemo.MouseLeave += new EventHandler(pieMemo_MouseLeave);
            picMemo.MouseMove += new MouseEventHandler(picMemo_MouseMove);
            pictureBoxBmp = new Bitmap(picMemo.Width, picMemo.Height);
            pnlBoard.Controls.Add(picMemo);
        }

        // 색 선택 창 띄우기
        private void pnlShowColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                curColor = colorDialog.Color;
                pnlShowColor.BackColor = curColor;
            }
        }

        // 노트 버튼 선택 시 노트 모드로 변경
        private void btnNote_Click(object sender, EventArgs e) => SetDrawMode((int)DRAW_MODE.NOTEMODE);

        // 이미지로 저장하기
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = ".png";
            saveFileDialog.Filter = "PNG File|*.png|Bitmap File|*.bmp|JPEG File|*.jpg";
            saveFileDialog.OverwritePrompt = true;

            Bitmap img = new Bitmap(picMemo.Width, picMemo.Height);
            Rectangle rect = new Rectangle(picMemo.Location, picMemo.Size);
            pnlBoard.DrawToBitmap(img, rect);

            if (img == null)
            {
                MessageBox.Show("이미지가 없습니다!");
                return;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        img.Save(saveFileDialog.FileName, ImageFormat.Png);
                        break;

                    case 2:
                        img.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                        break;

                    case 3:
                        img.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }

        // 메모 패널에서 마우스 클릭 시
        private void picMemo_MouseDown(object sender, MouseEventArgs e)
        {
            // 펜 모드면 좌표 저장
            if (curMode == (int)DRAW_MODE.PENMODE && e.Button == MouseButtons.Left)
            {
                p.X = e.X;
                p.Y = e.Y;
            }
            // 노트 모드면 노트 생성
            else if (curMode == (int)DRAW_MODE.NOTEMODE && e.Button == MouseButtons.Left)
            {
                TextBox t = new TextBox();
                t.Location = new Point(e.X, e.Y);
                t.Multiline = true;
                t.Size = new Size(100, 160);
                t.BackColor = Color.Gold;
                t.Font = new Font("맑은 고딕", 10, FontStyle.Bold);
                t.ImeMode = ImeMode.NoControl;
                picMemo.Controls.Add(t);
            }
        }

        // 메모 패널에서 마우스 이동 시
        private void picMemo_MouseMove(object sender, MouseEventArgs e)
        {
            // 펜 모드면 선 그리기
            if (curMode == (int)DRAW_MODE.PENMODE && e.Button == MouseButtons.Left)
            {
                Pen pen = new Pen(curColor, curLineSize);

                Graphics g = Graphics.FromImage(pictureBoxBmp);
                g.DrawLine(pen, p.X, p.Y, e.X, e.Y);
                p.X = e.X;
                p.Y = e.Y;
                picMemo.Image = pictureBoxBmp;
                g.Dispose();
            }
        }

        // 메모 패널에 마우스 들어갈 경우 /  나올 경우
        private void picMemo_MouseEnter(object sender, EventArgs e) => SetDrawMode(curMode);
        private void pieMemo_MouseLeave(object sender, EventArgs e) => SetDrawMode((int)DRAW_MODE.EDITMODE);

        // 선 굵기 조절 스크롤
        private void trbThick_Scroll(object sender, EventArgs e) => curLineSize = trbThick.Value;
    }
}
