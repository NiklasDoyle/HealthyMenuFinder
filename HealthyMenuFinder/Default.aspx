<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HealthyMenuFinder.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Healthy Menu Maker</div>
        <p>
            Need to find a something to eat after the gym? Look in your fridge and we&#39;ll tell you what you can make!</p>
        <p>
            Type in an ingrediate and click add!</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="AddBtn" runat="server" OnClick="AddBtn_Click" Text="Add" />
        </p>
        <p>
            What kind of meal are you looking for?</p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="100px" OnClick="Button1_Click" Text="Calories" Width="100px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Height="100px" OnClick="Button2_Click" Text="Protein" Width="100px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Height="100px" OnClick="Button3_Click" Text="Both" Width="100px" />
        </p>
        <p>
            Ingredients available:</p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Height="257px" ReadOnly="True" TextMode="MultiLine" Width="309px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
