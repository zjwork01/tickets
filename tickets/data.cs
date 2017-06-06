using System;

namespace tickets
{
	/// <summary>
	/// data 的摘要说明。
	/// </summary>
	public class data
	{
		public data()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		public static string connStr=System.Configuration.ConfigurationSettings.AppSettings["conn"].ToString();
	}
}
