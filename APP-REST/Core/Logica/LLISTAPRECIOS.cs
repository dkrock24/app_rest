using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LLISTAPRECIOS : ILISTAPRECIOS
	{
		public List<LISTAPRECIOS> Listar()
		{
			aBase.SQL = "select * from INVENTARIO.LISTAPRECIOS";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new LISTAPRECIOS());
			return aBase.LoadData().ConvertAll(new Converter<aBase, LISTAPRECIOS>(Abase));
		}
		public LISTAPRECIOS Abase(aBase p)
		{
			return (LISTAPRECIOS)p;
		}
		public void Guardar(LISTAPRECIOS obj)
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
		public int GuardarById(LISTAPRECIOS obj)
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
		public void Eliminar(LISTAPRECIOS obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(LISTAPRECIOS obj)
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
		public LISTAPRECIOS EntidadId(int id)
		{
            aBase.SQL = "select * from INVENTARIO.LISTAPRECIOS where LISTAPRECIOSID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new LISTAPRECIOS());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, LISTAPRECIOS>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
