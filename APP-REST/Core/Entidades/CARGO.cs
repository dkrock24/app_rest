using System;
using Datos;
namespace Core.Entidades
{
	[Map("CARGOID","CARGOID")]
	[Map("NOMBRE","NOMBRE")]
	public class CARGO:aBase
	{
		public int CARGOID { get; set; }
		public string NOMBRE { get; set; }
	}
}
