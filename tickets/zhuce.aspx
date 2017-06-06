<%@ Page language="c#" Codebehind="zhuce.aspx.cs" AutoEventWireup="false" Inherits="tickets.zhuce" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>列车售票系统--注册页面</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body background="/images\bg.gif" MS_POSITIONING="GridLayout">
		<div align="center">
			<form id="Form1" method="post" runat="server">
				<P><FONT face="宋体"></FONT>&nbsp;</P>
				<P>&nbsp;</P>
				<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 136px; WIDTH: 664px; POSITION: absolute; TOP: 40px; HEIGHT: 488px"
					cellSpacing="1" cellPadding="1" width="664" border="1">
					<TR>
						<TD style="HEIGHT: 61px"><FONT face="宋体">
								<P align="center"><FONT face="华文中宋" size="7">
										<asp:Image id="Image2" runat="server" Height="98px" Width="657px" ImageUrl="/images\biaoti.gif"></asp:Image></FONT></P>
							</FONT>
						</TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 40px"><FONT face="宋体">
								<TABLE id="Table2" style="WIDTH: 659px; HEIGHT: 30px" cellSpacing="0" cellPadding="0" width="659"
									border="0">
									<TR>
										<TD style="WIDTH: 115px"><asp:button id="Button_maipiao" runat="server" Text="买票" Width="133px" Height="27px"></asp:button></TD>
										<TD><asp:button id="Button_dingpiao" runat="server" Text="订票" Width="133px" Height="27px"></asp:button></TD>
										<TD style="WIDTH: 133px"><asp:button id="Button_tuipiao" runat="server" Text="退票" Width="122px" Height="27px"></asp:button></TD>
										<TD style="WIDTH: 121px"><asp:button id="Button_chaxun" runat="server" Text="查询" Width="125px" Height="27px"></asp:button></TD>
										<TD><asp:button id="Button_yhgl" runat="server" Text="用户管理" Width="135px" Height="27px"></asp:button></TD>
									</TR>
								</TABLE>
							</FONT>
						</TD>
					</TR>
					<TR>
						<TD style="VERTICAL-ALIGN: baseline; HEIGHT: 343px; TEXT-ALIGN: center">
							<P><FONT style="VERTICAL-ALIGN: baseline; POSITION: static; TEXT-ALIGN: center" face="宋体"></FONT></P>
							<P><FONT style="VERTICAL-ALIGN: baseline; POSITION: static; TEXT-ALIGN: center" face="宋体">
									<TABLE id="Table5" style="WIDTH: 444px; HEIGHT: 30px" cellSpacing="1" cellPadding="1" width="444"
										border="0">
										<TR>
											<TD align="center" bgColor="#339900"><asp:radiobutton id="RadioButton_dsd" runat="server" Text="代售点注册" Checked="True" AutoPostBack="True"
													GroupName="1"></asp:radiobutton></TD>
											<TD align="center" bgColor="#339900"><asp:radiobutton id="RadioButton_qydw" runat="server" Text="单位企业注册" AutoPostBack="True" GroupName="1"></asp:radiobutton></TD>
										</TR>
									</TABLE>
								</FONT><FONT style="VERTICAL-ALIGN: baseline; POSITION: static; TEXT-ALIGN: center" face="宋体">
								&nbsp;</P>
							<P>
								<TABLE id="Table3" style="WIDTH: 442px; HEIGHT: 66px" cellSpacing="0" cellPadding="0" width="442"
									border="0">
									<TR>
										<TD style="WIDTH: 153px" align="right" colSpan="1" rowSpan="1">用户名:</TD>
										<TD><asp:textbox id="TextBox_xingming" tabIndex="1" runat="server" Width="160px"></asp:textbox>&nbsp;
											<asp:label id="Label_yhm" runat="server" Width="94px" Font-Size="X-Small" ForeColor="Red">6-16个字符</asp:label></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 153px" align="right">密码:</TD>
										<TD><asp:textbox id="TextBox_mima" tabIndex="2" runat="server" Width="160px" TextMode="Password"></asp:textbox>&nbsp;
											<asp:label id="Label_mm" runat="server" Width="94px" Font-Size="X-Small" ForeColor="Red">8-16个字符</asp:label></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 153px" align="right">重复密码:</TD>
										<TD><asp:textbox id="TextBox_mimacf" tabIndex="3" runat="server" Width="160px" TextMode="Password"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 153px" align="right"><asp:label id="Label_dsfzr" runat="server" Width="98px">负责人:</asp:label></TD>
										<TD><asp:textbox id="TextBox_dsfzr" tabIndex="4" runat="server" Width="160px"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 153px; HEIGHT: 24px" align="right"><asp:label id="Label_dssfz" runat="server" Width="98px">身份证:</asp:label></TD>
										<TD style="HEIGHT: 24px"><asp:textbox id="TextBox_dssfz" tabIndex="5" runat="server" Width="160px"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 153px; HEIGHT: 24px" align="right"><asp:label id="Label_dsdz" runat="server" Width="98px">具体地址:</asp:label></TD>
										<TD style="HEIGHT: 24px"><asp:textbox id="TextBox_dsdz" tabIndex="6" runat="server" Width="160px"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 153px" align="right"><asp:label id="Label_dslxfs" runat="server" Width="98px">联系方式:</asp:label></TD>
										<TD><asp:textbox id="TextBox_dslxfs" tabIndex="7" runat="server" Width="160px" Height="28px"></asp:textbox></TD>
									</TR>
								</TABLE>
							</P>
							<P>
								<TABLE id="Table4" style="WIDTH: 441px; HEIGHT: 54px" cellSpacing="0" cellPadding="0" width="441"
									border="0">
									<TR>
										<TD style="WIDTH: 151px" align="right"><asp:label id="Label_dwmc" runat="server" Width="98px">单位全称:</asp:label></TD>
										<TD><asp:textbox id="TextBox_dwmc" tabIndex="8" runat="server" Width="160px"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 151px" align="right"><asp:label id="Label_dwfzr" runat="server" Width="98px">负责人:</asp:label></TD>
										<TD><asp:textbox id="TextBox_dwfzr" tabIndex="9" runat="server" Width="160px"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 151px; HEIGHT: 24px" align="right"><asp:label id="Label_dwsfz" runat="server" Width="98px">身份证:</asp:label></TD>
										<TD style="HEIGHT: 24px"><asp:textbox id="TextBox_dwsfz" runat="server" Width="160px"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 151px; HEIGHT: 16px" align="right"><asp:label id="Label_dwlxfs" runat="server" Width="98px">联系方式:</asp:label></TD>
										<TD style="HEIGHT: 16px"><asp:textbox id="TextBox_dwlxfs" tabIndex="10" runat="server" Width="160px"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 151px" align="right"><asp:label id="Label_dwdz" runat="server" Width="98px">具体地址:</asp:label></TD>
										<TD><asp:textbox id="TextBox_dwdz" tabIndex="11" runat="server" Width="160px"></asp:textbox></TD>
									</TR>
								</TABLE>
								</FONT><FONT face="宋体"></FONT>
							</P>
							<P><FONT face="宋体"><asp:button id="Button_queding" tabIndex="12" runat="server" Text="确定" Width="62px"></asp:button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
									<asp:button id="Button_chongzhi" tabIndex="13" runat="server" Text="重置" Width="60px"></asp:button></FONT><FONT face="宋体"></FONT></P>
						</TD>
					</TR>
					<TR>
						<TD><FONT face="宋体"><FONT face="宋体"><FONT size="2">当前用户IP:</FONT>
									<asp:Label id="Label_IP" runat="server" Width="99px" ForeColor="Black" BackColor="White">Label</asp:Label><FONT size="2">浏览器版本:
										<asp:Label id="Label_LLQ" runat="server" Width="42px" ForeColor="Black" BackColor="White">Label</asp:Label></FONT></FONT></FONT></TD>
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
