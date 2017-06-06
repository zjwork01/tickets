<%@ Page language="c#" Codebehind="gengxincheci.aspx.cs" AutoEventWireup="false" Inherits="tickets.gengxincheci" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>更新车次</title>
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
							<p align="center"><font face="华文中宋" size="7">
									<asp:Image id="Image2" runat="server" Width="624px" Height="96px" BackColor="White" ImageUrl="/images\biaoti.gif"></asp:Image></font></p>
						</td>
					</tr>
					<tr>
						<td height="26">
							<table id="table2" height="22" cellSpacing="0" borderColorDark="#ffffff" cellPadding="0"
								width="624" borderColorLight="#c0c0c0" border="1">
								<tr>
									<td align="center" width="124" height="18"><asp:button id="Button_maipiao" runat="server" Height="27px" Width="133px" Text="买票"></asp:button></td>
									<td align="center" width="124" height="18"><asp:button id="Button_dingpiao" runat="server" Height="27px" Width="120px" Text="订票"></asp:button></td>
									<td align="center" width="124" height="18"><asp:button id="Button_tuipiao" runat="server" Height="27px" Width="134px" Text="退票"></asp:button></td>
									<td align="center" width="124" height="18"><asp:button id="Button_chaxun" runat="server" Height="27px" Width="123px" Text="查询"></asp:button></td>
									<td align="center" width="125" height="18"><asp:button id="Button_yhgl" runat="server" Height="27px" Width="93px" Text="用户管理"></asp:button></td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td vAlign="top" align="left">
							<table id="table3" style="HEIGHT: 22px" cellSpacing="0" borderColorDark="#ffffff" cellPadding="0"
								width="630" borderColorLight="#c0c0c0" border="1">
								<tr>
									<td align="center" width="124"><asp:linkbutton id="LinkButton1" runat="server" ForeColor="Green">用户管理</asp:linkbutton></td>
									<td align="center" width="124"><FONT face="宋体"><asp:linkbutton id="LinkButton2" runat="server" ForeColor="Green">查询剩余票</asp:linkbutton></FONT></td>
									<td align="center" width="124"><asp:linkbutton id="LinkButton3" runat="server" ForeColor="Green">更新车次</asp:linkbutton></td>
									<TD align="center" width="124">
										<asp:linkbutton id="Linkbutton_xwgl" runat="server" ForeColor="Green">新闻管理</asp:linkbutton></TD>
									<TD align="center" width="124">
										<asp:linkbutton id="Linkbutton_xxfk" runat="server" ForeColor="Green">信息反馈</asp:linkbutton></TD>
									<td align="center" width="124" colSpan="2"><asp:linkbutton id="LinkButton4" runat="server" ForeColor="Green">销售情况查询</asp:linkbutton></td>
								</tr>
							</table>
                            
							<table id="table4" style="WIDTH: 631px; HEIGHT: 214px" cellSpacing="0" borderColorDark="#ffffff"
								cellPadding="0" width="631" borderColorLight="#c0c0c0" border="1">
								<tr>
									<td>车次基本信息：</td>
								</tr>
								<TR>
									<TD><FONT face="宋体">车次
											<asp:textbox id="TextBox＿checi" runat="server" Width="63px" tabIndex="1"></asp:textbox>起始站
											<asp:textbox id="TextBox_qsz" runat="server" Width="60px" tabIndex="2"></asp:textbox>终点站
											<asp:textbox id="TextBox_zdz" runat="server" Width="45px" tabIndex="3"></asp:textbox>开车时间
											<asp:textbox id="TextBox_kcsj" runat="server" Width="72px" tabIndex="4"></asp:textbox>到达时间
											<asp:textbox id="TextBox_ddsj" runat="server" Width="81px" tabIndex="5"></asp:textbox></FONT></TD>
								</TR>
								<TR>
									<TD><FONT face="宋体">各座位票数：</FONT></TD>
								</TR>
								<TR>
									<TD><FONT face="宋体">硬座
											<asp:textbox id="TextBox_yzps" runat="server" Width="34px" tabIndex="6"></asp:textbox><FONT face="宋体">硬卧上
												<asp:textbox id="TextBox_ywsps" runat="server" Width="34px" tabIndex="7"></asp:textbox>硬卧中
												<asp:textbox id="TextBox_ywzps" runat="server" Width="34px" tabIndex="8"></asp:textbox>硬卧下
												<asp:textbox id="TextBox_ywxps" runat="server" Width="34px" tabIndex="9"></asp:textbox>软卧上
												<asp:textbox id="TextBox_rwsps" runat="server" Width="34px" tabIndex="10"></asp:textbox>软卧中
												<asp:textbox id="TextBox_rwzps" runat="server" Width="34px" tabIndex="11"></asp:textbox>软卧下
												<asp:textbox id="TextBox_rwxps" runat="server" Width="34px" tabIndex="12"></asp:textbox></FONT></FONT></TD>
								</TR>
								<TR>
									<TD><FONT face="宋体">车辆类型信息：</FONT></TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 4px"><FONT face="宋体">&nbsp; 有无空调
											<asp:dropdownlist id="DropDownList_ywkt" runat="server" Width="67px" tabIndex="13">
												<asp:ListItem Value="空调">有</asp:ListItem>
												<asp:ListItem Value="无">无</asp:ListItem>
											</asp:dropdownlist>车辆类型
											<asp:dropdownlist id="DropDownList_cllx" runat="server" Width="75px" tabIndex="14">
												<asp:ListItem Value="普通">普通</asp:ListItem>
												<asp:ListItem Value="普快">普快</asp:ListItem>
												<asp:ListItem Value="特快">特快</asp:ListItem>
												<asp:ListItem></asp:ListItem>
											</asp:dropdownlist></FONT></TD>
								</TR>
								<TR>
									<TD><FONT face="宋体">车厢容量信息：</FONT></TD>
								</TR>
								<TR>
									<TD><FONT face="宋体">硬座车厢数
											<asp:textbox id="TextBox_yzcxs" runat="server" Width="63px" tabIndex="15"></asp:textbox>硬座车厢人数
											<asp:textbox id="TextBox_yzcxrs" runat="server" Width="48px" tabIndex="16"></asp:textbox>硬卧车厢数
											<asp:textbox id="TextBox_ywcxs" runat="server" Width="60px" tabIndex="17"></asp:textbox>硬卧车厢人数
											<asp:textbox id="TextBox_ywcxrs" runat="server" Width="63px" tabIndex="18"></asp:textbox></FONT></TD>
								</TR>
								<TR>
									<TD><FONT face="宋体">软卧车厢数
											<asp:textbox id="TextBox_rwcxs" runat="server" Width="63px" tabIndex="19"></asp:textbox>软卧车厢人数
											<asp:textbox id="TextBox_rwcxrs" runat="server" Width="48px" tabIndex="20"></asp:textbox>&nbsp;
											<asp:button id="Button_zengjia" runat="server" Height="27px" Width="78px" Text="增加" tabIndex="21"></asp:button><asp:button id="gengxin" runat="server" Height="27px" Width="78px" Text="更新" tabIndex="22"></asp:button></FONT></TD>
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
									<td align="center" width="124"><asp:button id="Button_zjjbxx" runat="server" Height="27px" Width="110px" Text="增加车次" tabIndex="23"></asp:button></td>
									<td align="center" width="124"><asp:button id="Button_xgjbxx" runat="server" Height="27px" Width="113px" Text="修改车次信息" tabIndex="24"></asp:button></td>
                                    <td align="center" width="124"><asp:button id="Button_scjbxx" runat="server" Height="27px" Width="113px" Text="删除当前车次" tabIndex="24"/></td>
									<td align="center" width="124"><asp:button id="Button_qrcc" runat="server" Height="27px" Width="94px" Text="确认车次" tabIndex="25"></asp:button></td>
									<td style="WIDTH: 124px" align="center" width="124"><asp:button id="Button_zjldxx" runat="server" Height="27px" Width="114px" Text="编辑路段信息" tabIndex="26"></asp:button></td>
									<td align="center" width="124"><asp:button id="Button_czjbxx" runat="server" Height="27px" Width="78px" Text="重置" tabIndex="27"></asp:button></td>
								</tr>
							</table>
							<table id="table9" height="354" cellSpacing="0" borderColorDark="#ffffff" cellPadding="0"
								width="100%" borderColorLight="#c0c0c0" border="1">
								<tr>
									<td colSpan="3" height="21">具体路段信息:</td>
								</tr>
								<tr>
									<td style="HEIGHT: 300px" vAlign="top" align="center" colSpan="3"><FONT face="宋体"><asp:datagrid id=DataGrid1 runat="server" Height="30px" Width="613px" AllowPaging="True" AutoGenerateColumns="False" DataMember="ticketsinf" DataKeyField="序号" DataSource="<%# dataSet_ticketsinf %>" CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#CCCCCC">
												<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
												<ItemStyle ForeColor="#000066"></ItemStyle>
												<HeaderStyle Font-Bold="True" HorizontalAlign="Center" ForeColor="White" VerticalAlign="Middle"
													BackColor="#339900"></HeaderStyle>
												<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
												<Columns>
													<asp:BoundColumn DataField="序号" HeaderText="序号">
														<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="车次" HeaderText="车次">
														<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="开车时间" HeaderText="开车时间" DataFormatString="{0:hh-mm}">
														<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="到达时间" HeaderText="到达时间" DataFormatString="{0:hh-mm}">
														<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="出发站" HeaderText="出发站">
														<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="到达站" HeaderText="到达站">
														<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
													</asp:BoundColumn>
													<asp:BoundColumn DataField="行程" HeaderText="行程">
														<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
													</asp:BoundColumn>
													<asp:ButtonColumn Text="编辑" CommandName="Select">
														<ItemStyle Font-Size="X-Small"></ItemStyle>
													</asp:ButtonColumn>
													<asp:ButtonColumn Text="删除" CommandName="Delete">
														<ItemStyle Font-Size="X-Small"></ItemStyle>
													</asp:ButtonColumn>
												</Columns>
												<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#339900" Mode="NumericPages"></PagerStyle>
											</asp:datagrid></FONT></td>
								</tr>
								<tr>
									<td style="WIDTH: 465px" width="465" bgColor="lightblue" height="25"><FONT face="宋体">输入要修改的车次
											<asp:textbox id="Textbox_xgcc" runat="server" Width="63px" tabIndex="28"></asp:textbox><asp:button id="Button_xiugai" runat="server" Height="23px" Width="93px" Text="修改以有信息" tabIndex="28"></asp:button></FONT></td>
									<td style="WIDTH: 98px" align="center" width="98" bgColor="lightblue" colSpan="1" height="25"
										rowSpan="1"><asp:button id="Button_zj" runat="server" Height="23px" Width="82px" Text="增加" tabIndex="29"></asp:button></td>
									<td align="center" width="12%" height="25"><asp:button id="Button_czldxx" runat="server" Height="23px" Width="73px" Text="重置" tabIndex="30"></asp:button></td>
								</tr>
							</table>
							<table id="table10" style="WIDTH: 637px; HEIGHT: 66px" height="66" cellSpacing="0" borderColorDark="#ffffff"
								cellPadding="0" width="637" borderColorLight="#c0c0c0" border="1">
								<tr>
									<td style="HEIGHT: 13px" colSpan="7">编辑路段信息:</td>
								</tr>
								<tr>
									<td style="WIDTH: 87px; HEIGHT: 23px" align="right" width="87" height="23">
										<asp:Label id="xuhao" runat="server" Width="2px" Visible="False"></asp:Label>车次:</td>
									<td style="WIDTH: 96px; HEIGHT: 23px" align="right" width="96" height="23"><asp:textbox id="TextBox_ldcc" runat="server" Width="113px" tabIndex="31"></asp:textbox></td>
									<td style="WIDTH: 114px; HEIGHT: 23px" align="right" width="114" height="23">出发站:</td>
									<td style="HEIGHT: 23px" align="right" width="104" height="23"><asp:textbox id="TextBox_ldcfz" runat="server" Width="113px" tabIndex="32"></asp:textbox></td>
									<td style="WIDTH: 96px; HEIGHT: 23px" align="right" width="96" height="23">到达站:</td>
									<td style="HEIGHT: 23px" align="right" width="119" colSpan="2" height="23"><asp:textbox id="TextBox_ldddz" runat="server" Width="113px" tabIndex="33"></asp:textbox></td>
								</tr>
								<TR>
									<TD style="HEIGHT: 23px" width="103" colSpan="7" height="23"><FONT face="宋体">
											<TABLE id="Table11" cellSpacing="1" cellPadding="1" width="631" border="1">
												<TR>
													<TD>开车时间
														<asp:textbox id="Textbox_ldkcsj" runat="server" Width="93px" tabIndex="34"></asp:textbox>到达时间
														<asp:textbox id="Textbox_ldddsj" runat="server" Width="96px" tabIndex="35"></asp:textbox>路程
														<asp:textbox id="Textbox_lc" runat="server" Width="64px" tabIndex="36"></asp:textbox>
														<asp:button id="Button_bjzj" runat="server" Text="增加" Width="46px" Height="23px" tabIndex="37"></asp:button>
														<asp:button id="Button_bjgx" runat="server" Text="更新" Width="43px" Height="23px" tabIndex="38"></asp:button>
														<asp:button id="Button_chongzhi" runat="server" Text="重置" Width="57px" Height="23px" tabIndex="39"></asp:button></TD>
												</TR>
											</TABLE>
										</FONT>
									</TD>
								</TR>
							</table>
							<FONT face="宋体"><FONT size="2">当前用户IP:</FONT>
								<asp:Label id="Label_IP" runat="server" Width="99px" ForeColor="Black" BackColor="White">Label</asp:Label><FONT size="2">浏览器版本:
									<asp:Label id="Label_LLQ" runat="server" Width="42px" ForeColor="Black" BackColor="White">Label</asp:Label></FONT></FONT>
						</td>
					</tr>
					<tr>
						<td height="21">
							<p align="center"><font face="宋体" size="2"></font>&nbsp; <font face="华文中宋" size="2">
									</font></p>
						</td>
					</tr>
				</table>
			</form>
		</div>
	</body>
</HTML>
