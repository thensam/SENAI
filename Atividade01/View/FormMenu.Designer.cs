namespace Atividade01
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            btnFuncionarios = new Bunifu.UI.WinForms.BunifuImageButton();
            bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            panelTarefa = new Panel();
            bunifuPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.ActiveImage = null;
            btnFuncionarios.AllowAnimations = true;
            btnFuncionarios.AllowBuffering = false;
            btnFuncionarios.AllowToggling = false;
            btnFuncionarios.AllowZooming = true;
            btnFuncionarios.AllowZoomingOnFocus = false;
            btnFuncionarios.BackColor = Color.Black;
            btnFuncionarios.DialogResult = DialogResult.None;
            btnFuncionarios.ErrorImage = (Image)resources.GetObject("btnFuncionarios.ErrorImage");
            btnFuncionarios.FadeWhenInactive = false;
            btnFuncionarios.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            btnFuncionarios.Image = (Image)resources.GetObject("btnFuncionarios.Image");
            btnFuncionarios.ImageActive = null;
            btnFuncionarios.ImageLocation = null;
            btnFuncionarios.ImageMargin = 20;
            btnFuncionarios.ImageSize = new Size(32, 31);
            btnFuncionarios.ImageZoomSize = new Size(52, 51);
            btnFuncionarios.InitialImage = (Image)resources.GetObject("btnFuncionarios.InitialImage");
            btnFuncionarios.Location = new Point(3, 57);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Rotation = 0;
            btnFuncionarios.ShowActiveImage = true;
            btnFuncionarios.ShowCursorChanges = true;
            btnFuncionarios.ShowImageBorders = true;
            btnFuncionarios.ShowSizeMarkers = false;
            btnFuncionarios.Size = new Size(52, 51);
            btnFuncionarios.TabIndex = 3;
            btnFuncionarios.ToolTipText = "";
            btnFuncionarios.WaitOnLoad = false;
            btnFuncionarios.Zoom = 20;
            btnFuncionarios.ZoomSpeed = 10;
            btnFuncionarios.Click += btnFuncionarios_Click;
            // 
            // bunifuImageButton1
            // 
            bunifuImageButton1.ActiveImage = null;
            bunifuImageButton1.AllowAnimations = true;
            bunifuImageButton1.AllowBuffering = false;
            bunifuImageButton1.AllowToggling = false;
            bunifuImageButton1.AllowZooming = true;
            bunifuImageButton1.AllowZoomingOnFocus = false;
            bunifuImageButton1.BackColor = Color.Black;
            bunifuImageButton1.DialogResult = DialogResult.None;
            bunifuImageButton1.ErrorImage = (Image)resources.GetObject("bunifuImageButton1.ErrorImage");
            bunifuImageButton1.FadeWhenInactive = false;
            bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            bunifuImageButton1.Image = (Image)resources.GetObject("bunifuImageButton1.Image");
            bunifuImageButton1.ImageActive = null;
            bunifuImageButton1.ImageLocation = null;
            bunifuImageButton1.ImageMargin = 20;
            bunifuImageButton1.ImageSize = new Size(32, 31);
            bunifuImageButton1.ImageZoomSize = new Size(52, 51);
            bunifuImageButton1.InitialImage = (Image)resources.GetObject("bunifuImageButton1.InitialImage");
            bunifuImageButton1.Location = new Point(3, 0);
            bunifuImageButton1.Name = "bunifuImageButton1";
            bunifuImageButton1.Rotation = 0;
            bunifuImageButton1.ShowActiveImage = true;
            bunifuImageButton1.ShowCursorChanges = true;
            bunifuImageButton1.ShowImageBorders = true;
            bunifuImageButton1.ShowSizeMarkers = false;
            bunifuImageButton1.Size = new Size(52, 51);
            bunifuImageButton1.TabIndex = 2;
            bunifuImageButton1.ToolTipText = "";
            bunifuImageButton1.WaitOnLoad = false;
            bunifuImageButton1.Zoom = 20;
            bunifuImageButton1.ZoomSpeed = 10;
            bunifuImageButton1.Click += bunifuImageButton1_Click;
            // 
            // bunifuPanel1
            // 
            bunifuPanel1.BackgroundColor = Color.Black;
            bunifuPanel1.BackgroundImage = (Image)resources.GetObject("bunifuPanel1.BackgroundImage");
            bunifuPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel1.BorderColor = Color.Transparent;
            bunifuPanel1.BorderRadius = 3;
            bunifuPanel1.BorderThickness = 1;
            bunifuPanel1.Controls.Add(btnFuncionarios);
            bunifuPanel1.Controls.Add(bunifuImageButton1);
            bunifuPanel1.Dock = DockStyle.Left;
            bunifuPanel1.Location = new Point(0, 0);
            bunifuPanel1.Name = "bunifuPanel1";
            bunifuPanel1.ShowBorders = true;
            bunifuPanel1.Size = new Size(59, 497);
            bunifuPanel1.TabIndex = 4;
            // 
            // panelTarefa
            // 
            panelTarefa.Dock = DockStyle.Fill;
            panelTarefa.Location = new Point(59, 0);
            panelTarefa.Name = "panelTarefa";
            panelTarefa.Size = new Size(814, 497);
            panelTarefa.TabIndex = 5;
            panelTarefa.Paint += panelTarefa_Paint;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(873, 497);
            Controls.Add(panelTarefa);
            Controls.Add(bunifuPanel1);
            Name = "FormMenu";
            Text = "FormMenu";
            bunifuPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuImageButton btnFuncionarios;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Panel panelTarefa;
    }
}