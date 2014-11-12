using System;
using Datos;
namespace Core.Entidades
{
	[Map("MESAID","MESAID")]
	[Map("NUMERO","NUMERO")]
	[Map("NOMBRE","NOMBRE")]
	[Map("CAPACIDAD","CAPACIDAD")]
	[Map("ZONAID","ZONAID")]
	[Map("ACTIVO","ACTIVO")]
	public class MESA:aBase
	{
		public int MESAID { get; set; }
		public int NUMERO { get; set; }
		public string NOMBRE { get; set; }
		public int CAPACIDAD { get; set; }
		public int ZONAID { get; set; }
		public bool ACTIVO { get; set; }
	}
}
