using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface ILISTAPRECIOS
	{
		List<LISTAPRECIOS> Listar();
		LISTAPRECIOS Abase(aBase p);
		void Guardar(LISTAPRECIOS obj);
		int GuardarById(LISTAPRECIOS obj);
		void Eliminar(LISTAPRECIOS obj);
		void Actualizar(LISTAPRECIOS obj);
		LISTAPRECIOS EntidadId(int id);
	}
}
