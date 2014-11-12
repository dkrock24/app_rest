using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface IMEDIDAPRODUCTO
	{
		List<MEDIDAPRODUCTO> Listar();
		MEDIDAPRODUCTO Abase(aBase p);
		void Guardar(MEDIDAPRODUCTO obj);
		int GuardarById(MEDIDAPRODUCTO obj);
		void Eliminar(MEDIDAPRODUCTO obj);
		void Actualizar(MEDIDAPRODUCTO obj);
		MEDIDAPRODUCTO EntidadId(int id);
	}
}
