namespace Reconocimiento_facial
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumeroDetect = new System.Windows.Forms.Label();
            this.btn_detectar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.button1 = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.btn_agregar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txt_Sangre = new System.Windows.Forms.TextBox();
            this.txtFecha_Nac = new System.Windows.Forms.MaskedTextBox();
            this.txt_Alergia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_detectar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 819);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1332, 12);
            this.panel2.TabIndex = 2;
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBoxFrameGrabber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageBoxFrameGrabber.BackgroundImage")));
            this.imageBoxFrameGrabber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(31, 364);
            this.imageBoxFrameGrabber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(389, 344);
            this.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxFrameGrabber.TabIndex = 28;
            this.imageBoxFrameGrabber.TabStop = false;
            this.imageBoxFrameGrabber.Click += new System.EventHandler(this.imageBoxFrameGrabber_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(456, 574);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Rostros detectados:";
            // 
            // lblNumeroDetect
            // 
            this.lblNumeroDetect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDetect.AutoSize = true;
            this.lblNumeroDetect.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroDetect.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDetect.ForeColor = System.Drawing.Color.White;
            this.lblNumeroDetect.Location = new System.Drawing.Point(640, 574);
            this.lblNumeroDetect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDetect.Name = "lblNumeroDetect";
            this.lblNumeroDetect.Size = new System.Drawing.Size(18, 17);
            this.lblNumeroDetect.TabIndex = 39;
            this.lblNumeroDetect.Text = "0";
            this.lblNumeroDetect.Click += new System.EventHandler(this.lblNumeroDetect_Click);
            // 
            // btn_detectar
            // 
            this.btn_detectar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_detectar.BackgroundStyle.SolidColor = System.Drawing.Color.RoyalBlue;
            this.btn_detectar.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_detectar.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_detectar.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_detectar.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_detectar.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_detectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detectar.DropDownArrowColor = System.Drawing.Color.Transparent;
            this.btn_detectar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_detectar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_detectar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_detectar.ForegroundImageStyle.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_detectar.Location = new System.Drawing.Point(221, 743);
            this.btn_detectar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_detectar.Name = "btn_detectar";
            this.btn_detectar.Size = new System.Drawing.Size(195, 44);
            this.btn_detectar.StateStyles.DisabledStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_detectar.StateStyles.FocusStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_detectar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_detectar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_detectar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_detectar.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_detectar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_detectar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_detectar.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btn_detectar.StateStyles.PressedStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_detectar.TabIndex = 63;
            this.btn_detectar.TextStyle.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold);
            this.btn_detectar.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_detectar.TextStyle.Text = "Conectar";
            this.btn_detectar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_detectar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_detectar.Click += new System.EventHandler(this.btn_detectar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.button1.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.button1.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.button1.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.button1.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.button1.BorderStyle.SolidColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.button1.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.button1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Location = new System.Drawing.Point(27, 742);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 44);
            this.button1.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.YellowGreen;
            this.button1.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.YellowGreen;
            this.button1.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.YellowGreen;
            this.button1.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.YellowGreen;
            this.button1.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.YellowGreen;
            this.button1.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.YellowGreen;
            this.button1.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.TabIndex = 62;
            this.button1.TextStyle.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.TextStyle.ForeColor = System.Drawing.Color.White;
            this.button1.TextStyle.Text = "Desconectar";
            this.button1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox2.BackColor = System.Drawing.Color.Transparent;
            this.imageBox2.Location = new System.Drawing.Point(437, 367);
            this.imageBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(256, 197);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 65;
            this.imageBox2.TabStop = false;
            this.imageBox2.Click += new System.EventHandler(this.imageBox2_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_agregar.BackgroundStyle.SolidColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregar.BorderStyle.SolidColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_agregar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_agregar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_agregar.Location = new System.Drawing.Point(1033, 742);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(157, 44);
            this.btn_agregar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregar.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregar.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.TabIndex = 75;
            this.btn_agregar.TextStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.TextStyle.Text = "Añadir";
            this.btn_agregar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_agregar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_nombre.Location = new System.Drawing.Point(944, 415);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(308, 23);
            this.txt_nombre.TabIndex = 77;
            this.txt_nombre.Tag = "";
            this.txt_nombre.Enter += new System.EventHandler(this.txt_nombre_Enter_1);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // txt_codigo
            // 
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_codigo.Location = new System.Drawing.Point(944, 482);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(304, 23);
            this.txt_codigo.TabIndex = 78;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            this.txt_codigo.Enter += new System.EventHandler(this.txt_codigo_Enter);
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txt_Sangre
            // 
            this.txt_Sangre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Sangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sangre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Sangre.Location = new System.Drawing.Point(944, 626);
            this.txt_Sangre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Sangre.Name = "txt_Sangre";
            this.txt_Sangre.Size = new System.Drawing.Size(308, 23);
            this.txt_Sangre.TabIndex = 80;
            // 
            // txtFecha_Nac
            // 
            this.txtFecha_Nac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha_Nac.Location = new System.Drawing.Point(944, 697);
            this.txtFecha_Nac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFecha_Nac.Mask = "00/00/0000";
            this.txtFecha_Nac.Name = "txtFecha_Nac";
            this.txtFecha_Nac.Size = new System.Drawing.Size(308, 15);
            this.txtFecha_Nac.TabIndex = 83;
            this.txtFecha_Nac.ValidatingType = typeof(System.DateTime);
            this.txtFecha_Nac.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtFecha_Nac_MaskInputRejected);
            // 
            // txt_Alergia
            // 
            this.txt_Alergia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Alergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Alergia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Alergia.Location = new System.Drawing.Point(948, 555);
            this.txt_Alergia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Alergia.Name = "txt_Alergia";
            this.txt_Alergia.Size = new System.Drawing.Size(304, 23);
            this.txt_Alergia.TabIndex = 85;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1332, 831);
            this.Controls.Add(this.txt_Alergia);
            this.Controls.Add(this.txtFecha_Nac);
            this.Controls.Add(this.txt_Sangre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.btn_detectar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumeroDetect);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1332, 831);
            this.MinimumSize = new System.Drawing.Size(1332, 831);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Frm_Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_detectar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumeroDetect;
        public Klik.Windows.Forms.v1.EntryLib.ELButton btn_detectar;
        public Klik.Windows.Forms.v1.EntryLib.ELButton button1;
        private Emgu.CV.UI.ImageBox imageBox2;
        public Klik.Windows.Forms.v1.EntryLib.ELButton btn_agregar;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_nombre;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TextBox txt_Sangre;
        private System.Windows.Forms.MaskedTextBox txtFecha_Nac;
        private System.Windows.Forms.TextBox txt_Alergia;
    }
}