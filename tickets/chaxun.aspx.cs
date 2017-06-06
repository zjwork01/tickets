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
	/// chaxun 的摘要说明。
	/// </summary>
	public class chaxun : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button_maipiao;
		protected System.Web.UI.WebControls.Button Button_dingpiao;
		protected System.Web.UI.WebControls.Button Button_tuipiao;
		protected System.Web.UI.WebControls.Button Button_chaxun;
		protected System.Web.UI.WebControls.Button Button_yhgl;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.Button Button_cxcx;
		protected System.Web.UI.WebControls.Button Button_chaxun1;
		protected System.Web.UI.WebControls.Button Button_chaxun2;
		protected System.Web.UI.WebControls.TextBox TextBox_checi;
		protected System.Web.UI.WebControls.TextBox TextBox_qsz;
		protected System.Web.UI.WebControls.TextBox TextBox_zdz;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		private string sql;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_ticketsinf;
		private string type;
		private string begin;
		private string  end;
	    private	string lscc;
		protected System.Data.DataSet dsbegin;
		protected System.Data.DataSet dsend;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_tickets;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected tickets.DataSet_chaxun1 dataSet_chaxun1;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Label Label_LLQ;
		protected System.Web.UI.WebControls.Label Label_IP;
		protected System.Data.DataSet dschaxun;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection1.ConnectionString=data.connStr;
			// 在此处放置用户代码以初始化页面
			if(Session["username"].ToString()=="admin")
				this.Button_yhgl.Visible=true;
			else  this.Button_yhgl.Visible=false;
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
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_ticketsinf = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDataAdapter_tickets = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.dataSet_chaxun1 = new tickets.DataSet_chaxun1();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_chaxun1)).BeginInit();
			this.Button_maipiao.Click += new System.EventHandler(this.Button_maipiao_Click);
			this.Button_dingpiao.Click += new System.EventHandler(this.Button_dingpiao_Click);
			this.Button_tuipiao.Click += new System.EventHandler(this.Button_tuipiao_Click);
			this.Button_chaxun.Click += new System.EventHandler(this.Button_chaxun_Click);
			this.Button_yhgl.Click += new System.EventHandler(this.Button_yhgl_Click);
			this.Button_cxcx.Click += new System.EventHandler(this.Button1_Click);
			this.Button_chaxun1.Click += new System.EventHandler(this.Button_chaxun1_Click);
			this.Button_chaxun2.Click += new System.EventHandler(this.Button3_Click);
			this.DataGrid1.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_ItemCommand);
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT 序号, 车次, 开车时间, 到达时间, 出发站, 到达站, 硬座票价, 硬卧票价, 软卧票价 FROM ticketsinf";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO ticketsinf(序号, 车次, 开车时间, 到达时间, 出发站, 到达站, 硬座票价, 硬卧票价, 软卧票价) VALUES (@序" +
				"号, @车次, @开车时间, @到达时间, @出发站, @到达站, @硬座票价, @硬卧票价, @软卧票价); SELECT 序号, 车次, 开车时间, 到达时" +
				"间, 出发站, 到达站, 硬座票价, 硬卧票价, 软卧票价 FROM ticketsinf WHERE (序号 = @序号)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@序号", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车次", System.Data.SqlDbType.VarChar, 18, "车次"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@开车时间", System.Data.SqlDbType.DateTime, 8, "开车时间"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达时间", System.Data.SqlDbType.DateTime, 8, "到达时间"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@出发站", System.Data.SqlDbType.VarChar, 50, "出发站"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达站", System.Data.SqlDbType.VarChar, 50, "到达站"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬座票价", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬卧票价", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "软卧票价", System.Data.DataRowVersion.Current, null));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE ticketsinf SET 序号 = @序号, 车次 = @车次, 开车时间 = @开车时间, 到达时间 = @到达时间, 出发站 = @出发站, 到达站 = @到达站, 硬座票价 = @硬座票价, 硬卧票价 = @硬卧票价, 软卧票价 = @软卧票价 WHERE (序号 = @Original_序号) AND (出发站 = @Original_出发站 OR @Original_出发站 IS NULL AND 出发站 IS NULL) AND (到达时间 = @Original_到达时间 OR @Original_到达时间 IS NULL AND 到达时间 IS NULL) AND (到达站 = @Original_到达站 OR @Original_到达站 IS NULL AND 到达站 IS NULL) AND (开车时间 = @Original_开车时间 OR @Original_开车时间 IS NULL AND 开车时间 IS NULL) AND (硬卧票价 = @Original_硬卧票价 OR @Original_硬卧票价 IS NULL AND 硬卧票价 IS NULL) AND (硬座票价 = @Original_硬座票价 OR @Original_硬座票价 IS NULL AND 硬座票价 IS NULL) AND (车次 = @Original_车次 OR @Original_车次 IS NULL AND 车次 IS NULL) AND (软卧票价 = @Original_软卧票价 OR @Original_软卧票价 IS NULL AND 软卧票价 IS NULL); SELECT 序号, 车次, 开车时间, 到达时间, 出发站, 到达站, 硬座票价, 硬卧票价, 软卧票价 FROM ticketsinf WHERE (序号 = @序号)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@序号", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车次", System.Data.SqlDbType.VarChar, 18, "车次"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@开车时间", System.Data.SqlDbType.DateTime, 8, "开车时间"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达时间", System.Data.SqlDbType.DateTime, 8, "到达时间"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@出发站", System.Data.SqlDbType.VarChar, 50, "出发站"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达站", System.Data.SqlDbType.VarChar, 50, "到达站"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬座票价", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬卧票价", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "软卧票价", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_出发站", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "出发站", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_到达时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "到达时间", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_到达站", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "到达站", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_开车时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "开车时间", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬卧票价", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬座票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬座票价", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车次", System.Data.SqlDbType.VarChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车次", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_软卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "软卧票价", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM ticketsinf WHERE (序号 = @Original_序号) AND (出发站 = @Original_出发站 OR @Original_出发站 IS NULL AND 出发站 IS NULL) AND (到达时间 = @Original_到达时间 OR @Original_到达时间 IS NULL AND 到达时间 IS NULL) AND (到达站 = @Original_到达站 OR @Original_到达站 IS NULL AND 到达站 IS NULL) AND (开车时间 = @Original_开车时间 OR @Original_开车时间 IS NULL AND 开车时间 IS NULL) AND (硬卧票价 = @Original_硬卧票价 OR @Original_硬卧票价 IS NULL AND 硬卧票价 IS NULL) AND (硬座票价 = @Original_硬座票价 OR @Original_硬座票价 IS NULL AND 硬座票价 IS NULL) AND (车次 = @Original_车次 OR @Original_车次 IS NULL AND 车次 IS NULL) AND (软卧票价 = @Original_软卧票价 OR @Original_软卧票价 IS NULL AND 软卧票价 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_出发站", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "出发站", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_到达时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "到达时间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_到达站", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "到达站", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_开车时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "开车时间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬卧票价", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬座票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "硬座票价", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车次", System.Data.SqlDbType.VarChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车次", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_软卧票价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "软卧票价", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter_ticketsinf
			// 
			this.sqlDataAdapter_ticketsinf.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_ticketsinf.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter_ticketsinf.SelectCommand = this.sqlSelectCommand2;
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
			this.sqlDataAdapter_ticketsinf.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDataAdapter_tickets
			// 
			this.sqlDataAdapter_tickets.DeleteCommand = this.sqlDeleteCommand2;
			this.sqlDataAdapter_tickets.InsertCommand = this.sqlInsertCommand2;
			this.sqlDataAdapter_tickets.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter_tickets.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																											 new System.Data.Common.DataTableMapping("Table", "tickets", new System.Data.Common.DataColumnMapping[] {
																																																						new System.Data.Common.DataColumnMapping("序号", "序号"),
																																																						new System.Data.Common.DataColumnMapping("车次", "车次"),
																																																						new System.Data.Common.DataColumnMapping("始发站", "始发站"),
																																																						new System.Data.Common.DataColumnMapping("终点站", "终点站"),
																																																						new System.Data.Common.DataColumnMapping("开车时间", "开车时间"),
																																																						new System.Data.Common.DataColumnMapping("到达时间", "到达时间"),
																																																						new System.Data.Common.DataColumnMapping("硬座票数", "硬座票数"),
																																																						new System.Data.Common.DataColumnMapping("硬卧上票数", "硬卧上票数"),
																																																						new System.Data.Common.DataColumnMapping("硬卧中票数", "硬卧中票数"),
																																																						new System.Data.Common.DataColumnMapping("硬卧下票数", "硬卧下票数"),
																																																						new System.Data.Common.DataColumnMapping("软卧上票数", "软卧上票数"),
																																																						new System.Data.Common.DataColumnMapping("软卧中票数", "软卧中票数"),
																																																						new System.Data.Common.DataColumnMapping("软卧下票数", "软卧下票数"),
																																																						new System.Data.Common.DataColumnMapping("有无空调", "有无空调"),
																																																						new System.Data.Common.DataColumnMapping("车辆类型", "车辆类型"),
																																																						new System.Data.Common.DataColumnMapping("硬座车厢数", "硬座车厢数"),
																																																						new System.Data.Common.DataColumnMapping("硬座车厢人数", "硬座车厢人数"),
																																																						new System.Data.Common.DataColumnMapping("硬卧车厢数", "硬卧车厢数"),
																																																						new System.Data.Common.DataColumnMapping("硬卧车厢人数", "硬卧车厢人数"),
																																																						new System.Data.Common.DataColumnMapping("软卧车厢数", "软卧车厢数"),
																																																						new System.Data.Common.DataColumnMapping("软卧车厢人数", "软卧车厢人数")})});
			this.sqlDataAdapter_tickets.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = "DELETE FROM tickets WHERE (车次 = @Original_车次)";
			this.sqlDeleteCommand2.Connection = this.sqlConnection1;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车次", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车次", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = @"INSERT INTO tickets(车次, 始发站, 终点站, 开车时间, 到达时间, 硬座票数, 硬卧上票数, 硬卧中票数, 硬卧下票数, 软卧上票数, 软卧中票数, 软卧下票数, 有无空调, 车辆类型, 硬座车厢数, 硬座车厢人数, 硬卧车厢数, 硬卧车厢人数, 软卧车厢数, 软卧车厢人数) VALUES (@车次, @始发站, @终点站, @开车时间, @到达时间, @硬座票数, @硬卧上票数, @硬卧中票数, @硬卧下票数, @软卧上票数, @软卧中票数, @软卧下票数, @有无空调, @车辆类型, @硬座车厢数, @硬座车厢人数, @硬卧车厢数, @硬卧车厢人数, @软卧车厢数, @软卧车厢人数)";
			this.sqlInsertCommand2.Connection = this.sqlConnection1;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车次", System.Data.SqlDbType.VarChar, 10, "车次"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@始发站", System.Data.SqlDbType.VarChar, 10, "始发站"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@终点站", System.Data.SqlDbType.VarChar, 10, "终点站"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@开车时间", System.Data.SqlDbType.DateTime, 8, "开车时间"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达时间", System.Data.SqlDbType.DateTime, 8, "到达时间"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座票数", System.Data.SqlDbType.Int, 4, "硬座票数"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧上票数", System.Data.SqlDbType.Int, 4, "硬卧上票数"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧中票数", System.Data.SqlDbType.Int, 4, "硬卧中票数"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧下票数", System.Data.SqlDbType.Int, 4, "硬卧下票数"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧上票数", System.Data.SqlDbType.Int, 4, "软卧上票数"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧中票数", System.Data.SqlDbType.Int, 4, "软卧中票数"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧下票数", System.Data.SqlDbType.Int, 4, "软卧下票数"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@有无空调", System.Data.SqlDbType.VarChar, 10, "有无空调"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车辆类型", System.Data.SqlDbType.VarChar, 10, "车辆类型"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座车厢数", System.Data.SqlDbType.Int, 4, "硬座车厢数"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座车厢人数", System.Data.SqlDbType.Int, 4, "硬座车厢人数"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧车厢数", System.Data.SqlDbType.Int, 4, "硬卧车厢数"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧车厢人数", System.Data.SqlDbType.Int, 4, "硬卧车厢人数"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧车厢数", System.Data.SqlDbType.Int, 4, "软卧车厢数"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧车厢人数", System.Data.SqlDbType.Int, 4, "软卧车厢人数"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 序号, 车次, 始发站, 终点站, 开车时间, 到达时间, 硬座票数, 硬卧上票数, 硬卧中票数, 硬卧下票数, 软卧上票数, 软卧中票数, 软卧下" +
				"票数, 有无空调, 车辆类型, 硬座车厢数, 硬座车厢人数, 硬卧车厢数, 硬卧车厢人数, 软卧车厢数, 软卧车厢人数 FROM tickets";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = @"UPDATE tickets SET 车次 = @车次, 始发站 = @始发站, 终点站 = @终点站, 开车时间 = @开车时间, 到达时间 = @到达时间, 硬座票数 = @硬座票数, 硬卧上票数 = @硬卧上票数, 硬卧中票数 = @硬卧中票数, 硬卧下票数 = @硬卧下票数, 软卧上票数 = @软卧上票数, 软卧中票数 = @软卧中票数, 软卧下票数 = @软卧下票数, 有无空调 = @有无空调, 车辆类型 = @车辆类型, 硬座车厢数 = @硬座车厢数, 硬座车厢人数 = @硬座车厢人数, 硬卧车厢数 = @硬卧车厢数, 硬卧车厢人数 = @硬卧车厢人数, 软卧车厢数 = @软卧车厢数, 软卧车厢人数 = @软卧车厢人数 WHERE (车次 = @Original_车次)";
			this.sqlUpdateCommand2.Connection = this.sqlConnection1;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车次", System.Data.SqlDbType.VarChar, 10, "车次"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@始发站", System.Data.SqlDbType.VarChar, 10, "始发站"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@终点站", System.Data.SqlDbType.VarChar, 10, "终点站"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@开车时间", System.Data.SqlDbType.DateTime, 8, "开车时间"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达时间", System.Data.SqlDbType.DateTime, 8, "到达时间"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座票数", System.Data.SqlDbType.Int, 4, "硬座票数"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧上票数", System.Data.SqlDbType.Int, 4, "硬卧上票数"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧中票数", System.Data.SqlDbType.Int, 4, "硬卧中票数"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧下票数", System.Data.SqlDbType.Int, 4, "硬卧下票数"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧上票数", System.Data.SqlDbType.Int, 4, "软卧上票数"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧中票数", System.Data.SqlDbType.Int, 4, "软卧中票数"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧下票数", System.Data.SqlDbType.Int, 4, "软卧下票数"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@有无空调", System.Data.SqlDbType.VarChar, 10, "有无空调"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车辆类型", System.Data.SqlDbType.VarChar, 10, "车辆类型"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座车厢数", System.Data.SqlDbType.Int, 4, "硬座车厢数"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座车厢人数", System.Data.SqlDbType.Int, 4, "硬座车厢人数"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧车厢数", System.Data.SqlDbType.Int, 4, "硬卧车厢数"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧车厢人数", System.Data.SqlDbType.Int, 4, "硬卧车厢人数"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧车厢数", System.Data.SqlDbType.Int, 4, "软卧车厢数"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧车厢人数", System.Data.SqlDbType.Int, 4, "软卧车厢人数"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车次", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车次", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet_chaxun1
			// 
			this.dataSet_chaxun1.DataSetName = "DataSet_chaxun1";
			this.dataSet_chaxun1.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_chaxun1)).EndInit();

		}
		#endregion
       
		private void Button1_Click(object sender, System.EventArgs e)
		{
			this.dataSet_chaxun1.Clear();
			this.TextBox_checi.Text="";
			this.TextBox_qsz.Text="";
			this.TextBox_zdz.Text="";
			this.DataGrid1.Visible=false;
		}

          

		private void Button3_Click(object sender, System.EventArgs e)
		{
			
			if(this.TextBox_qsz.Text.Trim() !="" && this.TextBox_zdz.Text.Trim() !="")
				type="zh";
			else if(this.TextBox_qsz.Text.Trim() !="")
				type="sfz";
			else if(this.TextBox_zdz.Text.Trim() !="")
				type="zdz";
			if(type!=null)
			{
				this.displayccxx(type);
			}
			else
				Global.Alert(this,"请输入查询条件！");
		}
	
          
		private void displayccxx(string type)
		{  
			
			this.dataSet_chaxun1.Clear();

			sql="SELECT  * FROM tickets ";
			switch(type)
			{
				case "cc":
				{ sql+="where 车次='"+this.TextBox_checi.Text.Trim()+"'";
					this.sqlDataAdapter_tickets.SelectCommand.CommandText=sql;

					if(this.sqlConnection1.State.ToString()=="Closed")
						this.sqlConnection1.Open();

					this.sqlDataAdapter_tickets.Fill(this.dataSet_chaxun1);
					if(this.dataSet_chaxun1.Tables[0].Rows.Count>0)
					{
						this.DataGrid1.Visible=true;
						this.DataGrid1.DataBind();
					}
					else
					{
						Global.Alert(this,"没有相关记录!");   
			

					}
					break;
				}
				case "sfz" :
				{
				
					
			  
						dschaxun=new DataSet();
			 
               
						this.begin=this.TextBox_qsz.Text.Trim();
					
			
		

						sql="select  车次  from ticketsinf  ";
						sql+=" where 出发站='"+this.TextBox_qsz.Text.Trim()+"'";

						if(this.sqlConnection1.State.ToString()=="Closed")
							this.sqlConnection1.Open();

						this.sqlDataAdapter_ticketsinf.SelectCommand.CommandText=sql;
						this.sqlDataAdapter_ticketsinf.Fill(this.dschaxun);

		
 
						

						int count = this.dschaxun.Tables[0].Rows.Count;
					    sql="select * from tickets where 车次='"+this.dschaxun.Tables[0].Rows[0][0].ToString().Trim()+"'";
					for(int i=1;i<count;i++)
					
					 {  sql+=" OR 车次='"+this.dschaxun.Tables[0].Rows[i][0].ToString().Trim()+"'";
					     
					  }
						
						this.sqlDataAdapter_tickets.SelectCommand.CommandText=sql;
			
						this.sqlDataAdapter_tickets.Fill(this.dataSet_chaxun1) ; 
						
						
						this.DataGrid1.Visible=true;
						this.DataGrid1.DataBind();
						
             
					
					break;
				}
				case "zdz":
				{
					dschaxun=new DataSet();
			 
               
					this.end=this.TextBox_zdz.Text.Trim();
					
			
		

					sql="select  车次  from ticketsinf  ";
					sql+=" where 到达站='"+this.TextBox_zdz.Text.Trim()+"'";

					if(this.sqlConnection1.State.ToString()=="Closed")
						this.sqlConnection1.Open();

					this.sqlDataAdapter_ticketsinf.SelectCommand.CommandText=sql;
					this.sqlDataAdapter_ticketsinf.Fill(this.dschaxun);

		
 
						

					int count = this.dschaxun.Tables[0].Rows.Count;
					sql="select * from tickets where 车次='"+this.dschaxun.Tables[0].Rows[0][0].ToString().Trim()+"'";
					for(int i=1;i<count;i++)
					
					{
							sql+=" OR 车次='"+this.dschaxun.Tables[0].Rows[i][0].ToString().Trim()+"'";
					     
					}
						
					this.sqlDataAdapter_tickets.SelectCommand.CommandText=sql;
			
					this.sqlDataAdapter_tickets.Fill(this.dataSet_chaxun1) ; 
						
						
					this.DataGrid1.Visible=true;
					this.DataGrid1.DataBind();
						
             
					break;
				}
				case "zh":
				{  
					int leiji1=0;
					int leiji2=0;
				    int  k=0;

					dschaxun=new DataSet();
			        this.begin=this.TextBox_qsz.Text.Trim();
               		this.end=this.TextBox_zdz.Text.Trim();
					
		

					sql="select  车次 ,出发站,到达站  from ticketsinf  ";
					

					if(this.sqlConnection1.State.ToString()=="Closed")
						this.sqlConnection1.Open();

					this.sqlDataAdapter_ticketsinf.SelectCommand.CommandText=sql;
					this.sqlDataAdapter_ticketsinf.Fill(this.dschaxun);

		
 
						

					int count = this.dschaxun.Tables[0].Rows.Count;


					
					for(int i=0;i<count;i++)
					{
						if(this.begin==this.dschaxun.Tables[0].Rows[i][1].ToString())
						{
								leiji1=1;
							this.lscc=this.dschaxun.Tables[0].Rows[i][0].ToString();
						}

						if(this.end==this.dschaxun.Tables[0].Rows[i][2].ToString()&&this.dschaxun.Tables[0].Rows[i][0].ToString()==lscc)
							leiji2=1;
						
						if(leiji1==1&&leiji2==1)
						{
								sql="select * from tickets where 车次='"+this.dschaxun.Tables[0].Rows[i][0].ToString().Trim()+"'";
							     k=i; 
							    leiji1=0;
							    leiji2=0;
							    goto next;
                                 
						}
					  
					}
				  
					next:   	
						for(int i=k+1;i<count;i++)
						{
							if(this.begin==this.dschaxun.Tables[0].Rows[i][1].ToString())
							{
								leiji1=1;
								this.lscc=this.dschaxun.Tables[0].Rows[i][0].ToString();
							}

							if(this.end==this.dschaxun.Tables[0].Rows[i][2].ToString()&&this.dschaxun.Tables[0].Rows[i][0].ToString()==lscc)
								leiji2=1;
						
							
							if(leiji1==1&&leiji2==1)
							{
								sql+=" OR 车次='"+this.dschaxun.Tables[0].Rows[i][0].ToString().Trim()+"'";
								leiji1=0;
								leiji2=0;
							}
					
						}
					this.sqlDataAdapter_tickets.SelectCommand.CommandText=sql;
			
					this.sqlDataAdapter_tickets.Fill(this.dataSet_chaxun1) ; 
									
					this.DataGrid1.Visible=true;
					this.DataGrid1.DataBind();
				
					break;
				}
			}

		}
		private void Button_chaxun1_Click(object sender, System.EventArgs e)
		{
			if(this.TextBox_checi.Text.Trim()!="")
			{
				type="cc";
				this.displayccxx(type);
			}
			else
			{
				Global.Alert(this,"请输入查询车次！");
			}
		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			displayccxx(type);
			this.sqlDataAdapter_tickets.Fill(this.dschaxun);
			this.DataGrid1.CurrentPageIndex=e.NewPageIndex;
			this.DataGrid1.DataBind();
		}

		private void DataGrid1_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			if(e.CommandName=="Select")
			{
				string  flag=this.DataGrid1.DataKeys[e.Item.ItemIndex].ToString();
				Response.Redirect("maipiao.aspx?flag="+flag);
			}
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
