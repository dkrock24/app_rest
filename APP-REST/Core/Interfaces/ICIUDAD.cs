using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface ICIUDAD
	{
		List<CIUDAD> Listar();
		CIUDAD Abase(aBase p);
		void Guardar(CIUDAD obj);
		int GuardarById(CIUDAD obj);
		void Eliminar(CIUDAD obj);
		void Actualizar(CIUDAD obj);
		CIUDAD EntidadId(int id);
	}
}
