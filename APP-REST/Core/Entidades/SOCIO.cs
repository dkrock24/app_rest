using System;
using Datos;
namespace Core.Entidades
{
	[Map("SOCIOID","SOCIOID")]
	[Map("NOMBRE","NOMBRE")]
	[Map("NIT","NIT")]
	[Map("TELEFONO","TELEFONO")]
	[Map("TIPOSOCIOID","TIPOSOCIOID")]
	[Map("CORREO","CORREO")]
	[Map("DIRECCION","DIRECCION")]
	[Map("CIUDADID","CIUDADID")]
	public class SOCIO:aBase
	{
		public string SOCIOID { get; set; }
		public string NOMBRE { get; set; }
		public string NIT { get; set; }
		public string TELEFONO { get; set; }
		public int TIPOSOCIOID { get; set; }
		public string CORREO { get; set; }
		public string DIRECCION { get; set; }
		public int CIUDADID { get; set; }
	}
}
