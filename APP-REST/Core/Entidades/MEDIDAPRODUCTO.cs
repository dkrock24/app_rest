using System;
using Datos;
namespace Core.Entidades
{
	[Map("MEDIDAPRODUCTOID","MEDIDAPRODUCTOID")]
	[Map("DESCCORTA","DESCCORTA")]
	[Map("DESCRIPCION","DESCRIPCION")]
	public class MEDIDAPRODUCTO:aBase
	{
		public int MEDIDAPRODUCTOID { get; set; }
		public string DESCCORTA { get; set; }
		public string DESCRIPCION { get; set; }
	}
}
