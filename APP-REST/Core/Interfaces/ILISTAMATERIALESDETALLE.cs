using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface ILISTAMATERIALESDETALLE
	{
		List<LISTAMATERIALESDETALLE> Listar();
		LISTAMATERIALESDETALLE Abase(aBase p);
		void Guardar(LISTAMATERIALESDETALLE obj);
		int GuardarById(LISTAMATERIALESDETALLE obj);
		void Eliminar(LISTAMATERIALESDETALLE obj);
		void Actualizar(LISTAMATERIALESDETALLE obj);
		LISTAMATERIALESDETALLE EntidadId(int id);
	}
}
