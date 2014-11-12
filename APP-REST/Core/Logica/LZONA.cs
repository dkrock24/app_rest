using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LZONA : IZONA
	{
		public List<ZONA> Listar()
		{
			aBase.SQL = "select * from VENTAS.ZONA";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new ZONA());
			return aBase.LoadData().ConvertAll(new Converter<aBase, ZONA>(Abase));
		}
		public ZONA Abase(aBase p)
		{
			return (ZONA)p;
		}
		public void Guardar(ZONA obj)
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
		public int GuardarById(ZONA obj)
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
		public void Eliminar(ZONA obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(ZONA obj)
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
		public ZONA EntidadId(int id)
		{
            aBase.SQL = "select * from VENTAS.ZONA where ZONAID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new ZONA());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, ZONA>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
