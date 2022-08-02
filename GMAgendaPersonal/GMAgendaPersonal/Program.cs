using GMAgendaPersonal.Forms;
using Login;
using Permisos.Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GMAgendaPersonal {

	public static class Program {
		public const int ID_SISTEMA = 45;

		private const bool TESTING = true;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main(string[] args) {
			using (Mutex mutex = new Mutex(true, "GMAgendaPer", out bool newInstance)) {
				if (newInstance) {
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(true);

					FormPrincipal form = new FormPrincipal();
					FormLogin login = new FormLogin(ID_SISTEMA, form, args);
					if (Debugger.IsAttached && TESTING) {
						CPermiso.PermisoLogin().Usuario = new CUsuario("MATHIAS");
						//Form1 f = new Form1();
						Application.Run(form);
					} else {
						Application.Run(login);
					}
				} else {
					MessageBox.Show("La aplicación GMAgendaPersonal ya se encuentra abierta!");
				}
			}
		}
	}
}