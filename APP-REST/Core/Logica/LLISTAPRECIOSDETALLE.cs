using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LLISTAPRECIOSDETALLE : ILISTAPRECIOSDETALLE
	{
		public List<LISTAPRECIOSDETALLE> Listar()
		{
			aBase.SQL = "select * from INVENTARIO.LISTAPRECIOSDETALLE";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new LISTAPRECIOSDETALLE());
			return aBase.LoadData().ConvertAll(new Converter<aBase, LISTAPRECIOSDETALLE>(Abase));
		}
		public LISTAPRECIOSDETALLE Abase(aBase p)
		{
			return (LISTAPRECIOSDETALLE)p;
		}
		public void Guardar(LISTAPRECIOSDETALLE obj)
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
		public int GuardarById(LISTAPRECIOSDETALLE obj)
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
		public void Eliminar(LISTAPRECIOSDETALLE obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(LISTAPRECIOSDETALLE obj)
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
		public LISTAPRECIOSDETALLE EntidadId(int id)
		{
            aBase.SQL = "select * from INVENTARIO.LISTAPRECIOSDETALLE where LISTAPRECIOSDETALLEID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new LISTAPRECIOSDETALLE());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, LISTAPRECIOSDETALLE>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
