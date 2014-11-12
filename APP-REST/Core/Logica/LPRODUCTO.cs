using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LPRODUCTO : IPRODUCTO
	{
		public List<PRODUCTO> Listar()
		{
			aBase.SQL = "select * from INVENTARIO.PRODUCTO";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new PRODUCTO());
			return aBase.LoadData().ConvertAll(new Converter<aBase, PRODUCTO>(Abase));
		}
		public PRODUCTO Abase(aBase p)
		{
			return (PRODUCTO)p;
		}
		public void Guardar(PRODUCTO obj)
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
		public int GuardarById(PRODUCTO obj)
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
		public void Eliminar(PRODUCTO obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(PRODUCTO obj)
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
		public PRODUCTO EntidadId(int id)
		{
            aBase.SQL = "select * from INVENTARIO.PRODUCTO where PRODUCTOID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new PRODUCTO());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, PRODUCTO>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
