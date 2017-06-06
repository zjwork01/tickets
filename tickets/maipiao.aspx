<%@ Page Language="c#" CodeBehind="maipiao.aspx.cs" AutoEventWireup="false" Inherits="tickets.maipiao" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>列车售票系统--买票页面</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
</head>
<body background="/images\bg.gif" ms_positioning="GridLayout">
    <div align="center">
        <form id="买票" method="post" runat="server">
        <table id="Table1" style="z-index: 101; left: 136px; width: 664px; position: absolute;
            top: 40px; height: 488px" cellspacing="1" cellpadding="1" width="664" border="1">
            <tr>
                <td style="height: 61px">
                    <font face="宋体">
                        <p align="center">
                            <font face="华文中宋" size="7">
                                <asp:Image ID="Image2" runat="server" ImageUrl="/images\biaoti.gif" Height="98px"
                                    Width="672px"></asp:Image></font></p>
                    </font>
                </td>
            </tr>
            <tr>
                <td style="height: 49px">
                    <font face="宋体">
                        <table id="Table2" style="width: 659px; height: 30px" cellspacing="0" cellpadding="0"
                            width="659" border="0">
                            <tr>
                                <td style="width: 115px">
                                    <asp:Button ID="Button_maipiao" runat="server" Height="27px" Width="133px" Text="买票">
                                    </asp:Button>
                                </td>
                                <td style="width: 134px">
                                    <asp:Button ID="Button_dingpiao" runat="server" Height="27px" Width="134px" Text="订票">
                                    </asp:Button>
                                </td>
                                <td style="width: 133px">
                                    <asp:Button ID="Button_tuipiao" runat="server" Height="27px" Width="129px" Text="退票">
                                    </asp:Button>
                                </td>
                                <td style="width: 121px">
                                    <asp:Button ID="Button_chaxun" runat="server" Height="27px" Width="138px" Text="查询">
                                    </asp:Button>
                                </td>
                                <td>
                                    <asp:Button ID="Button_yhgl" runat="server" Height="27px" Width="131px" Text="用户管理">
                                    </asp:Button>
                                </td>
                            </tr>
                        </table>
                    </font>
                    <p>
                        &nbsp;</p>
                </td>
            </tr>
            <tr>
                <td style="height: 32px">
                    <table id="Table3" style="vertical-align: baseline; width: 672px; position: static;
                        height: 120px; text-align: justify" cellspacing="0" cellpadding="0" width="672"
                        border="0">
                        <tr>
                            <td colspan="5">
                                <font face="宋体"><font face="宋体">
                                    <asp:Label ID="Label_xinxi" runat="server" Width="325px"></asp:Label></font></font>
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 8px" align="right">
                                输入车次：
                            </td>
                            <td style="width: 178px; height: 8px">
                                <font face="宋体">
                                    <asp:TextBox ID="Text_checi" TabIndex="1" runat="server" Width="177px"></asp:TextBox></font>
                            </td>
                            <td style="width: 98px; height: 8px">
                                <font face="宋体">&nbsp;&nbsp;发车日期:</font>
                            </td>
                            <td style="width: 208px; height: 8px" align="left">
                                <font face="宋体">
                                    <asp:DropDownList ID="DropDownList_nian" TabIndex="2" runat="server" Width="62px">
                                        <asp:ListItem Value="2005" Selected="True">2005</asp:ListItem>
                                        <asp:ListItem Value="2007">2007</asp:ListItem>
                                        <asp:ListItem Value="2008">2008</asp:ListItem>
                                    </asp:DropDownList>
                                    年
                                    <asp:DropDownList ID="DropDownList_yue" TabIndex="3" runat="server" Width="41px">
                                        <asp:ListItem Value="1" Selected="True">1</asp:ListItem>
                                        <asp:ListItem Value="2">2</asp:ListItem>
                                        <asp:ListItem Value="3">3</asp:ListItem>
                                        <asp:ListItem Value="4">4</asp:ListItem>
                                        <asp:ListItem Value="5">5</asp:ListItem>
                                        <asp:ListItem Value="6">6</asp:ListItem>
                                        <asp:ListItem Value="7">7</asp:ListItem>
                                        <asp:ListItem Value="8">8</asp:ListItem>
                                        <asp:ListItem Value="9">9</asp:ListItem>
                                        <asp:ListItem Value="10">10</asp:ListItem>
                                        <asp:ListItem Value="11">11</asp:ListItem>
                                        <asp:ListItem Value="12">12</asp:ListItem>
                                    </asp:DropDownList>
                                    月
                                    <asp:DropDownList ID="DropDownList_ri" TabIndex="4" runat="server" Width="37px">
                                        <asp:ListItem Value="1" Selected="True">1</asp:ListItem>
                                        <asp:ListItem Value="2">2</asp:ListItem>
                                        <asp:ListItem Value="3">3</asp:ListItem>
                                        <asp:ListItem Value="4">4</asp:ListItem>
                                        <asp:ListItem Value="5">5</asp:ListItem>
                                        <asp:ListItem Value="6">6</asp:ListItem>
                                        <asp:ListItem Value="7">7</asp:ListItem>
                                        <asp:ListItem Value="8">8</asp:ListItem>
                                        <asp:ListItem Value="9">9</asp:ListItem>
                                        <asp:ListItem Value="10">10</asp:ListItem>
                                        <asp:ListItem Value="11">11</asp:ListItem>
                                        <asp:ListItem Value="12">12</asp:ListItem>
                                        <asp:ListItem Value="13">13</asp:ListItem>
                                        <asp:ListItem Value="14">14</asp:ListItem>
                                        <asp:ListItem Value="15">15</asp:ListItem>
                                        <asp:ListItem Value="16">16</asp:ListItem>
                                        <asp:ListItem Value="17">17</asp:ListItem>
                                        <asp:ListItem Value="18">18</asp:ListItem>
                                        <asp:ListItem Value="19">19</asp:ListItem>
                                        <asp:ListItem Value="20">20</asp:ListItem>
                                        <asp:ListItem Value="21">21</asp:ListItem>
                                        <asp:ListItem Value="22">22</asp:ListItem>
                                        <asp:ListItem Value="23">23</asp:ListItem>
                                        <asp:ListItem Value="24">24</asp:ListItem>
                                        <asp:ListItem Value="25">25</asp:ListItem>
                                        <asp:ListItem Value="26">26</asp:ListItem>
                                        <asp:ListItem Value="27">27</asp:ListItem>
                                        <asp:ListItem Value="28">28</asp:ListItem>
                                        <asp:ListItem Value="29">29</asp:ListItem>
                                        <asp:ListItem Value="30">30</asp:ListItem>
                                        <asp:ListItem Value="31">31</asp:ListItem>
                                    </asp:DropDownList>
                                    日</font>
                            </td>
                            <td style="height: 8px">
                                <font face="宋体">
                                    <asp:Button ID="Button_quding" TabIndex="5" runat="server" Width="57px" Text="确定">
                                    </asp:Button></font>
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 15px" align="right">
                                选择起始站：
                            </td>
                            <td style="width: 178px; height: 15px">
                                <asp:DropDownList ID="DropDownList_qsz" TabIndex="6" runat="server" Width="180px">
                                </asp:DropDownList>
                            </td>
                            <td style="width: 98px; height: 15px" align="right">
                                <font face="宋体">选择终点站：</font>
                            </td>
                            <td style="height: 15px" colspan="2">
                                <font face="宋体"></font><font face="宋体">
                                    <asp:DropDownList ID="DropDownList_zdz" TabIndex="7" runat="server" Width="152px">
                                    </asp:DropDownList>
                                    &nbsp;&nbsp;学生票
                                    <asp:DropDownList ID="Dropdownlist_xsp" TabIndex="7" runat="server" Width="55px">
                                        <asp:ListItem Value="学">是</asp:ListItem>
                                        <asp:ListItem Value=" " Selected="True">否</asp:ListItem>
                                    </asp:DropDownList>
                                </font>
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 2px" align="right">
                                选择座位型：
                            </td>
                            <td style="width: 178px; height: 2px">
                                <font face="宋体">
                                    <asp:DropDownList ID="DropDownList_zwlx1" TabIndex="8" runat="server" Width="180px">
                                        <asp:ListItem Value="硬座票价" Selected="True">硬座</asp:ListItem>
                                        <asp:ListItem Value="硬卧上">硬卧上</asp:ListItem>
                                        <asp:ListItem Value="硬卧中">硬卧中</asp:ListItem>
                                        <asp:ListItem Value="硬卧下">硬卧下</asp:ListItem>
                                        <asp:ListItem Value="软卧上">软卧上</asp:ListItem>
                                        <asp:ListItem Value="软卧下">软卧下</asp:ListItem>
                                    </asp:DropDownList>
                                </font>
                            </td>
                            <td style="width: 98px; height: 2px" align="right">
                                <font face="宋体">输入票数：</font>
                            </td>
                            <td style="width: 208px; height: 2px">
                                <font face="宋体">
                                    <asp:TextBox ID="Text_ps" TabIndex="9" runat="server" Width="151px"></asp:TextBox></font>
                            </td>
                            <td style="height: 2px">
                                <font style="vertical-align: baseline; text-align: center" face="宋体">
                                    <asp:Button ID="Button_jiage" TabIndex="10" runat="server" Width="59px" Text="价格">
                                    </asp:Button></font>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                总价格：
                            </td>
                            <td style="width: 178px">
                                <font face="宋体">
                                    <asp:Label ID="Label_zjg" runat="server" Width="26px"></asp:Label>元</font>
                            </td>
                            <td style="width: 98px">
                                <font face="宋体">
                                    <asp:Button ID="Button_goumai" TabIndex="11" runat="server" Width="61px" Text="购买">
                                    </asp:Button></font>
                            </td>
                            <td style="width: 208px">
                                <font face="宋体"></font>
                            </td>
                            <td>
                                <font face="宋体">
                                    <asp:Button ID="Button_chongzhi" TabIndex="12" runat="server" Width="59px" Text="重置">
                                    </asp:Button></font>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="height: 379px">
                    <p>
                        <font face="宋体">
                            <asp:Panel ID="Panel1" runat="server" Height="152px" HorizontalAlign="Center" Visible="False">
                                <table id="Table4" style="vertical-align: baseline; width: 663px; height: 72px; text-align: justify"
                                    cellspacing="0" cellpadding="0" width="663" border="1">
                                    <tr>
                                        <td style="height: 36px" colspan="5">
                                            用户信息：
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 94px; height: 26px" align="right">
                                            姓名:
                                        </td>
                                        <td style="width: 153px; height: 26px">
                                            <asp:TextBox ID="TextBox_xm" TabIndex="13" runat="server"></asp:TextBox>
                                        </td>
                                        <td style="width: 269px; height: 26px" align="right">
                                            &nbsp;联系方式:
                                        </td>
                                        <td style="height: 26px">
                                        </td>
                                        <td style="height: 26px">
                                            <asp:TextBox ID="TextBox_lxfs" TabIndex="14" runat="server" Width="135px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 94px; height: 26px" align="right">
                                            地址:
                                        </td>
                                        <td style="width: 153px; height: 26px">
                                            <asp:TextBox ID="TextBox_dz" TabIndex="15" runat="server" Width="152px"></asp:TextBox>
                                        </td>
                                        <td style="width: 258px; height: 26px" align="right" colspan="2">
                                            &nbsp;&nbsp; 身份证号:
                                        </td>
                                        <td style="width: 258px; height: 26px" align="left">
                                            <asp:TextBox ID="TextBox_sfzh" TabIndex="16" runat="server" Width="136px"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </font>
                    </p>
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
                        <font face="华文中宋" size="2"></font>&nbsp;</p>
                </td>
            </tr>
        </table>
        &nbsp;
        </form>
    </div>
</body>
</html>
