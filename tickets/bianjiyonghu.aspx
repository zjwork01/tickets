<%@ Page language="c#" Codebehind="bianjiyonghu.aspx.cs" AutoEventWireup="false" Inherits="tickets.bianjiyonghu" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>�û���Ϣ</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<div align="center">
			<form id="Form1" method="post" runat="server">
				<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="680" border="1">
					<TR>
						<TD borderColor="#0066cc" bgColor="#339900" colSpan="1" height="35" rowSpan="1"><FONT face="����">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							</FONT>
							<asp:label id="Label_biaoti" runat="server" Font-Size="Large" Width="201px" Font-Bold="True"
								ForeColor="White">�û���ϸ��Ϣ</asp:label></TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 26px"><FONT face="����"><FONT face="����">��Ʊ���:
									<asp:textbox id="TextBox_bh" runat="server" Width="101px" tabIndex="1"></asp:textbox></FONT>�û���:
								<asp:textbox id="TextBox_yhm" runat="server" Width="101px" tabIndex="2"></asp:textbox>&nbsp;��&nbsp;&nbsp;&nbsp;��:
								<asp:textbox id="TextBox_mm" runat="server" Width="82px" tabIndex="3"></asp:textbox>&nbsp;
								<asp:Label id="Label_xuhao" runat="server">���:</asp:Label><FONT face="����">
									<asp:Label id="xuhao" runat="server" Width="38px"></asp:Label>&nbsp;</FONT></FONT></TD>
					</TR>
					<TR>
						<TD><FONT face="����">��λȫ��:
								<asp:textbox id="TextBox_dwmc" runat="server" Width="101px" tabIndex="4"></asp:textbox>��&nbsp; 
								ַ:
								<asp:textbox id="TextBox_dz" runat="server" Width="266px" tabIndex="5"></asp:textbox>���֤:<asp:textbox id="TextBox_sfz" runat="server" Width="101px" tabIndex="6"></asp:textbox></FONT></TD>
					</TR>
					<TR>
						<TD><FONT face="����">��ϵ��ʽ:
								<asp:textbox id="TextBox_lxfs" runat="server" Width="101px" tabIndex="7"></asp:textbox>������:
								<asp:textbox id="TextBoxfzr" runat="server" Width="101px" tabIndex="8"></asp:textbox>�û�����:
								<asp:textbox id="TextBox_yhlx" runat="server" Width="82px" tabIndex="9"></asp:textbox>&nbsp;&nbsp;&nbsp;&nbsp;
								<asp:button id="Button_xiugai" runat="server" Text="�ύ" tabIndex="10"></asp:button><asp:button id="Button_zj" runat="server" Text="����" tabIndex="11"></asp:button><asp:button id="Button_cz" runat="server" Text="����" tabIndex="12"></asp:button></FONT></TD>
					</TR>
				</TABLE>
			</form>
		</div>
	</body>
</HTML>
