using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1.pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Label lblMasterStatus = (Label)Master.FindControl("Lbl1");
             TextBox text = (TextBox)Master.FindControl("Txt1");
            lblMasterStatus.Text = text.Text;

            


        }
    }
}