<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ShowUser.aspx.cs" Inherits="Earth.ShowUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 246px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>All Users</h1>
    <br /><br />
    <table class="tblLogin">
        <thead class="tth">
            <tr>
                <td>Number </td>
                <td>UserName </td>
                <td>Password </td>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="rtpInfo" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("LoginId") %> </td>
                        <td><%# Eval("UserName") %> </td>
                        <td><%# Eval("Password") %> </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <p>&nbsp;</p>
</asp:Content>
