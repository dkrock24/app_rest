using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface IEMPLEADO
	{
		List<EMPLEADO> Listar();
		EMPLEADO Abase(aBase p);
		void Guardar(EMPLEADO obj);
		int GuardarById(EMPLEADO obj);
		void Eliminar(EMPLEADO obj);
		void Actualizar(EMPLEADO obj);
		EMPLEADO EntidadId(int id);
	}
}
