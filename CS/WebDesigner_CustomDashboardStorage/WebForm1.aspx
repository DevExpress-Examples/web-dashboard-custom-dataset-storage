﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" 
         Inherits="WebDesigner_CustomDashboardStorage.WebForm1" %>

<%@ Register Assembly="DevExpress.Dashboard.v16.1.Web, Version=16.1.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position:absolute; left:0; right:0; top:0; bottom:0;">
        <dx:ASPxDashboardDesigner ID="ASPxDashboardDesigner1" runat="server" AllowExportDashboard="True" 
            Height="100%" Width="100%">
        </dx:ASPxDashboardDesigner>
    </div>
    </form>
</body>
</html>
