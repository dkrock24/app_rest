using System;
using Datos;
namespace Core.Entidades
{
	[Map("LISTAPRECIOSID","LISTAPRECIOSID")]
	[Map("NOMBRE","NOMBRE")]
	[Map("FACTOR","FACTOR")]
	[Map("REDONDEO","REDONDEO")]
	[Map("ACTIVA","ACTIVA")]
	public class LISTAPRECIOS:aBase
	{
		public int LISTAPRECIOSID { get; set; }
		public string NOMBRE { get; set; }
		public int FACTOR { get; set; }
		public string REDONDEO { get; set; }
		public bool ACTIVA { get; set; }
	}
}
