<%@ Page language="c#" Codebehind="yhxx.aspx.cs" AutoEventWireup="false" Inherits="tickets.yhxx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>��������</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="����">
				<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; WIDTH: 624px; POSITION: absolute; TOP: 8px; HEIGHT: 142px"
					width="624" border="1">
					<TR>
						<TD bgColor="#339900" colSpan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<STRONG>&nbsp;&nbsp;<FONT color="#ffffff">�� 
									�� �� ��</FONT></STRONG></TD>
					</TR>
					<TR>
						<TD colSpan="3">&nbsp; �û���
							<asp:TextBox id="TextBox_yhm" runat="server" Width="128px" tabIndex="1"></asp:TextBox>��&nbsp;&nbsp;&nbsp; 
							��
							<asp:TextBox id="TextBox_mm" runat="server" Width="128px" tabIndex="2"></asp:TextBox>��ϵ��ʽ
							<asp:TextBox id="TextBox_lxfs" runat="server" Width="128px" tabIndex="3"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD colSpan="3">&nbsp; ������
							<asp:TextBox id="TextBox_fzr" runat="server" Width="128px" tabIndex="4"></asp:TextBox>��λ����
							<asp:TextBox id="TextBox_dwmc" runat="server" Width="128px" tabIndex="5"></asp:TextBox>&nbsp; 
							���֤
							<asp:TextBox id="TextBox_sfz" runat="server" Width="128px" tabIndex="6"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD colSpan="3">�����ַ
							<asp:TextBox id="TextBox_dz" runat="server" Width="528px" tabIndex="7"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD colSpan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
							&nbsp;&nbsp;&nbsp;
							<asp:Button id="Button_xg" runat="server" Text="�޸�" Width="48px" BorderStyle="Outset" tabIndex="8"></asp:Button>&nbsp;
							<asp:Button id="Button_queding" runat="server" Text="ȷ��" Width="48px" BorderStyle="Outset" Visible="False"
								tabIndex="9"></asp:Button>&nbsp;
							<asp:Button id="Button_qx" runat="server" Text="����" Width="48px" BorderStyle="Outset" tabIndex="10"></asp:Button></TD>
					</TR>
				</TABLE>
				<asp:Label id="Label_xh" style="Z-INDEX: 102; LEFT: 272px; POSITION: absolute; TOP: 160px"
					runat="server" Width="128px" Visible="False" ForeColor="Red"></asp:Label></FONT>
		</form>
	</body>
</HTML>
