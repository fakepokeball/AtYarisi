namespace AtYarisi
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
            this.components = new System.ComponentModel.Container();
            this.At1 = new System.Windows.Forms.PictureBox();
            this.At2 = new System.Windows.Forms.PictureBox();
            this.At3 = new System.Windows.Forms.PictureBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.lblFinish = new System.Windows.Forms.Label();
            this.timerYaris = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.At1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.At2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.At3)).BeginInit();
            this.SuspendLayout();
            // 
            // At1
            // 
            this.At1.Image = global::AtYarisi.Properties.Resources.horse1;
            this.At1.Location = new System.Drawing.Point(12, 12);
            this.At1.Name = "At1";
            this.At1.Size = new System.Drawing.Size(80, 80);
            this.At1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.At1.TabIndex = 0;
            this.At1.TabStop = false;
            // 
            // At2
            // 
            this.At2.Image = global::AtYarisi.Properties.Resources.horse2;
            this.At2.Location = new System.Drawing.Point(12, 98);
            this.At2.Name = "At2";
            this.At2.Size = new System.Drawing.Size(80, 80);
            this.At2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.At2.TabIndex = 1;
            this.At2.TabStop = false;
            // 
            // At3
            // 
            this.At3.Image = global::AtYarisi.Properties.Resources.horse3;
            this.At3.Location = new System.Drawing.Point(12, 184);
            this.At3.Name = "At3";
            this.At3.Size = new System.Drawing.Size(80, 80);
            this.At3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.At3.TabIndex = 2;
            this.At3.TabStop = false;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(12, 293);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(80, 80);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "YARIŞA BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFinish.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFinish.Location = new System.Drawing.Point(550, 0);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(18, 383);
            this.lblFinish.TabIndex = 4;
            // 
            // timerYaris
            // 
            this.timerYaris.Tick += new System.EventHandler(this.timerYaris_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(568, 383);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.At3);
            this.Controls.Add(this.At2);
            this.Controls.Add(this.At1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.At1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.At2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.At3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox At1;
        private System.Windows.Forms.PictureBox At2;
        private System.Windows.Forms.PictureBox At3;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Timer timerYaris;
    }
}

