using Agenda.Clases.Dominio.Entidades;
using Agenda.Clases.Dominio.Persistencia.Adv.Listas;
using Agenda.Constantes;
using Agenda.Controles;
using ConexionAdv;
using Funcionario.Dominio;
using GMAgendaPersonal.Clases;
using GMAgendaPersonal.Properties;
using MetroSet_UI.Controls;
using MetroSet_UI.Forms;
using Permisos.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static MetroSet_UI.Native.User32;

namespace GMAgendaPersonal.Forms {

	[ToolboxItem(false)]
	[ToolboxBitmap(typeof(Form), "Bitmaps.Form.bmp")]
	[DesignerCategory("Form")]
	[DefaultEvent("Load")]
	[DesignTimeVisible(false)]
	[ComVisible(true)]
	[InitializationEvent("Load")]
	public partial class FormPrincipal : Form {

		#region Atributos

		private CUsuario _loggedUser;
		private CFuncionario _Funciuser;
		private List<CCategoriaPersonal> categorias;

		private bool iconAnimation2Clockwise = true;

		private SlideMenuController slideMenuController;

		private DateTime Now = DateTime.Now;

		#endregion Atributos

		#region Constructor

		public FormPrincipal() {
			CConexion.Instancia().Conectar();

			Inicializar();
		}

		private void Inicializar() {
			InitializeComponent();
			slideMenuController = new SlideMenuController(timerSlideBar, pictureBoxDot, this, panelSubMenu, flowLaySlideMenu, lblSlideMenuTitle, btnSlideAdd);

			// Theme Colors
			Colors.PrimaryColor = Color.RoyalBlue;
			Colors.SecondaryColor = Color.Coral;

			this.BackColor = Colors.BG1;
			this.FormBorderStyle = FormBorderStyle.None;
			var wrokArea = Screen.FromHandle(this.Handle).WorkingArea;
			this.MaximizedBounds = new Rectangle(-8, -9, wrokArea.Width + 18, wrokArea.Height + 17);

			panelSubMenu.BackColor = Colors.BG2;
			panelSubMenu.Size = panelSubMenu.MinimumSize;
			panelLeftBar.BackColor = Colors.BG3;

			lblWelcomeText.Font = Fonts.Title2;
			lblWelcomeText.ForeColor = Color.White;
			lblTodayDate.Font = Fonts.Title2;
			lblTodayDate.ForeColor = Colors.Gray1;

			lineLeftBarDivider.BackColor = Colors.PrimaryColor;
			lineSlideBar.BackColor = Colors.SecondaryColor;

			// Content Tab Control
			mainContentTabControl.BackgroundColor = Colors.BG1;
			mainContentTabControl.ForegroundColor = Colors.PrimaryColor;
			var imgList = new ImageList();
			imgList.Images.Add(Resources.plus_filled);
			imgList.Images.Add(Resources.calendar);
			imgList.Images.Add(Resources.waving_hand);
			mainContentTabControl.ImageList = imgList;

			mainContentTabControl.TabPages.Add(new TabPage("TEST") { BackColor = Colors.BG1, ImageIndex = 0 });
			mainContentTabControl.TabPages.Add(new TabPage("HOLA") { BackColor = Colors.BG1, ImageIndex = 1 });

			mainContentTabControl.TabPages.Add(new TabPage("FEDE") { BackColor = Colors.BG1, ImageIndex = 2 });
		}

		#endregion Constructor

		#region Formulario

		private void FormPrincipal_Load(object sender, EventArgs e) {
			LoadForm();

			AnimateWindow(Handle, 800, (int)(AnimateWindowFlags.AW_ACTIVATE | AnimateWindowFlags.AW_BLEND));

			slideMenuController.CargarPresets(CargarCategorias(categorias), true);
			SetearFotoXCodigoFunc(_Funciuser.Codigo);
			FormBorderStyle = FormBorderStyle.Sizable;
		}

		private void FormPrincipal_Shown(object sender, EventArgs e) {
			Application.DoEvents();
		}

		private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
			var r = FullScreenMessageBox.Show(this, "¿Desea salir?", "A T E N C I Ó N !", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
			if (r != DialogResult.Yes) {
				e.Cancel = true;
				return;
			}
		}

