<%@ Page language="c#" Codebehind="yonghuguanlizhujiemian.aspx.cs" AutoEventWireup="false" Inherits="tickets.yonghuguanlizhujiemian" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>用户管理页面</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" background="/images\bg.gif">
		<div align="center">
			<form id="Form2" method="post" runat="server">
				<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 136px; WIDTH: 664px; POSITION: absolute; TOP: 40px; HEIGHT: 488px"
					cellSpacing="1" cellPadding="1" width="664" border="1">
					<TR>
						<TD style="HEIGHT: 61px"><FONT face="宋体">
								<P align="center"><FONT face="华文中宋" size="7">
										<asp:Image id="Image2" runat="server" Height="98px" Width="679px" ImageUrl="/images\biaoti.gif"></asp:Image></FONT></P>
							</FONT>
						</TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 30px"><FONT face="宋体">
								<TABLE id="Table2" style="WIDTH: 682px; HEIGHT: 30px" cellSpacing="0" cellPadding="0" width="682"
									border="0">
									<TR>
										<TD style="WIDTH: 115px">
											<asp:Button id="Button_maipiao" runat="server" Text="买票" Width="133px" Height="27px"></asp:Button></TD>
										<TD>
											<asp:Button id="Button_dingpiao" runat="server" Text="订票" Width="120px" Height="27px"></asp:Button></TD>
										<TD style="WIDTH: 139px">
											<asp:Button id="Button_tuipiao" runat="server" Text="退票" Width="134px" Height="27px"></asp:Button></TD>
										<TD style="WIDTH: 140px">
											<asp:Button id="Button_chaxun" runat="server" Text="查询" Width="125px" Height="27px"></asp:Button></TD>
										<TD>
											<asp:Button id="Button_yhgl" runat="server" Text="用户管理" Width="149px" Height="27px"></asp:Button></TD>
									</TR>
								</TABLE>
							</FONT>
						</TD>
					</TR>
					<tr>
						<td align="left" valign="top">
							<table border="1" width="683" id="table3" bordercolorlight="#c0c0c0" cellspacing="1" bordercolordark="#ffffff"
								style="WIDTH: 683px; HEIGHT: 26px">
								<tr>
									<td width="124" align="center">
										<asp:LinkButton id="LinkButton1" runat="server" tabIndex="1" ForeColor="Green">用户管理</asp:LinkButton></td>
									<td width="124" align="center">
										<asp:LinkButton id="LinkButton2" runat="server" tabIndex="2" ForeColor="Green">查询剩余票</asp:LinkButton></td>
									<td width="124" align="center">
										<asp:LinkButton id="LinkButton3" runat="server" tabIndex="3" ForeColor="Green">更新车次</asp:LinkButton></td>
									<TD align="center" width="124"><FONT face="宋体">
											<asp:LinkButton id="LinkButton5" tabIndex="3" runat="server" ForeColor="Green">新闻管理</asp:LinkButton></FONT></TD>
									<TD align="center" width="124">
										<asp:LinkButton id="LinkButton_xxfk" tabIndex="3" runat="server" ForeColor="Green">信息反馈</asp:LinkButton></TD>
									<td width="124" align="center" colSpan="2">
										<asp:LinkButton id="LinkButton4" runat="server" tabIndex="4" ForeColor="Green">销售情况查询</asp:LinkButton></td>
								</tr>
							</table>
							<P><FONT face="宋体">
									<asp:Image id="Image1" runat="server" ImageUrl="/images\mdl_default_bg.JPG" Width="680px"></asp:Image></FONT></P>
							<P><FONT face="宋体"></FONT>&nbsp;</P>
							<P>&nbsp;</P>
					<TR>
						<TD height="21"><FONT face="宋体"><FONT size="2">当前用户IP:</FONT>
								<asp:Label id="Label_IP" runat="server" Width="99px" ForeColor="Black" BackColor="White">Label</asp:Label><FONT size="2">浏览器版本:
									<asp:Label id="Label_LLQ" runat="server" Width="42px" ForeColor="Black" BackColor="White">Label</asp:Label></FONT></FONT></TD>
					</TR>
					<tr>
						<td height="21">
							<p align="center"><font size="2" face="宋体"></font>&nbsp; <font face="华文中宋" size="2">
									</font></p>
						</td>
					</tr>
				</TABLE>
			</form>
		</div>
	</body>
</HTML>
