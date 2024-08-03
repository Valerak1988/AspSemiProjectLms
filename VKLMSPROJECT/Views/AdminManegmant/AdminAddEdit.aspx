<%@ Page Title="" Language="C#" MasterPageFile="~/Views/AdminManegmant/BackAdmin.Master" AutoEventWireup="true" CodeBehind="AdminAddEdit.aspx.cs" Inherits="VKLMSPROJECT.Views.AdminManegmant.AdminAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="row gx-3">
        <div class="col-sm-12 col-12">
            <!-- Card start -->
            <div class="card">
                <div class="card-header">
                    <div class="card-title">Add/Update Admin</div>
                </div>
                <div class="card-body">
                    <!-- Row start -->
                    <div class="row gx-3">
                        <div class="col-xl-4 col-sm-4 col-12">
                            <div class="mb-3">
                                <asp:HiddenField ID="HidAdminID" runat="server" Value="-1" />
                                <label for="TxtAdminName" class="form-label">Name</label>
                                <asp:TextBox ID="TxtAdminName" runat="server" class="form-control" placeholder="Enter Name" />
                            </div>
                        </div>
                        <div class="col-xl-4 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="TxtAdminLastName" class="form-label">Last Name</label>
                                <asp:TextBox ID="TxtAdminLastName" runat="server" class="form-control" placeholder="Enter Last Name" />
                            </div>
                        </div>
                        <div class="col-xl-4 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="TxtRole" class="form-label">Role</label>
                                <asp:TextBox ID="TxtRole" runat="server" class="form-control" placeholder="Enter Role" />
                            </div>
                        </div>
                        <div class="col-xl-4 col-sm-4 col-12">
                            <div class="mb-3">
                                <label class="form-label">Profile Image</label>
                                <asp:FileUpload ID="UploadPic" class="form-control" runat="server" />
                            </div>
                        </div>
                        <div class="col-xl-4 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="TxtEmail" class="form-label">Email</label>
                                <asp:TextBox ID="TxtEmail" runat="server" class="form-control" placeholder="Enter Email" />
                            </div>
                        </div>
                        <div class="col-xl-4 col-sm-4 col-12">
                            <asp:Panel ID="PassPnl" runat="server">
                                <div class="mb-3">
                                    <label for="TxtPassword" class="form-label">Password</label>
                                    <asp:TextBox ID="TxtPassword" runat="server" class="form-control" TextMode="Password" placeholder="Enter Password" />
                                </div>
                            </asp:Panel>
                        </div>
                    </div>
                    <!-- Row end -->

                    <!-- Image Panel start -->
                    <asp:Panel ID="ImgPnl" runat="server">
                        <div class="row">
                            <div class="col-12 clearfix">
                                <div class="mb-3 text-center">
                                    <asp:Image ID="ProfileImg" CssClass="img-fluid" runat="server" Width="200" Height="175" />
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                    <!-- Image Panel end -->

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
