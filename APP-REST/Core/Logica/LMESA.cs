using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LMESA : IMESA
	{
		public List<MESA> Listar()
		{
			aBase.SQL = "select * from VENTAS.MESA";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new MESA());
			return aBase.LoadData().ConvertAll(new Converter<aBase, MESA>(Abase));
		}
		public MESA Abase(aBase p)
		{
			return (MESA)p;
		}
		public void Guardar(MESA obj)
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
		public int GuardarById(MESA obj)
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
		public void Eliminar(MESA obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(MESA obj)
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
		public MESA EntidadId(int id)
		{
            aBase.SQL = "select * from VENTAS.MESA where MESAID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new MESA());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, MESA>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
