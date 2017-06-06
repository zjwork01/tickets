using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace tickets
{
	/// <summary>
	/// tuipiao1 的摘要说明。
	/// </summary>
	public class tuipiao1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button_maipiao;
		protected System.Web.UI.WebControls.Button Button_dingpiao;
		protected System.Web.UI.WebControls.Button Button_tuipiao;
		protected System.Web.UI.WebControls.Button Button_chaxun;
		protected System.Web.UI.WebControls.Button Button_yhgl;
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_dingpiao;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_tickets;
		protected System.Web.UI.WebControls.RadioButton RadioButton_tuipiao;
		protected System.Web.UI.WebControls.RadioButton RadioButton_tuiding;
		protected System.Web.UI.WebControls.Button Button_qdcc;
		protected System.Web.UI.WebControls.Button Button_tp;
		protected System.Web.UI.WebControls.Button Button_cz;
		protected System.Web.UI.WebControls.TextBox TextBox_xm;
		protected System.Web.UI.HtmlControls.HtmlForm 买票;
		protected System.Data.DataSet dsbegin;
		protected System.Data.DataSet dsend;
		protected System.Data.DataSet dsjiage;
	
		protected System.Data.DataSet dsleixing;
		protected System.Data.DataSet dskongtiaoche;
		protected System.Data.DataSet dskongtiaochewopu;
		protected System.Data.DataSet dsputongche;
		protected System.Data.DataSet dsputongchewopu;
		protected System.Data.DataSet dslucheng;
		protected System.Data.DataSet dscxzwh;
		protected System.Data.DataSet dscxzwh1;
		protected System.Data.DataSet dskcsj;
		protected System.Data.DataSet dscllx;
		private string cc;
//		private string flag="0";
		private string sql;
		private string type;
		private string begin;
		protected System.Web.UI.WebControls.TextBox Text_checi;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand3;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_ticketsinf;
		protected System.Web.UI.WebControls.DropDownList DropDownList_qsz;
		protected System.Web.UI.WebControls.DropDownList DropDownList_zdz;
		protected System.Web.UI.WebControls.Button Button_jg;
		protected System.Web.UI.WebControls.Label Label_yj;
		protected System.Web.UI.WebControls.Label Label_xt;
		protected System.Web.UI.WebControls.TextBox TextBox_sfz;
		protected System.Web.UI.WebControls.TextBox TextBox_lxfs;
		protected System.Web.UI.WebControls.TextBox TextBox_dz;
		protected System.Web.UI.WebControls.DropDownList DropDownList_nian;
		protected System.Web.UI.WebControls.DropDownList DropDownList_yue;
		protected System.Web.UI.WebControls.DropDownList DropDownList_ri;
		protected System.Web.UI.WebControls.TextBox Text_ps;
		protected System.Data.SqlClient.SqlConnection sqlConnection2;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_kongtiaoche;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_kongtiaochewopu;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_putongche;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_putongchewopu;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand6;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		protected System.Web.UI.WebControls.DropDownList DropDownList_zwlx1;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Label Label_LLQ;
		protected System.Web.UI.WebControls.Label Label_IP;
		private string  end;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection1.ConnectionString=this.sqlConnection2.ConnectionString=data.connStr;
			// 在此处放置用户代码以初始化页面

			if(Session["username"].ToString()=="admin")
				this.Button_yhgl.Visible=true;
			else  this.Button_yhgl.Visible=false;
             this.Panel1.Visible=false;

            
			if(this.RadioButton_tuiding.Checked==true)
				this.Panel1.Visible=true;
			else  this.Panel1.Visible=false;

			this.Label_IP.Text=Page.Request.UserHostAddress;
			this.Label_LLQ.Text=Request.Browser.Version;
		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			if(!this.IsPostBack)
			{
				if(Session["username"]==null)
				{
					Response.Redirect("login.aspx");
					return;
				}
			}
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_dingpiao = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_tickets = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_ticketsinf = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
			this.sqlDataAdapter_kongtiaoche = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_kongtiaochewopu = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_putongche = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_putongchewopu = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
			this.Button_maipiao.Click += new System.EventHandler(this.Button_maipiao_Click);
			this.Button_dingpiao.Click += new System.EventHandler(this.Button_dingpiao_Click);
			this.Button_tuipiao.Click += new System.EventHandler(this.Button_tuipiao_Click);
			this.Button_chaxun.Click += new System.EventHandler(this.Button_chaxun_Click);
			this.Button_yhgl.Click += new System.EventHandler(this.Button_yhgl_Click);
			this.Button_qdcc.Click += new System.EventHandler(this.Button_qdcc_Click);
			this.Button_jg.Click += new System.EventHandler(this.Button_jg_Click);
			this.Button_tp.Click += new System.EventHandler(this.Button_tp_Click);
			this.Button_cz.Click += new System.EventHandler(this.Button_cz_Click);
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 序号, 车次, 出发站, 到达站, 座位类型, 票数, 总价格, 用户名, 联系方式, 地址, 身份证 FROM dingpiao";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=SA;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO dingpiao(序号, 车次, 出发站, 到达站, 座位类型, 票数, 总价格, 用户名, 联系方式, 地址, 身份证) VALUES " +
				"(@序号, @车次, @出发站, @到达站, @座位类型, @票数, @总价格, @用户名, @联系方式, @地址, @身份证); SELECT 序号, 车次," +
				" 出发站, 到达站, 座位类型, 票数, 总价格, 用户名, 联系方式, 地址, 身份证 FROM dingpiao WHERE (序号 = @序号)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@序号", System.Data.SqlDbType.Int, 4, "序号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车次", System.Data.SqlDbType.VarChar, 10, "车次"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@出发站", System.Data.SqlDbType.VarChar, 10, "出发站"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达站", System.Data.SqlDbType.VarChar, 10, "到达站"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@座位类型", System.Data.SqlDbType.VarChar, 10, "座位类型"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@票数", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "票数", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@总价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "总价格", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@用户名", System.Data.SqlDbType.VarChar, 50, "用户名"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@联系方式", System.Data.SqlDbType.VarChar, 20, "联系方式"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@地址", System.Data.SqlDbType.VarChar, 50, "地址"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@身份证", System.Data.SqlDbType.VarChar, 20, "身份证"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE dingpiao SET 序号 = @序号, 车次 = @车次, 出发站 = @出发站, 到达站 = @到达站, 座位类型 = @座位类型, 票数 = @票数, 总价格 = @总价格, 用户名 = @用户名, 联系方式 = @联系方式, 地址 = @地址, 身份证 = @身份证 WHERE (序号 = @Original_序号) AND (出发站 = @Original_出发站 OR @Original_出发站 IS NULL AND 出发站 IS NULL) AND (到达站 = @Original_到达站 OR @Original_到达站 IS NULL AND 到达站 IS NULL) AND (地址 = @Original_地址 OR @Original_地址 IS NULL AND 地址 IS NULL) AND (座位类型 = @Original_座位类型 OR @Original_座位类型 IS NULL AND 座位类型 IS NULL) AND (总价格 = @Original_总价格 OR @Original_总价格 IS NULL AND 总价格 IS NULL) AND (用户名 = @Original_用户名 OR @Original_用户名 IS NULL AND 用户名 IS NULL) AND (票数 = @Original_票数 OR @Original_票数 IS NULL AND 票数 IS NULL) AND (联系方式 = @Original_联系方式 OR @Original_联系方式 IS NULL AND 联系方式 IS NULL) AND (身份证 = @Original_身份证 OR @Original_身份证 IS NULL AND 身份证 IS NULL) AND (车次 = @Original_车次 OR @Original_车次 IS NULL AND 车次 IS NULL); SELECT 序号, 车次, 出发站, 到达站, 座位类型, 票数, 总价格, 用户名, 联系方式, 地址, 身份证 FROM dingpiao WHERE (序号 = @序号)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@序号", System.Data.SqlDbType.Int, 4, "序号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车次", System.Data.SqlDbType.VarChar, 10, "车次"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@出发站", System.Data.SqlDbType.VarChar, 10, "出发站"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达站", System.Data.SqlDbType.VarChar, 10, "到达站"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@座位类型", System.Data.SqlDbType.VarChar, 10, "座位类型"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@票数", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "票数", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@总价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "总价格", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@用户名", System.Data.SqlDbType.VarChar, 50, "用户名"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@联系方式", System.Data.SqlDbType.VarChar, 20, "联系方式"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@地址", System.Data.SqlDbType.VarChar, 50, "地址"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@身份证", System.Data.SqlDbType.VarChar, 20, "身份证"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_出发站", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "出发站", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_到达站", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "到达站", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_地址", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "地址", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_座位类型", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "座位类型", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_总价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "总价格", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户名", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户名", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_票数", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "票数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系方式", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系方式", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_身份证", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "身份证", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车次", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车次", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			// 
			// sqlDataAdapter_dingpiao
			// 
			this.sqlDataAdapter_dingpiao.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_dingpiao.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter_dingpiao.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter_dingpiao.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																											  new System.Data.Common.DataTableMapping("Table", "dingpiao", new System.Data.Common.DataColumnMapping[] {
																																																						  new System.Data.Common.DataColumnMapping("序号", "序号"),
																																																						  new System.Data.Common.DataColumnMapping("车次", "车次"),
																																																						  new System.Data.Common.DataColumnMapping("出发站", "出发站"),
																																																						  new System.Data.Common.DataColumnMapping("到达站", "到达站"),
																																																						  new System.Data.Common.DataColumnMapping("座位类型", "座位类型"),
																																																						  new System.Data.Common.DataColumnMapping("票数", "票数"),
																																																						  new System.Data.Common.DataColumnMapping("总价格", "总价格"),
																																																						  new System.Data.Common.DataColumnMapping("用户名", "用户名"),
																																																						  new System.Data.Common.DataColumnMapping("联系方式", "联系方式"),
																																																						  new System.Data.Common.DataColumnMapping("地址", "地址"),
																																																						  new System.Data.Common.DataColumnMapping("身份证", "身份证")})});
			this.sqlDataAdapter_dingpiao.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT 序号, 车次, 始发站, 终点站, 开车时间, 到达时间, 硬座票数, 硬卧票数, 软卧票数 FROM tickets";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = "INSERT INTO tickets(序号, 车次, 始发站, 终点站, 开车时间, 到达时间, 硬座票数, 硬卧票数, 软卧票数) VALUES (@序号, " +
				"@车次, @始发站, @终点站, @开车时间, @到达时间, @硬座票数, @硬卧票数, @软卧票数); SELECT 序号, 车次, 始发站, 终点站, 开车" +
				"时间, 到达时间, 硬座票数, 硬卧票数, 软卧票数 FROM tickets WHERE (序号 = @序号)";
			this.sqlInsertCommand2.Connection = this.sqlConnection1;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@序号", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车次", System.Data.SqlDbType.VarChar, 10, "车次"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@始发站", System.Data.SqlDbType.VarChar, 10, "始发站"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@终点站", System.Data.SqlDbType.VarChar, 10, "终点站"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@开车时间", System.Data.SqlDbType.DateTime, 8, "开车时间"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达时间", System.Data.SqlDbType.DateTime, 8, "到达时间"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座票数", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬座票数", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧票数", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬卧票数", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧票数", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "软卧票数", System.Data.DataRowVersion.Current, null));
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.Connection = this.sqlConnection1;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = @"DELETE FROM tickets WHERE (序号 = @Original_序号) AND (到达时间 = @Original_到达时间 OR @Original_到达时间 IS NULL AND 到达时间 IS NULL) AND (始发站 = @Original_始发站 OR @Original_始发站 IS NULL AND 始发站 IS NULL) AND (开车时间 = @Original_开车时间 OR @Original_开车时间 IS NULL AND 开车时间 IS NULL) AND (硬卧票数 = @Original_硬卧票数 OR @Original_硬卧票数 IS NULL AND 硬卧票数 IS NULL) AND (硬座票数 = @Original_硬座票数 OR @Original_硬座票数 IS NULL AND 硬座票数 IS NULL) AND (终点站 = @Original_终点站 OR @Original_终点站 IS NULL AND 终点站 IS NULL) AND (车次 = @Original_车次 OR @Original_车次 IS NULL AND 车次 IS NULL) AND (软卧票数 = @Original_软卧票数 OR @Original_软卧票数 IS NULL AND 软卧票数 IS NULL)";
			this.sqlDeleteCommand2.Connection = this.sqlConnection1;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_到达时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "到达时间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_始发站", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "始发站", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_开车时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "开车时间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬卧票数", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬卧票数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬座票数", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬座票数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_终点站", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "终点站", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车次", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车次", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_软卧票数", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "软卧票数", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter_tickets
			// 
			this.sqlDataAdapter_tickets.DeleteCommand = this.sqlDeleteCommand2;
			this.sqlDataAdapter_tickets.InsertCommand = this.sqlInsertCommand2;
			this.sqlDataAdapter_tickets.SelectCommand = this.sqlSelectCommand2;
			this.sqlDataAdapter_tickets.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																											 new System.Data.Common.DataTableMapping("Table", "tickets", new System.Data.Common.DataColumnMapping[] {
																																																						new System.Data.Common.DataColumnMapping("序号", "序号"),
																																																						new System.Data.Common.DataColumnMapping("车次", "车次"),
																																																						new System.Data.Common.DataColumnMapping("始发站", "始发站"),
																																																						new System.Data.Common.DataColumnMapping("终点站", "终点站"),
																																																						new System.Data.Common.DataColumnMapping("开车时间", "开车时间"),
																																																						new System.Data.Common.DataColumnMapping("到达时间", "到达时间"),
																																																						new System.Data.Common.DataColumnMapping("硬座票数", "硬座票数"),
																																																						new System.Data.Common.DataColumnMapping("硬卧票数", "硬卧票数"),
																																																						new System.Data.Common.DataColumnMapping("软卧票数", "软卧票数")})});
			this.sqlDataAdapter_tickets.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "SELECT 序号, 车次, 开车时间, 到达时间, 出发站, 到达站, 硬座票价, 硬卧票价, 软卧票价 FROM ticketsinf";
			this.sqlSelectCommand3.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand3
			// 
			this.sqlInsertCommand3.CommandText = "INSERT INTO ticketsinf(序号, 车次, 开车时间, 到达时间, 出发站, 到达站, 硬座票价, 硬卧票价, 软卧票价) VALUES (@序" +
				"号, @车次, @开车时间, @到达时间, @出发站, @到达站, @硬座票价, @硬卧票价, @软卧票价); SELECT 序号, 车次, 开车时间, 到达时" +
				"间, 出发站, 到达站, 硬座票价, 硬卧票价, 软卧票价 FROM ticketsinf WHERE (序号 = @序号)";
			this.sqlInsertCommand3.Connection = this.sqlConnection1;
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@序号", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车次", System.Data.SqlDbType.VarChar, 18, "车次"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@开车时间", System.Data.SqlDbType.DateTime, 8, "开车时间"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达时间", System.Data.SqlDbType.DateTime, 8, "到达时间"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@出发站", System.Data.SqlDbType.VarChar, 50, "出发站"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达站", System.Data.SqlDbType.VarChar, 50, "到达站"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬座票价", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬卧票价", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "软卧票价", System.Data.DataRowVersion.Current, null));
			// 
			// sqlUpdateCommand3
			// 
			this.sqlUpdateCommand3.CommandText = @"UPDATE ticketsinf SET 序号 = @序号, 车次 = @车次, 开车时间 = @开车时间, 到达时间 = @到达时间, 出发站 = @出发站, 到达站 = @到达站, 硬座票价 = @硬座票价, 硬卧票价 = @硬卧票价, 软卧票价 = @软卧票价 WHERE (序号 = @Original_序号) AND (出发站 = @Original_出发站 OR @Original_出发站 IS NULL AND 出发站 IS NULL) AND (到达时间 = @Original_到达时间 OR @Original_到达时间 IS NULL AND 到达时间 IS NULL) AND (到达站 = @Original_到达站 OR @Original_到达站 IS NULL AND 到达站 IS NULL) AND (开车时间 = @Original_开车时间 OR @Original_开车时间 IS NULL AND 开车时间 IS NULL) AND (硬卧票价 = @Original_硬卧票价 OR @Original_硬卧票价 IS NULL AND 硬卧票价 IS NULL) AND (硬座票价 = @Original_硬座票价 OR @Original_硬座票价 IS NULL AND 硬座票价 IS NULL) AND (车次 = @Original_车次 OR @Original_车次 IS NULL AND 车次 IS NULL) AND (软卧票价 = @Original_软卧票价 OR @Original_软卧票价 IS NULL AND 软卧票价 IS NULL); SELECT 序号, 车次, 开车时间, 到达时间, 出发站, 到达站, 硬座票价, 硬卧票价, 软卧票价 FROM ticketsinf WHERE (序号 = @序号)";
			this.sqlUpdateCommand3.Connection = this.sqlConnection1;
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@序号", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车次", System.Data.SqlDbType.VarChar, 18, "车次"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@开车时间", System.Data.SqlDbType.DateTime, 8, "开车时间"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达时间", System.Data.SqlDbType.DateTime, 8, "到达时间"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@出发站", System.Data.SqlDbType.VarChar, 50, "出发站"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达站", System.Data.SqlDbType.VarChar, 50, "到达站"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬座票价", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬卧票价", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "软卧票价", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_出发站", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "出发站", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_到达时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "到达时间", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_到达站", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "到达站", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_开车时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "开车时间", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬卧票价", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬座票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬座票价", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车次", System.Data.SqlDbType.VarChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车次", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_软卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "软卧票价", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand3
			// 
			this.sqlDeleteCommand3.CommandText = @"DELETE FROM ticketsinf WHERE (序号 = @Original_序号) AND (出发站 = @Original_出发站 OR @Original_出发站 IS NULL AND 出发站 IS NULL) AND (到达时间 = @Original_到达时间 OR @Original_到达时间 IS NULL AND 到达时间 IS NULL) AND (到达站 = @Original_到达站 OR @Original_到达站 IS NULL AND 到达站 IS NULL) AND (开车时间 = @Original_开车时间 OR @Original_开车时间 IS NULL AND 开车时间 IS NULL) AND (硬卧票价 = @Original_硬卧票价 OR @Original_硬卧票价 IS NULL AND 硬卧票价 IS NULL) AND (硬座票价 = @Original_硬座票价 OR @Original_硬座票价 IS NULL AND 硬座票价 IS NULL) AND (车次 = @Original_车次 OR @Original_车次 IS NULL AND 车次 IS NULL) AND (软卧票价 = @Original_软卧票价 OR @Original_软卧票价 IS NULL AND 软卧票价 IS NULL)";
			this.sqlDeleteCommand3.Connection = this.sqlConnection1;
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_出发站", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "出发站", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_到达时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "到达时间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_到达站", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "到达站", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_开车时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "开车时间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬卧票价", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬座票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬座票价", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车次", System.Data.SqlDbType.VarChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车次", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_软卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "软卧票价", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter_ticketsinf
			// 
			this.sqlDataAdapter_ticketsinf.DeleteCommand = this.sqlDeleteCommand3;
			this.sqlDataAdapter_ticketsinf.InsertCommand = this.sqlInsertCommand3;
			this.sqlDataAdapter_ticketsinf.SelectCommand = this.sqlSelectCommand3;
			this.sqlDataAdapter_ticketsinf.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																												new System.Data.Common.DataTableMapping("Table", "ticketsinf", new System.Data.Common.DataColumnMapping[] {
																																																							  new System.Data.Common.DataColumnMapping("序号", "序号"),
																																																							  new System.Data.Common.DataColumnMapping("车次", "车次"),
																																																							  new System.Data.Common.DataColumnMapping("开车时间", "开车时间"),
																																																							  new System.Data.Common.DataColumnMapping("到达时间", "到达时间"),
																																																							  new System.Data.Common.DataColumnMapping("出发站", "出发站"),
																																																							  new System.Data.Common.DataColumnMapping("到达站", "到达站"),
																																																							  new System.Data.Common.DataColumnMapping("硬座票价", "硬座票价"),
																																																							  new System.Data.Common.DataColumnMapping("硬卧票价", "硬卧票价"),
																																																							  new System.Data.Common.DataColumnMapping("软卧票价", "软卧票价")})});
			this.sqlDataAdapter_ticketsinf.UpdateCommand = this.sqlUpdateCommand3;
			// 
			// sqlConnection2
			// 
			this.sqlConnection2.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlDataAdapter_kongtiaoche
			// 
			this.sqlDataAdapter_kongtiaoche.SelectCommand = this.sqlSelectCommand4;
			this.sqlDataAdapter_kongtiaoche.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																												 new System.Data.Common.DataTableMapping("Table", "kongtiaoliechejiage", new System.Data.Common.DataColumnMapping[] {
																																																										new System.Data.Common.DataColumnMapping("序号", "序号"),
																																																										new System.Data.Common.DataColumnMapping("里程", "里程"),
																																																										new System.Data.Common.DataColumnMapping("普通列车", "普通列车"),
																																																										new System.Data.Common.DataColumnMapping("普快列车", "普快列车"),
																																																										new System.Data.Common.DataColumnMapping("特快列车", "特快列车"),
																																																										new System.Data.Common.DataColumnMapping("空调费率", "空调费率"),
																																																										new System.Data.Common.DataColumnMapping("座位类型", "座位类型")})});
			// 
			// sqlSelectCommand4
			// 
			this.sqlSelectCommand4.CommandText = "SELECT 序号, 里程, 普通列车, 普快列车, 特快列车, 空调费率, 座位类型 FROM kongtiaoliechejiage";
			this.sqlSelectCommand4.Connection = this.sqlConnection2;
			// 
			// sqlDataAdapter_kongtiaochewopu
			// 
			this.sqlDataAdapter_kongtiaochewopu.SelectCommand = this.sqlSelectCommand5;
			this.sqlDataAdapter_kongtiaochewopu.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																													 new System.Data.Common.DataTableMapping("Table", "kongtiaoliechewopujiage", new System.Data.Common.DataColumnMapping[] {
																																																												new System.Data.Common.DataColumnMapping("序号", "序号"),
																																																												new System.Data.Common.DataColumnMapping("里程", "里程"),
																																																												new System.Data.Common.DataColumnMapping("上铺", "上铺"),
																																																												new System.Data.Common.DataColumnMapping("中铺", "中铺"),
																																																												new System.Data.Common.DataColumnMapping("下铺", "下铺"),
																																																												new System.Data.Common.DataColumnMapping("空调费率", "空调费率"),
																																																												new System.Data.Common.DataColumnMapping("车辆类型", "车辆类型"),
																																																												new System.Data.Common.DataColumnMapping("座位类型", "座位类型")})});
			// 
			// sqlSelectCommand5
			// 
			this.sqlSelectCommand5.CommandText = "SELECT 序号, 里程, 上铺, 中铺, 下铺, 空调费率, 车辆类型, 座位类型 FROM kongtiaoliechewopujiage";
			this.sqlSelectCommand5.Connection = this.sqlConnection2;
			// 
			// sqlDataAdapter_putongche
			// 
			this.sqlDataAdapter_putongche.SelectCommand = this.sqlSelectCommand6;
			this.sqlDataAdapter_putongche.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																											   new System.Data.Common.DataTableMapping("Table", "putongliechejiage", new System.Data.Common.DataColumnMapping[] {
																																																									new System.Data.Common.DataColumnMapping("序号", "序号"),
																																																									new System.Data.Common.DataColumnMapping("里程", "里程"),
																																																									new System.Data.Common.DataColumnMapping("普通列车", "普通列车"),
																																																									new System.Data.Common.DataColumnMapping("普快列车", "普快列车"),
																																																									new System.Data.Common.DataColumnMapping("特快列车", "特快列车"),
																																																									new System.Data.Common.DataColumnMapping("空调费率", "空调费率"),
																																																									new System.Data.Common.DataColumnMapping("座位类型", "座位类型")})});
			// 
			// sqlSelectCommand6
			// 
			this.sqlSelectCommand6.CommandText = "SELECT 序号, 里程, 普通列车, 普快列车, 特快列车, 空调费率, 座位类型 FROM putongliechejiage";
			this.sqlSelectCommand6.Connection = this.sqlConnection2;
			// 
			// sqlDataAdapter_putongchewopu
			// 
			this.sqlDataAdapter_putongchewopu.SelectCommand = this.sqlSelectCommand7;
			this.sqlDataAdapter_putongchewopu.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																												   new System.Data.Common.DataTableMapping("Table", "putongliechewopujiage", new System.Data.Common.DataColumnMapping[] {
																																																											new System.Data.Common.DataColumnMapping("序号", "序号"),
																																																											new System.Data.Common.DataColumnMapping("里程", "里程"),
																																																											new System.Data.Common.DataColumnMapping("上铺", "上铺"),
																																																											new System.Data.Common.DataColumnMapping("中铺", "中铺"),
																																																											new System.Data.Common.DataColumnMapping("下铺", "下铺"),
																																																											new System.Data.Common.DataColumnMapping("空调费率", "空调费率"),
																																																											new System.Data.Common.DataColumnMapping("车辆类型", "车辆类型"),
																																																											new System.Data.Common.DataColumnMapping("座位类型", "座位类型")})});
			// 
			// sqlSelectCommand7
			// 
			this.sqlSelectCommand7.CommandText = "SELECT 序号, 里程, 上铺, 中铺, 下铺, 空调费率, 车辆类型, 座位类型 FROM putongliechewopujiage";
			this.sqlSelectCommand7.Connection = this.sqlConnection2;
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private void xianshicheci(string cc)
		{
			dsbegin=new DataSet();
			dsend=new DataSet(); 


			sql="SELECT 出发站 FROM ticketsinf";
			sql+=" where 车次='"+ this.Text_checi.Text.Trim()+"'";
			
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();

			this.sqlDataAdapter_ticketsinf.SelectCommand.CommandText=sql;
			this.sqlDataAdapter_ticketsinf.Fill(this.dsbegin);

			this.DropDownList_qsz.DataSource=this.dsbegin;
			this.DropDownList_qsz.DataMember=this.dsbegin.Tables[0].ToString();
			this.DropDownList_qsz.DataTextField=this.dsbegin.Tables[0].Columns[0].ToString();
			this.DropDownList_qsz.DataValueField=this.dsbegin.Tables[0].Columns[0].ToString();
			this.DropDownList_qsz.DataBind();



			sql="SELECT 到达站 FROM ticketsinf";
			sql+=" where 车次='"+ this.Text_checi.Text+"'";
			this.sqlDataAdapter_ticketsinf.SelectCommand.CommandText=sql;
			this.sqlDataAdapter_ticketsinf.Fill(this.dsend);

			this.DropDownList_zdz.DataSource=this.dsend;
			this.DropDownList_zdz.DataMember=this.dsend.Tables[0].ToString();
			this.DropDownList_zdz.DataTextField=this.dsend.Tables[0].Columns[0].ToString();
			this.DropDownList_zdz.DataValueField=this.dsend.Tables[0].Columns[0].ToString();
			this.DropDownList_zdz.DataBind();
		}
		public void DropDownList_zwlx1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			type=this.DropDownList_zwlx1.SelectedItem.Value.ToString();
		}
		private  Decimal  jisuanjiage()
		{
				dsleixing=new DataSet();
			dsputongche=new DataSet();
			dsputongchewopu=new DataSet();
			dskongtiaoche=new DataSet();
			dskongtiaochewopu=new DataSet();
			decimal jiage=0m;
			this.sqlDataAdapter_tickets.SelectCommand.CommandText="select 有无空调,车辆类型 from tickets where 车次='"+this.Text_checi.Text.Trim()+"'";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();

			this.sqlDataAdapter_tickets.Fill(dsleixing);
			string kongtiao=this.dsleixing.Tables[0].Rows[0][0].ToString().Trim();
			string leixing=this.dsleixing.Tables[0].Rows[0][1].ToString().Trim();
			string zuoweileixing=this.DropDownList_zwlx1.SelectedItem.Text.Trim();
			decimal  lucheng=this.jisuanlucheng();
			if((kongtiao=="")&&(zuoweileixing=="硬座"))
			{
				this.sqlDataAdapter_putongche.SelectCommand.CommandText="select 里程,普通列车,普快列车,特快列车,空调费率 ,座位类型 from putongliechejiage ";
				if(this.sqlConnection2.State.ToString()=="Closed")
					this.sqlConnection2.Open();

				this.sqlDataAdapter_putongche.Fill(this.dsputongche);
				int hangshu=this.dsputongche.Tables[0].Rows.Count;
				if(leixing=="普通")
				{
					for(int i=0;i<hangshu;i++)
					{
							if(lucheng>=decimal.Parse(this.dsputongche.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongche.Tables[0].Rows[i+1][0].ToString()))
					   {
							   jiage=decimal.Parse(this.dsputongche.Tables[0].Rows[i][1].ToString())+decimal.Parse(this.dsputongche.Tables[0].Rows[i][4].ToString());
						   break;
					   }
					}
				
				}
				else if(leixing=="普快")
				{
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongche.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongche.Tables[0].Rows[i+1][0].ToString()))
						{
								jiage=decimal.Parse(this.dsputongche.Tables[0].Rows[i][2].ToString())+decimal.Parse(this.dsputongche.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="特快")
				{
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongche.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongche.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongche.Tables[0].Rows[i][3].ToString())+decimal.Parse(this.dsputongche.Tables[0].Rows[i][4].ToString());
							break;
						}
					} 
				
				}

			
			
			
			}
			else if((kongtiao=="空调")&&(zuoweileixing=="硬座"))
			{
				this.sqlDataAdapter_kongtiaoche.SelectCommand.CommandText="select 里程,普通列车,普快列车,特快列车 from kongtiaoliechejiage ";
				if(this.sqlConnection2.State.ToString()=="Closed")
					this.sqlConnection2.Open();

				this.sqlDataAdapter_kongtiaoche.Fill(this.dskongtiaoche);
				int hangshu=this.dskongtiaoche.Tables[0].Rows.Count;
				if(leixing=="普通")
				{
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i][1].ToString());
						}
					}
				
				}
				else if(leixing=="普快")
				{
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i][2].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="特快")
				{
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i][3].ToString());
							break;
						}
					} 
				
				}

			
			
			
			}
			else if((kongtiao=="")&&(zuoweileixing=="硬卧上"))
			{
				
				if(leixing=="普通")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='硬卧'and 车辆类型='普通列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][1].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="普快")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='硬卧'and 车辆类型='普快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][1].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="特快")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='硬卧'and 车辆类型='特快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][1].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="")&&(zuoweileixing=="硬卧中"))
			{
				
				if(leixing=="普通")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='硬卧'and 车辆类型='普通列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][2].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="普快")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='硬卧'and 车辆类型='普快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][2].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="特快")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='硬卧'and 车辆类型='特快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][2].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="")&&(zuoweileixing=="硬卧下"))
			{
				
				if(leixing=="普通")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='硬卧'and 车辆类型='普通列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][3].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="普快")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='硬卧'and 车辆类型='普快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][3].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="特快")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='硬卧'and 车辆类型='特快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][3].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="")&&(zuoweileixing=="软卧上"))
			{
				
				if(leixing=="普通")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='软卧'and 车辆类型='普通列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][1].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="普快")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='软卧'and 车辆类型='普快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][1].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="特快")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='软卧'and 车辆类型='特快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][1].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="")&&(zuoweileixing=="软卧中"))
			{
				
				if(leixing=="普通")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='软卧'and 车辆类型='普通列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][2].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="普快")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='软卧'and 车辆类型='普快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][2].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="特快")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='软卧'and 车辆类型='特快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][2].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="")&&(zuoweileixing=="软卧下"))
			{
				
				if(leixing=="普通")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='软卧'and 车辆类型='普通列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][3].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="普快")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='软卧'and 车辆类型='普快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][3].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="特快")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,空调费率,车辆类型 from putongliechewopujiage where 座位类型='软卧'and 车辆类型='特快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][3].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				
			
			}
		
			else if((kongtiao=="空调")&&(zuoweileixing=="硬卧上"))
			{
				
				if(leixing=="普通")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,车辆类型 from kongtiaoliechewopujiage where 座位类型='硬卧'and 车辆类型='普通列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][1].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="普快")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,车辆类型 from kongtiaoliechewopujiage where 座位类型='硬卧'and 车辆类型='普快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][1].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="特快")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,车辆类型 from kongtiaoliechewopujiage where 座位类型='硬卧'and 车辆类型='特快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][1].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="空调")&&(zuoweileixing=="硬卧中"))
			{
				
				if(leixing=="普通")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,车辆类型 from kongtiaoliechewopujiage where 座位类型='硬卧'and 车辆类型='普通列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][2].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="普快")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,车辆类型 from kongtiaoliechewopujiage where 座位类型='硬卧'and 车辆类型='普快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][2].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="特快")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,车辆类型 from kongtiaoliechewopujiage where 座位类型='硬卧'and 车辆类型='特快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][2].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="空调")&&(zuoweileixing=="硬卧下"))
			{
				
				if(leixing=="普通")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,车辆类型 from kongtiaoliechewopujiage where 座位类型='硬卧'and 车辆类型='普通列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][3].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="普快")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,车辆类型 from kongtiaoliechewopujiage where 座位类型='硬卧'and 车辆类型='普快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][3].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="特快")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺车辆类型 from kongtiaoliechewopujiage where 座位类型='硬卧'and 车辆类型='特快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][3].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="空调")&&(zuoweileixing=="软卧上"))
			{
				
				if(leixing=="普通")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,车辆类型 from kongtiaoliechewopujiage where 座位类型='软卧'and 车辆类型='普通列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][1].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="普快")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,车辆类型 from kongtiaoliechewopujiage where 座位类型='软卧'and 车辆类型='普快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][1].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="特快")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,车辆类型 from kongtiaoliechewopujiage where 座位类型='软卧'and 车辆类型='特快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][1].ToString());
							break;
						}
					}
				
				}
				
			
			}
			
			else if((kongtiao=="空调")&&(zuoweileixing=="软卧下"))
			{
				
				if(leixing=="普通")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,车辆类型 from kongtiaoliechewopujiage where 座位类型='软卧'and 车辆类型='普通列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][3].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="普快")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,车辆类型 from kongtiaoliechewopujiage where 座位类型='软卧'and 车辆类型='普快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][3].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="特快")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select 里程,上铺,中铺,下铺,车辆类型 from kongtiaoliechewopujiage where 座位类型='软卧'and 车辆类型='特快列车'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][3].ToString());
							break;
						}
					}
				
				}
				
			
			}
			return jiage*int.Parse(this.Text_ps.Text.Trim());
			
		}
		private Decimal jisuanlucheng()
		{  
			Decimal total=0m;  
			bool leiji=false;  //是否开始累计
			dslucheng=new DataSet();
			 
               
			this.begin=this.DropDownList_qsz.SelectedItem.Value.ToString().Trim();
			this.end=this.DropDownList_zdz.SelectedItem.Value.ToString().Trim();

		

			sql="select 出发站,到达站,行程 from ticketsinf";
			sql+=" where 车次='"+this.Text_checi.Text.Trim()+"'";

			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();

			this.sqlDataAdapter_ticketsinf.SelectCommand.CommandText=sql;
			this.sqlDataAdapter_ticketsinf.Fill(this.dslucheng);

			DataTable table_lucheng=this.dslucheng.Tables[0];

			int count = table_lucheng.Rows.Count;
			

			for(int i=0;i<count;i++)
			{
				string chufazhan=table_lucheng.Rows[i]["出发站"].ToString().Trim();
				string daodazhan=table_lucheng.Rows[i]["到达站"].ToString().Trim();

				if(chufazhan==this.begin )
					leiji=true;

				if(leiji==true)
					total+=Decimal.Parse(table_lucheng.Rows[i][2].ToString().Trim());

				if(daodazhan==this.end)
					leiji=false;
			}
			return total;
		}
		private void Button_qdcc_Click(object sender, System.EventArgs e)
		{
			
			this.cc=this.Text_checi.Text.Trim();
			if(cc!="")
			{
				xianshicheci(this.cc);
			}
		}

		private void Button_jg_Click(object sender, System.EventArgs e)
		{
			
			if(this.Text_ps.Text.Trim()=="")
			{
				Global.Alert(this,"请填写正确的订票数!");
				return;
			}
			else
			{
				Decimal yuanjia=jisuanjiage();
				Decimal xiantui=Global.TPBL*yuanjia;
				this.Label_yj.Text=Global.strFormate(yuanjia);
				this.Label_xt.Text=Global.strFormate(xiantui);	
			}
		}

	
	
		private void Button_tplx_Click(object sender, System.EventArgs e)
		{
			if(this.RadioButton_tuiding.Checked==true)
            this.Panel1.Visible=true;
			else  this.Panel1.Visible=false;
		}
		private void updatekucun(string checi,string type,string count)
		{
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sql="UPDATE tickets  SET "+type+"票数="+type+"票数+"+count;
			this.sql+=" WHERE  车次='"+checi+"'";
			this.sqlDataAdapter_tickets.UpdateCommand.CommandText=sql;

			this.sqlDataAdapter_tickets.UpdateCommand.ExecuteNonQuery();
			Global.Alert(this,"退票成功");
			this.chongzhi();
		}
		private void chongzhi()
		{
		    this.RadioButton_tuiding.Checked=false;
			this.RadioButton_tuipiao.Checked=false;
			this.Text_checi.Text="";
			this.TextBox_dz.Text="";
			this.TextBox_lxfs.Text="";
			this.Text_ps.Text="";
			this.TextBox_sfz.Text="";
			this.TextBox_xm.Text="";
			this.DropDownList_qsz.SelectedItem.Text="";
			this.DropDownList_zdz.SelectedItem.Text="";
			this.Label_xt.Text="";
			this.Label_yj.Text="";
			this.DropDownList_zwlx1.SelectedItem.Text="";
           
   
			this.DropDownList_nian.SelectedItem.Text="";
			this.DropDownList_yue.SelectedItem.Text="";
			this.DropDownList_ri.SelectedItem.Text="";
			
		}

		private void Button_tp_Click(object sender, System.EventArgs e)
		{
			if(this.RadioButton_tuipiao.Checked==true)
			{
			    string sj=this.DropDownList_nian.SelectedItem.Text.ToString()+"-"+this.DropDownList_yue.SelectedItem.Text.ToString()+"-"+this.DropDownList_ri.SelectedItem.Text.ToString();
				this.sqlDataAdapter_dingpiao.DeleteCommand.CommandText="delete from dingpiao where 车次='"+this.Text_checi.Text.Trim()+"' and 出发站='"+this.DropDownList_qsz.SelectedItem.Text.ToString()+"'and 到达站='"+this.DropDownList_zdz.SelectedItem.Text.ToString()+"'and 座位类型='"+this.DropDownList_zwlx1.SelectedItem.Text.ToString()+"'and 发车日期='"+sj+"'";
				if(this.sqlConnection1.State.ToString()=="Closed")
					this.sqlConnection1.Open();

                   this.sqlDataAdapter_dingpiao.DeleteCommand.ExecuteNonQuery();


               updatekucun(this.Text_checi.Text,this.DropDownList_zwlx1.SelectedItem.Text.ToString(),this.Text_ps.Text);
             
				  
				this.chongzhi();

			}
			if(this.RadioButton_tuiding.Checked==true)
			{
			 
				string sj=this.DropDownList_nian.SelectedItem.Text.ToString()+"-"+this.DropDownList_yue.SelectedItem.Text.ToString()+"-"+this.DropDownList_ri.SelectedItem.Text.ToString();
				this.sqlDataAdapter_dingpiao.DeleteCommand.CommandText="delete from dingpiao where 车次='"+this.Text_checi.Text.Trim()+"' and 出发站='"+this.DropDownList_qsz.SelectedItem.Text.ToString()+"'and 到达站='"+this.DropDownList_zdz.SelectedItem.Text.ToString()+"'and 座位类型='"+this.DropDownList_zwlx1.SelectedItem.Text.ToString()+"'and 发车日期='"+sj+"'and 身份证='"+this.TextBox_sfz.Text.ToString()+"'";
				if(this.sqlConnection1.State.ToString()=="Closed")
					this.sqlConnection1.Open();

				this.sqlDataAdapter_dingpiao.DeleteCommand.ExecuteNonQuery();


				updatekucun(this.Text_checi.Text,this.DropDownList_zwlx1.SelectedItem.Text.ToString(),this.Text_ps.Text);
             
				  
				this.chongzhi();

			}
		}

		private void Button_cz_Click(object sender, System.EventArgs e)
		{
			  
			this.chongzhi();

		}

	


		

		private void DropDownList_zwlx1_SelectedIndexChanged_1(object sender, System.EventArgs e)
		{
		}

		private void Button_maipiao_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("maipiao.aspx?flag=1");
		}

		private void Button_dingpiao_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("maipiao.aspx?flag=2");
		}

		private void Button_tuipiao_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("tuipiao.aspx");
		}

		private void Button_chaxun_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("chaxun.aspx");
		}

		private void Button_yhgl_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("yonghuguanlizhujiemian.aspx");
		}
	}
}
