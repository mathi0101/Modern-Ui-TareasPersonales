using ADODB;
using Agenda.Clases.Dominio.Entidades;
using Agenda.Clases.Dominio.Persistencia.Adv.Entidades;
using ConexionAdv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.Clases.Dominio.Persistencia.Adv.Listas {

	public class LCategoriasPersonales {

		#region Atributos

		private static Connection conexion = CConexion.Instancia().Conexion();

		#endregion Atributos

		#region Buscar

		public List<CCategoriaPersonal> BuscarCodigo(int codigo, List<CCategoriaPersonal> lista) => lista.Where(x => x.Codigo == codigo).ToList();

		public List<CCategoriaPersonal> BuscarNombre(string nombre, List<CCategoriaPersonal> lista) => lista.Where(x => x.Nombre.Trim() == nombre.Trim()).ToList();

		#endregion Buscar

		#region Recuperar

		public List<CCategoriaPersonal> RecuperarTodos() {
			PCategoriaPersonal pers = new PCategoriaPersonal();
			Command cmd = new Command {
				ActiveConnection = conexion,
				CommandText = "SELECT " + "\n" + pers.Campos() + "\n" +
							  "FROM " + "\n" + pers.Tabla() + "\n"
			};
			return cmd.ExecuteSelectList<CCategoriaPersonal>(pers.Cargar);
		}

		public List<CCategoriaPersonal> RecuperarTodosXUsuario(string usuario) {
			PCategoriaPersonal pers = new PCategoriaPersonal();
			Command cmd = new Command {
				ActiveConnection = conexion,
				CommandText = "SELECT " + "\n" + pers.Campos() + "\n" +
							  "FROM " + "\n" + pers.Tabla() + "\n" +
							  "WHERE " + "\n" + pers.CndUsuario(usuario) + "\n"
			};
			return cmd.ExecuteSelectList<CCategoriaPersonal>(pers.Cargar);
		}

		#endregion Recuperar
	}
}