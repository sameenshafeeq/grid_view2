<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="task02_state_mangemnt.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
      <asp:TextBox ID="search_box" runat="server" placeholder="Enter the name of the Staff to search!!"></asp:TextBox>
      <asp:Button runat="server" ID="search_button" Text="Seach" onClick="search_button_Click1"/><br />
      <asp:GridView ID="STAFFGRIDDATA" AutoGenerateColumns="false" runat="server" BackColor="White" BorderColor="#E7E7FF"
      BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Calibri" Font-Size="Larger" OnRowDeleting="GV_RowDeleting" OnRowEditing="GV_RowEditing" OnRowCancelingEdit="TaskGridView_RowCancelingEdit" OnRowUpdating="STAFFGRIDDATA_RowUpdating"
               AllowPaging="true" OnPageIndexChanging="STAFFGRIDDATA_PageIndexChanging">
          <AlternatingRowStyle BackColor="#F7F7F7" />
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
          <Columns>
              <asp:BoundField  DataField="StaffID" HeaderText="ID" />
	          <asp:BoundField  DataField="StaffName" HeaderText="Name" />
              <asp:BoundField  DataField="StaffRole" HeaderText="Job Role" />
            
              <asp:CommandField ShowEditButton="true" />  
              <asp:CommandField ShowDeleteButton="true" />
          </Columns>
           </asp:GridView> 
        <asp:Label ID="Output_label" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
