using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface IORDENDETALLE
	{
		List<ORDENDETALLE> Listar();
		ORDENDETALLE Abase(aBase p);
		void Guardar(ORDENDETALLE obj);
		int GuardarById(ORDENDETALLE obj);
		void Eliminar(ORDENDETALLE obj);
		void Actualizar(ORDENDETALLE obj);
		ORDENDETALLE EntidadId(int id);
	}
}
