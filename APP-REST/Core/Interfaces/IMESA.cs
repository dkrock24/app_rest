using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface IMESA
	{
		List<MESA> Listar();
		MESA Abase(aBase p);
		void Guardar(MESA obj);
		int GuardarById(MESA obj);
		void Eliminar(MESA obj);
		void Actualizar(MESA obj);
		MESA EntidadId(int id);
	}
}
