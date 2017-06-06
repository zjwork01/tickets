<%@ Page language="c#" Codebehind="bianjiyonghu.aspx.cs" AutoEventWireup="false" Inherits="tickets.bianjiyonghu" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>用户信息</title>
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
						<TD borderColor="#0066cc" bgColor="#339900" colSpan="1" height="35" rowSpan="1"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							</FONT>
							<asp:label id="Label_biaoti" runat="server" Font-Size="Large" Width="201px" Font-Bold="True"
								ForeColor="White">用户详细信息</asp:label></TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 26px"><FONT face="宋体"><FONT face="宋体">售票编号:
									<asp:textbox id="TextBox_bh" runat="server" Width="101px" tabIndex="1"></asp:textbox></FONT>用户名:
								<asp:textbox id="TextBox_yhm" runat="server" Width="101px" tabIndex="2"></asp:textbox>&nbsp;密&nbsp;&nbsp;&nbsp;码:
								<asp:textbox id="TextBox_mm" runat="server" Width="82px" tabIndex="3"></asp:textbox>&nbsp;
								<asp:Label id="Label_xuhao" runat="server">序号:</asp:Label><FONT face="宋体">
									<asp:Label id="xuhao" runat="server" Width="38px"></asp:Label>&nbsp;</FONT></FONT></TD>
					</TR>
					<TR>
						<TD><FONT face="宋体">单位全称:
								<asp:textbox id="TextBox_dwmc" runat="server" Width="101px" tabIndex="4"></asp:textbox>地&nbsp; 
								址:
								<asp:textbox id="TextBox_dz" runat="server" Width="266px" tabIndex="5"></asp:textbox>身份证:<asp:textbox id="TextBox_sfz" runat="server" Width="101px" tabIndex="6"></asp:textbox></FONT></TD>
					</TR>
					<TR>
						<TD><FONT face="宋体">联系方式:
								<asp:textbox id="TextBox_lxfs" runat="server" Width="101px" tabIndex="7"></asp:textbox>负责人:
								<asp:textbox id="TextBoxfzr" runat="server" Width="101px" tabIndex="8"></asp:textbox>用户类型:
								<asp:textbox id="TextBox_yhlx" runat="server" Width="82px" tabIndex="9"></asp:textbox>&nbsp;&nbsp;&nbsp;&nbsp;
								<asp:button id="Button_xiugai" runat="server" Text="提交" tabIndex="10"></asp:button><asp:button id="Button_zj" runat="server" Text="增加" tabIndex="11"></asp:button><asp:button id="Button_cz" runat="server" Text="重置" tabIndex="12"></asp:button></FONT></TD>
					</TR>
				</TABLE>
			</form>
		</div>
	</body>
</HTML>
