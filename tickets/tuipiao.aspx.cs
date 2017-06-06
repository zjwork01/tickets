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
	/// tuipiao1 ��ժҪ˵����
	/// </summary>
	public class tuipiao1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button_maipiao;
		protected System.Web.UI.WebControls.Button Button_dingpiao;
		protected System.Web.UI.WebControls.Button Button_tuipiao;
		protected System.Web.UI.WebControls.Button Button_chaxun;
		protected System.Web.UI.WebControls.Button Button_yhgl;
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_dingpiao;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_tickets;
		protected System.Web.UI.WebControls.RadioButton RadioButton_tuipiao;
		protected System.Web.UI.WebControls.RadioButton RadioButton_tuiding;
		protected System.Web.UI.WebControls.Button Button_qdcc;
		protected System.Web.UI.WebControls.Button Button_tp;
		protected System.Web.UI.WebControls.Button Button_cz;
		protected System.Web.UI.WebControls.TextBox TextBox_xm;
		protected System.Web.UI.HtmlControls.HtmlForm ��Ʊ;
		protected System.Data.DataSet dsbegin;
		protected System.Data.DataSet dsend;
		protected System.Data.DataSet dsjiage;
	
		protected System.Data.DataSet dsleixing;
		protected System.Data.DataSet dskongtiaoche;
		protected System.Data.DataSet dskongtiaochewopu;
		protected System.Data.DataSet dsputongche;
		protected System.Data.DataSet dsputongchewopu;
		protected System.Data.DataSet dslucheng;
		protected System.Data.DataSet dscxzwh;
		protected System.Data.DataSet dscxzwh1;
		protected System.Data.DataSet dskcsj;
		protected System.Data.DataSet dscllx;
		private string cc;
