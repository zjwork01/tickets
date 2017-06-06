<%@ Page language="c#" Codebehind="shoupiaoqingkuangtongji.aspx.cs" AutoEventWireup="false" Inherits="tickets.shoupiaoqingkuangtongji" smartNavigation="False"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>列车售票系统--售票情况统计</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body background="/images\bg.gif" MS_POSITIONING="GridLayout">
		<div align="center">
			<form id="Form1" method="post" runat="server">
				<table id="table1" height="673" borderColorDark="#ffffff" width="630" borderColorLight="#c0c0c0"
					border="1">
					<tr>
						<td height="59">
							<p align="center"><font face="华文中宋" size="7">
									<asp:Image id="Image2" runat="server" Height="98px" Width="713px" ImageUrl="/images\biaoti.gif"></asp:Image></font></p>
						</td>
					</tr>
					<tr>
						<td height="26">
							<table id="table2" height="22" cellSpacing="1" borderColorDark="#ffffff" width="624" borderColorLight="#c0c0c0"
								border="1">
								<tr>
									<td align="center" width="124" height="18"><asp:button id="Button_maipiao" runat="server" Text="买票" Width="133px" Height="27px"></asp:button></td>
									<td align="center" width="124" height="18"><asp:button id="Button_dingpiao" runat="server" Text="订票" Width="120px" Height="27px"></asp:button></td>
									<td align="center" width="124" height="18"><asp:button id="Button_tuipiao" runat="server" Text="退票" Width="134px" Height="27px"></asp:button></td>
									<td align="center" width="124" height="18"><asp:button id="Button_chaxun" runat="server" Text="查询" Width="125px" Height="27px"></asp:button></td>
									<td align="center" width="125" height="18"><asp:button id="Button_yhgl" runat="server" Text="用户管理" Width="163px" Height="27px"></asp:button></td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td vAlign="top" align="left">
							<table id="table3" style="HEIGHT: 26px" cellSpacing="1" borderColorDark="#ffffff" width="716"
								borderColorLight="#c0c0c0" border="1">
								<tr>
									<td align="center" width="124"><asp:linkbutton id="LinkButton1" runat="server" ForeColor="Green">管理用户</asp:linkbutton></td>
									<td align="center" width="124"><FONT face="宋体"><asp:linkbutton id="LinkButton2" runat="server" ForeColor="Green">查询剩余票</asp:linkbutton></FONT></td>
									<td align="center" width="124"><asp:linkbutton id="LinkButton3" runat="server" ForeColor="Green">更新车次</asp:linkbutton></td>
									<TD align="center" width="124">
										<asp:linkbutton id="Linkbutton_xwgl" runat="server" ForeColor="Green">新闻管理</asp:linkbutton></TD>
									<TD align="center" width="124">
										<asp:linkbutton id="Linkbutton_xxfk" runat="server" ForeColor="Green">信息反馈</asp:linkbutton></TD>
									<td align="center" width="124" colSpan="2"><asp:linkbutton id="LinkButton4" runat="server" ForeColor="Green">销售情况统计</asp:linkbutton></td>
								</tr>
							</table>
							<table id="table4" cellSpacing="0" borderColorDark="#ffffff" width="100%" borderColorLight="#c0c0c0"
								border="1">
								<tr>
									<td colSpan="5">请设置查询条件</td>
								</tr>
								<TR>
									<TD style="HEIGHT: 24px" align="right" width="15%" colSpan="5"><FONT face="宋体">按起始日期查询&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
											&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
											&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										</FONT>
									</TD>
								</TR>
								<tr>
									<td style="HEIGHT: 62px" align="right" width="15%" colSpan="5">
										<P>从
											<asp:dropdownlist id="Dl_nian" runat="server" Width="60px" tabIndex="1">
												<asp:ListItem Value="2004">2004</asp:ListItem>
												<asp:ListItem Value="2005">2005</asp:ListItem>
												<asp:ListItem Value="2006">2006</asp:ListItem>
											</asp:dropdownlist>&nbsp;年
											<asp:dropdownlist id="Dl_yue" runat="server" Width="50px" tabIndex="2">
												<asp:ListItem Value="01">01</asp:ListItem>
												<asp:ListItem Value="02">02</asp:ListItem>
												<asp:ListItem Value="03">03</asp:ListItem>
												<asp:ListItem Value="04">04</asp:ListItem>
												<asp:ListItem Value="05">05</asp:ListItem>
												<asp:ListItem Value="06">06</asp:ListItem>
												<asp:ListItem Value="07">07</asp:ListItem>
												<asp:ListItem Value="08">08</asp:ListItem>
												<asp:ListItem Value="09">09</asp:ListItem>
												<asp:ListItem Value="10">10</asp:ListItem>
												<asp:ListItem Value="11">11</asp:ListItem>
												<asp:ListItem Value="12">12</asp:ListItem>
												<asp:ListItem></asp:ListItem>
											</asp:dropdownlist>月
											<asp:dropdownlist id="Dl_ri" runat="server" Width="50px" tabIndex="3">
												<asp:ListItem Value="1">1</asp:ListItem>
												<asp:ListItem Value="2">2</asp:ListItem>
												<asp:ListItem Value="3">3</asp:ListItem>
												<asp:ListItem Value="4">4</asp:ListItem>
												<asp:ListItem Value="5">5</asp:ListItem>
												<asp:ListItem Value="6">6</asp:ListItem>
												<asp:ListItem Value="7">7</asp:ListItem>
												<asp:ListItem Value="8">8</asp:ListItem>
												<asp:ListItem Value="9">9</asp:ListItem>
												<asp:ListItem Value="10">10</asp:ListItem>
												<asp:ListItem Value="11">11</asp:ListItem>
												<asp:ListItem Value="12">12</asp:ListItem>
												<asp:ListItem Value="13">13</asp:ListItem>
												<asp:ListItem Value="14">14</asp:ListItem>
												<asp:ListItem Value="15">15</asp:ListItem>
												<asp:ListItem Value="16">16</asp:ListItem>
												<asp:ListItem Value="17">17</asp:ListItem>
												<asp:ListItem Value="18">18</asp:ListItem>
												<asp:ListItem Value="19">19</asp:ListItem>
												<asp:ListItem Value="20">20</asp:ListItem>
												<asp:ListItem Value="21">21</asp:ListItem>
												<asp:ListItem Value="22">22</asp:ListItem>
												<asp:ListItem Value="23">23</asp:ListItem>
												<asp:ListItem Value="24">24</asp:ListItem>
												<asp:ListItem Value="25">25</asp:ListItem>
												<asp:ListItem Value="26">26</asp:ListItem>
												<asp:ListItem Value="27">27</asp:ListItem>
												<asp:ListItem Value="28">28</asp:ListItem>
												<asp:ListItem Value="29">29</asp:ListItem>
												<asp:ListItem Value="30">30</asp:ListItem>
												<asp:ListItem Value="31">31</asp:ListItem>
											</asp:dropdownlist>日&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
											&nbsp;到&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
											<asp:dropdownlist id="Dl_nian1" runat="server" Width="60px" tabIndex="4">
												<asp:ListItem Value="2004">2004</asp:ListItem>
												<asp:ListItem Value="2005">2005</asp:ListItem>
												<asp:ListItem Value="2006">2006</asp:ListItem>
											</asp:dropdownlist>&nbsp;年
											<asp:dropdownlist id="Dl_yue1" runat="server" Width="50px" tabIndex="5">
												<asp:ListItem Value="01">01</asp:ListItem>
												<asp:ListItem Value="02">02</asp:ListItem>
												<asp:ListItem Value="03">03</asp:ListItem>
												<asp:ListItem Value="04">04</asp:ListItem>
												<asp:ListItem Value="05">05</asp:ListItem>
												<asp:ListItem Value="06">06</asp:ListItem>
												<asp:ListItem Value="07">07</asp:ListItem>
												<asp:ListItem Value="08">08</asp:ListItem>
												<asp:ListItem Value="09">09</asp:ListItem>
												<asp:ListItem Value="10">10</asp:ListItem>
												<asp:ListItem Value="11">11</asp:ListItem>
												<asp:ListItem Value="12">12</asp:ListItem>
												<asp:ListItem></asp:ListItem>
											</asp:dropdownlist>月
											<asp:dropdownlist id="Dl_ri1" runat="server" Width="50px" tabIndex="6">
												<asp:ListItem Value="1">1</asp:ListItem>
												<asp:ListItem Value="2">2</asp:ListItem>
												<asp:ListItem Value="3">3</asp:ListItem>
												<asp:ListItem Value="4">4</asp:ListItem>
												<asp:ListItem Value="5">5</asp:ListItem>
												<asp:ListItem Value="6">6</asp:ListItem>
												<asp:ListItem Value="7">7</asp:ListItem>
												<asp:ListItem Value="8">8</asp:ListItem>
												<asp:ListItem Value="9">9</asp:ListItem>
												<asp:ListItem Value="10">10</asp:ListItem>
												<asp:ListItem Value="11">11</asp:ListItem>
												<asp:ListItem Value="12">12</asp:ListItem>
												<asp:ListItem Value="13">13</asp:ListItem>
												<asp:ListItem Value="14">14</asp:ListItem>
												<asp:ListItem Value="15">15</asp:ListItem>
												<asp:ListItem Value="16">16</asp:ListItem>
												<asp:ListItem Value="17">17</asp:ListItem>
												<asp:ListItem Value="18">18</asp:ListItem>
												<asp:ListItem Value="19">19</asp:ListItem>
												<asp:ListItem Value="20">20</asp:ListItem>
												<asp:ListItem Value="21">21</asp:ListItem>
												<asp:ListItem Value="22">22</asp:ListItem>
												<asp:ListItem Value="23">23</asp:ListItem>
												<asp:ListItem Value="24">24</asp:ListItem>
												<asp:ListItem Value="25">25</asp:ListItem>
												<asp:ListItem Value="26">26</asp:ListItem>
												<asp:ListItem Value="27">27</asp:ListItem>
												<asp:ListItem Value="28">28</asp:ListItem>
												<asp:ListItem Value="29">29</asp:ListItem>
												<asp:ListItem Value="30">30</asp:ListItem>
												<asp:ListItem Value="31">31</asp:ListItem>
											</asp:dropdownlist>日&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
											&nbsp;&nbsp;</P>
										<P>&nbsp;查询方式:
											<asp:dropdownlist id="Dl_cxfs" runat="server" Width="80px" AutoPostBack="True" tabIndex="7">
												<asp:ListItem Value="按车次">按车次</asp:ListItem>
												<asp:ListItem Value="按售票点">按售票点</asp:ListItem>
												<asp:ListItem Value="查询所有">查询所有</asp:ListItem>
											</asp:dropdownlist><asp:dropdownlist id="DropDownList_tjfs" runat="server" Width="55px" tabIndex="8">
												<asp:ListItem Value="记录">记录</asp:ListItem>
												<asp:ListItem Value="合计">合计</asp:ListItem>
											</asp:dropdownlist>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; 代售点
											<asp:dropdownlist id="Dl_dsdbh" runat="server" AutoPostBack="True" tabIndex="9"></asp:dropdownlist><asp:textbox id="TextBox_dsd" runat="server" Width="163px"></asp:textbox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
											<asp:label id="dsdbh" runat="server" Visible="False">Label</asp:label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
									</td>
								</tr>
								<TR>
									<TD style="HEIGHT: 22px" width="15%" colSpan="5"><FONT face="宋体"> &nbsp;按车次查询</FONT></TD>
								</TR>
								<tr>
									<td width="15%" colSpan="5">
										<P align="right">请输入车次:
											<asp:textbox id="TextBox_checi" runat="server" Width="163px" tabIndex="10"></asp:textbox><asp:button id="Button_chx" runat="server" Text="查询" Width="57px" Height="23px" tabIndex="11"></asp:button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										</P>
									</td>
								</tr>
							</table>
							<table id="table5" style="WIDTH: 715px; HEIGHT: 434px" cellSpacing="0" borderColorDark="#ffffff"
								width="715" borderColorLight="#c0c0c0" border="1">
								<tr>
									<td colSpan="5"><asp:label id="qssj" runat="server" Width="110px"></asp:label>至
										<asp:label id="jzsj" runat="server" Width="126px"></asp:label>日车票销售情况如下:</td>
								</tr>
								<tr>
									<td vAlign="top" align="center" colSpan="5" height="422"><asp:datagrid id=DataGrid1 runat="server" Width="706px" Height="50px" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Vertical" DataSource="<%# dataSet_dingpiao %>" DataKeyField="序号" DataMember="dingpiao" AutoGenerateColumns="False" AllowPaging="True">
											<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#008A8C"></SelectedItemStyle>
											<AlternatingItemStyle BackColor="Gainsboro"></AlternatingItemStyle>
											<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
											<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#009900"></HeaderStyle>
											<FooterStyle ForeColor="Black" BackColor="#CCCCCC"></FooterStyle>
											<Columns>
												<asp:BoundColumn DataField="序号" HeaderText="序号">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="车次" HeaderText="车次">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="出发站" HeaderText="出发站">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="到达站" HeaderText="到达站">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="座位类型" HeaderText="座位类型">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="总价格" HeaderText="价格">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="车辆类型" HeaderText="车辆类型">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="售票点编号" SortExpression="售票点编号" HeaderText="售票点编号">
													<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
													<FooterStyle HorizontalAlign="Center"></FooterStyle>
												</asp:BoundColumn>
											</Columns>
											<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#009900" Mode="NumericPages"></PagerStyle>
										</asp:datagrid></td>
								</tr>
							</table>
							<FONT face="宋体"><FONT size="2">当前用户IP:</FONT>
								<asp:Label id="Label_IP" runat="server" Width="99px" BackColor="White" ForeColor="Black">Label</asp:Label><FONT size="2">浏览器版本:
									<asp:Label id="Label_LLQ" runat="server" Width="42px" BackColor="White" ForeColor="Black">Label</asp:Label></FONT></FONT>
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
