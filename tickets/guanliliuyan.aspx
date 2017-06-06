<%@ Page language="c#" Codebehind="guanliliuyan.aspx.cs" AutoEventWireup="false" Inherits="tickets.guanliliuyan" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>管理留言</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; WIDTH: 704px; POSITION: absolute; TOP: 8px; HEIGHT: 188px"
				cellSpacing="1" cellPadding="1" width="704" border="1">
				<TR>
					<TD bgColor="#339900"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<FONT color="#ffffff"><STRONG>&nbsp;&nbsp;&nbsp;用户留言</STRONG></FONT></FONT></TD>
				</TR>
				<TR>
					<TD><FONT face="宋体">标题
							<asp:TextBox id="TextBox_bt" runat="server" Width="600px" tabIndex="1"></asp:TextBox></FONT></TD>
				</TR>
				<TR>
					<TD><FONT face="宋体">用户:
							<asp:Label id="Label_yh" runat="server" Width="104px" Font-Size="Small"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
							留言时间:
							<asp:Label id="Label_sj" runat="server" Width="136px" Font-Size="Small"></asp:Label></FONT></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 81px"><FONT face="宋体">内容
							<asp:TextBox id="TextBox_nr" runat="server" Width="600px" TextMode="MultiLine" Height="94px"
								tabIndex="2"></asp:TextBox></FONT></TD>
				</TR>
				<TR>
					<TD><FONT face="宋体">
							<asp:Label id="Label_xh" runat="server" Width="104px" Visible="False"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
							&nbsp;
							<asp:Button id="Button_sc" runat="server" Width="50px" Text="删除" tabIndex="3"></asp:Button>&nbsp;&nbsp;
							<asp:Button id="Button_fh" runat="server" Width="50px" Text="返回" tabIndex="4"></asp:Button></FONT></TD>
				</TR>
				<TR>
					<TD><FONT face="宋体">日期范围:从<FONT face="宋体"><FONT face="宋体">
									<asp:dropdownlist id="DropDownList_nian" tabIndex="5" runat="server" Width="56px">
										<asp:ListItem Value="2005">2005</asp:ListItem>
										<asp:ListItem Value="2006">2006</asp:ListItem>
										<asp:ListItem Value="2007">2007</asp:ListItem>
										<asp:ListItem></asp:ListItem>
									</asp:dropdownlist>年
									<asp:dropdownlist id="DropDownList_yue" tabIndex="6" runat="server" Width="32px">
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
									<asp:dropdownlist id="DropDownList_ri" tabIndex="7" runat="server" Width="34px">
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
											<asp:dropdownlist id="Dropdownlist_nian1" tabIndex="8" runat="server" Width="56px">
												<asp:ListItem Value="2005">2005</asp:ListItem>
												<asp:ListItem Value="2006">2006</asp:ListItem>
												<asp:ListItem Value="2007">2007</asp:ListItem>
												<asp:ListItem></asp:ListItem>
											</asp:dropdownlist>年
											<asp:dropdownlist id="Dropdownlist_yue1" tabIndex="9" runat="server" Width="32px">
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
											<asp:dropdownlist id="Dropdownlist_ri1" tabIndex="10" runat="server" Width="34px">
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
											<asp:Button id="Button_cx" runat="server" Width="72px" Text="查看" tabIndex="11"></asp:Button>
											<asp:Button id="Button_plsc" runat="server" Width="67px" Text="批量删除" tabIndex="12"></asp:Button></FONT></FONT></FONT></FONT></FONT></TD>
				</TR>
			</TABLE>
			<TABLE id="Table2" style="Z-INDEX: 102; LEFT: 8px; WIDTH: 704px; POSITION: absolute; TOP: 256px; HEIGHT: 24px"
				cellSpacing="0" cellPadding="0" width="704" border="0">
				<TR>
					<TD><FONT face="宋体">
							<asp:DataGrid id=DataGrid1 runat="server" Width="700px" DataSource="<%# dataSet_ly %>" ShowHeader="False" DataKeyField="序号" DataMember="liuyan" AutoGenerateColumns="False">
								<Columns>
									<asp:BoundColumn DataField="标题" SortExpression="标题" HeaderText="标题">
										<HeaderStyle Width="80%"></HeaderStyle>
									</asp:BoundColumn>
									<asp:ButtonColumn Text="详细" CommandName="Select">
										<HeaderStyle Width="20%"></HeaderStyle>
									</asp:ButtonColumn>
								</Columns>
							</asp:DataGrid></FONT></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
