<%@ Page language="c#" Codebehind="guanliyonghu.aspx.cs" AutoEventWireup="false" Inherits="tickets.guanliyonghu" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>�����û�</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body background="/images\bg.gif" MS_POSITIONING="GridLayout">
		<div align="center">
			<form id="Form1" method="post" runat="server">
				<table id="table1" style="WIDTH: 635px; HEIGHT: 361px" height="361" borderColorDark="#ffffff"
					width="635" borderColorLight="#c0c0c0" border="1">
					<TBODY>
						<tr>
							<td height="59">
								<p align="center"><font face="��������" size="7">
										<asp:Image id="Image2" runat="server" Width="623px" Height="98px" ImageUrl="/images\biaoti.gif"></asp:Image></font></p>
							</td>
						</tr>
						<tr>
							<td height="26">
								<table id="table2" height="22" cellSpacing="1" borderColorDark="#ffffff" width="624" borderColorLight="#c0c0c0"
									border="1">
									<tr>
										<td align="center" width="124" height="18"><asp:button id="Button_maipiao" runat="server" Height="27px" Width="133px" Text="��Ʊ"></asp:button></td>
										<td align="center" width="124" height="18"><asp:button id="Button_dingpiao" runat="server" Height="27px" Width="120px" Text="��Ʊ"></asp:button></td>
										<td align="center" width="124" height="18"><asp:button id="Button_tuipiao" runat="server" Height="27px" Width="134px" Text="��Ʊ"></asp:button></td>
										<td align="center" width="124" height="18"><asp:button id="Button_chaxun" runat="server" Height="27px" Width="116px" Text="��ѯ"></asp:button></td>
										<td align="center" width="125" height="18"><asp:button id="Button_yhgl" runat="server" Height="27px" Width="81px" Text="�û�����"></asp:button></td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td style="HEIGHT: 316px" vAlign="top" align="left">
								<table id="table3" cellSpacing="1" borderColorDark="#ffffff" width="624" borderColorLight="#c0c0c0"
									border="1">
									<tr>
										<td align="center" width="124"><asp:linkbutton id="LinkButton1" runat="server" tabIndex="1" ForeColor="Green">�����û�</asp:linkbutton></td>
										<td align="center" width="124"><asp:linkbutton id="LinkButton2" runat="server" tabIndex="2" ForeColor="Green">��ѯʣ��Ʊ</asp:linkbutton></td>
										<td align="center" width="124"><asp:linkbutton id="LinkButton3" runat="server" tabIndex="3" ForeColor="Green">���³���</asp:linkbutton></td>
										<TD align="center" width="124">
											<asp:linkbutton id="Linkbutton_xwgl" tabIndex="3" runat="server" ForeColor="Green">���Ź���</asp:linkbutton></TD>
										<TD align="center" width="124">
											<asp:linkbutton id="Linkbutton_xxfk" tabIndex="3" runat="server" ForeColor="Green">��Ϣ����</asp:linkbutton></TD>
										<td align="center" width="124" colSpan="2"><asp:linkbutton id="LinkButton4" runat="server" tabIndex="4" ForeColor="Green">���������ѯ</asp:linkbutton></td>
									</tr>
								</table>
								<table id="table4" cellSpacing="1" borderColorDark="#ffffff" width="100%" borderColorLight="#c0c0c0"
									border="1">
									<tr>
										<td>��ǰ����
											<asp:label id="ct" runat="server" Width="16px"></asp:label>λ�û�����&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
											&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
											<asp:Label id="Label_cx" runat="server" Width="67px" Visible="False">��ѯ�û�</asp:Label>&nbsp;
											<asp:TextBox id="TextBox_sousuo" runat="server" Width="161px" Visible="False" tabIndex="5"></asp:TextBox>
											<asp:button id="Button_sousuo" runat="server" Text="����" Width="45px" Height="22px" Visible="False"
												tabIndex="6"></asp:button>
											<asp:button id="Button_sy" runat="server" Text="����" Width="45px" Height="22px" Visible="False"
												tabIndex="7"></asp:button></td>
									</tr>
								</table>
								<TABLE id="table5" style="VERTICAL-ALIGN: baseline; TEXT-ALIGN: left" height="300" cellSpacing="0"
									borderColorDark="#ffffff" width="100%" borderColorLight="#c0c0c0" border="0">
								</FONT>
							</td>
						</tr>
				</table>
				<table id="table6" cellSpacing="1" borderColorDark="#ffffff" width="624" borderColorLight="#c0c0c0"
					border="1" style="WIDTH: 624px; HEIGHT: 30px">
					<tr>
						<td align="center" width="124" height="32"><asp:button id="Button1" runat="server" Height="25px" Width="133px" Text="��ѯ�û���Ϣ" tabIndex="8"></asp:button></td>
						<td align="center" width="123" height="32" style="WIDTH: 123px" colSpan="3"><FONT face="����"></FONT><FONT face="����">
								<asp:button id="Button4" runat="server" Text="����û�" Width="125px" Height="25px" tabIndex="9"></asp:button></FONT><FONT face="����"></FONT></td>
						<TD align="center" width="124" height="32"><FONT face="����">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</FONT>
							<asp:button id="Button5" runat="server" Text="����" Width="60px" Height="25px" tabIndex="10"></asp:button></TD>
					</tr>
				</table>
				<P>
					<asp:DataGrid id=DataGrid1 runat="server" Height="50px" Width="624px" AllowPaging="True" AutoGenerateColumns="False" DataMember="user" DataSource="<%# dataSet_users %>" GridLines="Vertical" CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#999999" DataKeyField="���">
						<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#008A8C"></SelectedItemStyle>
						<AlternatingItemStyle BackColor="Gainsboro"></AlternatingItemStyle>
						<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
						<HeaderStyle Font-Size="11pt" Font-Bold="True" HorizontalAlign="Center" ForeColor="White" VerticalAlign="Middle"
							BackColor="#009900"></HeaderStyle>
						<FooterStyle ForeColor="DarkSeaGreen" BackColor="#CCCC99"></FooterStyle>
						<Columns>
							<asp:BoundColumn DataField="���" HeaderText="���">
								<HeaderStyle Width="32px"></HeaderStyle>
								<ItemStyle HorizontalAlign="Center"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="�û���" HeaderText="�û���">
								<HeaderStyle Width="55px"></HeaderStyle>
								<ItemStyle HorizontalAlign="Center"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="����" HeaderText="����">
								<ItemStyle HorizontalAlign="Center"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="������" HeaderText="������">
								<HeaderStyle Width="55px"></HeaderStyle>
								<ItemStyle HorizontalAlign="Center"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="���֤" HeaderText="���֤">
								<ItemStyle HorizontalAlign="Center"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="�û�����" HeaderText="�û�����">
								<HeaderStyle Width="70px"></HeaderStyle>
								<ItemStyle HorizontalAlign="Center"></ItemStyle>
							</asp:BoundColumn>
							<asp:ButtonColumn Text="��ϸ/�༭" HeaderText="��ϸ/�༭/����" CommandName="Select">
								<HeaderStyle Width="120px"></HeaderStyle>
								<ItemStyle Font-Size="X-Small" HorizontalAlign="Center"></ItemStyle>
							</asp:ButtonColumn>
							<asp:ButtonColumn Text="ɾ��" HeaderText="ɾ��" CommandName="Delete">
								<ItemStyle Font-Size="X-Small" HorizontalAlign="Center"></ItemStyle>
							</asp:ButtonColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#009900" Mode="NumericPages"></PagerStyle>
					</asp:DataGrid></P>
				<P><FONT face="����"></FONT>&nbsp;</P>
				<P><FONT face="����"></FONT>&nbsp;</P>
				<P>&nbsp;</P>
				</TD></TR>
				<TR>
					<TD height="21"><FONT face="����"><FONT size="2">��ǰ�û�IP:</FONT>
							<asp:Label id="Label_IP" runat="server" Width="99px" ForeColor="Black" BackColor="White">Label</asp:Label><FONT size="2">������汾:
								<asp:Label id="Label_LLQ" runat="server" Width="42px" ForeColor="Black" BackColor="White">Label</asp:Label></FONT></FONT></TD>
				</TR>
				<tr>
					<td height="21">
						<p align="center"><font face="����" size="2"></font>&nbsp; <font face="��������" size="2">
								</font></p>
					</td>
				</tr>
				</TBODY></TABLE>
			</form>
		</div>
	</body>
</HTML>
