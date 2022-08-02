using ADODB;
using Agenda.Clases.Dominio.Entidades;
using Agenda.Clases.Dominio.Persistencia.Adv.Entidades;
using ConexionAdv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.Clases.Dominio.Persistencia.Adv.Listas {

	public class LTareasPersonales {

		#region Atributos

		private static Connection conexion = CConexion.Instancia().Conexion();

		#endregion Atributos

		#region Buscar

		public List<CTareaPersonal> BuscarCodigo(int codigo, List<CTareaPersonal> lista) => lista.Where(x => x.Codigo == codigo).ToList();

		#endregion Buscar

		#region Recuperar

		public List<CTareaPersonal> RecuperarTodos() {
			PTareaPersonal pers = new PTareaPersonal();
			Command cmd = new Command {
				ActiveConnection = conexion,
				CommandText = "SELECT " + "\n" + pers.Campos() + "\n" +
							  "FROM " + "\n" + pers.Tabla() + "\n"
			};
			return cmd.ExecuteSelectList<CTareaPersonal>(pers.Cargar);
		}

		public List<CTareaPersonal> RecuperarPorCategoria(CCategoriaPersonal cat, DateTime desde, DateTime hasta) {
			PTareaPersonal pers = new PTareaPersonal();
			PCategoriaPersonal persCat = new PCategoriaPersonal();
			Command cmd = new Command {
				ActiveConnection = conexion,
				CommandText = "SELECT " + "\n" + pers.Campos() + "\n" +
							  "FROM " + "\n" + pers.Tablas() + "\n" +
							  "WHERE " + "\n" + persCat.Condicion(cat)
			};
			return cmd.ExecuteSelectList<CTareaPersonal>(pers.Cargar);
		}

		#endregion Recuperar
	}
}