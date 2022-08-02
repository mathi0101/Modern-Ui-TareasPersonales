using ADODB;
using Agenda.Clases.Dominio.Entidades;
using ConexionAdv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.Clases.Dominio.Persistencia.Adv.Entidades {

	public class PTareaPersonal {

		#region Atributos

		private static Connection conexion = CConexion.Instancia().Conexion();

		#endregion Atributos

		#region Campos

		public string CmpExiste() => " Ageper_Tareas.id_tarea AS Ageper_TareasId_tarea ";

		public string Campos() =>
			" Ageper_Tareas.id_tarea AS Ageper_TareasId_tarea," +
			" Ageper_Tareas.id_categoria AS Ageper_TareasId_categoria," +
			" Ageper_Tareas.usuario AS Ageper_TareasUsuario," +
			" Ageper_Tareas.texto AS Ageper_TareasTexto," +
			" Ageper_Tareas.fecha AS Ageper_TareasFecha," +
			" Ageper_Tareas.remarcar AS Ageper_TareasRemarcar," +
			" Ageper_Tareas.completa AS Ageper_TareasCompleta ";

		#endregion Campos

		#region Cargar

		public void Cargar(CTareaPersonal obj, Recordset rs) {
			obj.Inicializar();

			obj.Codigo = rs.GetInt("Ageper_TareasId_tarea");
			obj.Id_categoria = rs.GetInt("Ageper_TareasId_categoria");
			obj.Usuario = rs.GetString("Ageper_TareasUsuario");
			obj.Texto = rs.GetString("Ageper_TareasTexto");
			obj.Fecha = rs.GetDateTime("Ageper_TareasFecha");
			obj.Remarcar = rs.GetBoolean("Ageper_TareasRemarcar");
			obj.Completa = rs.GetBoolean("Ageper_TareasCompleta");
		}

		#endregion Cargar

		#region Recuperar

		public bool Existe(CTareaPersonal obj) {
			Command cmd = new Command {
				ActiveConnection = conexion,
				CommandText = "SELECT " + "\n" + CmpExiste() + "\n" +
							  "FROM " + "\n" + Tabla() + "\n" +
							  "WHERE " + Condicion(obj)
			};
			return cmd.ExecuteExist();
		}

		public bool Recuperar(CTareaPersonal obj) {
			Command cmd = new Command {
				ActiveConnection = conexion,
				CommandText = "SELECT " + "\n" + Campos() + "\n" +
							  "FROM " + "\n" + Tabla() + "\n" +
							  "WHERE " + Condicion(obj)
			};
			return cmd.ExecuteSelect(obj, Cargar);
		}

		#endregion Recuperar

		#region Condiciones

		public string Condicion(CTareaPersonal obj) => " Ageper_Tareas.id_tarea = " + obj.Codigo + " ";

		#endregion Condiciones

		#region DML

		public bool Agregar(CTareaPersonal obj) {
			Command cmd = new Command {
				ActiveConnection = conexion,
				CommandText = "INSERT INTO " + "\n" + Tabla() + "\n" +
							  "(" + AgregarVariables() + ")" + "\n" +
							  " VALUES " + "\n" +
							  "(" + AgregarValores(obj) + ")"
			};
			return cmd.ExecuteNonQuery();
		}

		public bool Eliminar(CTareaPersonal obj) {
			Command cmd = new Command {
				ActiveConnection = conexion,
				CommandText = "DELETE FROM " + "\n" + Tabla() + "\n" +
							  "WHERE " + Condicion(obj)
			};
			return cmd.ExecuteNonQuery();
		}

		public bool Modificar(CTareaPersonal obj) {
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

		public string AgregarValores(CTareaPersonal obj) =>
			obj.Codigo + ", " +
			obj.Id_categoria + ", " +
			obj.Usuario.InsertStringInSQL() + ", " +
			obj.Texto.InsertStringInSQL() + ", " +
			obj.Fecha.InsertDateTimeInSQL() + ", " +
			obj.Remarcar.InsertNumberOrBooleanInSQL() + ", " +
			obj.Completa.InsertNumberOrBooleanInSQL();

		public string AgregarVariables() =>
			"id_tarea, " +
			"id_categoria, " +
			"usuario, " +
			"texto, " +
			"fecha, " +
			"remarcar, " +
			"completa ";

		public string ModificarValores(CTareaPersonal obj) =>
		   "id_tarea = " + obj.Codigo + ", " +
		   "id_categoria = " + obj.Id_categoria + ", " +
		   "usuario = " + obj.Usuario.InsertStringInSQL() + ", " +
		   "texto = " + obj.Texto.InsertStringInSQL() + ", " +
		   "fecha = " + obj.Fecha.InsertDateTimeInSQL() + ", " +
		   "remarcar = " + obj.Remarcar.InsertNumberOrBooleanInSQL() + ", " +
		   "completa = " + obj.Completa.InsertNumberOrBooleanInSQL();

		#endregion Edición

		#region Orden

		public string Orden() => " Ageper_Tareas.id_tarea ";

		#endregion Orden

		#region Tablas

		public string Tabla() => " Ageper_Tareas ";

		public string Tablas() {
			PCategoriaPersonal pers = new PCategoriaPersonal();
			return Tabla() + " " + " LEFT OUTER JOIN " + pers.Tabla() + $" ON (Ageper_Tareas.id_categoria = Ageper_Categorias.id_categoria) ";
		}

		#endregion Tablas
	}
}