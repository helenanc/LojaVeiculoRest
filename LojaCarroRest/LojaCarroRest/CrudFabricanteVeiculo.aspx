<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrudFabricanteVeiculo.aspx.cs" Inherits="LojaCarroRest.CrudFabricantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblFab" runat="server" Text="CRUD Fabricante" Font-Size="Larger"></asp:Label>
        <table style="width:100%;">
            <tr>
                <td>Id</td>
                <td>
        <asp:TextBox ID="txtFabId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Descrição</td>
                <td>                    
        <asp:TextBox ID="txtFabDesc" runat="server"></asp:TextBox>
                </td>
            </tr>
            </table>
        <br />
        <asp:Button ID="btnFabInsert" runat="server" Text="Inserir" />
        <asp:Button ID="btnFabUpdate" runat="server" Text="Atualizar" />
        <asp:Button ID="btnFabDelete" runat="server" Text="Deletar" />
        <asp:Button ID="btnFabList" runat="server" Text="Listar" />    
        <br />
        <br />
        <asp:ListView ID="listViewFab" runat="server">
        </asp:ListView>
        <br />
        <hr />
        <br />
        <br />
        <asp:Label ID="lblVeiculo" runat="server" Text="CRUD Veículo" Font-Size="Larger"></asp:Label>
        <table style="width:100%;">
            <tr>
                <td>Id</td>
                <td>
        <asp:TextBox ID="txtVeicId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Modelo</td>
                <td>                    
        <asp:TextBox ID="txtVeicModelo" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>Ano</td>
                <td>                    
        <asp:TextBox ID="txtVeic" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>Fabricante</td>
                <td> 
        <asp:DropDownList ID="dropdownFab" runat="server"></asp:DropDownList> 
                </td>
            </tr>
             <tr>
                <td>Data Compra</td>
                <td>                    
        <asp:TextBox ID="txtVeicDataCompra" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>Valor Compra</td>
                <td>                    
        <asp:TextBox ID="txtVeicValorCompra" runat="server"></asp:TextBox>
                </td>
            </tr>
              <tr>
                <td>Preço Venda</td>
                <td>                    
        <asp:TextBox ID="txtVeicPrecoVenda" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>Data Venda</td>
                <td>                    
        <asp:TextBox ID="txtVeicDataVenda" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Valor Venda</td>
                <td>                    
        <asp:TextBox ID="txtVeicValorVenda" runat="server"></asp:TextBox>
                </td>
            </tr>

            </table>
        <br />
        <asp:Button ID="btnVeicInsert" runat="server" Text="Inserir" />
        <asp:Button ID="btnVeicUpdate" runat="server" Text="Atualizar" />
        <asp:Button ID="btnVeicDelete" runat="server" Text="Deletar" />
        <asp:Button ID="btnVeicList" runat="server" Text="Listar" />
        <br />
        <asp:ListView ID="listViewVeic" runat="server" OnSelectedIndexChanged="ListView2_SelectedIndexChanged">
        </asp:ListView>
    </div>
    </form>
</body>
</html>
