<%@ Page language="c#" Codebehind="chaxunshengyupiao.aspx.cs" AutoEventWireup="false" Inherits="tickets.chaxunshengyupiao" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>chaxunshengyupiao</title>
		<META http-equiv="Content-Type" content="text/html; charset=gb2312">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body background="/images\bg.gif" MS_POSITIONING="GridLayout">
		<div align="center">
			<form id="Form2" method="post" runat="server">
				<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 136px; WIDTH: 664px; POSITION: absolute; TOP: 40px; HEIGHT: 488px"
					cellSpacing="1" cellPadding="1" width="664" border="1">
					<TR>
						<TD style="HEIGHT: 61px"><FONT face="宋体">
								<P align="center"><FONT face="华文中宋" size="7">
										<asp:Image id="Image2" runat="server" Width="666px" Height="96px" BackColor="White" ImageUrl="/images\biaoti.gif"></asp:Image></FONT></P>
							</FONT>
						</TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 30px"><FONT face="宋体">
								<TABLE id="Table2" style="WIDTH: 682px; HEIGHT: 30px" cellSpacing="0" cellPadding="0" width="682"
									border="0">
									<TR>
										<TD style="WIDTH: 115px"><asp:button id="Button_maipiao" runat="server" Height="27px" Width="133px" Text="买票"></asp:button></TD>
										<TD><asp:button id="Button_dingpiao" runat="server" Height="27px" Width="120px" Text="订票"></asp:button></TD>
										<TD style="WIDTH: 139px"><asp:button id="Button_tuipiao" runat="server" Height="27px" Width="134px" Text="退票"></asp:button></TD>
										<TD style="WIDTH: 121px"><asp:button id="Button_chaxun" runat="server" Height="27px" Width="125px" Text="查询"></asp:button></TD>
										<TD><asp:button id="Button_yhgl" runat="server" Height="27px" Width="163px" Text="用户管理"></asp:button></TD>
									</TR>
								</TABLE>
							</FONT>
						</TD>
					</TR>
					<tr>
						<td vAlign="top" align="left">
							<table id="table3" style="WIDTH: 683px; HEIGHT: 26px" cellSpacing="1" borderColorDark="#ffffff"
								width="683" borderColorLight="#c0c0c0" border="1">
								<tr>
									<td align="center" width="124"><asp:linkbutton id="LinkButton1" tabIndex="1" runat="server" ForeColor="Green">用户管理</asp:linkbutton></td>
									<td align="center" width="124"><asp:linkbutton id="LinkButton2" tabIndex="2" runat="server" ForeColor="Green">查询剩余票</asp:linkbutton></td>
									<td align="center" width="124"><asp:linkbutton id="LinkButton3" tabIndex="3" runat="server" ForeColor="Green">更新车次</asp:linkbutton></td>
									<TD align="center" width="124">
										<asp:linkbutton id="Linkbutton_xwgl" tabIndex="3" runat="server" ForeColor="Green">新闻管理</asp:linkbutton></TD>
									<TD align="center" width="124">
										<asp:linkbutton id="Linkbutton_xxfk" tabIndex="3" runat="server" ForeColor="Green">信息反馈</asp:linkbutton></TD>
									<td align="center" width="124" colSpan="2"><asp:linkbutton id="LinkButton4" tabIndex="4" runat="server" ForeColor="Green">销售情况查询</asp:linkbutton></td>
								</tr>
							</table>
							<table id="table7" cellSpacing="1" borderColorDark="#ffffff" width="100%" borderColorLight="#c0c0c0"
								border="1">
								<tr>
									<td width="73"><asp:label id="Label_cxcc" runat="server" Width="84px">输入车次:</asp:label></td>
									<td style="WIDTH: 524px" width="524"><asp:textbox id="TextBox_cxcc" tabIndex="5" runat="server" Width="150px"></asp:textbox></td>
									<td align="right"><asp:button id="Button_cccx" tabIndex="6" runat="server" Height="24px" Width="69px" Text="查询"></asp:button></td>
								</tr>
							</table>
							<table id="table4" cellSpacing="1" borderColorDark="#ffffff" width="100%" borderColorLight="#c0c0c0"
								border="1">
								<tr>
									<td>当前共有
										<asp:label id="Label_checi" runat="server" Width="39px"></asp:label>趟车次信息：</td>
								</tr>
							</table>
							<table id="table5" height="350" cellSpacing="1" borderColorDark="#ffffff" width="100%"
								borderColorLight="#c0c0c0" border="1">
								<tr>
									<td vAlign="top" align="center"><asp:datagrid id=DataGrid1 runat="server" Height="50px" Width="673px" CellPadding="4" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#3366CC" AllowPaging="True" AllowCustomPaging="True" AutoGenerateColumns="False" DataMember="tickets" DataKeyField="车次" DataSource="<%# dataSet_checi %>">
											<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
											<ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
											<HeaderStyle Font-Size="12px" Font-Bold="True" HorizontalAlign="Center" ForeColor="White" VerticalAlign="Middle"
												BackColor="#339900"></HeaderStyle>
											<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
											<Columns>
												<asp:BoundColumn DataField="序号" SortExpression="序号" HeaderText="序号">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="车次" SortExpression="车次" HeaderText="车次">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="车辆类型" SortExpression="车辆类型" HeaderText="车辆类型">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="硬座票数" SortExpression="硬座票数" HeaderText="硬座票数">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="硬卧上票数" SortExpression="硬卧上票数" HeaderText="硬卧上票数">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="硬卧中票数" SortExpression="硬卧中票数" HeaderText="硬卧中票数">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="硬卧下票数" SortExpression="硬卧下票数" HeaderText="硬卧下票数">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="软卧上票数" SortExpression="软卧上票数" HeaderText="软卧上票数">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="软卧下票数" SortExpression="软卧下票数" HeaderText="软卧下票数">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
											</Columns>
											<PagerStyle HorizontalAlign="Left" ForeColor="White" BackColor="#339900" Mode="NumericPages"></PagerStyle>
										</asp:datagrid></td>
								</tr>
							</table>
							<table id="table6" style="WIDTH: 685px; HEIGHT: 35px" height="35" cellSpacing="1" borderColorDark="#ffffff"
								width="685" borderColorLight="#c0c0c0" border="1">
								<tr>
									<td align="center" width="207" height="24"><asp:button id="Button_cxsy" tabIndex="7" runat="server" Height="27px" Width="119px" Text="查询所有剩余票"></asp:button></td>
									<td align="center" width="207" height="24"><asp:button id="Button_cccxsy" tabIndex="8" runat="server" Height="27px" Width="116px" Text="按车次查询剩余票"></asp:button></td>
									<td align="center" width="207" height="24"><asp:button id="Button_cz" tabIndex="9" runat="server" Height="27px" Width="108px" Text="重置"></asp:button></td>
								</tr>
							</table>
							<FONT face="宋体"><FONT size="2">当前用户IP:</FONT>
								<asp:Label id="Label_IP" runat="server" Width="99px" ForeColor="Black" BackColor="White">Label</asp:Label><FONT size="2">浏览器版本:
									<asp:Label id="Label_LLQ" runat="server" Width="42px" ForeColor="Black" BackColor="White">Label</asp:Label></FONT></FONT>
						</td>
					</tr>
					<tr>
						<td height="21">
							<p align="center"><font face="宋体" size="2"></font>&nbsp; <font face="华文中宋" size="2">
									</font></p>
						</td>
					</tr>
				</TABLE>
			</form>
		</div>
	</body>
</HTML>
