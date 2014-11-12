using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prueba
{
    public partial class inicio : System.Web.UI.Page
    {
      

   
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=prueba;user=sa;password=12345");
            SqlCommand cm = new SqlCommand("select * from tabla_a", cn);
            cn.Open();
            SqlDataReader rd = cm.ExecuteReader();

            gvDatos.DataSource = rd;
            gvDatos.DataBind();


            

        }
    }
}