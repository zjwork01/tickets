<%@ Page language="c#" Codebehind="guanliyonghu.aspx.cs" AutoEventWireup="false" Inherits="tickets.guanliyonghu" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>管理用户</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body background="/images\bg.gif" MS_POSITIONING="GridLayout">
		<div align="center">
			<form id="Form1" method="post" runat="server">
				<table id="table1" style="WIDTH: 635px; HEIGHT: 361px" height="361" borderColorDark="#ffffff"
					width="635" borderColorLight="#c0c0c0" border="1">
					<TBODY>
						<tr>
							<td height="59">
								<p align="center"><font face="华文中宋" size="7">
										<asp:Image id="Image2" runat="server" Width="623px" Height="98px" ImageUrl="/images\biaoti.gif"></asp:Image></font></p>
							</td>
						</tr>
						<tr>
							<td height="26">
								<table id="table2" height="22" cellSpacing="1" borderColorDark="#ffffff" width="624" borderColorLight="#c0c0c0"
									border="1">
									<tr>
										<td align="center" width="124" height="18"><asp:button id="Button_maipiao" runat="server" Height="27px" Width="133px" Text="买票"></asp:button></td>
										<td align="center" width="124" height="18"><asp:button id="Button_dingpiao" runat="server" Height="27px" Width="120px" Text="订票"></asp:button></td>
										<td align="center" width="124" height="18"><asp:button id="Button_tuipiao" runat="server" Height="27px" Width="134px" Text="退票"></asp:button></td>
										<td align="center" width="124" height="18"><asp:button id="Button_chaxun" runat="server" Height="27px" Width="116px" Text="查询"></asp:button></td>
										<td align="center" width="125" height="18"><asp:button id="Button_yhgl" runat="server" Height="27px" Width="81px" Text="用户管理"></asp:button></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td style="HEIGHT: 316px" vAlign="top" align="left">
								<table id="table3" cellSpacing="1" borderColorDark="#ffffff" width="624" borderColorLight="#c0c0c0"
									border="1">
									<tr>
										<td align="center" width="124"><asp:linkbutton id="LinkButton1" runat="server" tabIndex="1" ForeColor="Green">管理用户</asp:linkbutton></td>
										<td align="center" width="124"><asp:linkbutton id="LinkButton2" runat="server" tabIndex="2" ForeColor="Green">查询剩余票</asp:linkbutton></td>
										<td align="center" width="124"><asp:linkbutton id="LinkButton3" runat="server" tabIndex="3" ForeColor="Green">更新车次</asp:linkbutton></td>
										<TD align="center" width="124">
											<asp:linkbutton id="Linkbutton_xwgl" tabIndex="3" runat="server" ForeColor="Green">新闻管理</asp:linkbutton></TD>
										<TD align="center" width="124">
											<asp:linkbutton id="Linkbutton_xxfk" tabIndex="3" runat="server" ForeColor="Green">信息反馈</asp:linkbutton></TD>
										<td align="center" width="124" colSpan="2"><asp:linkbutton id="LinkButton4" runat="server" tabIndex="4" ForeColor="Green">销售情况查询</asp:linkbutton></td>
									</tr>
								</table>
								<table id="table4" cellSpacing="1" borderColorDark="#ffffff" width="100%" borderColorLight="#c0c0c0"
									border="1">
									<tr>
										<td>当前共有
											<asp:label id="ct" runat="server" Width="16px"></asp:label>位用户在线&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
											&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
											<asp:Label id="Label_cx" runat="server" Width="67px" Visible="False">查询用户</asp:Label>&nbsp;
											<asp:TextBox id="TextBox_sousuo" runat="server" Width="161px" Visible="False" tabIndex="5"></asp:TextBox>
											<asp:button id="Button_sousuo" runat="server" Text="搜索" Width="45px" Height="22px" Visible="False"
												tabIndex="6"></asp:button>
											<asp:button id="Button_sy" runat="server" Text="所有" Width="45px" Height="22px" Visible="False"
												tabIndex="7"></asp:button></td>
									</tr>
								</table>
								<TABLE id="table5" style="VERTICAL-ALIGN: baseline; TEXT-ALIGN: left" height="300" cellSpacing="0"
									borderColorDark="#ffffff" width="100%" borderColorLight="#c0c0c0" border="0">
								</FONT>
							</td>
						</tr>
				</table>
				<table id="table6" cellSpacing="1" borderColorDark="#ffffff" width="624" borderColorLight="#c0c0c0"
					border="1" style="WIDTH: 624px; HEIGHT: 30px">
					<tr>
						<td align="center" width="124" height="32"><asp:button id="Button1" runat="server" Height="25px" Width="133px" Text="查询用户信息" tabIndex="8"></asp:button></td>
						<td align="center" width="123" height="32" style="WIDTH: 123px" colSpan="3"><FONT face="宋体"></FONT><FONT face="宋体">
								<asp:button id="Button4" runat="server" Text="添加用户" Width="125px" Height="25px" tabIndex="9"></asp:button></FONT><FONT face="宋体"></FONT></td>
						<TD align="center" width="124" height="32"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</FONT>
							<asp:button id="Button5" runat="server" Text="重置" Width="60px" Height="25px" tabIndex="10"></asp:button></TD>
					</tr>
				</table>
				<P>
					<asp:DataGrid id=DataGrid1 runat="server" Height="50px" Width="624px" AllowPaging="True" AutoGenerateColumns="False" DataMember="user" DataSource="<%# dataSet_users %>" GridLines="Vertical" CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#999999" DataKeyField="序号">
						<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#008A8C"></SelectedItemStyle>
						<AlternatingItemStyle BackColor="Gainsboro"></AlternatingItemStyle>
						<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
						<HeaderStyle Font-Size="11pt" Font-Bold="True" HorizontalAlign="Center" ForeColor="White" VerticalAlign="Middle"
							BackColor="#009900"></HeaderStyle>
						<FooterStyle ForeColor="DarkSeaGreen" BackColor="#CCCC99"></FooterStyle>
						<Columns>
							<asp:BoundColumn DataField="序号" HeaderText="序号">
								<HeaderStyle Width="32px"></HeaderStyle>
								<ItemStyle HorizontalAlign="Center"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="用户名" HeaderText="用户名">
								<HeaderStyle Width="55px"></HeaderStyle>
								<ItemStyle HorizontalAlign="Center"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="密码" HeaderText="密码">
								<ItemStyle HorizontalAlign="Center"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="负责人" HeaderText="负责人">
								<HeaderStyle Width="55px"></HeaderStyle>
								<ItemStyle HorizontalAlign="Center"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="身份证" HeaderText="身份证">
								<ItemStyle HorizontalAlign="Center"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="用户类型" HeaderText="用户类型">
								<HeaderStyle Width="70px"></HeaderStyle>
								<ItemStyle HorizontalAlign="Center"></ItemStyle>
							</asp:BoundColumn>
							<asp:ButtonColumn Text="详细/编辑" HeaderText="详细/编辑/增加" CommandName="Select">
								<HeaderStyle Width="120px"></HeaderStyle>
								<ItemStyle Font-Size="X-Small" HorizontalAlign="Center"></ItemStyle>
							</asp:ButtonColumn>
							<asp:ButtonColumn Text="删除" HeaderText="删除" CommandName="Delete">
								<ItemStyle Font-Size="X-Small" HorizontalAlign="Center"></ItemStyle>
							</asp:ButtonColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#009900" Mode="NumericPages"></PagerStyle>
					</asp:DataGrid></P>
				<P><FONT face="宋体"></FONT>&nbsp;</P>
				<P><FONT face="宋体"></FONT>&nbsp;</P>
				<P>&nbsp;</P>
				</TD></TR>
				<TR>
					<TD height="21"><FONT face="宋体"><FONT size="2">当前用户IP:</FONT>
							<asp:Label id="Label_IP" runat="server" Width="99px" ForeColor="Black" BackColor="White">Label</asp:Label><FONT size="2">浏览器版本:
								<asp:Label id="Label_LLQ" runat="server" Width="42px" ForeColor="Black" BackColor="White">Label</asp:Label></FONT></FONT></TD>
				</TR>
				<tr>
					<td height="21">
						<p align="center"><font face="宋体" size="2"></font>&nbsp; <font face="华文中宋" size="2">
								</font></p>
					</td>
				</tr>
				</TBODY></TABLE>
			</form>
		</div>
	</body>
</HTML>
