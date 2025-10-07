<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Earth.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
        height: 23px;
    }
    .auto-style2 {
        width: 269px;
    }
    .auto-style3 {
        height: 23px;
        width: 269px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login</h1>


    <table class="tblLogin">
        <tr>
            <td class="auto-style2">Username</td>
            <td>
                <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td class="auto-style2">Password</td>
            <td>
                <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td class="auto-style3">Re-type Password</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtPass2" runat="server"></asp:TextBox>
            </td>

        </tr>
            <tr>
            <td class="auto-style2">
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                </td>
            <td>
                <asp:Label ID="lblDisplay" runat="server" ForeColor="#FF3300"></asp:Label>
                </td>

        </tr>
    </table>
</asp:Content>
