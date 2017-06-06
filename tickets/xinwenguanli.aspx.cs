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
	/// xinwenguanli ��ժҪ˵����
	/// </summary>
	public class xinwenguanli : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList DropDownList_ri;
		protected System.Web.UI.WebControls.DropDownList DropDownList_yue;
		protected System.Web.UI.WebControls.TextBox TextBox_bt;
		protected System.Web.UI.WebControls.TextBox TextBox_nr;
		protected System.Web.UI.WebControls.Button Button_zj;
		protected System.Web.UI.WebControls.Button Button_xg;
		protected System.Web.UI.WebControls.Button Button_sc;
		protected System.Web.UI.WebControls.Button Button_fh;
		protected System.Web.UI.WebControls.DropDownList Dropdownlist_ri1;
		protected System.Web.UI.WebControls.DropDownList Dropdownlist_yue1;
		protected System.Web.UI.WebControls.DropDownList Dropdownlist_nian1;
		protected System.Web.UI.WebControls.Button Button_plsc;
		protected System.Web.UI.WebControls.TextBox TextBox_sousuo;
		protected System.Web.UI.WebControls.Button Button_sousuo;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_xinwen;
		protected tickets.DataSet_xw dataSet_xw;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Web.UI.WebControls.Label Label_xh;
		protected System.Web.UI.WebControls.Button Button_cx;
		protected System.Web.UI.WebControls.DataGrid DataGrid_xwlb;
		protected System.Web.UI.WebControls.DropDownList DropDownList_nian;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			this.sqlConnection1.ConnectionString=data.connStr;
		}

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{    
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlDataAdapter_xinwen = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dataSet_xw = new tickets.DataSet_xw();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_xw)).BeginInit();
			this.Button_zj.Click += new System.EventHandler(this.Button_zj_Click);
			this.Button_xg.Click += new System.EventHandler(this.Button_xg_Click);
			this.Button_sc.Click += new System.EventHandler(this.Button_sc_Click);
			this.Button_fh.Click += new System.EventHandler(this.Button_fh_Click);
			this.Button_cx.Click += new System.EventHandler(this.Button_cx_Click);
			this.Button_plsc.Click += new System.EventHandler(this.Button_plsc_Click);
			this.Button_sousuo.Click += new System.EventHandler(this.Button_sousuo_Click);
			this.DataGrid_xwlb.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid_xwlb_ItemCommand);
			this.DataGrid_xwlb.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid_xwlb_PageIndexChanged);
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlDataAdapter_xinwen
			// 
			this.sqlDataAdapter_xinwen.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_xinwen.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter_xinwen.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter_xinwen.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																											new System.Data.Common.DataTableMapping("Table", "xinwen", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("���", "���"),
																																																					  new System.Data.Common.DataColumnMapping("����", "����"),
																																																					  new System.Data.Common.DataColumnMapping("����ʱ��", "����ʱ��"),
																																																					  new System.Data.Common.DataColumnMapping("����", "����")})});
			this.sqlDataAdapter_xinwen.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ���, ����, ����ʱ��, ���� FROM xinwen";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			// 
			// dataSet_xw
			// 
			this.dataSet_xw.DataSetName = "DataSet_xw";
			this.dataSet_xw.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_xw)).EndInit();

		}
		#endregion

		private void Button_zj_Click(object sender, System.EventArgs e)
		{  
			
			string riqi=DateTime.Today.ToString();
			if(this.TextBox_bt.Text.Trim()!=""&&this.TextBox_nr.Text.Trim()!="")
			{ this.dataSet_xw.Clear();
			  this.sqlDataAdapter_xinwen.InsertCommand.CommandText="insert into xinwen (����,����ʱ��,����) values('"+this.TextBox_bt.Text.Trim()+"','"+riqi+"','"+this.TextBox_nr.Text.Trim()+"')";
				if(this.sqlConnection1.State.ToString()=="Closed")
					this.sqlConnection1.Open();
				this.sqlDataAdapter_xinwen.InsertCommand.ExecuteNonQuery();
			 Global.Alert(this,"�����ɹ�!");
			  
			}
			else Global.Alert(this,"��Ϣ������,����!");
		}

		private void Button_plsc_Click(object sender, System.EventArgs e)
		{ string kssj=this.DropDownList_nian.SelectedItem.Text.Trim()+"-"+this.DropDownList_yue.SelectedItem.Text.Trim()+"-"+this.DropDownList_ri.SelectedItem.Text.Trim(); 
		  string zzsj=this.Dropdownlist_nian1.SelectedItem.Text.Trim()+"-"+this.Dropdownlist_yue1.SelectedItem.Text.Trim()+"-"+this.Dropdownlist_ri1.SelectedItem.Text.Trim(); 
		  this.sqlDataAdapter_xinwen.DeleteCommand.CommandText="delete from xinwen where ����ʱ��>='"+kssj+"' and ����ʱ��<='"+zzsj+"'";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_xinwen.DeleteCommand.ExecuteNonQuery();
			 Global.Alert(this,"ɾ���ɹ�!");
		}

		private void Button_cx_Click(object sender, System.EventArgs e)
		{   this.dataSet_xw.Clear();
			string kssj=this.DropDownList_nian.SelectedItem.Text.Trim()+"-"+this.DropDownList_yue.SelectedItem.Text.Trim()+"-"+this.DropDownList_ri.SelectedItem.Text.Trim(); 
			string zzsj=this.Dropdownlist_nian1.SelectedItem.Text.Trim()+"-"+this.Dropdownlist_yue1.SelectedItem.Text.Trim()+"-"+this.Dropdownlist_ri1.SelectedItem.Text.Trim(); 
			this.sqlDataAdapter_xinwen.SelectCommand.CommandText="select * from xinwen where ����ʱ��>='"+kssj+"' and ����ʱ��<='"+zzsj+"'";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_xinwen.Fill(this.dataSet_xw);
		    this.DataGrid_xwlb.DataBind();
		}

		private void Button_sousuo_Click(object sender, System.EventArgs e)
		{
			this.dataSet_xw.Clear();
			this.sqlDataAdapter_xinwen.SelectCommand.CommandText="select * from xinwen where ���� like'"+this.TextBox_sousuo.Text.Trim()+"%'";
			if(this.sqlConnection1.State.ToString()=="Closed")
				 this.sqlConnection1.Open();
			this.sqlDataAdapter_xinwen.Fill(this.dataSet_xw);
			this.DataGrid_xwlb.DataBind();
		}

		private void DataGrid_xwlb_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			this.dataSet_xw.Clear();
			if(e.CommandName=="Select")
			{
				string  flag=this.DataGrid_xwlb.DataKeys[e.Item.ItemIndex].ToString();
				this.sqlDataAdapter_xinwen.SelectCommand.CommandText="select * from xinwen where ���='"+flag+"'";
				if(this.sqlConnection1.State.ToString()=="closed")
					this.sqlConnection1.Open();
				this.sqlDataAdapter_xinwen.Fill(this.dataSet_xw);

				this.Label_xh.Text=this.dataSet_xw.Tables[0].Rows[0][0].ToString();
				this.TextBox_bt.Text=this.dataSet_xw.Tables[0].Rows[0][1].ToString();
				this.TextBox_nr.Text=this.dataSet_xw.Tables[0].Rows[0][3].ToString();
				
			}
		}

		private void Button_xg_Click(object sender, System.EventArgs e)
		{
			
			this.sqlDataAdapter_xinwen.UpdateCommand.CommandText="update  xinwen set ����='"+this.TextBox_bt.Text.Trim()+"',����='"+this.TextBox_nr.Text.Trim()+"'where ���='"+this.Label_xh.Text.Trim()+"'";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_xinwen.UpdateCommand.ExecuteNonQuery();
			Global.Alert(this,"�޸ĳɹ�!");
			  
		}

		private void Button_sc_Click(object sender, System.EventArgs e)
		{
			this.sqlDataAdapter_xinwen.DeleteCommand.CommandText="delete from xinwen where ���='"+this.Label_xh.Text.Trim()+"'";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_xinwen.DeleteCommand.ExecuteNonQuery();
			Global.Alert(this,"ɾ���ɹ�!");
		}

		private void Button_fh_Click(object sender, System.EventArgs e)
		{
			this.RegisterStartupScript("����","<script  language='javascript'> window.close();</script>");
		}

		private void DataGrid_xwlb_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			this.sqlDataAdapter_xinwen.Fill(this.dataSet_xw);
			this.DataGrid_xwlb.CurrentPageIndex=e.NewPageIndex;
			this.DataGrid_xwlb.DataBind();
		}
	}
}
