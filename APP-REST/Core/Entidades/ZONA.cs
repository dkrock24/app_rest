using System;
using Datos;
namespace Core.Entidades
{
	[Map("ZONAID","ZONAID")]
	[Map("NOMBRE","NOMBRE")]
	[Map("DESCRIPCION","DESCRIPCION")]
	public class ZONA:aBase
	{
		public int ZONAID { get; set; }
		public string NOMBRE { get; set; }
		public string DESCRIPCION { get; set; }
	}
}
