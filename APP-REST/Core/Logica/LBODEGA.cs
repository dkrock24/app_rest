using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LBODEGA : IBODEGA
	{
		public List<BODEGA> Listar()
		{
            aBase.SQL = "select * from INVENTARIO.BODEGA";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new BODEGA());
			return aBase.LoadData().ConvertAll(new Converter<aBase, BODEGA>(Abase));
		}
		public BODEGA Abase(aBase p)
		{
			return (BODEGA)p;
		}
		public void Guardar(BODEGA obj)
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
		public int GuardarById(BODEGA obj)
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
		public void Eliminar(BODEGA obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(BODEGA obj)
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
		public BODEGA EntidadId(int id)
		{
            aBase.SQL = "select * from INVENTARIO.BODEGA where BODEGAID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new BODEGA());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, BODEGA>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
