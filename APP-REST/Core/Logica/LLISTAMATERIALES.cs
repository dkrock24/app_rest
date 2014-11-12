using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LLISTAMATERIALES : ILISTAMATERIALES
	{
		public List<LISTAMATERIALES> Listar()
		{
			aBase.SQL = "select * from INVENTARIO.LISTAMATERIALES";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new LISTAMATERIALES());
			return aBase.LoadData().ConvertAll(new Converter<aBase, LISTAMATERIALES>(Abase));
		}
		public LISTAMATERIALES Abase(aBase p)
		{
			return (LISTAMATERIALES)p;
		}
		public void Guardar(LISTAMATERIALES obj)
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
		public int GuardarById(LISTAMATERIALES obj)
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
		public void Eliminar(LISTAMATERIALES obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(LISTAMATERIALES obj)
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
		public LISTAMATERIALES EntidadId(int id)
		{
            aBase.SQL = "select * from INVENTARIO.LISTAMATERIALES where LISTAMATERIALESID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new LISTAMATERIALES());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, LISTAMATERIALES>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
