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
	/// tongji2 的摘要说明。
	/// </summary>
	public class tongji2 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_dp;
		protected tickets.DataSet_dp dataSet_dp;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection1.ConnectionString=data.connStr;
			// 在此处放置用户代码以初始化页面
			string qssj1=Request.QueryString["qssj"];
			string zzsj1=Request.QueryString["zzsj"];
			this.xianshijieguo(qssj1,zzsj1);
		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
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
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlDataAdapter_dp = new System.Data.SqlClient.SqlDataAdapter();
			this.dataSet_dp = new tickets.DataSet_dp();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_dp)).BeginInit();
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 序号, 车次, 出发站, 到达站, 座位类型, 票数, 总价格, 用户名, 联系方式, 地址, 身份证, 发车日期, 时间, 车厢号, 座位号, 车" +
				"辆类型, 售票日期, 售票点编号 FROM dingpiao";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO dingpiao(车次, 出发站, 到达站, 座位类型, 票数, 总价格, 用户名, 联系方式, 地址, 身份证, 发车日期, 时间, 车厢号, 座位号, 车辆类型, 售票日期, 售票点编号) VALUES (@车次, @出发站, @到达站, @座位类型, @票数, @总价格, @用户名, @联系方式, @地址, @身份证, @发车日期, @时间, @车厢号, @座位号, @车辆类型, @售票日期, @售票点编号); SELECT 序号, 车次, 出发站, 到达站, 座位类型, 票数, 总价格, 用户名, 联系方式, 地址, 身份证, 发车日期, 时间, 车厢号, 座位号, 车辆类型, 售票日期, 售票点编号 FROM dingpiao WHERE (序号 = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
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
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@发车日期", System.Data.SqlDbType.DateTime, 8, "发车日期"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@时间", System.Data.SqlDbType.DateTime, 8, "时间"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车厢号", System.Data.SqlDbType.Int, 4, "车厢号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@座位号", System.Data.SqlDbType.Int, 4, "座位号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车辆类型", System.Data.SqlDbType.VarChar, 10, "车辆类型"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@售票日期", System.Data.SqlDbType.DateTime, 8, "售票日期"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@售票点编号", System.Data.SqlDbType.VarChar, 10, "售票点编号"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE dingpiao SET 车次 = @车次, 出发站 = @出发站, 到达站 = @到达站, 座位类型 = @座位类型, 票数 = @票数, 总价格" +
				" = @总价格, 用户名 = @用户名, 联系方式 = @联系方式, 地址 = @地址, 身份证 = @身份证, 发车日期 = @发车日期, 时间 = @时间," +
				" 车厢号 = @车厢号, 座位号 = @座位号, 车辆类型 = @车辆类型, 售票日期 = @售票日期, 售票点编号 = @售票点编号 WHERE (序号 = " +
				"@Original_序号) AND (出发站 = @Original_出发站 OR @Original_出发站 IS NULL AND 出发站 IS NULL)" +
				" AND (到达站 = @Original_到达站 OR @Original_到达站 IS NULL AND 到达站 IS NULL) AND (发车日期 = " +
				"@Original_发车日期 OR @Original_发车日期 IS NULL AND 发车日期 IS NULL) AND (售票日期 = @Original" +
				"_售票日期 OR @Original_售票日期 IS NULL AND 售票日期 IS NULL) AND (售票点编号 = @Original_售票点编号 O" +
				"R @Original_售票点编号 IS NULL AND 售票点编号 IS NULL) AND (地址 = @Original_地址 OR @Original" +
				"_地址 IS NULL AND 地址 IS NULL) AND (座位号 = @Original_座位号 OR @Original_座位号 IS NULL AN" +
				"D 座位号 IS NULL) AND (座位类型 = @Original_座位类型 OR @Original_座位类型 IS NULL AND 座位类型 IS " +
				"NULL) AND (总价格 = @Original_总价格 OR @Original_总价格 IS NULL AND 总价格 IS NULL) AND (时间" +
				" = @Original_时间 OR @Original_时间 IS NULL AND 时间 IS NULL) AND (用户名 = @Original_用户名" +
				" OR @Original_用户名 IS NULL AND 用户名 IS NULL) AND (票数 = @Original_票数 OR @Original_票" +
				"数 IS NULL AND 票数 IS NULL) AND (联系方式 = @Original_联系方式 OR @Original_联系方式 IS NULL A" +
				"ND 联系方式 IS NULL) AND (身份证 = @Original_身份证 OR @Original_身份证 IS NULL AND 身份证 IS NU" +
				"LL) AND (车厢号 = @Original_车厢号 OR @Original_车厢号 IS NULL AND 车厢号 IS NULL) AND (车次 =" +
				" @Original_车次 OR @Original_车次 IS NULL AND 车次 IS NULL) AND (车辆类型 = @Original_车辆类型" +
				" OR @Original_车辆类型 IS NULL AND 车辆类型 IS NULL); SELECT 序号, 车次, 出发站, 到达站, 座位类型, 票数," +
				" 总价格, 用户名, 联系方式, 地址, 身份证, 发车日期, 时间, 车厢号, 座位号, 车辆类型, 售票日期, 售票点编号 FROM dingpiao WH" +
				"ERE (序号 = @序号)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
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
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@发车日期", System.Data.SqlDbType.DateTime, 8, "发车日期"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@时间", System.Data.SqlDbType.DateTime, 8, "时间"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车厢号", System.Data.SqlDbType.Int, 4, "车厢号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@座位号", System.Data.SqlDbType.Int, 4, "座位号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车辆类型", System.Data.SqlDbType.VarChar, 10, "车辆类型"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@售票日期", System.Data.SqlDbType.DateTime, 8, "售票日期"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@售票点编号", System.Data.SqlDbType.VarChar, 10, "售票点编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_出发站", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "出发站", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_到达站", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "到达站", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_发车日期", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "发车日期", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_售票日期", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "售票日期", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_售票点编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "售票点编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_地址", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "地址", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_座位号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "座位号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_座位类型", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "座位类型", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_总价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "总价格", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "时间", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户名", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户名", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_票数", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "票数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系方式", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系方式", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_身份证", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "身份证", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车厢号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车厢号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车次", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车次", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车辆类型", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车辆类型", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@序号", System.Data.SqlDbType.Int, 4, "序号"));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM dingpiao WHERE (序号 = @Original_序号) AND (出发站 = @Original_出发站 OR @Original_出发站 IS NULL AND 出发站 IS NULL) AND (到达站 = @Original_到达站 OR @Original_到达站 IS NULL AND 到达站 IS NULL) AND (发车日期 = @Original_发车日期 OR @Original_发车日期 IS NULL AND 发车日期 IS NULL) AND (售票日期 = @Original_售票日期 OR @Original_售票日期 IS NULL AND 售票日期 IS NULL) AND (售票点编号 = @Original_售票点编号 OR @Original_售票点编号 IS NULL AND 售票点编号 IS NULL) AND (地址 = @Original_地址 OR @Original_地址 IS NULL AND 地址 IS NULL) AND (座位号 = @Original_座位号 OR @Original_座位号 IS NULL AND 座位号 IS NULL) AND (座位类型 = @Original_座位类型 OR @Original_座位类型 IS NULL AND 座位类型 IS NULL) AND (总价格 = @Original_总价格 OR @Original_总价格 IS NULL AND 总价格 IS NULL) AND (时间 = @Original_时间 OR @Original_时间 IS NULL AND 时间 IS NULL) AND (用户名 = @Original_用户名 OR @Original_用户名 IS NULL AND 用户名 IS NULL) AND (票数 = @Original_票数 OR @Original_票数 IS NULL AND 票数 IS NULL) AND (联系方式 = @Original_联系方式 OR @Original_联系方式 IS NULL AND 联系方式 IS NULL) AND (身份证 = @Original_身份证 OR @Original_身份证 IS NULL AND 身份证 IS NULL) AND (车厢号 = @Original_车厢号 OR @Original_车厢号 IS NULL AND 车厢号 IS NULL) AND (车次 = @Original_车次 OR @Original_车次 IS NULL AND 车次 IS NULL) AND (车辆类型 = @Original_车辆类型 OR @Original_车辆类型 IS NULL AND 车辆类型 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_出发站", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "出发站", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_到达站", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "到达站", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_发车日期", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "发车日期", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_售票日期", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "售票日期", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_售票点编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "售票点编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_地址", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "地址", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_座位号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "座位号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_座位类型", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "座位类型", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_总价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "总价格", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "时间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户名", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户名", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_票数", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "票数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系方式", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系方式", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_身份证", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "身份证", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车厢号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车厢号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车次", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车次", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车辆类型", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车辆类型", System.Data.DataRowVersion.Original, null));
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlDataAdapter_dp
			// 
			this.sqlDataAdapter_dp.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_dp.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter_dp.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter_dp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
																																																					new System.Data.Common.DataColumnMapping("身份证", "身份证"),
																																																					new System.Data.Common.DataColumnMapping("发车日期", "发车日期"),
																																																					new System.Data.Common.DataColumnMapping("时间", "时间"),
																																																					new System.Data.Common.DataColumnMapping("车厢号", "车厢号"),
																																																					new System.Data.Common.DataColumnMapping("座位号", "座位号"),
																																																					new System.Data.Common.DataColumnMapping("车辆类型", "车辆类型"),
																																																					new System.Data.Common.DataColumnMapping("售票日期", "售票日期"),
																																																					new System.Data.Common.DataColumnMapping("售票点编号", "售票点编号")})});
			this.sqlDataAdapter_dp.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// dataSet_dp
			// 
			this.dataSet_dp.DataSetName = "DataSet_dp";
			this.dataSet_dp.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_dp)).EndInit();

		}
		#endregion


		private void xianshijieguo(string qssj,string zzsj)
		{
			this.sqlDataAdapter_dp.SelectCommand.CommandText="select 售票点编号,  sum(票数)总票数 ,sum(总价格)总价格 from dingpiao where 售票日期 between'"+qssj+"'and '"+zzsj+"'group by 售票点编号";
			if(this.sqlConnection1.State.ToString()=="closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_dp.Fill(this.dataSet_dp);
			this.DataGrid1.DataBind();
			this.DataGrid1.Visible=true;
				
		
		}
	}
}
