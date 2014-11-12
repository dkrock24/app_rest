using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LLISTAMATERIALESDETALLE : ILISTAMATERIALESDETALLE
	{
		public List<LISTAMATERIALESDETALLE> Listar()
		{
			aBase.SQL = "select * from INVENTARIO.LISTAMATERIALESDETALLE";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new LISTAMATERIALESDETALLE());
			return aBase.LoadData().ConvertAll(new Converter<aBase, LISTAMATERIALESDETALLE>(Abase));
		}
		public LISTAMATERIALESDETALLE Abase(aBase p)
		{
			return (LISTAMATERIALESDETALLE)p;
		}
		public void Guardar(LISTAMATERIALESDETALLE obj)
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
		public int GuardarById(LISTAMATERIALESDETALLE obj)
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
		public void Eliminar(LISTAMATERIALESDETALLE obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(LISTAMATERIALESDETALLE obj)
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
		public LISTAMATERIALESDETALLE EntidadId(int id)
		{
            aBase.SQL = "select * from INVENTARIO.LISTAMATERIALESDETALLE where LISTAMATERIALESDETALLEID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new LISTAMATERIALESDETALLE());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, LISTAMATERIALESDETALLE>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
