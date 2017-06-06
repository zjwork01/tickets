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
	/// dingpiaopiaoju 的摘要说明。
	/// </summary>
	public class dingpiaopiaoju : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox TextBox_cc;
		protected System.Web.UI.WebControls.TextBox TextBox_qsz;
		protected System.Web.UI.WebControls.TextBox TextBox_zdz;
		protected System.Web.UI.WebControls.TextBox TextBox_kcsj;
		protected System.Web.UI.WebControls.TextBox TextBox_zwlx;
		protected System.Web.UI.WebControls.TextBox TextBox_ps;
		protected System.Web.UI.WebControls.TextBox TextBox_jg;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		protected tickets.DataSet_dsdmc dataSet_dsdmc;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_dpxd;
		protected tickets.DataSet_dpxd dataSet_dpxd;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Web.UI.WebControls.Label Label_dprq;
		protected System.Web.UI.WebControls.TextBox TextBox_xsp;
		protected System.Web.UI.WebControls.TextBox TextBox_yhm;
		protected System.Web.UI.WebControls.TextBox TextBox_dh;
		protected System.Web.UI.WebControls.TextBox TextBox_dz;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.Label Label_dsdmc;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection1.ConnectionString=data.connStr;
			// 在此处放置用户代码以初始化页面
			string cc=Request.QueryString["checi"];
            this.TextBox_cc.Text=cc;
		

			this.dsdmc();
          
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
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dataSet_dsdmc = new tickets.DataSet_dsdmc();
			this.sqlDataAdapter_dpxd = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.dataSet_dpxd = new tickets.DataSet_dpxd();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_dsdmc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_dpxd)).BeginInit();
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "user", new System.Data.Common.DataColumnMapping[] {
																																																			  new System.Data.Common.DataColumnMapping("序号", "序号"),
																																																			  new System.Data.Common.DataColumnMapping("用户名", "用户名"),
																																																			  new System.Data.Common.DataColumnMapping("密码", "密码"),
																																																			  new System.Data.Common.DataColumnMapping("联系方式", "联系方式"),
																																																			  new System.Data.Common.DataColumnMapping("负责人", "负责人"),
																																																			  new System.Data.Common.DataColumnMapping("单位全称", "单位全称"),
																																																			  new System.Data.Common.DataColumnMapping("具体地址", "具体地址"),
																																																			  new System.Data.Common.DataColumnMapping("身份证", "身份证"),
																																																			  new System.Data.Common.DataColumnMapping("代售点编号", "代售点编号"),
																																																			  new System.Data.Common.DataColumnMapping("用户类型", "用户类型")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 序号, 用户名, 密码, 联系方式, 负责人, 单位全称, 具体地址, 身份证, 代售点编号, 用户类型 FROM [user]";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// dataSet_dsdmc
			// 
			this.dataSet_dsdmc.DataSetName = "DataSet_dsdmc";
			this.dataSet_dsdmc.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlDataAdapter_dpxd
			// 
			this.sqlDataAdapter_dpxd.SelectCommand = this.sqlSelectCommand2;
			this.sqlDataAdapter_dpxd.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
																																																					  new System.Data.Common.DataColumnMapping("售票点编号", "售票点编号"),
																																																					  new System.Data.Common.DataColumnMapping("是否学生票", "是否学生票")})});
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT 序号, 车次, 出发站, 到达站, 座位类型, 票数, 总价格, 用户名, 联系方式, 地址, 身份证, 发车日期, 时间, 车厢号, 座位号, 车" +
				"辆类型, 售票日期, 售票点编号, 是否学生票 FROM dingpiao";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			// 
			// dataSet_dpxd
			// 
			this.dataSet_dpxd.DataSetName = "DataSet_dpxd";
			this.dataSet_dpxd.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_dsdmc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_dpxd)).EndInit();

		}
		#endregion
		private void dsdmc()
		{   this.sqlDataAdapter_dpxd.SelectCommand.CommandText="select * from dingpiao ";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_dpxd.Fill(this.dataSet_dpxd);
			int dpxxs=this.dataSet_dpxd.Tables[0].Rows.Count-1;

			
			this.TextBox_jg.Text=this.dataSet_dpxd.Tables[0].Rows[dpxxs][6].ToString().Trim();
			this.TextBox_ps.Text=this.dataSet_dpxd.Tables[0].Rows[dpxxs][5].ToString().Trim();
			this.TextBox_qsz.Text=this.dataSet_dpxd.Tables[0].Rows[dpxxs][2].ToString().Trim();
			this.TextBox_zdz.Text=this.dataSet_dpxd.Tables[0].Rows[dpxxs][3].ToString().Trim();
			this.TextBox_zwlx.Text=this.dataSet_dpxd.Tables[0].Rows[dpxxs][4].ToString().Trim();
			this.TextBox_kcsj.Text=this.dataSet_dpxd.Tables[0].Rows[dpxxs][11].ToString().Trim();
            this.TextBox_xsp.Text=this.dataSet_dpxd.Tables[0].Rows[dpxxs][18].ToString().Trim();
			DateTime dprq=DateTime.Parse(this.dataSet_dpxd.Tables[0].Rows[dpxxs][16].ToString().Trim());
			this.Label_dprq.Text=dprq.Year.ToString()+"/"+dprq.Month.ToString()+"/"+dprq.Day.ToString();
			this.TextBox_yhm.Text=this.dataSet_dpxd.Tables[0].Rows[dpxxs][7].ToString().Trim();
			this.TextBox_dh.Text=this.dataSet_dpxd.Tables[0].Rows[dpxxs][8].ToString().Trim();
			this.TextBox_dz.Text=this.dataSet_dpxd.Tables[0].Rows[dpxxs][9].ToString().Trim();
			
			this.sqlDataAdapter1.SelectCommand.CommandText="select * from [user] where 用户名='"+Session["username"]+"'";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter1.Fill(this.dataSet_dsdmc);
			this.Label_dsdmc.Text=this.dataSet_dsdmc.Tables[0].Rows[0][8].ToString().Trim();
		}

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
		this.RegisterStartupScript("订票详单","<script  language='javascript'> print();</script>");
		}
	}
}
