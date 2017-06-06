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
	/// zhuce ��ժҪ˵����
	/// </summary>
	public class zhuce : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button_maipiao;
		protected System.Web.UI.WebControls.Button Button_dingpiao;
		protected System.Web.UI.WebControls.Button Button_tuipiao;
		protected System.Web.UI.WebControls.Button Button_chaxun;
		protected System.Web.UI.WebControls.Button Button_yhgl;
		protected System.Web.UI.WebControls.TextBox TextBox_xingming;
		protected System.Web.UI.WebControls.TextBox TextBox_mima;
		protected System.Web.UI.WebControls.TextBox TextBox_mimacf;
		protected System.Web.UI.WebControls.Button Button_queding;
		protected System.Web.UI.WebControls.Button Button_chongzhi;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_user;
		protected System.Web.UI.WebControls.Label Label_mm;
		protected System.Web.UI.WebControls.RadioButton RadioButton_dsd;
		protected System.Web.UI.WebControls.RadioButton RadioButton_qydw;
		protected System.Web.UI.WebControls.TextBox TextBox_dsdz;
		protected System.Web.UI.WebControls.TextBox TextBox_dsfzr;
		protected System.Web.UI.WebControls.TextBox TextBox_dssfz;
		protected System.Web.UI.WebControls.Label Label_dsfzr;
		protected System.Web.UI.WebControls.Label Label_dwfzr;
		protected System.Web.UI.WebControls.Label Label_dwsfz;
		protected System.Web.UI.WebControls.TextBox TextBox_dslxfs;
		protected System.Web.UI.WebControls.TextBox TextBox_dwmc;
		protected System.Web.UI.WebControls.TextBox TextBox_dwfzr;
		protected System.Web.UI.WebControls.Label Label_dwmc;
		protected System.Web.UI.WebControls.Label Label_dssfz;
		protected System.Web.UI.WebControls.TextBox TextBox_dwsfz;
		protected System.Web.UI.WebControls.TextBox TextBox_dwlxfs;
		protected System.Web.UI.WebControls.TextBox TextBox_dwdz;
		protected System.Web.UI.WebControls.Label Label_dwlxfs;
		protected System.Web.UI.WebControls.Label Label_dwdz;
		protected System.Web.UI.WebControls.Label Label_dslxfs;
		protected System.Web.UI.WebControls.Label Label_dsdz;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		protected System.Web.UI.WebControls.Label Label_yhm;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Label Label_LLQ;
		protected System.Web.UI.WebControls.Label Label_IP;
		protected System.Data.DataSet dsyzyhm;
	   
		private void Page_Load(object sender, System.EventArgs e)
		{
			this.sqlConnection1.ConnectionString=data.connStr;
			// �ڴ˴������û������Գ�ʼ��ҳ��


			
			  this.Button_yhgl.Enabled=false;


			this.Label_dwdz.Visible=false;
			this.Label_dwfzr.Visible=false;
			this.Label_dwlxfs.Visible=false;
			this.Label_dwmc.Visible=false;
			this.Label_dwsfz.Visible=false;
			
			this.TextBox_dwdz.Visible=false;
			this.TextBox_dwfzr.Visible=false;
			this.TextBox_dwlxfs.Visible=false;
			this.TextBox_dwmc.Visible=false;
			this.TextBox_dwsfz.Visible=false;

			this.Label_dsdz.Visible=true;
			this.Label_dsfzr.Visible=true;
			this.Label_dslxfs.Visible=true;
			this.Label_dssfz.Visible=true;
			this.TextBox_dsdz.Visible=true;
			this.TextBox_dsfzr.Visible=true;
			this.TextBox_dslxfs.Visible=true;
			this.TextBox_dssfz.Visible=true;

			if(this.RadioButton_dsd.Checked==true)

			{
				this.Label_dwdz.Visible=false;
				this.Label_dwfzr.Visible=false;
				this.Label_dwlxfs.Visible=false;
				this.Label_dwmc.Visible=false;
				this.Label_dwsfz.Visible=false;
			
				this.TextBox_dwdz.Visible=false;
				this.TextBox_dwfzr.Visible=false;
				this.TextBox_dwlxfs.Visible=false;
				this.TextBox_dwmc.Visible=false;
				this.TextBox_dwsfz.Visible=false;

				this.Label_dsdz.Visible=true;
				this.Label_dsfzr.Visible=true;
				this.Label_dslxfs.Visible=true;
				this.Label_dssfz.Visible=true;
				this.TextBox_dsdz.Visible=true;
				this.TextBox_dsfzr.Visible=true;
				this.TextBox_dslxfs.Visible=true;
				this.TextBox_dssfz.Visible=true;

				
			
			}
			if(this.RadioButton_qydw.Checked==true)
			{
				this.Label_dsdz.Visible=false;
				this.Label_dsfzr.Visible=false;
				this.Label_dslxfs.Visible=false;
				this.Label_dssfz.Visible=false;
				this.TextBox_dsdz.Visible=false;
				this.TextBox_dsfzr.Visible=false;
				this.TextBox_dslxfs.Visible=false;
				this.TextBox_dssfz.Visible=false;
										
				this.Label_dwdz.Visible=true;
				this.Label_dwfzr.Visible=true;
				this.Label_dwlxfs.Visible=true;
				this.Label_dwmc.Visible=true;
				this.Label_dwsfz.Visible=true;
			
				this.TextBox_dwdz.Visible=true;
				this.TextBox_dwfzr.Visible=true;
				this.TextBox_dwlxfs.Visible=true;
				this.TextBox_dwmc.Visible=true;
				this.TextBox_dwsfz.Visible=true;

			
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
			this.sqlDataAdapter_user = new System.Data.SqlClient.SqlDataAdapter();
			this.Button_maipiao.Click += new System.EventHandler(this.Button_maipiao_Click);
			this.Button_dingpiao.Click += new System.EventHandler(this.Button_dingpiao_Click);
			this.Button_tuipiao.Click += new System.EventHandler(this.Button_tuipiao_Click);
			this.Button_chaxun.Click += new System.EventHandler(this.Button_chaxun_Click);
			this.Button_yhgl.Click += new System.EventHandler(this.Button_yhgl_Click);
			this.TextBox_mima.TextChanged += new System.EventHandler(this.TextBox_mima_TextChanged);
			this.TextBox_mimacf.TextChanged += new System.EventHandler(this.TextBox_mimacf_TextChanged);
			this.TextBox_dsfzr.TextChanged += new System.EventHandler(this.TextBox_dsfzr_TextChanged);
			this.Button_queding.Click += new System.EventHandler(this.Button1_Click);
			this.Button_chongzhi.Click += new System.EventHandler(this.Button_chongzhi_Click);
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ���, �û���, ����, ��ϵ��ʽ, ���� FROM [user]";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
				"ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE [user] SET ��� = @���, �û��� = @�û���, ���� = @����, ��ϵ��ʽ = @��ϵ��ʽ, ���� = @���� WHERE (��� = @Original_���) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (�û��� = @Original_�û��� OR @Original_�û��� IS NULL AND �û��� IS NULL) AND (��ϵ��ʽ = @Original_��ϵ��ʽ OR @Original_��ϵ��ʽ IS NULL AND ��ϵ��ʽ IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL); SELECT ���, �û���, ����, ��ϵ��ʽ, ���� FROM [user] WHERE (��� = @���)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Int, 4, "���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�û���", System.Data.SqlDbType.VarChar, 10, "�û���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 10, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ϵ��ʽ", System.Data.SqlDbType.VarChar, 50, "��ϵ��ʽ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 50, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û���", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ��ʽ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ��ʽ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM [user] WHERE (��� = @Original_���) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (�û��� = @Original_�û��� OR @Original_�û��� IS NULL AND �û��� IS NULL) AND (��ϵ��ʽ = @Original_��ϵ��ʽ OR @Original_��ϵ��ʽ IS NULL AND ��ϵ��ʽ IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û���", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ��ʽ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ��ʽ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
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
																																																				  new System.Data.Common.DataColumnMapping("����", "����")})});
			this.sqlDataAdapter_user.UpdateCommand = this.sqlUpdateCommand1;
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private int getNewID()
		{
			this.sqlDataAdapter_user.SelectCommand.CommandText="select ��� from [user]";
			DataSet dsxuhao=new DataSet();
			this.sqlDataAdapter_user.Fill(dsxuhao);
			if(dsxuhao.Tables[0].Rows.Count>0)
			{
				int newid=1;
				int count1=dsxuhao.Tables[0].Rows.Count;
				for(int i=0;i<count1;i++)
					newid+=1;
				return newid+1;
			}
			else
				return 1;
		}
		private int getbianhao()
		{
			this.sqlDataAdapter_user.SelectCommand.CommandText="select ���۵��� from [user] where  ���۵���!=''";
			DataSet dsbianhao=new DataSet();
			this.sqlDataAdapter_user.Fill(dsbianhao);
			if(dsbianhao.Tables[0].Rows.Count>0)
			{
				int newid=1;
				int count1=dsbianhao.Tables[0].Rows.Count;
				for(int i=0;i<count1;i++)
					newid+=1;
				return newid+1;
			}
			else
				return 1;
		}
		private int yanzhengyhm()
		{  dsyzyhm=new DataSet();
		  this.sqlDataAdapter_user.SelectCommand.CommandText="select * from [user] where �û���='"+this.TextBox_xingming.Text.Trim()+"'";
			if(this.sqlConnection1.State.ToString()=="Closed")
				this.sqlConnection1.Open();
			this.sqlDataAdapter_user.Fill(this.dsyzyhm);
			int ctyhm=this.dsyzyhm.Tables[0].Rows.Count;
			if(ctyhm>0)
		       return ctyhm;
			else return 0;
		}
		private void Button1_Click(object sender, System.EventArgs e)
		{
			if(this.RadioButton_dsd.Checked==true)
             
			{
				if((this.TextBox_dsdz.Text!="")&&(this.TextBox_dsfzr.Text!="")&&(this.TextBox_dslxfs.Text!="")&&(this.TextBox_xingming.Text!="")&&(this.TextBox_dssfz.Text!="")&&(this.TextBox_mima.Text!="")&&(this.TextBox_mimacf.Text!=""))
				{
					int ctyhm=this.yanzhengyhm();
					if(this.TextBox_xingming.Text.Length<6)
						Global.Alert(this,"�û������Ȳ���!");
					else 
					{
						if(this.TextBox_mima.Text.Length<8)
							Global.Alert(this,"���볤�Ȳ���!");
						else
						{
							if(ctyhm>0)
							
							{
								this.Label_yhm.Text="�û������ظ�!";
							
								goto end;
							}
							else 
							{

								if(this.TextBox_mima.Text.Trim()==this.TextBox_mimacf.Text.Trim())
								{
							
						
						
									int xuhao=this.getNewID();
									string xingming=this.TextBox_xingming.Text.Trim();
									string mima=this.TextBox_mima.Text.Trim();
					
									string fzr=this.TextBox_dsfzr.Text.Trim();
									string lxfs=this.TextBox_dslxfs.Text.Trim();
									string dz=this.TextBox_dsdz.Text.Trim();
									string sfz=this.TextBox_dssfz.Text.Trim();
									int   bianhao=this.getbianhao();
									int  yonghuleixing=1;
			
									this.sqlDataAdapter_user.InsertCommand.CommandText="insert into [user] (���,�û���,����,��ϵ��ʽ,������,���۵���,�����ַ,���֤,�û�����) values ('"+xuhao+"','"+xingming+"','"+mima+"','"+lxfs+"','"+fzr+"','"+bianhao+"','"+dz+"','"+sfz+"','"+yonghuleixing+"')";
		        
									if(this.sqlConnection1.State.ToString()=="Closed")
										this.sqlConnection1.Open();
									this.sqlDataAdapter_user.InsertCommand.ExecuteNonQuery();
							
									
									this.Response.Redirect("zhucechenggong.aspx");
								}
					
								else    	Global.Alert(this,"�����������벻һ��!");

							}
						}
					}
				}
				else  Global.Alert(this,"������Ϣ������,����!");
			}
			
		else 	if(this.RadioButton_qydw.Checked==true)
             
			{
				if((this.TextBox_dwdz.Text!="")&&(this.TextBox_dwfzr.Text!="")&&(this.TextBox_dwlxfs.Text!="")&&(this.TextBox_xingming.Text!="")&&(this.TextBox_dwsfz.Text!="")&&(this.TextBox_mima.Text!="")&&(this.TextBox_mimacf.Text!=""))
				{
					int ctyhm=this.yanzhengyhm();
					if(this.TextBox_xingming.Text.Length<6)
						Global.Alert(this,"�û������Ȳ���!");
					else
					{
						if(this.TextBox_mima.Text.Length<8)
							Global.Alert(this,"���볤�Ȳ���!");
						else
						{
							if(ctyhm>0)
							
							{
								this.Label_yhm.Text="�û������ظ�!";
						
								goto end;
							}
                           

							else
							{
								if(this.TextBox_mima.Text.Trim()==this.TextBox_mimacf.Text.Trim())
								{
									this.yanzhengyhm();
									int xuhao=this.getNewID();
									string xingming=this.TextBox_xingming.Text.Trim();
									string mima=this.TextBox_mima.Text.Trim();
					
									string fzr=this.TextBox_dwfzr.Text.Trim();
									string lxfs=this.TextBox_dwlxfs.Text.Trim();
									string dz=this.TextBox_dwdz.Text.Trim();
									string sfz=this.TextBox_dwsfz.Text.Trim();
									string dwmc=this.TextBox_dwmc.Text.Trim();
									int  yonghuleixing=2;
			
									this.sqlDataAdapter_user.InsertCommand.CommandText="insert into [user] (���,�û���,����,��ϵ��ʽ,������,��λȫ��,�����ַ,���֤,�û�����) values ('"+xuhao+"','"+xingming+"','"+mima+"','"+lxfs+"','"+fzr+"','"+dwmc+"','"+dz+"','"+sfz+"','"+yonghuleixing+"')";
		        
									if(this.sqlConnection1.State.ToString()=="Closed")
										this.sqlConnection1.Open();
									this.sqlDataAdapter_user.InsertCommand.ExecuteNonQuery();
								   this.Response.Redirect("zhucechenggong.aspx");
						
					
								}
								else    	Global.Alert(this,"�����������벻һ��!");

							}
						}
					}
				}
				else  Global.Alert(this,"������Ϣ������,����!");
			
			}
			
			
            end:  ;
		}
		private void chongzhi()
		{
			this.TextBox_dwlxfs.Text="";
			this.TextBox_mima.Text="";
			this.TextBox_mimacf.Text="";
			this.TextBox_xingming.Text="";
			this.TextBox_xingming.Text="";
			this.TextBox_dwsfz.Text="";
			this.TextBox_dwmc.Text="";
			this.TextBox_dwfzr.Text="";
			this.TextBox_dssfz.Text="";
			this.TextBox_dsdz.Text="";
			this.TextBox_dsfzr.Text="";
			this.TextBox_dslxfs.Text="";
			this.Label_dwdz.Text="";
			this.TextBox_dwdz.Text="";
		}

		private void Button_chongzhi_Click(object sender, System.EventArgs e)
		{
			
		    this.chongzhi();
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

		private void TextBox_mimacf_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void TextBox5_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void TextBox_mima_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void TextBox_dsfzr_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
