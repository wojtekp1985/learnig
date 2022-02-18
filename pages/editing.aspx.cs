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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                DdlChoseCity.DataSource = fillingUpBridgeData("getCityAllNames", null);
                
                DdlChoseCity.DataTextField = fillingUpBridgeData("getCityAllNames", null).Tables[0].Columns[1].ToString();
                DdlChoseCity.DataValueField = fillingUpBridgeData("getCityAllNames", null).Tables[0].Columns[0].ToString();
                DdlChoseCity.DataBind();
                ListItem firstDdlElement = new ListItem("wybierz miasto", "-1");
                DdlChoseCity.Items.Insert(0, firstDdlElement);

                // ListItem firstDdlChoseJniItem = new ListItem("no working", "-1");
                // DdlChoseJni.Items.Insert(0, firstDdlChoseJniItem);
                
                DdlChoseJni.Enabled = false;
                //  DdlChoseCity.SelectedIndex = 2;
       
       
            }
            
           
        }
        
     /*   public void fillUPddl(int id)
        {
            
            Bridge bridge = new Bridge();
            // int bridges = city.id;
            int bridges = id;
            //bridge.city = city.id;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-84AAGHL;Initial Catalog=bridge;Integrated Security=True");
            con.Open();
            
            SqlCommand com = new SqlCommand("select jni from Bridge where Bridge.city=@bridges", con);
            com.Connection = con;
            com.Parameters.AddWithValue("@bridges", bridges);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);  // fill dataset  

            DdlChoseJni.DataTextField = ds.Tables[0].Columns[0].ToString(); // text field name of table dispalyed in dropdown       
            
            
            // to retrive specific  textfield name   
            DdlChoseJni.DataSource = ds.Tables[0];    //assigning datasource to the dropdownlist  
            DdlChoseJni.DataBind();




        }
     */

        
       /*protected void DropDownList2_SelectedIndexChanged1(object sender, EventArgs e)
        {
            
            city City = new city();
            City.CityName = DdlChoseCity.SelectedValue;
            string CityName = City.CityName;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-84AAGHL;Initial Catalog=bridge;Integrated Security=True");
            con.Open();

            SqlCommand com = new SqlCommand("select id from city where city.CityName=@CityName", con);
            com.Parameters.AddWithValue("@CityName", CityName);
            com.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "id");
            dt = ds.Tables["id"];
            City.id = Convert.ToInt32(dt.Rows[0]["id"].ToString());
            fillUPddl(City.id);
        }*/

       /* public int checkingCityIdSQL(string City)
        {

            string name = City;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-84AAGHL;Initial Catalog=bridge;Integrated Security=True");
            con.Open();

            SqlCommand com = new SqlCommand("select id from city where city.CityName = @CityName", con);
            com.Parameters.AddWithValue("@CityName", name);
            com.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "id");
            dt = ds.Tables["id"];
          
            //fillUPddl(City.id);
            return  Convert.ToInt32(dt.Rows[0]["id"].ToString());
        }
       */
  //function that return data from database 
  //first we create a sqlConnection
  //second we open connection
  //we are using adapter which to we giving selecte

        private DataSet fillingUpBridgeData(string ProcedureName, SqlParameter param)
        {
            // string conString = ConfigurationManager.ConnectionStrings.ToString(); 
            //  ConfigurationManager.ConnectionStrings["Data Source=DESKTOP-84AAGHL;Initial Catalog=bridge;Integrated Security=True"].ConnectionString;
            //  SqlConnection con = new SqlConnection(conString);
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-84AAGHL;Initial Catalog=bridge;Integrated Security=True");
            con.Open();
            DataSet da = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(ProcedureName, con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            
            if (param != null)
            {
                adapter.SelectCommand.Parameters.Add(param);
                
            }
            adapter.Fill(da);

            return da;




        }

        protected void DdlChoseCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DdlChoseCity.SelectedIndex == 0)
            {
                /*  ListItem firstDdlChoseJniItem = new ListItem("broken", "-2");
                  DdlChoseJni.Items.Insert(1, firstDdlChoseJniItem);
                  DdlChoseJni.SelectedIndex = 1;*/

               ListItem firstElementOfDdlChoseJni = new ListItem("select Jni", "-1");
                DdlChoseJni.Items.Insert(0, firstElementOfDdlChoseJni);
                DdlChoseJni.SelectedIndex = 1;
                DdlChoseJni.Enabled =false;
                
            }
            else
            {
                DdlChoseJni.Enabled = true;
                SqlParameter param = new SqlParameter("@cityId", DdlChoseCity.SelectedValue);
                DdlChoseJni.DataSource = fillingUpBridgeData("getBridgeById", param);
                DdlChoseJni.DataBind();
                GetData();
                
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
         /*   SqlConnection con = new SqlConnection("Data Source=DESKTOP-84AAGHL;Initial Catalog=bridge;Integrated Security=True");
            con.Open();
           DataSet data = new DataSet();
            SqlCommand com = new SqlCommand("select k.id, k.jni, l.CityName, k.length from bridge k join city l on k.city=l.id where k.jni=@jni", con);
           
            com.Parameters.AddWithValue("@jni", DdlChoseJni.SelectedValue.ToString());
            com.Connection = con;



            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(data);
            
           // GridView1.DataSource = data;
          //  GridView1.DataBind();
          //  GridView1.AutoGenerateColumns.ToString();

          //  GridView1.DataBind();*/


        }

       void GetData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-84AAGHL;Initial Catalog=bridge;Integrated Security=True");
            con.Open();
            DataSet data = new DataSet();
            SqlCommand com = new SqlCommand("select k.id, k.jni, l.CityName, k.length from bridge k join city l on k.city=l.id where k.jni=@jni", con);
            /* if (DdlChoseJni.SelectedIndex != 0)
             { com.Parameters.AddWithValue("@jni", DdlChoseJni.SelectedValue.ToString()); }

             else
                 com.Parameters.AddWithValue("@jni", "1213");
            */
            com.Parameters.AddWithValue("@jni", DdlChoseJni.SelectedValue);
            com.Connection = con;



            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(data);


            GridView1.DataSource = data;


            GridView1.DataBind();
            con.Close();
        }

          protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
           {
         
               //  GridView1.AutoGenerateColumns.ToString();

               //  GridView1.DataBind();
           }

        protected void DdlChoseJni_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}