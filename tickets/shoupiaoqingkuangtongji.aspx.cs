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
	/// shoupiaoqingkuangtongji ��ժҪ˵����
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
			// �ڴ˴������û������Գ�ʼ��ҳ��
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

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
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
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
																																																						  new System.Data.Common.DataColumnMapping("��Ʊ����", "��Ʊ����")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ���, ����, ����վ, ����վ, ��λ����, Ʊ��, �ܼ۸�, �û���, ��ϵ��ʽ, ��ַ, ���֤, ��������, ʱ��, �����, ��λ��, ��" +
				"������, ��Ʊ����, ��Ʊ���� FROM dingpiao";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// dataSet_dingpiao
			// 
			this.dataSet_dingpiao.DataSetName = "DataSet_dingpiao";
			this.dataSet_dingpiao.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ���, �û���, ����, ��ϵ��ʽ, ������, ��λȫ��, �����ַ, ���֤, ���۵���, �û����� FROM [user]";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO [user] (���, �û���, ����, ��ϵ��ʽ, ������, ��λȫ��, �����ַ, ���֤, ���۵���, �û�����) VALUES " +
				"(@���, @�û���, @����, @��ϵ��ʽ, @������, @��λȫ��, @�����ַ, @���֤, @���۵���, @�û�����); SELECT ���, �û���" +
				", ����, ��ϵ��ʽ, ������, ��λȫ��, �����ַ, ���֤, ���۵���, �û����� FROM [user] WHERE (��� = @���)";
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
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE [user] SET ��� = @���, �û��� = @�û���, ���� = @����, ��ϵ��ʽ = @��ϵ��ʽ, ������ = @������, ��λȫ�� = @��λȫ��, �����ַ = @�����ַ, ���֤ = @���֤, ���۵��� = @���۵���, �û����� = @�û����� WHERE (��� = @Original_���) AND (���۵��� = @Original_���۵��� OR @Original_���۵��� IS NULL AND ���۵��� IS NULL) AND (�����ַ = @Original_�����ַ OR @Original_�����ַ IS NULL AND �����ַ IS NULL) AND (��λȫ�� = @Original_��λȫ�� OR @Original_��λȫ�� IS NULL AND ��λȫ�� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (�û��� = @Original_�û��� OR @Original_�û��� IS NULL AND �û��� IS NULL) AND (�û����� = @Original_�û����� OR @Original_�û����� IS NULL AND �û����� IS NULL) AND (��ϵ��ʽ = @Original_��ϵ��ʽ OR @Original_��ϵ��ʽ IS NULL AND ��ϵ��ʽ IS NULL) AND (������ = @Original_������ OR @Original_������ IS NULL AND ������ IS NULL) AND (���֤ = @Original_���֤ OR @Original_���֤ IS NULL AND ���֤ IS NULL); SELECT ���, �û���, ����, ��ϵ��ʽ, ������, ��λȫ��, �����ַ, ���֤, ���۵���, �û����� FROM [user] WHERE (��� = @���)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Int, 4, "���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�û���", System.Data.SqlDbType.VarChar, 10, "�û���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 10, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ϵ��ʽ", System.Data.SqlDbType.VarChar, 50, "��ϵ��ʽ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������", System.Data.SqlDbType.VarChar, 10, "������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��λȫ��", System.Data.SqlDbType.VarChar, 50, "��λȫ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�����ַ", System.Data.SqlDbType.VarChar, 50, "�����ַ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���֤", System.Data.SqlDbType.VarChar, 20, "���֤"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���۵���", System.Data.SqlDbType.Int, 4, "���۵���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�û�����", System.Data.SqlDbType.Int, 4, "�û�����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���۵���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���۵���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�����ַ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�����ַ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��λȫ��", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��λȫ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û���", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û�����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ��ʽ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ��ʽ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���֤", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���֤", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM [user] WHERE (��� = @Original_���) AND (���۵��� = @Original_���۵��� OR @Original_���۵��� IS NULL AND ���۵��� IS NULL) AND (�����ַ = @Original_�����ַ OR @Original_�����ַ IS NULL AND �����ַ IS NULL) AND (��λȫ�� = @Original_��λȫ�� OR @Original_��λȫ�� IS NULL AND ��λȫ�� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (�û��� = @Original_�û��� OR @Original_�û��� IS NULL AND �û��� IS NULL) AND (�û����� = @Original_�û����� OR @Original_�û����� IS NULL AND �û����� IS NULL) AND (��ϵ��ʽ = @Original_��ϵ��ʽ OR @Original_��ϵ��ʽ IS NULL AND ��ϵ��ʽ IS NULL) AND (������ = @Original_������ OR @Original_������ IS NULL AND ������ IS NULL) AND (���֤ = @Original_���֤ OR @Original_���֤ IS NULL AND ���֤ IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���۵���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���۵���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�����ַ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�����ַ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��λȫ��", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��λȫ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û���", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û�����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ��ʽ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ��ʽ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���֤", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���֤", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter_yonghu
			// 
			this.sqlDataAdapter_yonghu.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_yonghu.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter_yonghu.SelectCommand = this.sqlSelectCommand2;
			this.sqlDataAdapter_yonghu.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			if(this.Dl_cxfs.SelectedItem.Text.Trim()=="������")
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
			if(this.DropDownList_tjfs.SelectedItem.Text.Trim()=="��¼"&&this.Dl_cxfs.SelectedItem.Text.Trim()=="��ѯ����")
			{
				this.sqlDataAdapter_dingpiao.SelectCommand.CommandText="select * from  dingpiao  where ��Ʊ����>='"+qssj+"' and   ��Ʊ����<='"+zzsj+"'";
				if(this.sqlConnection1.State.ToString()=="closed")
					this.sqlConnection1.Open();
				this.sqlDataAdapter_dingpiao.Fill(this.dataSet_dingpiao);
				this.DataGrid1.DataBind();
				this.DataGrid1.Visible=true;
				this.qssj.Text=qssj;
				this.jzsj.Text=zzsj;
                            
			}

			if(this.DropDownList_tjfs.SelectedItem.Text.Trim()=="��¼"&&this.Dl_cxfs.SelectedItem.Text.Trim()=="������")
			{
				this.TextBox_checi.Enabled=true;
				this.sqlDataAdapter_dingpiao.SelectCommand.CommandText="select * from  dingpiao  where ��Ʊ����>='"+qssj+"' and   ��Ʊ����<='"+zzsj+"'and ����='"+this.TextBox_checi.Text.Trim()+"' ";
				if(this.sqlConnection1.State.ToString()=="closed")
					this.sqlConnection1.Open();
				this.sqlDataAdapter_dingpiao.Fill(this.dataSet_dingpiao);
				this.DataGrid1.DataBind();
				this.DataGrid1.Visible=true;
				this.qssj.Text=qssj;
				this.jzsj.Text=zzsj;
                            
			}

			if(this.DropDownList_tjfs.SelectedItem.Text.Trim()=="��¼"&&this.Dl_cxfs.SelectedItem.Text.Trim()=="����Ʊ��")
			{  
				
				this.sqlDataAdapter_dingpiao.SelectCommand.CommandText="select * from  dingpiao  where ��Ʊ����>='"+qssj+"' and   ��Ʊ����<='"+zzsj+"'and ��Ʊ����='"+this.dsdbh.Text.Trim()+"' ";
				if(this.sqlConnection1.State.ToString()=="closed")
					this.sqlConnection1.Open();
				this.sqlDataAdapter_dingpiao.Fill(this.dataSet_dingpiao);
				this.DataGrid1.DataBind();
				this.DataGrid1.Visible=true;
				this.qssj.Text=qssj;
				this.jzsj.Text=zzsj;
                            
			}
		
			if(this.DropDownList_tjfs.SelectedItem.Text.Trim()=="�ϼ�"&&this.Dl_cxfs.SelectedItem.Text.Trim()=="������")
			{  string cxfs="1";
				string qssj1=this.Dl_nian.SelectedItem.Text.Trim()+"-"+this.Dl_yue.SelectedItem.Text.Trim()+"-"+this.Dl_ri.SelectedItem.Text.Trim();
				string zzsj1=this.Dl_nian1.SelectedItem.Text.Trim()+"-"+this.Dl_yue1.SelectedItem.Text.Trim()+"-"+this.Dl_ri1.SelectedItem.Text.Trim();
			    string checi=this.TextBox_checi.Text.Trim();
				string canshu="cxfs="+cxfs+"&qssj="+qssj+"&zzsj="+zzsj+"&checi="+checi;
				string msg;
				msg  = "<script language='javascript'>";
				msg +="window.open ('tongji.aspx?"+canshu+"','��Ʊ���ͳ��','height=200,width=700,top=150,left=100,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')"; 
				msg +="</script>";
				this.RegisterStartupScript("��Ʊ���ͳ��",msg);
			}
			if(this.DropDownList_tjfs.SelectedItem.Text.Trim()=="�ϼ�"&&this.Dl_cxfs.SelectedItem.Text.Trim()=="����Ʊ��")
			{
				
				string qssj1=this.Dl_nian.SelectedItem.Text.Trim()+"-"+this.Dl_yue.SelectedItem.Text.Trim()+"-"+this.Dl_ri.SelectedItem.Text.Trim();
				string zzsj1=this.Dl_nian1.SelectedItem.Text.Trim()+"-"+this.Dl_yue1.SelectedItem.Text.Trim()+"-"+this.Dl_ri1.SelectedItem.Text.Trim();
				
				string canshu="qssj="+qssj+"&zzsj="+zzsj;
				string msg;
				msg  = "<script language='javascript'>";
				msg +="window.open ('tongji2.aspx?"+canshu+"','��Ʊ���ͳ��','height=200,width=700,top=150,left=100,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')"; 
				msg +="</script>";
				this.RegisterStartupScript("��Ʊ���ͳ��",msg);
			}
		
			if(this.DropDownList_tjfs.SelectedItem.Text.Trim()=="�ϼ�"&&this.Dl_cxfs.SelectedItem.Text.Trim()=="��ѯ����")
			{
				string cxfs="3";
				string qssj1=this.Dl_nian.SelectedItem.Text.Trim()+"-"+this.Dl_yue.SelectedItem.Text.Trim()+"-"+this.Dl_ri.SelectedItem.Text.Trim();
				string zzsj1=this.Dl_nian1.SelectedItem.Text.Trim()+"-"+this.Dl_yue1.SelectedItem.Text.Trim()+"-"+this.Dl_ri1.SelectedItem.Text.Trim();
			
				string canshu="cxfs="+cxfs+"&qssj="+qssj+"&zzsj="+zzsj;
				string msg;
				msg  = "<script language='javascript'>";
				msg +="window.open ('tongji.aspx?"+canshu+"','��Ʊ���ͳ��','height=200,width=700,top=150,left=100,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')"; 
				msg +="</script>";
				this.RegisterStartupScript("��Ʊ���ͳ��",msg);
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
			msg +="window.open ('xinwenguanli.aspx?"+canshu+"','����','height=500,width=750,top=50,left=50,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')"; 
			msg +="</script>";
			this.RegisterStartupScript("����",msg);
		}

		private void Linkbutton_xxfk_Click(object sender, System.EventArgs e)
		{
			string canshu="checi=123";
			string msg;
			msg  = "<script language='javascript'>";
			msg +="window.open ('guanliliuyan.aspx?"+canshu+"','����','height=500,width=720,top=50,left=50,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')"; 
			msg +="</script>";
			this.RegisterStartupScript("����",msg);
		}
	}
}
