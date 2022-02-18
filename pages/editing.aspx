<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editing.aspx.cs" Inherits="WebApplication1.pages.WebForm3" EnableEventValidation="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <%--   <asp:ScriptManager ID="ScriptManager1" runat="server">
        
    <Services>
        <asp:ServiceReference Path="~/WebService1.asmx" />
    </Services>
 %></asp:ScriptManager>
        <table>
    <tr>
        <td>
            Make:
        </td>
        <td>
            <asp:DropDownList ID="ddlMake" Width="200" runat="server" AutoPostBack="false" onchange="ddl_changed(this)" />
        </td>
    </tr>
    <tr>
        <td>
            Model:
        </td>
        <td>
            <asp:DropDownList ID="ddlModel" Width="200" runat="server" AutoPostBack="false" onchange="ddl_changed(this)" OnSelectedIndexChanged="ddlModel_SelectedIndexChanged" />
        </td>
    </tr>
    <tr>
        <td>
            Color:
        </td>
        <td>
            <asp:DropDownList ID="ddlColor" Width="200" runat="server" AutoPostBack="false" onchange="DisplayResult()" OnSelectedIndexChanged="ddlColor_SelectedIndexChanged" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnReset" runat="server" Text="Reset" />
        </td>
    </tr>
</table>
<a id="aResult" />
        <script type="text/javascript">
            function pageLoad() {
                // call a Web service method with no parameters and the user context.
                
                KB_CascadingDDL_CS.WebService.GetMakeValue(SucceededCallbackWithContext, FailedCallback, "fillMake);
                <%--"
            }

            // Event handler for ddlMake and ddlModel.
            // This function calls a Web service method
            // passing simple type parameters and the user context.
            function ddl_changed(sender) {
                // This initiates the call to the server-side method in your code-behind
                // The parameters are as follows:
                // 1st : Specify all the parameters expected by your code-behind method
                //      (in this case there are 2: parentControl's ID, parentControl's selected text)
                // 2nd : Specify a callback method when the call succeeds
                // 3rd : Specify a callback method when the call fails(optional)
                // 4th : Specify a user context object (option - not shown)
                //      (in this case we need to assign the parentControl's ID as the user context)
                KB_CascadingDDL_CS.WebService.GetChildValue(sender.id, sender[sender.selectedIndex].text,
                    SucceededCallbackWithContext, FailedCallback, sender.id);
            }

            // This is the callback function called if the
            // Web service succeeded. It accepts the result
            // object, the user context, and the method name as
            // parameters.
            function SucceededCallbackWithContext(result, userContext) {

                if (userContext == "fillMake") {
                    //fill the Make
                    var ddl = $get('ddlMake');
                } else if (userContext == "ddlMake") {
                    // fill the Model
                    var ddl = $get('ddlModel');
                    $get('ddlColor').options.length = 0;
                } else if (userContext == "ddlModel") {
                    // fill the Color
                    var ddl = $get('ddlColor');
                }
                // clear the options
                ddl.options.length = 0;
                if (result) {
                    var i = 0;
                    for (var item in result) {
                        // item is the key, result[item] is the value
                        ddl.options.add(new Option(result[item], item));
                        i++;
                    }
                } else {
                    alert("Invalid! Please reset the selection!");
                    $get(userContext).focus();
                }
            }

            // This is the callback function called if the
            // Web service failed. It accepts the error object
            // as a parameter.
            function FailedCallback(error) {
                if (error) {
                    alert(error.get_message());
                }
                else
                    alert("An unexpeceted error occurred");
            }

            //This the function to show the three DropDownLists'selection
            function DisplayResult() {
                $get("aResult").innerHTML = "You have selected a " +
                    $get("ddlMake")[$get("ddlMake").selectedIndex].text + "," +
                    $get("ddlModel")[$get("ddlModel").selectedIndex].text + "," +
                    $get("ddlColor")[$get("ddlColor").selectedIndex].text + " car!";
            }
            
        </script>--%>
        
        <div>
            wybierz miejscowość</div>
        <asp:DropDownList ID="DdlChoseCity" runat="server"   AutoPostBack="True" OnSelectedIndexChanged="DdlChoseCity_SelectedIndexChanged" >
           <%-- %> DataTextField="CityName" DataValueField="id"--%>
            <asp:ListItem Enabled="False"></asp:ListItem>
        </asp:DropDownList>
        <p>
            wybierz JNI</p>
        <p>
            &nbsp;</p>
        <asp:DropDownList ID="DdlChoseJni" runat="server" AutoPostBack="True"  ValidateRequestMode="Enabled" Width="103px" DataTextField="jni" DataValueField="jni" OnSelectedIndexChanged="DdlChoseJni_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
   
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" >
        </asp:GridView>
    </form>
</body>
</html>
