<%@ Page language="c#" Codebehind="tongji.aspx.cs" AutoEventWireup="false" Inherits="tickets.tongji" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>��Ʊ�������ͳ��</title>
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
					<TD style="HEIGHT: 4px" colSpan="4"><FONT face="����"></FONT><FONT face="����"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<asp:Label id="Label1" runat="server" Font-Bold="True" ForeColor="Green" Font-Size="Large"
								Width="208px">��Ʊ�������ͳ��</asp:Label></FONT></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 76px; HEIGHT: 54px" colSpan="4"><FONT face="����"></FONT><FONT face="����">
							<P>
								<asp:DataGrid id=DataGrid1 runat="server" Width="656px" AutoGenerateColumns="False" DataMember="dingpiao" AllowSorting="True" DataKeyField="���" DataSource="<%# dataSet_tongji %>" PageSize="5" AllowPaging="True" GridLines="Vertical" CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#999999" height="50px">
									<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#008A8C"></SelectedItemStyle>
									<AlternatingItemStyle BackColor="Gainsboro"></AlternatingItemStyle>
									<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
									<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#009900"></HeaderStyle>
									<FooterStyle ForeColor="Black" BackColor="#CCCCCC"></FooterStyle>
									<Columns>
										<asp:BoundColumn DataField="����" SortExpression="����" HeaderText="����"></asp:BoundColumn>
										<asp:BoundColumn DataField="Ʊ��" SortExpression="Ʊ��" HeaderText="Ʊ��"></asp:BoundColumn>
										<asp:BoundColumn DataField="�ܼ۸�" SortExpression="�ܼ۸�" HeaderText="�ܼ۸�"></asp:BoundColumn>
									</Columns>
									<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#009900" Mode="NumericPages"></PagerStyle>
								</asp:DataGrid></P>
						</FONT>
					</TD>
				</TR>
			</TABLE>
			<P><FONT face="����"></FONT>&nbsp;</P>
		</form>
	</body>
</HTML>
