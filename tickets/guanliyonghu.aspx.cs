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
	/// guanliyonghu ��ժҪ˵����
	/// </summary>
	public class guanliyonghu : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button_dingpiao;
		protected System.Web.UI.WebControls.Button Button_tuipiao;
		protected System.Web.UI.WebControls.Button Button_chaxun;
		protected System.Web.UI.WebControls.Button Button_yhgl;
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
		protected System.Web.UI.WebControls.LinkButton LinkButton2;
		protected System.Web.UI.WebControls.LinkButton LinkButton3;
		protected System.Web.UI.WebControls.LinkButton LinkButton4;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_user;
		protected tickets.DataSet_users dataSet_users;
		protected System.Web.UI.WebControls.TextBox TextBox_sousuo;
		protected System.Web.UI.WebControls.Button Button_sy;
		protected System.Web.UI.WebControls.Label Label_cx;
		protected System.Web.UI.WebControls.Button Button_sousuo;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Web.UI.WebControls.Button Button5;
		protected System.Web.UI.WebControls.Button Button4;
		protected System.Web.UI.WebControls.Label ct;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Label Label_LLQ;
		protected System.Web.UI.WebControls.Label Label_IP;
		protected System.Web.UI.WebControls.LinkButton Linkbutton_xwgl;
		protected System.Web.UI.WebControls.LinkButton Linkbutton_xxfk;
		protected System.Web.UI.WebControls.Button Button_maipiao;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection1.ConnectionString=data.connStr;
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if(Session["username"].ToString()=="admin")
				this.Button_yhgl.Visible=true;
			else  this.Button_yhgl.Visible=false;
			this.ct.Text=Global.counter.ToString();

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
			this.sqlDataAdapter_user = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dataSet_users = new tickets.DataSet_users();
			((System.ComponentModel.ISupportInitialize)(this.dataSet_users)).BeginInit();
			this.Button_maipiao.Click += new System.EventHandler(this.Button_maipiao_Click);
			this.Button_dingpiao.Click += new System.EventHandler(this.Button_dingpiao_Click);
			this.Button_tuipiao.Click += new System.EventHandler(this.Button_tuipiao_Click);
			this.Button_chaxun.Click += new System.EventHandler(this.Button_chaxun_Click);
			this.Button_yhgl.Click += new System.EventHandler(this.Button_yhgl_Click);
			this.LinkButton1.Click += new System.EventHandler(this.LinkButton1_Click);
			this.LinkButton2.Click += new System.EventHandler(this.LinkButton2_Click);
			this.LinkButton3.Click += new System.EventHandler(this.LinkButton3_Click);
			this.Linkbutton_xwgl.Click += new System.EventHandler(this.Linkbutton_xwgl_Click);
			this.LinkButton4.Click += new System.EventHandler(this.LinkButton4_Click);
			this.Button_sousuo.Click += new System.EventHandler(this.Button_sousuo_Click);
			this.Button_sy.Click += new System.EventHandler(this.Button_sy_Click);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.DataGrid1.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_ItemCommand);
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
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
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
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
			this.sqlUpdateCommand1.CommandText = "UPDATE [user] SET ��� = @���, �û��� = @�û���, ���� = @����, ��ϵ��ʽ = @��ϵ��ʽ, ������ = @������, ��λȫ�� " +
				"= @��λȫ��, �����ַ = @�����ַ, ���֤ = @���֤, ���۵��� = @���۵���, �û����� = @�û����� WHERE (��� = @Ori" +
				"ginal_���)";
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
			// 
			// dataSet_users
			// 
			this.dataSet_users.DataSetName = "DataSet_users";
			this.dataSet_users.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Linkbutton_xxfk.Click += new System.EventHandler(this.Linkbutton_xxfk_Click);
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet_users)).EndInit();

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

		private void Button1_Click(object sender, System.EventArgs e)
		{
			this.Label_cx.Visible=true;
			this.TextBox_sousuo.Visible=true;
			this.Button_sousuo.Visible=true;
			this.Button_sy.Visible=true;
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void Button_sousuo_Click(object sender, System.EventArgs e)
		{
			if(this.TextBox_sousuo.Text.Trim()!="")
			{
               this.sqlDataAdapter_user.SelectCommand.CommandText="select * from [user] where �û��� like '"+this.TextBox_sousuo.Text.Trim()+"%'";
				if(this.sqlConnection1.State.ToString()=="closed")
					this.sqlConnection1.Open();
				this.sqlDataAdapter_user.Fill(this.dataSet_users);
				this.DataGrid1.DataBind();
				this.DataGrid1.Visible=true;


			}
			else  Global.Alert(this,"����Ҫ���ҵ��û���");
		}

		private void Button_sy_Click(object sender, System.EventArgs e)
		{
			this.sqlDataAdapter_user.SelectCommand.CommandText="select * from [user]";
			if(this.sqlConnection1.State.ToString()=="closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_user.Fill(this.dataSet_users);
			this.DataGrid1.DataBind();
				this.DataGrid1.Visible=true;
		}

		private void Button5_Click(object sender, System.EventArgs e)
		{
			this.DataGrid1.Visible=false;
		}

		

		private void DataGrid1_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			if(e.CommandName=="Select")
			{
				string xuhao=this.DataGrid1.DataKeys[e.Item.ItemIndex].ToString();
               			
				string canshu="xh="+xuhao;
				string msg;
				msg  = "<script language='javascript'>";
				msg +="window.open ('bianjiyonghu.aspx?"+canshu+"','�û���Ϣ','height=200,width=700,top=250,left=150,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')"; 
				msg +="</script>";
				this.RegisterStartupScript("�û���Ϣ",msg);

				
			}
			else if(e.CommandName=="Delete")
			{
			  string xuhao=this.DataGrid1.DataKeys[e.Item.ItemIndex].ToString();
			  this.sqlDataAdapter_user.DeleteCommand.CommandText="delete from [user] where ���='"+xuhao+"'";
				if(this.sqlConnection1.State.ToString()=="Closed")
					this.sqlConnection1.Open();
				this.sqlDataAdapter_user.DeleteCommand.ExecuteNonQuery();
               Global.Alert(this,"ɾ���ɹ�!");
            
				
				this.sqlDataAdapter_user.SelectCommand.CommandText="select * from [user] ";
				if(this.sqlConnection1.State.ToString()=="closed")
					this.sqlConnection1.Open();
				this.sqlDataAdapter_user.Fill(this.dataSet_users);
				this.DataGrid1.DataBind();
				this.DataGrid1.Visible=true;

			
			}
		}

		private void Button4_Click(object sender, System.EventArgs e)
		{   string xuhao="0";
			string canshu="xh="+xuhao;
			string msg;
			msg  = "<script language='javascript'>";
			msg +="window.open ('bianjiyonghu.aspx?"+canshu+"','�û���Ϣ','height=200,width=700,top=250,left=150,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')"; 
			msg +="</script>";
			this.RegisterStartupScript("�û���Ϣ",msg);

		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{   this.sqlDataAdapter_user.Fill(this.dataSet_users);
			this.DataGrid1.CurrentPageIndex=e.NewPageIndex;
			this.DataGrid1.DataBind();
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
