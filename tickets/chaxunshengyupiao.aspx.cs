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
	/// chaxunshengyupiao 的摘要说明。
	/// </summary>
	public class chaxunshengyupiao : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button_maipiao;
		protected System.Web.UI.WebControls.Button Button_dingpiao;
		protected System.Web.UI.WebControls.Button Button_tuipiao;
		protected System.Web.UI.WebControls.Button Button_chaxun;
		protected System.Web.UI.WebControls.Button Button_yhgl;
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
		protected System.Web.UI.WebControls.LinkButton LinkButton2;
		protected System.Web.UI.WebControls.LinkButton LinkButton3;
		protected System.Web.UI.WebControls.LinkButton LinkButton4;
		protected System.Web.UI.HtmlControls.HtmlForm Form2;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.Label Label_checi;
		protected System.Web.UI.WebControls.TextBox TextBox_cxcc;
		protected System.Web.UI.WebControls.Button Button_cccx;
		protected System.Web.UI.WebControls.Button Button_cxsy;
		protected System.Web.UI.WebControls.Button Button_cccxsy;
		protected System.Web.UI.WebControls.Button Button_cz;
		protected System.Web.UI.WebControls.Label Label_cxcc;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_tickets;
		protected tickets.DataSet_checi dataSet_checi;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Label Label_LLQ;
		protected System.Web.UI.WebControls.Label Label_IP;
		protected System.Web.UI.WebControls.LinkButton Linkbutton_xwgl;
		protected System.Web.UI.WebControls.LinkButton Linkbutton_xxfk;
	    private string sql;

		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection1.ConnectionString=data.connStr;
			// 在此处放置用户代码以初始化页面
			if(Session["username"].ToString()=="admin")
				this.Button_yhgl.Visible=true;
			else  this.Button_yhgl.Visible=false;
		     
	
			this.DataGrid1.Visible=false;

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
			this.sqlDataAdapter_tickets = new System.Data.SqlClient.SqlDataAdapter();
			this.dataSet_checi = new tickets.DataSet_checi();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_checi)).BeginInit();
			this.Button_maipiao.Click += new System.EventHandler(this.Button_maipiao_Click);
			this.Button_dingpiao.Click += new System.EventHandler(this.Button_dingpiao_Click);
			this.Button_tuipiao.Click += new System.EventHandler(this.Button_tuipiao_Click);
			this.Button_chaxun.Click += new System.EventHandler(this.Button_chaxun_Click);
			this.Button_yhgl.Click += new System.EventHandler(this.Button_yhgl_Click);
			this.LinkButton1.Click += new System.EventHandler(this.LinkButton1_Click);
			this.LinkButton2.Click += new System.EventHandler(this.LinkButton2_Click);
			this.LinkButton3.Click += new System.EventHandler(this.LinkButton3_Click);
			this.Linkbutton_xwgl.Click += new System.EventHandler(this.Linkbutton_xwgl_Click);
			this.Linkbutton_xxfk.Click += new System.EventHandler(this.Linkbutton_xxfk_Click);
			this.LinkButton4.Click += new System.EventHandler(this.LinkButton4_Click);
			this.Button_cccx.Click += new System.EventHandler(this.Button_cccx_Click);
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			this.Button_cxsy.Click += new System.EventHandler(this.Button_cxsy_Click);
			this.Button_cccxsy.Click += new System.EventHandler(this.Button_cccxsy_Click);
			this.Button_cz.Click += new System.EventHandler(this.Button_cz_Click);
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 序号, 车次, 始发站, 终点站, 开车时间, 到达时间, 硬座票数, 硬卧上票数, 硬卧中票数, 硬卧下票数, 软卧上票数, 软卧中票数, 软卧下" +
				"票数, 有无空调, 车辆类型, 硬座车厢数, 硬座车厢人数, 硬卧车厢数, 硬卧车厢人数, 软卧车厢数, 软卧车厢人数 FROM tickets";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO tickets(车次, 始发站, 终点站, 开车时间, 到达时间, 硬座票数, 硬卧上票数, 硬卧中票数, 硬卧下票数, 软卧上票数, 软卧中票数, 软卧下票数, 有无空调, 车辆类型, 硬座车厢数, 硬座车厢人数, 硬卧车厢数, 硬卧车厢人数, 软卧车厢数, 软卧车厢人数) VALUES (@车次, @始发站, @终点站, @开车时间, @到达时间, @硬座票数, @硬卧上票数, @硬卧中票数, @硬卧下票数, @软卧上票数, @软卧中票数, @软卧下票数, @有无空调, @车辆类型, @硬座车厢数, @硬座车厢人数, @硬卧车厢数, @硬卧车厢人数, @软卧车厢数, @软卧车厢人数); SELECT 序号, 车次, 始发站, 终点站, 开车时间, 到达时间, 硬座票数, 硬卧上票数, 硬卧中票数, 硬卧下票数, 软卧上票数, 软卧中票数, 软卧下票数, 有无空调, 车辆类型, 硬座车厢数, 硬座车厢人数, 硬卧车厢数, 硬卧车厢人数, 软卧车厢数, 软卧车厢人数 FROM tickets WHERE (车次 = @车次)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车次", System.Data.SqlDbType.VarChar, 10, "车次"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@始发站", System.Data.SqlDbType.VarChar, 10, "始发站"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@终点站", System.Data.SqlDbType.VarChar, 10, "终点站"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@开车时间", System.Data.SqlDbType.DateTime, 8, "开车时间"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达时间", System.Data.SqlDbType.DateTime, 8, "到达时间"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座票数", System.Data.SqlDbType.Int, 4, "硬座票数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧上票数", System.Data.SqlDbType.Int, 4, "硬卧上票数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧中票数", System.Data.SqlDbType.Int, 4, "硬卧中票数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧下票数", System.Data.SqlDbType.Int, 4, "硬卧下票数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧上票数", System.Data.SqlDbType.Int, 4, "软卧上票数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧中票数", System.Data.SqlDbType.Int, 4, "软卧中票数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧下票数", System.Data.SqlDbType.Int, 4, "软卧下票数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@有无空调", System.Data.SqlDbType.VarChar, 10, "有无空调"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车辆类型", System.Data.SqlDbType.VarChar, 10, "车辆类型"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座车厢数", System.Data.SqlDbType.Int, 4, "硬座车厢数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座车厢人数", System.Data.SqlDbType.Int, 4, "硬座车厢人数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧车厢数", System.Data.SqlDbType.Int, 4, "硬卧车厢数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧车厢人数", System.Data.SqlDbType.Int, 4, "硬卧车厢人数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧车厢数", System.Data.SqlDbType.Int, 4, "软卧车厢数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧车厢人数", System.Data.SqlDbType.Int, 4, "软卧车厢人数"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE tickets SET 车次 = @车次, 始发站 = @始发站, 终点站 = @终点站, 开车时间 = @开车时间, 到达时间 = @到达时间, " +
				"硬座票数 = @硬座票数, 硬卧上票数 = @硬卧上票数, 硬卧中票数 = @硬卧中票数, 硬卧下票数 = @硬卧下票数, 软卧上票数 = @软卧上票数, 软卧" +
				"中票数 = @软卧中票数, 软卧下票数 = @软卧下票数, 有无空调 = @有无空调, 车辆类型 = @车辆类型, 硬座车厢数 = @硬座车厢数, 硬座车厢人数" +
				" = @硬座车厢人数, 硬卧车厢数 = @硬卧车厢数, 硬卧车厢人数 = @硬卧车厢人数, 软卧车厢数 = @软卧车厢数, 软卧车厢人数 = @软卧车厢人数 W" +
				"HERE (车次 = @Original_车次) AND (到达时间 = @Original_到达时间 OR @Original_到达时间 IS NULL AN" +
				"D 到达时间 IS NULL) AND (始发站 = @Original_始发站 OR @Original_始发站 IS NULL AND 始发站 IS NUL" +
				"L) AND (开车时间 = @Original_开车时间 OR @Original_开车时间 IS NULL AND 开车时间 IS NULL) AND (有" +
				"无空调 = @Original_有无空调 OR @Original_有无空调 IS NULL AND 有无空调 IS NULL) AND (硬卧上票数 = @O" +
				"riginal_硬卧上票数 OR @Original_硬卧上票数 IS NULL AND 硬卧上票数 IS NULL) AND (硬卧下票数 = @Origin" +
				"al_硬卧下票数 OR @Original_硬卧下票数 IS NULL AND 硬卧下票数 IS NULL) AND (硬卧中票数 = @Original_硬卧" +
				"中票数 OR @Original_硬卧中票数 IS NULL AND 硬卧中票数 IS NULL) AND (硬卧车厢人数 = @Original_硬卧车厢人数" +
				" OR @Original_硬卧车厢人数 IS NULL AND 硬卧车厢人数 IS NULL) AND (硬卧车厢数 = @Original_硬卧车厢数 OR" +
				" @Original_硬卧车厢数 IS NULL AND 硬卧车厢数 IS NULL) AND (硬座票数 = @Original_硬座票数 OR @Origi" +
				"nal_硬座票数 IS NULL AND 硬座票数 IS NULL) AND (硬座车厢人数 = @Original_硬座车厢人数 OR @Original_硬" +
				"座车厢人数 IS NULL AND 硬座车厢人数 IS NULL) AND (硬座车厢数 = @Original_硬座车厢数 OR @Original_硬座车厢" +
				"数 IS NULL AND 硬座车厢数 IS NULL) AND (终点站 = @Original_终点站 OR @Original_终点站 IS NULL A" +
				"ND 终点站 IS NULL) AND (车辆类型 = @Original_车辆类型 OR @Original_车辆类型 IS NULL AND 车辆类型 IS" +
				" NULL) AND (软卧上票数 = @Original_软卧上票数 OR @Original_软卧上票数 IS NULL AND 软卧上票数 IS NULL" +
				") AND (软卧下票数 = @Original_软卧下票数 OR @Original_软卧下票数 IS NULL AND 软卧下票数 IS NULL) AND" +
				" (软卧中票数 = @Original_软卧中票数 OR @Original_软卧中票数 IS NULL AND 软卧中票数 IS NULL) AND (软卧车" +
				"厢人数 = @Original_软卧车厢人数 OR @Original_软卧车厢人数 IS NULL AND 软卧车厢人数 IS NULL) AND (软卧车厢" +
				"数 = @Original_软卧车厢数 OR @Original_软卧车厢数 IS NULL AND 软卧车厢数 IS NULL); SELECT 序号, 车次" +
				", 始发站, 终点站, 开车时间, 到达时间, 硬座票数, 硬卧上票数, 硬卧中票数, 硬卧下票数, 软卧上票数, 软卧中票数, 软卧下票数, 有无空调, 车辆" +
				"类型, 硬座车厢数, 硬座车厢人数, 硬卧车厢数, 硬卧车厢人数, 软卧车厢数, 软卧车厢人数 FROM tickets WHERE (车次 = @车次)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车次", System.Data.SqlDbType.VarChar, 10, "车次"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@始发站", System.Data.SqlDbType.VarChar, 10, "始发站"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@终点站", System.Data.SqlDbType.VarChar, 10, "终点站"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@开车时间", System.Data.SqlDbType.DateTime, 8, "开车时间"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达时间", System.Data.SqlDbType.DateTime, 8, "到达时间"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座票数", System.Data.SqlDbType.Int, 4, "硬座票数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧上票数", System.Data.SqlDbType.Int, 4, "硬卧上票数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧中票数", System.Data.SqlDbType.Int, 4, "硬卧中票数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧下票数", System.Data.SqlDbType.Int, 4, "硬卧下票数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧上票数", System.Data.SqlDbType.Int, 4, "软卧上票数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧中票数", System.Data.SqlDbType.Int, 4, "软卧中票数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧下票数", System.Data.SqlDbType.Int, 4, "软卧下票数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@有无空调", System.Data.SqlDbType.VarChar, 10, "有无空调"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车辆类型", System.Data.SqlDbType.VarChar, 10, "车辆类型"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座车厢数", System.Data.SqlDbType.Int, 4, "硬座车厢数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座车厢人数", System.Data.SqlDbType.Int, 4, "硬座车厢人数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧车厢数", System.Data.SqlDbType.Int, 4, "硬卧车厢数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧车厢人数", System.Data.SqlDbType.Int, 4, "硬卧车厢人数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧车厢数", System.Data.SqlDbType.Int, 4, "软卧车厢数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧车厢人数", System.Data.SqlDbType.Int, 4, "软卧车厢人数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车次", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车次", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_到达时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "到达时间", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_始发站", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "始发站", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_开车时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "开车时间", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_有无空调", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "有无空调", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬卧上票数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬卧上票数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬卧下票数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬卧下票数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬卧中票数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬卧中票数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬卧车厢人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬卧车厢人数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬卧车厢数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬卧车厢数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬座票数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬座票数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬座车厢人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬座车厢人数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬座车厢数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬座车厢数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_终点站", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "终点站", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车辆类型", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车辆类型", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_软卧上票数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "软卧上票数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_软卧下票数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "软卧下票数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_软卧中票数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "软卧中票数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_软卧车厢人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "软卧车厢人数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_软卧车厢数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "软卧车厢数", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM tickets WHERE (车次 = @Original_车次) AND (到达时间 = @Original_到达时间 OR @Original_到达时间 IS NULL AND 到达时间 IS NULL) AND (始发站 = @Original_始发站 OR @Original_始发站 IS NULL AND 始发站 IS NULL) AND (序号 = @Original_序号) AND (开车时间 = @Original_开车时间 OR @Original_开车时间 IS NULL AND 开车时间 IS NULL) AND (有无空调 = @Original_有无空调 OR @Original_有无空调 IS NULL AND 有无空调 IS NULL) AND (硬卧上票数 = @Original_硬卧上票数 OR @Original_硬卧上票数 IS NULL AND 硬卧上票数 IS NULL) AND (硬卧下票数 = @Original_硬卧下票数 OR @Original_硬卧下票数 IS NULL AND 硬卧下票数 IS NULL) AND (硬卧中票数 = @Original_硬卧中票数 OR @Original_硬卧中票数 IS NULL AND 硬卧中票数 IS NULL) AND (硬卧车厢人数 = @Original_硬卧车厢人数 OR @Original_硬卧车厢人数 IS NULL AND 硬卧车厢人数 IS NULL) AND (硬卧车厢数 = @Original_硬卧车厢数 OR @Original_硬卧车厢数 IS NULL AND 硬卧车厢数 IS NULL) AND (硬座票数 = @Original_硬座票数 OR @Original_硬座票数 IS NULL AND 硬座票数 IS NULL) AND (硬座车厢人数 = @Original_硬座车厢人数 OR @Original_硬座车厢人数 IS NULL AND 硬座车厢人数 IS NULL) AND (硬座车厢数 = @Original_硬座车厢数 OR @Original_硬座车厢数 IS NULL AND 硬座车厢数 IS NULL) AND (终点站 = @Original_终点站 OR @Original_终点站 IS NULL AND 终点站 IS NULL) AND (车辆类型 = @Original_车辆类型 OR @Original_车辆类型 IS NULL AND 车辆类型 IS NULL) AND (软卧上票数 = @Original_软卧上票数 OR @Original_软卧上票数 IS NULL AND 软卧上票数 IS NULL) AND (软卧下票数 = @Original_软卧下票数 OR @Original_软卧下票数 IS NULL AND 软卧下票数 IS NULL) AND (软卧中票数 = @Original_软卧中票数 OR @Original_软卧中票数 IS NULL AND 软卧中票数 IS NULL) AND (软卧车厢人数 = @Original_软卧车厢人数 OR @Original_软卧车厢人数 IS NULL AND 软卧车厢人数 IS NULL) AND (软卧车厢数 = @Original_软卧车厢数 OR @Original_软卧车厢数 IS NULL AND 软卧车厢数 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车次", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车次", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_到达时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "到达时间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_始发站", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "始发站", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_开车时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "开车时间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_有无空调", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "有无空调", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬卧上票数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬卧上票数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬卧下票数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬卧下票数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬卧中票数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬卧中票数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬卧车厢人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬卧车厢人数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬卧车厢数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬卧车厢数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬座票数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬座票数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬座车厢人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬座车厢人数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_硬座车厢数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "硬座车厢数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_终点站", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "终点站", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车辆类型", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车辆类型", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_软卧上票数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "软卧上票数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_软卧下票数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "软卧下票数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_软卧中票数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "软卧中票数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_软卧车厢人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "软卧车厢人数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_软卧车厢数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "软卧车厢数", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter_tickets
			// 
			this.sqlDataAdapter_tickets.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_tickets.InsertCommand = this.sqlInsertCommand1;
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
			this.sqlDataAdapter_tickets.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// dataSet_checi
			// 
			this.dataSet_checi.DataSetName = "DataSet_checi";
			this.dataSet_checi.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_checi)).EndInit();

		}
		#endregion

		private void Button_cccxsy_Click(object sender, System.EventArgs e)
		{
			
			this.TextBox_cxcc.Enabled=true;
			this.TextBox_cxcc.Text="";
			this.Button_cccx.Enabled=true;
			
		}

		private void Button_cccx_Click(object sender, System.EventArgs e)
		{
			sql="select * from tickets where 车次='"+this.TextBox_cxcc.Text.Trim()+"'";
			this.sqlDataAdapter_tickets.SelectCommand.CommandText=sql;
			if(this.sqlConnection1.State.ToString()=="closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_tickets.Fill(this.dataSet_checi);
			this.DataGrid1.DataBind();
			this.DataGrid1.Visible=true;  
			
		}

		private void Button_cxsy_Click(object sender, System.EventArgs e)
		{   this.TextBox_cxcc.Enabled=false;
			this.Button_cccx.Enabled=false;
			sql="select * from tickets ";
			this.sqlDataAdapter_tickets.SelectCommand.CommandText=sql;
			if(this.sqlConnection1.State.ToString()=="closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_tickets.Fill(this.dataSet_checi);
			this.DataGrid1.DataBind();
			this.DataGrid1.Visible=true;  
			this.Label_checi.Text=this.dataSet_checi.Tables[0].Rows.Count.ToString();
			this.TextBox_cxcc.Visible=true;
		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{   this.sqlDataAdapter_tickets.Fill(this.dataSet_checi);
			this.DataGrid1.CurrentPageIndex=e.NewPageIndex;
			this.DataGrid1.DataBind();
		}

		private void Button_cz_Click(object sender, System.EventArgs e)
		{
			this.TextBox_cxcc.Text="";
			this.DataGrid1.Visible=false;
			this.dataSet_checi.Clear();
			this.TextBox_cxcc.Enabled=false;
			this.Button_cccx.Enabled=false;

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

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("guanliyonghu.aspx");
		}

		private void LinkButton2_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("chaxunshengyupiao.aspx");
		}

		private void LinkButton3_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("gengxincheci.aspx");
		}

		private void LinkButton4_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("shoupiaoqingkuangtongji.aspx");
		}

		private void Linkbutton_xwgl_Click(object sender, System.EventArgs e)
		{
			string canshu="checi=123";
			string msg;
			msg  = "<script language='javascript'>";
			msg +="window.open ('xinwenguanli.aspx?"+canshu+"','新闻','height=500,width=750,top=50,left=50,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')"; 
			msg +="</script>";
			this.RegisterStartupScript("新闻",msg);
		}

		private void Linkbutton_xxfk_Click(object sender, System.EventArgs e)
		{
			string canshu="checi=123";
			string msg;
			msg  = "<script language='javascript'>";
			msg +="window.open ('guanliliuyan.aspx?"+canshu+"','留言','height=500,width=720,top=50,left=50,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')"; 
			msg +="</script>";
			this.RegisterStartupScript("留言",msg);
		}
	}
}
