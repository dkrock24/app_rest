using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LROL : IROL
	{
		public List<ROL> Listar()
		{
			aBase.SQL = "select * from ADMINISTRACION.ROL";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new ROL());
			return aBase.LoadData().ConvertAll(new Converter<aBase, ROL>(Abase));
		}
		public ROL Abase(aBase p)
		{
			return (ROL)p;
		}
		public void Guardar(ROL obj)
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
		public int GuardarById(ROL obj)
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
		public void Eliminar(ROL obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(ROL obj)
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
		public ROL EntidadId(int id)
		{
            aBase.SQL = "select * from ADMINISTRACION.ROL where ROLID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new ROL());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, ROL>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
