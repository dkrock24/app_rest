using System;
using Datos;
namespace Core.Entidades
{
	[Map("BODEGAID","BODEGAID")]
	[Map("NOMBRE","NOMBRE")]
	[Map("UBICACION","UBICACION")]
	[Map("CAPACIDAD","CAPACIDAD")]
	[Map("ACTIVA","ACTIVA")]
	public class BODEGA:aBase
	{
		public int BODEGAID { get; set; }
		public string NOMBRE { get; set; }
		public string UBICACION { get; set; }
		public decimal CAPACIDAD { get; set; }
		public bool ACTIVA { get; set; }
	}
}
