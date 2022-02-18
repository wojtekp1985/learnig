using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication1.pages
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void BtnSbt_Click(object sender, EventArgs e)
        {
            bridgeEntities db = new bridgeEntities();
            city City = new city();
            City.CityName = DdlCity.SelectedValue;
            
            string CityName = City.CityName;
            
            //bridge.city = city.id;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-84AAGHL;Initial Catalog=bridge;Integrated Security=True");
            con.Open();

            SqlCommand com = new SqlCommand("select id from city where city.CityName=@CityName", con);
            com.Parameters.AddWithValue("@CityName",CityName);
            com.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();          
            da.Fill(ds, "id");
            dt = ds.Tables["id"];
            City.id =Convert.ToInt32(dt.Rows[0]["id"].ToString());
            db.Bridges.Add(AddingBridge(City));
            db.SaveChanges();
        }

        private Bridge AddingBridge(city City)
        {
            Bridge bridge = new Bridge();
            bridge.jni = System.Convert.ToInt32(TxtJni.Text);
            bridge.length = System.Convert.ToDouble(TxtLength.Text);
            //  city CityName = new city()
            // CityName.CityName = DdlCity.SelectedValue;

            bridge.city = City.id;
            //bridge.city1 = City;
            
            return bridge;






        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}