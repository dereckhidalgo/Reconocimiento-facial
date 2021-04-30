namespace Reconocimiento_facial
{
    partial class Frm_Reconocimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reconocimiento));
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblNumeroDetect = new System.Windows.Forms.Label();
            this.lblNadie = new System.Windows.Forms.Label();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.lblCedResultado = new System.Windows.Forms.Label();
            this.lblFNResultado = new System.Windows.Forms.Label();
            this.lblSangreResultado = new System.Windows.Forms.Label();
            this.lblAlergiaResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 825);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1332, 6);
            this.panel2.TabIndex = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lblNumeroDetect
            // 
            this.lblNumeroDetect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDetect.AutoSize = true;
            this.lblNumeroDetect.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroDetect.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDetect.ForeColor = System.Drawing.Color.Black;
            this.lblNumeroDetect.Location = new System.Drawing.Point(975, 412);
            this.lblNumeroDetect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDetect.Name = "lblNumeroDetect";
            this.lblNumeroDetect.Size = new System.Drawing.Size(25, 27);
            this.lblNumeroDetect.TabIndex = 56;
            this.lblNumeroDetect.Text = "0";
            // 
            // lblNadie
            // 
            this.lblNadie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNadie.AutoSize = true;
            this.lblNadie.BackColor = System.Drawing.Color.Transparent;
            this.lblNadie.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNadie.ForeColor = System.Drawing.Color.Black;
            this.lblNadie.Location = new System.Drawing.Point(975, 471);
            this.lblNadie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNadie.Name = "lblNadie";
            this.lblNadie.Size = new System.Drawing.Size(25, 27);
            this.lblNadie.TabIndex = 62;
            this.lblNadie.Text = "0";
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBoxFrameGrabber.BackColor = System.Drawing.Color.Transparent;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(81, 356);
            this.imageBoxFrameGrabber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(416, 430);
            this.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxFrameGrabber.TabIndex = 49;
            this.imageBoxFrameGrabber.TabStop = false;
            this.imageBoxFrameGrabber.WaitOnLoad = true;
            // 
            // lblCedResultado
            // 
            this.lblCedResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCedResultado.AutoSize = true;
            this.lblCedResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblCedResultado.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedResultado.ForeColor = System.Drawing.Color.Black;
            this.lblCedResultado.Location = new System.Drawing.Point(975, 540);
            this.lblCedResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedResultado.Name = "lblCedResultado";
            this.lblCedResultado.Size = new System.Drawing.Size(25, 27);
            this.lblCedResultado.TabIndex = 67;
            this.lblCedResultado.Text = "0";
            // 
            // lblFNResultado
            // 
            this.lblFNResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFNResultado.AutoSize = true;
            this.lblFNResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblFNResultado.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNResultado.ForeColor = System.Drawing.Color.Black;
            this.lblFNResultado.Location = new System.Drawing.Point(965, 747);
            this.lblFNResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFNResultado.Name = "lblFNResultado";
            this.lblFNResultado.Size = new System.Drawing.Size(25, 27);
            this.lblFNResultado.TabIndex = 68;
            this.lblFNResultado.Text = "0";
            // 
            // lblSangreResultado
            // 
            this.lblSangreResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSangreResultado.AutoSize = true;
            this.lblSangreResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblSangreResultado.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSangreResultado.ForeColor = System.Drawing.Color.Black;
            this.lblSangreResultado.Location = new System.Drawing.Point(965, 688);
            this.lblSangreResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSangreResultado.Name = "lblSangreResultado";
            this.lblSangreResultado.Size = new System.Drawing.Size(25, 27);
            this.lblSangreResultado.TabIndex = 69;
            this.lblSangreResultado.Text = "0";
            // 
            // lblAlergiaResultado
            // 
            this.lblAlergiaResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlergiaResultado.AutoSize = true;
            this.lblAlergiaResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblAlergiaResultado.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlergiaResultado.ForeColor = System.Drawing.Color.Black;
            this.lblAlergiaResultado.Location = new System.Drawing.Point(965, 612);
            this.lblAlergiaResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlergiaResultado.Name = "lblAlergiaResultado";
            this.lblAlergiaResultado.Size = new System.Drawing.Size(25, 27);
            this.lblAlergiaResultado.TabIndex = 70;
            this.lblAlergiaResultado.Text = "0";
            // 
            // Frm_Reconocimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1332, 831);
            this.Controls.Add(this.lblAlergiaResultado);
            this.Controls.Add(this.lblSangreResultado);
            this.Controls.Add(this.lblFNResultado);
            this.Controls.Add(this.lblCedResultado);
            this.Controls.Add(this.lblNadie);
            this.Controls.Add(this.lblNumeroDetect);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1332, 831);
            this.MinimumSize = new System.Drawing.Size(1332, 831);
            this.Name = "Frm_Reconocimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Reconocimiento";
            this.Load += new System.EventHandler(this.Frm_Reconocimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Label lblNumeroDetect;
        private System.Windows.Forms.Label lblNadie;
        private System.Windows.Forms.Label lblAlergiaResultado;
        private System.Windows.Forms.Label lblSangreResultado;
        private System.Windows.Forms.Label lblFNResultado;
        private System.Windows.Forms.Label lblCedResultado;
    }
}