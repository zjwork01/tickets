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
	/// dingpiaopiaoju ��ժҪ˵����
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
			// �ڴ˴������û������Գ�ʼ��ҳ��
			string cc=Request.QueryString["checi"];
            this.TextBox_cc.Text=cc;
		

			this.dsdmc();
          
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
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ���, �û���, ����, ��ϵ��ʽ, ������, ��λȫ��, �����ַ, ���֤, ���۵���, �û����� FROM [user]";
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
																																																					  new System.Data.Common.DataColumnMapping("���", "���"),
																																																					  new System.Data.Common.DataColumnMapping("����", "����"),
																																																					  new System.Data.Common.DataColumnMapping("����վ", "����վ"),
																																																					  new System.Data.Common.DataColumnMapping("����վ", "����վ"),
																																																					  new System.Data.Common.DataColumnMapping("��λ����", "��λ����"),
																																																					  new System.Data.Common.DataColumnMapping("Ʊ��", "Ʊ��"),
																																																					  new System.Data.Common.DataColumnMapping("�ܼ۸�", "�ܼ۸�"),
																																																					  new System.Data.Common.DataColumnMapping("�û���", "�û���"),
																																																					  new System.Data.Common.DataColumnMapping("��ϵ��ʽ", "��ϵ��ʽ"),
																																																					  new System.Data.Common.DataColumnMapping("��ַ", "��ַ"),
																																																					  new System.Data.Common.DataColumnMapping("���֤", "���֤"),
																																																					  new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																					  new System.Data.Common.DataColumnMapping("ʱ��", "ʱ��"),
																																																					  new System.Data.Common.DataColumnMapping("�����", "�����"),
																																																					  new System.Data.Common.DataColumnMapping("��λ��", "��λ��"),
																																																					  new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																					  new System.Data.Common.DataColumnMapping("��Ʊ����", "��Ʊ����"),
																																																					  new System.Data.Common.DataColumnMapping("��Ʊ����", "��Ʊ����"),
																																																					  new System.Data.Common.DataColumnMapping("�Ƿ�ѧ��Ʊ", "�Ƿ�ѧ��Ʊ")})});
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ���, ����, ����վ, ����վ, ��λ����, Ʊ��, �ܼ۸�, �û���, ��ϵ��ʽ, ��ַ, ���֤, ��������, ʱ��, �����, ��λ��, ��" +
				"������, ��Ʊ����, ��Ʊ����, �Ƿ�ѧ��Ʊ FROM dingpiao";
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
			
			this.sqlDataAdapter1.SelectCommand.CommandText="select * from [user] where �û���='"+Session["username"]+"'";
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
		this.RegisterStartupScript("��Ʊ�굥","<script  language='javascript'> print();</script>");
		}
	}
}
