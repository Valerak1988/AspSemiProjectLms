<%@ Page Title="" Language="C#" MasterPageFile="~/Views/AdminManegmant/BackAdmin.Master" AutoEventWireup="true" CodeBehind="ClientAddEdit.aspx.cs" Inherits="VKLMSPROJECT.Views.AdminManegmant.ClientAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="row gx-3">
        <div class="col-sm-12 col-12">
            <!-- Card start -->
            <div class="card">
                <div class="card-header">
                    <div class="card-title">Add/Update Client</div>
                </div>
                <div class="card-body">
                    <!-- Row start -->
                    <div class="row gx-3">
                        <div class="col-xl-4 col-sm-4 col-12">
                            <div class="mb-3">
                                <asp:HiddenField ID="HidClientID" runat="server" Value="-1" />
                                <label for="TxtFirstName" class="form-label">First Name</label>
                                <asp:TextBox ID="TxtFirstName" runat="server" class="form-control" placeholder="Enter First Name" />
                            </div>
                        </div>
                        <div class="col-xl-4 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="TxtLastName" class="form-label">Last Name</label>
                                <asp:TextBox ID="TxtLastName" runat="server" class="form-control" placeholder="Enter Last Name" />
                            </div>
                        </div>
                        <div class="col-xl-4 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="TxtID" class="form-label">ID</label>
                                <asp:TextBox ID="TxtID" runat="server" class="form-control" placeholder="Enter ID" />
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
                                <label for="DDLCity" class="form-label">City</label>
                                <asp:DropDownList ID="DDLCity" class="form-control" runat="server" />
                            </div>
                        </div>
                        <div class="col-xl-4 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="TxtPhone" class="form-label">Phone</label>
                                <asp:TextBox ID="TxtPhone" runat="server" class="form-control" placeholder="Enter Phone" />
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
                    <div class="col-xl-4 col-sm-4 col-12">
                        <div class="mb-3">
                            <label for="DDLStatus" class="form-label">Status</label>
                            <asp:DropDownList ID="DDLStatus" runat="server" class="form-control" />
                        </div>
                    </div>
                    <div class="col-xl-6 col-sm-4 col-12">
                        <div class="mb-3">
                            <label for="TxtDateOfBirth" class="form-label">Date Of Birth</label>
                            <asp:TextBox ID="TxtDateOfBirth" runat="server" class="form-control" TextMode="Date" />
                        </div>
                    </div>
                    <div class="col-xl-6 col-sm-4 col-12">
                        <div class="mb-3">
                            <label for="TxtSubscriptionEndDate" class="form-label">Subscription End Date</label>
                            <asp:TextBox ID="TxtSubscriptionEndDate" runat="server" class="form-control" TextMode="Date" />
                        </div>
                    </div>
                    <div class="col-xl-4 col-sm-4 col-12">

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

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooter" runat="server">
</asp:Content>
