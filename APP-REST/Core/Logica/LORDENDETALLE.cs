using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LORDENDETALLE : IORDENDETALLE
	{
		public List<ORDENDETALLE> Listar()
		{
            aBase.SQL = "select * from PRODUCCION.ORDENDETALLE";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new ORDENDETALLE());
			return aBase.LoadData().ConvertAll(new Converter<aBase, ORDENDETALLE>(Abase));
		}
		public ORDENDETALLE Abase(aBase p)
		{
			return (ORDENDETALLE)p;
		}
		public void Guardar(ORDENDETALLE obj)
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
		public int GuardarById(ORDENDETALLE obj)
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
		public void Eliminar(ORDENDETALLE obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(ORDENDETALLE obj)
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
		public ORDENDETALLE EntidadId(int id)
		{
            aBase.SQL = "select * from PRODUCCION.ORDENDETALLE where ORDENDETALLEID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new ORDENDETALLE());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, ORDENDETALLE>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
