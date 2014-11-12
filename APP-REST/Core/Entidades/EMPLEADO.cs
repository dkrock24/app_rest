using System;
using Datos;
namespace Core.Entidades
{
	[Map("EMPLEADOID","EMPLEADOID")]
	[Map("NOMBRE","NOMBRE")]
	[Map("APELLIDO","APELLIDO")]
	[Map("DUI","DUI")]
	[Map("NIT","NIT")]
	[Map("DIRECCION","DIRECCION")]
	[Map("TELEFONO","TELEFONO")]
	[Map("CELULAR","CELULAR")]
	[Map("EMAIL","EMAIL")]
	[Map("USUARIOID","USUARIOID")]
	[Map("CARGOID","CARGOID")]
	[Map("CIUDADID","CIUDADID")]
	public class EMPLEADO:aBase
	{
		public int EMPLEADOID { get; set; }
		public string NOMBRE { get; set; }
		public string APELLIDO { get; set; }
		public string DUI { get; set; }
		public string NIT { get; set; }
		public string DIRECCION { get; set; }
		public string TELEFONO { get; set; }
		public string CELULAR { get; set; }
		public string EMAIL { get; set; }
		public int USUARIOID { get; set; }
		public int CARGOID { get; set; }
		public int CIUDADID { get; set; }
	}
}
