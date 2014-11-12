using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LINVENTARIO : IINVENTARIO
	{
		public List<INVENTARIO> Listar()
		{
			aBase.SQL = "select * from INVENTARIO.INVENTARIO";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new INVENTARIO());
			return aBase.LoadData().ConvertAll(new Converter<aBase, INVENTARIO>(Abase));
		}
		public INVENTARIO Abase(aBase p)
		{
			return (INVENTARIO)p;
		}
		public void Guardar(INVENTARIO obj)
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
		public int GuardarById(INVENTARIO obj)
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
		public void Eliminar(INVENTARIO obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(INVENTARIO obj)
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
		public INVENTARIO EntidadId(int id)
		{
            aBase.SQL = "select * from INVENTARIO.INVENTARIO where INVENTARIOID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new INVENTARIO());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, INVENTARIO>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
