<%@ Page language="c#" Codebehind="gengxincheci.aspx.cs" AutoEventWireup="false" Inherits="tickets.gengxincheci" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>���³���</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body background="/images\bg.gif" MS_POSITIONING="GridLayout">
		<div align="center">
			<form id="Form2" method="post" runat="server">
				<table id="table1" style="WIDTH: 615px; HEIGHT: 872px" height="872" cellSpacing="0" borderColorDark="#ffffff"
					cellPadding="0" width="615" borderColorLight="#c0c0c0" border="1">
					<tr>
						<td height="59">
							<p align="center"><font face="��������" size="7">
									<asp:Image id="Image2" runat="server" Width="624px" Height="96px" BackColor="White" ImageUrl="/images\biaoti.gif"></asp:Image></font></p>
						</td>
					</tr>
					<tr>
						<td height="26">
							<table id="table2" height="22" cellSpacing="0" borderColorDark="#ffffff" cellPadding="0"
								width="624" borderColorLight="#c0c0c0" border="1">
								<tr>
									<td align="center" width="124" height="18"><asp:button id="Button_maipiao" runat="server" Height="27px" Width="133px" Text="��Ʊ"></asp:button></td>
									<td align="center" width="124" height="18"><asp:button id="Button_dingpiao" runat="server" Height="27px" Width="120px" Text="��Ʊ"></asp:button></td>
									<td align="center" width="124" height="18"><asp:button id="Button_tuipiao" runat="server" Height="27px" Width="134px" Text="��Ʊ"></asp:button></td>
									<td align="center" width="124" height="18"><asp:button id="Button_chaxun" runat="server" Height="27px" Width="123px" Text="��ѯ"></asp:button></td>
									<td align="center" width="125" height="18"><asp:button id="Button_yhgl" runat="server" Height="27px" Width="93px" Text="�û�����"></asp:button></td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td vAlign="top" align="left">
							<table id="table3" style="HEIGHT: 22px" cellSpacing="0" borderColorDark="#ffffff" cellPadding="0"
								width="630" borderColorLight="#c0c0c0" border="1">
								<tr>
									<td align="center" width="124"><asp:linkbutton id="LinkButton1" runat="server" ForeColor="Green">�û�����</asp:linkbutton></td>
									<td align="center" width="124"><FONT face="����"><asp:linkbutton id="LinkButton2" runat="server" ForeColor="Green">��ѯʣ��Ʊ</asp:linkbutton></FONT></td>
									<td align="center" width="124"><asp:linkbutton id="LinkButton3" runat="server" ForeColor="Green">���³���</asp:linkbutton></td>
									<TD align="center" width="124">
										<asp:linkbutton id="Linkbutton_xwgl" runat="server" ForeColor="Green">���Ź���</asp:linkbutton></TD>
									<TD align="center" width="124">
										<asp:linkbutton id="Linkbutton_xxfk" runat="server" ForeColor="Green">��Ϣ����</asp:linkbutton></TD>
									<td align="center" width="124" colSpan="2"><asp:linkbutton id="LinkButton4" runat="server" ForeColor="Green">���������ѯ</asp:linkbutton></td>
								</tr>
							</table>
                            
							<table id="table4" style="WIDTH: 631px; HEIGHT: 214px" cellSpacing="0" borderColorDark="#ffffff"
								cellPadding="0" width="631" borderColorLight="#c0c0c0" border="1">
								<tr>
									<td>���λ�����Ϣ��</td>
								</tr>
								<TR>
									<TD><FONT face="����">����
											<asp:textbox id="TextBox��checi" runat="server" Width="63px" tabIndex="1"></asp:textbox>��ʼվ
											<asp:textbox id="TextBox_qsz" runat="server" Width="60px" tabIndex="2"></asp:textbox>�յ�վ
											<asp:textbox id="TextBox_zdz" runat="server" Width="45px" tabIndex="3"></asp:textbox>����ʱ��
											<asp:textbox id="TextBox_kcsj" runat="server" Width="72px" tabIndex="4"></asp:textbox>����ʱ��
											<asp:textbox id="TextBox_ddsj" runat="server" Width="81px" tabIndex="5"></asp:textbox></FONT></TD>
								</TR>
								<TR>
									<TD><FONT face="����">����λƱ����</FONT></TD>
								</TR>
								<TR>
									<TD><FONT face="����">Ӳ��
											<asp:textbox id="TextBox_yzps" runat="server" Width="34px" tabIndex="6"></asp:textbox><FONT face="����">Ӳ����
												<asp:textbox id="TextBox_ywsps" runat="server" Width="34px" tabIndex="7"></asp:textbox>Ӳ����
												<asp:textbox id="TextBox_ywzps" runat="server" Width="34px" tabIndex="8"></asp:textbox>Ӳ����
												<asp:textbox id="TextBox_ywxps" runat="server" Width="34px" tabIndex="9"></asp:textbox>������
												<asp:textbox id="TextBox_rwsps" runat="server" Width="34px" tabIndex="10"></asp:textbox>������
												<asp:textbox id="TextBox_rwzps" runat="server" Width="34px" tabIndex="11"></asp:textbox>������
												<asp:textbox id="TextBox_rwxps" runat="server" Width="34px" tabIndex="12"></asp:textbox></FONT></FONT></TD>
								</TR>
								<TR>
									<TD><FONT face="����">����������Ϣ��</FONT></TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 4px"><FONT face="����">&nbsp; ���޿յ�
											<asp:dropdownlist id="DropDownList_ywkt" runat="server" Width="67px" tabIndex="13">
												<asp:ListItem Value="�յ�">��</asp:ListItem>
												<asp:ListItem Value="��">��</asp:ListItem>
											</asp:dropdownlist>��������
											<asp:dropdownlist id="DropDownList_cllx" runat="server" Width="75px" tabIndex="14">
												<asp:ListItem Value="��ͨ">��ͨ</asp:ListItem>
												<asp:ListItem Value="�տ�">�տ�</asp:ListItem>
												<asp:ListItem Value="�ؿ�">�ؿ�</asp:ListItem>
												<asp:ListItem></asp:ListItem>
											</asp:dropdownlist></FONT></TD>
								</TR>
								<TR>
									<TD><FONT face="����">����������Ϣ��</FONT></TD>
								</TR>
								<TR>
									<TD><FONT face="����">Ӳ��������
											<asp:textbox id="TextBox_yzcxs" runat="server" Width="63px" tabIndex="15"></asp:textbox>Ӳ����������
											<asp:textbox id="TextBox_yzcxrs" runat="server" Width="48px" tabIndex="16"></asp:textbox>Ӳ�Գ�����
											<asp:textbox id="TextBox_ywcxs" runat="server" Width="60px" tabIndex="17"></asp:textbox>Ӳ�Գ�������
											<asp:textbox id="TextBox_ywcxrs" runat="server" Width="63px" tabIndex="18"></asp:textbox></FONT></TD>
								</TR>
								<TR>
									<TD><FONT face="����">���Գ�����
											<asp:textbox id="TextBox_rwcxs" runat="server" Width="63px" tabIndex="19"></asp:textbox>���Գ�������
											<asp:textbox id="TextBox_rwcxrs" runat="server" Width="48px" tabIndex="20"></asp:textbox>&nbsp;
											<asp:button id="Button_zengjia" runat="server" Height="27px" Width="78px" Text="����" tabIndex="21"></asp:button><asp:button id="gengxin" runat="server" Height="27px" Width="78px" Text="����" tabIndex="22"></asp:button></FONT></TD>
								</TR>
							</table>
							<table id="table5" cellSpacing="0" borderColorDark="#ffffff" cellPadding="0" width="630"
								borderColorLight="#c0c0c0" border="1">
							</table>
							<table id="table6" cellSpacing="0" borderColorDark="#ffffff" cellPadding="0" width="630"
								borderColorLight="#c0c0c0" border="1">
							</table>
							<table id="table7" cellSpacing="0" borderColorDark="#ffffff" cellPadding="0" width="630"
								borderColorLight="#c0c0c0" border="1">
							</table>
							<table id="table8" cellSpacing="0" borderColorDark="#ffffff" cellPadding="0" width="630"
								borderColorLight="#c0c0c0" border="1">
								<tr>
									<td align="center" width="124"><asp:button id="Button_zjjbxx" runat="server" Height="27px" Width="110px" Text="���ӳ���" tabIndex="23"></asp:button></td>
									<td align="center" width="124"><asp:button id="Button_xgjbxx" runat="server" Height="27px" Width="113px" Text="�޸ĳ�����Ϣ" tabIndex="24"></asp:button></td>
                                    <td align="center" width="124"><asp:button id="Button_scjbxx" runat="server" Height="27px" Width="113px" Text="ɾ����ǰ����" tabIndex="24"/></td>
									<td align="center" width="124"><asp:button id="Button_qrcc" runat="server" Height="27px" Width="94px" Text="ȷ�ϳ���" tabIndex="25"></asp:button></td>
									<td style="WIDTH: 124px" align="center" width="124"><asp:button id="Button_zjldxx" runat="server" Height="27px" Width="114px" Text="�༭·����Ϣ" tabIndex="26"></asp:button></td>
									<td align="center" width="124"><asp:button id="Button_czjbxx" runat="server" Height="27px" Width="78px" Text="����" tabIndex="27"></asp:button></td>
								</tr>
							</table>
							<table id="table9" height="354" cellSpacing="0" borderColorDark="#ffffff" cellPadding="0"
								width="100%" borderColorLight="#c0c0c0" border="1">
								<tr>
									<td colSpan="3" height="21">����·����Ϣ:</td>
								</tr>
								<tr>
									<td style="HEIGHT: 300px" vAlign="top" align="center" colSpan="3"><FONT face="����"><asp:datagrid id=DataGrid1 runat="server" Height="30px" Width="613px" AllowPaging="True" AutoGenerateColumns="False" DataMember="ticketsinf" DataKeyField="���" DataSource="<%# dataSet_ticketsinf %>" CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#CCCCCC">
												<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
												<ItemStyle ForeColor="#000066"></ItemStyle>
												<HeaderStyle Font-Bold="True" HorizontalAlign="Center" ForeColor="White" VerticalAlign="Middle"
													BackColor="#339900"></HeaderStyle>
												<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
												<Columns>
													<asp:BoundColumn DataField="���" HeaderText="���">
														<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="����" HeaderText="����">
														<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="����ʱ��" HeaderText="����ʱ��" DataFormatString="{0:hh-mm}">
														<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="����ʱ��" HeaderText="����ʱ��" DataFormatString="{0:hh-mm}">
														<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="����վ" HeaderText="����վ">
														<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="����վ" HeaderText="����վ">
														<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="�г�" HeaderText="�г�">
														<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
													</asp:BoundColumn>
													<asp:ButtonColumn Text="�༭" CommandName="Select">
														<ItemStyle Font-Size="X-Small"></ItemStyle>
													</asp:ButtonColumn>
													<asp:ButtonColumn Text="ɾ��" CommandName="Delete">
														<ItemStyle Font-Size="X-Small"></ItemStyle>
													</asp:ButtonColumn>
												</Columns>
												<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#339900" Mode="NumericPages"></PagerStyle>
											</asp:datagrid></FONT></td>
								</tr>
								<tr>
									<td style="WIDTH: 465px" width="465" bgColor="lightblue" height="25"><FONT face="����">����Ҫ�޸ĵĳ���
											<asp:textbox id="Textbox_xgcc" runat="server" Width="63px" tabIndex="28"></asp:textbox><asp:button id="Button_xiugai" runat="server" Height="23px" Width="93px" Text="�޸�������Ϣ" tabIndex="28"></asp:button></FONT></td>
									<td style="WIDTH: 98px" align="center" width="98" bgColor="lightblue" colSpan="1" height="25"
										rowSpan="1"><asp:button id="Button_zj" runat="server" Height="23px" Width="82px" Text="����" tabIndex="29"></asp:button></td>
									<td align="center" width="12%" height="25"><asp:button id="Button_czldxx" runat="server" Height="23px" Width="73px" Text="����" tabIndex="30"></asp:button></td>
								</tr>
							</table>
							<table id="table10" style="WIDTH: 637px; HEIGHT: 66px" height="66" cellSpacing="0" borderColorDark="#ffffff"
								cellPadding="0" width="637" borderColorLight="#c0c0c0" border="1">
								<tr>
									<td style="HEIGHT: 13px" colSpan="7">�༭·����Ϣ:</td>
								</tr>
								<tr>
									<td style="WIDTH: 87px; HEIGHT: 23px" align="right" width="87" height="23">
										<asp:Label id="xuhao" runat="server" Width="2px" Visible="False"></asp:Label>����:</td>
									<td style="WIDTH: 96px; HEIGHT: 23px" align="right" width="96" height="23"><asp:textbox id="TextBox_ldcc" runat="server" Width="113px" tabIndex="31"></asp:textbox></td>
									<td style="WIDTH: 114px; HEIGHT: 23px" align="right" width="114" height="23">����վ:</td>
									<td style="HEIGHT: 23px" align="right" width="104" height="23"><asp:textbox id="TextBox_ldcfz" runat="server" Width="113px" tabIndex="32"></asp:textbox></td>
									<td style="WIDTH: 96px; HEIGHT: 23px" align="right" width="96" height="23">����վ:</td>
									<td style="HEIGHT: 23px" align="right" width="119" colSpan="2" height="23"><asp:textbox id="TextBox_ldddz" runat="server" Width="113px" tabIndex="33"></asp:textbox></td>
								</tr>
								<TR>
									<TD style="HEIGHT: 23px" width="103" colSpan="7" height="23"><FONT face="����">
											<TABLE id="Table11" cellSpacing="1" cellPadding="1" width="631" border="1">
												<TR>
													<TD>����ʱ��
														<asp:textbox id="Textbox_ldkcsj" runat="server" Width="93px" tabIndex="34"></asp:textbox>����ʱ��
														<asp:textbox id="Textbox_ldddsj" runat="server" Width="96px" tabIndex="35"></asp:textbox>·��
														<asp:textbox id="Textbox_lc" runat="server" Width="64px" tabIndex="36"></asp:textbox>
														<asp:button id="Button_bjzj" runat="server" Text="����" Width="46px" Height="23px" tabIndex="37"></asp:button>
														<asp:button id="Button_bjgx" runat="server" Text="����" Width="43px" Height="23px" tabIndex="38"></asp:button>
														<asp:button id="Button_chongzhi" runat="server" Text="����" Width="57px" Height="23px" tabIndex="39"></asp:button></TD>
												</TR>
											</TABLE>
										</FONT>
									</TD>
								</TR>
							</table>
							<FONT face="����"><FONT size="2">��ǰ�û�IP:</FONT>
								<asp:Label id="Label_IP" runat="server" Width="99px" ForeColor="Black" BackColor="White">Label</asp:Label><FONT size="2">������汾:
									<asp:Label id="Label_LLQ" runat="server" Width="42px" ForeColor="Black" BackColor="White">Label</asp:Label></FONT></FONT>
						</td>
					</tr>
					<tr>
						<td height="21">
							<p align="center"><font face="����" size="2"></font>&nbsp; <font face="��������" size="2">
									</font></p>
						</td>
					</tr>
				</table>
			</form>
		</div>
	</body>
</HTML>
