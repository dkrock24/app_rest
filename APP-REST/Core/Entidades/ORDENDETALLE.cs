using System;
using Datos;
namespace Core.Entidades
{
	[Map("ORDENDETALLEID","ORDENDETALLEID")]
	[Map("ORDENID","ORDENID")]
	[Map("PRODUCTOID","PRODUCTOID")]
	[Map("PRECIOUNITARIO","PRECIOUNITARIO")]
	[Map("DESCUENTO","DESCUENTO")]
	public class ORDENDETALLE:aBase
	{
		public int ORDENDETALLEID { get; set; }
		public int ORDENID { get; set; }
		public string PRODUCTOID { get; set; }
		public decimal PRECIOUNITARIO { get; set; }
		public decimal DESCUENTO { get; set; }
	}
}
