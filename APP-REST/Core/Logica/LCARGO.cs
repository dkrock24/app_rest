using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LCARGO : ICARGO
	{
		public List<CARGO> Listar()
		{
			aBase.SQL = "select * from ADMINISTRACION.CARGO";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new CARGO());
			return aBase.LoadData().ConvertAll(new Converter<aBase, CARGO>(Abase));
		}
		public CARGO Abase(aBase p)
		{
			return (CARGO)p;
		}
		public void Guardar(CARGO obj)
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
		public int GuardarById(CARGO obj)
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
		public void Eliminar(CARGO obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(CARGO obj)
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
		public CARGO EntidadId(int id)
		{
            aBase.SQL = "select * from ADMINISTRACION.CARGO where CARGOID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new CARGO());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, CARGO>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
