<%@ Page language="c#" Codebehind="xinwenguanli.aspx.cs" AutoEventWireup="false" Inherits="tickets.xinwenguanli" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>新闻管理</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; WIDTH: 736px; POSITION: absolute; TOP: 8px; HEIGHT: 75px"
				cellSpacing="1" cellPadding="1" width="736" border="1">
				<TR>
					<TD colSpan="3" bgcolor="#339900" style="HEIGHT: 18px"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<STRONG>&nbsp;&nbsp;&nbsp;<FONT color="#ffffff">新闻管理</FONT></STRONG></FONT></TD>
				</TR>
				<TR>
					<TD colSpan="3"><FONT face="宋体">新闻标题:
							<asp:TextBox id="TextBox_bt" runat="server" Width="640px" tabIndex="1"></asp:TextBox></FONT></TD>
				</TR>
				<TR>
					<TD colSpan="3"><FONT face="宋体" style="VERTICAL-ALIGN: super; POSITION: relative; TEXT-ALIGN: left">新闻内容:
							<asp:TextBox id="TextBox_nr" runat="server" Width="640px" TextMode="MultiLine" Height="112px"
								MaxLength="15" tabIndex="2"></asp:TextBox></FONT></TD>
				</TR>
				<TR>
					<TD colSpan="3"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<asp:Label id="Label_xh" runat="server" Width="104px" Visible="False"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<asp:Button id="Button_zj" runat="server" Text="增加" Width="50px" tabIndex="3"></asp:Button>&nbsp;
							<asp:Button id="Button_xg" runat="server" Text="修改" Width="50px" tabIndex="4"></asp:Button>&nbsp;
							<asp:Button id="Button_sc" runat="server" Text="删除" Width="50px" tabIndex="5"></asp:Button>&nbsp;
							<asp:Button id="Button_fh" runat="server" Text="返回" Width="50px" tabIndex="6"></asp:Button></FONT></TD>
				</TR>
			</TABLE>
			<TABLE id="Table2" style="Z-INDEX: 102; LEFT: 8px; WIDTH: 736px; POSITION: absolute; TOP: 216px; HEIGHT: 62px"
				cellSpacing="1" cellPadding="1" width="736" border="1">
				<TR>
					<TD style="HEIGHT: 13px" colSpan="3"><FONT face="宋体">日期范围:从<FONT face="宋体"><FONT face="宋体">
									<asp:dropdownlist id="DropDownList_nian" tabIndex="7" runat="server" Width="56px">
										<asp:ListItem Value="2005">2005</asp:ListItem>
										<asp:ListItem Value="2006">2006</asp:ListItem>
										<asp:ListItem Value="2007">2007</asp:ListItem>
										<asp:ListItem></asp:ListItem>
									</asp:dropdownlist>年
									<asp:dropdownlist id="DropDownList_yue" tabIndex="8" runat="server" Width="32px">
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
									<asp:dropdownlist id="DropDownList_ri" tabIndex="9" runat="server" Width="34px">
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
									</asp:dropdownlist>日&nbsp; 到&nbsp;&nbsp; <FONT face="宋体"><FONT face="宋体">
											<asp:dropdownlist id="Dropdownlist_nian1" tabIndex="10" runat="server" Width="56px">
												<asp:ListItem Value="2005">2005</asp:ListItem>
												<asp:ListItem Value="2006">2006</asp:ListItem>
												<asp:ListItem Value="2007">2007</asp:ListItem>
												<asp:ListItem></asp:ListItem>
											</asp:dropdownlist>年
											<asp:dropdownlist id="Dropdownlist_yue1" tabIndex="11" runat="server" Width="32px">
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
											<asp:dropdownlist id="Dropdownlist_ri1" tabIndex="12" runat="server" Width="34px">
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
											</asp:dropdownlist>日&nbsp;
											<asp:Button id="Button_cx" runat="server" Width="72px" Text="搜索" tabIndex="13"></asp:Button>&nbsp;&nbsp;&nbsp;
											<asp:Button id="Button_plsc" runat="server" Text="批量删除" Width="67px" tabIndex="14"></asp:Button></FONT></FONT></FONT></FONT></FONT></TD>
				</TR>
				<TR>
					<TD colSpan="3"><FONT face="宋体"><FONT face="宋体">新闻搜索
								<asp:TextBox id="TextBox_sousuo" runat="server" Width="456px" tabIndex="15"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
								<asp:Button id="Button_sousuo" runat="server" Width="79px" Text="搜索" tabIndex="16"></asp:Button></FONT></FONT></TD>
				</TR>
			</TABLE>
			<TABLE id="Table3" style="Z-INDEX: 100; LEFT: 8px; WIDTH: 736px; POSITION: absolute; TOP: 288px; HEIGHT: 211px"
				cellSpacing="1" cellPadding="1" width="736" align="center" border="1">
				<TR>
					<TD vAlign="top" align="center"><FONT face="宋体"><FONT face="宋体"><FONT face="宋体"><FONT face="宋体">
										<asp:DataGrid id=DataGrid_xwlb runat="server" Width="726px" AutoGenerateColumns="False" DataSource="<%# dataSet_xw %>" ShowHeader="False" DataKeyField="序号" DataMember="xinwen" AllowPaging="True">
											<Columns>
												<asp:BoundColumn DataField="标题" SortExpression="标题" HeaderText="标题">
													<HeaderStyle Width="60%"></HeaderStyle>
													<ItemStyle Font-Size="X-Small"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="发布时间" SortExpression="发布时间" HeaderText="发布时间" DataFormatString="{0:hh-mm}">
													<HeaderStyle Width="30%"></HeaderStyle>
													<ItemStyle Font-Size="X-Small"></ItemStyle>
												</asp:BoundColumn>
												<asp:ButtonColumn Text="详细" CommandName="Select">
													<HeaderStyle Width="10%"></HeaderStyle>
													<ItemStyle Font-Size="X-Small"></ItemStyle>
												</asp:ButtonColumn>
											</Columns>
											<PagerStyle Mode="NumericPages"></PagerStyle>
										</asp:DataGrid></FONT></FONT></FONT></FONT></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
