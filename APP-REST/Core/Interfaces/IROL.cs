using System.Collections.Generic;
using Core.Entidades;
using Datos;
namespace Core.Interfaces
{
	public interface IROL
	{
		List<ROL> Listar();
		ROL Abase(aBase p);
		void Guardar(ROL obj);
		int GuardarById(ROL obj);
		void Eliminar(ROL obj);
		void Actualizar(ROL obj);
		ROL EntidadId(int id);
	}
}
