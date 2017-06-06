<%@ Page language="c#" Codebehind="tuipiao.aspx.cs" AutoEventWireup="false" Inherits="tickets.tuipiao1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>退票</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" background="/images\bg.gif">
		<div align="center">
			<form id="买票" method="post" runat="server">
				<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 136px; WIDTH: 664px; POSITION: absolute; TOP: 40px; HEIGHT: 488px"
					cellSpacing="1" cellPadding="1" width="664" border="1">
					<TR>
						<TD><FONT face="宋体">
								<P align="center"><FONT face="华文中宋" size="7">
										<asp:Image id="Image2" runat="server" Height="98px" Width="657px" ImageUrl="/images\biaoti.gif"></asp:Image></FONT></P>
							</FONT>
						</TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 66px"><FONT face="宋体">
								<TABLE id="Table2" style="WIDTH: 659px" cellSpacing="0" cellPadding="0" width="659" border="0">
									<TR>
										<TD style="WIDTH: 115px">
											<asp:Button id="Button_maipiao" runat="server" Text="买票" Width="133px" Height="27px"></asp:Button></TD>
										<TD style="WIDTH: 134px">
											<asp:Button id="Button_dingpiao" runat="server" Text="订票" Width="134px" Height="27px"></asp:Button></TD>
										<TD style="WIDTH: 133px">
											<asp:Button id="Button_tuipiao" runat="server" Text="退票" Width="129px" Height="27px"></asp:Button></TD>
										<TD style="WIDTH: 121px">
											<asp:Button id="Button_chaxun" runat="server" Text="查询" Width="138px" Height="27px"></asp:Button></TD>
										<TD>
											<asp:Button id="Button_yhgl" runat="server" Text="用户管理" Width="120px" Height="27px"></asp:Button></TD>
									</TR>
								</TABLE>
							</FONT>
							<P><FONT face="宋体"></FONT>&nbsp;</P>
						</TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 50px">
							<P><FONT style="VERTICAL-ALIGN: super; TEXT-ALIGN: center" face="宋体">
									<TABLE id="Table5" style="WIDTH: 664px; HEIGHT: 136px" cellSpacing="1" cellPadding="1"
										width="664" border="1">
										<TR>
											<TD style="WIDTH: 207px; HEIGHT: 23px" colSpan="2">
												<P align="left">请选择退票类型:</P>
											</TD>
											<TD style="WIDTH: 216px; HEIGHT: 23px" colSpan="2">
												<asp:RadioButton id="RadioButton_tuipiao" runat="server" Width="74px" Text="退票" AutoPostBack="True"
													GroupName="1" Checked="True"></asp:RadioButton></TD>
											<TD style="HEIGHT: 23px" colSpan="2">
												<asp:RadioButton id="RadioButton_tuiding" runat="server" Width="90px" Text="退订" AutoPostBack="True"
													GroupName="1"></asp:RadioButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</TD>
										</TR>
										<TR>
											<TD style="WIDTH: 130px; HEIGHT: 20px" align="right">输入车次：</TD>
											<TD style="WIDTH: 497px; HEIGHT: 20px" colSpan="4">
												<asp:TextBox id="Text_checi" runat="server" Width="176px" tabIndex="1"></asp:TextBox>&nbsp;&nbsp;&nbsp; 
												发车时间:
												<asp:DropDownList id="DropDownList_nian" runat="server" Width="56px" tabIndex="2">
													<asp:ListItem Value="2005">2005</asp:ListItem>
													<asp:ListItem Value="2006">2006</asp:ListItem>
													<asp:ListItem Value="2008">2008</asp:ListItem>
												</asp:DropDownList>年
												<asp:DropDownList id="DropDownList_yue" runat="server" Width="41px" tabIndex="3">
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
												</asp:DropDownList>月
												<asp:DropDownList id="DropDownList_ri" runat="server" Width="37px" tabIndex="4">
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
												</asp:DropDownList>日</TD>
											<TD style="HEIGHT: 20px">
												<asp:Button id="Button_qdcc" runat="server" Width="57px" Text="确定"></asp:Button></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 130px; HEIGHT: 8px" align="right">起点站：</TD>
											<TD style="WIDTH: 49px; HEIGHT: 8px" colSpan="2">
												<asp:DropDownList id="DropDownList_qsz" runat="server" Width="180px" tabIndex="5"></asp:DropDownList></TD>
											<TD style="WIDTH: 142px; HEIGHT: 8px">
												<P align="right">终点站:</P>
											</TD>
											<TD style="WIDTH: 167px; HEIGHT: 8px">
												<asp:DropDownList id="DropDownList_zdz" runat="server" Width="180px" tabIndex="6"></asp:DropDownList></TD>
											<TD style="HEIGHT: 8px"></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 130px; HEIGHT: 19px">
												<P align="right">座位类型:</P>
											</TD>
											<TD style="WIDTH: 120px; HEIGHT: 19px" colSpan="2"><P align="right">
													<asp:dropdownlist id="DropDownList_zwlx1" runat="server" Height="32px" Width="179px" tabIndex="7">
														<asp:ListItem Value="硬座票价">硬座</asp:ListItem>
														<asp:ListItem Value="硬卧上">硬卧上</asp:ListItem>
														<asp:ListItem Value="硬卧中">硬卧中</asp:ListItem>
														<asp:ListItem Value="硬卧下">硬卧下</asp:ListItem>
														<asp:ListItem Value="软卧上">软卧上</asp:ListItem>
														<asp:ListItem Value="软卧下">软卧下</asp:ListItem>
													</asp:dropdownlist></P>
											</TD>
											<TD style="WIDTH: 333px; HEIGHT: 19px" colSpan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
												&nbsp;票数:
												<asp:TextBox id="Text_ps" runat="server" Width="114px" tabIndex="8"></asp:TextBox></TD>
											<TD style="HEIGHT: 19px">
												<asp:Button id="Button_jg" runat="server" Width="57px" Text="价格"></asp:Button></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 130px" align="right">原价:</TD>
											<TD style="WIDTH: 120px">
												<asp:Label id="Label_yj" runat="server" Width="40px"></asp:Label></TD>
											<TD align="right">现退:</TD>
											<TD style="WIDTH: 142px">
												<asp:Label id="Label_xt" runat="server" Width="40px"></asp:Label></TD>
											<TD style="WIDTH: 167px" align="center" colSpan="1" rowSpan="1">
												<asp:Button id="Button_tp" runat="server" Width="76px" Text="退票" tabIndex="9"></asp:Button></TD>
											<TD>
												<asp:Button id="Button_cz" runat="server" Width="58px" Text="重置"></asp:Button></TD>
										</TR>
									</TABLE>
								</FONT>
							</P>
						</TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 270px">
							<P><FONT face="宋体">
									<asp:Panel id="Panel1" runat="server" Height="152px" HorizontalAlign="Center">
										<TABLE id="Table4" style="VERTICAL-ALIGN: baseline; WIDTH: 663px; POSITION: static; HEIGHT: 72px; TEXT-ALIGN: justify"
											cellSpacing="0" cellPadding="0" width="663" border="1">
											<TR>
												<TD style="HEIGHT: 36px" colSpan="4">用户信息：</TD>
											</TR>
											<TR>
												<TD style="WIDTH: 94px" align="right">姓名:</TD>
												<TD style="WIDTH: 407px">
													<asp:TextBox id="TextBox_xm" tabIndex="11" runat="server" Width="136px"></asp:TextBox></TD>
												<TD style="WIDTH: 341px" align="right">联系方式:
													<asp:TextBox id="TextBox_lxfs" tabIndex="12" runat="server" Width="130px"></asp:TextBox></TD>
												<TD></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 94px; HEIGHT: 8px" align="right">
													<P align="right">地址:</P>
												</TD>
												<TD style="WIDTH: 407px; HEIGHT: 8px">
													<asp:TextBox id="TextBox_dz" tabIndex="13" runat="server" Width="304px"></asp:TextBox></TD>
												<TD style="WIDTH: 341px; HEIGHT: 8px" align="right">身份证号:
													<asp:TextBox id="TextBox_sfz" tabIndex="14" runat="server" Width="131px"></asp:TextBox></TD>
												<TD style="HEIGHT: 8px">&nbsp;&nbsp;</TD>
											</TR>
										</TABLE>
									</asp:Panel></FONT></P>
							<P>&nbsp;</P>
						</TD>
					</TR>
					<TR>
						<TD><FONT face="宋体"><FONT face="宋体"><FONT size="2">当前用户IP:</FONT>
									<asp:Label id="Label_IP" runat="server" Width="99px" ForeColor="Black" BackColor="White">Label</asp:Label><FONT size="2">浏览器版本:
										<asp:Label id="Label_LLQ" runat="server" Width="42px" ForeColor="Black" BackColor="White">Label</asp:Label></FONT></FONT></FONT></TD>
					</TR>
					<TR>
						<TD>
							<P align="center"><FONT face="宋体" size="2"></FONT>&nbsp; <FONT face="华文中宋" size="2">
									</FONT></P>
						</TD>
					</TR>
				</TABLE>
				&nbsp;
			</form>
		</div>
	</body>
</HTML>
