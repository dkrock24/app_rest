using System;
using Datos;
namespace Core.Entidades
{
	[Map("TIPOPRODUCTOID","TIPOPRODUCTOID")]
	[Map("DESCRIPCION","DESCRIPCION")]
	public class TIPOPRODUCTO:aBase
	{
		public int TIPOPRODUCTOID { get; set; }
		public string DESCRIPCION { get; set; }
	}
}
