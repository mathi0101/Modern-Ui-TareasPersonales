using ADODB;
using Agenda.Clases.Dominio.Persistencia.Adv.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.Clases.Dominio.Entidades {

	public class CTareaPersonal {

		#region Propiedades

		public int Codigo { get; set; }

		public int Id_categoria { get; set; }

		public string Usuario { get; set; }

		public string Texto { get; set; }

		public DateTime Fecha { get; set; }

		public bool Remarcar { get; set; }

		public bool Completa { get; set; }

		#endregion Propiedades

		#region Construcción

		public CTareaPersonal() => Inicializar();

		public void Inicializar() {
			Codigo = 0;
			Id_categoria = 0;
			Usuario = string.Empty;
			Texto = string.Empty;
			Fecha = DateTime.Now;
			Remarcar = false;
			Completa = false;
		}

		#endregion Construcción

		#region Persistencia

		public bool Agregar() => new PTareaPersonal().Agregar(this);

		public void Cargar(Recordset rs) => new PTareaPersonal().Cargar(this, rs);

		public bool Eliminar() => new PTareaPersonal().Eliminar(this);

		public bool Existe() => new PTareaPersonal().Existe(this);

		public bool Modificar() => new PTareaPersonal().Modificar(this);

		public bool Recuperar() => new PTareaPersonal().Recuperar(this);

		#endregion Persistencia

		#region Strings

		public override string ToString() => Codigo.ToString();

		#endregion Strings
	}
}