namespace Agenda.Controles {
	partial class MenuControl {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.pnlName = new MetroSet_UI.Controls.MetroSetPanel();
			this.txtName = new MetroSet_UI.Controls.MetroSetTextBox();
			this.btnArrowUpDown = new MetroSet_UI.Controls.MetroSetEllipse();
			this.pnlLeft = new MetroSet_UI.Controls.MetroSetPanel();
			this.div = new System.Windows.Forms.Panel();
			this.flowLay = new System.Windows.Forms.FlowLayoutPanel();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cambiarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configurarMáximoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.pnlName.SuspendLayout();
			this.pnlLeft.SuspendLayout();
			this.contextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlName
			// 
			this.pnlName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.pnlName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
			this.pnlName.BorderThickness = 0;
			this.pnlName.Controls.Add(this.txtName);
			this.pnlName.Controls.Add(this.btnArrowUpDown);
			this.pnlName.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlName.IsDerivedStyle = true;
			this.pnlName.Location = new System.Drawing.Point(0, 0);
			this.pnlName.Name = "pnlName";
			this.pnlName.Size = new System.Drawing.Size(241, 38);
			this.pnlName.Style = MetroSet_UI.Enums.Style.Dark;
			this.pnlName.StyleManager = null;
			this.pnlName.TabIndex = 0;
			this.pnlName.ThemeAuthor = "Narwin";
			this.pnlName.ThemeName = "MetroDark";
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.AutoCompleteCustomSource = null;
			this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txtName.BorderColor = System.Drawing.Color.Transparent;
			this.txtName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.txtName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
			this.txtName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.txtName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.txtName.Image = null;
			this.txtName.IsDerivedStyle = true;
			this.txtName.Lines = null;
			this.txtName.Location = new System.Drawing.Point(7, 7);
			this.txtName.MaxLength = 17;
			this.txtName.Multiline = false;
			this.txtName.Name = "txtName";
			this.txtName.ReadOnly = false;
			this.txtName.Size = new System.Drawing.Size(178, 23);
			this.txtName.Style = MetroSet_UI.Enums.Style.Custom;
			this.txtName.StyleManager = null;
			this.txtName.TabIndex = 2;
			this.txtName.TabStop = false;
			this.txtName.Text = "Menu 1";
			this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtName.ThemeAuthor = "Narwin";
			this.txtName.ThemeName = "MetroLite";
			this.txtName.UseSystemPasswordChar = false;
			this.txtName.WatermarkText = "";
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			this.txtName.KeyPressed += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
			this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
			// 
			// btnArrowUpDown
			// 
			this.btnArrowUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnArrowUpDown.BorderThickness = 0;
			this.btnArrowUpDown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnArrowUpDown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.btnArrowUpDown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.btnArrowUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnArrowUpDown.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.btnArrowUpDown.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.btnArrowUpDown.HoverTextColor = System.Drawing.Color.White;
			this.btnArrowUpDown.Image = global::Agenda.Properties.Resources.flecha_abajo;
			this.btnArrowUpDown.ImageSize = new System.Drawing.Size(15, 15);
			this.btnArrowUpDown.IsDerivedStyle = true;
			this.btnArrowUpDown.Location = new System.Drawing.Point(206, 5);
			this.btnArrowUpDown.Name = "btnArrowUpDown";
			this.btnArrowUpDown.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnArrowUpDown.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.btnArrowUpDown.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnArrowUpDown.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.btnArrowUpDown.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.btnArrowUpDown.PressTextColor = System.Drawing.Color.White;
			this.btnArrowUpDown.Size = new System.Drawing.Size(30, 29);
			this.btnArrowUpDown.Style = MetroSet_UI.Enums.Style.Dark;
			this.btnArrowUpDown.StyleManager = null;
			this.btnArrowUpDown.TabIndex = 1;
			this.btnArrowUpDown.TabStop = false;
			this.btnArrowUpDown.ThemeAuthor = "Narwin";
			this.btnArrowUpDown.ThemeName = "MetroDark";
			this.btnArrowUpDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnArrowUpDown_MouseClick);
			// 
			// pnlLeft
			// 
			this.pnlLeft.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
			this.pnlLeft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
			this.pnlLeft.BorderThickness = 0;
			this.pnlLeft.Controls.Add(this.div);
			this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLeft.IsDerivedStyle = true;
			this.pnlLeft.Location = new System.Drawing.Point(0, 38);
			this.pnlLeft.Name = "pnlLeft";
			this.pnlLeft.Size = new System.Drawing.Size(43, 86);
			this.pnlLeft.Style = MetroSet_UI.Enums.Style.Custom;
			this.pnlLeft.StyleManager = null;
			this.pnlLeft.TabIndex = 1;
			this.pnlLeft.ThemeAuthor = "Narwin";
			this.pnlLeft.ThemeName = "MetroDark";
			// 
			// div
			// 
			this.div.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.div.Location = new System.Drawing.Point(20, 0);
			this.div.Name = "div";
			this.div.Size = new System.Drawing.Size(2, 83);
			this.div.TabIndex = 0;
			// 
			// flowLay
			// 
			this.flowLay.BackColor = System.Drawing.Color.Transparent;
			this.flowLay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLay.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLay.Location = new System.Drawing.Point(43, 38);
			this.flowLay.Name = "flowLay";
			this.flowLay.Size = new System.Drawing.Size(198, 86);
			this.flowLay.TabIndex = 2;
			// 
			// contextMenu
			// 
			this.contextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarNombreToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.configurarMáximoToolStripMenuItem});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.contextMenu.Size = new System.Drawing.Size(167, 70);
			this.contextMenu.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenu_Closed);
			// 
			// cambiarNombreToolStripMenuItem
			// 
			this.cambiarNombreToolStripMenuItem.AutoSize = false;
			this.cambiarNombreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.cambiarNombreToolStripMenuItem.Image = global::Agenda.Properties.Resources.rename;
			this.cambiarNombreToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cambiarNombreToolStripMenuItem.Name = "cambiarNombreToolStripMenuItem";
			this.cambiarNombreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cambiarNombreToolStripMenuItem.Text = "Cambiar Nombre";
			this.cambiarNombreToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cambiarNombreToolStripMenuItem.Click += new System.EventHandler(this.cambiarNombreToolStripMenuItem_Click_1);
			// 
			// eliminarToolStripMenuItem
			// 
			this.eliminarToolStripMenuItem.AutoSize = false;
			this.eliminarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.eliminarToolStripMenuItem.Image = global::Agenda.Properties.Resources.trash_can;
			this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
			this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.eliminarToolStripMenuItem.Text = "Eliminar";
			this.eliminarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click_1);
			// 
			// configurarMáximoToolStripMenuItem
			// 
			this.configurarMáximoToolStripMenuItem.AutoSize = false;
			this.configurarMáximoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.configurarMáximoToolStripMenuItem.Image = global::Agenda.Properties.Resources.paquete;
			this.configurarMáximoToolStripMenuItem.Name = "configurarMáximoToolStripMenuItem";
			this.configurarMáximoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.configurarMáximoToolStripMenuItem.Text = "Tareas a mostrar";
			this.configurarMáximoToolStripMenuItem.Click += new System.EventHandler(this.configurarMáximoToolStripMenuItem_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// MenuControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
			this.Controls.Add(this.flowLay);
			this.Controls.Add(this.pnlLeft);
			this.Controls.Add(this.pnlName);
			this.MinimumSize = new System.Drawing.Size(0, 37);
			this.Name = "MenuControl";
			this.Size = new System.Drawing.Size(241, 124);
			this.pnlName.ResumeLayout(false);
			this.pnlLeft.ResumeLayout(false);
			this.contextMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroSet_UI.Controls.MetroSetPanel pnlName;
		private MetroSet_UI.Controls.MetroSetPanel pnlLeft;
		private MetroSet_UI.Controls.MetroSetEllipse btnArrowUpDown;
		private System.Windows.Forms.FlowLayoutPanel flowLay;
		private System.Windows.Forms.Panel div;
		private MetroSet_UI.Controls.MetroSetTextBox txtName;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem cambiarNombreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configurarMáximoToolStripMenuItem;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}
