<%@ Page language="c#" Codebehind="chaxun.aspx.cs" AutoEventWireup="false" Inherits="tickets.chaxun" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>��ѯ</title>
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
						<TD style="HEIGHT: 61px"><FONT face="����">
								<P align="center"><FONT face="��������" size="7">
										<asp:Image id="Image2" runat="server" Width="666px" Height="96px" BackColor="White" ImageUrl="/images\biaoti.gif"></asp:Image></FONT></P>
							</FONT>
						</TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 44px"><FONT face="����">
								<TABLE id="Table2" style="WIDTH: 665px; HEIGHT: 30px" cellSpacing="0" cellPadding="0" width="659"
									border="0">
									<TR>
										<TD style="WIDTH: 115px"><asp:button id="Button_maipiao" runat="server" Height="27px" Width="133px" Text="��Ʊ"></asp:button></TD>
										<TD><asp:button id="Button_dingpiao" runat="server" Height="27px" Width="137px" Text="��Ʊ"></asp:button></TD>
										<TD style="WIDTH: 124px"><asp:button id="Button_tuipiao" runat="server" Height="27px" Width="122px" Text="��Ʊ"></asp:button></TD>
										<TD style="WIDTH: 121px"><asp:button id="Button_chaxun" runat="server" Height="27px" Width="125px" Text="��ѯ"></asp:button></TD>
										<TD><asp:button id="Button_yhgl" runat="server" Height="27px" Width="136px" Text="�û�����"></asp:button></TD>
									</TR>
								</TABLE>
							</FONT>
						</TD>
					</TR>
					<TR>
						<TD><FONT face="����">
								<P><FONT face="����">
										<TABLE id="Table3" style="WIDTH: 664px; HEIGHT: 116px" borderColor="buttonface" cellSpacing="0"
											cellPadding="0" width="664" border="1" DESIGNTIMEDRAGDROP="131">
											<TR>
												<TD style="WIDTH: 561px; HEIGHT: 18px" colSpan="4">�����β�ѯ</TD>
												<TD style="HEIGHT: 18px"><asp:button id="Button_cxcx" tabIndex="1" runat="server" Height="27px" Width="73px" Text="���²�ѯ"></asp:button></TD>
											</TR>
											<TR>
												<TD style="HEIGHT: 30px" align="right">�������ѯ����:</TD>
												<TD style="WIDTH: 248px; HEIGHT: 30px" colSpan="3"><asp:textbox id="TextBox_checi" tabIndex="2" runat="server" Width="168px"></asp:textbox></TD>
												<TD style="HEIGHT: 30px"><asp:button id="Button_chaxun1" tabIndex="3" runat="server" Height="27px" Width="74px" Text="��ѯ"></asp:button></TD>
											</TR>
											<TR>
												<TD colSpan="5" style="HEIGHT: 20px">����ʼվ��ѯ</TD>
											</TR>
											<TR>
												<TD align="right">��ʼվ:</TD>
												<TD style="WIDTH: 161px"><asp:textbox id="TextBox_qsz" tabIndex="4" runat="server" Height="28px" Width="168px"></asp:textbox></TD>
												<TD style="WIDTH: 75px">�յ�վ��</TD>
												<TD style="WIDTH: 169px"><asp:textbox id="TextBox_zdz" tabIndex="5" runat="server" Height="28px" Width="168px"></asp:textbox></TD>
												<TD><asp:button id="Button_chaxun2" tabIndex="6" runat="server" Height="27px" Width="77px" Text="��ѯ"></asp:button></TD>
											</TR>
										</TABLE>
									</FONT>
								</P>
							</FONT>
							<P><FONT face="����"><asp:datagrid id=DataGrid1 runat="server" Height="80px" Width="664px" CellPadding="4" BorderStyle="None" BorderWidth="1px" BorderColor="#3366CC" HorizontalAlign="Center" BackColor="White" Visible="False" AutoGenerateColumns="False" AllowPaging="True" AllowCustomPaging="True" DataMember="tickets" AllowSorting="True" DataKeyField="����" DataSource="<%# dataSet_chaxun1 %>">
										<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
										<ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
										<HeaderStyle Font-Size="Smaller" Font-Bold="True" HorizontalAlign="Center" ForeColor="White"
											VerticalAlign="Middle" BackColor="#339900"></HeaderStyle>
										<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
										<Columns>
											<asp:TemplateColumn HeaderText="���">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
												<ItemTemplate>
													<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.���") %>'>
													</asp:Label>
												</ItemTemplate>
												<EditItemTemplate>
													<asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.���") %>'>
													</asp:TextBox>
												</EditItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn DataField="����" HeaderText="����">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="��������" SortExpression="��������" HeaderText="��������">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="ʼ��վ" HeaderText="ʼ��վ">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="�յ�վ" HeaderText="�յ�վ">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="����ʱ��" HeaderText="����ʱ��" DataFormatString="{0:hh-mm}">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="����ʱ��" HeaderText="����ʱ��" DataFormatString="{0:hh-mm}">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
											</asp:BoundColumn>
											<asp:ButtonColumn Text="����" CommandName="Select">
												<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
											</asp:ButtonColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Left" ForeColor="White" BackColor="#339900" Mode="NumericPages"></PagerStyle>
									</asp:datagrid></FONT></P>
							<P><FONT face="����"></FONT>&nbsp;</P>
							<P>&nbsp;</P>
						</TD>
					</TR>
					<TR>
						<TD><FONT face="����"><FONT size="2">��ǰ�û�IP:</FONT>
								<asp:Label id="Label_IP" runat="server" Width="99px" BackColor="White" ForeColor="Black">Label</asp:Label><FONT size="2">������汾:
									<asp:Label id="Label_LLQ" runat="server" Width="42px" BackColor="White" ForeColor="Black">Label</asp:Label></FONT></FONT></TD>
					</TR>
					<TR>
						<TD>
							<P align="center"><FONT face="����" size="2"></FONT>&nbsp; <FONT face="��������" size="2">
									</FONT></P>
						</TD>
					</TR>
				</TABLE>
				&nbsp;
			</form>
		</div>
	</body>
</HTML>
