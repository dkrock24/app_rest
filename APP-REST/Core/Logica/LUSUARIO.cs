using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entidades;
using Core.Interfaces;
using Datos;
namespace Core.Logica
{
	public class LUSUARIO : IUSUARIO
	{
		public List<USUARIO> Listar()
		{
            aBase.SQL = "select * from ADMINISTRACION.USUARIO";
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new USUARIO());
			return aBase.LoadData().ConvertAll(new Converter<aBase, USUARIO>(Abase));
		}
		public USUARIO Abase(aBase p)
		{
			return (USUARIO)p;
		}
		public void Guardar(USUARIO obj)
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
		public int GuardarById(USUARIO obj)
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
		public void Eliminar(USUARIO obj)
		{
			throw new NotImplementedException();
		}
		public void Actualizar(USUARIO obj)
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
		public USUARIO EntidadId(int id)
		{
            aBase.SQL = "select * from ADMINISTRACION.USUARIO where USUARIOID = " + id;
			aBase.BaseUtil(ConnectionContext.Datos.APP_Rest, dbFactory.TipoBases.Sql, new USUARIO());
			var obj = aBase.LoadData().ConvertAll(new Converter<aBase, USUARIO>(Abase));
			return obj.SingleOrDefault();
		}
	}
}
