using System;
using Datos;
namespace Core.Entidades
{
	[Map("USUARIOID","USUARIOID")]
	[Map("ROLID","ROLID")]
	public class USUARIO_ROL:aBase
	{
		public int USUARIOID { get; set; }
		public int ROLID { get; set; }
	}
}
