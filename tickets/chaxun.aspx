<%@ Page language="c#" Codebehind="chaxun.aspx.cs" AutoEventWireup="false" Inherits="tickets.chaxun" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>查询</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body background="/images\bg.gif" MS_POSITIONING="GridLayout">
		<div align="center">
			<form id="Form1" method="post" runat="server">
				<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 136px; WIDTH: 664px; POSITION: absolute; TOP: 40px; HEIGHT: 300px"
					cellSpacing="1" cellPadding="1" width="664" border="1">
					<TR>
						<TD style="HEIGHT: 61px"><FONT face="宋体">
								<P align="center"><FONT face="华文中宋" size="7">
										<asp:Image id="Image2" runat="server" Width="666px" Height="96px" BackColor="White" ImageUrl="/images\biaoti.gif"></asp:Image></FONT></P>
							</FONT>
						</TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 44px"><FONT face="宋体">
								<TABLE id="Table2" style="WIDTH: 665px; HEIGHT: 30px" cellSpacing="0" cellPadding="0" width="659"
									border="0">
									<TR>
										<TD style="WIDTH: 115px"><asp:button id="Button_maipiao" runat="server" Height="27px" Width="133px" Text="买票"></asp:button></TD>
										<TD><asp:button id="Button_dingpiao" runat="server" Height="27px" Width="137px" Text="订票"></asp:button></TD>
										<TD style="WIDTH: 124px"><asp:button id="Button_tuipiao" runat="server" Height="27px" Width="122px" Text="退票"></asp:button></TD>
										<TD style="WIDTH: 121px"><asp:button id="Button_chaxun" runat="server" Height="27px" Width="125px" Text="查询"></asp:button></TD>
										<TD><asp:button id="Button_yhgl" runat="server" Height="27px" Width="136px" Text="用户管理"></asp:button></TD>
									</TR>
								</TABLE>
							</FONT>
						</TD>
					</TR>
					<TR>
						<TD><FONT face="宋体">
								<P><FONT face="宋体">
										<TABLE id="Table3" style="WIDTH: 664px; HEIGHT: 116px" borderColor="buttonface" cellSpacing="0"
											cellPadding="0" width="664" border="1" DESIGNTIMEDRAGDROP="131">
											<TR>
												<TD style="WIDTH: 561px; HEIGHT: 18px" colSpan="4">按车次查询</TD>
												<TD style="HEIGHT: 18px"><asp:button id="Button_cxcx" tabIndex="1" runat="server" Height="27px" Width="73px" Text="重新查询"></asp:button></TD>
											</TR>
											<TR>
												<TD style="HEIGHT: 30px" align="right">请输入查询车次:</TD>
												<TD style="WIDTH: 248px; HEIGHT: 30px" colSpan="3"><asp:textbox id="TextBox_checi" tabIndex="2" runat="server" Width="168px"></asp:textbox></TD>
												<TD style="HEIGHT: 30px"><asp:button id="Button_chaxun1" tabIndex="3" runat="server" Height="27px" Width="74px" Text="查询"></asp:button></TD>
											</TR>
											<TR>
												<TD colSpan="5" style="HEIGHT: 20px">按起始站查询</TD>
											</TR>
											<TR>
												<TD align="right">起始站:</TD>
												<TD style="WIDTH: 161px"><asp:textbox id="TextBox_qsz" tabIndex="4" runat="server" Height="28px" Width="168px"></asp:textbox></TD>
												<TD style="WIDTH: 75px">终点站：</TD>
												<TD style="WIDTH: 169px"><asp:textbox id="TextBox_zdz" tabIndex="5" runat="server" Height="28px" Width="168px"></asp:textbox></TD>
												<TD><asp:button id="Button_chaxun2" tabIndex="6" runat="server" Height="27px" Width="77px" Text="查询"></asp:button></TD>
											</TR>
										</TABLE>
									</FONT>
								</P>
							</FONT>
							<P><FONT face="宋体"><asp:datagrid id=DataGrid1 runat="server" Height="80px" Width="664px" CellPadding="4" BorderStyle="None" BorderWidth="1px" BorderColor="#3366CC" HorizontalAlign="Center" BackColor="White" Visible="False" AutoGenerateColumns="False" AllowPaging="True" AllowCustomPaging="True" DataMember="tickets" AllowSorting="True" DataKeyField="车次" DataSource="<%# dataSet_chaxun1 %>">
										<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
										<ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
										<HeaderStyle Font-Size="Smaller" Font-Bold="True" HorizontalAlign="Center" ForeColor="White"
											VerticalAlign="Middle" BackColor="#339900"></HeaderStyle>
										<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
										<Columns>
											<asp:TemplateColumn HeaderText="序号">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
												<ItemTemplate>
													<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.序号") %>'>
													</asp:Label>
												</ItemTemplate>
												<EditItemTemplate>
													<asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.序号") %>'>
													</asp:TextBox>
												</EditItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn DataField="车次" HeaderText="车次">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="车辆类型" SortExpression="车辆类型" HeaderText="车辆类型">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="始发站" HeaderText="始发站">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="终点站" HeaderText="终点站">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="开车时间" HeaderText="开车时间" DataFormatString="{0:hh-mm}">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="到达时间" HeaderText="到达时间" DataFormatString="{0:hh-mm}">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
											</asp:BoundColumn>
											<asp:ButtonColumn Text="购买" CommandName="Select">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
											</asp:ButtonColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Left" ForeColor="White" BackColor="#339900" Mode="NumericPages"></PagerStyle>
									</asp:datagrid></FONT></P>
							<P><FONT face="宋体"></FONT>&nbsp;</P>
							<P>&nbsp;</P>
						</TD>
					</TR>
					<TR>
						<TD><FONT face="宋体"><FONT size="2">当前用户IP:</FONT>
								<asp:Label id="Label_IP" runat="server" Width="99px" BackColor="White" ForeColor="Black">Label</asp:Label><FONT size="2">浏览器版本:
									<asp:Label id="Label_LLQ" runat="server" Width="42px" BackColor="White" ForeColor="Black">Label</asp:Label></FONT></FONT></TD>
					</TR>
					<TR>
						<TD>
							<P align="center"><FONT face="宋体" size="2"></FONT>&nbsp; <FONT face="华文中宋" size="2">
									</FONT></P>
						</TD>
					</TR>
				</TABLE>
				&nbsp;
			</form>
		</div>
	</body>
</HTML>
