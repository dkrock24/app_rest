using System;

namespace Datos
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    public class Map : Attribute
    {
        public Map(string campoTabla, string propiedadClase)
        {
            CampoTabla = campoTabla;
            PropiedadClase = propiedadClase;
        }
        public string CampoTabla { get; set; }
        public string PropiedadClase { get; set; }
    }
}
