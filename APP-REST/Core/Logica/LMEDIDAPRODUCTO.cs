using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LMEDIDAPRODUCTO : IMEDIDAPRODUCTO
	{
		public List<MEDIDAPRODUCTO> Listar()
		{
			aBase.SQL = "select * from INVENTARIO.MEDIDAPRODUCTO";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new MEDIDAPRODUCTO());
			return aBase.LoadData().ConvertAll(new Converter<aBase, MEDIDAPRODUCTO>(Abase));
		}
		public MEDIDAPRODUCTO Abase(aBase p)
		{
			return (MEDIDAPRODUCTO)p;
		}
		public void Guardar(MEDIDAPRODUCTO obj)
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
		public int GuardarById(MEDIDAPRODUCTO obj)
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
		public void Eliminar(MEDIDAPRODUCTO obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(MEDIDAPRODUCTO obj)
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
		public MEDIDAPRODUCTO EntidadId(int id)
		{
            aBase.SQL = "select * from INVENTARIO.MEDIDAPRODUCTO where MEDIDAPRODUCTOID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new MEDIDAPRODUCTO());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, MEDIDAPRODUCTO>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
