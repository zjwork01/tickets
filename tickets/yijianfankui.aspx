<%@ Page language="c#" Codebehind="yijianfankui.aspx.cs" AutoEventWireup="false" Inherits="tickets.yijianfankui" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>意见反馈</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; WIDTH: 640px; POSITION: absolute; TOP: 8px; HEIGHT: 66px"
					cellSpacing="1" cellPadding="1" width="640" border="1">
					<TR>
						<TD bgColor="#339900" colSpan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<FONT color="#ffffff">&nbsp;&nbsp;&nbsp;&nbsp;
								<STRONG>意见反馈</STRONG></FONT></TD>
					</TR>
					<TR>
						<TD colSpan="3">&nbsp;&nbsp; 标题:
							<asp:TextBox id="TextBox_bt" runat="server" Width="528px" tabIndex="1"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD colSpan="3">&nbsp;&nbsp; 内容:
							<asp:TextBox id="TextBox_nr" runat="server" Width="528px" TextMode="MultiLine" MaxLength="10"
								Height="104px" tabIndex="2"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD colSpan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
							&nbsp;&nbsp; &nbsp;&nbsp;
							<asp:Button id="Button_tj" runat="server" Width="50px" Text="提交" BorderStyle="Outset" tabIndex="3"></asp:Button>&nbsp;
							<asp:Button id="Button_cz" runat="server" Width="50px" Text="重置" BorderStyle="Outset" tabIndex="4"></asp:Button>&nbsp;
							<asp:Button id="Button_fh" runat="server" Width="50px" Text="返回" BorderStyle="Outset" tabIndex="5"></asp:Button></TD>
					</TR>
				</TABLE>
			</FONT>
		</form>
	</body>
</HTML>
