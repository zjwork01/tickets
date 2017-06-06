<%@ Page Language="c#" CodeBehind="main.aspx.cs" AutoEventWireup="false" Inherits="tickets.WebForm2" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>列车售票系统</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
    <meta name="CODE_LANGUAGE" content="C#">
    <meta name="vs_defaultClientScript" content="JavaScript">
    <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
</head>
<body ms_positioning="GridLayout" bgcolor="#99cc00" background="file:///C:\Inetpub\wwwroot\images\bg.gif">
    <div align="center">
        <form id="Form1" method="post" runat="server">
        <table id="Table1" style="z-index: 101; border-left-color: #66cc00; left: 136px;
            border-bottom-color: #669900; width: 624px; border-top-style: inset; border-top-color: #669900;
            border-right-style: outset; border-left-style: outset; position: absolute; top: 40px;
            height: 429px; border-right-color: #66cc00; border-bottom-style: inset" cellspacing="1"
            cellpadding="1" width="624" border="1">
            <tr>
                <td style="height: 89px">
                    <font face="宋体">
                        <p align="center">
                            <font face="华文中宋" size="7">
                                <asp:Image ID="Image2" runat="server" Height="96px" Width="655px" ImageUrl="/images\biaoti.gif"
                                    BackColor="White"></asp:Image></font>
                        </p>
                    </font>
                </td>
            </tr>
            <tr>
                <td style="height: 30px">
                    <font face="宋体">
                        <table id="Table2" style="width: 659px; height: 30px" cellspacing="0" cellpadding="0"
                            width="659" border="0" runat="server">
                            <tr>
                                <td style="width: 115px">
                                    <asp:Button ID="Button_maipiao" runat="server" Text="买票" Width="133px" Height="27px"
                                        TabIndex="1"></asp:Button>
                                </td>
                                <td>
                                    <asp:Button ID="Button_dingpiao" runat="server" Text="订票" Width="120px" Height="27px"
                                        TabIndex="2"></asp:Button>
                                </td>
                                <td style="width: 139px">
                                    <asp:Button ID="Button_tuipiao" runat="server" Text="退票" Width="134px" Height="27px"
                                        TabIndex="3"></asp:Button>
                                </td>
                                <td style="width: 121px">
                                    <asp:Button ID="Button_chaxun" runat="server" Text="查询" Width="125px" Height="27px"
                                        TabIndex="4"></asp:Button>
                                </td>
                                <td style="width: 122px">
                                    <asp:Button ID="Button_yhgl" runat="server" Text="用户管理" Width="137px" Height="27px"
                                        TabIndex="5"></asp:Button>
                                </td>
                            </tr>
                        </table>
                    </font>
                </td>
            </tr>
            <tr>
                <td style="height: 1px" align="left">
                    <font face="宋体"><font face="新宋体" color="#009900">&nbsp;</font>
                        <asp:Label ID="Label_yhm" runat="server" BackColor="White" Width="54px" ForeColor="Green"
                            BorderColor="White">Label</asp:Label><font face="新宋体" color="#009900">&nbsp;</font><font
                                face="华文行楷" color="#ff9900"><font face="新宋体" color="#009900">
                                    <script>
                                        today = new Date();
                                        var day; var date; var hello; var wel;
                                        hour = new Date().getHours()
                                        if (hour < 6) hello = '凌晨好'
                                        else if (hour < 9) hello = '早上好'
                                        else if (hour < 12) hello = '上午好'
                                        else if (hour < 14) hello = '中午好'
                                        else if (hour < 17) hello = '下午好'
                                        else if (hour < 19) hello = '傍晚好'
                                        else if (hour < 22) hello = '晚上好'
                                        else { hello = '夜里好!' }
                                        if (today.getDay() == 0) day = '星期日'
                                        else if (today.getDay() == 1) day = '星期一'
                                        else if (today.getDay() == 2) day = '星期二'
                                        else if (today.getDay() == 3) day = '星期三'
                                        else if (today.getDay() == 4) day = '星期四'
                                        else if (today.getDay() == 5) day = '星期五'
                                        else if (today.getDay() == 6) day = '星期六'
                                        date = (today.getYear()) + '年' + (today.getMonth() + 1) + '月' + today.getDate() + '日';
                                        if (hour < 1) wel = '子时';
                                        else if (hour < 3) wel = '丑时';
                                        else if (hour < 5) wel = '寅时';
                                        else if (hour < 7) wel = '卯时';
                                        else if (hour < 9) wel = '辰时';
                                        else if (hour < 11) wel = '巳时';
                                        else if (hour < 13) wel = '午时';
                                        else if (hour < 15) wel = '未时';
                                        else if (hour < 17) wel = '申时';
                                        else if (hour < 19) wel = '酉时';
                                        else if (hour < 21) wel = '戌时';
                                        else if (hour < 23) wel = '亥时';
                                        else { wel = '子时'; }
                                        document.write(hello);
                                    </script>
                                    现在是<script>
                                           document.write(date + ' ' + day + ' ' + wel);
                                    </script>
                                    &nbsp;&nbsp;&nbsp;&nbsp; </font></font>
                        <asp:LinkButton ID="LinkButton_xinwen" runat="server" BackColor="White" ForeColor="Green"
                            Font-Size="Small">站内新闻</asp:LinkButton><font face="新宋体" color="#009900">&nbsp;
                        </font>
                        <asp:LinkButton ID="LinkButton_grxx" runat="server" BackColor="White" ForeColor="Green"
                            Font-Size="Small">个人资料</asp:LinkButton>&nbsp;
                        <asp:LinkButton ID="LinkButton_yjfk" runat="server" BackColor="White" ForeColor="Green"
                            Font-Size="Small">意见反馈</asp:LinkButton></font>
                </td>
            </tr>
            <tr>
                <td style="height: 285px" align="center">
                    <p>
                        <font face="宋体"></font>&nbsp;</p>
                    <font face="宋体">
                        <p>
                            <font face="宋体">
                                <asp:Image ID="Image1" runat="server" Height="264px" Width="574px" ImageUrl="/images\mdl_default_bg.JPG">
                                </asp:Image></font>
                        </p>
                    </font><font face="宋体">
                        <p>
                            <font face="宋体"></font>&nbsp;</p>
                    </font>
                    <p>
                        <font face="宋体"></font>&nbsp;</p>
                    <p>
                        <font face="宋体"></font>&nbsp;</p>
                </td>
            </tr>
            <tr>
                <td>
                    <font face="宋体"><font size="2">当前用户IP:</font>
                        <asp:Label ID="Label_IP" runat="server" Width="99px" ForeColor="Black" BackColor="White">Label</asp:Label><font
                            size="2">浏览器版本:
                            <asp:Label ID="Label_LLQ" runat="server" Width="42px" ForeColor="Black" BackColor="White">Label</asp:Label></font></font>
                </td>
            </tr>
            <tr>
                <td>
                    <p align="center">
                        <font face="宋体" size="2"></font>&nbsp; <font face="华文中宋" size="2"></font>
                    </p>
                </td>
            </tr>
        </table>
        &nbsp;
        </form>
    </div>
</body>
</html>
