using System;
using Datos;
namespace Core.Entidades
{
	[Map("LISTAMATERIALESID","LISTAMATERIALESID")]
	[Map("PRODUCTOID","PRODUCTOID")]
	[Map("CANTIDAD","CANTIDAD")]
	[Map("BODEGAID","BODEGAID")]
	[Map("LISTAPRECIOSID","LISTAPRECIOSID")]
	[Map("PROYECTO","PROYECTO")]
	[Map("PRECIOPRODUCTO","PRECIOPRODUCTO")]
	public class LISTAMATERIALES:aBase
	{
		public int LISTAMATERIALESID { get; set; }
		public string PRODUCTOID { get; set; }
		public int CANTIDAD { get; set; }
		public int BODEGAID { get; set; }
		public int LISTAPRECIOSID { get; set; }
		public string PROYECTO { get; set; }
		public decimal PRECIOPRODUCTO { get; set; }
	}
}
