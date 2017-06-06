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
	/// yijianfankui ��ժҪ˵����
	/// </summary>
	public class yijianfankui : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox TextBox_bt;
		protected System.Web.UI.WebControls.TextBox TextBox_nr;
		protected System.Web.UI.WebControls.Button Button_tj;
		protected System.Web.UI.WebControls.Button Button_cz;
		protected System.Web.UI.WebControls.Button Button_fh;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_liuyan;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
	
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
			this.sqlDataAdapter_liuyan = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.Button_tj.Click += new System.EventHandler(this.Button_tj_Click);
			this.Button_cz.Click += new System.EventHandler(this.Button_cz_Click);
			this.Button_fh.Click += new System.EventHandler(this.Button_fh_Click);
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlDataAdapter_liuyan
			// 
			this.sqlDataAdapter_liuyan.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_liuyan.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter_liuyan.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter_liuyan.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																											new System.Data.Common.DataTableMapping("Table", "liuyan", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("���", "���"),
																																																					  new System.Data.Common.DataColumnMapping("����", "����"),
																																																					  new System.Data.Common.DataColumnMapping("����", "����"),
																																																					  new System.Data.Common.DataColumnMapping("����", "����")})});
			this.sqlDataAdapter_liuyan.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM liuyan WHERE (��� = @Original_���)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ���, ����, ����, ���� FROM liuyan";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE liuyan SET ��� = @���, ���� = @����, ���� = @����, ���� = @���� WHERE (��� = @Original_���" +
				")";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Int, 4, "���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 50, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 1000, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 10, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button_tj_Click(object sender, System.EventArgs e)
		{
			if(this.TextBox_bt.Text.Trim()!=""&&this.TextBox_nr.Text.Trim()!="")
	     {   string shijian=DateTime.Today.ToString();
			 string yonghu=Session["username"].ToString();
			 this.sqlDataAdapter_liuyan.InsertCommand.CommandText="insert into liuyan (����,����,����,ʱ��) values('"+this.TextBox_bt.Text.Trim()+"','"+this.TextBox_nr.Text.Trim()+"','"+yonghu+"','"+shijian+"')";
			 this.sqlConnection1.Open();
			 this.sqlDataAdapter_liuyan.InsertCommand.ExecuteNonQuery();
			 this.sqlConnection1.Close();
			 Global.Alert(this,"�ύ�ɹ�!");

            }
		}

		private void Button_cz_Click(object sender, System.EventArgs e)
		{
			this.TextBox_bt.Text="";
			this.TextBox_nr.Text="";
		}

		private void Button_fh_Click(object sender, System.EventArgs e)
		{
			this.RegisterStartupScript("����","<script  language='javascript'> window.close();</script>");
		}
	}
}
