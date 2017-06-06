<%@ Page language="c#" Codebehind="xwgg.aspx.cs" AutoEventWireup="false" Inherits="tickets.xwgg" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>站内新闻</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 8px; HEIGHT: 88px"
				cellSpacing="0" width="960" align="center" bgColor="#3485da" border="0">
				<TR>
					<TD colSpan="3"><FONT face="宋体" color="#ffffff" size="6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
							列车售票系统新闻中心</FONT></TD>
				</TR>
			</TABLE>
			<asp:label id="Label_sj" style="Z-INDEX: 105; LEFT: 416px; POSITION: absolute; TOP: 592px"
				runat="server" Width="312px" Height="12px" ForeColor="Red" Font-Size="Smaller">Label</asp:label>
			<TABLE id="Table5" style="Z-INDEX: 104; LEFT: 768px; WIDTH: 204px; POSITION: absolute; TOP: 96px; HEIGHT: 69px"
				borderColor="#3485da" cellSpacing="0" cellPadding="0" width="204" border="1">
				<TR>
					<TD style="HEIGHT: 27px"><FONT face="宋体">&nbsp;&nbsp;&nbsp;<FONT size="2">&nbsp;<FONT color="#ff3300">共有</FONT></FONT><FONT color="#ff3300"><FONT size="2">:</FONT>
							</FONT>
							<asp:label id="Lb_zjl" runat="server" Width="40px" ForeColor="Red" Font-Size="X-Small"></asp:label><FONT color="#ff3300" size="2">条新闻</FONT></FONT></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 6px" bgColor="#3485da"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<FONT color="#ffffff">&nbsp;<FONT size="2">&nbsp;</FONT><FONT size="3">
									以往新闻</FONT></FONT></FONT></TD>
				</TR>
				<TR>
					<TD><FONT face="宋体"></FONT><FONT face="宋体"><asp:datagrid id=DataGrid_ywxw runat="server" Width="200px" Height="404px" PageSize="22" AllowPaging="True" DataSource="<%# dataSet_xinwen %>" ShowHeader="False" DataKeyField="序号" DataMember="xinwen" AutoGenerateColumns="False">
								<Columns>
									<asp:BoundColumn DataField="标题" SortExpression="标题" HeaderText="标题">
										<HeaderStyle Width="180px"></HeaderStyle>
										<ItemStyle Font-Size="X-Small"></ItemStyle>
									</asp:BoundColumn>
									<asp:ButtonColumn Text="详细" CommandName="Select">
										<HeaderStyle Width="30px"></HeaderStyle>
										<ItemStyle Font-Size="X-Small" Wrap="False" ForeColor="Black"></ItemStyle>
									</asp:ButtonColumn>
								</Columns>
								<PagerStyle Mode="NumericPages"></PagerStyle>
							</asp:datagrid></FONT></TD>
				</TR>
			</TABLE>
			<TABLE id="Table4" style="Z-INDEX: 103; LEFT: 240px; WIDTH: 528px; BORDER-BOTTOM: #3485da thin solid; POSITION: absolute; TOP: 96px; HEIGHT: 72px"
				cellSpacing="0" cellPadding="0" width="528" border="0">
				<TR>
					<TD style="HEIGHT: 27px" align="center"><FONT face="宋体"><asp:label id="Label_biaoti" runat="server" Width="514px" Font-Size="Small"></asp:label></FONT></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 19px" align="center"><FONT face="宋体"><asp:label id="Label_shijian" runat="server" Width="520px" Font-Size="X-Small"></asp:label></FONT></TD>
				</TR>
				<TR>
					<TD>
						<P><FONT face="宋体">
								<asp:textbox id="TextBox_xwnr" runat="server" Height="416px" Width="528px" MaxLength="20" TextMode="MultiLine"></asp:textbox></FONT></P>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table2" style="Z-INDEX: 102; LEFT: 16px; WIDTH: 224px; POSITION: absolute; TOP: 96px; HEIGHT: 424px"
				borderColor="#3485da" cellSpacing="0" cellPadding="0" width="224" border="1">
				<TR>
					<TD style="HEIGHT: 27px"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<FONT color="#ff3300" size="2">访问量:
								<asp:label id="Lbl_fwl" runat="server" Width="40px"></asp:label>次</FONT></FONT></TD>
				</TR>
				<TR>
					<TD bgColor="#3485da"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<FONT color="#ffffff">&nbsp;&nbsp;&nbsp;&nbsp;
								<asp:label id="Label_jryw" runat="server" Width="64px">今日要闻</asp:label></FONT></FONT></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 2px"><FONT face="宋体"><asp:datagrid id=DataGrid_jryw runat="server" Width="220px" Height="160px" PageSize="9" AllowPaging="True" DataSource="<%# dataSet_xinwen %>" ShowHeader="False" DataKeyField="序号" DataMember="xinwen" AutoGenerateColumns="False">
								<Columns>
									<asp:BoundColumn DataField="标题" SortExpression="标题" HeaderText="标题">
										<HeaderStyle Width="180px"></HeaderStyle>
										<ItemStyle Font-Size="X-Small" Wrap="False"></ItemStyle>
									</asp:BoundColumn>
									<asp:ButtonColumn Text="详细" CommandName="Select">
										<HeaderStyle Width="30px"></HeaderStyle>
										<ItemStyle Font-Size="X-Small" ForeColor="#000000"></ItemStyle>
									</asp:ButtonColumn>
								</Columns>
								<PagerStyle Mode="NumericPages"></PagerStyle>
							</asp:datagrid></FONT></TD>
				</TR>
				<TR>
					<TD bgColor="#3485da"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<FONT color="#ffffff">&nbsp;&nbsp;新闻查询</FONT></FONT></TD>
				</TR>
				<TR>
					<TD><FONT face="宋体"><FONT face="宋体"><asp:dropdownlist id="DropDownList_nian" tabIndex="2" runat="server" Width="56px">
									<asp:ListItem Value="2005">2005</asp:ListItem>
									<asp:ListItem Value="2006">2006</asp:ListItem>
									<asp:ListItem Value="2007">2007</asp:ListItem>
									<asp:ListItem></asp:ListItem>
								</asp:dropdownlist>年
								<asp:dropdownlist id="DropDownList_yue" tabIndex="3" runat="server" Width="32px">
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
									<asp:ListItem></asp:ListItem>
								</asp:dropdownlist>月
								<asp:dropdownlist id="DropDownList_ri" tabIndex="4" runat="server" Width="34px">
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
									<asp:ListItem></asp:ListItem>
								</asp:dropdownlist>日
								<asp:button id="Button_chaxun" runat="server" Width="26px" Text="Go!" ForeColor="Red"></asp:button></FONT></FONT></TD>
				</TR>
				<TR>
					<TD bgColor="#3485da"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<FONT color="#ffffff">查询结果</FONT></FONT></TD>
				</TR>
				<TR>
					<TD><FONT face="宋体"></FONT><FONT face="宋体">
							<P>
								<asp:DataGrid id=DataGrid_chaxun runat="server" Height="104px" Width="220px" AutoGenerateColumns="False" DataMember="xinwen" DataKeyField="序号" ShowHeader="False" DataSource="<%# dataSet_xinwen %>" AllowPaging="True" PageSize="5">
									<Columns>
										<asp:BoundColumn DataField="标题" SortExpression="标题" HeaderText="标题">
											<HeaderStyle Width="180px"></HeaderStyle>
											<ItemStyle Font-Size="X-Small"></ItemStyle>
										</asp:BoundColumn>
										<asp:ButtonColumn Text="详细" CommandName="Select">
											<HeaderStyle Width="30px"></HeaderStyle>
											<ItemStyle Font-Size="X-Small" ForeColor="#000000"></ItemStyle>
										</asp:ButtonColumn>
									</Columns>
									<PagerStyle Mode="NumericPages"></PagerStyle>
								</asp:DataGrid></P>
							<P>
								<asp:LinkButton id="LinkButton1" runat="server">返回主页</asp:LinkButton></P>
						</FONT><FONT face="宋体">
							<P>
								<asp:label id="Label_tishi" runat="server" ForeColor="Red" Width="208px"></asp:label></P>
						</FONT>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
