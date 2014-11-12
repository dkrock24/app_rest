using System;
using Datos;
namespace Core.Entidades
{
	[Map("INVENTARIOID","INVENTARIOID")]
	[Map("PRODUCTOID","PRODUCTOID")]
	[Map("FECHACREACION","FECHACREACION")]
	[Map("FECHAMOV","FECHAMOV")]
	[Map("CANTIDAD","CANTIDAD")]
	[Map("BODEGAID","BODEGAID")]
	[Map("TIPOMOV","TIPOMOV")]
	public class INVENTARIO:aBase
	{
		public int INVENTARIOID { get; set; }
		public string PRODUCTOID { get; set; }
		public DateTime FECHACREACION { get; set; }
		public DateTime FECHAMOV { get; set; }
		public decimal CANTIDAD { get; set; }
		public int BODEGAID { get; set; }
		public string TIPOMOV { get; set; }
	}
}
