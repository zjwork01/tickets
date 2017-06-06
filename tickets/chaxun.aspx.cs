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
	/// chaxun ��ժҪ˵����
	/// </summary>
	public class chaxun : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button_maipiao;
		protected System.Web.UI.WebControls.Button Button_dingpiao;
		protected System.Web.UI.WebControls.Button Button_tuipiao;
		protected System.Web.UI.WebControls.Button Button_chaxun;
		protected System.Web.UI.WebControls.Button Button_yhgl;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.Button Button_cxcx;
		protected System.Web.UI.WebControls.Button Button_chaxun1;
		protected System.Web.UI.WebControls.Button Button_chaxun2;
		protected System.Web.UI.WebControls.TextBox TextBox_checi;
		protected System.Web.UI.WebControls.TextBox TextBox_qsz;
		protected System.Web.UI.WebControls.TextBox TextBox_zdz;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		private string sql;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_ticketsinf;
		private string type;
		private string begin;
		private string  end;
	    private	string lscc;
		protected System.Data.DataSet dsbegin;
		protected System.Data.DataSet dsend;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_tickets;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected tickets.DataSet_chaxun1 dataSet_chaxun1;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Label Label_LLQ;
		protected System.Web.UI.WebControls.Label Label_IP;
		protected System.Data.DataSet dschaxun;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection1.ConnectionString=data.connStr;
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if(Session["username"].ToString()=="admin")
				this.Button_yhgl.Visible=true;
			else  this.Button_yhgl.Visible=false;
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
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_ticketsinf = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDataAdapter_tickets = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.dataSet_chaxun1 = new tickets.DataSet_chaxun1();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_chaxun1)).BeginInit();
			this.Button_maipiao.Click += new System.EventHandler(this.Button_maipiao_Click);
			this.Button_dingpiao.Click += new System.EventHandler(this.Button_dingpiao_Click);
			this.Button_tuipiao.Click += new System.EventHandler(this.Button_tuipiao_Click);
			this.Button_chaxun.Click += new System.EventHandler(this.Button_chaxun_Click);
			this.Button_yhgl.Click += new System.EventHandler(this.Button_yhgl_Click);
			this.Button_cxcx.Click += new System.EventHandler(this.Button1_Click);
			this.Button_chaxun1.Click += new System.EventHandler(this.Button_chaxun1_Click);
			this.Button_chaxun2.Click += new System.EventHandler(this.Button3_Click);
			this.DataGrid1.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_ItemCommand);
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ���, ����, ����ʱ��, ����ʱ��, ����վ, ����վ, Ӳ��Ʊ��, Ӳ��Ʊ��, ����Ʊ�� FROM ticketsinf";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO ticketsinf(���, ����, ����ʱ��, ����ʱ��, ����վ, ����վ, Ӳ��Ʊ��, Ӳ��Ʊ��, ����Ʊ��) VALUES (@��" +
				"��, @����, @����ʱ��, @����ʱ��, @����վ, @����վ, @Ӳ��Ʊ��, @Ӳ��Ʊ��, @����Ʊ��); SELECT ���, ����, ����ʱ��, ����ʱ" +
				"��, ����վ, ����վ, Ӳ��Ʊ��, Ӳ��Ʊ��, ����Ʊ�� FROM ticketsinf WHERE (��� = @���)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 18, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����վ", System.Data.SqlDbType.VarChar, 50, "����վ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����վ", System.Data.SqlDbType.VarChar, 50, "����վ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "����Ʊ��", System.Data.DataRowVersion.Current, null));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE ticketsinf SET ��� = @���, ���� = @����, ����ʱ�� = @����ʱ��, ����ʱ�� = @����ʱ��, ����վ = @����վ, ����վ = @����վ, Ӳ��Ʊ�� = @Ӳ��Ʊ��, Ӳ��Ʊ�� = @Ӳ��Ʊ��, ����Ʊ�� = @����Ʊ�� WHERE (��� = @Original_���) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL) AND (����ʱ�� = @Original_����ʱ�� OR @Original_����ʱ�� IS NULL AND ����ʱ�� IS NULL) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL) AND (����ʱ�� = @Original_����ʱ�� OR @Original_����ʱ�� IS NULL AND ����ʱ�� IS NULL) AND (Ӳ��Ʊ�� = @Original_Ӳ��Ʊ�� OR @Original_Ӳ��Ʊ�� IS NULL AND Ӳ��Ʊ�� IS NULL) AND (Ӳ��Ʊ�� = @Original_Ӳ��Ʊ�� OR @Original_Ӳ��Ʊ�� IS NULL AND Ӳ��Ʊ�� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (����Ʊ�� = @Original_����Ʊ�� OR @Original_����Ʊ�� IS NULL AND ����Ʊ�� IS NULL); SELECT ���, ����, ����ʱ��, ����ʱ��, ����վ, ����վ, Ӳ��Ʊ��, Ӳ��Ʊ��, ����Ʊ�� FROM ticketsinf WHERE (��� = @���)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 18, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����վ", System.Data.SqlDbType.VarChar, 50, "����վ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����վ", System.Data.SqlDbType.VarChar, 50, "����վ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "����Ʊ��", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����վ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����վ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����վ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����վ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "����Ʊ��", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM ticketsinf WHERE (��� = @Original_���) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL) AND (����ʱ�� = @Original_����ʱ�� OR @Original_����ʱ�� IS NULL AND ����ʱ�� IS NULL) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL) AND (����ʱ�� = @Original_����ʱ�� OR @Original_����ʱ�� IS NULL AND ����ʱ�� IS NULL) AND (Ӳ��Ʊ�� = @Original_Ӳ��Ʊ�� OR @Original_Ӳ��Ʊ�� IS NULL AND Ӳ��Ʊ�� IS NULL) AND (Ӳ��Ʊ�� = @Original_Ӳ��Ʊ�� OR @Original_Ӳ��Ʊ�� IS NULL AND Ӳ��Ʊ�� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (����Ʊ�� = @Original_����Ʊ�� OR @Original_����Ʊ�� IS NULL AND ����Ʊ�� IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����վ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����վ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����վ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����վ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "����Ʊ��", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter_ticketsinf
			// 
			this.sqlDataAdapter_ticketsinf.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_ticketsinf.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter_ticketsinf.SelectCommand = this.sqlSelectCommand2;
			this.sqlDataAdapter_ticketsinf.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																												new System.Data.Common.DataTableMapping("Table", "ticketsinf", new System.Data.Common.DataColumnMapping[] {
																																																							  new System.Data.Common.DataColumnMapping("���", "���"),
																																																							  new System.Data.Common.DataColumnMapping("����", "����"),
																																																							  new System.Data.Common.DataColumnMapping("����ʱ��", "����ʱ��"),
																																																							  new System.Data.Common.DataColumnMapping("����ʱ��", "����ʱ��"),
																																																							  new System.Data.Common.DataColumnMapping("����վ", "����վ"),
																																																							  new System.Data.Common.DataColumnMapping("����վ", "����վ"),
																																																							  new System.Data.Common.DataColumnMapping("Ӳ��Ʊ��", "Ӳ��Ʊ��"),
																																																							  new System.Data.Common.DataColumnMapping("Ӳ��Ʊ��", "Ӳ��Ʊ��"),
																																																							  new System.Data.Common.DataColumnMapping("����Ʊ��", "����Ʊ��")})});
			this.sqlDataAdapter_ticketsinf.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDataAdapter_tickets
			// 
			this.sqlDataAdapter_tickets.DeleteCommand = this.sqlDeleteCommand2;
			this.sqlDataAdapter_tickets.InsertCommand = this.sqlInsertCommand2;
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
			this.sqlDataAdapter_tickets.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = "DELETE FROM tickets WHERE (���� = @Original_����)";
			this.sqlDeleteCommand2.Connection = this.sqlConnection1;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = @"INSERT INTO tickets(����, ʼ��վ, �յ�վ, ����ʱ��, ����ʱ��, Ӳ��Ʊ��, Ӳ����Ʊ��, Ӳ����Ʊ��, Ӳ����Ʊ��, ������Ʊ��, ������Ʊ��, ������Ʊ��, ���޿յ�, ��������, Ӳ��������, Ӳ����������, Ӳ�Գ�����, Ӳ�Գ�������, ���Գ�����, ���Գ�������) VALUES (@����, @ʼ��վ, @�յ�վ, @����ʱ��, @����ʱ��, @Ӳ��Ʊ��, @Ӳ����Ʊ��, @Ӳ����Ʊ��, @Ӳ����Ʊ��, @������Ʊ��, @������Ʊ��, @������Ʊ��, @���޿յ�, @��������, @Ӳ��������, @Ӳ����������, @Ӳ�Գ�����, @Ӳ�Գ�������, @���Գ�����, @���Գ�������)";
			this.sqlInsertCommand2.Connection = this.sqlConnection1;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 10, "����"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ʼ��վ", System.Data.SqlDbType.VarChar, 10, "ʼ��վ"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�յ�վ", System.Data.SqlDbType.VarChar, 10, "�յ�վ"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ��Ʊ��"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ����Ʊ��"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ����Ʊ��"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ����Ʊ��"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������Ʊ��", System.Data.SqlDbType.Int, 4, "������Ʊ��"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������Ʊ��", System.Data.SqlDbType.Int, 4, "������Ʊ��"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������Ʊ��", System.Data.SqlDbType.Int, 4, "������Ʊ��"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���޿յ�", System.Data.SqlDbType.VarChar, 10, "���޿յ�"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.VarChar, 10, "��������"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��������", System.Data.SqlDbType.Int, 4, "Ӳ��������"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����������", System.Data.SqlDbType.Int, 4, "Ӳ����������"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ�Գ�����", System.Data.SqlDbType.Int, 4, "Ӳ�Գ�����"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ�Գ�������", System.Data.SqlDbType.Int, 4, "Ӳ�Գ�������"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���Գ�����", System.Data.SqlDbType.Int, 4, "���Գ�����"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���Գ�������", System.Data.SqlDbType.Int, 4, "���Գ�������"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ���, ����, ʼ��վ, �յ�վ, ����ʱ��, ����ʱ��, Ӳ��Ʊ��, Ӳ����Ʊ��, Ӳ����Ʊ��, Ӳ����Ʊ��, ������Ʊ��, ������Ʊ��, ������" +
				"Ʊ��, ���޿յ�, ��������, Ӳ��������, Ӳ����������, Ӳ�Գ�����, Ӳ�Գ�������, ���Գ�����, ���Գ������� FROM tickets";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = @"UPDATE tickets SET ���� = @����, ʼ��վ = @ʼ��վ, �յ�վ = @�յ�վ, ����ʱ�� = @����ʱ��, ����ʱ�� = @����ʱ��, Ӳ��Ʊ�� = @Ӳ��Ʊ��, Ӳ����Ʊ�� = @Ӳ����Ʊ��, Ӳ����Ʊ�� = @Ӳ����Ʊ��, Ӳ����Ʊ�� = @Ӳ����Ʊ��, ������Ʊ�� = @������Ʊ��, ������Ʊ�� = @������Ʊ��, ������Ʊ�� = @������Ʊ��, ���޿յ� = @���޿յ�, �������� = @��������, Ӳ�������� = @Ӳ��������, Ӳ���������� = @Ӳ����������, Ӳ�Գ����� = @Ӳ�Գ�����, Ӳ�Գ������� = @Ӳ�Գ�������, ���Գ����� = @���Գ�����, ���Գ������� = @���Գ������� WHERE (���� = @Original_����)";
			this.sqlUpdateCommand2.Connection = this.sqlConnection1;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 10, "����"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ʼ��վ", System.Data.SqlDbType.VarChar, 10, "ʼ��վ"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�յ�վ", System.Data.SqlDbType.VarChar, 10, "�յ�վ"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ��Ʊ��"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ����Ʊ��"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ����Ʊ��"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ����Ʊ��"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������Ʊ��", System.Data.SqlDbType.Int, 4, "������Ʊ��"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������Ʊ��", System.Data.SqlDbType.Int, 4, "������Ʊ��"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������Ʊ��", System.Data.SqlDbType.Int, 4, "������Ʊ��"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���޿յ�", System.Data.SqlDbType.VarChar, 10, "���޿յ�"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.VarChar, 10, "��������"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��������", System.Data.SqlDbType.Int, 4, "Ӳ��������"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����������", System.Data.SqlDbType.Int, 4, "Ӳ����������"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ�Գ�����", System.Data.SqlDbType.Int, 4, "Ӳ�Գ�����"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ�Գ�������", System.Data.SqlDbType.Int, 4, "Ӳ�Գ�������"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���Գ�����", System.Data.SqlDbType.Int, 4, "���Գ�����"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���Գ�������", System.Data.SqlDbType.Int, 4, "���Գ�������"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet_chaxun1
			// 
			this.dataSet_chaxun1.DataSetName = "DataSet_chaxun1";
			this.dataSet_chaxun1.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_chaxun1)).EndInit();

		}
		#endregion
       
		private void Button1_Click(object sender, System.EventArgs e)
		{
			this.dataSet_chaxun1.Clear();
			this.TextBox_checi.Text="";
			this.TextBox_qsz.Text="";
			this.TextBox_zdz.Text="";
			this.DataGrid1.Visible=false;
		}

          

		private void Button3_Click(object sender, System.EventArgs e)
		{
			
			if(this.TextBox_qsz.Text.Trim() !="" && this.TextBox_zdz.Text.Trim() !="")
				type="zh";
			else if(this.TextBox_qsz.Text.Trim() !="")
				type="sfz";
			else if(this.TextBox_zdz.Text.Trim() !="")
				type="zdz";
			if(type!=null)
			{
				this.displayccxx(type);
			}
			else
				Global.Alert(this,"�������ѯ������");
		}
	
          
		private void displayccxx(string type)
		{  
			
			this.dataSet_chaxun1.Clear();

			sql="SELECT  * FROM tickets ";
			switch(type)
			{
				case "cc":
				{ sql+="where ����='"+this.TextBox_checi.Text.Trim()+"'";
					this.sqlDataAdapter_tickets.SelectCommand.CommandText=sql;

					if(this.sqlConnection1.State.ToString()=="Closed")
						this.sqlConnection1.Open();

					this.sqlDataAdapter_tickets.Fill(this.dataSet_chaxun1);
					if(this.dataSet_chaxun1.Tables[0].Rows.Count>0)
					{
						this.DataGrid1.Visible=true;
						this.DataGrid1.DataBind();
					}
					else
					{
						Global.Alert(this,"û����ؼ�¼!");   
			

					}
					break;
				}
				case "sfz" :
				{
				
					
			  
						dschaxun=new DataSet();
			 
               
						this.begin=this.TextBox_qsz.Text.Trim();
					
			
		

						sql="select  ����  from ticketsinf  ";
						sql+=" where ����վ='"+this.TextBox_qsz.Text.Trim()+"'";

						if(this.sqlConnection1.State.ToString()=="Closed")
							this.sqlConnection1.Open();

						this.sqlDataAdapter_ticketsinf.SelectCommand.CommandText=sql;
						this.sqlDataAdapter_ticketsinf.Fill(this.dschaxun);

		
 
						

						int count = this.dschaxun.Tables[0].Rows.Count;
					    sql="select * from tickets where ����='"+this.dschaxun.Tables[0].Rows[0][0].ToString().Trim()+"'";
					for(int i=1;i<count;i++)
					
					 {  sql+=" OR ����='"+this.dschaxun.Tables[0].Rows[i][0].ToString().Trim()+"'";
					     
					  }
						
						this.sqlDataAdapter_tickets.SelectCommand.CommandText=sql;
			
						this.sqlDataAdapter_tickets.Fill(this.dataSet_chaxun1) ; 
						
						
						this.DataGrid1.Visible=true;
						this.DataGrid1.DataBind();
						
             
					
					break;
				}
				case "zdz":
				{
					dschaxun=new DataSet();
			 
               
					this.end=this.TextBox_zdz.Text.Trim();
					
			
		

					sql="select  ����  from ticketsinf  ";
					sql+=" where ����վ='"+this.TextBox_zdz.Text.Trim()+"'";

					if(this.sqlConnection1.State.ToString()=="Closed")
						this.sqlConnection1.Open();

					this.sqlDataAdapter_ticketsinf.SelectCommand.CommandText=sql;
					this.sqlDataAdapter_ticketsinf.Fill(this.dschaxun);

		
 
						

					int count = this.dschaxun.Tables[0].Rows.Count;
					sql="select * from tickets where ����='"+this.dschaxun.Tables[0].Rows[0][0].ToString().Trim()+"'";
					for(int i=1;i<count;i++)
					
					{
							sql+=" OR ����='"+this.dschaxun.Tables[0].Rows[i][0].ToString().Trim()+"'";
					     
					}
						
					this.sqlDataAdapter_tickets.SelectCommand.CommandText=sql;
			
					this.sqlDataAdapter_tickets.Fill(this.dataSet_chaxun1) ; 
						
						
					this.DataGrid1.Visible=true;
					this.DataGrid1.DataBind();
						
             
					break;
				}
				case "zh":
				{  
					int leiji1=0;
					int leiji2=0;
				    int  k=0;

					dschaxun=new DataSet();
			        this.begin=this.TextBox_qsz.Text.Trim();
               		this.end=this.TextBox_zdz.Text.Trim();
					
		

					sql="select  ���� ,����վ,����վ  from ticketsinf  ";
					

					if(this.sqlConnection1.State.ToString()=="Closed")
						this.sqlConnection1.Open();

					this.sqlDataAdapter_ticketsinf.SelectCommand.CommandText=sql;
					this.sqlDataAdapter_ticketsinf.Fill(this.dschaxun);

		
 
						

					int count = this.dschaxun.Tables[0].Rows.Count;


					
					for(int i=0;i<count;i++)
					{
						if(this.begin==this.dschaxun.Tables[0].Rows[i][1].ToString())
						{
								leiji1=1;
							this.lscc=this.dschaxun.Tables[0].Rows[i][0].ToString();
						}

						if(this.end==this.dschaxun.Tables[0].Rows[i][2].ToString()&&this.dschaxun.Tables[0].Rows[i][0].ToString()==lscc)
							leiji2=1;
						
						if(leiji1==1&&leiji2==1)
						{
								sql="select * from tickets where ����='"+this.dschaxun.Tables[0].Rows[i][0].ToString().Trim()+"'";
							     k=i; 
							    leiji1=0;
							    leiji2=0;
							    goto next;
                                 
						}
					  
					}
				  
					next:   	
						for(int i=k+1;i<count;i++)
						{
							if(this.begin==this.dschaxun.Tables[0].Rows[i][1].ToString())
							{
								leiji1=1;
								this.lscc=this.dschaxun.Tables[0].Rows[i][0].ToString();
							}

							if(this.end==this.dschaxun.Tables[0].Rows[i][2].ToString()&&this.dschaxun.Tables[0].Rows[i][0].ToString()==lscc)
								leiji2=1;
						
							
							if(leiji1==1&&leiji2==1)
							{
								sql+=" OR ����='"+this.dschaxun.Tables[0].Rows[i][0].ToString().Trim()+"'";
								leiji1=0;
								leiji2=0;
							}
					
						}
					this.sqlDataAdapter_tickets.SelectCommand.CommandText=sql;
			
					this.sqlDataAdapter_tickets.Fill(this.dataSet_chaxun1) ; 
									
					this.DataGrid1.Visible=true;
					this.DataGrid1.DataBind();
				
					break;
				}
			}

		}
		private void Button_chaxun1_Click(object sender, System.EventArgs e)
		{
			if(this.TextBox_checi.Text.Trim()!="")
			{
				type="cc";
				this.displayccxx(type);
			}
			else
			{
				Global.Alert(this,"�������ѯ���Σ�");
			}
		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			displayccxx(type);
			this.sqlDataAdapter_tickets.Fill(this.dschaxun);
			this.DataGrid1.CurrentPageIndex=e.NewPageIndex;
			this.DataGrid1.DataBind();
		}

		private void DataGrid1_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			if(e.CommandName=="Select")
			{
				string  flag=this.DataGrid1.DataKeys[e.Item.ItemIndex].ToString();
				Response.Redirect("maipiao.aspx?flag="+flag);
			}
		}

		

	

		
	
		private void Button_maipiao_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("maipiao.aspx?flag=1");
		}

		private void Button_dingpiao_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("maipiao.aspx?flag=2");
		}

		private void Button_tuipiao_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("tuipiao.aspx");
		}

		private void Button_chaxun_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("chaxun.aspx");
		}

		private void Button_yhgl_Click(object sender, System.EventArgs e)
		{
				this.Response.Redirect("yonghuguanlizhujiemian.aspx");
		}
	}
}
