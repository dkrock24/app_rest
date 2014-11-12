using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface ISOCIO
	{
		List<SOCIO> Listar();
		SOCIO Abase(aBase p);
		void Guardar(SOCIO obj);
		int GuardarById(SOCIO obj);
		void Eliminar(SOCIO obj);
		void Actualizar(SOCIO obj);
		SOCIO EntidadId(int id);
	}
}
