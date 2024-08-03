<%@ Page Title="" Language="C#" MasterPageFile="~/Views/AdminManegmant/BackAdmin.Master" AutoEventWireup="true" CodeBehind="CategoryList.aspx.cs" Inherits="VKLMSPROJECT.Views.AdminManegmant.CategoryList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="assets/vendor/datatables/dataTables.bs5.css" />
    <link rel="stylesheet" href="assets/vendor/datatables/dataTables.bs5-custom.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="card">
        <div class="card-header">
            <div class="card-title">List Of Categories</div>
        </div>
        <div class="card-body">
            <div class="table-responsive">
                <table id="MainTbl" class="table custom-table">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Category name</th>
                            <th>Description</th>
                            <th>Image</th>
                            <th>Add Date</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="RptCategory" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("CategoryID") %></td>
                                    <td><%#Eval("CategoryName") %></td>
                                    <td><%#Eval("Description") %></td>
                                    <td class="center">
                                        <img src="/Uploads/Category/<%#Eval("PicName") %>" width="100" hight="50"></td>
                                    <td><%#Eval("AddDate") %></td>
                                    <td class=" center"><a href="CategoryAddEdit.aspx?CategoryID=<%#Eval("CategoryID") %>" style="text-decoration: underline; color: blue;">Update<span class="bi bi-pencil-fill"></span></a></td>
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

