using System;
using Datos;
namespace Core.Entidades
{
	[Map("CIUDADID","CIUDADID")]
	[Map("NOMBRE","NOMBRE")]
	public class CIUDAD:aBase
	{
		public int CIUDADID { get; set; }
		public string NOMBRE { get; set; }
	}
}
