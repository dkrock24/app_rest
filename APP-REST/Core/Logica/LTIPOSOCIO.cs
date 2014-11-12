using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LTIPOSOCIO : ITIPOSOCIO
	{
		public List<TIPOSOCIO> Listar()
		{
			aBase.SQL = "select * from ADMINISTRACION.TIPOSOCIO";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new TIPOSOCIO());
			return aBase.LoadData().ConvertAll(new Converter<aBase, TIPOSOCIO>(Abase));
		}
		public TIPOSOCIO Abase(aBase p)
		{
			return (TIPOSOCIO)p;
		}
		public void Guardar(TIPOSOCIO obj)
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
		public int GuardarById(TIPOSOCIO obj)
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
		public void Eliminar(TIPOSOCIO obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(TIPOSOCIO obj)
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
		public TIPOSOCIO EntidadId(int id)
		{
            aBase.SQL = "select * from ADMINISTRACION.TIPOSOCIO where TIPOSOCIOID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new TIPOSOCIO());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, TIPOSOCIO>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
