using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface IPRODUCTO
	{
		List<PRODUCTO> Listar();
		PRODUCTO Abase(aBase p);
		void Guardar(PRODUCTO obj);
		int GuardarById(PRODUCTO obj);
		void Eliminar(PRODUCTO obj);
		void Actualizar(PRODUCTO obj);
		PRODUCTO EntidadId(int id);
	}
}
