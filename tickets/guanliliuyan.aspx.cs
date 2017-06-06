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
	/// guanliliuyan 的摘要说明。
	/// </summary>
	public class guanliliuyan : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label_xh;
		protected System.Web.UI.WebControls.Button Button_fh;
		protected System.Web.UI.WebControls.TextBox TextBox_bt;
		protected System.Web.UI.WebControls.TextBox TextBox_nr;
		protected System.Web.UI.WebControls.Button Button_plsc;
		protected System.Web.UI.WebControls.Button Button_cx;
		protected System.Web.UI.WebControls.DropDownList Dropdownlist_ri1;
		protected System.Web.UI.WebControls.DropDownList Dropdownlist_yue1;
		protected System.Web.UI.WebControls.DropDownList Dropdownlist_nian1;
		protected System.Web.UI.WebControls.DropDownList DropDownList_ri;
		protected System.Web.UI.WebControls.DropDownList DropDownList_yue;
		protected System.Web.UI.WebControls.DropDownList DropDownList_nian;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_ly;
		protected tickets.DataSet_ly dataSet_ly;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Web.UI.WebControls.Label Label_sj;
		protected System.Web.UI.WebControls.Label Label_yh;
		protected System.Web.UI.WebControls.Button Button_sc;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			this.sqlConnection1.ConnectionString=data.connStr;
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
			this.sqlDataAdapter_ly = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dataSet_ly = new tickets.DataSet_ly();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_ly)).BeginInit();
			this.Button_sc.Click += new System.EventHandler(this.Button_sc_Click);
			this.Button_fh.Click += new System.EventHandler(this.Button_fh_Click);
			this.Button_cx.Click += new System.EventHandler(this.Button_cx_Click);
			this.Button_plsc.Click += new System.EventHandler(this.Button_plsc_Click);
			this.DataGrid1.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_ItemCommand);
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlDataAdapter_ly
			// 
			this.sqlDataAdapter_ly.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_ly.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter_ly.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter_ly.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "liuyan", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("序号", "序号"),
																																																				  new System.Data.Common.DataColumnMapping("标题", "标题"),
																																																				  new System.Data.Common.DataColumnMapping("内容", "内容"),
																																																				  new System.Data.Common.DataColumnMapping("作者", "作者"),
																																																				  new System.Data.Common.DataColumnMapping("时间", "时间")})});
			this.sqlDataAdapter_ly.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO liuyan(标题, 内容, 作者, 时间) VALUES (@标题, @内容, @作者, @时间)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@标题", System.Data.SqlDbType.VarChar, 50, "标题"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@内容", System.Data.SqlDbType.VarChar, 1000, "内容"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@作者", System.Data.SqlDbType.VarChar, 50, "作者"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@时间", System.Data.SqlDbType.DateTime, 8, "时间"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 序号, 标题, 内容, 作者, 时间 FROM liuyan";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE liuyan SET 标题 = @标题, 内容 = @内容, 作者 = @作者, 时间 = @时间 WHERE (序号 = @Original_序号" +
				")";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@标题", System.Data.SqlDbType.VarChar, 50, "标题"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@内容", System.Data.SqlDbType.VarChar, 1000, "内容"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@作者", System.Data.SqlDbType.VarChar, 50, "作者"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@时间", System.Data.SqlDbType.DateTime, 8, "时间"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet_ly
			// 
			this.dataSet_ly.DataSetName = "DataSet_ly";
			this.dataSet_ly.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_ly)).EndInit();

		}
		#endregion

		private void Button_cx_Click(object sender, System.EventArgs e)
		{
			string kssj=this.DropDownList_nian.SelectedItem.Text.Trim()+"-"+this.DropDownList_yue.SelectedItem.Text.Trim()+"-"+this.DropDownList_ri.SelectedItem.Text.Trim(); 
			string zzsj=this.Dropdownlist_nian1.SelectedItem.Text.Trim()+"-"+this.Dropdownlist_yue1.SelectedItem.Text.Trim()+"-"+this.Dropdownlist_ri1.SelectedItem.Text.Trim(); 
			this.sqlDataAdapter_ly.SelectCommand.CommandText="select * from liuyan where 时间>='"+kssj+"' and 时间<='"+zzsj+"'";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_ly.Fill(this.dataSet_ly);
			this.DataGrid1.DataBind();
		}

		private void Button_fh_Click(object sender, System.EventArgs e)
		{
			this.RegisterStartupScript("返回","<script  language='javascript'> window.close();</script>");
		}

		private void Button_plsc_Click(object sender, System.EventArgs e)
		{
			string kssj=this.DropDownList_nian.SelectedItem.Text.Trim()+"-"+this.DropDownList_yue.SelectedItem.Text.Trim()+"-"+this.DropDownList_ri.SelectedItem.Text.Trim(); 
			string zzsj=this.Dropdownlist_nian1.SelectedItem.Text.Trim()+"-"+this.Dropdownlist_yue1.SelectedItem.Text.Trim()+"-"+this.Dropdownlist_ri1.SelectedItem.Text.Trim(); 
			this.sqlDataAdapter_ly.DeleteCommand.CommandText="delete from liuyan where 时间>='"+kssj+"' and 时间<='"+zzsj+"'";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_ly.DeleteCommand.ExecuteNonQuery();
			Global.Alert(this,"删除成功!");
		}

		private void Button_sc_Click(object sender, System.EventArgs e)
		{
			this.sqlDataAdapter_ly.DeleteCommand.CommandText="delete from liuyan where  序号='"+this.Label_xh.Text.Trim()+"'";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_ly.DeleteCommand.ExecuteNonQuery();
              	Global.Alert(this,"删除成功!");
		}

		private void DataGrid1_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			this.dataSet_ly.Clear();
			if(e.CommandName=="Select")
			{
				string  flag=this.DataGrid1.DataKeys[e.Item.ItemIndex].ToString();
				this.sqlDataAdapter_ly.SelectCommand.CommandText="select * from liuyan where 序号='"+flag+"'";
				if(this.sqlConnection1.State.ToString()=="closed")
					this.sqlConnection1.Open();
				this.sqlDataAdapter_ly.Fill(this.dataSet_ly);
                this.Label_xh.Text=this.dataSet_ly.Tables[0].Rows[0][0].ToString().Trim();
				this.TextBox_bt.Text=this.dataSet_ly.Tables[0].Rows[0][1].ToString().Trim();
				this.TextBox_nr.Text=this.dataSet_ly.Tables[0].Rows[0][2].ToString().Trim();
				this.Label_yh.Text=this.dataSet_ly.Tables[0].Rows[0][3].ToString().Trim();
				this.Label_sj.Text=this.dataSet_ly.Tables[0].Rows[0][4].ToString().Substring(0,9);
				
			}
		}
	}
}
