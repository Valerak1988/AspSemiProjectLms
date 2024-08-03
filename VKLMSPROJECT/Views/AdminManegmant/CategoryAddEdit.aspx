﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/AdminManegmant/BackAdmin.Master" AutoEventWireup="true" CodeBehind="CategoryAddEdit.aspx.cs" Inherits="VKLMSPROJECT.Views.AdminManegmant.CategoryAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
     <div class="row gx-3">
     <div class="col-sm-12 col-12">
         <!-- Card start -->
         <div class="card">
             <div class="card-header">
                 <div class="card-title">Add/Update Category</div>
             </div>
             <div class="card-body">
                 <!-- Row start -->
                 <div class="row gx-3">
                     <div class="col-xl-12 col-sm-4 col-12">
                         <div class="mb-3">
                             <asp:HiddenField ID="HidCategoryID" runat="server" Value="-1" />
                             <label for="TxtCategoryName" class="form-label">Category Name</label>
                             <asp:TextBox ID="TxtCategoryName" runat="server" class="form-control" placeholder="Enter Category Name" />
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
                             <label class="form-label">Category Image</label>
                             <asp:FileUpload ID="UploadPic" class="form-control" runat="server" />
                         </div>
                     </div>
                 </div>
                 <!-- Image Panel start -->
                 <asp:Panel ID="ImgPnl" runat="server">
                     <div class="row">
                         <div class="col-12 clearfix">
                             <div class="mb-3 text-center">
                                 <asp:Image ID="CatgoryImg" CssClass="img-fluid" runat="server" Width="200" Height="175" />
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