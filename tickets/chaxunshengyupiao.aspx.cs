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
	/// chaxunshengyupiao ��ժҪ˵����
	/// </summary>
	public class chaxunshengyupiao : System.Web.UI.Page
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
		protected System.Web.UI.HtmlControls.HtmlForm Form2;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.Label Label_checi;
		protected System.Web.UI.WebControls.TextBox TextBox_cxcc;
		protected System.Web.UI.WebControls.Button Button_cccx;
		protected System.Web.UI.WebControls.Button Button_cxsy;
		protected System.Web.UI.WebControls.Button Button_cccxsy;
		protected System.Web.UI.WebControls.Button Button_cz;
		protected System.Web.UI.WebControls.Label Label_cxcc;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_tickets;
		protected tickets.DataSet_checi dataSet_checi;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Label Label_LLQ;
		protected System.Web.UI.WebControls.Label Label_IP;
		protected System.Web.UI.WebControls.LinkButton Linkbutton_xwgl;
		protected System.Web.UI.WebControls.LinkButton Linkbutton_xxfk;
	    private string sql;

		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection1.ConnectionString=data.connStr;
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if(Session["username"].ToString()=="admin")
				this.Button_yhgl.Visible=true;
			else  this.Button_yhgl.Visible=false;
		     
	
			this.DataGrid1.Visible=false;

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
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_tickets = new System.Data.SqlClient.SqlDataAdapter();
			this.dataSet_checi = new tickets.DataSet_checi();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_checi)).BeginInit();
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
			this.Button_cccx.Click += new System.EventHandler(this.Button_cccx_Click);
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			this.Button_cxsy.Click += new System.EventHandler(this.Button_cxsy_Click);
			this.Button_cccxsy.Click += new System.EventHandler(this.Button_cccxsy_Click);
			this.Button_cz.Click += new System.EventHandler(this.Button_cz_Click);
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ���, ����, ʼ��վ, �յ�վ, ����ʱ��, ����ʱ��, Ӳ��Ʊ��, Ӳ����Ʊ��, Ӳ����Ʊ��, Ӳ����Ʊ��, ������Ʊ��, ������Ʊ��, ������" +
				"Ʊ��, ���޿յ�, ��������, Ӳ��������, Ӳ����������, Ӳ�Գ�����, Ӳ�Գ�������, ���Գ�����, ���Գ������� FROM tickets";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO tickets(����, ʼ��վ, �յ�վ, ����ʱ��, ����ʱ��, Ӳ��Ʊ��, Ӳ����Ʊ��, Ӳ����Ʊ��, Ӳ����Ʊ��, ������Ʊ��, ������Ʊ��, ������Ʊ��, ���޿յ�, ��������, Ӳ��������, Ӳ����������, Ӳ�Գ�����, Ӳ�Գ�������, ���Գ�����, ���Գ�������) VALUES (@����, @ʼ��վ, @�յ�վ, @����ʱ��, @����ʱ��, @Ӳ��Ʊ��, @Ӳ����Ʊ��, @Ӳ����Ʊ��, @Ӳ����Ʊ��, @������Ʊ��, @������Ʊ��, @������Ʊ��, @���޿յ�, @��������, @Ӳ��������, @Ӳ����������, @Ӳ�Գ�����, @Ӳ�Գ�������, @���Գ�����, @���Գ�������); SELECT ���, ����, ʼ��վ, �յ�վ, ����ʱ��, ����ʱ��, Ӳ��Ʊ��, Ӳ����Ʊ��, Ӳ����Ʊ��, Ӳ����Ʊ��, ������Ʊ��, ������Ʊ��, ������Ʊ��, ���޿յ�, ��������, Ӳ��������, Ӳ����������, Ӳ�Գ�����, Ӳ�Գ�������, ���Գ�����, ���Գ������� FROM tickets WHERE (���� = @����)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 10, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ʼ��վ", System.Data.SqlDbType.VarChar, 10, "ʼ��վ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�յ�վ", System.Data.SqlDbType.VarChar, 10, "�յ�վ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ��Ʊ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ����Ʊ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ����Ʊ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ����Ʊ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������Ʊ��", System.Data.SqlDbType.Int, 4, "������Ʊ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������Ʊ��", System.Data.SqlDbType.Int, 4, "������Ʊ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������Ʊ��", System.Data.SqlDbType.Int, 4, "������Ʊ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���޿յ�", System.Data.SqlDbType.VarChar, 10, "���޿յ�"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.VarChar, 10, "��������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��������", System.Data.SqlDbType.Int, 4, "Ӳ��������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����������", System.Data.SqlDbType.Int, 4, "Ӳ����������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ�Գ�����", System.Data.SqlDbType.Int, 4, "Ӳ�Գ�����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ�Գ�������", System.Data.SqlDbType.Int, 4, "Ӳ�Գ�������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���Գ�����", System.Data.SqlDbType.Int, 4, "���Գ�����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���Գ�������", System.Data.SqlDbType.Int, 4, "���Գ�������"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE tickets SET ���� = @����, ʼ��վ = @ʼ��վ, �յ�վ = @�յ�վ, ����ʱ�� = @����ʱ��, ����ʱ�� = @����ʱ��, " +
				"Ӳ��Ʊ�� = @Ӳ��Ʊ��, Ӳ����Ʊ�� = @Ӳ����Ʊ��, Ӳ����Ʊ�� = @Ӳ����Ʊ��, Ӳ����Ʊ�� = @Ӳ����Ʊ��, ������Ʊ�� = @������Ʊ��, ����" +
				"��Ʊ�� = @������Ʊ��, ������Ʊ�� = @������Ʊ��, ���޿յ� = @���޿յ�, �������� = @��������, Ӳ�������� = @Ӳ��������, Ӳ����������" +
				" = @Ӳ����������, Ӳ�Գ����� = @Ӳ�Գ�����, Ӳ�Գ������� = @Ӳ�Գ�������, ���Գ����� = @���Գ�����, ���Գ������� = @���Գ������� W" +
				"HERE (���� = @Original_����) AND (����ʱ�� = @Original_����ʱ�� OR @Original_����ʱ�� IS NULL AN" +
				"D ����ʱ�� IS NULL) AND (ʼ��վ = @Original_ʼ��վ OR @Original_ʼ��վ IS NULL AND ʼ��վ IS NUL" +
				"L) AND (����ʱ�� = @Original_����ʱ�� OR @Original_����ʱ�� IS NULL AND ����ʱ�� IS NULL) AND (��" +
				"�޿յ� = @Original_���޿յ� OR @Original_���޿յ� IS NULL AND ���޿յ� IS NULL) AND (Ӳ����Ʊ�� = @O" +
				"riginal_Ӳ����Ʊ�� OR @Original_Ӳ����Ʊ�� IS NULL AND Ӳ����Ʊ�� IS NULL) AND (Ӳ����Ʊ�� = @Origin" +
				"al_Ӳ����Ʊ�� OR @Original_Ӳ����Ʊ�� IS NULL AND Ӳ����Ʊ�� IS NULL) AND (Ӳ����Ʊ�� = @Original_Ӳ��" +
				"��Ʊ�� OR @Original_Ӳ����Ʊ�� IS NULL AND Ӳ����Ʊ�� IS NULL) AND (Ӳ�Գ������� = @Original_Ӳ�Գ�������" +
				" OR @Original_Ӳ�Գ������� IS NULL AND Ӳ�Գ������� IS NULL) AND (Ӳ�Գ����� = @Original_Ӳ�Գ����� OR" +
				" @Original_Ӳ�Գ����� IS NULL AND Ӳ�Գ����� IS NULL) AND (Ӳ��Ʊ�� = @Original_Ӳ��Ʊ�� OR @Origi" +
				"nal_Ӳ��Ʊ�� IS NULL AND Ӳ��Ʊ�� IS NULL) AND (Ӳ���������� = @Original_Ӳ���������� OR @Original_Ӳ" +
				"���������� IS NULL AND Ӳ���������� IS NULL) AND (Ӳ�������� = @Original_Ӳ�������� OR @Original_Ӳ������" +
				"�� IS NULL AND Ӳ�������� IS NULL) AND (�յ�վ = @Original_�յ�վ OR @Original_�յ�վ IS NULL A" +
				"ND �յ�վ IS NULL) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS" +
				" NULL) AND (������Ʊ�� = @Original_������Ʊ�� OR @Original_������Ʊ�� IS NULL AND ������Ʊ�� IS NULL" +
				") AND (������Ʊ�� = @Original_������Ʊ�� OR @Original_������Ʊ�� IS NULL AND ������Ʊ�� IS NULL) AND" +
				" (������Ʊ�� = @Original_������Ʊ�� OR @Original_������Ʊ�� IS NULL AND ������Ʊ�� IS NULL) AND (���Գ�" +
				"������ = @Original_���Գ������� OR @Original_���Գ������� IS NULL AND ���Գ������� IS NULL) AND (���Գ���" +
				"�� = @Original_���Գ����� OR @Original_���Գ����� IS NULL AND ���Գ����� IS NULL); SELECT ���, ����" +
				", ʼ��վ, �յ�վ, ����ʱ��, ����ʱ��, Ӳ��Ʊ��, Ӳ����Ʊ��, Ӳ����Ʊ��, Ӳ����Ʊ��, ������Ʊ��, ������Ʊ��, ������Ʊ��, ���޿յ�, ����" +
				"����, Ӳ��������, Ӳ����������, Ӳ�Գ�����, Ӳ�Գ�������, ���Գ�����, ���Գ������� FROM tickets WHERE (���� = @����)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 10, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ʼ��վ", System.Data.SqlDbType.VarChar, 10, "ʼ��վ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�յ�վ", System.Data.SqlDbType.VarChar, 10, "�յ�վ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ��Ʊ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ����Ʊ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ����Ʊ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, "Ӳ����Ʊ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������Ʊ��", System.Data.SqlDbType.Int, 4, "������Ʊ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������Ʊ��", System.Data.SqlDbType.Int, 4, "������Ʊ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������Ʊ��", System.Data.SqlDbType.Int, 4, "������Ʊ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���޿յ�", System.Data.SqlDbType.VarChar, 10, "���޿յ�"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.VarChar, 10, "��������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��������", System.Data.SqlDbType.Int, 4, "Ӳ��������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ����������", System.Data.SqlDbType.Int, 4, "Ӳ����������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ�Գ�����", System.Data.SqlDbType.Int, 4, "Ӳ�Գ�����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ�Գ�������", System.Data.SqlDbType.Int, 4, "Ӳ�Գ�������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���Գ�����", System.Data.SqlDbType.Int, 4, "���Գ�����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���Գ�������", System.Data.SqlDbType.Int, 4, "���Գ�������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ʼ��վ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ʼ��վ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���޿յ�", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���޿յ�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ����Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ����Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ����Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ�Գ�������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ�Գ�������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ�Գ�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ�Գ�����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ��Ʊ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ����������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ����������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ��������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ��������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�յ�վ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�յ�վ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������Ʊ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������Ʊ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������Ʊ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���Գ�������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���Գ�������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���Գ�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���Գ�����", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM tickets WHERE (���� = @Original_����) AND (����ʱ�� = @Original_����ʱ�� OR @Original_����ʱ�� IS NULL AND ����ʱ�� IS NULL) AND (ʼ��վ = @Original_ʼ��վ OR @Original_ʼ��վ IS NULL AND ʼ��վ IS NULL) AND (��� = @Original_���) AND (����ʱ�� = @Original_����ʱ�� OR @Original_����ʱ�� IS NULL AND ����ʱ�� IS NULL) AND (���޿յ� = @Original_���޿յ� OR @Original_���޿յ� IS NULL AND ���޿յ� IS NULL) AND (Ӳ����Ʊ�� = @Original_Ӳ����Ʊ�� OR @Original_Ӳ����Ʊ�� IS NULL AND Ӳ����Ʊ�� IS NULL) AND (Ӳ����Ʊ�� = @Original_Ӳ����Ʊ�� OR @Original_Ӳ����Ʊ�� IS NULL AND Ӳ����Ʊ�� IS NULL) AND (Ӳ����Ʊ�� = @Original_Ӳ����Ʊ�� OR @Original_Ӳ����Ʊ�� IS NULL AND Ӳ����Ʊ�� IS NULL) AND (Ӳ�Գ������� = @Original_Ӳ�Գ������� OR @Original_Ӳ�Գ������� IS NULL AND Ӳ�Գ������� IS NULL) AND (Ӳ�Գ����� = @Original_Ӳ�Գ����� OR @Original_Ӳ�Գ����� IS NULL AND Ӳ�Գ����� IS NULL) AND (Ӳ��Ʊ�� = @Original_Ӳ��Ʊ�� OR @Original_Ӳ��Ʊ�� IS NULL AND Ӳ��Ʊ�� IS NULL) AND (Ӳ���������� = @Original_Ӳ���������� OR @Original_Ӳ���������� IS NULL AND Ӳ���������� IS NULL) AND (Ӳ�������� = @Original_Ӳ�������� OR @Original_Ӳ�������� IS NULL AND Ӳ�������� IS NULL) AND (�յ�վ = @Original_�յ�վ OR @Original_�յ�վ IS NULL AND �յ�վ IS NULL) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL) AND (������Ʊ�� = @Original_������Ʊ�� OR @Original_������Ʊ�� IS NULL AND ������Ʊ�� IS NULL) AND (������Ʊ�� = @Original_������Ʊ�� OR @Original_������Ʊ�� IS NULL AND ������Ʊ�� IS NULL) AND (������Ʊ�� = @Original_������Ʊ�� OR @Original_������Ʊ�� IS NULL AND ������Ʊ�� IS NULL) AND (���Գ������� = @Original_���Գ������� OR @Original_���Գ������� IS NULL AND ���Գ������� IS NULL) AND (���Գ����� = @Original_���Գ����� OR @Original_���Գ����� IS NULL AND ���Գ����� IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ʼ��վ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ʼ��վ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���޿յ�", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���޿յ�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ����Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ����Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ����Ʊ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ����Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ�Գ�������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ�Գ�������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ�Գ�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ�Գ�����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ��Ʊ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ����������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ����������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ��������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӳ��������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�յ�վ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�յ�վ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������Ʊ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������Ʊ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������Ʊ��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���Գ�������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���Գ�������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���Գ�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���Գ�����", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter_tickets
			// 
			this.sqlDataAdapter_tickets.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_tickets.InsertCommand = this.sqlInsertCommand1;
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
			this.sqlDataAdapter_tickets.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// dataSet_checi
			// 
			this.dataSet_checi.DataSetName = "DataSet_checi";
			this.dataSet_checi.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_checi)).EndInit();

		}
		#endregion

		private void Button_cccxsy_Click(object sender, System.EventArgs e)
		{
			
			this.TextBox_cxcc.Enabled=true;
			this.TextBox_cxcc.Text="";
			this.Button_cccx.Enabled=true;
			
		}

		private void Button_cccx_Click(object sender, System.EventArgs e)
		{
			sql="select * from tickets where ����='"+this.TextBox_cxcc.Text.Trim()+"'";
			this.sqlDataAdapter_tickets.SelectCommand.CommandText=sql;
			if(this.sqlConnection1.State.ToString()=="closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_tickets.Fill(this.dataSet_checi);
			this.DataGrid1.DataBind();
			this.DataGrid1.Visible=true;  
			
		}

		private void Button_cxsy_Click(object sender, System.EventArgs e)
		{   this.TextBox_cxcc.Enabled=false;
			this.Button_cccx.Enabled=false;
			sql="select * from tickets ";
			this.sqlDataAdapter_tickets.SelectCommand.CommandText=sql;
			if(this.sqlConnection1.State.ToString()=="closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_tickets.Fill(this.dataSet_checi);
			this.DataGrid1.DataBind();
			this.DataGrid1.Visible=true;  
			this.Label_checi.Text=this.dataSet_checi.Tables[0].Rows.Count.ToString();
			this.TextBox_cxcc.Visible=true;
		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{   this.sqlDataAdapter_tickets.Fill(this.dataSet_checi);
			this.DataGrid1.CurrentPageIndex=e.NewPageIndex;
			this.DataGrid1.DataBind();
		}

		private void Button_cz_Click(object sender, System.EventArgs e)
		{
			this.TextBox_cxcc.Text="";
			this.DataGrid1.Visible=false;
			this.dataSet_checi.Clear();
			this.TextBox_cxcc.Enabled=false;
			this.Button_cccx.Enabled=false;

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

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("guanliyonghu.aspx");
		}

		private void LinkButton2_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("chaxunshengyupiao.aspx");
		}

		private void LinkButton3_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("gengxincheci.aspx");
		}

		private void LinkButton4_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("shoupiaoqingkuangtongji.aspx");
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
