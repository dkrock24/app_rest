using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LUSUARIO_ROL : IUSUARIO_ROL
	{
		public List<USUARIO_ROL> Listar()
		{
			aBase.SQL = "select * from ADMINISTRACION.USUARIO_ROL";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new USUARIO_ROL());
			return aBase.LoadData().ConvertAll(new Converter<aBase, USUARIO_ROL>(Abase));
		}
		public USUARIO_ROL Abase(aBase p)
		{
			return (USUARIO_ROL)p;
		}
		public void Guardar(USUARIO_ROL obj)
		{
			try
			{
				aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, obj);
				aBase.Guardar();
			}
			catch (Exception ex)
			{
				throw new ApplicationException(ex.Message);
			}
		}
		public int GuardarById(USUARIO_ROL obj)
		{
			try
			{
				aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, obj);
				return aBase.GuardarbyEntidad();
			}
			catch (Exception ex)
			{
				throw new ApplicationException(ex.Message);
			}
		}
		public void Eliminar(USUARIO_ROL obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(USUARIO_ROL obj)
		{
			try
			{
				aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, obj);
				aBase.Actualizar();
			}
			catch (Exception ex)
			{
				throw new ApplicationException(ex.Message);
			}
		}
		public USUARIO_ROL EntidadId(int id)
		{
            aBase.SQL = "select * from ADMINISTRACION.USUARIO_ROL where USUARIOID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new USUARIO_ROL());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, USUARIO_ROL>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
