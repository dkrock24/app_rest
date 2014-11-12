using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LTIPOPRODUCTO : ITIPOPRODUCTO
	{
		public List<TIPOPRODUCTO> Listar()
		{
			aBase.SQL = "select * from ADMINISTRACION.TIPOPRODUCTO";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new TIPOPRODUCTO());
			return aBase.LoadData().ConvertAll(new Converter<aBase, TIPOPRODUCTO>(Abase));
		}
		public TIPOPRODUCTO Abase(aBase p)
		{
			return (TIPOPRODUCTO)p;
		}
		public void Guardar(TIPOPRODUCTO obj)
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
		public int GuardarById(TIPOPRODUCTO obj)
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
		public void Eliminar(TIPOPRODUCTO obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(TIPOPRODUCTO obj)
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
		public TIPOPRODUCTO EntidadId(int id)
		{
            aBase.SQL = "select * from ADMINISTRACION.TIPOPRODUCTO where TIPOSOCIOID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new TIPOPRODUCTO());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, TIPOPRODUCTO>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
