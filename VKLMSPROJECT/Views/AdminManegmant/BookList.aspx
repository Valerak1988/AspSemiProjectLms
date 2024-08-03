<%@ Page Title="" Language="C#" MasterPageFile="~/Views/AdminManegmant/BackAdmin.Master" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="VKLMSPROJECT.Views.AdminManegmant.BookList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="assets/vendor/datatables/dataTables.bs5.css" />
    <link rel="stylesheet" href="assets/vendor/datatables/dataTables.bs5-custom.css" />
    <style>
    #MainTbl th, #MainTbl td {
        white-space: nowrap;
        max-width: 150px; 
        overflow: hidden;
        text-overflow: ellipsis;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">

    <div class="card">
        <div class="card-header">
            <div class="card-title">List Of Books</div>
        </div>
        <div class="card-body">
            <div class="table-responsive">
                <table id="MainTbl" class="table custom-table">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Title</th>
                            <th>Author</th>
                            <th>Description</th>
                            <th>Cover</th>
                            <th>Category</th>
                            <th>ISBN</th>
                            <th>Quantity</th>
                            <th>Copies In Stock</th>
                            <th>Max Loan Days</th>
                            <th>Add Date</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="RptBook" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("BookID") %></td>
                                    <td><%#Eval("Title") %></td>
                                    <td><%#Eval("Author") %></td>
                                    <td><%#Eval("Description") %></td>
                                    <td class="center">
                                        <img src="/Uploads/Book/<%#Eval("PicName") %>" width="50"></td>
                                    <td><%#Eval("CategoryName") %></td>
                                    <td><%#Eval("ISBN") %></td>
                                    <td><%#Eval("Quantity") %></td>
                                    <td><%#Eval("CopiesInStock") %></td>
                                    <td><%#Eval("MaxLoanDays") %></td>
                                    <td><%#Eval("AddDate") %></td>
                                    <td class=" center"><a href="BookAddEdit.aspx?BookID=<%#Eval("BookID") %>" style="text-decoration: underline; color: blue;">Update<span class="bi bi-pencil-fill"></span></a></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
    <!-- Data Tables -->
    <script src="assets/vendor/datatables/dataTables.min.js"></script>
    <script src="assets/vendor/datatables/dataTables.bootstrap.min.js"></script>

    <!-- Custom Data tables -->
    <script src="assets/vendor/datatables/custom/custom-datatables.js"></script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooter" runat="server">
</asp:Content>

