namespace painting
{
    partial class Form1
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
            this.panelDraw = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxWhite = new System.Windows.Forms.PictureBox();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrange = new System.Windows.Forms.PictureBox();
            this.pictureBoxYellow = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxCayn = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.pictureBoxPink = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlack = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClasicPen = new System.Windows.Forms.Button();
            this.buttonSpray = new System.Windows.Forms.Button();
            this.panelDraw.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCayn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.Color.White;
            this.panelDraw.Controls.Add(this.panel2);
            this.panelDraw.Controls.Add(this.panel1);
            this.panelDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDraw.Location = new System.Drawing.Point(0, 0);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(1107, 808);
            this.panelDraw.TabIndex = 0;
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            this.panelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseMove);
            this.panelDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBoxBlack);
            this.panel1.Controls.Add(this.pictureBoxPink);
            this.panel1.Controls.Add(this.pictureBoxBlue);
            this.panel1.Controls.Add(this.pictureBoxCayn);
            this.panel1.Controls.Add(this.pictureBoxGreen);
            this.panel1.Controls.Add(this.pictureBoxYellow);
            this.panel1.Controls.Add(this.pictureBoxOrange);
            this.panel1.Controls.Add(this.pictureBoxRed);
            this.panel1.Controls.Add(this.pictureBoxWhite);
            this.panel1.Location = new System.Drawing.Point(767, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 36);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxWhite
            // 
            this.pictureBoxWhite.BackColor = System.Drawing.Color.White;
            this.pictureBoxWhite.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxWhite.Name = "pictureBoxWhite";
            this.pictureBoxWhite.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxWhite.TabIndex = 0;
            this.pictureBoxWhite.TabStop = false;
            this.pictureBoxWhite.Click += new System.EventHandler(this.pictureBoxBlack_Click);
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.BackColor = System.Drawing.Color.Red;
            this.pictureBoxRed.Location = new System.Drawing.Point(39, 3);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxRed.TabIndex = 1;
            this.pictureBoxRed.TabStop = false;
            this.pictureBoxRed.Click += new System.EventHandler(this.pictureBoxBlack_Click);
            // 
            // pictureBoxOrange
            // 
            this.pictureBoxOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBoxOrange.Location = new System.Drawing.Point(75, 3);
            this.pictureBoxOrange.Name = "pictureBoxOrange";
            this.pictureBoxOrange.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxOrange.TabIndex = 2;
            this.pictureBoxOrange.TabStop = false;
            this.pictureBoxOrange.Click += new System.EventHandler(this.pictureBoxBlack_Click);
            // 
            // pictureBoxYellow
            // 
            this.pictureBoxYellow.BackColor = System.Drawing.Color.Yellow;
            this.pictureBoxYellow.Location = new System.Drawing.Point(111, 3);
            this.pictureBoxYellow.Name = "pictureBoxYellow";
            this.pictureBoxYellow.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxYellow.TabIndex = 3;
            this.pictureBoxYellow.TabStop = false;
            this.pictureBoxYellow.Click += new System.EventHandler(this.pictureBoxBlack_Click);
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.BackColor = System.Drawing.Color.Lime;
            this.pictureBoxGreen.Location = new System.Drawing.Point(147, 3);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxGreen.TabIndex = 4;
            this.pictureBoxGreen.TabStop = false;
            this.pictureBoxGreen.Click += new System.EventHandler(this.pictureBoxBlack_Click);
            // 
            // pictureBoxCayn
            // 
            this.pictureBoxCayn.BackColor = System.Drawing.Color.Cyan;
            this.pictureBoxCayn.Location = new System.Drawing.Point(185, 3);
            this.pictureBoxCayn.Name = "pictureBoxCayn";
            this.pictureBoxCayn.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxCayn.TabIndex = 5;
            this.pictureBoxCayn.TabStop = false;
            this.pictureBoxCayn.Click += new System.EventHandler(this.pictureBoxBlack_Click);
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxBlue.Location = new System.Drawing.Point(221, 3);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxBlue.TabIndex = 6;
            this.pictureBoxBlue.TabStop = false;
            this.pictureBoxBlue.Click += new System.EventHandler(this.pictureBoxBlack_Click);
            // 
            // pictureBoxPink
            // 
            this.pictureBoxPink.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBoxPink.Location = new System.Drawing.Point(257, 3);
            this.pictureBoxPink.Name = "pictureBoxPink";
            this.pictureBoxPink.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPink.TabIndex = 7;
            this.pictureBoxPink.TabStop = false;
            this.pictureBoxPink.Click += new System.EventHandler(this.pictureBoxBlack_Click);
            // 
            // pictureBoxBlack
            // 
            this.pictureBoxBlack.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBlack.Location = new System.Drawing.Point(293, 3);
            this.pictureBoxBlack.Name = "pictureBoxBlack";
            this.pictureBoxBlack.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxBlack.TabIndex = 8;
            this.pictureBoxBlack.TabStop = false;
            this.pictureBoxBlack.Click += new System.EventHandler(this.pictureBoxBlack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.buttonSpray);
            this.panel2.Controls.Add(this.buttonClasicPen);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 36);
            this.panel2.TabIndex = 1;
            // 
            // buttonClasicPen
            // 
            this.buttonClasicPen.Location = new System.Drawing.Point(3, 3);
            this.buttonClasicPen.Name = "buttonClasicPen";
            this.buttonClasicPen.Size = new System.Drawing.Size(75, 30);
            this.buttonClasicPen.TabIndex = 9;
            this.buttonClasicPen.Text = "PEN";
            this.buttonClasicPen.UseVisualStyleBackColor = true;
            // 
            // buttonSpray
            // 
            this.buttonSpray.Location = new System.Drawing.Point(84, 3);
            this.buttonSpray.Name = "buttonSpray";
            this.buttonSpray.Size = new System.Drawing.Size(75, 30);
            this.buttonSpray.TabIndex = 10;
            this.buttonSpray.Text = "SPRAY";
            this.buttonSpray.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 808);
            this.Controls.Add(this.panelDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelDraw.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCayn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxWhite;
        private System.Windows.Forms.PictureBox pictureBoxBlack;
        private System.Windows.Forms.PictureBox pictureBoxPink;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.PictureBox pictureBoxCayn;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.PictureBox pictureBoxYellow;
        private System.Windows.Forms.PictureBox pictureBoxOrange;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSpray;
        private System.Windows.Forms.Button buttonClasicPen;
    }
}

