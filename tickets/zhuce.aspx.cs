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
	/// zhuce 的摘要说明。
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
			// 在此处放置用户代码以初始化页面


			
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

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
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
			this.sqlSelectCommand1.CommandText = "SELECT 序号, 用户名, 密码, 联系方式, 邮箱 FROM [user]";
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
			this.sqlUpdateCommand1.CommandText = @"UPDATE [user] SET 序号 = @序号, 用户名 = @用户名, 密码 = @密码, 联系方式 = @联系方式, 邮箱 = @邮箱 WHERE (序号 = @Original_序号) AND (密码 = @Original_密码 OR @Original_密码 IS NULL AND 密码 IS NULL) AND (用户名 = @Original_用户名 OR @Original_用户名 IS NULL AND 用户名 IS NULL) AND (联系方式 = @Original_联系方式 OR @Original_联系方式 IS NULL AND 联系方式 IS NULL) AND (邮箱 = @Original_邮箱 OR @Original_邮箱 IS NULL AND 邮箱 IS NULL); SELECT 序号, 用户名, 密码, 联系方式, 邮箱 FROM [user] WHERE (序号 = @序号)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@序号", System.Data.SqlDbType.Int, 4, "序号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@用户名", System.Data.SqlDbType.VarChar, 10, "用户名"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@密码", System.Data.SqlDbType.VarChar, 10, "密码"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@联系方式", System.Data.SqlDbType.VarChar, 50, "联系方式"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@邮箱", System.Data.SqlDbType.VarChar, 50, "邮箱"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_密码", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "密码", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户名", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户名", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系方式", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系方式", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_邮箱", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "邮箱", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM [user] WHERE (序号 = @Original_序号) AND (密码 = @Original_密码 OR @Original_密码 IS NULL AND 密码 IS NULL) AND (用户名 = @Original_用户名 OR @Original_用户名 IS NULL AND 用户名 IS NULL) AND (联系方式 = @Original_联系方式 OR @Original_联系方式 IS NULL AND 联系方式 IS NULL) AND (邮箱 = @Original_邮箱 OR @Original_邮箱 IS NULL AND 邮箱 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_密码", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "密码", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户名", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户名", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系方式", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系方式", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_邮箱", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "邮箱", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter_user
			// 
			this.sqlDataAdapter_user.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter_user.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter_user.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter_user.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										  new System.Data.Common.DataTableMapping("Table", "user", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("序号", "序号"),
																																																				  new System.Data.Common.DataColumnMapping("用户名", "用户名"),
																																																				  new System.Data.Common.DataColumnMapping("密码", "密码"),
																																																				  new System.Data.Common.DataColumnMapping("联系方式", "联系方式"),
																																																				  new System.Data.Common.DataColumnMapping("邮箱", "邮箱")})});
			this.sqlDataAdapter_user.UpdateCommand = this.sqlUpdateCommand1;
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private int getNewID()
		{
			this.sqlDataAdapter_user.SelectCommand.CommandText="select 序号 from [user]";
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
			this.sqlDataAdapter_user.SelectCommand.CommandText="select 代售点编号 from [user] where  代售点编号!=''";
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
		  this.sqlDataAdapter_user.SelectCommand.CommandText="select * from [user] where 用户名='"+this.TextBox_xingming.Text.Trim()+"'";
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
						Global.Alert(this,"用户名长度不够!");
					else 
					{
						if(this.TextBox_mima.Text.Length<8)
							Global.Alert(this,"密码长度不够!");
						else
						{
							if(ctyhm>0)
							
							{
								this.Label_yhm.Text="用户名有重复!";
							
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
			
									this.sqlDataAdapter_user.InsertCommand.CommandText="insert into [user] (序号,用户名,密码,联系方式,负责人,代售点编号,具体地址,身份证,用户类型) values ('"+xuhao+"','"+xingming+"','"+mima+"','"+lxfs+"','"+fzr+"','"+bianhao+"','"+dz+"','"+sfz+"','"+yonghuleixing+"')";
		        
									if(this.sqlConnection1.State.ToString()=="Closed")
										this.sqlConnection1.Open();
									this.sqlDataAdapter_user.InsertCommand.ExecuteNonQuery();
							
									
									this.Response.Redirect("zhucechenggong.aspx");
								}
					
								else    	Global.Alert(this,"两次密码输入不一致!");

							}
						}
					}
				}
				else  Global.Alert(this,"输入信息不完整,请检查!");
			}
			
		else 	if(this.RadioButton_qydw.Checked==true)
             
			{
				if((this.TextBox_dwdz.Text!="")&&(this.TextBox_dwfzr.Text!="")&&(this.TextBox_dwlxfs.Text!="")&&(this.TextBox_xingming.Text!="")&&(this.TextBox_dwsfz.Text!="")&&(this.TextBox_mima.Text!="")&&(this.TextBox_mimacf.Text!=""))
				{
					int ctyhm=this.yanzhengyhm();
					if(this.TextBox_xingming.Text.Length<6)
						Global.Alert(this,"用户名长度不够!");
					else
					{
						if(this.TextBox_mima.Text.Length<8)
							Global.Alert(this,"密码长度不够!");
						else
						{
							if(ctyhm>0)
							
							{
								this.Label_yhm.Text="用户名有重复!";
						
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
			
									this.sqlDataAdapter_user.InsertCommand.CommandText="insert into [user] (序号,用户名,密码,联系方式,负责人,单位全称,具体地址,身份证,用户类型) values ('"+xuhao+"','"+xingming+"','"+mima+"','"+lxfs+"','"+fzr+"','"+dwmc+"','"+dz+"','"+sfz+"','"+yonghuleixing+"')";
		        
									if(this.sqlConnection1.State.ToString()=="Closed")
										this.sqlConnection1.Open();
									this.sqlDataAdapter_user.InsertCommand.ExecuteNonQuery();
								   this.Response.Redirect("zhucechenggong.aspx");
						
					
								}
								else    	Global.Alert(this,"两次密码输入不一致!");

							}
						}
					}
				}
				else  Global.Alert(this,"输入信息不完整,请检查!");
			
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
