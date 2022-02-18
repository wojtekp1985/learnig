<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.pages.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Podaj jni</div>
        <p>
            <asp:TextBox ID="TxtJni" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            wybierz miasto</p>
        <asp:DropDownList ID="DdlCity" runat="server" DataSourceID="SqlDataSource1" DataTextField="CityName" DataValueField="CityName">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bridgeConnectionString2 %>" OnSelecting="SqlDataSource1_Selecting" SelectCommand="SELECT [CityName] FROM [city]"></asp:SqlDataSource>
        <br />
        podaj długość<br />
        <asp:TextBox ID="TxtLength" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="BtnSbt" runat="server" OnClick="BtnSbt_Click" Text="submit" />
        <br />
    </form>
</body>
</html>
