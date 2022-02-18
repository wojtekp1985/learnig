using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Classes;

namespace WebApplication1.pages
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnSbt_Click(object sender, EventArgs e)
        {
         
            Class1 bridge1 = new Class1();
            bridge1.BridgeAdding(bridgeaddnig());
            
        }

        private Bridge bridgeaddnig()
        {
            city CityName = new city();
            CityName.CityName = DdlCity.SelectedValue;

            Bridge bridge = new Bridge();
            bridge.jni = System.Convert.ToInt32(TxtJni.Text);
            bridge.city = CityName.id;
            bridge.city1 = CityName;
            bridge.length = System.Convert.ToDouble(TxtLength.Text);
            return bridge;

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}