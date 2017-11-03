<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SendNewsLetter.default"%>  
  
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title></title>  
</head>  
<body>  
    <form id="form1" runat="server">  
    <div>  
    <asp:Button ID="btnSendEmail" runat="server" OnClick="sendEmail_Click" Text="Send Email to Subscribers"/>    
    
<asp:Literal ID="ltlResult" runat="server" Visible="false"></asp:Literal>    
    </div>  
    </form>  
</body>  
</html>  
