using System;
using System.Collections;
using System.ComponentModel;
using System.Web;
using System.Web.SessionState;

namespace tickets 
{
	/// <summary>
	/// Global 的摘要说明。
	/// </summary>
	public class Global : System.Web.HttpApplication
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
	    public const Decimal TPBL=0.8m;
		private System.ComponentModel.IContainer components = null;
		public  static int counter=0;
		public  static int total=0;

		public Global()
		{
			InitializeComponent();
		}	
		public static void Alert(System.Web.UI.Page p,string mssage)
		{
			string msg;
			msg  = "<script language='javascript'>";
			msg +="alert('" + mssage + "');"; 
			msg +="</script>";
			p.RegisterStartupScript("alert",msg);
		}
		public static string strFormate(Decimal Source)
		{
			string str=String.Format("{0:C}", Source);
			return str;
		}
		

		protected void Application_Start(Object sender, EventArgs e)
		{
			counter=0;
			total=0;
		}
 
		protected void Session_Start(Object sender, EventArgs e)
		{
             counter++;
			 total++;
			
		}

		protected void Application_BeginRequest(Object sender, EventArgs e)
		{
         
		}

		protected void Application_EndRequest(Object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(Object sender, EventArgs e)
		{

		}

		protected void Application_Error(Object sender, EventArgs e)
		{

		}

		protected void Session_End(Object sender, EventArgs e)
		{
           counter--;
		}

		protected void Application_End(Object sender, EventArgs e)
		{
              
		}
			
		#region Web 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.components = new System.ComponentModel.Container();
		}
		#endregion
	}
}

