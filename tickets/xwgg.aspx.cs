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
	/// xwgg 的摘要说明。
	/// </summary>
	public class xwgg : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox TextBox_xwnr;
		protected System.Web.UI.WebControls.Label Label_biaoti;
		protected System.Web.UI.WebControls.Label Label_shijian;
		protected System.Web.UI.WebControls.DropDownList DropDownList_ri;
		protected System.Web.UI.WebControls.DropDownList DropDownList_yue;
		protected System.Web.UI.WebControls.DropDownList DropDownList_nian;
		protected System.Web.UI.WebControls.Button Button_chaxun;
		protected System.Web.UI.WebControls.Label Lbl_fwl;
		protected System.Web.UI.WebControls.Label Lb_zjl;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_xinwen;
		protected tickets.DataSet_xinwen dataSet_xinwen;
		protected System.Web.UI.WebControls.DataGrid DataGrid_ywxw;
		protected System.Web.UI.WebControls.DataGrid DataGrid_jryw;
		protected System.Web.UI.WebControls.Label Label_sj;
		protected System.Web.UI.WebControls.Label Label_jryw;
		protected System.Web.UI.WebControls.DataGrid DataGrid_chaxun;
		protected System.Web.UI.WebControls.Label Label_tishi;
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection1.ConnectionString=data.connStr;
			// 在此处放置用户代码以初始化页面
	
			if(!this.IsPostBack)
			{
				this.jryw();
			}
			this.ywxw();
           this.Label_sj.Text="今天是:"+DateTime.Today.Year+"-"+DateTime.Today.Month+"-"+DateTime.Today.Day+" "+DateTime.Today.DayOfWeek;
	          this.Lbl_fwl.Text=Global.total.ToString();
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
			this.sqlDataAdapter_xinwen = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dataSet_xinwen = new tickets.DataSet_xinwen();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_xinwen)).BeginInit();
			this.DataGrid_ywxw.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid_ywxw_ItemCommand);
			this.DataGrid_ywxw.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid_ywxw_PageIndexChanged);
			this.TextBox_xwnr.TextChanged += new System.EventHandler(this.TextBox_xwnr_TextChanged);
			this.DataGrid_jryw.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid_jryw_ItemCommand);
			this.DataGrid_jryw.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid_jryw_PageIndexChanged);
			this.Button_chaxun.Click += new System.EventHandler(this.Button_chaxun_Click);
			this.DataGrid_chaxun.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid_chaxun_PageIndexChanged);
			this.LinkButton1.Click += new System.EventHandler(this.LinkButton1_Click);
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlDataAdapter_xinwen
			// 
			this.sqlDataAdapter_xinwen.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter_xinwen.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																											new System.Data.Common.DataTableMapping("Table", "xinwen", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("序号", "序号"),
																																																					  new System.Data.Common.DataColumnMapping("标题", "标题"),
																																																					  new System.Data.Common.DataColumnMapping("发布时间", "发布时间"),
																																																					  new System.Data.Common.DataColumnMapping("内容", "内容")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 序号, 标题, 发布时间, 内容 FROM xinwen";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// dataSet_xinwen
			// 
			this.dataSet_xinwen.DataSetName = "DataSet_xinwen";
			this.dataSet_xinwen.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_xinwen)).EndInit();

		}
		#endregion
		private void jryw()
		{ DateTime fbsj=DateTime.Today;
		  this.sqlDataAdapter_xinwen.SelectCommand.CommandText="select * from xinwen where 发布时间 ='"+fbsj+"'";
		  if(this.sqlConnection1.State.ToString()=="closed")
			  this.sqlConnection1.Open();
			this.sqlDataAdapter_xinwen.Fill(this.dataSet_xinwen);
			int count=this.dataSet_xinwen.Tables[0].Rows.Count;
		
				this.Label_biaoti.Text=this.dataSet_xinwen.Tables[0].Rows[0][1].ToString();
				this.Label_shijian.Text=this.dataSet_xinwen.Tables[0].Rows[0][2].ToString();
				this.TextBox_xwnr.Text=this.dataSet_xinwen.Tables[0].Rows[0][3].ToString();
		

			for(int i=0;i<count;i++)
			{ if(this.dataSet_xinwen.Tables[0].Rows[i][1].ToString().Length>10)
			   this.dataSet_xinwen.Tables[0].Rows[i][1]=this.dataSet_xinwen.Tables[0].Rows[i][1].ToString().Substring(0,10);
			  
			}
			this.DataGrid_jryw.DataBind();


		}

		private void ywxw()
		{
		   this.sqlDataAdapter_xinwen.SelectCommand.CommandText="select * from xinwen ";
			if(this.sqlConnection1.State.ToString()=="closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_xinwen.Fill(this.dataSet_xinwen);
			int count=this.dataSet_xinwen.Tables[0].Rows.Count;
			for(int i=0;i<count;i++)
			{  if(this.dataSet_xinwen.Tables[0].Rows[i][1].ToString().Length>10)
				this.dataSet_xinwen.Tables[0].Rows[i][1]=this.dataSet_xinwen.Tables[0].Rows[i][1].ToString().Substring(0,10);
			
			}
			this.DataGrid_ywxw.DataBind();
			this.Lb_zjl.Text=count.ToString();

		}

		private void DataGrid_jryw_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{   this.dataSet_xinwen.Clear();
			if(e.CommandName=="Select")
			{
				string  flag=this.DataGrid_jryw.DataKeys[e.Item.ItemIndex].ToString();
				this.sqlDataAdapter_xinwen.SelectCommand.CommandText="select * from xinwen where 序号='"+flag+"'";
				if(this.sqlConnection1.State.ToString()=="closed")
					this.sqlConnection1.Open();
				this.sqlDataAdapter_xinwen.Fill(this.dataSet_xinwen);

				this.Label_biaoti.Text=this.dataSet_xinwen.Tables[0].Rows[0][1].ToString();
				this.Label_shijian.Text=this.dataSet_xinwen.Tables[0].Rows[0][2].ToString();
				this.TextBox_xwnr.Text=this.dataSet_xinwen.Tables[0].Rows[0][3].ToString();
			}
		}

		private void DataGrid_jryw_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
		
			this.sqlDataAdapter_xinwen.Fill(this.dataSet_xinwen);
			int count=this.dataSet_xinwen.Tables[0].Rows.Count;
			for(int i=0;i<count;i++)
			{
				if(this.dataSet_xinwen.Tables[0].Rows[i][1].ToString().Length>10)
					this.dataSet_xinwen.Tables[0].Rows[i][1]=this.dataSet_xinwen.Tables[0].Rows[i][1].ToString().Substring(0,10);
			
			}
			this.DataGrid_jryw.CurrentPageIndex=e.NewPageIndex;
			this.DataGrid_jryw.DataBind();
		}

		private void DataGrid_ywxw_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			this.dataSet_xinwen.Clear();
			if(e.CommandName=="Select")
			{
				string  flag=this.DataGrid_ywxw.DataKeys[e.Item.ItemIndex].ToString();
				this.sqlDataAdapter_xinwen.SelectCommand.CommandText="select * from xinwen where 序号='"+flag+"'";
				if(this.sqlConnection1.State.ToString()=="closed")
					this.sqlConnection1.Open();
				this.sqlDataAdapter_xinwen.Fill(this.dataSet_xinwen);

				this.Label_biaoti.Text=this.dataSet_xinwen.Tables[0].Rows[0][1].ToString();
				this.Label_shijian.Text=this.dataSet_xinwen.Tables[0].Rows[0][2].ToString();
				this.TextBox_xwnr.Text=this.dataSet_xinwen.Tables[0].Rows[0][3].ToString();
			}
		}

		private void DataGrid_ywxw_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{   
					
			this.sqlDataAdapter_xinwen.Fill(this.dataSet_xinwen);
			int count=this.dataSet_xinwen.Tables[0].Rows.Count;
			for(int i=0;i<count;i++)
			{
				if(this.dataSet_xinwen.Tables[0].Rows[i][1].ToString().Length>10)
					this.dataSet_xinwen.Tables[0].Rows[i][1]=this.dataSet_xinwen.Tables[0].Rows[i][1].ToString().Substring(0,10);
			
			}
			this.DataGrid_ywxw.CurrentPageIndex=e.NewPageIndex;
			this.DataGrid_ywxw.DataBind();
		}

		private void Button_chaxun_Click(object sender, System.EventArgs e)
		{ this.dataSet_xinwen.Clear();
			this.Label_tishi.Text="";
		 string shijian=this.DropDownList_nian.SelectedItem.Text.Trim()+"-"+this.DropDownList_yue.SelectedItem.Text.Trim()+"-"+this.DropDownList_ri.SelectedItem.Text.Trim();
		 this.sqlDataAdapter_xinwen.SelectCommand.CommandText="select * from xinwen where 发布时间='"+shijian+"'";
			if(this.sqlConnection1.State.ToString()=="closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_xinwen.Fill(this.dataSet_xinwen);
            
			int count=this.dataSet_xinwen.Tables[0].Rows.Count;
			if(count>1)
			{
				for(int i=0;i<count;i++)
				{
					if(this.dataSet_xinwen.Tables[0].Rows[i][1].ToString().Length>10)
						this.dataSet_xinwen.Tables[0].Rows[i][1]=this.dataSet_xinwen.Tables[0].Rows[i][1].ToString().Substring(0,10)+"...";
			
				}
			
				this.DataGrid_chaxun.DataBind();
			}

           else this.Label_tishi.Text="没有相关记录!";

		}

		private void DataGrid_chaxun_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			
			this.sqlDataAdapter_xinwen.Fill(this.dataSet_xinwen);
			int count=this.dataSet_xinwen.Tables[0].Rows.Count;
			for(int i=0;i<count;i++)
			{
				if(this.dataSet_xinwen.Tables[0].Rows[i][1].ToString().Length>10)
					this.dataSet_xinwen.Tables[0].Rows[i][1]=this.dataSet_xinwen.Tables[0].Rows[i][1].ToString().Substring(0,10);
			
			}
			this.DataGrid_chaxun.CurrentPageIndex=e.NewPageIndex;
			this.DataGrid_chaxun.DataBind();
		}

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("main.aspx");
		}

		private void TextBox_xwnr_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
