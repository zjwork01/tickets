using System;

namespace tickets
{
	/// <summary>
	/// data ��ժҪ˵����
	/// </summary>
	public class data
	{
		public data()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
		public static string connStr=System.Configuration.ConfigurationSettings.AppSettings["conn"].ToString();
	}
}
