<%@ Page Language="c#" CodeBehind="main.aspx.cs" AutoEventWireup="false" Inherits="tickets.WebForm2" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>�г���Ʊϵͳ</title>
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
                    <font face="����">
                        <p align="center">
                            <font face="��������" size="7">
                                <asp:Image ID="Image2" runat="server" Height="96px" Width="655px" ImageUrl="/images\biaoti.gif"
                                    BackColor="White"></asp:Image></font>
                        </p>
                    </font>
                </td>
            </tr>
            <tr>
                <td style="height: 30px">
                    <font face="����">
                        <table id="Table2" style="width: 659px; height: 30px" cellspacing="0" cellpadding="0"
                            width="659" border="0" runat="server">
                            <tr>
                                <td style="width: 115px">
                                    <asp:Button ID="Button_maipiao" runat="server" Text="��Ʊ" Width="133px" Height="27px"
                                        TabIndex="1"></asp:Button>
                                </td>
                                <td>
                                    <asp:Button ID="Button_dingpiao" runat="server" Text="��Ʊ" Width="120px" Height="27px"
                                        TabIndex="2"></asp:Button>
                                </td>
                                <td style="width: 139px">
                                    <asp:Button ID="Button_tuipiao" runat="server" Text="��Ʊ" Width="134px" Height="27px"
                                        TabIndex="3"></asp:Button>
                                </td>
                                <td style="width: 121px">
                                    <asp:Button ID="Button_chaxun" runat="server" Text="��ѯ" Width="125px" Height="27px"
                                        TabIndex="4"></asp:Button>
                                </td>
                                <td style="width: 122px">
                                    <asp:Button ID="Button_yhgl" runat="server" Text="�û�����" Width="137px" Height="27px"
                                        TabIndex="5"></asp:Button>
                                </td>
                            </tr>
                        </table>
                    </font>
                </td>
            </tr>
            <tr>
                <td style="height: 1px" align="left">
                    <font face="����"><font face="������" color="#009900">&nbsp;</font>
                        <asp:Label ID="Label_yhm" runat="server" BackColor="White" Width="54px" ForeColor="Green"
                            BorderColor="White">Label</asp:Label><font face="������" color="#009900">&nbsp;</font><font
                                face="�����п�" color="#ff9900"><font face="������" color="#009900">
                                    <script>
                                        today = new Date();
                                        var day; var date; var hello; var wel;
                                        hour = new Date().getHours()
                                        if (hour < 6) hello = '�賿��'
                                        else if (hour < 9) hello = '���Ϻ�'
                                        else if (hour < 12) hello = '�����'
                                        else if (hour < 14) hello = '�����'
                                        else if (hour < 17) hello = '�����'
                                        else if (hour < 19) hello = '�����'
                                        else if (hour < 22) hello = '���Ϻ�'
                                        else { hello = 'ҹ���!' }
                                        if (today.getDay() == 0) day = '������'
                                        else if (today.getDay() == 1) day = '����һ'
                                        else if (today.getDay() == 2) day = '���ڶ�'
                                        else if (today.getDay() == 3) day = '������'
                                        else if (today.getDay() == 4) day = '������'
                                        else if (today.getDay() == 5) day = '������'
                                        else if (today.getDay() == 6) day = '������'
                                        date = (today.getYear()) + '��' + (today.getMonth() + 1) + '��' + today.getDate() + '��';
                                        if (hour < 1) wel = '��ʱ';
                                        else if (hour < 3) wel = '��ʱ';
                                        else if (hour < 5) wel = '��ʱ';
                                        else if (hour < 7) wel = 'îʱ';
                                        else if (hour < 9) wel = '��ʱ';
                                        else if (hour < 11) wel = '��ʱ';
                                        else if (hour < 13) wel = '��ʱ';
                                        else if (hour < 15) wel = 'δʱ';
                                        else if (hour < 17) wel = '��ʱ';
                                        else if (hour < 19) wel = '��ʱ';
                                        else if (hour < 21) wel = '��ʱ';
                                        else if (hour < 23) wel = '��ʱ';
                                        else { wel = '��ʱ'; }
                                        document.write(hello);
                                    </script>
                                    ������<script>
                                           document.write(date + ' ' + day + ' ' + wel);
                                    </script>
                                    &nbsp;&nbsp;&nbsp;&nbsp; </font></font>
                        <asp:LinkButton ID="LinkButton_xinwen" runat="server" BackColor="White" ForeColor="Green"
                            Font-Size="Small">վ������</asp:LinkButton><font face="������" color="#009900">&nbsp;
                        </font>
                        <asp:LinkButton ID="LinkButton_grxx" runat="server" BackColor="White" ForeColor="Green"
                            Font-Size="Small">��������</asp:LinkButton>&nbsp;
                        <asp:LinkButton ID="LinkButton_yjfk" runat="server" BackColor="White" ForeColor="Green"
                            Font-Size="Small">�������</asp:LinkButton></font>
                </td>
            </tr>
            <tr>
                <td style="height: 285px" align="center">
                    <p>
                        <font face="����"></font>&nbsp;</p>
                    <font face="����">
                        <p>
                            <font face="����">
                                <asp:Image ID="Image1" runat="server" Height="264px" Width="574px" ImageUrl="/images\mdl_default_bg.JPG">
                                </asp:Image></font>
                        </p>
                    </font><font face="����">
                        <p>
                            <font face="����"></font>&nbsp;</p>
                    </font>
                    <p>
                        <font face="����"></font>&nbsp;</p>
                    <p>
                        <font face="����"></font>&nbsp;</p>
                </td>
            </tr>
            <tr>
                <td>
                    <font face="����"><font size="2">��ǰ�û�IP:</font>
                        <asp:Label ID="Label_IP" runat="server" Width="99px" ForeColor="Black" BackColor="White">Label</asp:Label><font
                            size="2">������汾:
                            <asp:Label ID="Label_LLQ" runat="server" Width="42px" ForeColor="Black" BackColor="White">Label</asp:Label></font></font>
                </td>
            </tr>
            <tr>
                <td>
                    <p align="center">
                        <font face="����" size="2"></font>&nbsp; <font face="��������" size="2"></font>
                    </p>
                </td>
            </tr>
        </table>
        &nbsp;
        </form>
    </div>
</body>
</html>
