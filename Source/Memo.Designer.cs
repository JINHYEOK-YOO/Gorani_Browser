namespace GoraniBrowser
{
    partial class frmMemo
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
            this.trbThick = new System.Windows.Forms.TrackBar();
            this.pnlShowColor = new System.Windows.Forms.Panel();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnDrawing = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.picMemo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trbThick)).BeginInit();
            this.pnlIcon.SuspendLayout();
            this.pnlBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMemo)).BeginInit();
            this.SuspendLayout();
            // 
            // trbThick
            // 
            this.trbThick.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trbThick.Cursor = System.Windows.Forms.Cursors.Default;
            this.trbThick.LargeChange = 1;
            this.trbThick.Location = new System.Drawing.Point(540, 33);
            this.trbThick.Margin = new System.Windows.Forms.Padding(0);
            this.trbThick.Minimum = 1;
            this.trbThick.Name = "trbThick";
            this.trbThick.Size = new System.Drawing.Size(76, 56);
            this.trbThick.TabIndex = 7;
            this.trbThick.TickFrequency = 10;
            this.trbThick.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbThick.Value = 1;
            this.trbThick.Scroll += new System.EventHandler(this.trbThick_Scroll);
            // 
            // pnlShowColor
            // 
            this.pnlShowColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlShowColor.BackColor = System.Drawing.Color.Black;
            this.pnlShowColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlShowColor.Location = new System.Drawing.Point(550, 4);
            this.pnlShowColor.Margin = new System.Windows.Forms.Padding(2);
            this.pnlShowColor.Name = "pnlShowColor";
            this.pnlShowColor.Size = new System.Drawing.Size(60, 25);
            this.pnlShowColor.TabIndex = 8;
            this.pnlShowColor.Click += new System.EventHandler(this.pnlShowColor_Click);
            // 
            // pnlIcon
            // 
            this.pnlIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIcon.Controls.Add(this.btnSave);
            this.pnlIcon.Controls.Add(this.btnNote);
            this.pnlIcon.Controls.Add(this.btnEraser);
            this.pnlIcon.Controls.Add(this.btnDrawing);
            this.pnlIcon.Controls.Add(this.pnlShowColor);
            this.pnlIcon.Controls.Add(this.trbThick);
            this.pnlIcon.Location = new System.Drawing.Point(11, 5);
            this.pnlIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(1160, 60);
            this.pnlIcon.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackgroundImage = global::GoraniBrowser.Properties.Resources.Save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(700, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 55);
            this.btnSave.TabIndex = 14;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNote
            // 
            this.btnNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNote.BackColor = System.Drawing.SystemColors.Control;
            this.btnNote.BackgroundImage = global::GoraniBrowser.Properties.Resources.note;
            this.btnNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNote.Location = new System.Drawing.Point(630, 2);
            this.btnNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(55, 55);
            this.btnNote.TabIndex = 13;
            this.btnNote.UseVisualStyleBackColor = false;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEraser.BackColor = System.Drawing.SystemColors.Control;
            this.btnEraser.BackgroundImage = global::GoraniBrowser.Properties.Resources.Rubber;
            this.btnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEraser.Location = new System.Drawing.Point(470, 2);
            this.btnEraser.Margin = new System.Windows.Forms.Padding(2);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(55, 55);
            this.btnEraser.TabIndex = 11;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnDrawing
            // 
            this.btnDrawing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDrawing.BackColor = System.Drawing.SystemColors.Control;
            this.btnDrawing.BackgroundImage = global::GoraniBrowser.Properties.Resources.Pencil;
            this.btnDrawing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDrawing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrawing.Location = new System.Drawing.Point(400, 2);
            this.btnDrawing.Margin = new System.Windows.Forms.Padding(2);
            this.btnDrawing.Name = "btnDrawing";
            this.btnDrawing.Size = new System.Drawing.Size(55, 55);
            this.btnDrawing.TabIndex = 10;
            this.btnDrawing.UseVisualStyleBackColor = false;
            this.btnDrawing.Click += new System.EventHandler(this.btnDrawing_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBoard.Controls.Add(this.picMemo);
            this.pnlBoard.Location = new System.Drawing.Point(9, 69);
            this.pnlBoard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(1162, 573);
            this.pnlBoard.TabIndex = 11;
            // 
            // picMemo
            // 
            this.picMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMemo.BackColor = System.Drawing.Color.Transparent;
            this.picMemo.Location = new System.Drawing.Point(0, 0);
            this.picMemo.Name = "picMemo";
            this.picMemo.Size = new System.Drawing.Size(1160, 571);
            this.picMemo.TabIndex = 0;
            this.picMemo.TabStop = false;
            this.picMemo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMemo_MouseDown);
            this.picMemo.MouseEnter += new System.EventHandler(this.picMemo_MouseEnter);
            this.picMemo.MouseLeave += new System.EventHandler(this.pieMemo_MouseLeave);
            this.picMemo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMemo_MouseMove);
            // 
            // frmMemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.pnlIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gorani Memo";
            ((System.ComponentModel.ISupportInitialize)(this.trbThick)).EndInit();
            this.pnlIcon.ResumeLayout(false);
            this.pnlIcon.PerformLayout();
            this.pnlBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar trbThick;
        private System.Windows.Forms.Panel pnlShowColor;
        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.Button btnDrawing;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.PictureBox picMemo;
    }
}