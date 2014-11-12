using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface ILISTAPRECIOSDETALLE
	{
		List<LISTAPRECIOSDETALLE> Listar();
		LISTAPRECIOSDETALLE Abase(aBase p);
		void Guardar(LISTAPRECIOSDETALLE obj);
		int GuardarById(LISTAPRECIOSDETALLE obj);
		void Eliminar(LISTAPRECIOSDETALLE obj);
		void Actualizar(LISTAPRECIOSDETALLE obj);
		LISTAPRECIOSDETALLE EntidadId(int id);
	}
}
