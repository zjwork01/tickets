<%@ Page language="c#" Codebehind="tongji.aspx.cs" AutoEventWireup="false" Inherits="tickets.tongji" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>车票销售情况统计</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; WIDTH: 624px; POSITION: absolute; TOP: 8px; HEIGHT: 120px"
				width="624" border="1">
				<TR>
					<TD style="HEIGHT: 4px" colSpan="4"><FONT face="宋体"></FONT><FONT face="宋体"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<asp:Label id="Label1" runat="server" Font-Bold="True" ForeColor="Green" Font-Size="Large"
								Width="208px">车票销售情况统计</asp:Label></FONT></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 76px; HEIGHT: 54px" colSpan="4"><FONT face="宋体"></FONT><FONT face="宋体">
							<P>
								<asp:DataGrid id=DataGrid1 runat="server" Width="656px" AutoGenerateColumns="False" DataMember="dingpiao" AllowSorting="True" DataKeyField="序号" DataSource="<%# dataSet_tongji %>" PageSize="5" AllowPaging="True" GridLines="Vertical" CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#999999" height="50px">
									<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#008A8C"></SelectedItemStyle>
									<AlternatingItemStyle BackColor="Gainsboro"></AlternatingItemStyle>
									<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
									<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#009900"></HeaderStyle>
									<FooterStyle ForeColor="Black" BackColor="#CCCCCC"></FooterStyle>
									<Columns>
										<asp:BoundColumn DataField="车次" SortExpression="车次" HeaderText="车次"></asp:BoundColumn>
										<asp:BoundColumn DataField="票数" SortExpression="票数" HeaderText="票数"></asp:BoundColumn>
										<asp:BoundColumn DataField="总价格" SortExpression="总价格" HeaderText="总价格"></asp:BoundColumn>
									</Columns>
									<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#009900" Mode="NumericPages"></PagerStyle>
								</asp:DataGrid></P>
						</FONT>
					</TD>
				</TR>
			</TABLE>
			<P><FONT face="宋体"></FONT>&nbsp;</P>
		</form>
	</body>
</HTML>
