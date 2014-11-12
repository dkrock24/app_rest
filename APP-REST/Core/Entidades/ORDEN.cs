using System;
using Datos;
namespace Core.Entidades
{
	[Map("ORDENID","ORDENID")]
	[Map("NUMERO","NUMERO")]
	[Map("SOCIOID","SOCIOID")]
	[Map("MESAID","MESAID")]
	[Map("EMPLEADOID","EMPLEADOID")]
	[Map("FECHAORDEN","FECHAORDEN")]
	[Map("FECHACREACION","FECHACREACION")]
	[Map("FECHAENTREGA","FECHAENTREGA")]
	[Map("ESTADO","ESTADO")]
	public class ORDEN:aBase
	{
		public int ORDENID { get; set; }
		public int NUMERO { get; set; }
		public string SOCIOID { get; set; }
		public int MESAID { get; set; }
		public int EMPLEADOID { get; set; }
		public DateTime FECHAORDEN { get; set; }
		public DateTime FECHACREACION { get; set; }
		public DateTime FECHAENTREGA { get; set; }
		public string ESTADO { get; set; }
	}
}