//		private string flag="0";
		private string sql;
		private string type;
		private string begin;
		protected System.Web.UI.WebControls.TextBox Text_checi;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand3;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_ticketsinf;
		protected System.Web.UI.WebControls.DropDownList DropDownList_qsz;
		protected System.Web.UI.WebControls.DropDownList DropDownList_zdz;
		protected System.Web.UI.WebControls.Button Button_jg;
		protected System.Web.UI.WebControls.Label Label_yj;
		protected System.Web.UI.WebControls.Label Label_xt;
		protected System.Web.UI.WebControls.TextBox TextBox_sfz;
		protected System.Web.UI.WebControls.TextBox TextBox_lxfs;
		protected System.Web.UI.WebControls.TextBox TextBox_dz;
		protected System.Web.UI.WebControls.DropDownList DropDownList_nian;
		protected System.Web.UI.WebControls.DropDownList DropDownList_yue;
		protected System.Web.UI.WebControls.DropDownList DropDownList_ri;
		protected System.Web.UI.WebControls.TextBox Text_ps;
		protected System.Data.SqlClient.SqlConnection sqlConnection2;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_kongtiaoche;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_kongtiaochewopu;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_putongche;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_putongchewopu;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand6;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		protected System.Web.UI.WebControls.DropDownList DropDownList_zwlx1;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Label Label_LLQ;
		protected System.Web.UI.WebControls.Label Label_IP;
		private string  end;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection1.ConnectionString=this.sqlConnection2.ConnectionString=data.connStr;
			// �ڴ˴������û������Գ�ʼ��ҳ��

			if(Session["username"].ToString()=="admin")
				this.Button_yhgl.Visible=true;
			else  this.Button_yhgl.Visible=false;
             this.Panel1.Visible=false;

            
			if(this.RadioButton_tuiding.Checked==true)
				this.Panel1.Visible=true;
			else  this.Panel1.Visible=false;

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
			this.sqlDataAdapter_dingpiao = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_tickets = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_ticketsinf = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
			this.sqlDataAdapter_kongtiaoche = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_kongtiaochewopu = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_putongche = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter_putongchewopu = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
			this.Button_maipiao.Click += new System.EventHandler(this.Button_maipiao_Click);
			this.Button_dingpiao.Click += new System.EventHandler(this.Button_dingpiao_Click);
			this.Button_tuipiao.Click += new System.EventHandler(this.Button_tuipiao_Click);
			this.Button_chaxun.Click += new System.EventHandler(this.Button_chaxun_Click);
			this.Button_yhgl.Click += new System.EventHandler(this.Button_yhgl_Click);
			this.Button_qdcc.Click += new System.EventHandler(this.Button_qdcc_Click);
			this.Button_jg.Click += new System.EventHandler(this.Button_jg_Click);
			this.Button_tp.Click += new System.EventHandler(this.Button_tp_Click);
			this.Button_cz.Click += new System.EventHandler(this.Button_cz_Click);
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ���, ����, ����վ, ����վ, ��λ����, Ʊ��, �ܼ۸�, �û���, ��ϵ��ʽ, ��ַ, ���֤ FROM dingpiao";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=SA;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO dingpiao(���, ����, ����վ, ����վ, ��λ����, Ʊ��, �ܼ۸�, �û���, ��ϵ��ʽ, ��ַ, ���֤) VALUES " +
				"(@���, @����, @����վ, @����վ, @��λ����, @Ʊ��, @�ܼ۸�, @�û���, @��ϵ��ʽ, @��ַ, @���֤); SELECT ���, ����," +
				" ����վ, ����վ, ��λ����, Ʊ��, �ܼ۸�, �û���, ��ϵ��ʽ, ��ַ, ���֤ FROM dingpiao WHERE (��� = @���)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Int, 4, "���"));
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
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE dingpiao SET ��� = @���, ���� = @����, ����վ = @����վ, ����վ = @����վ, ��λ���� = @��λ����, Ʊ�� = @Ʊ��, �ܼ۸� = @�ܼ۸�, �û��� = @�û���, ��ϵ��ʽ = @��ϵ��ʽ, ��ַ = @��ַ, ���֤ = @���֤ WHERE (��� = @Original_���) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL) AND (��ַ = @Original_��ַ OR @Original_��ַ IS NULL AND ��ַ IS NULL) AND (��λ���� = @Original_��λ���� OR @Original_��λ���� IS NULL AND ��λ���� IS NULL) AND (�ܼ۸� = @Original_�ܼ۸� OR @Original_�ܼ۸� IS NULL AND �ܼ۸� IS NULL) AND (�û��� = @Original_�û��� OR @Original_�û��� IS NULL AND �û��� IS NULL) AND (Ʊ�� = @Original_Ʊ�� OR @Original_Ʊ�� IS NULL AND Ʊ�� IS NULL) AND (��ϵ��ʽ = @Original_��ϵ��ʽ OR @Original_��ϵ��ʽ IS NULL AND ��ϵ��ʽ IS NULL) AND (���֤ = @Original_���֤ OR @Original_���֤ IS NULL AND ���֤ IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL); SELECT ���, ����, ����վ, ����վ, ��λ����, Ʊ��, �ܼ۸�, �û���, ��ϵ��ʽ, ��ַ, ���֤ FROM dingpiao WHERE (��� = @���)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Int, 4, "���"));
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
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����վ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����վ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����վ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����վ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ַ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ַ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��λ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��λ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ܼ۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ܼ۸�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û���", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ��ʽ", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ��ʽ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���֤", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���֤", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			// 
			// sqlDataAdapter_dingpiao
			// 
			this.sqlDataAdapter_dingpiao.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_dingpiao.InsertCommand = this.sqlInsertCommand1;
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
																																																						  new System.Data.Common.DataColumnMapping("���֤", "���֤")})});
			this.sqlDataAdapter_dingpiao.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ���, ����, ʼ��վ, �յ�վ, ����ʱ��, ����ʱ��, Ӳ��Ʊ��, Ӳ��Ʊ��, ����Ʊ�� FROM tickets";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = "INSERT INTO tickets(���, ����, ʼ��վ, �յ�վ, ����ʱ��, ����ʱ��, Ӳ��Ʊ��, Ӳ��Ʊ��, ����Ʊ��) VALUES (@���, " +
				"@����, @ʼ��վ, @�յ�վ, @����ʱ��, @����ʱ��, @Ӳ��Ʊ��, @Ӳ��Ʊ��, @����Ʊ��); SELECT ���, ����, ʼ��վ, �յ�վ, ����" +
				"ʱ��, ����ʱ��, Ӳ��Ʊ��, Ӳ��Ʊ��, ����Ʊ�� FROM tickets WHERE (��� = @���)";
			this.sqlInsertCommand2.Connection = this.sqlConnection1;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 10, "����"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ʼ��վ", System.Data.SqlDbType.VarChar, 10, "ʼ��վ"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�յ�վ", System.Data.SqlDbType.VarChar, 10, "�յ�վ"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "����Ʊ��", System.Data.DataRowVersion.Current, null));
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.Connection = this.sqlConnection1;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = @"DELETE FROM tickets WHERE (��� = @Original_���) AND (����ʱ�� = @Original_����ʱ�� OR @Original_����ʱ�� IS NULL AND ����ʱ�� IS NULL) AND (ʼ��վ = @Original_ʼ��վ OR @Original_ʼ��վ IS NULL AND ʼ��վ IS NULL) AND (����ʱ�� = @Original_����ʱ�� OR @Original_����ʱ�� IS NULL AND ����ʱ�� IS NULL) AND (Ӳ��Ʊ�� = @Original_Ӳ��Ʊ�� OR @Original_Ӳ��Ʊ�� IS NULL AND Ӳ��Ʊ�� IS NULL) AND (Ӳ��Ʊ�� = @Original_Ӳ��Ʊ�� OR @Original_Ӳ��Ʊ�� IS NULL AND Ӳ��Ʊ�� IS NULL) AND (�յ�վ = @Original_�յ�վ OR @Original_�յ�վ IS NULL AND �յ�վ IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (����Ʊ�� = @Original_����Ʊ�� OR @Original_����Ʊ�� IS NULL AND ����Ʊ�� IS NULL)";
			this.sqlDeleteCommand2.Connection = this.sqlConnection1;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ʼ��վ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ʼ��վ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�յ�վ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�յ�վ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "����Ʊ��", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter_tickets
			// 
			this.sqlDataAdapter_tickets.DeleteCommand = this.sqlDeleteCommand2;
			this.sqlDataAdapter_tickets.InsertCommand = this.sqlInsertCommand2;
			this.sqlDataAdapter_tickets.SelectCommand = this.sqlSelectCommand2;
			this.sqlDataAdapter_tickets.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																											 new System.Data.Common.DataTableMapping("Table", "tickets", new System.Data.Common.DataColumnMapping[] {
																																																						new System.Data.Common.DataColumnMapping("���", "���"),
																																																						new System.Data.Common.DataColumnMapping("����", "����"),
																																																						new System.Data.Common.DataColumnMapping("ʼ��վ", "ʼ��վ"),
																																																						new System.Data.Common.DataColumnMapping("�յ�վ", "�յ�վ"),
																																																						new System.Data.Common.DataColumnMapping("����ʱ��", "����ʱ��"),
																																																						new System.Data.Common.DataColumnMapping("����ʱ��", "����ʱ��"),
																																																						new System.Data.Common.DataColumnMapping("Ӳ��Ʊ��", "Ӳ��Ʊ��"),
																																																						new System.Data.Common.DataColumnMapping("Ӳ��Ʊ��", "Ӳ��Ʊ��"),
																																																						new System.Data.Common.DataColumnMapping("����Ʊ��", "����Ʊ��")})});
			this.sqlDataAdapter_tickets.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "SELECT ���, ����, ����ʱ��, ����ʱ��, ����վ, ����վ, Ӳ��Ʊ��, Ӳ��Ʊ��, ����Ʊ�� FROM ticketsinf";
			this.sqlSelectCommand3.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand3
			// 
			this.sqlInsertCommand3.CommandText = "INSERT INTO ticketsinf(���, ����, ����ʱ��, ����ʱ��, ����վ, ����վ, Ӳ��Ʊ��, Ӳ��Ʊ��, ����Ʊ��) VALUES (@��" +
				"��, @����, @����ʱ��, @����ʱ��, @����վ, @����վ, @Ӳ��Ʊ��, @Ӳ��Ʊ��, @����Ʊ��); SELECT ���, ����, ����ʱ��, ����ʱ" +
				"��, ����վ, ����վ, Ӳ��Ʊ��, Ӳ��Ʊ��, ����Ʊ�� FROM ticketsinf WHERE (��� = @���)";
			this.sqlInsertCommand3.Connection = this.sqlConnection1;
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 18, "����"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����վ", System.Data.SqlDbType.VarChar, 50, "����վ"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����վ", System.Data.SqlDbType.VarChar, 50, "����վ"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "����Ʊ��", System.Data.DataRowVersion.Current, null));
			// 
			// sqlUpdateCommand3
			// 
			this.sqlUpdateCommand3.CommandText = @"UPDATE ticketsinf SET ��� = @���, ���� = @����, ����ʱ�� = @����ʱ��, ����ʱ�� = @����ʱ��, ����վ = @����վ, ����վ = @����վ, Ӳ��Ʊ�� = @Ӳ��Ʊ��, Ӳ��Ʊ�� = @Ӳ��Ʊ��, ����Ʊ�� = @����Ʊ�� WHERE (��� = @Original_���) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL) AND (����ʱ�� = @Original_����ʱ�� OR @Original_����ʱ�� IS NULL AND ����ʱ�� IS NULL) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL) AND (����ʱ�� = @Original_����ʱ�� OR @Original_����ʱ�� IS NULL AND ����ʱ�� IS NULL) AND (Ӳ��Ʊ�� = @Original_Ӳ��Ʊ�� OR @Original_Ӳ��Ʊ�� IS NULL AND Ӳ��Ʊ�� IS NULL) AND (Ӳ��Ʊ�� = @Original_Ӳ��Ʊ�� OR @Original_Ӳ��Ʊ�� IS NULL AND Ӳ��Ʊ�� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (����Ʊ�� = @Original_����Ʊ�� OR @Original_����Ʊ�� IS NULL AND ����Ʊ�� IS NULL); SELECT ���, ����, ����ʱ��, ����ʱ��, ����վ, ����վ, Ӳ��Ʊ��, Ӳ��Ʊ��, ����Ʊ�� FROM ticketsinf WHERE (��� = @���)";
			this.sqlUpdateCommand3.Connection = this.sqlConnection1;
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 18, "����"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����ʱ��"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����վ", System.Data.SqlDbType.VarChar, 50, "����վ"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����վ", System.Data.SqlDbType.VarChar, 50, "����վ"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "����Ʊ��", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����վ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����վ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����վ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����վ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "����Ʊ��", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand3
			// 
			this.sqlDeleteCommand3.CommandText = @"DELETE FROM ticketsinf WHERE (��� = @Original_���) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL) AND (����ʱ�� = @Original_����ʱ�� OR @Original_����ʱ�� IS NULL AND ����ʱ�� IS NULL) AND (����վ = @Original_����վ OR @Original_����վ IS NULL AND ����վ IS NULL) AND (����ʱ�� = @Original_����ʱ�� OR @Original_����ʱ�� IS NULL AND ����ʱ�� IS NULL) AND (Ӳ��Ʊ�� = @Original_Ӳ��Ʊ�� OR @Original_Ӳ��Ʊ�� IS NULL AND Ӳ��Ʊ�� IS NULL) AND (Ӳ��Ʊ�� = @Original_Ӳ��Ʊ�� OR @Original_Ӳ��Ʊ�� IS NULL AND Ӳ��Ʊ�� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (����Ʊ�� = @Original_����Ʊ�� OR @Original_����Ʊ�� IS NULL AND ����Ʊ�� IS NULL)";
			this.sqlDeleteCommand3.Connection = this.sqlConnection1;
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����վ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����վ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����վ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����վ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӳ��Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӳ��Ʊ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 18, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����Ʊ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "����Ʊ��", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter_ticketsinf
			// 
			this.sqlDataAdapter_ticketsinf.DeleteCommand = this.sqlDeleteCommand3;
			this.sqlDataAdapter_ticketsinf.InsertCommand = this.sqlInsertCommand3;
			this.sqlDataAdapter_ticketsinf.SelectCommand = this.sqlSelectCommand3;
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
			this.sqlDataAdapter_ticketsinf.UpdateCommand = this.sqlUpdateCommand3;
			// 
			// sqlConnection2
			// 
			this.sqlConnection2.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlDataAdapter_kongtiaoche
			// 
			this.sqlDataAdapter_kongtiaoche.SelectCommand = this.sqlSelectCommand4;
			this.sqlDataAdapter_kongtiaoche.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																												 new System.Data.Common.DataTableMapping("Table", "kongtiaoliechejiage", new System.Data.Common.DataColumnMapping[] {
																																																										new System.Data.Common.DataColumnMapping("���", "���"),
																																																										new System.Data.Common.DataColumnMapping("���", "���"),
																																																										new System.Data.Common.DataColumnMapping("��ͨ�г�", "��ͨ�г�"),
																																																										new System.Data.Common.DataColumnMapping("�տ��г�", "�տ��г�"),
																																																										new System.Data.Common.DataColumnMapping("�ؿ��г�", "�ؿ��г�"),
																																																										new System.Data.Common.DataColumnMapping("�յ�����", "�յ�����"),
																																																										new System.Data.Common.DataColumnMapping("��λ����", "��λ����")})});
			// 
			// sqlSelectCommand4
			// 
			this.sqlSelectCommand4.CommandText = "SELECT ���, ���, ��ͨ�г�, �տ��г�, �ؿ��г�, �յ�����, ��λ���� FROM kongtiaoliechejiage";
			this.sqlSelectCommand4.Connection = this.sqlConnection2;
			// 
			// sqlDataAdapter_kongtiaochewopu
			// 
			this.sqlDataAdapter_kongtiaochewopu.SelectCommand = this.sqlSelectCommand5;
			this.sqlDataAdapter_kongtiaochewopu.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																													 new System.Data.Common.DataTableMapping("Table", "kongtiaoliechewopujiage", new System.Data.Common.DataColumnMapping[] {
																																																												new System.Data.Common.DataColumnMapping("���", "���"),
																																																												new System.Data.Common.DataColumnMapping("���", "���"),
																																																												new System.Data.Common.DataColumnMapping("����", "����"),
																																																												new System.Data.Common.DataColumnMapping("����", "����"),
																																																												new System.Data.Common.DataColumnMapping("����", "����"),
																																																												new System.Data.Common.DataColumnMapping("�յ�����", "�յ�����"),
																																																												new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																												new System.Data.Common.DataColumnMapping("��λ����", "��λ����")})});
			// 
			// sqlSelectCommand5
			// 
			this.sqlSelectCommand5.CommandText = "SELECT ���, ���, ����, ����, ����, �յ�����, ��������, ��λ���� FROM kongtiaoliechewopujiage";
			this.sqlSelectCommand5.Connection = this.sqlConnection2;
			// 
			// sqlDataAdapter_putongche
			// 
			this.sqlDataAdapter_putongche.SelectCommand = this.sqlSelectCommand6;
			this.sqlDataAdapter_putongche.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																											   new System.Data.Common.DataTableMapping("Table", "putongliechejiage", new System.Data.Common.DataColumnMapping[] {
																																																									new System.Data.Common.DataColumnMapping("���", "���"),
																																																									new System.Data.Common.DataColumnMapping("���", "���"),
																																																									new System.Data.Common.DataColumnMapping("��ͨ�г�", "��ͨ�г�"),
																																																									new System.Data.Common.DataColumnMapping("�տ��г�", "�տ��г�"),
																																																									new System.Data.Common.DataColumnMapping("�ؿ��г�", "�ؿ��г�"),
																																																									new System.Data.Common.DataColumnMapping("�յ�����", "�յ�����"),
																																																									new System.Data.Common.DataColumnMapping("��λ����", "��λ����")})});
			// 
			// sqlSelectCommand6
			// 
			this.sqlSelectCommand6.CommandText = "SELECT ���, ���, ��ͨ�г�, �տ��г�, �ؿ��г�, �յ�����, ��λ���� FROM putongliechejiage";
			this.sqlSelectCommand6.Connection = this.sqlConnection2;
			// 
			// sqlDataAdapter_putongchewopu
			// 
			this.sqlDataAdapter_putongchewopu.SelectCommand = this.sqlSelectCommand7;
			this.sqlDataAdapter_putongchewopu.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																												   new System.Data.Common.DataTableMapping("Table", "putongliechewopujiage", new System.Data.Common.DataColumnMapping[] {
																																																											new System.Data.Common.DataColumnMapping("���", "���"),
																																																											new System.Data.Common.DataColumnMapping("���", "���"),
																																																											new System.Data.Common.DataColumnMapping("����", "����"),
																																																											new System.Data.Common.DataColumnMapping("����", "����"),
																																																											new System.Data.Common.DataColumnMapping("����", "����"),
																																																											new System.Data.Common.DataColumnMapping("�յ�����", "�յ�����"),
																																																											new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																											new System.Data.Common.DataColumnMapping("��λ����", "��λ����")})});
			// 
			// sqlSelectCommand7
			// 
			this.sqlSelectCommand7.CommandText = "SELECT ���, ���, ����, ����, ����, �յ�����, ��������, ��λ���� FROM putongliechewopujiage";
			this.sqlSelectCommand7.Connection = this.sqlConnection2;
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private void xianshicheci(string cc)
		{
			dsbegin=new DataSet();
			dsend=new DataSet(); 


			sql="SELECT ����վ FROM ticketsinf";
			sql+=" where ����='"+ this.Text_checi.Text.Trim()+"'";
			
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();

			this.sqlDataAdapter_ticketsinf.SelectCommand.CommandText=sql;
			this.sqlDataAdapter_ticketsinf.Fill(this.dsbegin);

			this.DropDownList_qsz.DataSource=this.dsbegin;
			this.DropDownList_qsz.DataMember=this.dsbegin.Tables[0].ToString();
			this.DropDownList_qsz.DataTextField=this.dsbegin.Tables[0].Columns[0].ToString();
			this.DropDownList_qsz.DataValueField=this.dsbegin.Tables[0].Columns[0].ToString();
			this.DropDownList_qsz.DataBind();



			sql="SELECT ����վ FROM ticketsinf";
			sql+=" where ����='"+ this.Text_checi.Text+"'";
			this.sqlDataAdapter_ticketsinf.SelectCommand.CommandText=sql;
			this.sqlDataAdapter_ticketsinf.Fill(this.dsend);

			this.DropDownList_zdz.DataSource=this.dsend;
			this.DropDownList_zdz.DataMember=this.dsend.Tables[0].ToString();
			this.DropDownList_zdz.DataTextField=this.dsend.Tables[0].Columns[0].ToString();
			this.DropDownList_zdz.DataValueField=this.dsend.Tables[0].Columns[0].ToString();
			this.DropDownList_zdz.DataBind();
		}
		public void DropDownList_zwlx1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			type=this.DropDownList_zwlx1.SelectedItem.Value.ToString();
		}
		private  Decimal  jisuanjiage()
		{
				dsleixing=new DataSet();
			dsputongche=new DataSet();
			dsputongchewopu=new DataSet();
			dskongtiaoche=new DataSet();
			dskongtiaochewopu=new DataSet();
			decimal jiage=0m;
			this.sqlDataAdapter_tickets.SelectCommand.CommandText="select ���޿յ�,�������� from tickets where ����='"+this.Text_checi.Text.Trim()+"'";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();

			this.sqlDataAdapter_tickets.Fill(dsleixing);
			string kongtiao=this.dsleixing.Tables[0].Rows[0][0].ToString().Trim();
			string leixing=this.dsleixing.Tables[0].Rows[0][1].ToString().Trim();
			string zuoweileixing=this.DropDownList_zwlx1.SelectedItem.Text.Trim();
			decimal  lucheng=this.jisuanlucheng();
			if((kongtiao=="")&&(zuoweileixing=="Ӳ��"))
			{
				this.sqlDataAdapter_putongche.SelectCommand.CommandText="select ���,��ͨ�г�,�տ��г�,�ؿ��г�,�յ����� ,��λ���� from putongliechejiage ";
				if(this.sqlConnection2.State.ToString()=="Closed")
					this.sqlConnection2.Open();

				this.sqlDataAdapter_putongche.Fill(this.dsputongche);
				int hangshu=this.dsputongche.Tables[0].Rows.Count;
				if(leixing=="��ͨ")
				{
					for(int i=0;i<hangshu;i++)
					{
							if(lucheng>=decimal.Parse(this.dsputongche.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongche.Tables[0].Rows[i+1][0].ToString()))
					   {
							   jiage=decimal.Parse(this.dsputongche.Tables[0].Rows[i][1].ToString())+decimal.Parse(this.dsputongche.Tables[0].Rows[i][4].ToString());
						   break;
					   }
					}
				
				}
				else if(leixing=="�տ�")
				{
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongche.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongche.Tables[0].Rows[i+1][0].ToString()))
						{
								jiage=decimal.Parse(this.dsputongche.Tables[0].Rows[i][2].ToString())+decimal.Parse(this.dsputongche.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�ؿ�")
				{
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongche.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongche.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongche.Tables[0].Rows[i][3].ToString())+decimal.Parse(this.dsputongche.Tables[0].Rows[i][4].ToString());
							break;
						}
					} 
				
				}

			
			
			
			}
			else if((kongtiao=="�յ�")&&(zuoweileixing=="Ӳ��"))
			{
				this.sqlDataAdapter_kongtiaoche.SelectCommand.CommandText="select ���,��ͨ�г�,�տ��г�,�ؿ��г� from kongtiaoliechejiage ";
				if(this.sqlConnection2.State.ToString()=="Closed")
					this.sqlConnection2.Open();

				this.sqlDataAdapter_kongtiaoche.Fill(this.dskongtiaoche);
				int hangshu=this.dskongtiaoche.Tables[0].Rows.Count;
				if(leixing=="��ͨ")
				{
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i][1].ToString());
						}
					}
				
				}
				else if(leixing=="�տ�")
				{
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i][2].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�ؿ�")
				{
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaoche.Tables[0].Rows[i][3].ToString());
							break;
						}
					} 
				
				}

			
			
			
			}
			else if((kongtiao=="")&&(zuoweileixing=="Ӳ����"))
			{
				
				if(leixing=="��ͨ")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='Ӳ��'and ��������='��ͨ�г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][1].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�տ�")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='Ӳ��'and ��������='�տ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][1].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�ؿ�")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='Ӳ��'and ��������='�ؿ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][1].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="")&&(zuoweileixing=="Ӳ����"))
			{
				
				if(leixing=="��ͨ")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='Ӳ��'and ��������='��ͨ�г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][2].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�տ�")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='Ӳ��'and ��������='�տ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][2].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�ؿ�")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='Ӳ��'and ��������='�ؿ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][2].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="")&&(zuoweileixing=="Ӳ����"))
			{
				
				if(leixing=="��ͨ")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='Ӳ��'and ��������='��ͨ�г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][3].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�տ�")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='Ӳ��'and ��������='�տ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][3].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�ؿ�")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='Ӳ��'and ��������='�ؿ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][3].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="")&&(zuoweileixing=="������"))
			{
				
				if(leixing=="��ͨ")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='����'and ��������='��ͨ�г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][1].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�տ�")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='����'and ��������='�տ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][1].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�ؿ�")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='����'and ��������='�ؿ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][1].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="")&&(zuoweileixing=="������"))
			{
				
				if(leixing=="��ͨ")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='����'and ��������='��ͨ�г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][2].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�տ�")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='����'and ��������='�տ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][2].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�ؿ�")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='����'and ��������='�ؿ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][2].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="")&&(zuoweileixing=="������"))
			{
				
				if(leixing=="��ͨ")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='����'and ��������='��ͨ�г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][3].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�տ�")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='����'and ��������='�տ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][3].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�ؿ�")
				{  
					this.sqlDataAdapter_putongchewopu.SelectCommand.CommandText="select ���,����,����,����,�յ�����,�������� from putongliechewopujiage where ��λ����='����'and ��������='�ؿ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_putongchewopu.Fill(this.dsputongchewopu);
					int hangshu=this.dsputongchewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][3].ToString())+decimal.Parse(this.dsputongchewopu.Tables[0].Rows[i][4].ToString());
							break;
						}
					}
				
				}
				
			
			}
		
			else if((kongtiao=="�յ�")&&(zuoweileixing=="Ӳ����"))
			{
				
				if(leixing=="��ͨ")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select ���,����,����,����,�������� from kongtiaoliechewopujiage where ��λ����='Ӳ��'and ��������='��ͨ�г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][1].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�տ�")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select ���,����,����,����,�������� from kongtiaoliechewopujiage where ��λ����='Ӳ��'and ��������='�տ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][1].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�ؿ�")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select ���,����,����,����,�������� from kongtiaoliechewopujiage where ��λ����='Ӳ��'and ��������='�ؿ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][1].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="�յ�")&&(zuoweileixing=="Ӳ����"))
			{
				
				if(leixing=="��ͨ")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select ���,����,����,����,�������� from kongtiaoliechewopujiage where ��λ����='Ӳ��'and ��������='��ͨ�г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][2].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�տ�")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select ���,����,����,����,�������� from kongtiaoliechewopujiage where ��λ����='Ӳ��'and ��������='�տ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][2].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�ؿ�")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select ���,����,����,����,�������� from kongtiaoliechewopujiage where ��λ����='Ӳ��'and ��������='�ؿ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][2].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="�յ�")&&(zuoweileixing=="Ӳ����"))
			{
				
				if(leixing=="��ͨ")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select ���,����,����,����,�������� from kongtiaoliechewopujiage where ��λ����='Ӳ��'and ��������='��ͨ�г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][3].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�տ�")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select ���,����,����,����,�������� from kongtiaoliechewopujiage where ��λ����='Ӳ��'and ��������='�տ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][3].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�ؿ�")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select ���,����,����,���̳������� from kongtiaoliechewopujiage where ��λ����='Ӳ��'and ��������='�ؿ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][3].ToString());
							break;
						}
					}
				
				}
				
			
			}
			else if((kongtiao=="�յ�")&&(zuoweileixing=="������"))
			{
				
				if(leixing=="��ͨ")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select ���,����,����,����,�������� from kongtiaoliechewopujiage where ��λ����='����'and ��������='��ͨ�г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][1].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�տ�")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select ���,����,����,����,�������� from kongtiaoliechewopujiage where ��λ����='����'and ��������='�տ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][1].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�ؿ�")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select ���,����,����,����,�������� from kongtiaoliechewopujiage where ��λ����='����'and ��������='�ؿ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][1].ToString());
							break;
						}
					}
				
				}
				
			
			}
			
			else if((kongtiao=="�յ�")&&(zuoweileixing=="������"))
			{
				
				if(leixing=="��ͨ")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select ���,����,����,����,�������� from kongtiaoliechewopujiage where ��λ����='����'and ��������='��ͨ�г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][3].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�տ�")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select ���,����,����,����,�������� from kongtiaoliechewopujiage where ��λ����='����'and ��������='�տ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][3].ToString());
							break;
						}
					}
				
				}
				else if(leixing=="�ؿ�")
				{  
					this.sqlDataAdapter_kongtiaochewopu.SelectCommand.CommandText="select ���,����,����,����,�������� from kongtiaoliechewopujiage where ��λ����='����'and ��������='�ؿ��г�'";
					if(this.sqlConnection2.State.ToString()=="Closed")
						this.sqlConnection2.Open();

					this.sqlDataAdapter_kongtiaochewopu.Fill(this.dskongtiaochewopu);
					int hangshu=this.dskongtiaochewopu.Tables[0].Rows.Count;
					for(int i=0;i<hangshu;i++)
					{
						if(lucheng>=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][0].ToString())&&lucheng<decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i+1][0].ToString()))
						{
							jiage=decimal.Parse(this.dskongtiaochewopu.Tables[0].Rows[i][3].ToString());
							break;
						}
					}
				
				}
				
			
			}
			return jiage*int.Parse(this.Text_ps.Text.Trim());
			
		}
		private Decimal jisuanlucheng()
		{  
			Decimal total=0m;  
			bool leiji=false;  //�Ƿ�ʼ�ۼ�
			dslucheng=new DataSet();
			 
               
			this.begin=this.DropDownList_qsz.SelectedItem.Value.ToString().Trim();
			this.end=this.DropDownList_zdz.SelectedItem.Value.ToString().Trim();

		

			sql="select ����վ,����վ,�г� from ticketsinf";
			sql+=" where ����='"+this.Text_checi.Text.Trim()+"'";

			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();

			this.sqlDataAdapter_ticketsinf.SelectCommand.CommandText=sql;
			this.sqlDataAdapter_ticketsinf.Fill(this.dslucheng);

			DataTable table_lucheng=this.dslucheng.Tables[0];

			int count = table_lucheng.Rows.Count;
			

			for(int i=0;i<count;i++)
			{
				string chufazhan=table_lucheng.Rows[i]["����վ"].ToString().Trim();
				string daodazhan=table_lucheng.Rows[i]["����վ"].ToString().Trim();

				if(chufazhan==this.begin )
					leiji=true;

				if(leiji==true)
					total+=Decimal.Parse(table_lucheng.Rows[i][2].ToString().Trim());

				if(daodazhan==this.end)
					leiji=false;
			}
			return total;
		}
		private void Button_qdcc_Click(object sender, System.EventArgs e)
		{
			
			this.cc=this.Text_checi.Text.Trim();
			if(cc!="")
			{
				xianshicheci(this.cc);
			}
		}

		private void Button_jg_Click(object sender, System.EventArgs e)
		{
			
			if(this.Text_ps.Text.Trim()=="")
			{
				Global.Alert(this,"����д��ȷ�Ķ�Ʊ��!");
				return;
			}
			else
			{
				Decimal yuanjia=jisuanjiage();
				Decimal xiantui=Global.TPBL*yuanjia;
				this.Label_yj.Text=Global.strFormate(yuanjia);
				this.Label_xt.Text=Global.strFormate(xiantui);	
			}
		}

	
	
		private void Button_tplx_Click(object sender, System.EventArgs e)
		{
			if(this.RadioButton_tuiding.Checked==true)
            this.Panel1.Visible=true;
			else  this.Panel1.Visible=false;
		}
		private void updatekucun(string checi,string type,string count)
		{
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sql="UPDATE tickets  SET "+type+"Ʊ��="+type+"Ʊ��+"+count;
			this.sql+=" WHERE  ����='"+checi+"'";
			this.sqlDataAdapter_tickets.UpdateCommand.CommandText=sql;

			this.sqlDataAdapter_tickets.UpdateCommand.ExecuteNonQuery();
			Global.Alert(this,"��Ʊ�ɹ�");
			this.chongzhi();
		}
		private void chongzhi()
		{
		    this.RadioButton_tuiding.Checked=false;
			this.RadioButton_tuipiao.Checked=false;
			this.Text_checi.Text="";
			this.TextBox_dz.Text="";
			this.TextBox_lxfs.Text="";
			this.Text_ps.Text="";
			this.TextBox_sfz.Text="";
			this.TextBox_xm.Text="";
			this.DropDownList_qsz.SelectedItem.Text="";
			this.DropDownList_zdz.SelectedItem.Text="";
			this.Label_xt.Text="";
			this.Label_yj.Text="";
			this.DropDownList_zwlx1.SelectedItem.Text="";
           
   
			this.DropDownList_nian.SelectedItem.Text="";
			this.DropDownList_yue.SelectedItem.Text="";
			this.DropDownList_ri.SelectedItem.Text="";
			
		}

		private void Button_tp_Click(object sender, System.EventArgs e)
		{
			if(this.RadioButton_tuipiao.Checked==true)
			{
			    string sj=this.DropDownList_nian.SelectedItem.Text.ToString()+"-"+this.DropDownList_yue.SelectedItem.Text.ToString()+"-"+this.DropDownList_ri.SelectedItem.Text.ToString();
				this.sqlDataAdapter_dingpiao.DeleteCommand.CommandText="delete from dingpiao where ����='"+this.Text_checi.Text.Trim()+"' and ����վ='"+this.DropDownList_qsz.SelectedItem.Text.ToString()+"'and ����վ='"+this.DropDownList_zdz.SelectedItem.Text.ToString()+"'and ��λ����='"+this.DropDownList_zwlx1.SelectedItem.Text.ToString()+"'and ��������='"+sj+"'";
				if(this.sqlConnection1.State.ToString()=="Closed")
					this.sqlConnection1.Open();

                   this.sqlDataAdapter_dingpiao.DeleteCommand.ExecuteNonQuery();


               updatekucun(this.Text_checi.Text,this.DropDownList_zwlx1.SelectedItem.Text.ToString(),this.Text_ps.Text);
             
				  
				this.chongzhi();

			}
			if(this.RadioButton_tuiding.Checked==true)
			{
			 
				string sj=this.DropDownList_nian.SelectedItem.Text.ToString()+"-"+this.DropDownList_yue.SelectedItem.Text.ToString()+"-"+this.DropDownList_ri.SelectedItem.Text.ToString();
				this.sqlDataAdapter_dingpiao.DeleteCommand.CommandText="delete from dingpiao where ����='"+this.Text_checi.Text.Trim()+"' and ����վ='"+this.DropDownList_qsz.SelectedItem.Text.ToString()+"'and ����վ='"+this.DropDownList_zdz.SelectedItem.Text.ToString()+"'and ��λ����='"+this.DropDownList_zwlx1.SelectedItem.Text.ToString()+"'and ��������='"+sj+"'and ���֤='"+this.TextBox_sfz.Text.ToString()+"'";
				if(this.sqlConnection1.State.ToString()=="Closed")
					this.sqlConnection1.Open();

				this.sqlDataAdapter_dingpiao.DeleteCommand.ExecuteNonQuery();


				updatekucun(this.Text_checi.Text,this.DropDownList_zwlx1.SelectedItem.Text.ToString(),this.Text_ps.Text);
             
				  
				this.chongzhi();

			}
		}

		private void Button_cz_Click(object sender, System.EventArgs e)
		{
			  
			this.chongzhi();

		}

	


		

		private void DropDownList_zwlx1_SelectedIndexChanged_1(object sender, System.EventArgs e)
		{
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
