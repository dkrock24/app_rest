using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface ITIPOPRODUCTO
	{
		List<TIPOPRODUCTO> Listar();
		TIPOPRODUCTO Abase(aBase p);
		void Guardar(TIPOPRODUCTO obj);
		int GuardarById(TIPOPRODUCTO obj);
		void Eliminar(TIPOPRODUCTO obj);
		void Actualizar(TIPOPRODUCTO obj);
		TIPOPRODUCTO EntidadId(int id);
	}
}
