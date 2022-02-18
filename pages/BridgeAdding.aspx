<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BridgeAdding.aspx.cs" Inherits="WebApplication1.pages.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Podaj jni<br />
            <br />
            <asp:TextBox ID="TxtJni" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div>
        <p>
            wybierz miasto</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:DropDownList ID="DdlCity" runat="server" DataSourceID="SqlDataSource1" DataTextField="CityName" DataValueField="CityName" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bridgeConnectionString4 %>" SelectCommand="SELECT DISTINCT [CityName] FROM [city]"></asp:SqlDataSource>
        </p>
        <br />
        podaj długość<br />
        <br />
        <asp:Button ID="BtnSbt" runat="server" OnClick="BtnSbt_Click" Text="submit" style="margin-bottom: 11px" />
        <br />
        <asp:TextBox ID="TxtLength" runat="server"></asp:TextBox>
    </form>
</body>
</html>
