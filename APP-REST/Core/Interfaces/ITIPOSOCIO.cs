using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface ITIPOSOCIO
	{
		List<TIPOSOCIO> Listar();
		TIPOSOCIO Abase(aBase p);
		void Guardar(TIPOSOCIO obj);
		int GuardarById(TIPOSOCIO obj);
		void Eliminar(TIPOSOCIO obj);
		void Actualizar(TIPOSOCIO obj);
		TIPOSOCIO EntidadId(int id);
	}
}
