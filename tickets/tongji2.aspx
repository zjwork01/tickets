<%@ Page language="c#" Codebehind="tongji2.aspx.cs" AutoEventWireup="false" Inherits="tickets.tongji2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>tongji2</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; WIDTH: 584px; POSITION: absolute; TOP: 8px; HEIGHT: 200px"
				cellSpacing="1" cellPadding="1" width="584" border="1">
				<TR>
					<TD style="HEIGHT: 35px"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<asp:Label id="Label1" runat="server" Width="208px" Font-Size="Large" ForeColor="Green" Font-Bold="True">车票销售情况统计</asp:Label></FONT></TD>
				</TR>
				<TR>
					<TD><FONT face="宋体">
							<asp:DataGrid id=DataGrid1 runat="server" Width="576px" DataSource="<%# dataSet_dp %>" DataKeyField="序号" DataMember="dingpiao" AutoGenerateColumns="False">
								<HeaderStyle ForeColor="#FFFFFF" BackColor="#339900"></HeaderStyle>
								<Columns>
									<asp:BoundColumn DataField="总票数" SortExpression="总票数" HeaderText="总票数">
										<HeaderStyle Width="33%"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="总价格" SortExpression="总价格" HeaderText="总价格">
										<HeaderStyle Width="33%"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="售票点编号" SortExpression="售票点编号" HeaderText="售票点编号">
										<HeaderStyle Width="33%"></HeaderStyle>
									</asp:BoundColumn>
								</Columns>
								<PagerStyle ForeColor="#FFFFFF" BackColor="#339900"></PagerStyle>
							</asp:DataGrid></FONT></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
