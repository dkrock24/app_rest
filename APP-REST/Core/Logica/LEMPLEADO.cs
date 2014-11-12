using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LEMPLEADO : IEMPLEADO
	{
		public List<EMPLEADO> Listar()
		{
			aBase.SQL = "select * from ADMINISTRACION.EMPLEADO";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new EMPLEADO());
			return aBase.LoadData().ConvertAll(new Converter<aBase, EMPLEADO>(Abase));
		}
		public EMPLEADO Abase(aBase p)
		{
			return (EMPLEADO)p;
		}
		public void Guardar(EMPLEADO obj)
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
		public int GuardarById(EMPLEADO obj)
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
		public void Eliminar(EMPLEADO obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(EMPLEADO obj)
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
		public EMPLEADO EntidadId(int id)
		{
            aBase.SQL = "select * from ADMINISTRACION.EMPLEADO where EMPLEADOID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new EMPLEADO());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, EMPLEADO>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
