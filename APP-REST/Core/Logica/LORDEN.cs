using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LORDEN : IORDEN
	{
		public List<ORDEN> Listar()
		{
			aBase.SQL = "select * from PRODUCCION.ORDEN";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new ORDEN());
			return aBase.LoadData().ConvertAll(new Converter<aBase, ORDEN>(Abase));
		}
		public ORDEN Abase(aBase p)
		{
			return (ORDEN)p;
		}
		public void Guardar(ORDEN obj)
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
		public int GuardarById(ORDEN obj)
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
		public void Eliminar(ORDEN obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(ORDEN obj)
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
		public ORDEN EntidadId(int id)
		{
            aBase.SQL = "select * from PRODUCCION.ORDEN where ORDENID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new ORDEN());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, ORDEN>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
