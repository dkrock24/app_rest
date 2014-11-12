using System;
using Datos;
namespace Core.Entidades
{
	[Map("TIPOSOCIOID","TIPOSOCIOID")]
	[Map("DESCRIPCION","DESCRIPCION")]
	public class TIPOSOCIO:aBase
	{
		public int TIPOSOCIOID { get; set; }
		public string DESCRIPCION { get; set; }
	}
}
