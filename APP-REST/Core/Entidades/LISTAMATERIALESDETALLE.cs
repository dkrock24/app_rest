using System;
using Datos;
namespace Core.Entidades
{
	[Map("LISTAMATERIALESDETALLEID","LISTAMATERIALESDETALLEID")]
	[Map("LISTAMATERIALESID","LISTAMATERIALESID")]
	[Map("PRODUCTOID","PRODUCTOID")]
	[Map("CANTIDAD","CANTIDAD")]
	[Map("BODEGAID","BODEGAID")]
	[Map("LISTAPRECIOSID","LISTAPRECIOSID")]
	[Map("PRECIOUNITARIO","PRECIOUNITARIO")]
	[Map("COMENTARIO","COMENTARIO")]
	public class LISTAMATERIALESDETALLE:aBase
	{
		public int LISTAMATERIALESDETALLEID { get; set; }
		public int LISTAMATERIALESID { get; set; }
		public string PRODUCTOID { get; set; }
		public decimal CANTIDAD { get; set; }
		public int BODEGAID { get; set; }
		public int LISTAPRECIOSID { get; set; }
		public decimal PRECIOUNITARIO { get; set; }
		public string COMENTARIO { get; set; }
	}
}
