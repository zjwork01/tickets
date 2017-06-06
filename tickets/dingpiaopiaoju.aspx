<%@ Page language="c#" Codebehind="dingpiaopiaoju.aspx.cs" AutoEventWireup="false" Inherits="tickets.dingpiaopiaoju" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>订票票据</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; WIDTH: 600px; POSITION: absolute; TOP: 8px; HEIGHT: 134px"
				cellSpacing="0" cellPadding="0" width="600" border="1">
				<TR>
					<TD style="HEIGHT: 24px" borderColor="#ffffff" borderColorLight="#ffffff" borderColorDark="#ffffff"
						colSpan="3"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
							&nbsp;&nbsp; &nbsp;
							<asp:ImageButton id="ImageButton1" runat="server" Width="40px" Height="25px" ImageUrl="\images\dy.jpg"></asp:ImageButton>&nbsp;
						</FONT>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" bgcolor="#339900"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<FONT color="#ffffff">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</FONT></FONT><FONT face="黑体"><FONT color="#ffffff">&nbsp;订 
								票 详 单</FONT><FONT color="#339900"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
								&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
								<asp:Label id="Label_dprq" runat="server" Width="88px" Font-Size="X-Small" ForeColor="White"></asp:Label></FONT></FONT></TD>
				</TR>
				<TR>
					<TD colSpan="3"><FONT face="宋体">&nbsp;&nbsp; &nbsp;车次
							<asp:TextBox id="TextBox_cc" runat="server" Height="20px" Width="64px" Enabled="False"></asp:TextBox>起始站
							<asp:TextBox id="TextBox_qsz" runat="server" Height="20px" Width="80px" Enabled="False"></asp:TextBox>终点站
							<asp:TextBox id="TextBox_zdz" runat="server" Height="20px" Width="64px" Enabled="False"></asp:TextBox>&nbsp;&nbsp;开车时间
							<asp:TextBox id="TextBox_kcsj" runat="server" Height="20px" Width="104px" Enabled="False"></asp:TextBox></FONT></TD>
				</TR>
				<TR>
					<TD colSpan="3" style="HEIGHT: 21px"><FONT face="宋体">座位类型
							<asp:TextBox id="TextBox_zwlx" runat="server" Height="20px" Width="64px" Enabled="False"></asp:TextBox>票&nbsp; 
							数
							<asp:TextBox id="TextBox_ps" runat="server" Height="20px" Width="80px" Enabled="False"></asp:TextBox>价&nbsp; 
							格
							<asp:TextBox id="TextBox_jg" runat="server" Height="20px" Width="64px" Enabled="False"></asp:TextBox>是否学生票
							<asp:TextBox id="TextBox_xsp" runat="server" Enabled="False" Width="104px" Height="20px"></asp:TextBox></FONT></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 21px" colSpan="3"><FONT face="宋体">用户姓名
							<asp:TextBox id="TextBox_yhm" runat="server" Enabled="False" Width="64px" Height="20px"></asp:TextBox>电&nbsp;&nbsp;话
							<asp:TextBox id="TextBox_dh" runat="server" Enabled="False" Width="80px" Height="20px"></asp:TextBox>地&nbsp;&nbsp;址
							<asp:TextBox id="TextBox_dz" runat="server" Enabled="False" Width="257px" Height="20px"></asp:TextBox></FONT></TD>
				</TR>
				<TR>
					<TD colSpan="3"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<FONT size="2"><FONT color="#999999">
									售票地点:</FONT> </FONT>
							<asp:Label id="Label_dsdmc" runat="server" Width="24px" ForeColor="Gray"></asp:Label><FONT color="#999999" size="2">号售票厅</FONT></FONT></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
