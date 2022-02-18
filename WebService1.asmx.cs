using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace KB_CascadingDDL_CS
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
 /*   [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        [WebMethod()]
        public string[] GetMakeValue()
        {
            return new string[] { "Please select", "Ford", "Dodge" };
        }

        [WebMethod()]
        public string[] GetChildValue(string parentID, string parentValue)
        {
            if (parentValue == "Please select")
            {
                return null;
            }

            string[] values;
            if (parentID == "ddlMake")
            {
                if (parentValue == "Ford")
                {
                    values = new string[] { "Please select", "Explorer", "F150", "Mustang" };
                }
                else if (parentValue == "Dodge")
                {
                    values = new string[] { "Please select", "Durango", "Dakota", "Viper" };
                }
                else
                {
                    return new string[] { "Invalid Make value!" };
                }
            }
            else if (parentID == "ddlModel")
            {
                switch (parentValue)
                {
                    case "Explorer":
                    case "Dakota":
                    case "Viper":
                        values = new string[] { "Please select", "Black", "Green", "Yellow" };
                        break;
                    case "Durango":
                    case "F150":
                    case "Mustang":
                        values = new string[] { "Please select", "White", "Red", "Blue" };
                        break;
                    default:
                        values = new string[] { "Invalid Model value!" };
                        break;
                }
            }
            else
            {
                return new string[] { "Invalid Category value!" };
            }
            return values;
        }
    }
}
/*namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod()]
        public string[] GetMakeValue()
        {
            return new string[] { "Please select", "Ford", "Dodge" };
        }

        [WebMethod()]
        public string[] GetChildValue(string parentID, string parentValue)
        {
            if (parentValue == "Please select")
            {
                return null;
            }

            string[] values;
            if (parentID == "ddlMake")
            {
                if (parentValue == "Ford")
                {
                    values = new string[] { "Please select", "Explorer", "F150", "Mustang" };
                }
                else if (parentValue == "Dodge")
                {
                    values = new string[] { "Please select", "Durango", "Dakota", "Viper" };
                }
                else
                {
                    return new string[] { "Invalid Make value!" };
                }
            }
            else if (parentID == "ddlModel")
            {
                switch (parentValue)
                {
                    case "Explorer":
                    case "Dakota":
                    case "Viper":
                        values = new string[] { "Please select", "Black", "Green", "Yellow" };
                        break;
                    case "Durango":
                    case "F150":
                    case "Mustang":
                        values = new string[] { "Please select", "White", "Red", "Blue" };
                        break;
                    default:
                        values = new string[] { "Invalid Model value!" };
                        break;
                }
            }
            else
            {
                return new string[] { "Invalid Category value!" };
            }
            return values;
        }*/
    
}

