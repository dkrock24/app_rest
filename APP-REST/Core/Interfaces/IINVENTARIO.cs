using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface IINVENTARIO
	{
		List<INVENTARIO> Listar();
		INVENTARIO Abase(aBase p);
		void Guardar(INVENTARIO obj);
		int GuardarById(INVENTARIO obj);
		void Eliminar(INVENTARIO obj);
		void Actualizar(INVENTARIO obj);
		INVENTARIO EntidadId(int id);
	}
}
