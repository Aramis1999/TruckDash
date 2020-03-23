namespace PED___Proyecto.Views
{
    partial class frmLugarComer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLugarComer));
            this.pNo = new System.Windows.Forms.Panel();
            this.pSi = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pNo
            // 
            this.pNo.BackColor = System.Drawing.Color.Transparent;
            this.pNo.Location = new System.Drawing.Point(155, 150);
            this.pNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pNo.Name = "pNo";
            this.pNo.Size = new System.Drawing.Size(104, 58);
            this.pNo.TabIndex = 0;
            this.pNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pNo_MouseClick);
            this.pNo.MouseEnter += new System.EventHandler(this.pNo_MouseEnter);
            this.pNo.MouseLeave += new System.EventHandler(this.pNo_MouseLeave);
            // 
            // pSi
            // 
            this.pSi.BackColor = System.Drawing.Color.Transparent;
            this.pSi.Location = new System.Drawing.Point(300, 150);
            this.pSi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pSi.Name = "pSi";
            this.pSi.Size = new System.Drawing.Size(104, 58);
            this.pSi.TabIndex = 1;
            this.pSi.Paint += new System.Windows.Forms.PaintEventHandler(this.pSi_Paint);
            this.pSi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pSi_MouseClick);
            this.pSi.MouseEnter += new System.EventHandler(this.pSi_MouseEnter);
            this.pSi.MouseLeave += new System.EventHandler(this.pSi_MouseLeave);
            // 
            // frmLugarComer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 252);
            this.Controls.Add(this.pSi);
            this.Controls.Add(this.pNo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLugarComer";
            this.Text = "lugar_comer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNo;
        private System.Windows.Forms.Panel pSi;
    }
}