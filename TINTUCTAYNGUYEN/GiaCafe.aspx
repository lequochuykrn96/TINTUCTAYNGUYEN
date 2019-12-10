<%@ Page Title="Giá Cafe" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GiaCafe.aspx.cs" Inherits="TINTUCTAYNGUYEN.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
         <div>
         <hgroup>
         <h2 style="text-align:center">BÁO GIÁ CAFE</h2>
         </hgroup>
         <asp:ListView ID="GiaCafe" runat="server" DataKeyNames="KhuVucID"
        GroupItemCount="4"
         ItemType="TINTUCTAYNGUYEN.Models.KhuVuc" SelectMethod="GetKhuVucs">
         <EmptyDataTemplate>
         <table >
         <tr>
         <td>No data was returned.</td>
         </tr>
         </table>
         </EmptyDataTemplate>
         <EmptyItemTemplate>
         <td/>
         </EmptyItemTemplate>
         <GroupTemplate>
         <tr id="itemPlaceholderContainer" runat="server">
         <td id="itemPlaceholder" runat="server"></td>
         </tr>
         </GroupTemplate>
         <ItemTemplate>
         <td runat="server">
         <table>
         <tr>
         <td>
         <a href="ListKhuVuc.aspx?KhuVucID=<%#:Item.KhuVucID%>">
         <img src ="/Images/<%#:Item.HinhAnh%>"
         width="150" height="225" style="border:solid" /></a>
         </td>
         </tr>
         <tr>
         <td>
         <a href="ListKhuVuc.aspx?KhuVucID=<%#:Item.KhuVucID%>">
         <span>
         <%#:Item.TenKhuVuc%>
         </span>
         </a>
         <br />
         <span>
         <b>Giá Cafe: </b><%#:String.Format("{0:c}",Item.Gia)%>
         </span>
         <br />
             <%--<a href="AddToCart.aspx?bookID=<%#:Item.KhuVucID%>">
             <span>
             <b>Add To Cart<b>
             </span>
             </a>--%>
         </td>
         </tr>
         <tr>
         <td>&nbsp;</td>
         </tr>
         </table>
         </p>
         </td>
         </ItemTemplate>
         <LayoutTemplate>
         <table style="width:100%;">
         <tbody>
         <tr>
         <td>
         <table id="groupPlaceholderContainer" runat="server"
        style="width:100%">
         <tr id="groupPlaceholder"></tr>
         </table>
         </td>
         </tr>
         <tr>
         <td></td>
         </tr>
         <tr></tr>
         </tbody>
         </table>
         </LayoutTemplate>
         </asp:ListView>
         </div>
         </section>
</asp:Content>
