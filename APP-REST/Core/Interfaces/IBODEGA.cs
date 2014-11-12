using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface IBODEGA
	{
		List<BODEGA> Listar();
		BODEGA Abase(aBase p);
		void Guardar(BODEGA obj);
		int GuardarById(BODEGA obj);
		void Eliminar(BODEGA obj);
		void Actualizar(BODEGA obj);
		BODEGA EntidadId(int id);
	}
}
