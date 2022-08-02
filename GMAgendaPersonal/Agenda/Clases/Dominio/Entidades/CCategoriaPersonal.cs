using ADODB;
using Agenda.Clases.Dominio.Persistencia.Adv.Entidades;
using Agenda.Clases.Dominio.Persistencia.Adv.Listas;
using Agenda.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.Clases.Dominio.Entidades {

	public class CCategoriaPersonal : IPersistenciaBD {

		#region Propiedades

		public int Codigo { get; set; }

		public string Usuario { get; set; }

		public string Nombre { get; set; }

		public int Maximo { get; set; }

		public List<CTareaPersonal> Tareas { get; set; }

		#endregion Propiedades

		#region Construcción

		public CCategoriaPersonal() => Inicializar();

		public void Inicializar() {
			Codigo = 0;
			Usuario = string.Empty;
			Nombre = string.Empty;
			Maximo = 0;
			Tareas = new List<CTareaPersonal>();
		}

		#endregion Construcción

		#region Persistencia

		public bool Agregar() => new PCategoriaPersonal().Agregar(this);

		public void Cargar(Recordset rs) => new PCategoriaPersonal().Cargar(this, rs);

		public bool Eliminar() => new PCategoriaPersonal().Eliminar(this);

		public bool Existe() => new PCategoriaPersonal().Existe(this);

		public bool ExisteLogico() => new PCategoriaPersonal().ExisteXNombreYUsuario(this);

		public bool Modificar() => new PCategoriaPersonal().Modificar(this);

		public bool Recuperar() => new PCategoriaPersonal().Recuperar(this);

		public bool RecuperarXNombreYUsuario() => new PCategoriaPersonal().RecuperarXNombreYUsuario(this);

		public void RecuperarTareas(DateTime desde, DateTime hasta) => Tareas = new LTareasPersonales().RecuperarPorCategoria(this, desde, hasta);

		public bool RecuperarLogico() => RecuperarXNombreYUsuario();

		#endregion Persistencia

		#region Strings

		public override string ToString() => Codigo.ToString();

		#endregion Strings
	}
}