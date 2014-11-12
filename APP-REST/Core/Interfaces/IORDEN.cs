using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface IORDEN
	{
		List<ORDEN> Listar();
		ORDEN Abase(aBase p);
		void Guardar(ORDEN obj);
		int GuardarById(ORDEN obj);
		void Eliminar(ORDEN obj);
		void Actualizar(ORDEN obj);
		ORDEN EntidadId(int id);
	}
}
