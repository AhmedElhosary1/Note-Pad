namespace NotePad
{
    partial class NotePadMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePadMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new Guna.UI.WinForms.GunaTileButton();
            this.btnBold = new Guna.UI.WinForms.GunaTileButton();
            this.btnCopy = new Guna.UI.WinForms.GunaTileButton();
            this.btnCut = new Guna.UI.WinForms.GunaTileButton();
            this.btnErase = new Guna.UI.WinForms.GunaTileButton();
            this.btnImport = new Guna.UI.WinForms.GunaTileButton();
            this.btnLeft = new Guna.UI.WinForms.GunaTileButton();
            this.btnRight = new Guna.UI.WinForms.GunaTileButton();
            this.btnPaste = new Guna.UI.WinForms.GunaTileButton();
            this.btnPrint = new Guna.UI.WinForms.GunaTileButton();
            this.btnType = new Guna.UI.WinForms.GunaTileButton();
            this.btnUnderLine = new Guna.UI.WinForms.GunaTileButton();
            this.btnForColor = new Guna.UI.WinForms.GunaTileButton();
            this.trackBarSize = new Guna.UI.WinForms.GunaTrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.btnBackColor = new Guna.UI.WinForms.GunaTileButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBarSize);
            this.panel1.Controls.Add(this.btnBackColor);
            this.panel1.Controls.Add(this.btnForColor);
            this.panel1.Controls.Add(this.btnUnderLine);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnPaste);
            this.panel1.Controls.Add(this.btnType);
            this.panel1.Controls.Add(this.btnErase);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnCut);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnBold);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 90);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(12, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(70, 70);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBold
            // 
            this.btnBold.AnimationHoverSpeed = 0.07F;
            this.btnBold.AnimationSpeed = 0.03F;
            this.btnBold.BackColor = System.Drawing.Color.Transparent;
            this.btnBold.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnBold.BorderColor = System.Drawing.Color.Black;
            this.btnBold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBold.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBold.FocusedColor = System.Drawing.Color.Empty;
            this.btnBold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBold.ForeColor = System.Drawing.Color.Black;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBold.Location = new System.Drawing.Point(88, 10);
            this.btnBold.Name = "btnBold";
            this.btnBold.OnHoverBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBold.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBold.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBold.OnHoverImage = null;
            this.btnBold.OnPressedColor = System.Drawing.Color.Black;
            this.btnBold.Radius = 10;
            this.btnBold.Size = new System.Drawing.Size(70, 70);
            this.btnBold.TabIndex = 3;
            this.btnBold.Text = "Bold";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.AnimationHoverSpeed = 0.07F;
            this.btnCopy.AnimationSpeed = 0.03F;
            this.btnCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnCopy.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnCopy.BorderColor = System.Drawing.Color.Black;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCopy.FocusedColor = System.Drawing.Color.Empty;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.Black;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCopy.Location = new System.Drawing.Point(572, 10);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.OnHoverBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCopy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCopy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCopy.OnHoverImage = null;
            this.btnCopy.OnPressedColor = System.Drawing.Color.Black;
            this.btnCopy.Radius = 10;
            this.btnCopy.Size = new System.Drawing.Size(70, 70);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCut
            // 
            this.btnCut.AnimationHoverSpeed = 0.07F;
            this.btnCut.AnimationSpeed = 0.03F;
            this.btnCut.BackColor = System.Drawing.Color.Transparent;
            this.btnCut.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnCut.BorderColor = System.Drawing.Color.Black;
            this.btnCut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCut.FocusedColor = System.Drawing.Color.Empty;
            this.btnCut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCut.ForeColor = System.Drawing.Color.Black;
            this.btnCut.Image = ((System.Drawing.Image)(resources.GetObject("btnCut.Image")));
            this.btnCut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCut.Location = new System.Drawing.Point(648, 10);
            this.btnCut.Name = "btnCut";
            this.btnCut.OnHoverBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCut.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCut.OnHoverImage = null;
            this.btnCut.OnPressedColor = System.Drawing.Color.Black;
            this.btnCut.Radius = 10;
            this.btnCut.Size = new System.Drawing.Size(70, 70);
            this.btnCut.TabIndex = 3;
            this.btnCut.Text = "Cut";
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnErase
            // 
            this.btnErase.AnimationHoverSpeed = 0.07F;
            this.btnErase.AnimationSpeed = 0.03F;
            this.btnErase.BackColor = System.Drawing.Color.Transparent;
            this.btnErase.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnErase.BorderColor = System.Drawing.Color.Black;
            this.btnErase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnErase.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnErase.FocusedColor = System.Drawing.Color.Empty;
            this.btnErase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErase.ForeColor = System.Drawing.Color.Black;
            this.btnErase.Image = ((System.Drawing.Image)(resources.GetObject("btnErase.Image")));
            this.btnErase.ImageSize = new System.Drawing.Size(30, 30);
            this.btnErase.Location = new System.Drawing.Point(800, 10);
            this.btnErase.Name = "btnErase";
            this.btnErase.OnHoverBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnErase.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnErase.OnHoverForeColor = System.Drawing.Color.White;
            this.btnErase.OnHoverImage = null;
            this.btnErase.OnPressedColor = System.Drawing.Color.Black;
            this.btnErase.Radius = 10;
            this.btnErase.Size = new System.Drawing.Size(70, 70);
            this.btnErase.TabIndex = 3;
            this.btnErase.Text = "Erase";
            // 
            // btnImport
            // 
            this.btnImport.AnimationHoverSpeed = 0.07F;
            this.btnImport.AnimationSpeed = 0.03F;
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnImport.BorderColor = System.Drawing.Color.Black;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImport.FocusedColor = System.Drawing.Color.Empty;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageSize = new System.Drawing.Size(30, 30);
            this.btnImport.Location = new System.Drawing.Point(876, 10);
            this.btnImport.Name = "btnImport";
            this.btnImport.OnHoverBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnImport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImport.OnHoverImage = null;
            this.btnImport.OnPressedColor = System.Drawing.Color.Black;
            this.btnImport.Radius = 10;
            this.btnImport.Size = new System.Drawing.Size(70, 70);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.AnimationHoverSpeed = 0.07F;
            this.btnLeft.AnimationSpeed = 0.03F;
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnLeft.BorderColor = System.Drawing.Color.Black;
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLeft.FocusedColor = System.Drawing.Color.Empty;
            this.btnLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ForeColor = System.Drawing.Color.Black;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLeft.Location = new System.Drawing.Point(350, 10);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.OnHoverBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLeft.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLeft.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLeft.OnHoverImage = null;
            this.btnLeft.OnPressedColor = System.Drawing.Color.Black;
            this.btnLeft.Radius = 10;
            this.btnLeft.Size = new System.Drawing.Size(105, 70);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Left Align";
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.AnimationHoverSpeed = 0.07F;
            this.btnRight.AnimationSpeed = 0.03F;
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnRight.BorderColor = System.Drawing.Color.Black;
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRight.FocusedColor = System.Drawing.Color.Empty;
            this.btnRight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ForeColor = System.Drawing.Color.Black;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRight.Location = new System.Drawing.Point(461, 10);
            this.btnRight.Name = "btnRight";
            this.btnRight.OnHoverBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRight.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRight.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRight.OnHoverImage = null;
            this.btnRight.OnPressedColor = System.Drawing.Color.Black;
            this.btnRight.Radius = 10;
            this.btnRight.Size = new System.Drawing.Size(105, 70);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "Right Align";
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.AnimationHoverSpeed = 0.07F;
            this.btnPaste.AnimationSpeed = 0.03F;
            this.btnPaste.BackColor = System.Drawing.Color.Transparent;
            this.btnPaste.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnPaste.BorderColor = System.Drawing.Color.Black;
            this.btnPaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaste.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPaste.FocusedColor = System.Drawing.Color.Empty;
            this.btnPaste.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste.ForeColor = System.Drawing.Color.Black;
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPaste.Location = new System.Drawing.Point(724, 10);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.OnHoverBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPaste.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPaste.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPaste.OnHoverImage = null;
            this.btnPaste.OnPressedColor = System.Drawing.Color.Black;
            this.btnPaste.Radius = 10;
            this.btnPaste.Size = new System.Drawing.Size(70, 70);
            this.btnPaste.TabIndex = 3;
            this.btnPaste.Text = "Paste";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AnimationHoverSpeed = 0.07F;
            this.btnPrint.AnimationSpeed = 0.03F;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.BorderColor = System.Drawing.Color.Black;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPrint.Location = new System.Drawing.Point(952, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnHoverBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint.OnHoverImage = null;
            this.btnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint.Radius = 10;
            this.btnPrint.Size = new System.Drawing.Size(70, 70);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnType
            // 
            this.btnType.AnimationHoverSpeed = 0.07F;
            this.btnType.AnimationSpeed = 0.03F;
            this.btnType.BackColor = System.Drawing.Color.Transparent;
            this.btnType.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnType.BorderColor = System.Drawing.Color.Black;
            this.btnType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnType.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnType.FocusedColor = System.Drawing.Color.Empty;
            this.btnType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnType.ForeColor = System.Drawing.Color.Black;
            this.btnType.Image = ((System.Drawing.Image)(resources.GetObject("btnType.Image")));
            this.btnType.ImageSize = new System.Drawing.Size(30, 30);
            this.btnType.Location = new System.Drawing.Point(164, 10);
            this.btnType.Name = "btnType";
            this.btnType.OnHoverBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnType.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnType.OnHoverForeColor = System.Drawing.Color.White;
            this.btnType.OnHoverImage = null;
            this.btnType.OnPressedColor = System.Drawing.Color.Black;
            this.btnType.Radius = 10;
            this.btnType.Size = new System.Drawing.Size(70, 70);
            this.btnType.TabIndex = 3;
            this.btnType.Text = "Type";
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnUnderLine
            // 
            this.btnUnderLine.AnimationHoverSpeed = 0.07F;
            this.btnUnderLine.AnimationSpeed = 0.03F;
            this.btnUnderLine.BackColor = System.Drawing.Color.Transparent;
            this.btnUnderLine.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnUnderLine.BorderColor = System.Drawing.Color.Black;
            this.btnUnderLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnderLine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUnderLine.FocusedColor = System.Drawing.Color.Empty;
            this.btnUnderLine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnderLine.ForeColor = System.Drawing.Color.Black;
            this.btnUnderLine.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderLine.Image")));
            this.btnUnderLine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUnderLine.Location = new System.Drawing.Point(240, 10);
            this.btnUnderLine.Name = "btnUnderLine";
            this.btnUnderLine.OnHoverBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUnderLine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUnderLine.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUnderLine.OnHoverImage = null;
            this.btnUnderLine.OnPressedColor = System.Drawing.Color.Black;
            this.btnUnderLine.Radius = 10;
            this.btnUnderLine.Size = new System.Drawing.Size(105, 70);
            this.btnUnderLine.TabIndex = 3;
            this.btnUnderLine.Text = "Underline";
            this.btnUnderLine.Click += new System.EventHandler(this.btnUnderLine_Click);
            // 
            // btnForColor
            // 
            this.btnForColor.AnimationHoverSpeed = 0.07F;
            this.btnForColor.AnimationSpeed = 0.03F;
            this.btnForColor.BackColor = System.Drawing.Color.Transparent;
            this.btnForColor.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnForColor.BorderColor = System.Drawing.Color.Black;
            this.btnForColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForColor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnForColor.FocusedColor = System.Drawing.Color.Empty;
            this.btnForColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForColor.ForeColor = System.Drawing.Color.Black;
            this.btnForColor.Image = ((System.Drawing.Image)(resources.GetObject("btnForColor.Image")));
            this.btnForColor.ImageSize = new System.Drawing.Size(30, 30);
            this.btnForColor.Location = new System.Drawing.Point(1028, 10);
            this.btnForColor.Name = "btnForColor";
            this.btnForColor.OnHoverBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnForColor.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnForColor.OnHoverForeColor = System.Drawing.Color.White;
            this.btnForColor.OnHoverImage = null;
            this.btnForColor.OnPressedColor = System.Drawing.Color.Black;
            this.btnForColor.Radius = 10;
            this.btnForColor.Size = new System.Drawing.Size(70, 70);
            this.btnForColor.TabIndex = 3;
            this.btnForColor.Text = "ForeColor";
            this.btnForColor.Click += new System.EventHandler(this.btnForColor_Click);
            // 
            // trackBarSize
            // 
            this.trackBarSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSize.Location = new System.Drawing.Point(1336, 34);
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(134, 23);
            this.trackBarSize.TabIndex = 0;
            this.trackBarSize.TrackColor = System.Drawing.Color.Black;
            this.trackBarSize.TrackHoverColor = System.Drawing.Color.Gray;
            this.trackBarSize.TrackIdleColor = System.Drawing.Color.DarkGray;
            this.trackBarSize.TrackPressedColor = System.Drawing.Color.Black;
            this.trackBarSize.Value = 0;
            this.trackBarSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarSize_Scroll);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1482, 663);
            this.panel3.TabIndex = 2;
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Location = new System.Drawing.Point(12, 8);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1458, 643);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // btnBackColor
            // 
            this.btnBackColor.AnimationHoverSpeed = 0.07F;
            this.btnBackColor.AnimationSpeed = 0.03F;
            this.btnBackColor.BackColor = System.Drawing.Color.Transparent;
            this.btnBackColor.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackColor.BorderColor = System.Drawing.Color.Black;
            this.btnBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackColor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackColor.FocusedColor = System.Drawing.Color.Empty;
            this.btnBackColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackColor.ForeColor = System.Drawing.Color.Black;
            this.btnBackColor.Image = ((System.Drawing.Image)(resources.GetObject("btnBackColor.Image")));
            this.btnBackColor.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBackColor.Location = new System.Drawing.Point(1104, 10);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.OnHoverBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBackColor.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBackColor.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBackColor.OnHoverImage = null;
            this.btnBackColor.OnPressedColor = System.Drawing.Color.Black;
            this.btnBackColor.Radius = 10;
            this.btnBackColor.Size = new System.Drawing.Size(70, 70);
            this.btnBackColor.TabIndex = 3;
            this.btnBackColor.Text = "BackColor";
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // NotePadMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimumSize = new System.Drawing.Size(1100, 400);
            this.Name = "NotePadMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note Pad";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTileButton btnSave;
        private Guna.UI.WinForms.GunaTileButton btnForColor;
        private Guna.UI.WinForms.GunaTileButton btnUnderLine;
        private Guna.UI.WinForms.GunaTileButton btnPrint;
        private Guna.UI.WinForms.GunaTileButton btnPaste;
        private Guna.UI.WinForms.GunaTileButton btnType;
        private Guna.UI.WinForms.GunaTileButton btnErase;
        private Guna.UI.WinForms.GunaTileButton btnRight;
        private Guna.UI.WinForms.GunaTileButton btnCut;
        private Guna.UI.WinForms.GunaTileButton btnLeft;
        private Guna.UI.WinForms.GunaTileButton btnCopy;
        private Guna.UI.WinForms.GunaTileButton btnImport;
        private Guna.UI.WinForms.GunaTileButton btnBold;
        private Guna.UI.WinForms.GunaTrackBar trackBarSize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private Guna.UI.WinForms.GunaTileButton btnBackColor;
    }
}

