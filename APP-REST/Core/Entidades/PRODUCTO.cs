using System;
using Datos;
namespace Core.Entidades
{
	[Map("PRODUCTOID","PRODUCTOID")]
	[Map("NOMBRE","NOMBRE")]
	[Map("TAMANO","TAMANO")]
	[Map("PESO","PESO")]
	[Map("FOTO","FOTO")]
	[Map("VALIDO_DESDE","VALIDO_DESDE")]
	[Map("VALIDO_HASTA","VALIDO_HASTA")]
	[Map("LISTAPRECIOSID","LISTAPRECIOSID")]
	[Map("TIPOPRODUCTOID","TIPOPRODUCTOID")]
	[Map("BODEGAID","BODEGAID")]
	[Map("MEDIDAPRODUCTOID","MEDIDAPRODUCTOID")]
	public class PRODUCTO:aBase
	{
		public string PRODUCTOID { get; set; }
		public string NOMBRE { get; set; }
		public decimal TAMANO { get; set; }
		public decimal PESO { get; set; }
		public string FOTO { get; set; }
		public DateTime VALIDO_DESDE { get; set; }
		public DateTime VALIDO_HASTA { get; set; }
		public int LISTAPRECIOSID { get; set; }
		public int TIPOPRODUCTOID { get; set; }
		public int BODEGAID { get; set; }
		public int MEDIDAPRODUCTOID { get; set; }
	}
}
