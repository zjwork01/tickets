<%@ Page language="c#" Codebehind="yhxx.aspx.cs" AutoEventWireup="false" Inherits="tickets.yhxx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>个人资料</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; WIDTH: 624px; POSITION: absolute; TOP: 8px; HEIGHT: 142px"
					width="624" border="1">
					<TR>
						<TD bgColor="#339900" colSpan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<STRONG>&nbsp;&nbsp;<FONT color="#ffffff">个 
									人 资 料</FONT></STRONG></TD>
					</TR>
					<TR>
						<TD colSpan="3">&nbsp; 用户名
							<asp:TextBox id="TextBox_yhm" runat="server" Width="128px" tabIndex="1"></asp:TextBox>密&nbsp;&nbsp;&nbsp; 
							码
							<asp:TextBox id="TextBox_mm" runat="server" Width="128px" tabIndex="2"></asp:TextBox>联系方式
							<asp:TextBox id="TextBox_lxfs" runat="server" Width="128px" tabIndex="3"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD colSpan="3">&nbsp; 负责人
							<asp:TextBox id="TextBox_fzr" runat="server" Width="128px" tabIndex="4"></asp:TextBox>单位名称
							<asp:TextBox id="TextBox_dwmc" runat="server" Width="128px" tabIndex="5"></asp:TextBox>&nbsp; 
							身份证
							<asp:TextBox id="TextBox_sfz" runat="server" Width="128px" tabIndex="6"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD colSpan="3">具体地址
							<asp:TextBox id="TextBox_dz" runat="server" Width="528px" tabIndex="7"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD colSpan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
							&nbsp;&nbsp;&nbsp;
							<asp:Button id="Button_xg" runat="server" Text="修改" Width="48px" BorderStyle="Outset" tabIndex="8"></asp:Button>&nbsp;
							<asp:Button id="Button_queding" runat="server" Text="确定" Width="48px" BorderStyle="Outset" Visible="False"
								tabIndex="9"></asp:Button>&nbsp;
							<asp:Button id="Button_qx" runat="server" Text="返回" Width="48px" BorderStyle="Outset" tabIndex="10"></asp:Button></TD>
					</TR>
				</TABLE>
				<asp:Label id="Label_xh" style="Z-INDEX: 102; LEFT: 272px; POSITION: absolute; TOP: 160px"
					runat="server" Width="128px" Visible="False" ForeColor="Red"></asp:Label></FONT>
		</form>
	</body>
</HTML>
