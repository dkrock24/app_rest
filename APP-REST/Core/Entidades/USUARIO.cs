using System;
using Datos;
namespace Core.Entidades
{
	[Map("USUARIOID","USUARIOID")]
	[Map("NOMBRE","NOMBRE")]
	[Map("CLAVE","CLAVE")]
	[Map("ACTIVO","ACTIVO")]
	public class USUARIO:aBase
	{
		public int USUARIOID { get; set; }
		public string NOMBRE { get; set; }
		public string CLAVE { get; set; }
		public bool ACTIVO { get; set; }
	}
}
