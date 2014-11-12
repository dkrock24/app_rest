using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface ICARGO
	{
		List<CARGO> Listar();
		CARGO Abase(aBase p);
		void Guardar(CARGO obj);
		int GuardarById(CARGO obj);
		void Eliminar(CARGO obj);
		void Actualizar(CARGO obj);
		CARGO EntidadId(int id);
	}
}
