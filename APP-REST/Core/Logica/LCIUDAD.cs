using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LCIUDAD : ICIUDAD
	{
		public List<CIUDAD> Listar()
		{
			aBase.SQL = "select * from ADMINISTRACION.CIUDAD";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new CIUDAD());
			return aBase.LoadData().ConvertAll(new Converter<aBase, CIUDAD>(Abase));
		}
		public CIUDAD Abase(aBase p)
		{
			return (CIUDAD)p;
		}
		public void Guardar(CIUDAD obj)
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
		public int GuardarById(CIUDAD obj)
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
		public void Eliminar(CIUDAD obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(CIUDAD obj)
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
		public CIUDAD EntidadId(int id)
		{
            aBase.SQL = "select * from ADMINISTRACION.CIUDAD where CIUDADID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new CIUDAD());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, CIUDAD>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
