namespace TicTacToe
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
            this.box00 = new System.Windows.Forms.PictureBox();
            this.box01 = new System.Windows.Forms.PictureBox();
            this.box10 = new System.Windows.Forms.PictureBox();
            this.box11 = new System.Windows.Forms.PictureBox();
            this.box12 = new System.Windows.Forms.PictureBox();
            this.box02 = new System.Windows.Forms.PictureBox();
            this.box22 = new System.Windows.Forms.PictureBox();
            this.box21 = new System.Windows.Forms.PictureBox();
            this.box20 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.box00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box20)).BeginInit();
            this.SuspendLayout();
            // 
            // box00
            // 
            this.box00.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.box00.Location = new System.Drawing.Point(88, 21);
            this.box00.Name = "box00";
            this.box00.Size = new System.Drawing.Size(150, 150);
            this.box00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box00.TabIndex = 0;
            this.box00.TabStop = false;
            // 
            // box01
            // 
            this.box01.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.box01.Location = new System.Drawing.Point(244, 21);
            this.box01.Name = "box01";
            this.box01.Size = new System.Drawing.Size(150, 150);
            this.box01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box01.TabIndex = 1;
            this.box01.TabStop = false;
            // 
            // box10
            // 
            this.box10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.box10.Location = new System.Drawing.Point(88, 177);
            this.box10.Name = "box10";
            this.box10.Size = new System.Drawing.Size(150, 150);
            this.box10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box10.TabIndex = 2;
            this.box10.TabStop = false;
            // 
            // box11
            // 
            this.box11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.box11.Location = new System.Drawing.Point(244, 177);
            this.box11.Name = "box11";
            this.box11.Size = new System.Drawing.Size(150, 150);
            this.box11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box11.TabIndex = 3;
            this.box11.TabStop = false;
            // 
            // box12
            // 
            this.box12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.box12.Location = new System.Drawing.Point(400, 177);
            this.box12.Name = "box12";
            this.box12.Size = new System.Drawing.Size(150, 150);
            this.box12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box12.TabIndex = 5;
            this.box12.TabStop = false;
            // 
            // box02
            // 
            this.box02.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.box02.Location = new System.Drawing.Point(400, 21);
            this.box02.Name = "box02";
            this.box02.Size = new System.Drawing.Size(150, 150);
            this.box02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box02.TabIndex = 4;
            this.box02.TabStop = false;
            this.box02.Click += new System.EventHandler(this.play);
            // 
            // box22
            // 
            this.box22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.box22.Location = new System.Drawing.Point(400, 333);
            this.box22.Name = "box22";
            this.box22.Size = new System.Drawing.Size(150, 150);
            this.box22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box22.TabIndex = 8;
            this.box22.TabStop = false;
            // 
            // box21
            // 
            this.box21.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.box21.Location = new System.Drawing.Point(244, 333);
            this.box21.Name = "box21";
            this.box21.Size = new System.Drawing.Size(150, 150);
            this.box21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box21.TabIndex = 7;
            this.box21.TabStop = false;
            // 
            // box20
            // 
            this.box20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.box20.Location = new System.Drawing.Point(88, 333);
            this.box20.Name = "box20";
            this.box20.Size = new System.Drawing.Size(150, 150);
            this.box20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box20.TabIndex = 6;
            this.box20.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box22);
            this.Controls.Add(this.box21);
            this.Controls.Add(this.box20);
            this.Controls.Add(this.box12);
            this.Controls.Add(this.box02);
            this.Controls.Add(this.box11);
            this.Controls.Add(this.box10);
            this.Controls.Add(this.box01);
            this.Controls.Add(this.box00);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.box00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box20)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox box00;
        private System.Windows.Forms.PictureBox box01;
        private System.Windows.Forms.PictureBox box10;
        private System.Windows.Forms.PictureBox box11;
        private System.Windows.Forms.PictureBox box12;
        private System.Windows.Forms.PictureBox box02;
        private System.Windows.Forms.PictureBox box22;
        private System.Windows.Forms.PictureBox box21;
        private System.Windows.Forms.PictureBox box20;
        private System.Windows.Forms.Button button1;
    }
}

