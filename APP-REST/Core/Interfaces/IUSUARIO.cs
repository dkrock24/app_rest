using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface IUSUARIO
	{
		List<USUARIO> Listar();
		USUARIO Abase(aBase p);
		void Guardar(USUARIO obj);
		int GuardarById(USUARIO obj);
		void Eliminar(USUARIO obj);
		void Actualizar(USUARIO obj);
		USUARIO EntidadId(int id);
	}
}
