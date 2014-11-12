namespace Datos
{
    public class ConnectionContext
    {
        public enum Datos
        {
            Sap = 0,
            Excel = 1,
            SGI = 2,
            SBIWeb =3,
            APP_Rest = 4

        }

        public Datos TipoDatos { get; set; }

        public string CadenaConexion { get; set; }

        public void SetearBase(Datos s)
        {
            switch (s)
            {
                //case Datos.Sap:
                //    CadenaConexion = Properties.Settings.Default.cnSAP;
                //    break;
                case Datos.Excel:
                    CadenaConexion = CadenaConexion;
                    break;
                //case Datos.PayrollOne:
                //    CadenaConexion = Properties.Settings.Default.cnPayroll;
                //    break;
                case Datos.APP_Rest:
                    CadenaConexion = Properties.Settings.Default.cnDB;
                    break;
                //case Datos.Sap:
                //    CadenaConexion = ;
                //    break;
            }
        }
    }
}
