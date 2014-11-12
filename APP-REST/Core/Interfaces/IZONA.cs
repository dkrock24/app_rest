using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface IZONA
	{
		List<ZONA> Listar();
		ZONA Abase(aBase p);
		void Guardar(ZONA obj);
		int GuardarById(ZONA obj);
		void Eliminar(ZONA obj);
		void Actualizar(ZONA obj);
		ZONA EntidadId(int id);
	}
}
