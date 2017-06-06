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
	/// piaoju ��ժҪ˵����
	/// </summary>
	public class piaoju : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label n;
		protected System.Web.UI.WebControls.Label y;
		protected System.Web.UI.WebControls.Label r;
		protected System.Web.UI.WebControls.Label cxh;
		protected System.Web.UI.WebControls.Label zw;
		protected System.Web.UI.WebControls.Label jiege;
		protected System.Web.UI.WebControls.Label Lb_checi;
		protected System.Web.UI.WebControls.Label Label_qsz;
		protected System.Web.UI.WebControls.Label Lb_zdz;
		protected System.Web.UI.WebControls.Label Label_cllx;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label kcsj;
		protected System.Web.UI.WebControls.Label kt;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_tickets;
		protected tickets.DataSet_cllx dataSet_cllx;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Web.UI.WebControls.Label x;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_dingpiao;
		protected tickets.DataSet_dingp dataSet_dingp;
		protected System.Web.UI.WebControls.Button Button_dy;
		protected tickets.DataSet_kt dataSet_kt;
		protected System.Web.UI.WebControls.Label zwlx;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			this.sqlConnection1.ConnectionString=data.connStr;
	
			this.xianshichepiao();
			this.xianshikt();
		   
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
			this.sqlDataAdapter_tickets = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dataSet_cllx = new tickets.DataSet_cllx();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_dingpiao = new System.Data.SqlClient.SqlDataAdapter();
			this.dataSet_dingp = new tickets.DataSet_dingp();
			this.dataSet_kt = new tickets.DataSet_kt();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_cllx)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_dingp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_kt)).BeginInit();
			this.Button_dy.Click += new System.EventHandler(this.Button_dy_Click);
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlDataAdapter_tickets
			// 
			this.sqlDataAdapter_tickets.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter_tickets.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																											 new System.Data.Common.DataTableMapping("Table", "tickets", new System.Data.Common.DataColumnMapping[] {
																																																						new System.Data.Common.DataColumnMapping("���", "���"),
																																																						new System.Data.Common.DataColumnMapping("����", "����"),
																																																						new System.Data.Common.DataColumnMapping("ʼ��վ", "ʼ��վ"),
																																																						new System.Data.Common.DataColumnMapping("�յ�վ", "�յ�վ"),
																																																						new System.Data.Common.DataColumnMapping("����ʱ��", "����ʱ��"),
																																																						new System.Data.Common.DataColumnMapping("����ʱ��", "����ʱ��"),
																																																						new System.Data.Common.DataColumnMapping("Ӳ��Ʊ��", "Ӳ��Ʊ��"),
																																																						new System.Data.Common.DataColumnMapping("Ӳ����Ʊ��", "Ӳ����Ʊ��"),
																																																						new System.Data.Common.DataColumnMapping("Ӳ����Ʊ��", "Ӳ����Ʊ��"),
																																																						new System.Data.Common.DataColumnMapping("Ӳ����Ʊ��", "Ӳ����Ʊ��"),
																																																						new System.Data.Common.DataColumnMapping("������Ʊ��", "������Ʊ��"),
																																																						new System.Data.Common.DataColumnMapping("������Ʊ��", "������Ʊ��"),
																																																						new System.Data.Common.DataColumnMapping("������Ʊ��", "������Ʊ��"),
																																																						new System.Data.Common.DataColumnMapping("���޿յ�", "���޿յ�"),
																																																						new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																						new System.Data.Common.DataColumnMapping("Ӳ��������", "Ӳ��������"),
																																																						new System.Data.Common.DataColumnMapping("Ӳ����������", "Ӳ����������"),
																																																						new System.Data.Common.DataColumnMapping("Ӳ�Գ�����", "Ӳ�Գ�����"),
																																																						new System.Data.Common.DataColumnMapping("Ӳ�Գ�������", "Ӳ�Գ�������"),
																																																						new System.Data.Common.DataColumnMapping("���Գ�����", "���Գ�����"),
																																																						new System.Data.Common.DataColumnMapping("���Գ�������", "���Գ�������")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ���, ����, ʼ��վ, �յ�վ, ����ʱ��, ����ʱ��, Ӳ��Ʊ��, Ӳ����Ʊ��, Ӳ����Ʊ��, Ӳ����Ʊ��, ������Ʊ��, ������Ʊ��, ������" +
				"Ʊ��, ���޿յ�, ��������, Ӳ��������, Ӳ����������, Ӳ�Գ�����, Ӳ�Գ�������, ���Գ�����, ���Գ������� FROM tickets";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// dataSet_cllx
			// 
			this.dataSet_cllx.DataSetName = "DataSet_cllx";
			this.dataSet_cllx.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ���, ����, ����վ, ����վ, ��λ����, Ʊ��, �ܼ۸�, �û���, ��ϵ��ʽ, ��ַ, ���֤, ��������, ʱ��, �����, ��λ��, ��" +
				"������, ��Ʊ����, ��Ʊ����, �Ƿ�ѧ��Ʊ FROM dingpiao";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO dingpiao(����, ����վ, ����վ, ��λ����, Ʊ��, �ܼ۸�, �û���, ��ϵ��ʽ, ��ַ, ���֤, ��������, ʱ��, �����, ��λ��, ��������, ��Ʊ����, ��Ʊ����, �Ƿ�ѧ��Ʊ) VALUES (@����, @����վ, @����վ, @��λ����, @Ʊ��, @�ܼ۸�, @�û���, @��ϵ��ʽ, @��ַ, @���֤, @��������, @ʱ��, @�����, @��λ��, @��������, @��Ʊ����, @��Ʊ����, @�Ƿ�ѧ��Ʊ); SELECT ���, ����, ����վ, ����վ, ��λ����, Ʊ��, �ܼ۸�, �û���, ��ϵ��ʽ, ��ַ, ���֤, ��������, ʱ��, �����, ��λ��, ��������, ��Ʊ����, ��Ʊ����, �Ƿ�ѧ��Ʊ FROM dingpiao WHERE (��� = @@IDENTITY)";
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
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ƿ�ѧ��Ʊ", System.Data.SqlDbType.VarChar, 10, "�Ƿ�ѧ��Ʊ"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE dingpiao SET ���� = @����, ����վ = @����վ, ����վ = @����վ, ��λ���� = @��λ����, Ʊ�� = @Ʊ��, �ܼ۸�" +
				" = @�ܼ۸�, �û��� = @�û���, ��ϵ��ʽ = @��ϵ��ʽ, ��ַ = @��ַ, ���֤ = @���֤, �������� = @��������, ʱ�� = @ʱ��," +
				" ����� = @�����, ��λ�� = @��λ��, �������� = @��������, ��Ʊ���� = @��Ʊ����, ��Ʊ���� = @��Ʊ����, �Ƿ�ѧ��Ʊ = @�Ƿ�" +
				"ѧ��Ʊ WHERE (��� = @Original_���) AND (����վ = @Original_����վ OR @Original_����վ IS NULL " +
				"AND ����վ IS NULL) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NU" +
				"LL) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL) AND (" +
				"��Ʊ���� = @Original_��Ʊ���� OR @Original_��Ʊ���� IS NULL AND ��Ʊ���� IS NULL) AND (��Ʊ���� = @" +
				"Original_��Ʊ���� OR @Original_��Ʊ���� IS NULL AND ��Ʊ���� IS NULL) AND (��ַ = @Original" +
				"_��ַ OR @Original_��ַ IS NULL AND ��ַ IS NULL) AND (��λ�� = @Original_��λ�� OR @Origina" +
				"l_��λ�� IS NULL AND ��λ�� IS NULL) AND (��λ���� = @Original_��λ���� OR @Original_��λ���� IS N" +
				"ULL AND ��λ���� IS NULL) AND (�ܼ۸� = @Original_�ܼ۸� OR @Original_�ܼ۸� IS NULL AND �ܼ۸� " +
				"IS NULL) AND (ʱ�� = @Original_ʱ�� OR @Original_ʱ�� IS NULL AND ʱ�� IS NULL) AND (�Ƿ�ѧ" +
				"��Ʊ = @Original_�Ƿ�ѧ��Ʊ OR @Original_�Ƿ�ѧ��Ʊ IS NULL AND �Ƿ�ѧ��Ʊ IS NULL) AND (�û��� = @O" +
				"riginal_�û��� OR @Original_�û��� IS NULL AND �û��� IS NULL) AND (Ʊ�� = @Original_Ʊ�� OR " +
				"@Original_Ʊ�� IS NULL AND Ʊ�� IS NULL) AND (��ϵ��ʽ = @Original_��ϵ��ʽ OR @Original_��ϵ��" +
				"ʽ IS NULL AND ��ϵ��ʽ IS NULL) AND (���֤ = @Original_���֤ OR @Original_���֤ IS NULL AN" +
				"D ���֤ IS NULL) AND (����� = @Original_����� OR @Original_����� IS NULL AND ����� IS NULL" +
				") AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (�������� = @Or" +
				"iginal_�������� OR @Original_�������� IS NULL AND �������� IS NULL); SELECT ���, ����, ����վ, ����վ" +
				", ��λ����, Ʊ��, �ܼ۸�, �û���, ��ϵ��ʽ, ��ַ, ���֤, ��������, ʱ��, �����, ��λ��, ��������, ��Ʊ����, ��Ʊ����, �Ƿ�ѧ��" +
				"Ʊ FROM dingpiao WHERE (��� = @���)";
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
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ƿ�ѧ��Ʊ", System.Data.SqlDbType.VarChar, 10, "�Ƿ�ѧ��Ʊ"));
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
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�ѧ��Ʊ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�Ƿ�ѧ��Ʊ", System.Data.DataRowVersion.Original, null));
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
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM dingpiao WHERE (��� = @Original_���) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL) AND (��Ʊ���� = @Original_��Ʊ���� OR @Original_��Ʊ���� IS NULL AND ��Ʊ���� IS NULL) AND (��Ʊ���� = @Original_��Ʊ���� OR @Original_��Ʊ���� IS NULL AND ��Ʊ���� IS NULL) AND (��ַ = @Original_��ַ OR @Original_��ַ IS NULL AND ��ַ IS NULL) AND (��λ�� = @Original_��λ�� OR @Original_��λ�� IS NULL AND ��λ�� IS NULL) AND (��λ���� = @Original_��λ���� OR @Original_��λ���� IS NULL AND ��λ���� IS NULL) AND (�ܼ۸� = @Original_�ܼ۸� OR @Original_�ܼ۸� IS NULL AND �ܼ۸� IS NULL) AND (ʱ�� = @Original_ʱ�� OR @Original_ʱ�� IS NULL AND ʱ�� IS NULL) AND (�Ƿ�ѧ��Ʊ = @Original_�Ƿ�ѧ��Ʊ OR @Original_�Ƿ�ѧ��Ʊ IS NULL AND �Ƿ�ѧ��Ʊ IS NULL) AND (�û��� = @Original_�û��� OR @Original_�û��� IS NULL AND �û��� IS NULL) AND (Ʊ�� = @Original_Ʊ�� OR @Original_Ʊ�� IS NULL AND Ʊ�� IS NULL) AND (��ϵ��ʽ = @Original_��ϵ��ʽ OR @Original_��ϵ��ʽ IS NULL AND ��ϵ��ʽ IS NULL) AND (���֤ = @Original_���֤ OR @Original_���֤ IS NULL AND ���֤ IS NULL) AND (����� = @Original_����� OR @Original_����� IS NULL AND ����� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL)";
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
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�ѧ��Ʊ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�Ƿ�ѧ��Ʊ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û���", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ��ʽ", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ��ʽ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���֤", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���֤", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter_dingpiao
			// 
			this.sqlDataAdapter_dingpiao.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_dingpiao.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter_dingpiao.SelectCommand = this.sqlSelectCommand2;
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
																																																						  new System.Data.Common.DataColumnMapping("��Ʊ����", "��Ʊ����"),
																																																						  new System.Data.Common.DataColumnMapping("�Ƿ�ѧ��Ʊ", "�Ƿ�ѧ��Ʊ")})});
			this.sqlDataAdapter_dingpiao.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// dataSet_dingp
			// 
			this.dataSet_dingp.DataSetName = "DataSet_dingp";
			this.dataSet_dingp.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// dataSet_kt
			// 
			this.dataSet_kt.DataSetName = "DataSet_kt";
			this.dataSet_kt.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_cllx)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_dingp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_kt)).EndInit();

		}
		#endregion
		private void xianshichepiao()
		{
		  this.sqlDataAdapter_dingpiao.SelectCommand.CommandText="select * from dingpiao ";
			if(this.sqlConnection1.State.ToString()=="closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_dingpiao.Fill(this.dataSet_dingp);
			int count=this.dataSet_dingp.Tables[0].Rows.Count-1;
			this.Label_qsz.Text=this.dataSet_dingp.Tables[0].Rows[count][2].ToString().Trim();
			this.Lb_zdz.Text=this.dataSet_dingp.Tables[0].Rows[count][3].ToString().Trim();
			this.Lb_checi.Text=this.dataSet_dingp.Tables[0].Rows[count][1].ToString().Trim();
			this.n.Text=DateTime.Parse(this.dataSet_dingp.Tables[0].Rows[count][11].ToString()).Year.ToString().Trim();
			this.y.Text=DateTime.Parse(this.dataSet_dingp.Tables[0].Rows[count][11].ToString()).Month.ToString().Trim();
			this.r.Text=DateTime.Parse(this.dataSet_dingp.Tables[0].Rows[count][11].ToString()).Day.ToString().Trim();
			this.kcsj.Text=DateTime.Parse(this.dataSet_dingp.Tables[0].Rows[count][12].ToString()).Hour+":"+DateTime.Parse(this.dataSet_dingp.Tables[0].Rows[count][12].ToString()).Minute;
			this.cxh.Text=this.dataSet_dingp.Tables[0].Rows[count][13].ToString().Trim();
			this.zw.Text=this.dataSet_dingp.Tables[0].Rows[count][14].ToString().Trim();
			this.jiege.Text=this.dataSet_dingp.Tables[0].Rows[count][6].ToString().Trim();
			this.zwlx.Text=this.dataSet_dingp.Tables[0].Rows[count][4].ToString().Substring(0,2);
			this.Label_cllx.Text=this.dataSet_dingp.Tables[0].Rows[count][15].ToString().Trim()+"�г�";
			if(this.dataSet_dingp.Tables[0].Rows[count][18].ToString().Trim()=="��")
				this.x.Text="ѧ";
			else this.x.Text="";
		
		}
		private void xianshikt()
		{
		   
			this.sqlDataAdapter_tickets.SelectCommand.CommandText="select * from  tickets where ����='"+this.Lb_checi.Text.Trim()+"'";
			if(this.sqlConnection1.State.ToString()=="closed")
				this.sqlConnection1.Open();
			
			this.sqlDataAdapter_tickets.Fill(this.dataSet_kt);
			int ct=this.dataSet_kt.Tables[0].Rows.Count;
			this.kt.Text=this.dataSet_kt.Tables[0].Rows[0][13].ToString().Trim();
		}

		private void Button_dy_Click(object sender, System.EventArgs e)
		{
			this.RegisterStartupScript("��Ʊ�굥","<script  language='javascript'> print();</script>");
		}
	
		
	}



}
