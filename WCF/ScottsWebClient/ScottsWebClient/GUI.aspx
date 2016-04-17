<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GUI.aspx.cs" Inherits="ScottsWebClient.GUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div style="font-family: Arial">

            <asp:TextBox ID="TxtBox_EnterMessage" runat="server">
            </asp:TextBox>

            <asp:Button ID="Btn_GetMessage" runat="server" Text="Get Message" OnClick="Btn_GetMessage_Click" />

            <p></p>

            <asp:Label ID="Lbl_DspMessage" runat="server" Font-Bold="true"></asp:Label>

        </div>

        <p></p>

        <div id="DspMoneyResults" style="font-family: Arial">

            <table>
                <tr>
                    <td>Salary:</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TxtBox_EnterSalary" runat="server" Width="250">
                        </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Hours Worked Per Week:</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TxtBox_EnterHoursWorked" runat="server" Width="250">
                        </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Btn_GetMoney" runat="server" Text="Get Money" OnClick="Btn_GetMoney_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LblDspMoney" runat="server" Font-Bold="true"></asp:Label>
                    </td>
                </tr>
            </table>

        </div>

    </form>
</body>
</html>
