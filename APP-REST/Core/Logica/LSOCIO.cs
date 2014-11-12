using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LSOCIO : ISOCIO
	{
		public List<SOCIO> Listar()
		{
			aBase.SQL = "select * from ADMINISTRACION.SOCIO";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new SOCIO());
			return aBase.LoadData().ConvertAll(new Converter<aBase, SOCIO>(Abase));
		}
		public SOCIO Abase(aBase p)
		{
			return (SOCIO)p;
		}
		public void Guardar(SOCIO obj)
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
		public int GuardarById(SOCIO obj)
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
		public void Eliminar(SOCIO obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(SOCIO obj)
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
		public SOCIO EntidadId(int id)
		{
            aBase.SQL = "select * from ADMINISTRACION.SOCIO where SOCIOID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new SOCIO());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, SOCIO>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
