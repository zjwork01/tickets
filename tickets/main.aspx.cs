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
	/// WebForm2 的摘要说明。
	/// </summary>
	public class WebForm2 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button_maipiao;
		protected System.Web.UI.WebControls.Button Button_dingpiao;
		protected System.Web.UI.WebControls.Button Button_tuipiao;
		protected System.Web.UI.WebControls.Button Button_chaxun;
		protected System.Web.UI.WebControls.Button Button_yhgl;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Label Label_LLQ;
		protected System.Web.UI.WebControls.Label Label_IP;
		protected System.Web.UI.WebControls.Label Label_yhm;
		protected System.Web.UI.WebControls.LinkButton LinkButton_grxx;
		protected System.Web.UI.WebControls.LinkButton LinkButton_xinwen;
		protected System.Web.UI.WebControls.LinkButton LinkButton_yjfk;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
	    
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if(Session["username"].ToString()=="admin")
				this.Button_yhgl.Visible=true;
			else  this.Button_yhgl.Visible=false;
		
		    this.Label_IP.Text=Page.Request.UserHostAddress;
			this.Label_LLQ.Text=Request.Browser.Version;
            this.Label_yhm.Text=Session["username"].ToString();
		
		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
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
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.Button_maipiao.Click += new System.EventHandler(this.Button_maipiao_Click);
			this.Button_dingpiao.Click += new System.EventHandler(this.Button_dingpiao_Click);
			this.Button_tuipiao.Click += new System.EventHandler(this.Button_tuipiao_Click);
			this.Button_chaxun.Click += new System.EventHandler(this.Button_chaxun_Click);
			this.Button_yhgl.Click += new System.EventHandler(this.Button_yhgl_Click);
			this.LinkButton_xinwen.Click += new System.EventHandler(this.LinkButton_xinwen_Click);
			this.LinkButton_grxx.Click += new System.EventHandler(this.LinkButton_grxx_Click);
			this.LinkButton_yjfk.Click += new System.EventHandler(this.LinkButton_yjfk_Click);
			this.Load += new System.EventHandler(this.Page_Load);

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

		private void Button_grzl_Click(object sender, System.EventArgs e)
		{
		;
			string msg;
			msg  = "<script language='javascript'>";
			msg +="window.open ('yhxx.aspx"+"','个人信息','height=200,width=650,top=150,left=250,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')"; 
			msg +="</script>";
			this.RegisterStartupScript("个人信息",msg);
		}

		private void LinkButton_grxx_Click(object sender, System.EventArgs e)
		{
		  
			string msg;
			msg  = "<script language='javascript'>";
			msg +="window.open ('yhxx.aspx"+"','个人信息','height=220,width=650,top=150,left=200,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')"; 
			msg +="</script>";
			this.RegisterStartupScript("个人信息",msg);
		}

		private void LinkButton_xinwen_Click(object sender, System.EventArgs e)
		{
		     Response.Redirect("xwgg.aspx");
		}

		private void LinkButton_yjfk_Click(object sender, System.EventArgs e)
		{
		
			string msg;
			msg  = "<script language='javascript'>";
			msg +="window.open ('yijianfankui.aspx"+"','意见反馈','height=220,width=650,top=150,left=250,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')"; 
			msg +="</script>";
			this.RegisterStartupScript("意见反馈",msg);
		}
	}
}
