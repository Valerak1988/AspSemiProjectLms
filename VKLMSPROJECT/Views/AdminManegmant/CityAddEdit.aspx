<%@ Page Title="" Language="C#" MasterPageFile="~/Views/AdminManegmant/BackAdmin.Master" AutoEventWireup="true" CodeBehind="CityAddEdit.aspx.cs" Inherits="VKLMSPROJECT.Views.AdminManegmant.CityAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
        <div class="row gx-3">
    <div class="col-sm-12 col-12">
        <!-- Card start -->
        <div class="card">
            <div class="card-header">
                <div class="card-title">Add/Update City</div>
            </div>
            <div class="card-body">
                <!-- Row start -->
                <div class="row gx-3">
                    <div class="col-xl-12 col-sm-4 col-12">
                        <div class="mb-3">
                            <asp:HiddenField ID="HidCityID" runat="server" Value="-1" />
                            <label for="TxtCityName" class="form-label">Title</label>
                            <asp:TextBox ID="TxtCityName" runat="server" class="form-control" placeholder="Enter City Name" />
                        </div>
                    </div>
                </div>

                <!-- Form actions footer start -->
                <div class="form-actions-footer">
                    <asp:Button ID="BtnDelete" runat="server" class="btn btn-danger" OnClick="BtnDelete_Click" Text="Delete" />
                    <asp:Button ID="BtnSave" runat="server" class="btn btn-success" OnClick="BtnSave_Click" Text="Update" />
                </div>
                <!-- Form actions footer end -->
            </div>
        </div>
        <!-- Card end -->
    </div>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooter" runat="server">
</asp:Content>
