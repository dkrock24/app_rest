using System;
using Datos;
namespace Core.Entidades
{
	[Map("LISTAPRECIOSDETALLEID","LISTAPRECIOSDETALLEID")]
	[Map("LISTAPRECIOSID","LISTAPRECIOSID")]
	[Map("PRODUCTOID","PRODUCTOID")]
	[Map("PRECIOBASE","PRECIOBASE")]
	[Map("FACTOR","FACTOR")]
	[Map("PRECIOUNITARIO","PRECIOUNITARIO")]
	public class LISTAPRECIOSDETALLE:aBase
	{
		public int LISTAPRECIOSDETALLEID { get; set; }
		public int LISTAPRECIOSID { get; set; }
		public string PRODUCTOID { get; set; }
		public decimal PRECIOBASE { get; set; }
		public decimal FACTOR { get; set; }
		public decimal PRECIOUNITARIO { get; set; }
	}
}
