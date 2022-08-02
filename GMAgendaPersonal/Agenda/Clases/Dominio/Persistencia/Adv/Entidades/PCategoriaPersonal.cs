using ADODB;
using Agenda.Clases.Dominio.Entidades;
using ConexionAdv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.Clases.Dominio.Persistencia.Adv.Entidades {

	public class PCategoriaPersonal {

		#region Atributos

		private static Connection conexion = CConexion.Instancia().Conexion();

		#endregion Atributos

		#region Campos

		public string CmpExiste() => " Ageper_Categorias.id_categoria AS Ageper_CategoriasId_categoria ";

		public string Campos() =>
			" Ageper_Categorias.id_categoria AS Ageper_CategoriasId_categoria," +
			" Ageper_Categorias.usuario AS Ageper_CategoriasUsuario," +
			" Ageper_Categorias.nombre AS Ageper_CategoriasNombre," +
			" Ageper_Categorias.maximo AS Ageper_CategoriasMaximo ";

		#endregion Campos

		#region Cargar

		public void Cargar(CCategoriaPersonal obj, Recordset rs) {
			obj.Inicializar();

			obj.Codigo = rs.GetInt("Ageper_CategoriasId_categoria");
			obj.Usuario = rs.GetString("Ageper_CategoriasUsuario");
			obj.Nombre = rs.GetString("Ageper_CategoriasNombre");
			obj.Maximo = rs.GetInt("Ageper_CategoriasMaximo");
		}

		#endregion Cargar

		#region Recuperar

		public bool Existe(CCategoriaPersonal obj) {
			Command cmd = new Command {
				ActiveConnection = conexion,
				CommandText = "SELECT " + "\n" + CmpExiste() + "\n" +
							  "FROM " + "\n" + Tabla() + "\n" +
							  "WHERE " + Condicion(obj)
			};
			return cmd.ExecuteExist();
		}

		public bool ExisteXNombreYUsuario(CCategoriaPersonal obj) {
			Command cmd = new Command {
				ActiveConnection = conexion,
				CommandText = "SELECT " + "\n" + CmpExiste() + "\n" +
							  "FROM " + "\n" + Tabla() + "\n" +
							  "WHERE " + CndNombre(obj) + " AND " + CndUsuario(obj.Usuario)
			};
			return cmd.ExecuteExist();
		}

		public bool Recuperar(CCategoriaPersonal obj) {
			Command cmd = new Command {
				ActiveConnection = conexion,
				CommandText = "SELECT " + "\n" + Campos() + "\n" +
							  "FROM " + "\n" + Tabla() + "\n" +
							  "WHERE " + Condicion(obj)
			};
			return cmd.ExecuteSelect(obj, Cargar);
		}

		public bool RecuperarXNombreYUsuario(CCategoriaPersonal obj) {
			Command cmd = new Command {
				ActiveConnection = conexion,
				CommandText = "SELECT " + "\n" + Campos() + "\n" +
							  "FROM " + "\n" + Tabla() + "\n" +
							  "WHERE " + CndNombre(obj) + " AND " + CndUsuario(obj.Usuario)
			};
			return cmd.ExecuteSelect(obj, Cargar);
		}

		#endregion Recuperar

		#region Condiciones

		public string Condicion(CCategoriaPersonal obj) => " Ageper_Categorias.id_categoria = " + obj.Codigo + " ";

		public string CndUsuario(string usuario) => " Ageper_Categorias.usuario = " + usuario.InsertStringInSQL() + " ";

		private string CndNombre(CCategoriaPersonal obj) => " Ageper_Categorias.nombre = " + obj.Nombre.InsertStringInSQL() + " ";

		#endregion Condiciones

		#region DML

		public bool Agregar(CCategoriaPersonal obj) {
			Command cmd = new Command {
				ActiveConnection = conexion,
				CommandText = "INSERT INTO " + "\n" + Tabla() + "\n" +
							  "(" + AgregarVariables() + ")" + "\n" +
							  " VALUES " + "\n" +
							  "(" + AgregarValores(obj) + ")"
			};
			return cmd.ExecuteNonQuery();
		}

		public bool Eliminar(CCategoriaPersonal obj) {
			Command cmd = new Command {
				ActiveConnection = conexion,
				CommandText = "DELETE FROM " + "\n" + Tabla() + "\n" +
							  "WHERE " + Condicion(obj)
			};
			return cmd.ExecuteNonQuery();
		}

		public bool Modificar(CCategoriaPersonal obj) {
			Command cmd = new Command {
				ActiveConnection = conexion,
				CommandText = "UPDATE " + "\n" + Tabla() + "\n" +
							  "SET " + "\n" + ModificarValores(obj) + "\n" +
							  "WHERE " + Condicion(obj)
			};
			return cmd.ExecuteNonQuery();
		}

		#endregion DML

		#region Edición

		public string AgregarValores(CCategoriaPersonal obj) =>
			obj.Codigo + ", " +
			obj.Usuario.InsertStringInSQL() + ", " +
			obj.Nombre.InsertStringInSQL() + ", " +
			obj.Maximo;

		public string AgregarVariables() =>
			"id_categoria, " +
			"usuario, " +
			"nombre, " +
			"maximo ";

		public string ModificarValores(CCategoriaPersonal obj) =>
		   "id_categoria = " + obj.Codigo + ", " +
		   "usuario = " + obj.Usuario.InsertStringInSQL() + ", " +
		   "nombre = " + obj.Nombre.InsertStringInSQL() + ", " +
		   "maximo = " + obj.Maximo;

		#endregion Edición

		#region Orden

		public string Orden() => " Ageper_Categorias.id_categoria ";

		#endregion Orden

		#region Tablas

		public string Tabla() => " Ageper_Categorias ";

		#endregion Tablas
	}
}