using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface IUSUARIO_ROL
	{
		List<USUARIO_ROL> Listar();
		USUARIO_ROL Abase(aBase p);
		void Guardar(USUARIO_ROL obj);
		int GuardarById(USUARIO_ROL obj);
		void Eliminar(USUARIO_ROL obj);
		void Actualizar(USUARIO_ROL obj);
		USUARIO_ROL EntidadId(int id);
	}
}
