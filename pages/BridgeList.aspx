<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BridgeList.aspx.cs" Inherits="WebApplication1.pages.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p id="GRID">
    <asp:Button ID="BtnAdd" runat="server" Text="add" OnClick="BtnAdd_Click" PostBackUrl="~/pages/BridgeAdding.aspx" />
    <asp:Button ID="BtnEditing" runat="server" OnClick="Button3_Click" PostBackUrl="~/pages/editing.aspx" Text="editing" />
    <asp:GridView ID="GV1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" style="margin-right: 951px" Width="98%" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                             <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="jni" HeaderText="jni" SortExpression="jni" />
                <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                <asp:BoundField DataField="CityName" HeaderText="CityName" SortExpression="CityName" />
                <asp:BoundField DataField="length" HeaderText="length" SortExpression="length" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bridgeConnectionString %>" OnSelecting="SqlDataSource1_Selecting" SelectCommand="SELECT l.id, l.jni,
		l.city,
		r.[CityName],
		l.[length]
		FROM [Bridge] l
		JOIN [city] r
		ON l.city=r.id;" 
            ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [Bridge] WHERE [id] = @original_id AND (([jni] = @original_jni) OR ([jni] IS NULL AND @original_jni IS NULL)) AND (([city] = @original_city) OR ([city] IS NULL AND @original_city IS NULL)) AND (([length] = @original_length) OR ([length] IS NULL AND @original_length IS NULL))" InsertCommand="INSERT INTO [Bridge] ([jni], [city], [length]) VALUES (@jni, @city, @length)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [Bridge] SET [jni] = @jni, [city] = @city, [length] = @length WHERE [id] = @original_id AND (([jni] = @original_jni) OR ([jni] IS NULL AND @original_jni IS NULL)) AND (([city] = @original_city) OR ([city] IS NULL AND @original_city IS NULL)) AND (([length] = @original_length) OR ([length] IS NULL AND @original_length IS NULL))">
   <%--DeleteCommand="DELETE FROM [Bridge] WHERE [id] = @original_id AND (([jni] = @original_jni) OR ([jni] IS NULL AND @original_jni IS NULL)) AND (([city] = @original_city) OR ([city] IS NULL AND @original_city IS NULL)) AND (([length] = @original_length) OR ([length] IS NULL AND @original_length IS NULL))"--%>
            <DeleteParameters>
                <asp:Parameter Name="original_id" Type="Int32" />
                <asp:Parameter Name="original_jni" Type="Int32" />
                <asp:Parameter Name="original_city" Type="Int32" />
                <asp:Parameter Name="original_length" Type="Double" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="jni" Type="Int32" />
                <asp:Parameter Name="city" Type="Int32" />
                <asp:Parameter Name="length" Type="Double" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="jni" Type="Int32" />
                <asp:Parameter Name="city" Type="Int32" />
                <asp:Parameter Name="length" Type="Double" />
                <asp:Parameter Name="original_id" Type="Int32" />
                <asp:Parameter Name="original_jni" Type="Int32" />
                <asp:Parameter Name="original_city" Type="Int32" />
                <asp:Parameter Name="original_length" Type="Double" />
            </UpdateParameters>
    </asp:SqlDataSource>
      
    </p>
</asp:Content>
