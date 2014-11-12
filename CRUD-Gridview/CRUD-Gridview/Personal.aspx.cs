using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_Gridview
{   
    public partial class Formulario : System.Web.UI.Page
    {
        //SqlConnection cnx = new SqlConnection("server=(local);Database=Practica;integrated security=true");
        SqlConnection cnx = new SqlConnection("server=(local);Database=Practica;integrated security=no;User=sa;Password=12345");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                {
                    txtCodigo.Attributes.Add("onkeypress", "javascript:return ValidNum(event);");
                    txtTelefono.Attributes.Add("onkeypress", "javascript:return ValidNum(event);");
                    txtDui.Attributes.Add("onkeypress", "javascript:return ValidNum(event);");                 
                    LLenar_Grilla();
            }                
        }
        private void LLenar_Grilla()
        {
            SqlCommand cmd = new SqlCommand("usp_personal_mostrar", cnx);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.GridPersonal.DataSource = dt;
            this.GridPersonal.DataBind();
        }
        protected void GridPersonal_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                LLenar_Grilla();
                GridPersonal.PageIndex = e.NewPageIndex;
                this.GridPersonal.DataBind();
            }
            catch (Exception ex)
            {
                txtMensaje.Text = ex.Message.ToString();
            }
        }
        protected void GridPersonal_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                GridPersonal.EditIndex = e.NewEditIndex;
                LLenar_Grilla();
            }
            catch (Exception ex)
            {
                txtMensaje.Text = ex.Message.ToString();
            }               
        }
        protected void GridPersonal_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                GridPersonal.EditIndex = -1;
                LLenar_Grilla();
            }
            catch (Exception ex)
            {
                txtMensaje.Text = ex.Message.ToString();
            }
        }
        protected void GridPersonal_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string cod, ape, nom, dir, tel, dui, sexito;
            int departamento;
            try
            {
                TextBox txt = new TextBox();
                txt = (TextBox)GridPersonal.Rows[e.RowIndex].FindControl("txtCod");
                cod = txt.Text;
                txt = (TextBox) GridPersonal.Rows[e.RowIndex].FindControl("txtApe");
                ape = txt.Text;
                txt = (TextBox)GridPersonal.Rows[e.RowIndex].FindControl("txtNom");
                nom = txt.Text;
                txt = (TextBox)GridPersonal.Rows[e.RowIndex].FindControl("txtDir");
                dir = txt.Text;
                txt = (TextBox)GridPersonal.Rows[e.RowIndex].FindControl("txtTel");
                tel = txt.Text;
                txt = (TextBox)GridPersonal.Rows[e.RowIndex].FindControl("txtDui");
                dui = txt.Text;
                
                DropDownList sexo = new DropDownList();                      
                sexo= (DropDownList) GridPersonal.Rows[e.RowIndex].FindControl("cboSex");
                sexito = Convert.ToString(sexo.SelectedValue);

                DropDownList depto = new DropDownList();  
                depto = (DropDownList)GridPersonal.Rows[e.RowIndex].FindControl("txtDepto");
                departamento = Convert.ToInt32(depto.SelectedValue);


                SqlCommand cmd = new SqlCommand("usp_personal_actualizar", cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Cod", SqlDbType.Int).Value = cod;
                    cmd.Parameters.AddWithValue("@Ape", SqlDbType.VarChar).Value = ape;
                    cmd.Parameters.AddWithValue("@Nom", SqlDbType.VarChar).Value = nom;
                    cmd.Parameters.AddWithValue("@Dir", SqlDbType.VarChar).Value = dir;
                    cmd.Parameters.AddWithValue("@Tel", SqlDbType.Char).Value = tel;
                    cmd.Parameters.AddWithValue("@Dui", SqlDbType.Char).Value = dui;
                    cmd.Parameters.AddWithValue("@Sex", SqlDbType.VarChar).Value = sexito;
                    cmd.Parameters.AddWithValue("@Dep", SqlDbType.Int).Value = departamento;
                }
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                GridPersonal.EditIndex = -1;
                LLenar_Grilla();
                PanelFormulario.Visible = false;
                txtMensaje.Text = "Personal Actualizado Correctamente.";
            }
            catch (Exception ex)
            {
                txtMensaje.Text = ex.Message.ToString();
            }
        }
        protected void GridPersonal_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("usp_personal_eliminar", cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Cod", SqlDbType.Int).Value = GridPersonal.DataKeys[e.RowIndex].Value;
                    //cmd.Parameters.AddWithValue("@Cod", SqlDbType.Int).Value = GridPersonal.DataKeys[e.RowIndex].Values["Cod"].ToString();
                }
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                GridPersonal.EditIndex = -1;
                LLenar_Grilla();
                PanelFormulario.Visible = false;
                txtMensaje.Text = "Personal Eliminado Correctamente.";
            }
            catch (Exception)
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text != "" && txtApellidos.Text != "" && txtNombres.Text != ""
                     && txtTelefono.Text != "" && txtDui.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("sp_personal_grabar", cnx);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@cod", SqlDbType.Int).Value = txtCodigo.Text;
                        cmd.Parameters.AddWithValue("@Ape", SqlDbType.VarChar).Value = txtApellidos.Text;
                        cmd.Parameters.AddWithValue("@Nom", SqlDbType.VarChar).Value = txtNombres.Text;
                        cmd.Parameters.AddWithValue("@Dir", SqlDbType.VarChar).Value = txtDireccion.Text;
                        cmd.Parameters.AddWithValue("@Tel", SqlDbType.Char).Value = txtTelefono.Text;
                        cmd.Parameters.AddWithValue("@Dui", SqlDbType.Char).Value = txtDui.Text;
                        cmd.Parameters.AddWithValue("@Sex", SqlDbType.VarChar).Value = cbSexo.SelectedValue;
                        cmd.Parameters.AddWithValue("@Dep", SqlDbType.Int).Value = txtDepto.Text;
                    }
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    LLenar_Grilla();
                    PanelFormulario.Visible = false;
                    Limpiar();
                    txtMensaje.Text = "Personal Guardado Correctamente.";
                }
                else {
                    txtMensaje.Text = "Completar el formulario.";
                }               
            }
            catch (Exception ex)
            {
                txtMensaje.Text = ex.Message.ToString();
            }
        }

        protected void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            PanelFormulario2.Visible = false;
            PanelFormulario.Visible = true;
            Limpiar();
            txtMensaje.Text = "";
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            PanelFormulario.Visible = false;
            Limpiar();
            txtMensaje.Text = "";
        }
        private void Limpiar() { 
            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtDui.Text = "";
            txtTelefono.Text = "";
        }

        protected void btnNuevoDepartamento_Click(object sender, EventArgs e)
        {
            PanelFormulario.Visible = false;
            PanelFormulario2.Visible = true;
            Limpiar();
            txtMensaje.Text = "";
        }

        protected void departament_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDepartamento.Text != "" && txtDescripcion.Text != "" )
                {
                    SqlCommand cmd = new SqlCommand("sp_departamento_grabar", cnx);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre_depto", SqlDbType.VarChar).Value = txtDepartamento.Text;
                        cmd.Parameters.AddWithValue("@descripcion_depto", SqlDbType.VarChar).Value = txtDescripcion.Text;

                    }
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    LLenar_Grilla();
                    PanelFormulario.Visible = false;
                    Limpiar();
                    txtMensaje.Text = "Departamento Guardado Correctamente.";
                }
                else
                {
                    txtMensaje.Text = "Completar el formulario.";
                }
            }
            catch (Exception ex)
            {
                txtMensaje.Text = ex.Message.ToString();
            }
        }

               
    }
}