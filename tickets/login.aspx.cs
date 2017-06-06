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
	/// WebForm1 的摘要说明。
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.Image Image7;
		protected System.Web.UI.WebControls.Image Image6;
		protected System.Web.UI.WebControls.Image Image5;
		protected System.Web.UI.WebControls.Image Image4;
		protected System.Web.UI.WebControls.Image Image3;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Button Button_zhuce;
		protected System.Web.UI.WebControls.Button Button_quxiao;
		protected System.Web.UI.WebControls.Button Button_denglu;
		protected System.Web.UI.WebControls.TextBox text_password;
		protected System.Web.UI.WebControls.TextBox text_name;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection_user;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_user;
		protected System.Web.UI.WebControls.Label Label_zfwl;
		protected System.Web.UI.WebControls.Label Label_bt;
		protected System.Web.UI.WebControls.Label Label_mm;
		protected System.Web.UI.WebControls.Label Label_yhm;
		protected tickets.DataSet_user dataSet_user;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection_user.ConnectionString=data.connStr;
			// 在此处放置用户代码以初始化页面
			this.Label_zfwl.Text="总访问量:"+Global.total.ToString()+"次";
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
			this.sqlConnection_user = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_user = new System.Data.SqlClient.SqlDataAdapter();
			this.dataSet_user = new tickets.DataSet_user();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_user)).BeginInit();
			this.Button_zhuce.Click += new System.EventHandler(this.Button_zhuce_Click);
			this.Button_quxiao.Click += new System.EventHandler(this.Button_quxiao_Click);
			this.Button_denglu.Click += new System.EventHandler(this.Button_denglu_Click);
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 序号, 用户名, 密码, 联系地址, 联系电话 FROM [user]";
			this.sqlSelectCommand1.Connection = this.sqlConnection_user;
            // 
            // sqlConnection_user
            // 
            this.sqlConnection_user.ConnectionString = "workstation id=\"PC-517\";packet size=4096;user id=sa;data source=\"(local)\";persist" +
            	" security info=False;initial catalog=selltickets";
            //this.sqlConnection_user.ConnectionString = "server=172.21.3.90;database=selltickets;uid=sa;pwd=zj19951105";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO [user] (序号, 用户名, 密码, 联系地址, 联系电话) VALUES (@序号, @用户名, @密码, @联系地址, @联系电话" +
				"); SELECT 序号, 用户名, 密码, 联系地址, 联系电话 FROM [user] WHERE (序号 = @序号)";
			this.sqlInsertCommand1.Connection = this.sqlConnection_user;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@序号", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@用户名", System.Data.SqlDbType.VarChar, 10, "用户名"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@密码", System.Data.SqlDbType.VarChar, 10, "密码"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@联系地址", System.Data.SqlDbType.VarChar, 50, "联系地址"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@联系电话", System.Data.SqlDbType.VarChar, 10, "联系电话"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE [user] SET 序号 = @序号, 用户名 = @用户名, 密码 = @密码, 联系地址 = @联系地址, 联系电话 = @联系电话 WHERE (序号 = @Original_序号) AND (密码 = @Original_密码 OR @Original_密码 IS NULL AND 密码 IS NULL) AND (用户名 = @Original_用户名 OR @Original_用户名 IS NULL AND 用户名 IS NULL) AND (联系地址 = @Original_联系地址 OR @Original_联系地址 IS NULL AND 联系地址 IS NULL) AND (联系电话 = @Original_联系电话 OR @Original_联系电话 IS NULL AND 联系电话 IS NULL); SELECT 序号, 用户名, 密码, 联系地址, 联系电话 FROM [user] WHERE (序号 = @序号)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection_user;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@序号", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@用户名", System.Data.SqlDbType.VarChar, 10, "用户名"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@密码", System.Data.SqlDbType.VarChar, 10, "密码"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@联系地址", System.Data.SqlDbType.VarChar, 50, "联系地址"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@联系电话", System.Data.SqlDbType.VarChar, 10, "联系电话"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_密码", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "密码", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户名", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户名", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系地址", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系地址", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系电话", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系电话", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM [user] WHERE (序号 = @Original_序号) AND (密码 = @Original_密码 OR @Original_密码 IS NULL AND 密码 IS NULL) AND (用户名 = @Original_用户名 OR @Original_用户名 IS NULL AND 用户名 IS NULL) AND (联系地址 = @Original_联系地址 OR @Original_联系地址 IS NULL AND 联系地址 IS NULL) AND (联系电话 = @Original_联系电话 OR @Original_联系电话 IS NULL AND 联系电话 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection_user;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_密码", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "密码", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户名", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户名", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系地址", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系地址", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系电话", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系电话", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter_user
			// 
			this.sqlDataAdapter_user.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_user.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter_user.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter_user.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										  new System.Data.Common.DataTableMapping("Table", "user", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("序号", "序号"),
																																																				  new System.Data.Common.DataColumnMapping("用户名", "用户名"),
																																																				  new System.Data.Common.DataColumnMapping("密码", "密码"),
																																																				  new System.Data.Common.DataColumnMapping("联系地址", "联系地址"),
																																																				  new System.Data.Common.DataColumnMapping("联系电话", "联系电话")})});
			this.sqlDataAdapter_user.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// dataSet_user
			// 
			this.dataSet_user.DataSetName = "DataSet_user";
			this.dataSet_user.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_user)).EndInit();

		}
		#endregion

		private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
		{
		
		}

		private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
		{
		
		}

		private void Button_denglu_Click(object sender, System.EventArgs e)
		{  
			if(this.sqlConnection_user.State.ToString()=="Closed")
				      this.sqlConnection_user.Open();
			if(this.text_name.Text.Trim()!=""&&this.text_password.Text.Trim()!="")
			{
				string sql="select * from [user] where 用户名='"+this.text_name.Text.Trim()+"'and 密码='"+this.text_password.Text.Trim()+"'";
				this.sqlDataAdapter_user.SelectCommand.CommandText=sql;
				this.sqlDataAdapter_user.Fill (this.dataSet_user);
            	
				if(this.dataSet_user.Tables[0].Rows.Count>0)
				{
					Session["username"]=this.text_name.Text.Trim();
					this.Response.Redirect("main.aspx");
				}
				else 
					Global.Alert(this,"用户名或密码输入有误，请重新输入！");			
			}
			else 
			{
				Global.Alert(this,"用户名或密码输入不完整！");
			     
				Session["username"]=null;   
			}
		}   

		private void Button_zhuce_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("zhuce.aspx");
		}

		private void Button_quxiao_Click(object sender, System.EventArgs e)
		{
		this.RegisterStartupScript("登陆","<script  language='javascript'> window.close();</script>");
		}
	}
}
