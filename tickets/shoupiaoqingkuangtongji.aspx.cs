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
	/// shoupiaoqingkuangtongji 的摘要说明。
	/// </summary>
	public class shoupiaoqingkuangtongji : System.Web.UI.Page
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
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.DropDownList Dl_nian;
		protected System.Web.UI.WebControls.DropDownList Dl_yue;
		protected System.Web.UI.WebControls.DropDownList Dl_ri;
		protected System.Web.UI.WebControls.DropDownList Dl_ri1;
		protected System.Web.UI.WebControls.DropDownList Dl_yue1;
		protected System.Web.UI.WebControls.DropDownList Dl_nian1;
		protected System.Web.UI.WebControls.Label qssj;
		protected System.Web.UI.WebControls.Label jzsj;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_dingpiao;
		protected tickets.DataSet_dingpiao dataSet_dingpiao;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Web.UI.WebControls.DropDownList Dl_cxfs;
		protected System.Web.UI.WebControls.DropDownList DropDownList_tjfs;
		protected System.Web.UI.WebControls.TextBox TextBox_checi;
		protected System.Web.UI.WebControls.TextBox TextBox_dsd;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_yonghu;
		protected tickets.DataSet_yonghu dataSet_yonghu;
		protected System.Web.UI.WebControls.Button Button_chx;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		protected System.Web.UI.WebControls.DropDownList Dl_dsdbh;
		protected System.Data.DataSet dataSet_dsd;
		protected System.Web.UI.WebControls.Label dsdbh;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Label Label_LLQ;
		protected System.Web.UI.WebControls.Label Label_IP;
		protected System.Web.UI.WebControls.LinkButton Linkbutton_xwgl;
		protected System.Web.UI.WebControls.LinkButton Linkbutton_xxfk;
		private string bianhao;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection1.ConnectionString=data.connStr;
			// 在此处放置用户代码以初始化页面
			if(Session["username"].ToString()=="admin")
				this.Button_yhgl.Visible=true;
			else  this.Button_yhgl.Visible=false;

			if(!this.IsPostBack)
			{
				
				this.xianshibh();
				this.bianhao=this.Dl_dsdbh.SelectedItem.Text.Trim();
			}
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
			this.sqlDataAdapter_dingpiao = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dataSet_dingpiao = new tickets.DataSet_dingpiao();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_yonghu = new System.Data.SqlClient.SqlDataAdapter();
			this.dataSet_yonghu = new tickets.DataSet_yonghu();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_dingpiao)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_yonghu)).BeginInit();
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
			this.Dl_cxfs.SelectedIndexChanged += new System.EventHandler(this.Dl_cxfs_SelectedIndexChanged);
			this.DropDownList_tjfs.SelectedIndexChanged += new System.EventHandler(this.DropDownList_tjfs_SelectedIndexChanged);
			this.Dl_dsdbh.SelectedIndexChanged += new System.EventHandler(this.Dl_dsdbh_SelectedIndexChanged);
			this.Button_chx.Click += new System.EventHandler(this.Button2_Click);
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlDataAdapter_dingpiao
			// 
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
																																																						  new System.Data.Common.DataColumnMapping("身份证", "身份证"),
																																																						  new System.Data.Common.DataColumnMapping("发车日期", "发车日期"),
																																																						  new System.Data.Common.DataColumnMapping("时间", "时间"),
																																																						  new System.Data.Common.DataColumnMapping("车厢号", "车厢号"),
																																																						  new System.Data.Common.DataColumnMapping("座位号", "座位号"),
																																																						  new System.Data.Common.DataColumnMapping("车辆类型", "车辆类型"),
																																																						  new System.Data.Common.DataColumnMapping("售票日期", "售票日期"),
																																																						  new System.Data.Common.DataColumnMapping("售票点编号", "售票点编号")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 序号, 车次, 出发站, 到达站, 座位类型, 票数, 总价格, 用户名, 联系方式, 地址, 身份证, 发车日期, 时间, 车厢号, 座位号, 车" +
				"辆类型, 售票日期, 售票点编号 FROM dingpiao";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// dataSet_dingpiao
			// 
			this.dataSet_dingpiao.DataSetName = "DataSet_dingpiao";
			this.dataSet_dingpiao.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT 序号, 用户名, 密码, 联系方式, 负责人, 单位全称, 具体地址, 身份证, 代售点编号, 用户类型 FROM [user]";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO [user] (序号, 用户名, 密码, 联系方式, 负责人, 单位全称, 具体地址, 身份证, 代售点编号, 用户类型) VALUES " +
				"(@序号, @用户名, @密码, @联系方式, @负责人, @单位全称, @具体地址, @身份证, @代售点编号, @用户类型); SELECT 序号, 用户名" +
				", 密码, 联系方式, 负责人, 单位全称, 具体地址, 身份证, 代售点编号, 用户类型 FROM [user] WHERE (序号 = @序号)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@序号", System.Data.SqlDbType.Int, 4, "序号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@用户名", System.Data.SqlDbType.VarChar, 10, "用户名"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@密码", System.Data.SqlDbType.VarChar, 10, "密码"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@联系方式", System.Data.SqlDbType.VarChar, 50, "联系方式"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@负责人", System.Data.SqlDbType.VarChar, 10, "负责人"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@单位全称", System.Data.SqlDbType.VarChar, 50, "单位全称"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@具体地址", System.Data.SqlDbType.VarChar, 50, "具体地址"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@身份证", System.Data.SqlDbType.VarChar, 20, "身份证"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@代售点编号", System.Data.SqlDbType.Int, 4, "代售点编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@用户类型", System.Data.SqlDbType.Int, 4, "用户类型"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE [user] SET 序号 = @序号, 用户名 = @用户名, 密码 = @密码, 联系方式 = @联系方式, 负责人 = @负责人, 单位全称 = @单位全称, 具体地址 = @具体地址, 身份证 = @身份证, 代售点编号 = @代售点编号, 用户类型 = @用户类型 WHERE (序号 = @Original_序号) AND (代售点编号 = @Original_代售点编号 OR @Original_代售点编号 IS NULL AND 代售点编号 IS NULL) AND (具体地址 = @Original_具体地址 OR @Original_具体地址 IS NULL AND 具体地址 IS NULL) AND (单位全称 = @Original_单位全称 OR @Original_单位全称 IS NULL AND 单位全称 IS NULL) AND (密码 = @Original_密码 OR @Original_密码 IS NULL AND 密码 IS NULL) AND (用户名 = @Original_用户名 OR @Original_用户名 IS NULL AND 用户名 IS NULL) AND (用户类型 = @Original_用户类型 OR @Original_用户类型 IS NULL AND 用户类型 IS NULL) AND (联系方式 = @Original_联系方式 OR @Original_联系方式 IS NULL AND 联系方式 IS NULL) AND (负责人 = @Original_负责人 OR @Original_负责人 IS NULL AND 负责人 IS NULL) AND (身份证 = @Original_身份证 OR @Original_身份证 IS NULL AND 身份证 IS NULL); SELECT 序号, 用户名, 密码, 联系方式, 负责人, 单位全称, 具体地址, 身份证, 代售点编号, 用户类型 FROM [user] WHERE (序号 = @序号)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@序号", System.Data.SqlDbType.Int, 4, "序号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@用户名", System.Data.SqlDbType.VarChar, 10, "用户名"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@密码", System.Data.SqlDbType.VarChar, 10, "密码"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@联系方式", System.Data.SqlDbType.VarChar, 50, "联系方式"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@负责人", System.Data.SqlDbType.VarChar, 10, "负责人"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@单位全称", System.Data.SqlDbType.VarChar, 50, "单位全称"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@具体地址", System.Data.SqlDbType.VarChar, 50, "具体地址"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@身份证", System.Data.SqlDbType.VarChar, 20, "身份证"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@代售点编号", System.Data.SqlDbType.Int, 4, "代售点编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@用户类型", System.Data.SqlDbType.Int, 4, "用户类型"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_代售点编号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "代售点编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_具体地址", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "具体地址", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_单位全称", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单位全称", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_密码", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "密码", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户名", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户名", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户类型", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户类型", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系方式", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系方式", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_负责人", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "负责人", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_身份证", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "身份证", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM [user] WHERE (序号 = @Original_序号) AND (代售点编号 = @Original_代售点编号 OR @Original_代售点编号 IS NULL AND 代售点编号 IS NULL) AND (具体地址 = @Original_具体地址 OR @Original_具体地址 IS NULL AND 具体地址 IS NULL) AND (单位全称 = @Original_单位全称 OR @Original_单位全称 IS NULL AND 单位全称 IS NULL) AND (密码 = @Original_密码 OR @Original_密码 IS NULL AND 密码 IS NULL) AND (用户名 = @Original_用户名 OR @Original_用户名 IS NULL AND 用户名 IS NULL) AND (用户类型 = @Original_用户类型 OR @Original_用户类型 IS NULL AND 用户类型 IS NULL) AND (联系方式 = @Original_联系方式 OR @Original_联系方式 IS NULL AND 联系方式 IS NULL) AND (负责人 = @Original_负责人 OR @Original_负责人 IS NULL AND 负责人 IS NULL) AND (身份证 = @Original_身份证 OR @Original_身份证 IS NULL AND 身份证 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_代售点编号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "代售点编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_具体地址", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "具体地址", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_单位全称", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单位全称", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_密码", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "密码", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户名", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户名", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户类型", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户类型", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系方式", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系方式", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_负责人", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "负责人", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_身份证", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "身份证", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter_yonghu
			// 
			this.sqlDataAdapter_yonghu.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_yonghu.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter_yonghu.SelectCommand = this.sqlSelectCommand2;
			this.sqlDataAdapter_yonghu.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.sqlDataAdapter_yonghu.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// dataSet_yonghu
			// 
			this.dataSet_yonghu.DataSetName = "DataSet_yonghu";
			this.dataSet_yonghu.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_dingpiao)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_yonghu)).EndInit();

		}
		#endregion

		private void Button_maipiao_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("maipiao.aspx?flag=1");
		}

		private void Button_dingpiao_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("maipiao.aspx?flag=2");
		}

		private void Button_tuipiao_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("tuipiao.aspx");
		}

		private void Button_chaxun_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("chaxun.aspx");
		}

		private void Button_yhgl_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("yonghuguanlizhujiemian.aspx");
		}

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("guanliyonghu.aspx");
		}

		private void LinkButton2_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("chaxunshengyupiao.aspx");
		}

		private void LinkButton3_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("gengxincheci.aspx");
		}

		private void LinkButton4_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("shoupiaoqingkuangtongji.aspx");
		}

		private void Dl_cxfs_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.Dl_cxfs.SelectedItem.Text.Trim()=="按车次")
				this.TextBox_checi.Enabled=true;
			else 
		
				this.TextBox_checi.Enabled=false;



		}
		private void xianshibh()
		{
			dataSet_dsd=new DataSet(); 
			this.sqlDataAdapter_yonghu.SelectCommand.CommandText="select * from [user] ";
			if(this.sqlConnection1.State.ToString()=="closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_yonghu.Fill(this.dataSet_dsd);

				
			this.Dl_dsdbh.DataSource=this.dataSet_dsd;
			this.Dl_dsdbh.DataMember=this.dataSet_dsd.Tables[0].ToString();
			this.Dl_dsdbh.DataTextField=this.dataSet_dsd.Tables[0].Columns[8].ToString();
			this.Dl_dsdbh.DataValueField=this.dataSet_dsd.Tables[0].Columns[5].ToString();
			this.Dl_dsdbh.DataBind();

		}/*
		  * 
		private void DropDownList_dsdbh_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.TextBox_dsd.Text=this.Dl_dsdbh.SelectedItem.Value.ToString().Trim();
			this.TextBox_dsd.Enabled=false;
		}*/

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			this.sqlDataAdapter_dingpiao.Fill(this.dataSet_dingpiao);
			this.DataGrid1.CurrentPageIndex=e.NewPageIndex;
			this.DataGrid1.DataBind();
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			string qssj=this.Dl_nian.SelectedItem.Text.Trim()+"-"+this.Dl_yue.SelectedItem.Text.Trim()+"-"+this.Dl_ri.SelectedItem.Text.Trim();
			string zzsj=this.Dl_nian1.SelectedItem.Text.Trim()+"-"+this.Dl_yue1.SelectedItem.Text.Trim()+"-"+this.Dl_ri1.SelectedItem.Text.Trim();
			if(this.DropDownList_tjfs.SelectedItem.Text.Trim()=="记录"&&this.Dl_cxfs.SelectedItem.Text.Trim()=="查询所有")
			{
				this.sqlDataAdapter_dingpiao.SelectCommand.CommandText="select * from  dingpiao  where 售票日期>='"+qssj+"' and   售票日期<='"+zzsj+"'";
				if(this.sqlConnection1.State.ToString()=="closed")
					this.sqlConnection1.Open();
				this.sqlDataAdapter_dingpiao.Fill(this.dataSet_dingpiao);
				this.DataGrid1.DataBind();
				this.DataGrid1.Visible=true;
				this.qssj.Text=qssj;
				this.jzsj.Text=zzsj;
                            
			}

			if(this.DropDownList_tjfs.SelectedItem.Text.Trim()=="记录"&&this.Dl_cxfs.SelectedItem.Text.Trim()=="按车次")
			{
				this.TextBox_checi.Enabled=true;
				this.sqlDataAdapter_dingpiao.SelectCommand.CommandText="select * from  dingpiao  where 售票日期>='"+qssj+"' and   售票日期<='"+zzsj+"'and 车次='"+this.TextBox_checi.Text.Trim()+"' ";
				if(this.sqlConnection1.State.ToString()=="closed")
					this.sqlConnection1.Open();
				this.sqlDataAdapter_dingpiao.Fill(this.dataSet_dingpiao);
				this.DataGrid1.DataBind();
				this.DataGrid1.Visible=true;
				this.qssj.Text=qssj;
				this.jzsj.Text=zzsj;
                            
			}

			if(this.DropDownList_tjfs.SelectedItem.Text.Trim()=="记录"&&this.Dl_cxfs.SelectedItem.Text.Trim()=="按售票点")
			{  
				
				this.sqlDataAdapter_dingpiao.SelectCommand.CommandText="select * from  dingpiao  where 售票日期>='"+qssj+"' and   售票日期<='"+zzsj+"'and 售票点编号='"+this.dsdbh.Text.Trim()+"' ";
				if(this.sqlConnection1.State.ToString()=="closed")
					this.sqlConnection1.Open();
				this.sqlDataAdapter_dingpiao.Fill(this.dataSet_dingpiao);
				this.DataGrid1.DataBind();
				this.DataGrid1.Visible=true;
				this.qssj.Text=qssj;
				this.jzsj.Text=zzsj;
                            
			}
		
			if(this.DropDownList_tjfs.SelectedItem.Text.Trim()=="合计"&&this.Dl_cxfs.SelectedItem.Text.Trim()=="按车次")
			{  string cxfs="1";
				string qssj1=this.Dl_nian.SelectedItem.Text.Trim()+"-"+this.Dl_yue.SelectedItem.Text.Trim()+"-"+this.Dl_ri.SelectedItem.Text.Trim();
				string zzsj1=this.Dl_nian1.SelectedItem.Text.Trim()+"-"+this.Dl_yue1.SelectedItem.Text.Trim()+"-"+this.Dl_ri1.SelectedItem.Text.Trim();
			    string checi=this.TextBox_checi.Text.Trim();
				string canshu="cxfs="+cxfs+"&qssj="+qssj+"&zzsj="+zzsj+"&checi="+checi;
				string msg;
				msg  = "<script language='javascript'>";
				msg +="window.open ('tongji.aspx?"+canshu+"','售票情况统计','height=200,width=700,top=150,left=100,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')"; 
				msg +="</script>";
				this.RegisterStartupScript("售票情况统计",msg);
			}
			if(this.DropDownList_tjfs.SelectedItem.Text.Trim()=="合计"&&this.Dl_cxfs.SelectedItem.Text.Trim()=="按售票点")
			{
				
				string qssj1=this.Dl_nian.SelectedItem.Text.Trim()+"-"+this.Dl_yue.SelectedItem.Text.Trim()+"-"+this.Dl_ri.SelectedItem.Text.Trim();
				string zzsj1=this.Dl_nian1.SelectedItem.Text.Trim()+"-"+this.Dl_yue1.SelectedItem.Text.Trim()+"-"+this.Dl_ri1.SelectedItem.Text.Trim();
				
				string canshu="qssj="+qssj+"&zzsj="+zzsj;
				string msg;
				msg  = "<script language='javascript'>";
				msg +="window.open ('tongji2.aspx?"+canshu+"','售票情况统计','height=200,width=700,top=150,left=100,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')"; 
				msg +="</script>";
				this.RegisterStartupScript("售票情况统计",msg);
			}
		
			if(this.DropDownList_tjfs.SelectedItem.Text.Trim()=="合计"&&this.Dl_cxfs.SelectedItem.Text.Trim()=="查询所有")
			{
				string cxfs="3";
				string qssj1=this.Dl_nian.SelectedItem.Text.Trim()+"-"+this.Dl_yue.SelectedItem.Text.Trim()+"-"+this.Dl_ri.SelectedItem.Text.Trim();
				string zzsj1=this.Dl_nian1.SelectedItem.Text.Trim()+"-"+this.Dl_yue1.SelectedItem.Text.Trim()+"-"+this.Dl_ri1.SelectedItem.Text.Trim();
			
				string canshu="cxfs="+cxfs+"&qssj="+qssj+"&zzsj="+zzsj;
				string msg;
				msg  = "<script language='javascript'>";
				msg +="window.open ('tongji.aspx?"+canshu+"','售票情况统计','height=200,width=700,top=150,left=100,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')"; 
				msg +="</script>";
				this.RegisterStartupScript("售票情况统计",msg);
			}

		
		}

		private void Dl_dsdbh_SelectedIndexChanged(object sender, System.EventArgs e)
		{ // this.dsdbh.Text=this.Dl_dsdbh.SelectedItem.Text.Trim();
			//this.TextBox_dsd.Text=this.Dl_dsdbh.SelectedItem.Value.ToString().Trim();
			this.TextBox_dsd.Text = this.Dl_dsdbh.SelectedValue;
			this.TextBox_dsd.Enabled=false;
		}

		private void DropDownList_tjfs_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
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
