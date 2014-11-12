using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface ILISTAMATERIALES
	{
		List<LISTAMATERIALES> Listar();
		LISTAMATERIALES Abase(aBase p);
		void Guardar(LISTAMATERIALES obj);
		int GuardarById(LISTAMATERIALES obj);
		void Eliminar(LISTAMATERIALES obj);
		void Actualizar(LISTAMATERIALES obj);
		LISTAMATERIALES EntidadId(int id);
	}
}
