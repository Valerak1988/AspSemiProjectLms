<%@ Page Title="" Language="C#" MasterPageFile="~/Views/AdminManegmant/BackAdmin.Master" AutoEventWireup="true" CodeBehind="LoanAddEdit.aspx.cs" Inherits="VKLMSPROJECT.Views.AdminManegmant.LoanAddEdit" %>

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
                                <asp:HiddenField ID="HidLoanID" runat="server" Value="-1" />                                
                                <asp:HiddenField ID="HidBookID" runat="server" />
                                <label for="DDLClientID" class="form-label">Client ID</label>
                                <asp:DropDownList ID="DDLClientID" runat="server" class="form-control" OnChange="updateEmailFromClientID()" />
                            </div>
                        </div>
                        
                        <div class="col-xl-6 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="DDLEmail" class="form-label">Client Email</label>
                                <asp:DropDownList ID="DDLEmail" runat="server" class="form-control" OnChange="updateClientIDFromEmail()" />
                            </div>
                        </div>
                        <div class="col-xl-6 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="DDLBookID" class="form-label">Book ID</label>
                                <asp:DropDownList ID="DDLBookID" runat="server" class="form-control" OnChange="updateBookNameFromBookID()"/>
                            </div>
                        </div>
                        <div class="col-xl-6 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="DDLBookName" class="form-label">Title</label>
                                <asp:DropDownList ID="DDLBookName" runat="server" class="form-control" OnChange="updateBookIDFromBookName()" />
                            </div>
                        </div>

                        <div class="col-xl-6 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="TxtLoanDate" class="form-label">Loan Date</label>
                                <asp:TextBox ID="TxtLoanDate" runat="server" class="form-control" TextMode="Date" />
                            </div>
                        </div>
                        <div class="col-xl-6 col-sm-4 col-12">
                            <div class="mb-3">
                                <label for="TxtActualReturnDate" class="form-label">Actual Return Date</label>
                                <asp:TextBox ID="TxtActualReturnDate" runat="server" class="form-control" TextMode="Date" />
                            </div>
                        </div>
                    </div>
                    <!-- Row end -->

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
    <script type="text/javascript">
        function updateClientIDFromEmail() {
            var selectedEmail = document.getElementById('<%= DDLEmail.ClientID %>').value;
        var clientIDDropdown = document.getElementById('<%= DDLClientID.ClientID %>');
            for (var i = 0; i < clientIDDropdown.options.length; i++) {
                if (clientIDDropdown.options[i].text === selectedEmail) {
                    clientIDDropdown.selectedIndex = i;
                    break;
                }
            }
        }

        function updateEmailFromClientID() {
            var selectedClientID = document.getElementById('<%= DDLClientID.ClientID %>').value;
        var emailDropdown = document.getElementById('<%= DDLEmail.ClientID %>');
        for (var i = 0; i < emailDropdown.options.length; i++) {
            if (emailDropdown.options[i].value === selectedClientID) {
                emailDropdown.selectedIndex = i;
                break;
            }
        }
    }

    function updateBookNameFromBookID() {
        var selectedBookID = document.getElementById('<%= DDLBookID.ClientID %>').value;
        var bookNameDropdown = document.getElementById('<%= DDLBookName.ClientID %>');
        for (var i = 0; i < bookNameDropdown.options.length; i++) {
            if (bookNameDropdown.options[i].value === selectedBookID) {
                bookNameDropdown.selectedIndex = i;
                break;
            }
        }
    }

    function updateBookIDFromBookName() {
        var selectedBookName = document.getElementById('<%= DDLBookName.ClientID %>').value;
        var bookIDDropdown = document.getElementById('<%= DDLBookID.ClientID %>');
            for (var i = 0; i < bookIDDropdown.options.length; i++) {
                if (bookIDDropdown.options[i].value === selectedBookName) {
                    bookIDDropdown.selectedIndex = i;
                    break;
                }
            }
        }
    </script>
</asp:Content>