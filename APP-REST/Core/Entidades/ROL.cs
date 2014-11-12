using System;
using Datos;
namespace Core.Entidades
{
	[Map("ROLID","ROLID")]
	[Map("NOMBRE","NOMBRE")]
	public class ROL:aBase
	{
		public int ROLID { get; set; }
		public string NOMBRE { get; set; }
	}
}
