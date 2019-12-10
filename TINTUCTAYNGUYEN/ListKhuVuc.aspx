<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListKhuVuc.aspx.cs" Inherits="TINTUCTAYNGUYEN.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="bookDetail" runat="server"
        ItemType="TINTUCTAYNGUYEN.Models.KhuVuc" SelectMethod ="GetListKhuVuc"
         RenderOuterTable="false">
         <ItemTemplate>
         <div>
         <h1><%#:Item.TenKhuVuc %></h1>
         </div>
         <br />
         <table>
         <tr>
         <td>
         <img src="/Images/<%#:Item.HinhAnh %>"
         style="border:solid; height:225px" alt="<%#:Item.TenKhuVuc %>"/>
         </td>
         <td>&nbsp;</td>
         <td style="vertical-align: top; text-align:left;">
         <b>Miêu Tả:</b><br /><%#:Item.MieuTa %>
         <br />
         <span><b>Giá CAFE:</b>&nbsp;<%#: String.Format("{0:c}",Item.Gia)
        %></span>
         <br />
         <span><b>STT:</b>&nbsp;<%#:Item.KhuVucID %></span>
         <br />
         </td>
         </tr>
         </table>
         </ItemTemplate>
         </asp:FormView>
</asp:Content>