		private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
			notifyIcon.Visible = false;
			notifyIcon.Dispose();
			FormBorderStyle = FormBorderStyle.None;
			AnimateWindow(Handle, 800, (int)(AnimateWindowFlags.AW_HIDE | AnimateWindowFlags.AW_BLEND));
			CConexion.Instancia().Desconectar();
			Application.Exit();
		}

		#endregion Formulario

		#region Eventos

		#region User32.dll

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlags);

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();

		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int Iparam);

		private void FormTopBar_MouseDown(object sender, MouseEventArgs e) {
			UserInteraction(null, null);
			if (e.Button == MouseButtons.Left) {
				if (e.Clicks == 1) {
					ReleaseCapture();
					SendMessage(Handle, 0xA1, 0x2, 0);
					//if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
				} else {
					this.WindowState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
				}
			}
		}

		#region Minimize From TaskBar

		protected override CreateParams CreateParams {
			get {
				CreateParams cp = base.CreateParams;
				cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
				return cp;
			}
		}

		#endregion Minimize From TaskBar

		#endregion User32.dll

		#region Left Sidebar Button

		#region Clicks

		private void btnCategories_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				slideMenuController.ToggleMenu(1, (MetroSetEllipse)sender);
			}
		}

		private void btnExtra_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				slideMenuController.ToggleMenu(2, (MetroSetEllipse)sender);
			}
		}

		private void btnLogout_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				if (FullScreenMessageBox.Show(this, "Deseas cerrar sesión y volver a la pantalla de login?", "¿ C E R R A R  S E S I Ó N ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK) {
					AnimateWindow(Handle, 800, (int)(AnimateWindowFlags.AW_HIDE | AnimateWindowFlags.AW_BLEND));
					slideMenuController.Dispose();
					notifyIcon.Visible = false;
					notifyIcon.Dispose();
					this.Dispose();
					Application.Restart();
				}
			}
		}

		#endregion Clicks

		#endregion Left Sidebar Button

		#region User Interacts

		private void UserInteraction(object sender, MouseEventArgs e) {
			var rn = DateTime.Now;
			if (Now.Day != rn.Day) {
				Now = rn;
				lblTodayDate.Text = rn.ToString("d MMMM yyyy");
				CambiarMensajeBienvenida();
			}
			Now = rn;
			slideMenuController.UserInteraction_MouseClick(null, null);
		}

		#endregion User Interacts

		#region Timers

		private void timerUserIconAnimation_Tick(object sender, EventArgs e) {
			Application.DoEvents();
			var increment = 8;
			var r = new Random();
			if (iconAnimation2Clockwise) {
				if (pictureUserFoto.GradientAngle >= 360) {
					Colors.PrimaryColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
					iconAnimation2Clockwise = false;

					pictureUserFoto.BorderColor = Colors.PrimaryColor;
					lineLeftBarDivider.BackColor = Colors.PrimaryColor;
					mainContentTabControl.ForegroundColor = Colors.PrimaryColor;
					mainContentTabControl.Refresh();
				} else {
					pictureUserFoto.GradientAngle += increment;
				}
			} else {
				if (pictureUserFoto.GradientAngle <= 15) {
					Colors.SecondaryColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
					iconAnimation2Clockwise = true;

					pictureUserFoto.BorderColor2 = Colors.SecondaryColor;
					lineSlideBar.BackColor = Colors.SecondaryColor;
				} else {
					pictureUserFoto.GradientAngle -= increment;
				}
			}
		}

		#endregion Timers

		#endregion Eventos

		#region Privadas

		#region Load Form

		private void LoadForm() {
			Recuperar();
			timerUserIconAnimation.Start();

			UserInteraction(null, null);
			lblTodayDate.Text = Now.ToString("d MMMM yyyy");
			CambiarMensajeBienvenida();
		}

		private void Recuperar() {
			_loggedUser = CPermiso.PermisoLogin().Usuario;
			_Funciuser = new CFuncionario() { Codigo = _loggedUser.BuscarNroFuncionario() };
			_Funciuser.Recuperar();

			categorias = new LCategoriasPersonales().RecuperarTodosXUsuario(_loggedUser.Nombre);
			var mes1 = DateTime.Now.AddMonths(-1);
			var mes2 = DateTime.Now.AddMonths(1);
			foreach (var cat in categorias) {
				cat.RecuperarTareas(mes1, mes2);
			}
		}

		#endregion Load Form

		#region get UserFoto

		private void SetearFotoXCodigoFunc(int codigo_func) {
			string url = "http://192.168.1.7/ffunci/business/FileContent.php?file=" + codigo_func + ".jpg";

			try {
				WebClient webClient = new WebClient();
				MemoryStream objImage = new MemoryStream(webClient.DownloadData(url));
				var img = Image.FromStream(objImage);
				pictureUserFoto.Image = img;
			} catch {
				pictureUserFoto.Image = Properties.Resources.default_user;
			}
		}

		#endregion get UserFoto

		#region Cargar Menus

		#region Categorias 1

		private MenuPreset[] CargarCategorias(List<CCategoriaPersonal> categorias) {
			List<MenuControl> controles = new List<MenuControl>();
			foreach (var cat in categorias) {
				var menus = new ButtonBadgeStruct[] { new ButtonBadgeStruct("Todas", cat.Tareas.Count.ToString()) };
				int porHacer = cat.Tareas.Where(x => x.Fecha >= DateTime.Now).Count();
				int enProgreso = cat.Tareas.Where(x => !x.Completa).Count();
				int finalizadas = cat.Tareas.Where(x => x.Completa).Count();
				if (porHacer > 0) {
					menus = menus.Append(new ButtonBadgeStruct("Por Hacer", porHacer.ToString())).ToArray();
				}
				if (enProgreso > 0) {
					menus = menus.Append(new ButtonBadgeStruct("En Progreso", enProgreso.ToString())).ToArray();
				}
				if (finalizadas > 0) {
					menus = menus.Append(new ButtonBadgeStruct("Finalizadas", finalizadas.ToString())).ToArray();
				}
				controles.Add(new MenuControl(cat.Nombre, menus) { Pers = cat });
			}
			var preset = new MenuPreset(1, "Categorías") { NewItemsPersistencia = agregarCategoria };
			preset.CargarMenus(controles);
			return new MenuPreset[] { preset };

			CCategoriaPersonal agregarCategoria() {
				CCategoriaPersonal cat = new CCategoriaPersonal() {
					Usuario = _loggedUser.Nombre
				};

				return cat;
			}
		}

		#endregion Categorias 1

		#endregion Cargar Menus

		#region MSG Bienvenida

		private void CambiarMensajeBienvenida() {
			string genero = _Funciuser.Sexo == "M" ? "o" : "a";
			string[] mensajes = new string[] {
				$"Bienvenid{genero} de vuelta",
				"Hola de nuevo",
				Now.Hour < 12 ? "Buenos días" : (Now.Hour < 19 ? "Buenas tardes" : "Buenas noches"),
				"Aquí tienes tus tareas",
				$"Hoy es {Capitalize(Now.ToString("dddd"))}",
			};
			lblWelcomeText.Text = mensajes[new Random().Next(mensajes.Count())] + $", {Obtener1erNombre(_Funciuser.Nombres)} !";
		}

		private string Obtener1erNombre(string nombres) {
			nombres = nombres.ToLower();
			if (nombres.Contains(" ")) {
				var x = nombres.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				return Capitalize(x[0]);
			} else {
				return Capitalize(nombres.Trim());
			}
		}

		#endregion MSG Bienvenida

		#endregion Privadas

		#region Estaticas

		public static string Capitalize(string text) {
			TextInfo t = Thread.CurrentThread.CurrentCulture.TextInfo;

			return t.ToTitleCase(text);
		}

		#endregion Estaticas

		private void metroSetEllipse2_Click(object sender, EventArgs e) {
		}

		private void metroSetEllipse1_Click(object sender, EventArgs e) {
		}

		private void metroSetEllipse2_MouseEnter(object sender, EventArgs e) {
			//if (sender is MetroSetEllipse b) {
			//	b.Cursor = Cursors.Hand;
			//	var s = b.ImageSize;
			//	b.ImageSize = new Size(s.Width + 3, s.Height + 3);
			//}
		}

		private void metroSetEllipse2_MouseLeave(object sender, EventArgs e) {
			//if (sender is MetroSetEllipse b) {
			//	b.Cursor = Cursors.Default;
			//	var s = b.ImageSize;
			//	b.ImageSize = new Size(s.Width - 3, s.Height - 3);
			//}
		}
	}
}