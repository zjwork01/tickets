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
	/// tongji ��ժҪ˵����
	/// </summary>
	public class tongji : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_tongji;
		protected tickets.DataSet_tongji dataSet_tongji;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_yonghu;
	
		protected System.Data.DataSet dataSet_yh2;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;

	
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection1.ConnectionString=data.connStr;
			// �ڴ˴������û������Գ�ʼ��ҳ��

			string qssj1=Request.QueryString["qssj"];
			string zzsj1=Request.QueryString["zzsj"];
			string cxfs1=Request.QueryString["cxfs"];
			string checi=Request.QueryString["checi"];
            this.xianshijieguo(qssj1,zzsj1,cxfs1,checi);
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
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_tongji = new System.Data.SqlClient.SqlDataAdapter();
			this.dataSet_tongji = new tickets.DataSet_tongji();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_yonghu = new System.Data.SqlClient.SqlDataAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_tongji)).BeginInit();
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ���, ����, ����վ, ����վ, ��λ����, Ʊ��, �ܼ۸�, �û���, ��ϵ��ʽ, ��ַ, ���֤, ��������, ʱ��, �����, ��λ��, ��" +
				"������, ��Ʊ����, ��Ʊ���� FROM dingpiao";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO dingpiao(����, ����վ, ����վ, ��λ����, Ʊ��, �ܼ۸�, �û���, ��ϵ��ʽ, ��ַ, ���֤, ��������, ʱ��, �����, ��λ��, ��������, ��Ʊ����, ��Ʊ����) VALUES (@����, @����վ, @����վ, @��λ����, @Ʊ��, @�ܼ۸�, @�û���, @��ϵ��ʽ, @��ַ, @���֤, @��������, @ʱ��, @�����, @��λ��, @��������, @��Ʊ����, @��Ʊ����); SELECT ���, ����, ����վ, ����վ, ��λ����, Ʊ��, �ܼ۸�, �û���, ��ϵ��ʽ, ��ַ, ���֤, ��������, ʱ��, �����, ��λ��, ��������, ��Ʊ����, ��Ʊ���� FROM dingpiao WHERE (��� = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 10, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����վ", System.Data.SqlDbType.VarChar, 10, "����վ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����վ", System.Data.SqlDbType.VarChar, 10, "����վ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��λ����", System.Data.SqlDbType.VarChar, 10, "��λ����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ʊ��", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ܼ۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ܼ۸�", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�û���", System.Data.SqlDbType.VarChar, 50, "�û���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ϵ��ʽ", System.Data.SqlDbType.VarChar, 20, "��ϵ��ʽ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ַ", System.Data.SqlDbType.VarChar, 50, "��ַ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���֤", System.Data.SqlDbType.VarChar, 20, "���֤"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.DateTime, 8, "��������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ʱ��", System.Data.SqlDbType.DateTime, 8, "ʱ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.Int, 4, "�����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��λ��", System.Data.SqlDbType.Int, 4, "��λ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.VarChar, 10, "��������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��Ʊ����", System.Data.SqlDbType.DateTime, 8, "��Ʊ����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��Ʊ����", System.Data.SqlDbType.VarChar, 10, "��Ʊ����"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE dingpiao SET ���� = @����, ����վ = @����վ, ����վ = @����վ, ��λ���� = @��λ����, Ʊ�� = @Ʊ��, �ܼ۸�" +
				" = @�ܼ۸�, �û��� = @�û���, ��ϵ��ʽ = @��ϵ��ʽ, ��ַ = @��ַ, ���֤ = @���֤, �������� = @��������, ʱ�� = @ʱ��," +
				" ����� = @�����, ��λ�� = @��λ��, �������� = @��������, ��Ʊ���� = @��Ʊ����, ��Ʊ���� = @��Ʊ���� WHERE (��� = " +
				"@Original_���) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL)" +
				" AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL) AND (�������� = " +
				"@Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL) AND (��Ʊ���� = @Original" +
				"_��Ʊ���� OR @Original_��Ʊ���� IS NULL AND ��Ʊ���� IS NULL) AND (��Ʊ���� = @Original_��Ʊ���� O" +
				"R @Original_��Ʊ���� IS NULL AND ��Ʊ���� IS NULL) AND (��ַ = @Original_��ַ OR @Original" +
				"_��ַ IS NULL AND ��ַ IS NULL) AND (��λ�� = @Original_��λ�� OR @Original_��λ�� IS NULL AN" +
				"D ��λ�� IS NULL) AND (��λ���� = @Original_��λ���� OR @Original_��λ���� IS NULL AND ��λ���� IS " +
				"NULL) AND (�ܼ۸� = @Original_�ܼ۸� OR @Original_�ܼ۸� IS NULL AND �ܼ۸� IS NULL) AND (ʱ��" +
				" = @Original_ʱ�� OR @Original_ʱ�� IS NULL AND ʱ�� IS NULL) AND (�û��� = @Original_�û���" +
				" OR @Original_�û��� IS NULL AND �û��� IS NULL) AND (Ʊ�� = @Original_Ʊ�� OR @Original_Ʊ" +
				"�� IS NULL AND Ʊ�� IS NULL) AND (��ϵ��ʽ = @Original_��ϵ��ʽ OR @Original_��ϵ��ʽ IS NULL A" +
				"ND ��ϵ��ʽ IS NULL) AND (���֤ = @Original_���֤ OR @Original_���֤ IS NULL AND ���֤ IS NU" +
				"LL) AND (����� = @Original_����� OR @Original_����� IS NULL AND ����� IS NULL) AND (���� =" +
				" @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (�������� = @Original_��������" +
				" OR @Original_�������� IS NULL AND �������� IS NULL); SELECT ���, ����, ����վ, ����վ, ��λ����, Ʊ��," +
				" �ܼ۸�, �û���, ��ϵ��ʽ, ��ַ, ���֤, ��������, ʱ��, �����, ��λ��, ��������, ��Ʊ����, ��Ʊ���� FROM dingpiao WH" +
				"ERE (��� = @���)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 10, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����վ", System.Data.SqlDbType.VarChar, 10, "����վ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����վ", System.Data.SqlDbType.VarChar, 10, "����վ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��λ����", System.Data.SqlDbType.VarChar, 10, "��λ����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ʊ��", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ܼ۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ܼ۸�", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�û���", System.Data.SqlDbType.VarChar, 50, "�û���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ϵ��ʽ", System.Data.SqlDbType.VarChar, 20, "��ϵ��ʽ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ַ", System.Data.SqlDbType.VarChar, 50, "��ַ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���֤", System.Data.SqlDbType.VarChar, 20, "���֤"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.DateTime, 8, "��������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ʱ��", System.Data.SqlDbType.DateTime, 8, "ʱ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.Int, 4, "�����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��λ��", System.Data.SqlDbType.Int, 4, "��λ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.VarChar, 10, "��������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��Ʊ����", System.Data.SqlDbType.DateTime, 8, "��Ʊ����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��Ʊ����", System.Data.SqlDbType.VarChar, 10, "��Ʊ����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����վ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����վ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����վ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����վ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��Ʊ����", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��Ʊ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��Ʊ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��Ʊ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ַ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ַ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��λ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��λ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��λ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��λ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ܼ۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ܼ۸�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û���", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ��ʽ", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ��ʽ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���֤", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���֤", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Int, 4, "���"));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM dingpiao WHERE (��� = @Original_���) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL) AND (��Ʊ���� = @Original_��Ʊ���� OR @Original_��Ʊ���� IS NULL AND ��Ʊ���� IS NULL) AND (��Ʊ���� = @Original_��Ʊ���� OR @Original_��Ʊ���� IS NULL AND ��Ʊ���� IS NULL) AND (��ַ = @Original_��ַ OR @Original_��ַ IS NULL AND ��ַ IS NULL) AND (��λ�� = @Original_��λ�� OR @Original_��λ�� IS NULL AND ��λ�� IS NULL) AND (��λ���� = @Original_��λ���� OR @Original_��λ���� IS NULL AND ��λ���� IS NULL) AND (�ܼ۸� = @Original_�ܼ۸� OR @Original_�ܼ۸� IS NULL AND �ܼ۸� IS NULL) AND (ʱ�� = @Original_ʱ�� OR @Original_ʱ�� IS NULL AND ʱ�� IS NULL) AND (�û��� = @Original_�û��� OR @Original_�û��� IS NULL AND �û��� IS NULL) AND (Ʊ�� = @Original_Ʊ�� OR @Original_Ʊ�� IS NULL AND Ʊ�� IS NULL) AND (��ϵ��ʽ = @Original_��ϵ��ʽ OR @Original_��ϵ��ʽ IS NULL AND ��ϵ��ʽ IS NULL) AND (���֤ = @Original_���֤ OR @Original_���֤ IS NULL AND ���֤ IS NULL) AND (����� = @Original_����� OR @Original_����� IS NULL AND ����� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����վ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����վ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����վ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����վ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��Ʊ����", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��Ʊ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��Ʊ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��Ʊ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ַ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ַ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��λ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��λ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��λ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��λ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ܼ۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ܼ۸�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û���", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ��ʽ", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ��ʽ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���֤", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���֤", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter_tongji
			// 
			this.sqlDataAdapter_tongji.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_tongji.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter_tongji.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter_tongji.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.sqlDataAdapter_tongji.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// dataSet_tongji
			// 
			this.dataSet_tongji.DataSetName = "DataSet_tongji";
			this.dataSet_tongji.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ���, �û���, ����, ��ϵ��ʽ, ������, ��λȫ��, �����ַ, ���֤, ���۵���, �û����� FROM [user]";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = "INSERT INTO [user] (���, �û���, ����, ��ϵ��ʽ, ������, ��λȫ��, �����ַ, ���֤, ���۵���, �û�����) VALUES " +
				"(@���, @�û���, @����, @��ϵ��ʽ, @������, @��λȫ��, @�����ַ, @���֤, @���۵���, @�û�����); SELECT ���, �û���" +
				", ����, ��ϵ��ʽ, ������, ��λȫ��, �����ַ, ���֤, ���۵���, �û����� FROM [user] WHERE (��� = @���)";
			this.sqlInsertCommand2.Connection = this.sqlConnection1;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Int, 4, "���"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�û���", System.Data.SqlDbType.VarChar, 10, "�û���"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 10, "����"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ϵ��ʽ", System.Data.SqlDbType.VarChar, 50, "��ϵ��ʽ"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������", System.Data.SqlDbType.VarChar, 10, "������"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��λȫ��", System.Data.SqlDbType.VarChar, 50, "��λȫ��"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�����ַ", System.Data.SqlDbType.VarChar, 50, "�����ַ"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���֤", System.Data.SqlDbType.VarChar, 20, "���֤"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���۵���", System.Data.SqlDbType.Int, 4, "���۵���"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�û�����", System.Data.SqlDbType.Int, 4, "�û�����"));
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = @"UPDATE [user] SET ��� = @���, �û��� = @�û���, ���� = @����, ��ϵ��ʽ = @��ϵ��ʽ, ������ = @������, ��λȫ�� = @��λȫ��, �����ַ = @�����ַ, ���֤ = @���֤, ���۵��� = @���۵���, �û����� = @�û����� WHERE (��� = @Original_���) AND (���۵��� = @Original_���۵��� OR @Original_���۵��� IS NULL AND ���۵��� IS NULL) AND (�����ַ = @Original_�����ַ OR @Original_�����ַ IS NULL AND �����ַ IS NULL) AND (��λȫ�� = @Original_��λȫ�� OR @Original_��λȫ�� IS NULL AND ��λȫ�� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (�û��� = @Original_�û��� OR @Original_�û��� IS NULL AND �û��� IS NULL) AND (�û����� = @Original_�û����� OR @Original_�û����� IS NULL AND �û����� IS NULL) AND (��ϵ��ʽ = @Original_��ϵ��ʽ OR @Original_��ϵ��ʽ IS NULL AND ��ϵ��ʽ IS NULL) AND (������ = @Original_������ OR @Original_������ IS NULL AND ������ IS NULL) AND (���֤ = @Original_���֤ OR @Original_���֤ IS NULL AND ���֤ IS NULL); SELECT ���, �û���, ����, ��ϵ��ʽ, ������, ��λȫ��, �����ַ, ���֤, ���۵���, �û����� FROM [user] WHERE (��� = @���)";
			this.sqlUpdateCommand2.Connection = this.sqlConnection1;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Int, 4, "���"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�û���", System.Data.SqlDbType.VarChar, 10, "�û���"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 10, "����"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ϵ��ʽ", System.Data.SqlDbType.VarChar, 50, "��ϵ��ʽ"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������", System.Data.SqlDbType.VarChar, 10, "������"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��λȫ��", System.Data.SqlDbType.VarChar, 50, "��λȫ��"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�����ַ", System.Data.SqlDbType.VarChar, 50, "�����ַ"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���֤", System.Data.SqlDbType.VarChar, 20, "���֤"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���۵���", System.Data.SqlDbType.Int, 4, "���۵���"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�û�����", System.Data.SqlDbType.Int, 4, "�û�����"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���۵���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���۵���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�����ַ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�����ַ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��λȫ��", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��λȫ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û���", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û�����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ��ʽ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ��ʽ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���֤", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���֤", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = @"DELETE FROM [user] WHERE (��� = @Original_���) AND (���۵��� = @Original_���۵��� OR @Original_���۵��� IS NULL AND ���۵��� IS NULL) AND (�����ַ = @Original_�����ַ OR @Original_�����ַ IS NULL AND �����ַ IS NULL) AND (��λȫ�� = @Original_��λȫ�� OR @Original_��λȫ�� IS NULL AND ��λȫ�� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (�û��� = @Original_�û��� OR @Original_�û��� IS NULL AND �û��� IS NULL) AND (�û����� = @Original_�û����� OR @Original_�û����� IS NULL AND �û����� IS NULL) AND (��ϵ��ʽ = @Original_��ϵ��ʽ OR @Original_��ϵ��ʽ IS NULL AND ��ϵ��ʽ IS NULL) AND (������ = @Original_������ OR @Original_������ IS NULL AND ������ IS NULL) AND (���֤ = @Original_���֤ OR @Original_���֤ IS NULL AND ���֤ IS NULL)";
			this.sqlDeleteCommand2.Connection = this.sqlConnection1;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���۵���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���۵���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�����ַ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�����ַ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��λȫ��", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��λȫ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û���", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û�����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ��ʽ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ��ʽ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���֤", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���֤", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter_yonghu
			// 
			this.sqlDataAdapter_yonghu.DeleteCommand = this.sqlDeleteCommand2;
			this.sqlDataAdapter_yonghu.InsertCommand = this.sqlInsertCommand2;
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
			this.sqlDataAdapter_yonghu.UpdateCommand = this.sqlUpdateCommand2;
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_tongji)).EndInit();

		}
		#endregion

		private void xianshijieguo(string qssj,string zzsj,string cxfs,string checi)
		{  
		
			if(cxfs=="1")
			{
			   this.sqlDataAdapter_tongji.SelectCommand.CommandText="select ����,  sum(Ʊ��)Ʊ�� ,sum(�ܼ۸�)�ܼ۸� from dingpiao where ����='"+checi+"'and ��Ʊ����>='"+qssj+"'and ��Ʊ����<='"+zzsj+"' group by ����";
			    if(this.sqlConnection1.State.ToString()=="closed")
				 this.sqlConnection1.Open();
				this.sqlDataAdapter_tongji.Fill(this.dataSet_tongji);
				this.DataGrid1.DataBind();
				this.DataGrid1.Visible=true;
				


			}
			if(cxfs=="3")
			{
				this.sqlDataAdapter_tongji.SelectCommand.CommandText="select  ����, sum(Ʊ��)Ʊ�� ,sum(�ܼ۸�)�ܼ۸� from dingpiao where ��Ʊ����>='"+qssj+"'and ��Ʊ����<='"+zzsj+"' group by ���� ";
				if(this.sqlConnection1.State.ToString()=="closed")
					this.sqlConnection1.Open();
				this.sqlDataAdapter_tongji.Fill(this.dataSet_tongji);
				this.DataGrid1.DataBind();
				this.DataGrid1.Visible=true;
			   
			}
		}
	
	}
}
