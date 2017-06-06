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
	/// bianjiyonghu ��ժҪ˵����
	/// </summary>
	public class bianjiyonghu : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button_xiugai;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		protected System.Web.UI.WebControls.Label Label_biaoti;
		protected System.Web.UI.WebControls.Button Button_zj;
		protected System.Web.UI.WebControls.Button Button_cz;
		protected System.Web.UI.WebControls.TextBox TextBox_bh;
		protected System.Web.UI.WebControls.TextBox TextBox_yhm;
		protected System.Web.UI.WebControls.TextBox TextBox_mm;
		protected System.Web.UI.WebControls.TextBox TextBox_dwmc;
		protected System.Web.UI.WebControls.TextBox TextBox_dz;
		protected System.Web.UI.WebControls.TextBox TextBox_sfz;
		protected System.Web.UI.WebControls.TextBox TextBox_lxfs;
		protected System.Web.UI.WebControls.TextBox TextBoxfzr;
		protected System.Web.UI.WebControls.TextBox TextBox_yhlx;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_user;
		protected tickets.DataSet_userbj dataSet_userbj;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Web.UI.WebControls.Label xuhao;
		protected System.Web.UI.WebControls.Label Label_xuhao;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection1.ConnectionString=data.connStr;
			// �ڴ˴������û������Գ�ʼ��ҳ��

			this.xuhao.Text=Request.QueryString["xh"];
			if(this.xuhao.Text.Trim()=="0")
			{
					this.chongzhi();
				this.Label_xuhao.Visible=false;
			}
			else
				this.xianshixinxi(this.xuhao.Text.Trim());

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
			this.sqlDataAdapter_user = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dataSet_userbj = new tickets.DataSet_userbj();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_userbj)).BeginInit();
			this.Button_xiugai.Click += new System.EventHandler(this.Button_xiugai_Click);
			this.Button_zj.Click += new System.EventHandler(this.Button_zj_Click);
			this.Button_cz.Click += new System.EventHandler(this.Button_cz_Click);
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlDataAdapter_user
			// 
			this.sqlDataAdapter_user.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_user.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter_user.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter_user.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.sqlDataAdapter_user.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM [user] WHERE (��� = @Original_���)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
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
			// dataSet_userbj
			// 
			this.dataSet_userbj.DataSetName = "DataSet_userbj";
			this.dataSet_userbj.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_userbj)).EndInit();

		}
		#endregion

		private void TextBox9_TextChanged(object sender, System.EventArgs e)
		{
		
		}
		private void chongzhi()

		{
		
			this.TextBox_bh.Text="";
			this.TextBox_dwmc.Text="";
			this.TextBox_dz.Text="";
			this.TextBox_lxfs.Text="";
			this.TextBox_mm.Text="";
			this.TextBox_sfz.Text="";
			this.TextBox_yhlx.Text="";
			this.TextBox_yhm.Text="";
			this.TextBoxfzr.Text="";
			this.xuhao.Text="";
		
		
		}
		private void xianshixinxi(string xuhao)
		{
		   this.sqlDataAdapter_user.SelectCommand.CommandText="select * from [user] where ���='"+xuhao+"'";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_user.Fill(this.dataSet_userbj);

			this.TextBox_yhm.Text=this.dataSet_userbj.Tables[0].Rows[0]["�û���"].ToString().Trim();
			this.TextBox_mm.Text=this.dataSet_userbj.Tables[0].Rows[0]["����"].ToString().Trim();
		    this.TextBox_lxfs.Text=this.dataSet_userbj.Tables[0].Rows[0]["��ϵ��ʽ"].ToString().Trim();
			this.TextBoxfzr.Text=this.dataSet_userbj.Tables[0].Rows[0]["������"].ToString().Trim();
			this.TextBox_dwmc.Text=this.dataSet_userbj.Tables[0].Rows[0]["��λȫ��"].ToString().Trim();
			this.TextBox_sfz.Text=this.dataSet_userbj.Tables[0].Rows[0]["���֤"].ToString().Trim();
			this.TextBox_dz.Text=this.dataSet_userbj.Tables[0].Rows[0]["�����ַ"].ToString().Trim();
			this.TextBox_bh.Text=this.dataSet_userbj.Tables[0].Rows[0]["���۵���"].ToString().Trim();
			this.TextBox_yhlx.Text=this.dataSet_userbj.Tables[0].Rows[0]["�û�����"].ToString().Trim();

		
		}

		private void Button_cz_Click(object sender, System.EventArgs e)
		{
			this.chongzhi();
		}

		private void Button_xiugai_Click(object sender, System.EventArgs e)
		{
		   string sql="update [user] set �û���='"+this.TextBox_yhm.Text.Trim()+"',����='"+this.TextBox_mm.Text.Trim()+"',��ϵ��ʽ='"+this.TextBox_lxfs.Text.Trim()+"',������='"+this.TextBoxfzr.Text.Trim()+"',��λȫ��='"+this.TextBox_dwmc.Text.Trim()+"',�����ַ=',"+this.TextBox_dz.Text.Trim()+"',���֤='"+this.TextBox_sfz.Text.Trim()+"',���۵���='"+this.TextBox_bh.Text.Trim()+"',�û�����='"+this.TextBox_yhlx.Text.Trim()+"'where ���='"+this.xuhao.Text.Trim()+"'";
		   this.sqlDataAdapter_user.UpdateCommand.CommandText=sql;
		
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_user.UpdateCommand.ExecuteNonQuery();

           Global.Alert(this,"���³ɹ�!");
           this.chongzhi();
		
		}

		private void Button_zj_Click(object sender, System.EventArgs e)
		{   this.sqlDataAdapter_user.SelectCommand.CommandText="select  *  from [user] ";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_user.Fill(this.dataSet_userbj);
			int xuhao=int.Parse(this.dataSet_userbj.Tables[0].Rows.Count.ToString())+1;
			string sql="insert into [user] (���,�û���,����,��ϵ��ʽ,������,��λȫ��,�����ַ,���֤,���۵���,�û����� ) values ('"+xuhao+"','"+this.TextBox_yhm.Text.Trim()+"','"+this.TextBox_mm.Text.Trim()+"','"+this.TextBox_lxfs.Text.Trim()+"','"+this.TextBoxfzr.Text.Trim()+"','"+this.TextBox_dwmc.Text.Trim()+"','"+this.TextBox_dz.Text.Trim()+"','"+this.TextBox_sfz.Text.Trim()+"','"+this.TextBox_bh.Text.Trim()+"','"+this.TextBox_yhlx.Text.Trim()+"')";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_user.InsertCommand.CommandText=sql;
			this.sqlDataAdapter_user.InsertCommand.ExecuteNonQuery();
			
			Global.Alert(this,"��ӳɹ�!");
			this.chongzhi();

		     
		}
	}
}
