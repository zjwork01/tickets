<%@ Page language="c#" Codebehind="login.aspx.cs" AutoEventWireup="false" Inherits="tickets.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>登陆列车售票系统</title>
		<meta name="vs_snapToGrid" content="True">
		<meta name="vs_showGrid" content="True">
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" background="file:///E:\赵卫平\售票管理系统\picture\bg.gif">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体" size="20">
				<asp:Image id="Image1" style="Z-INDEX: 101; LEFT: 144px; POSITION: absolute; TOP: 48px" runat="server"
					Height="480px" Width="718px" BorderStyle="Outset" ImageUrl="/images\main_bg.jpg"
					ImageAlign="AbsMiddle" ForeColor="Green"></asp:Image>
				<asp:Label id="Label6" style="Z-INDEX: 116; LEFT: 352px; POSITION: absolute; TOP: 496px" runat="server"
					Width="304px" Font-Size="X-Small">技术支持：zufe_zqs</asp:Label>
				<asp:Button id="Button_zhuce" style="Z-INDEX: 115; LEFT: 464px; POSITION: absolute; TOP: 416px"
					runat="server" BorderStyle="Outset" Width="96px" Height="32px" Text="注册" tabIndex="4"></asp:Button>
				<asp:Image id="Image7" style="Z-INDEX: 114; LEFT: 96px; POSITION: absolute; TOP: 40px" runat="server"
					ImageUrl="/images\login_left.jpg" Width="41px" Height="504px"></asp:Image>
				<asp:Image id="Image6" style="Z-INDEX: 113; LEFT: 872px; POSITION: absolute; TOP: 48px" runat="server"
					ImageUrl="/images\login_right.jpg" Width="40px" Height="494px"></asp:Image>
				<asp:Image id="Image5" style="Z-INDEX: 112; LEFT: 102px; POSITION: absolute; TOP: 536px" runat="server"
					ImageUrl="/images\login_bottom.jpg" Width="804px" Height="34px"></asp:Image>
				<asp:Image id="Image4" style="Z-INDEX: 111; LEFT: 102px; POSITION: absolute; TOP: 8px" runat="server"
					ImageUrl="/images\login_top.jpg" Width="804px" Height="40px"></asp:Image>
				<asp:Button id="Button_quxiao" style="Z-INDEX: 110; LEFT: 600px; POSITION: absolute; TOP: 416px"
					runat="server" BorderStyle="Outset" Width="96px" Height="32px" Text="取消" tabIndex="5"></asp:Button>
				<asp:Image id="Image3" style="Z-INDEX: 109; LEFT: 360px; POSITION: absolute; TOP: 328px" runat="server"
					ImageUrl="/images\pw_icon.gif"></asp:Image>
				<asp:Image id="Image2" style="Z-INDEX: 108; LEFT: 360px; POSITION: absolute; TOP: 288px" runat="server"
					ImageUrl="/images\user_icon.gif"></asp:Image>
				<asp:Label id="Label_bt" style="Z-INDEX: 107; LEFT: 344px; POSITION: absolute; TOP: 136px"
					runat="server" Font-Size="X-Large" ForeColor="Green" Height="56px" Width="352px">欢迎登陆车站售票系统！</asp:Label>
				<asp:TextBox id="text_password" style="Z-INDEX: 105; LEFT: 464px; POSITION: absolute; TOP: 336px"
					runat="server" Width="168px" TextMode="Password" tabIndex="2"></asp:TextBox>
				<asp:Label id="Label_mm" style="Z-INDEX: 103; LEFT: 392px; POSITION: absolute; TOP: 336px"
					runat="server" Font-Size="Small" Height="24px" Width="73px">密 码：</asp:Label>
				<asp:Label id="Label_yhm" style="Z-INDEX: 102; LEFT: 392px; POSITION: absolute; TOP: 288px"
					runat="server" Font-Size="Small" Height="24px" Width="72px">用户名：</asp:Label>
				<asp:TextBox id="text_name" style="Z-INDEX: 104; LEFT: 464px; POSITION: absolute; TOP: 288px"
					runat="server" Width="168px" tabIndex="1"></asp:TextBox>
				<asp:Button id="Button_denglu" style="Z-INDEX: 106; LEFT: 312px; POSITION: absolute; TOP: 416px"
					runat="server" Height="32px" Width="96px" BorderStyle="Outset" Text="登陆" tabIndex="3"></asp:Button></FONT>
		</form>
		<asp:Label id="Label_zfwl" style="Z-INDEX: 117; LEFT: 464px; POSITION: absolute; TOP: 584px"
			runat="server" Width="128px" Font-Size="X-Small" ForeColor="DimGray"></asp:Label>
	</body>
</HTML>
