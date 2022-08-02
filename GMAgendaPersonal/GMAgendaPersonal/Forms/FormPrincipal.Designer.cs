namespace GMAgendaPersonal.Forms {
	partial class FormPrincipal {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
			this.panelLeftBar = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.btnLogout = new MetroSet_UI.Controls.MetroSetEllipse();
			this.btnExtra = new MetroSet_UI.Controls.MetroSetEllipse();
			this.btnCategories = new MetroSet_UI.Controls.MetroSetEllipse();
			this.pictureBoxDot = new System.Windows.Forms.PictureBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lineLeftBarDivider = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel16 = new System.Windows.Forms.Panel();
			this.pictureUserFoto = new Agenda.Controles.CircularPictureBox(this.components);
			this.panel3 = new System.Windows.Forms.Panel();
			this.panelContent = new System.Windows.Forms.Panel();
			this.panelFormContent = new System.Windows.Forms.Panel();
			this.pnlContent = new MetroSet_UI.Controls.MetroSetPanel();
			this.mainContentTabControl = new MetroSet_UI.Controls.CustomTabControl();
			this.panel19 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnSearch = new MetroSet_UI.Controls.MetroSetEllipse();
			this.btnNotifications = new MetroSet_UI.Controls.MetroSetEllipse();
			this.btnCalendar = new MetroSet_UI.Controls.MetroSetEllipse();
			this.lblTodayDate = new System.Windows.Forms.Label();
			this.panelWelcome = new System.Windows.Forms.Panel();
			this.lblWelcomeText = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel8 = new System.Windows.Forms.Panel();
			this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
			this.panelSubMenu = new System.Windows.Forms.Panel();
			this.panelFlowLay = new System.Windows.Forms.Panel();
			this.flowLaySlideMenu = new System.Windows.Forms.FlowLayoutPanel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.panel14 = new System.Windows.Forms.Panel();
			this.lineSlideBar = new System.Windows.Forms.Panel();
			this.btnSlideAdd = new MetroSet_UI.Controls.MetroSetEllipse();
			this.lblSlideMenuTitle = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.timerSlideBar = new System.Windows.Forms.Timer(this.components);
			this.panelForm = new System.Windows.Forms.Panel();
			this.timerUserIconAnimation = new System.Windows.Forms.Timer(this.components);
			this.metroSetSetTabPage1 = new MetroSet_UI.Child.MetroSetSetTabPage();
			this.metroSetSetTabPage2 = new MetroSet_UI.Child.MetroSetSetTabPage();
			this.metroSetSetTabPage3 = new MetroSet_UI.Child.MetroSetSetTabPage();
			this.metroSetSetTabPage4 = new MetroSet_UI.Child.MetroSetSetTabPage();
			this.metroSetSetTabPage5 = new MetroSet_UI.Child.MetroSetSetTabPage();
			this.metroSetSetTabPage6 = new MetroSet_UI.Child.MetroSetSetTabPage();
			this.panelLeftBar.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDot)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel16.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureUserFoto)).BeginInit();
			this.panelContent.SuspendLayout();
			this.panelFormContent.SuspendLayout();
			this.pnlContent.SuspendLayout();
			this.panel19.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panelWelcome.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel8.SuspendLayout();
			this.panelSubMenu.SuspendLayout();
			this.panelFlowLay.SuspendLayout();
			this.panel14.SuspendLayout();
			this.panelForm.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelLeftBar
			// 
			this.panelLeftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
			this.panelLeftBar.Controls.Add(this.panel6);
			this.panelLeftBar.Controls.Add(this.panel5);
			this.panelLeftBar.Controls.Add(this.panel2);
			resources.ApplyResources(this.panelLeftBar, "panelLeftBar");
			this.panelLeftBar.Name = "panelLeftBar";
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.btnLogout);
			this.panel6.Controls.Add(this.btnExtra);
			this.panel6.Controls.Add(this.btnCategories);
			this.panel6.Controls.Add(this.pictureBoxDot);
			resources.ApplyResources(this.panel6, "panel6");
			this.panel6.Name = "panel6";
			this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserInteraction);
			// 
			// btnLogout
			// 
			resources.ApplyResources(this.btnLogout, "btnLogout");
			this.btnLogout.BorderThickness = 0;
			this.btnLogout.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnLogout.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
			this.btnLogout.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			this.btnLogout.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
			this.btnLogout.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(104)))), ((int)(((byte)(26)))));
			this.btnLogout.HoverTextColor = System.Drawing.Color.Transparent;
			this.btnLogout.Image = global::GMAgendaPersonal.Properties.Resources.sign_out;
			this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
			this.btnLogout.IsDerivedStyle = true;
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.NormalBorderColor = System.Drawing.Color.Transparent;
			this.btnLogout.NormalColor = System.Drawing.Color.Transparent;
			this.btnLogout.NormalTextColor = System.Drawing.Color.Black;
			this.btnLogout.PressBorderColor = System.Drawing.Color.Transparent;
			this.btnLogout.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
			this.btnLogout.PressTextColor = System.Drawing.Color.White;
			this.btnLogout.Style = MetroSet_UI.Enums.Style.Custom;
			this.btnLogout.StyleManager = null;
			this.btnLogout.TabStop = false;
			this.btnLogout.ThemeAuthor = "Narwin";
			this.btnLogout.ThemeName = "MetroLite";
			this.btnLogout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLogout_MouseClick);
			// 
			// btnExtra
			// 
			this.btnExtra.BorderThickness = 0;
			this.btnExtra.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnExtra.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
			this.btnExtra.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			resources.ApplyResources(this.btnExtra, "btnExtra");
			this.btnExtra.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
			this.btnExtra.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
			this.btnExtra.HoverTextColor = System.Drawing.Color.Transparent;
			this.btnExtra.Image = global::GMAgendaPersonal.Properties.Resources.settings;
			this.btnExtra.ImageSize = new System.Drawing.Size(20, 20);
			this.btnExtra.IsDerivedStyle = true;
			this.btnExtra.Name = "btnExtra";
			this.btnExtra.NormalBorderColor = System.Drawing.Color.Transparent;
			this.btnExtra.NormalColor = System.Drawing.Color.Transparent;
			this.btnExtra.NormalTextColor = System.Drawing.Color.Black;
			this.btnExtra.PressBorderColor = System.Drawing.Color.Transparent;
			this.btnExtra.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
			this.btnExtra.PressTextColor = System.Drawing.Color.White;
			this.btnExtra.Style = MetroSet_UI.Enums.Style.Custom;
			this.btnExtra.StyleManager = null;
			this.btnExtra.TabStop = false;
			this.btnExtra.ThemeAuthor = "Narwin";
			this.btnExtra.ThemeName = "MetroLite";
			this.btnExtra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnExtra_MouseClick);
			// 
			// btnCategories
			// 
			this.btnCategories.BorderThickness = 0;
			this.btnCategories.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnCategories.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
			this.btnCategories.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			resources.ApplyResources(this.btnCategories, "btnCategories");
			this.btnCategories.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
			this.btnCategories.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
			this.btnCategories.HoverTextColor = System.Drawing.Color.Transparent;
			this.btnCategories.Image = global::GMAgendaPersonal.Properties.Resources.squares;
			this.btnCategories.ImageSize = new System.Drawing.Size(20, 20);
			this.btnCategories.IsDerivedStyle = true;
			this.btnCategories.Name = "btnCategories";
			this.btnCategories.NormalBorderColor = System.Drawing.Color.Transparent;
			this.btnCategories.NormalColor = System.Drawing.Color.Transparent;
			this.btnCategories.NormalTextColor = System.Drawing.Color.Black;
			this.btnCategories.PressBorderColor = System.Drawing.Color.Transparent;
			this.btnCategories.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
			this.btnCategories.PressTextColor = System.Drawing.Color.White;
			this.btnCategories.Style = MetroSet_UI.Enums.Style.Custom;
			this.btnCategories.StyleManager = null;
			this.btnCategories.TabStop = false;
			this.btnCategories.ThemeAuthor = "Narwin";
			this.btnCategories.ThemeName = "MetroLite";
			this.btnCategories.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCategories_MouseClick);
			// 
			// pictureBoxDot
			// 
			this.pictureBoxDot.Image = global::GMAgendaPersonal.Properties.Resources.dot;
			resources.ApplyResources(this.pictureBoxDot, "pictureBoxDot");
			this.pictureBoxDot.Name = "pictureBoxDot";
			this.pictureBoxDot.TabStop = false;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.lineLeftBarDivider);
			resources.ApplyResources(this.panel5, "panel5");
			this.panel5.Name = "panel5";
			// 
			// lineLeftBarDivider
			// 
			this.lineLeftBarDivider.BackColor = System.Drawing.Color.SlateGray;
			resources.ApplyResources(this.lineLeftBarDivider, "lineLeftBarDivider");
			this.lineLeftBarDivider.Name = "lineLeftBarDivider";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel16);
			this.panel2.Controls.Add(this.panel3);
			resources.ApplyResources(this.panel2, "panel2");
			this.panel2.Name = "panel2";
			// 
			// panel16
			// 
			this.panel16.Controls.Add(this.pictureUserFoto);
			resources.ApplyResources(this.panel16, "panel16");
			this.panel16.Name = "panel16";
			// 
			// pictureUserFoto
			// 
			resources.ApplyResources(this.pictureUserFoto, "pictureUserFoto");
			this.pictureUserFoto.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
			this.pictureUserFoto.BorderColor = System.Drawing.Color.RoyalBlue;
			this.pictureUserFoto.BorderColor2 = System.Drawing.Color.Coral;
			this.pictureUserFoto.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
			this.pictureUserFoto.BorderSize = 3;
			this.pictureUserFoto.GradientAngle = 2F;
			this.pictureUserFoto.Image = global::GMAgendaPersonal.Properties.Resources.default_user;
			this.pictureUserFoto.Name = "pictureUserFoto";
			this.pictureUserFoto.TabStop = false;
			this.pictureUserFoto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserInteraction);
			// 
			// panel3
			// 
			resources.ApplyResources(this.panel3, "panel3");
			this.panel3.Name = "panel3";
			this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTopBar_MouseDown);
			// 
			// panelContent
			// 
			this.panelContent.Controls.Add(this.panelFormContent);
			this.panelContent.Controls.Add(this.panel8);
			this.panelContent.Controls.Add(this.panelSubMenu);
			resources.ApplyResources(this.panelContent, "panelContent");
			this.panelContent.Name = "panelContent";
			// 
			// panelFormContent
			// 
			this.panelFormContent.Controls.Add(this.pnlContent);
			this.panelFormContent.Controls.Add(this.panel19);
			resources.ApplyResources(this.panelFormContent, "panelFormContent");
			this.panelFormContent.Name = "panelFormContent";
			// 
			// pnlContent
			// 
			this.pnlContent.BackgroundColor = System.Drawing.Color.Transparent;
			this.pnlContent.BorderColor = System.Drawing.Color.Transparent;
			this.pnlContent.BorderThickness = 1;
			this.pnlContent.Controls.Add(this.mainContentTabControl);
			resources.ApplyResources(this.pnlContent, "pnlContent");
			this.pnlContent.IsDerivedStyle = true;
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Style = MetroSet_UI.Enums.Style.Custom;
			this.pnlContent.StyleManager = null;
			this.pnlContent.ThemeAuthor = "Narwin";
			this.pnlContent.ThemeName = "MetroLite";
			// 
			// mainContentTabControl
			// 
			this.mainContentTabControl.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
			this.mainContentTabControl.AnimateTime = 200;
			this.mainContentTabControl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
			resources.ApplyResources(this.mainContentTabControl, "mainContentTabControl");
			this.mainContentTabControl.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.mainContentTabControl.IsDerivedStyle = true;
			this.mainContentTabControl.Name = "mainContentTabControl";
			this.mainContentTabControl.SelectedTextColor = System.Drawing.Color.White;
			this.mainContentTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.mainContentTabControl.Speed = 100;
			this.mainContentTabControl.Style = MetroSet_UI.Enums.Style.Custom;
			this.mainContentTabControl.StyleManager = null;
			this.mainContentTabControl.ThemeAuthor = "Narwin";
			this.mainContentTabControl.ThemeName = "MetroLite";
			this.mainContentTabControl.UnselectedTextColor = System.Drawing.Color.Gray;
			this.mainContentTabControl.UseAnimation = false;
			// 
			// panel19
			// 
			this.panel19.Controls.Add(this.panel1);
			resources.ApplyResources(this.panel19, "panel19");
			this.panel19.Name = "panel19";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panelWelcome);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnSearch);
			this.panel4.Controls.Add(this.btnNotifications);
			this.panel4.Controls.Add(this.btnCalendar);
			this.panel4.Controls.Add(this.lblTodayDate);
			resources.ApplyResources(this.panel4, "panel4");
			this.panel4.Name = "panel4";
			this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserInteraction);
			// 
			// btnSearch
			// 
			this.btnSearch.BorderThickness = 0;
			this.btnSearch.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
			this.btnSearch.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			resources.ApplyResources(this.btnSearch, "btnSearch");
			this.btnSearch.HoverBorderColor = System.Drawing.Color.Transparent;
			this.btnSearch.HoverColor = System.Drawing.Color.Transparent;
			this.btnSearch.HoverTextColor = System.Drawing.Color.Transparent;
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.ImageSize = new System.Drawing.Size(19, 19);
			this.btnSearch.IsDerivedStyle = true;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.NormalBorderColor = System.Drawing.Color.Transparent;
			this.btnSearch.NormalColor = System.Drawing.Color.Transparent;
			this.btnSearch.NormalTextColor = System.Drawing.Color.Black;
			this.btnSearch.PressBorderColor = System.Drawing.Color.Transparent;
			this.btnSearch.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
			this.btnSearch.PressTextColor = System.Drawing.Color.White;
			this.btnSearch.Style = MetroSet_UI.Enums.Style.Custom;
			this.btnSearch.StyleManager = null;
			this.btnSearch.TabStop = false;
			this.btnSearch.ThemeAuthor = "Narwin";
			this.btnSearch.ThemeName = "MetroLite";
			this.btnSearch.Click += new System.EventHandler(this.metroSetEllipse2_Click);
			this.btnSearch.MouseEnter += new System.EventHandler(this.metroSetEllipse2_MouseEnter);
			this.btnSearch.MouseLeave += new System.EventHandler(this.metroSetEllipse2_MouseLeave);
			// 
			// btnNotifications
			// 
			this.btnNotifications.BorderThickness = 0;
			this.btnNotifications.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnNotifications.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
			this.btnNotifications.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			resources.ApplyResources(this.btnNotifications, "btnNotifications");
			this.btnNotifications.HoverBorderColor = System.Drawing.Color.Transparent;
			this.btnNotifications.HoverColor = System.Drawing.Color.Transparent;
			this.btnNotifications.HoverTextColor = System.Drawing.Color.Transparent;
			this.btnNotifications.Image = ((System.Drawing.Image)(resources.GetObject("btnNotifications.Image")));
			this.btnNotifications.ImageSize = new System.Drawing.Size(21, 21);
			this.btnNotifications.IsDerivedStyle = true;
			this.btnNotifications.Name = "btnNotifications";
			this.btnNotifications.NormalBorderColor = System.Drawing.Color.Transparent;
			this.btnNotifications.NormalColor = System.Drawing.Color.Transparent;
			this.btnNotifications.NormalTextColor = System.Drawing.Color.Black;
			this.btnNotifications.PressBorderColor = System.Drawing.Color.Transparent;
			this.btnNotifications.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
			this.btnNotifications.PressTextColor = System.Drawing.Color.White;
			this.btnNotifications.Style = MetroSet_UI.Enums.Style.Custom;
			this.btnNotifications.StyleManager = null;
			this.btnNotifications.TabStop = false;
			this.btnNotifications.ThemeAuthor = "Narwin";
			this.btnNotifications.ThemeName = "MetroLite";
			this.btnNotifications.Click += new System.EventHandler(this.metroSetEllipse1_Click);
			this.btnNotifications.MouseEnter += new System.EventHandler(this.metroSetEllipse2_MouseEnter);
			this.btnNotifications.MouseLeave += new System.EventHandler(this.metroSetEllipse2_MouseLeave);
			// 
			// btnCalendar
			// 
			this.btnCalendar.BorderThickness = 0;
			this.btnCalendar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnCalendar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
			this.btnCalendar.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			resources.ApplyResources(this.btnCalendar, "btnCalendar");
			this.btnCalendar.HoverBorderColor = System.Drawing.Color.Transparent;
			this.btnCalendar.HoverColor = System.Drawing.Color.Transparent;
			this.btnCalendar.HoverTextColor = System.Drawing.Color.Transparent;
			this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
			this.btnCalendar.ImageSize = new System.Drawing.Size(19, 19);
			this.btnCalendar.IsDerivedStyle = true;
			this.btnCalendar.Name = "btnCalendar";
			this.btnCalendar.NormalBorderColor = System.Drawing.Color.Transparent;
			this.btnCalendar.NormalColor = System.Drawing.Color.Transparent;
			this.btnCalendar.NormalTextColor = System.Drawing.Color.Black;
			this.btnCalendar.PressBorderColor = System.Drawing.Color.Transparent;
			this.btnCalendar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
			this.btnCalendar.PressTextColor = System.Drawing.Color.White;
			this.btnCalendar.Style = MetroSet_UI.Enums.Style.Custom;
			this.btnCalendar.StyleManager = null;
			this.btnCalendar.TabStop = false;
			this.btnCalendar.ThemeAuthor = "Narwin";
			this.btnCalendar.ThemeName = "MetroLite";
			this.btnCalendar.MouseEnter += new System.EventHandler(this.metroSetEllipse2_MouseEnter);
			this.btnCalendar.MouseLeave += new System.EventHandler(this.metroSetEllipse2_MouseLeave);
			// 
			// lblTodayDate
			// 
			this.lblTodayDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.lblTodayDate, "lblTodayDate");
			this.lblTodayDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(149)))));
			this.lblTodayDate.Name = "lblTodayDate";
			// 
			// panelWelcome
			// 
			this.panelWelcome.Controls.Add(this.lblWelcomeText);
			this.panelWelcome.Controls.Add(this.pictureBox1);
			resources.ApplyResources(this.panelWelcome, "panelWelcome");
			this.panelWelcome.Name = "panelWelcome";
			// 
			// lblWelcomeText
			// 
			resources.ApplyResources(this.lblWelcomeText, "lblWelcomeText");
			this.lblWelcomeText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblWelcomeText.ForeColor = System.Drawing.Color.White;
			this.lblWelcomeText.Name = "lblWelcomeText";
			this.lblWelcomeText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserInteraction);
			// 
			// pictureBox1
			// 
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Image = global::GMAgendaPersonal.Properties.Resources.waving_hand;
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.metroSetControlBox1);
			resources.ApplyResources(this.panel8, "panel8");
			this.panel8.Name = "panel8";
			this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTopBar_MouseDown);
			// 
			// metroSetControlBox1
			// 
			resources.ApplyResources(this.metroSetControlBox1, "metroSetControlBox1");
			this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
			this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
			this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
			this.metroSetControlBox1.IsDerivedStyle = true;
			this.metroSetControlBox1.MaximizeBox = true;
			this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
			this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
			this.metroSetControlBox1.MinimizeBox = true;
			this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
			this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
			this.metroSetControlBox1.Name = "metroSetControlBox1";
			this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
			this.metroSetControlBox1.StyleManager = null;
			this.metroSetControlBox1.TabStop = false;
			this.metroSetControlBox1.ThemeAuthor = "Narwin";
			this.metroSetControlBox1.ThemeName = "MetroDark";
			// 
			// panelSubMenu
			// 
			this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
			this.panelSubMenu.Controls.Add(this.panelFlowLay);
			this.panelSubMenu.Controls.Add(this.panel10);
			this.panelSubMenu.Controls.Add(this.panel14);
			resources.ApplyResources(this.panelSubMenu, "panelSubMenu");
			this.panelSubMenu.Name = "panelSubMenu";
			// 
			// panelFlowLay
			// 
			this.panelFlowLay.Controls.Add(this.flowLaySlideMenu);
			resources.ApplyResources(this.panelFlowLay, "panelFlowLay");
			this.panelFlowLay.Name = "panelFlowLay";
			// 
			// flowLaySlideMenu
			// 
			resources.ApplyResources(this.flowLaySlideMenu, "flowLaySlideMenu");
			this.flowLaySlideMenu.Name = "flowLaySlideMenu";
			this.flowLaySlideMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserInteraction);
			// 
			// panel10
			// 
			resources.ApplyResources(this.panel10, "panel10");
			this.panel10.Name = "panel10";
			// 
			// panel14
			// 
			this.panel14.Controls.Add(this.lineSlideBar);
			this.panel14.Controls.Add(this.btnSlideAdd);
			this.panel14.Controls.Add(this.lblSlideMenuTitle);
			this.panel14.Controls.Add(this.panel7);
			resources.ApplyResources(this.panel14, "panel14");
			this.panel14.Name = "panel14";
			this.panel14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTopBar_MouseDown);
			// 
			// lineSlideBar
			// 
			this.lineSlideBar.BackColor = System.Drawing.Color.SlateGray;
			resources.ApplyResources(this.lineSlideBar, "lineSlideBar");
			this.lineSlideBar.Name = "lineSlideBar";
			// 
			// btnSlideAdd
			// 
			this.btnSlideAdd.BorderThickness = 0;
			this.btnSlideAdd.DisabledBackColor = System.Drawing.Color.Transparent;
			this.btnSlideAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.btnSlideAdd.DisabledForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.btnSlideAdd, "btnSlideAdd");
			this.btnSlideAdd.HoverBorderColor = System.Drawing.Color.Transparent;
			this.btnSlideAdd.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.btnSlideAdd.HoverTextColor = System.Drawing.Color.Transparent;
			this.btnSlideAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnSlideAdd.Image")));
			this.btnSlideAdd.ImageSize = new System.Drawing.Size(11, 11);
			this.btnSlideAdd.IsDerivedStyle = true;
			this.btnSlideAdd.Name = "btnSlideAdd";
			this.btnSlideAdd.NormalBorderColor = System.Drawing.Color.Transparent;
			this.btnSlideAdd.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
			this.btnSlideAdd.NormalTextColor = System.Drawing.Color.Black;
			this.btnSlideAdd.PressBorderColor = System.Drawing.Color.Transparent;
			this.btnSlideAdd.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.btnSlideAdd.PressTextColor = System.Drawing.Color.White;
			this.btnSlideAdd.Style = MetroSet_UI.Enums.Style.Custom;
			this.btnSlideAdd.StyleManager = null;
			this.btnSlideAdd.TabStop = false;
			this.btnSlideAdd.ThemeAuthor = "Narwin";
			this.btnSlideAdd.ThemeName = "MetroLite";
			// 
			// lblSlideMenuTitle
			// 
			resources.ApplyResources(this.lblSlideMenuTitle, "lblSlideMenuTitle");
			this.lblSlideMenuTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblSlideMenuTitle.ForeColor = System.Drawing.Color.White;
			this.lblSlideMenuTitle.Name = "lblSlideMenuTitle";
			// 
			// panel7
			// 
			resources.ApplyResources(this.panel7, "panel7");
			this.panel7.Name = "panel7";
			this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTopBar_MouseDown);
			// 
			// notifyIcon
			// 
			resources.ApplyResources(this.notifyIcon, "notifyIcon");
			// 
			// timerSlideBar
			// 
			this.timerSlideBar.Interval = 10;
			// 
			// panelForm
			// 
			this.panelForm.Controls.Add(this.panelContent);
			this.panelForm.Controls.Add(this.panelLeftBar);
			resources.ApplyResources(this.panelForm, "panelForm");
			this.panelForm.Name = "panelForm";
			// 
			// timerUserIconAnimation
			// 
			this.timerUserIconAnimation.Interval = 500;
			this.timerUserIconAnimation.Tick += new System.EventHandler(this.timerUserIconAnimation_Tick);
			// 
			// metroSetSetTabPage1
			// 
			this.metroSetSetTabPage1.BaseColor = System.Drawing.Color.White;
			resources.ApplyResources(this.metroSetSetTabPage1, "metroSetSetTabPage1");
			this.metroSetSetTabPage1.IsDerivedStyle = true;
			this.metroSetSetTabPage1.Name = "metroSetSetTabPage1";
			this.metroSetSetTabPage1.Style = MetroSet_UI.Enums.Style.Light;
			this.metroSetSetTabPage1.StyleManager = null;
			this.metroSetSetTabPage1.ThemeAuthor = "Narwin";
			this.metroSetSetTabPage1.ThemeName = "MetroLite";
			// 
			// metroSetSetTabPage2
			// 
			this.metroSetSetTabPage2.BaseColor = System.Drawing.Color.White;
			resources.ApplyResources(this.metroSetSetTabPage2, "metroSetSetTabPage2");
			this.metroSetSetTabPage2.IsDerivedStyle = true;
			this.metroSetSetTabPage2.Name = "metroSetSetTabPage2";
			this.metroSetSetTabPage2.Style = MetroSet_UI.Enums.Style.Light;
			this.metroSetSetTabPage2.StyleManager = null;
			this.metroSetSetTabPage2.ThemeAuthor = "Narwin";
			this.metroSetSetTabPage2.ThemeName = "MetroLite";
			// 
			// metroSetSetTabPage3
			// 
			this.metroSetSetTabPage3.BaseColor = System.Drawing.Color.White;
			resources.ApplyResources(this.metroSetSetTabPage3, "metroSetSetTabPage3");
			this.metroSetSetTabPage3.IsDerivedStyle = true;
			this.metroSetSetTabPage3.Name = "metroSetSetTabPage3";
			this.metroSetSetTabPage3.Style = MetroSet_UI.Enums.Style.Light;
			this.metroSetSetTabPage3.StyleManager = null;
			this.metroSetSetTabPage3.ThemeAuthor = "Narwin";
			this.metroSetSetTabPage3.ThemeName = "MetroLite";
			// 
			// metroSetSetTabPage4
			// 
			this.metroSetSetTabPage4.BaseColor = System.Drawing.Color.White;
			resources.ApplyResources(this.metroSetSetTabPage4, "metroSetSetTabPage4");
			this.metroSetSetTabPage4.IsDerivedStyle = true;
			this.metroSetSetTabPage4.Name = "metroSetSetTabPage4";
			this.metroSetSetTabPage4.Style = MetroSet_UI.Enums.Style.Light;
			this.metroSetSetTabPage4.StyleManager = null;
			this.metroSetSetTabPage4.ThemeAuthor = "Narwin";
			this.metroSetSetTabPage4.ThemeName = "MetroLite";
			// 
			// metroSetSetTabPage5
			// 
			this.metroSetSetTabPage5.BaseColor = System.Drawing.Color.White;
			resources.ApplyResources(this.metroSetSetTabPage5, "metroSetSetTabPage5");
			this.metroSetSetTabPage5.IsDerivedStyle = true;
			this.metroSetSetTabPage5.Name = "metroSetSetTabPage5";
			this.metroSetSetTabPage5.Style = MetroSet_UI.Enums.Style.Light;
			this.metroSetSetTabPage5.StyleManager = null;
			this.metroSetSetTabPage5.ThemeAuthor = "Narwin";
			this.metroSetSetTabPage5.ThemeName = "MetroLite";
			// 
			// metroSetSetTabPage6
			// 
			this.metroSetSetTabPage6.BaseColor = System.Drawing.Color.White;
			resources.ApplyResources(this.metroSetSetTabPage6, "metroSetSetTabPage6");
			this.metroSetSetTabPage6.IsDerivedStyle = true;
			this.metroSetSetTabPage6.Name = "metroSetSetTabPage6";
			this.metroSetSetTabPage6.Style = MetroSet_UI.Enums.Style.Light;
			this.metroSetSetTabPage6.StyleManager = null;
			this.metroSetSetTabPage6.ThemeAuthor = "Narwin";
			this.metroSetSetTabPage6.ThemeName = "MetroLite";
			// 
			// FormPrincipal
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
			resources.ApplyResources(this, "$this");
			this.ControlBox = false;
			this.Controls.Add(this.panelForm);
			this.Name = "FormPrincipal";
			this.ShowIcon = false;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
			this.Load += new System.EventHandler(this.FormPrincipal_Load);
			this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
			this.panelLeftBar.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDot)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel16.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureUserFoto)).EndInit();
			this.panelContent.ResumeLayout(false);
			this.panelFormContent.ResumeLayout(false);
			this.pnlContent.ResumeLayout(false);
			this.panel19.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panelWelcome.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel8.ResumeLayout(false);
			this.panelSubMenu.ResumeLayout(false);
			this.panelFlowLay.ResumeLayout(false);
			this.panelFlowLay.PerformLayout();
			this.panel14.ResumeLayout(false);
			this.panelForm.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelLeftBar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel16;
		private System.Windows.Forms.Panel panelContent;
		private System.Windows.Forms.Panel panelSubMenu;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.Panel panel14;
		private System.Windows.Forms.Label lblSlideMenuTitle;
		private System.Windows.Forms.Panel panel19;
		private System.Windows.Forms.Label lblWelcomeText;
		private System.Windows.Forms.Timer timerSlideBar;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panelFormContent;
		private System.Windows.Forms.Panel panelForm;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panelWelcome;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel lineLeftBarDivider;
		private System.Windows.Forms.Timer timerUserIconAnimation;
		private System.Windows.Forms.Panel panel4;
		private Agenda.Controles.CircularPictureBox pictureUserFoto;
		private System.Windows.Forms.PictureBox pictureBoxDot;
		private MetroSet_UI.Controls.MetroSetEllipse btnLogout;
		private MetroSet_UI.Controls.MetroSetEllipse btnExtra;
		private MetroSet_UI.Controls.MetroSetEllipse btnCategories;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label lblTodayDate;
		private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
		private MetroSet_UI.Controls.MetroSetPanel pnlContent;
		private System.Windows.Forms.FlowLayoutPanel flowLaySlideMenu;
		private MetroSet_UI.Controls.MetroSetEllipse btnSlideAdd;
		private System.Windows.Forms.Panel panelFlowLay;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel lineSlideBar;
		private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage1;
		private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage2;
		private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage3;
		private MetroSet_UI.Controls.CustomTabControl mainContentTabControl;
		private MetroSet_UI.Controls.MetroSetEllipse btnCalendar;
		private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage4;
		private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage5;
		private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage6;
		private MetroSet_UI.Controls.MetroSetEllipse btnSearch;
		private MetroSet_UI.Controls.MetroSetEllipse btnNotifications;
	}
}

