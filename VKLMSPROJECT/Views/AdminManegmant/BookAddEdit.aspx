<%@ Page Title="" Language="C#" MasterPageFile="~/Views/AdminManegmant/BackAdmin.Master" AutoEventWireup="true" CodeBehind="BookAddEdit.aspx.cs" Inherits="VKLMSPROJECT.Views.AdminManegmant.BookAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="row gx-3">
        <div class="col-sm-12 col-12">
            <!-- Card start -->
            <div class="card">
                <div class="card-header">
                    <div class="card-title">Add/Update Book</div>
                </div>
                <div class="card-body">
                    <!-- Row start -->
                    <div class="row gx-3">
                        <div class="col-xl-6 col-sm-4 col-12">
                            <div class="mb-3">
                                <asp:HiddenField ID="HidBookID" runat="server" Value="-1" />
                                <label for="TxtTitle" class="form-label">Title</label>
                                <asp:TextBox ID="TxtTitle" runat="server" class="form-control" placeholder="Enter Title" />
                            </div>
                        </div>
                        <div class="col-xl-6 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="TxtAuthor" class="form-label">Author</label>
                                <asp:TextBox ID="TxtAuthor" runat="server" class="form-control" placeholder="Enter Author" />
                            </div>
                        </div>
                        <div class="col-xl-12 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="TxtDescription" class="form-label">Description</label>
                                <asp:TextBox ID="TxtDescription" runat="server" class="form-control" TextMode="MultiLine" Rows="5" Columns="40" placeholder="Enter Description" />
                            </div>
                        </div>
                        <div class="col-xl-4 col-sm-4 col-12">
                            <div class="mb-3">
                                <label class="form-label">Cover Image</label>
                                <asp:FileUpload ID="UploadPic" class="form-control" runat="server" />
                            </div>
                        </div>
                        <div class="col-xl-4 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="DDLCategory" class="form-label">Category</label>
                                <asp:DropDownList ID="DDLCategory" runat="server" class="form-control" />
                            </div>
                        </div>
                        <div class="col-xl-4 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="TxtISBN" class="form-label">ISBN</label>
                                <asp:TextBox ID="TxtISBN" runat="server" class="form-control" placeholder="Enter ISBN" />
                            </div>
                        </div>
                        <div class="col-xl-4 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="TxtQuantity" class="form-label">Quantity</label>
                                <asp:TextBox ID="TxtQuantity" runat="server" class="form-control"  placeholder="Enter Quantity" />
                            </div>
                        </div>
                        <div class="col-xl-4 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="TxtCopiesInStock" class="form-label">Copies In Stock</label>
                                <asp:TextBox ID="TxtCopiesInStock" runat="server" class="form-control"  placeholder="Enter Copies In Stock" />
                            </div>
                        </div>
                        <div class="col-xl-4 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="TxtMaxLoanDays" class="form-label">MaxLoanDays</label>
                                <asp:TextBox ID="TxtMaxLoanDays" runat="server" class="form-control"  placeholder="Enter Max Loan Days" />
                            </div>
                        </div>
                    </div>
                    <!-- Row end -->

                    <!-- Image Panel start -->
                    <asp:Panel ID="ImgPnl" runat="server">
                        <div class="row">
                            <div class="col-12 clearfix">
                                <div class="mb-3 text-center">
                                    <asp:Image ID="CoverImg" CssClass="img-fluid" runat="server" Width="200" Height="175" />
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
