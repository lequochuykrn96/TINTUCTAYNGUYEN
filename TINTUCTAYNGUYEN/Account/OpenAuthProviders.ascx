<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OpenAuthProviders.ascx.cs" Inherits="TINTUCTAYNGUYEN.Account.OpenAuthProviders" %>

<div id="socialLoginList">
    <h4>Sử dụng dịch vụ khác để đăng nhập</h4>
    <hr />
    <asp:ListView runat="server" ID="providerDetails" ItemType="System.String"
        SelectMethod="GetProviderNames" ViewStateMode="Disabled">
        <ItemTemplate>
            <p>
                <button type="submit" class="btn btn-default" name="provider" value="<%#: Item %>"
                    title="Log in using your <%#: Item %> account.">
                    <%#: Item %>
                </button>
            </p>
        </ItemTemplate>
        <EmptyDataTemplate>
            <div>
                <p>Sử dụng dịch vụ khác để đăng nhập</p>
            </div>
        </EmptyDataTemplate>
    </asp:ListView>
</div>
