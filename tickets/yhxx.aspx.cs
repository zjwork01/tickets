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
	/// yhxx ��ժҪ˵����
	/// </summary>
	public class yhxx : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button_xg;
		protected System.Web.UI.WebControls.Button Button_qx;
		protected System.Web.UI.WebControls.TextBox TextBox_yhm;
		protected System.Web.UI.WebControls.TextBox TextBox_mm;
		protected System.Web.UI.WebControls.TextBox TextBox_lxfs;
		protected System.Web.UI.WebControls.TextBox TextBox_fzr;
		protected System.Web.UI.WebControls.TextBox TextBox_dwmc;
		protected System.Web.UI.WebControls.TextBox TextBox_sfz;
		protected System.Web.UI.WebControls.TextBox TextBox_dz;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_grxx;
		protected tickets.DataSet_grxx dataSet_grxx;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Web.UI.WebControls.Label Label_xh;
		protected System.Web.UI.WebControls.Button Button_queding;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection1.ConnectionString=data.connStr;
			// �ڴ˴������û������Գ�ʼ��ҳ��
			string yhm=Session["username"].ToString();
			if(!this.IsPostBack)
			{
				this.xsyhxx(yhm);
			}
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
			this.sqlDataAdapter_grxx = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dataSet_grxx = new tickets.DataSet_grxx();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_grxx)).BeginInit();
			this.Button_xg.Click += new System.EventHandler(this.Button_xg_Click);
			this.Button_queding.Click += new System.EventHandler(this.Button_queding_Click);
			this.Button_qx.Click += new System.EventHandler(this.Button_qx_Click);
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlDataAdapter_grxx
			// 
			this.sqlDataAdapter_grxx.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_grxx.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter_grxx.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter_grxx.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										  new System.Data.Common.DataTableMapping("Table", "user", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("���", "���"),
																																																				  new System.Data.Common.DataColumnMapping("�û���", "�û���"),
																																																				  new System.Data.Common.DataColumnMapping("����", "����"),
																																																				  new System.Data.Common.DataColumnMapping("��ϵ��ʽ", "��ϵ��ʽ"),
																																																				  new System.Data.Common.DataColumnMapping("������", "������"),
																																																				  new System.Data.Common.DataColumnMapping("��λȫ��", "��λȫ��"),
																																																				  new System.Data.Common.DataColumnMapping("�����ַ", "�����ַ"),
																																																				  new System.Data.Common.DataColumnMapping("���֤", "���֤"),
																																																				  new System.Data.Common.DataColumnMapping("���۵���", "���۵���"),
																																																				  new System.Data.Common.DataColumnMapping("�û�����", "�û�����")})});
			this.sqlDataAdapter_grxx.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM [user] WHERE (��� = @Original_���)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO [user] (���, �û���, ����, ��ϵ��ʽ, ������, ��λȫ��, �����ַ, ���֤, ���۵���, �û�����) VALUES " +
				"(@���, @�û���, @����, @��ϵ��ʽ, @������, @��λȫ��, @�����ַ, @���֤, @���۵���, @�û�����)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Int, 4, "���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�û���", System.Data.SqlDbType.VarChar, 10, "�û���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 10, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ϵ��ʽ", System.Data.SqlDbType.VarChar, 50, "��ϵ��ʽ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������", System.Data.SqlDbType.VarChar, 10, "������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��λȫ��", System.Data.SqlDbType.VarChar, 50, "��λȫ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�����ַ", System.Data.SqlDbType.VarChar, 50, "�����ַ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���֤", System.Data.SqlDbType.VarChar, 20, "���֤"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���۵���", System.Data.SqlDbType.Int, 4, "���۵���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�û�����", System.Data.SqlDbType.Int, 4, "�û�����"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ���, �û���, ����, ��ϵ��ʽ, ������, ��λȫ��, �����ַ, ���֤, ���۵���, �û����� FROM [user]";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			// 
			// dataSet_grxx
			// 
			this.dataSet_grxx.DataSetName = "DataSet_grxx";
			this.dataSet_grxx.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_grxx)).EndInit();

		}
		#endregion
		private void xsyhxx(string yhm)
		{
		    this.sqlDataAdapter_grxx.SelectCommand.CommandText="select * from [user] where �û���='"+yhm+"'";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_grxx.Fill(this.dataSet_grxx);

			this.Label_xh.Text=this.dataSet_grxx.Tables[0].Rows[0][0].ToString().Trim();
			this.TextBox_yhm.Text=this.dataSet_grxx.Tables[0].Rows[0][1].ToString().Trim();
			this.TextBox_mm.Text=this.dataSet_grxx.Tables[0].Rows[0][2].ToString().Trim();
			this.TextBox_lxfs.Text=this.dataSet_grxx.Tables[0].Rows[0][3].ToString().Trim();
			this.TextBox_fzr.Text=this.dataSet_grxx.Tables[0].Rows[0][4].ToString().Trim();
			this.TextBox_dwmc.Text=this.dataSet_grxx.Tables[0].Rows[0][5].ToString().Trim();
			this.TextBox_sfz.Text=this.dataSet_grxx.Tables[0].Rows[0][7].ToString().Trim();
			this.TextBox_dz.Text=this.dataSet_grxx.Tables[0].Rows[0][6].ToString().Trim();

			this.Label_xh.Enabled=false;
			this.TextBox_yhm.Enabled=false;
			this.TextBox_mm.Enabled=false;
			this.TextBox_lxfs.Enabled=false;
			this.TextBox_fzr.Enabled=false;
			this.TextBox_dwmc.Enabled=false;
			this.TextBox_sfz.Enabled=false;
			this.TextBox_dz.Enabled=false;



		}

		private void Button_xg_Click(object sender, System.EventArgs e)
		{
			this.Button_xg.Visible=false;
			this.Button_queding.Visible=true;

			this.Label_xh.Enabled=true;
			this.TextBox_yhm.Enabled=true;
			this.TextBox_mm.Enabled=true;
			this.TextBox_lxfs.Enabled=true;
			this.TextBox_fzr.Enabled=true;
			this.TextBox_dwmc.Enabled=true;
			this.TextBox_sfz.Enabled=true;
			this.TextBox_dz.Enabled=true;
          
		}

		private void Button_queding_Click(object sender, System.EventArgs e)
		{
			this.sqlDataAdapter_grxx.UpdateCommand.CommandText="update [user] set �û���='"+this.TextBox_yhm.Text.Trim()+"',����='"+this.TextBox_mm.Text.Trim()+"',��ϵ��ʽ='"+this.TextBox_lxfs.Text.Trim()+"',������='"+this.TextBox_fzr.Text.Trim()+"',��λȫ��='"+this.TextBox_dwmc.Text.Trim()+"',���֤='"+this.TextBox_sfz.Text.Trim()+"',�����ַ='"+this.TextBox_dz.Text.Trim()+"' where ���='"+this.Label_xh.Text.Trim()+"'";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_grxx.UpdateCommand.ExecuteNonQuery();
			this.Label_xh.Text="���³ɹ�!";
			this.Label_xh.Visible=true;
		}

		private void Button_qx_Click(object sender, System.EventArgs e)
		{
				this.RegisterStartupScript("������Ϣ","<script  language='javascript'> window.close();</script>");
		}
	}
}
