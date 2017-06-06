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
    /// gengxincheci 的摘要说明。
    /// </summary>
    public class gengxincheci : System.Web.UI.Page
    {
        protected System.Data.SqlClient.SqlConnection sqlConnection1;
        protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_tickets;
        protected tickets.DataSet_tickts dataSet_tickets;
        protected System.Web.UI.HtmlControls.HtmlForm Form2;
        protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter_ticketsinf;
        protected tickets.DataSet_ticketsinf dataSet_ticketsinf;
        protected System.Web.UI.WebControls.Button Button_maipiao;
        protected System.Web.UI.WebControls.Button Button_dingpiao;
        protected System.Web.UI.WebControls.Button Button_tuipiao;
        protected System.Web.UI.WebControls.Button Button_chaxun;
        protected System.Web.UI.WebControls.Button Button_yhgl;
        protected System.Web.UI.WebControls.LinkButton LinkButton1;
        protected System.Web.UI.WebControls.LinkButton LinkButton2;
        protected System.Web.UI.WebControls.LinkButton LinkButton3;
        protected System.Web.UI.WebControls.LinkButton LinkButton4;
        protected System.Web.UI.WebControls.TextBox TextBox＿checi;
        protected System.Web.UI.WebControls.TextBox TextBox_qsz;
        protected System.Web.UI.WebControls.TextBox TextBox_zdz;
        protected System.Web.UI.WebControls.TextBox TextBox_kcsj;
        protected System.Web.UI.WebControls.TextBox TextBox_ddsj;
        protected System.Web.UI.WebControls.TextBox TextBox_yzps;
        protected System.Web.UI.WebControls.TextBox TextBox_ywsps;
        protected System.Web.UI.WebControls.TextBox TextBox_ywzps;
        protected System.Web.UI.WebControls.TextBox TextBox_ywxps;
        protected System.Web.UI.WebControls.TextBox TextBox_rwsps;
        protected System.Web.UI.WebControls.TextBox TextBox_rwzps;
        protected System.Web.UI.WebControls.TextBox TextBox_rwxps;
        protected System.Web.UI.WebControls.DropDownList DropDownList_ywkt;
        protected System.Web.UI.WebControls.DropDownList DropDownList_cllx;
        protected System.Web.UI.WebControls.TextBox TextBox_yzcxs;
        protected System.Web.UI.WebControls.TextBox TextBox_yzcxrs;
        protected System.Web.UI.WebControls.TextBox TextBox_ywcxs;
        protected System.Web.UI.WebControls.TextBox TextBox_ywcxrs;
        protected System.Web.UI.WebControls.TextBox TextBox_rwcxs;
        protected System.Web.UI.WebControls.TextBox TextBox_rwcxrs;
        protected System.Web.UI.WebControls.Button Button_zengjia;
        protected System.Web.UI.WebControls.Button gengxin;
        protected System.Web.UI.WebControls.Button Button_zjjbxx;
        protected System.Web.UI.WebControls.Button Button_xgjbxx;
        protected System.Web.UI.WebControls.Button Button_qrcc;
        protected System.Web.UI.WebControls.Button Button_zjldxx;
        protected System.Web.UI.WebControls.Button Button_czjbxx;
        protected System.Web.UI.WebControls.Button Button_scjbxx;
        protected System.Web.UI.WebControls.DataGrid DataGrid1;
        protected System.Web.UI.WebControls.TextBox Textbox_xgcc;
        protected System.Web.UI.WebControls.Button Button_xiugai;
        protected System.Web.UI.WebControls.Button Button_zj;
        protected System.Web.UI.WebControls.Button Button_czldxx;
        protected System.Web.UI.WebControls.Label xuhao;
        protected System.Web.UI.WebControls.TextBox TextBox_ldcc;
        protected System.Web.UI.WebControls.TextBox TextBox_ldcfz;
        protected System.Web.UI.WebControls.TextBox TextBox_ldddz;
        protected System.Web.UI.WebControls.TextBox Textbox_ldkcsj;
        protected System.Web.UI.WebControls.TextBox Textbox_ldddsj;
        protected System.Web.UI.WebControls.TextBox Textbox_lc;
        protected System.Web.UI.WebControls.Button Button_chongzhi;
        protected System.Web.UI.WebControls.Button Button_bjgx;
        protected System.Web.UI.WebControls.Button Button_bjzj;
        protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        protected System.Web.UI.WebControls.Image Image2;
        protected System.Web.UI.WebControls.Label Label_LLQ;
        protected System.Web.UI.WebControls.Label Label_IP;
        protected System.Web.UI.WebControls.LinkButton Linkbutton_xwgl;
        protected System.Web.UI.WebControls.LinkButton Linkbutton_xxfk;
        protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;


        private void Page_Load(object sender, System.EventArgs e)
        {
            this.sqlConnection1.ConnectionString = data.connStr;
            // 在此处放置用户代码以初始化页面
            if (Session["username"].ToString() == "admin")
                this.Button_yhgl.Visible = true;
            else this.Button_yhgl.Visible = false;

            if (!this.IsPostBack)
            {
                this.chushihua();

            }
            this.gengxin.Enabled = false;
            this.Button_zengjia.Enabled = false;
            this.Label_IP.Text = Page.Request.UserHostAddress;
            this.Label_LLQ.Text = Request.Browser.Version;
        }

        #region Web 窗体设计器生成的代码
        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
            //
            if (!this.IsPostBack)
            {
                if (Session["username"] == null)
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
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlDataAdapter_tickets = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dataSet_tickets = new tickets.DataSet_tickts();
            this.sqlDataAdapter_ticketsinf = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dataSet_ticketsinf = new tickets.DataSet_ticketsinf();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_tickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ticketsinf)).BeginInit();
            this.Button_maipiao.Click += new System.EventHandler(this.Button_maipiao_Click);
            this.Button_dingpiao.Click += new System.EventHandler(this.Button_dingpiao_Click);
            this.Button_tuipiao.Click += new System.EventHandler(this.Button_tuipiao_Click);
            this.Button_chaxun.Click += new System.EventHandler(this.Button_chaxun_Click);
            this.Button_yhgl.Click += new System.EventHandler(this.Button_yhgl_Click);
            this.LinkButton1.Click += new System.EventHandler(this.LinkButton1_Click);
            this.Linkbutton_xwgl.Click += new System.EventHandler(this.Linkbutton_xwgl_Click);
            this.Linkbutton_xxfk.Click += new System.EventHandler(this.Linkbutton_xxfk_Click);
            this.gengxin.Click += new System.EventHandler(this.gengxin_Click);
            this.Button_zjjbxx.Click += new System.EventHandler(this.Button_zjjbxx_Click);
            this.Button_xgjbxx.Click += new System.EventHandler(this.Button_xgjbxx_Click);
            this.Button_qrcc.Click += new System.EventHandler(this.Button_qrcc_Click);
            this.Button_zjldxx.Click += new System.EventHandler(this.Button_zjldxx_Click);
            this.DataGrid1.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_ItemCommand_1);
            this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged_1);
            this.Button_xiugai.Click += new System.EventHandler(this.Button_xiugai_Click);
            this.Button_zj.Click += new System.EventHandler(this.Button_zj_Click);
            this.Button_czldxx.Click += new System.EventHandler(this.Button_czldxx_Click);
            this.Button_bjzj.Click += new System.EventHandler(this.Button_bjzj_Click);
            this.Button_bjgx.Click += new System.EventHandler(this.Button_gengxin_Click);
            this.Button_chongzhi.Click += new System.EventHandler(this.Button_chongzhi_Click);
            this.Button_zengjia.Click += new EventHandler(this.Button_zengjia_Click);
            this.Button_czjbxx.Click += Button_czjbxx_Click;
            this.Button_scjbxx.Click += new EventHandler(this.Button_scjbxx_Click);

            

            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "workstation id=ZHAOWEIPING;packet size=4096;user id=sa;integrated security=SSPI;d" +
                "ata source=ZHAOWEIPING;persist security info=False;initial catalog=selltickets";
            // 
            // sqlDataAdapter_tickets
            // 
            this.sqlDataAdapter_tickets.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter_tickets.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter_tickets.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter_tickets.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                             new System.Data.Common.DataTableMapping("Table", "tickets", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("序号", "序号"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("车次", "车次"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("始发站", "始发站"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("终点站", "终点站"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("开车时间", "开车时间"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("到达时间", "到达时间"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("硬座票数", "硬座票数"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("硬卧上票数", "硬卧上票数"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("硬卧中票数", "硬卧中票数"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("硬卧下票数", "硬卧下票数"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("软卧上票数", "软卧上票数"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("软卧中票数", "软卧中票数"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("软卧下票数", "软卧下票数"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("有无空调", "有无空调"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("车辆类型", "车辆类型"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("硬座车厢数", "硬座车厢数"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("硬座车厢人数", "硬座车厢人数"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("硬卧车厢数", "硬卧车厢数"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("硬卧车厢人数", "硬卧车厢人数"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("软卧车厢数", "软卧车厢数"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("软卧车厢人数", "软卧车厢人数")})});
            this.sqlDataAdapter_tickets.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM tickets WHERE (车次 = @Original_车次)";
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_车次", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "车次", System.Data.DataRowVersion.Original, null));
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = @"INSERT INTO tickets(车次, 始发站, 终点站, 开车时间, 到达时间, 硬座票数, 硬卧上票数, 硬卧中票数, 硬卧下票数, 软卧上票数, 软卧中票数, 软卧下票数, 有无空调, 车辆类型, 硬座车厢数, 硬座车厢人数, 硬卧车厢数, 硬卧车厢人数, 软卧车厢数, 软卧车厢人数) VALUES (@车次, @始发站, @终点站, @开车时间, @到达时间, @硬座票数, @硬卧上票数, @硬卧中票数, @硬卧下票数, @软卧上票数, @软卧中票数, @软卧下票数, @有无空调, @车辆类型, @硬座车厢数, @硬座车厢人数, @硬卧车厢数, @硬卧车厢人数, @软卧车厢数, @软卧车厢人数)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车次", System.Data.SqlDbType.VarChar, 10, "车次"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@始发站", System.Data.SqlDbType.VarChar, 10, "始发站"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@终点站", System.Data.SqlDbType.VarChar, 10, "终点站"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@开车时间", System.Data.SqlDbType.DateTime, 8, "开车时间"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@到达时间", System.Data.SqlDbType.DateTime, 8, "到达时间"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座票数", System.Data.SqlDbType.Int, 4, "硬座票数"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧上票数", System.Data.SqlDbType.Int, 4, "硬卧上票数"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧中票数", System.Data.SqlDbType.Int, 4, "硬卧中票数"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧下票数", System.Data.SqlDbType.Int, 4, "硬卧下票数"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧上票数", System.Data.SqlDbType.Int, 4, "软卧上票数"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧中票数", System.Data.SqlDbType.Int, 4, "软卧中票数"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧下票数", System.Data.SqlDbType.Int, 4, "软卧下票数"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@有无空调", System.Data.SqlDbType.VarChar, 10, "有无空调"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@车辆类型", System.Data.SqlDbType.VarChar, 10, "车辆类型"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座车厢数", System.Data.SqlDbType.Int, 4, "硬座车厢数"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬座车厢人数", System.Data.SqlDbType.Int, 4, "硬座车厢人数"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧车厢数", System.Data.SqlDbType.Int, 4, "硬卧车厢数"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@硬卧车厢人数", System.Data.SqlDbType.Int, 4, "硬卧车厢人数"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧车厢数", System.Data.SqlDbType.Int, 4, "软卧车厢数"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@软卧车厢人数", System.Data.SqlDbType.Int, 4, "软卧车厢人数"));
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT 序号, 车次, 始发站, 终点站, 开车时间, 到达时间, 硬座票数, 硬卧上票数, 硬卧中票数, 硬卧下票数, 软卧上票数, 软卧中票数, 软卧下" +
                "票数, 有无空调, 车辆类型, 硬座车厢数, 硬座车厢人数, 硬卧车厢数, 硬卧车厢人数, 软卧车厢数, 软卧车厢人数 FROM tickets";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            // 
            // dataSet_tickets
            // 
            this.dataSet_tickets.DataSetName = "DataSet_tickts";
            this.dataSet_tickets.Locale = new System.Globalization.CultureInfo("zh-CN");
            // 
            // sqlDataAdapter_ticketsinf
            // 
            this.sqlDataAdapter_ticketsinf.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDataAdapter_ticketsinf.InsertCommand = this.sqlInsertCommand2;
            this.sqlDataAdapter_ticketsinf.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataAdapter_ticketsinf.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                              new System.Data.Common.DataTableMapping("Table", "ticketsinf", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                              new System.Data.Common.DataColumnMapping("序号", "序号"),
                                                                                                                                                                                                                              new System.Data.Common.DataColumnMapping("车次", "车次"),
                                                                                                                                                                                                                              new System.Data.Common.DataColumnMapping("开车时间", "开车时间"),
                                                                                                                                                                                                                              new System.Data.Common.DataColumnMapping("到达时间", "到达时间"),
                                                                                                                                                                                                                              new System.Data.Common.DataColumnMapping("出发站", "出发站"),
                                                                                                                                                                                                                              new System.Data.Common.DataColumnMapping("到达站", "到达站"),
                                                                                                                                                                                                                              new System.Data.Common.DataColumnMapping("行程", "行程")})});
            this.sqlDataAdapter_ticketsinf.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = "DELETE FROM ticketsinf WHERE (序号 = @Original_序号)";
            this.sqlDeleteCommand2.Connection = this.sqlConnection1;
            this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_序号", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "序号", System.Data.DataRowVersion.Original, null));
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT 序号, 车次, 开车时间, 到达时间, 出发站, 到达站, 行程 FROM ticketsinf";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.Connection = this.sqlConnection1;
            // 
            // dataSet_ticketsinf
            // 
            this.dataSet_ticketsinf.DataSetName = "DataSet_ticketsinf";
            this.dataSet_ticketsinf.Locale = new System.Globalization.CultureInfo("zh-CN");
            this.Load += new System.EventHandler(this.Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_tickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ticketsinf)).EndInit();

        }

        private void Button_czjbxx_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion
        private void chushihua()
        {
            this.TextBox_ddsj.Enabled = false;
            this.TextBox_kcsj.Enabled = false;
            this.TextBox_ldcc.Enabled = false;
            this.TextBox_ldcfz.Enabled = false;
            this.Textbox_ldddsj.Enabled = false;
            this.TextBox_ldddz.Enabled = false;
            this.Textbox_ldkcsj.Enabled = false;
            this.TextBox_qsz.Enabled = false;
            this.TextBox_rwcxrs.Enabled = false;
            this.TextBox_rwcxs.Enabled = false;
            this.TextBox_rwsps.Enabled = false;
            this.TextBox_rwxps.Enabled = false;
            this.TextBox_rwzps.Enabled = false;
            this.TextBox_ywcxrs.Enabled = false;
            this.TextBox_ywcxs.Enabled = false;
            this.TextBox_ywsps.Enabled = false;
            this.TextBox_ywxps.Enabled = false;
            this.TextBox_ywzps.Enabled = false;
            this.TextBox_yzcxrs.Enabled = false;
            this.TextBox_yzcxs.Enabled = false;
            this.TextBox_yzps.Enabled = false;
            this.TextBox_zdz.Enabled = false;
            this.TextBox＿checi.Enabled = false;
            this.DropDownList_cllx.Enabled = false;
            this.DropDownList_ywkt.Enabled = false;
            this.Button_zj.Enabled = false;
            this.Button_czldxx.Enabled = false;
            this.Textbox_xgcc.Enabled = false;
            this.Button_xiugai.Enabled = false;
            this.Button_bjzj.Enabled = false;
            this.Button_chongzhi.Enabled = false;
            this.Button_bjgx.Enabled = false;


        }

        private void Button_maipiao_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("maipiao.aspx?flag=1");
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

        private void Button_zjjbxx_Click(object sender, System.EventArgs e)
        {  //允许输入

            this.chushihuajbxx();//设置可以进行信息的录入
            this.Button_zengjia.Enabled = true;
            this.gengxin.Enabled = false;
        }
        private void chushihuajbxx()
        {
            this.TextBox_ddsj.Enabled = true;
            this.TextBox_kcsj.Enabled = true;
            this.TextBox_qsz.Enabled = true;
            this.TextBox_rwcxrs.Enabled = true;
            this.TextBox_rwcxs.Enabled = true;
            this.TextBox_rwsps.Enabled = true;
            this.TextBox_rwxps.Enabled = true;
            this.TextBox_rwzps.Enabled = true;
            this.TextBox_ywcxrs.Enabled = true;
            this.TextBox_ywcxs.Enabled = true;
            this.TextBox_ywsps.Enabled = true;
            this.TextBox_ywxps.Enabled = true;
            this.TextBox_ywzps.Enabled = true;
            this.TextBox_yzcxrs.Enabled = true;
            this.TextBox_yzcxs.Enabled = true;
            this.TextBox_yzps.Enabled = true;
            this.TextBox_zdz.Enabled = true;
            this.TextBox＿checi.Enabled = true;
            this.DropDownList_cllx.Enabled = true;
            this.DropDownList_ywkt.Enabled = true;
            this.Button_zengjia.Visible = true;
        }
        private void chongzhi()
        {
            this.TextBox_ddsj.Text = "";
            this.TextBox_kcsj.Text = "";
            this.TextBox_qsz.Text = "";
            this.TextBox_rwcxrs.Text = "";
            this.TextBox_rwcxs.Text = "";
            this.TextBox_rwsps.Text = "";
            this.TextBox_rwxps.Text = "";
            this.TextBox_rwzps.Text = "";
            this.TextBox_ywcxrs.Text = "";
            this.TextBox_ywcxs.Text = "";
            this.TextBox_ywsps.Text = "";
            this.TextBox_ywxps.Text = "";
            this.TextBox_ywzps.Text = "";
            this.TextBox_yzcxrs.Text = "";
            this.TextBox_yzcxs.Text = "";
            this.TextBox_yzps.Text ="";
            this.TextBox_zdz.Text = "";
            this.TextBox＿checi.Text = "";
            this.DropDownList_cllx.SelectedItem.Text = "";
            this.DropDownList_ywkt.SelectedItem.Text = "";
        }

        private void Button_scjbxx_Click(object sender, System.EventArgs e)
        {
            string id = TextBox＿checi.Text.Trim();//车次编号
            //检查是否有车次编号 
            if (id.Equals(""))
            {
                Global.Alert(this, "请输入要删除的车次");
                return;
            }
            //确认删除当前车次

            //删除当前车次
            string sql = "delete from tickets where ([车次]='" + id + "');";
            this.sqlDataAdapter_tickets.DeleteCommand.CommandText = sql;
            this.sqlDataAdapter_tickets.DeleteCommand.Parameters.Clear();
            if (this.sqlConnection1.State.ToString() == "Closed")
            {
                this.sqlConnection1.Open();
            }
            try
            {
                this.sqlDataAdapter_tickets.DeleteCommand.ExecuteNonQuery();
                Global.Alert(this, "删除成功");
            }catch(Exception ex)
            {
                Global.Alert(this, "删除失败");
            }
            this.chongzhi();
        }
        private void Button_zengjia_Click(object sender, System.EventArgs e)
        {
            if (this.TextBox_ddsj.Text.Trim() == "" && this.TextBox_kcsj.Text.Trim() == "" && this.TextBox_qsz.Text.Trim() == "" && this.TextBox_rwcxrs.Text.Trim() == "" && this.TextBox_rwcxs.Text.Trim() == "" && this.TextBox_rwsps.Text.Trim() == "" && this.TextBox_rwxps.Text.Trim() == "" && this.TextBox_rwzps.Text.Trim() == "" && this.TextBox_ywcxrs.Text.Trim() == "" && this.TextBox_ywcxs.Text.Trim() == "" && this.TextBox_ywsps.Text.Trim() == "" && this.TextBox_ywxps.Text.Trim() == "" && this.TextBox_ywzps.Text.Trim() == "" && this.TextBox_yzcxrs.Text.Trim() == "" && this.TextBox_yzcxs.Text.Trim() == "" && this.TextBox_yzps.Text.Trim() == "" && this.TextBox_zdz.Text.Trim() == "" && this.TextBox＿checi.Text.Trim() == "")
                Global.Alert(this, "车次基本信息输入不完整！");
            else
            {
                string sql = "insert into tickets (车次,始发站,终点站,开车时间,到达时间,硬座票数,硬卧上票数,硬卧中票数,硬卧下票数,软卧上票数,软卧中票数,软卧下票数,有无空调,车辆类型,硬座车厢数,硬座车厢人数,硬卧车厢数,硬卧车厢人数,软卧车厢数,软卧车厢人数) values (@车次1,@始发站1,@终点站1,@开车时间1,@到达时间1,@硬座票数1,@硬卧上票数1,@硬卧中票数1,@硬卧下票数1,@软卧上票数1,@软卧中票数1,@软卧下票数1,@有无空调1,@车辆类型1,@硬座车厢数1,@硬座车厢人数1,@硬卧车厢数1,@硬卧车厢人数1,@软卧车厢数1,@软卧车厢人数1)";
                this.sqlDataAdapter_tickets.InsertCommand.CommandText = sql;
                this.sqlDataAdapter_tickets.InsertCommand.Parameters.Clear();
                this.sqlDataAdapter_tickets.InsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[]
                {
                    new System.Data.SqlClient.SqlParameter("@车次1",this.TextBox＿checi.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@始发站1",this.TextBox_qsz.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@终点站1",this.TextBox_zdz.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@开车时间1",this.TextBox_kcsj.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@到达时间1",this.TextBox_ddsj.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@硬座票数1",this.TextBox_yzps.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@硬卧上票数1",this.TextBox_ywsps.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@硬卧中票数1",this.TextBox_ywzps.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@硬卧下票数1",this.TextBox_ywxps.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@软卧上票数1",this.TextBox_rwsps.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@软卧中票数1",this.TextBox_rwzps.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@软卧下票数1",this.TextBox_rwxps.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@有无空调1",this.DropDownList_ywkt.SelectedItem.Value.Trim()),
                    new System.Data.SqlClient.SqlParameter("@车辆类型1",this.DropDownList_cllx.SelectedItem.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@硬座车厢数1",this.TextBox_yzcxs.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@硬座车厢人数1",this.TextBox_yzcxrs.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@硬卧车厢数1",this.TextBox_ywcxs.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@硬卧车厢人数1",this.TextBox_ywcxrs.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@软卧车厢数1",this.TextBox_rwcxs.Text.Trim()),
                    new System.Data.SqlClient.SqlParameter("@软卧车厢人数1",this.TextBox_rwcxrs.Text.Trim())
                });
                if (this.sqlConnection1.State.ToString() == "Closed")
                    this.sqlConnection1.Open();
                try
                {
                    this.sqlDataAdapter_tickets.InsertCommand.ExecuteNonQuery();
                    Global.Alert(this, "车次基本信息增加成功!");
                }
                catch(Exception ex)
                {
                    Global.Alert(this,"添加车次失败");
                }
                
                this.chongzhi();
            }

        }

        private void Button_xgjbxx_Click(object sender, System.EventArgs e)
        {
            this.Button_zengjia.Enabled = false;
            this.gengxin.Enabled = true;
            this.chushihuajbxx();
        }

        private void Button_qrcc_Click(object sender, System.EventArgs e)
        {
            this.Button_zengjia.Enabled = false;
            this.gengxin.Enabled = true;
            if (this.TextBox＿checi.Text.Trim() == "")
                Global.Alert(this, "请输入车次!");

            else
            {
                this.sqlDataAdapter_tickets.SelectCommand.CommandText = "select * from tickets where 车次='" + this.TextBox＿checi.Text.Trim() + "'";
                if (this.sqlConnection1.State.ToString() == "Closed")
                    this.sqlConnection1.Open();
                this.sqlDataAdapter_tickets.Fill(this.dataSet_tickets);
                if(this.dataSet_tickets.Tables[0].Rows.Count == 0)
                {
                    Global.Alert(this, "不存在当前车次");
                    return;
                }
                this.TextBox_ddsj.Text = DateTime.Parse(this.dataSet_tickets.Tables[0].Rows[0]["到达时间"].ToString()).Hour + ":" + DateTime.Parse(this.dataSet_tickets.Tables[0].Rows[0]["到达时间"].ToString()).Minute;
                this.TextBox_kcsj.Text = DateTime.Parse(this.dataSet_tickets.Tables[0].Rows[0]["开车时间"].ToString()).Hour + ":" + DateTime.Parse(this.dataSet_tickets.Tables[0].Rows[0]["开车时间"].ToString()).Minute;
                this.TextBox_qsz.Text = this.dataSet_tickets.Tables[0].Rows[0]["始发站"].ToString().Trim();
                this.TextBox_rwcxrs.Text = this.dataSet_tickets.Tables[0].Rows[0]["软卧车厢人数"].ToString().Trim();
                this.TextBox_rwcxs.Text = this.dataSet_tickets.Tables[0].Rows[0]["软卧车厢数"].ToString().Trim();
                this.TextBox_rwsps.Text = this.dataSet_tickets.Tables[0].Rows[0]["软卧上票数"].ToString().Trim();
                this.TextBox_rwxps.Text = this.dataSet_tickets.Tables[0].Rows[0]["软卧下票数"].ToString().Trim();
                this.TextBox_rwzps.Text = this.dataSet_tickets.Tables[0].Rows[0]["软卧中票数"].ToString().Trim();
                this.TextBox_ywcxrs.Text = this.dataSet_tickets.Tables[0].Rows[0]["硬卧车厢人数"].ToString().Trim();
                this.TextBox_ywcxs.Text = this.dataSet_tickets.Tables[0].Rows[0]["硬卧车厢数"].ToString().Trim();
                this.TextBox_ywsps.Text = this.dataSet_tickets.Tables[0].Rows[0]["硬卧上票数"].ToString().Trim();
                this.TextBox_ywxps.Text = this.dataSet_tickets.Tables[0].Rows[0]["硬卧下票数"].ToString().Trim();
                this.TextBox_ywzps.Text = this.dataSet_tickets.Tables[0].Rows[0]["硬卧中票数"].ToString().Trim();
                this.TextBox_yzcxrs.Text = this.dataSet_tickets.Tables[0].Rows[0]["硬座车厢人数"].ToString().Trim();
                this.TextBox_yzcxs.Text = this.dataSet_tickets.Tables[0].Rows[0]["硬座车厢数"].ToString().Trim();
                this.TextBox_yzps.Text = this.dataSet_tickets.Tables[0].Rows[0]["硬座票数"].ToString().Trim();
                this.TextBox_zdz.Text = this.dataSet_tickets.Tables[0].Rows[0]["终点站"].ToString().Trim();
                this.DropDownList_cllx.SelectedItem.Text = this.dataSet_tickets.Tables[0].Rows[0]["车辆类型"].ToString().Trim();
                this.DropDownList_ywkt.SelectedItem.Text = this.dataSet_tickets.Tables[0].Rows[0]["有无空调"].ToString().Trim();

                this.TextBox＿checi.Enabled = false;
            }
        }

        private void gengxin_Click(object sender, System.EventArgs e)
        {
            if (this.TextBox_ddsj.Text.Trim() == "" && this.TextBox_kcsj.Text.Trim() == "" && this.TextBox_qsz.Text.Trim() == "" && this.TextBox_rwcxrs.Text.Trim() == "" && this.TextBox_rwcxs.Text.Trim() == "" && this.TextBox_rwsps.Text.Trim() == "" && this.TextBox_rwxps.Text.Trim() == "" && this.TextBox_rwzps.Text.Trim() == "" && this.TextBox_ywcxrs.Text.Trim() == "" && this.TextBox_ywcxs.Text.Trim() == "" && this.TextBox_ywsps.Text.Trim() == "" && this.TextBox_ywxps.Text.Trim() == "" && this.TextBox_ywzps.Text.Trim() == "" && this.TextBox_yzcxrs.Text.Trim() == "" && this.TextBox_yzcxs.Text.Trim() == "" && this.TextBox_yzps.Text.Trim() == "" && this.TextBox_zdz.Text.Trim() == "" && this.TextBox＿checi.Text.Trim() == "")
                Global.Alert(this, "车次基本信息输入不完整！");
            {

                string sql = "update  tickets set 始发站='" + this.TextBox_qsz.Text.Trim() + "',终点站='" + this.TextBox_zdz.Text.Trim() + "',开车时间='" + this.TextBox_kcsj.Text.Trim() + "',到达时间='" + this.TextBox_ddsj.Text.Trim() + "',硬座票数='" + this.TextBox_yzps.Text.Trim() + "',硬卧上票数='" + this.TextBox_ywsps.Text.Trim() + "',硬卧中票数='" + this.TextBox_ywzps.Text.Trim() + "',硬卧下票数='" + this.TextBox_ywxps.Text.Trim() + "',软卧上票数='" + this.TextBox_rwsps.Text.Trim() + "',软卧中票数='" + this.TextBox_rwzps.Text.Trim() + "',软卧下票数='" + this.TextBox_rwxps.Text.Trim() + "',有无空调='" + this.DropDownList_ywkt.SelectedItem.Value.ToString() + "',车辆类型='" + this.DropDownList_cllx.SelectedItem.Value.ToString() + "',硬座车厢数='" + this.TextBox_yzcxs.Text.Trim() + "',硬座车厢人数='" + this.TextBox_yzcxrs.Text.Trim() + "',硬卧车厢数='" + this.TextBox_rwcxs.Text.Trim() + "',硬卧车厢人数='" + this.TextBox_ywcxrs.Text.Trim() + "',软卧车厢数='" + this.TextBox_rwcxs.Text.Trim() + "',软卧车厢人数='" + this.TextBox_rwcxrs.Text.Trim() + "'where 车次='" + this.TextBox＿checi.Text.Trim() + "'";

                this.sqlDataAdapter_tickets.UpdateCommand.CommandText = sql;
                if (this.sqlConnection1.State.ToString() == "Closed")
                    this.sqlConnection1.Open();
                this.sqlDataAdapter_tickets.UpdateCommand.ExecuteNonQuery();
                Global.Alert(this, "更新成功!");
            }
        }

        private void Button_zjldxx_Click(object sender, System.EventArgs e)
        {
            this.Button_zj.Enabled = true;
            this.Button_czldxx.Enabled = true;
            this.Textbox_xgcc.Enabled = true;
            this.Button_xiugai.Enabled = true;
            this.Button_bjzj.Enabled = true;
            this.Button_chongzhi.Enabled = true;
            this.Button_bjgx.Enabled = true;
        }

        private void Button_zj_Click(object sender, System.EventArgs e)
        {
            this.TextBox_ldcc.Enabled = true;
            this.TextBox_ldcfz.Enabled = true;
            this.TextBox_ldddz.Enabled = true;
            this.Textbox_ldddsj.Enabled = true;
            this.Textbox_ldkcsj.Enabled = true;
            this.Button_bjzj.Enabled = true;
            this.Button_bjgx.Enabled = true;
        }

        private void Button_xiugai_Click(object sender, System.EventArgs e)
        {
            if (this.Textbox_xgcc.Text.Trim() == "")
                Global.Alert(this, "请输入要修改的车次!");
            else
            {
                this.sqlDataAdapter_ticketsinf.SelectCommand.CommandText = "select * from ticketsinf where 车次='" + this.Textbox_xgcc.Text.Trim() + "'";
                if (this.sqlConnection1.State.ToString() == "Closed")
                    this.sqlConnection1.Open();

                this.sqlDataAdapter_ticketsinf.Fill(this.dataSet_ticketsinf);
                this.DataGrid1.Visible = true;
                this.DataGrid1.DataBind();

            }
        }

        private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            this.DataGrid1.CurrentPageIndex = e.NewPageIndex;
            this.DataGrid1.DataBind();
        }


        private void xianshildxx(string xuhao)
        {
            this.sqlDataAdapter_ticketsinf.SelectCommand.CommandText = "select * from ticketsinf where 序号='" + xuhao + "'";
            if (this.sqlConnection1.State.ToString() == "Closed")
                this.sqlConnection1.Open();
            this.xuhao.Text = xuhao;
            this.sqlDataAdapter_ticketsinf.Fill(this.dataSet_ticketsinf);
            this.TextBox_ldcc.Text = this.dataSet_ticketsinf.Tables[0].Rows[0]["车次"].ToString().Trim();
            this.TextBox_ldcfz.Text = this.dataSet_ticketsinf.Tables[0].Rows[0]["出发站"].ToString().Trim();
            this.Textbox_ldddsj.Text = DateTime.Parse(this.dataSet_ticketsinf.Tables[0].Rows[0]["到达时间"].ToString()).Hour + ":" + DateTime.Parse(this.dataSet_ticketsinf.Tables[0].Rows[0]["到达时间"].ToString()).Minute;
            this.TextBox_ldddz.Text = this.dataSet_ticketsinf.Tables[0].Rows[0]["到达站"].ToString().Trim();
            this.Textbox_ldkcsj.Text = DateTime.Parse(this.dataSet_ticketsinf.Tables[0].Rows[0]["开车时间"].ToString()).Hour + ":" + DateTime.Parse(this.dataSet_ticketsinf.Tables[0].Rows[0]["开车时间"].ToString()).Minute;
            this.Textbox_lc.Text = this.dataSet_ticketsinf.Tables[0].Rows[0]["行程"].ToString().Trim();

            this.TextBox_ldcc.Enabled = true;
            this.TextBox_ldcfz.Enabled = true;
            this.TextBox_ldddz.Enabled = true;
            this.Textbox_ldddsj.Enabled = true;
            this.Textbox_ldkcsj.Enabled = true;

        }
        private int getid()
        {
            this.sqlDataAdapter_ticketsinf.SelectCommand.CommandText = "select * from ticketsinf";
            if (this.sqlConnection1.State.ToString() == "Closed")
                this.sqlConnection1.Open();
            this.sqlDataAdapter_ticketsinf.Fill(this.dataSet_ticketsinf);
            int xuhao = this.dataSet_ticketsinf.Tables[0].Rows.Count + 1;
            return xuhao;

        }

        private void Button_bjzj_Click(object sender, System.EventArgs e)
        {
            int xuhao = this.getid();
            if (this.TextBox_ldcc.Text.Trim() == "" && this.TextBox_ldcfz.Text.Trim() == "" && this.Textbox_ldddsj.Text.Trim() == "" && this.TextBox_ldddz.Text.Trim() == "" && this.Textbox_ldkcsj.Text.Trim() == "")
                Global.Alert(this, "路段信息输入不完整！");
            else
            {
                string sql = "insert into ticketsinf (序号,车次,出发站,到达站,开车时间,到达时间,行程) values ('" + xuhao + "','" + this.TextBox_ldcc.Text.Trim() + "','" + this.TextBox_ldcfz.Text.Trim() + "','" + this.TextBox_ldddz.Text.Trim() + "','" + this.Textbox_ldkcsj.Text.Trim() + "','" + this.Textbox_ldddsj.Text.Trim() + "','" + this.Textbox_lc.Text.Trim() + "')";

                this.sqlDataAdapter_ticketsinf.InsertCommand.CommandText = sql;
                if (this.sqlConnection1.State.ToString() == "Closed")
                    this.sqlConnection1.Open();
                this.sqlDataAdapter_ticketsinf.InsertCommand.ExecuteNonQuery();
                Global.Alert(this, "路段信息增加成功!");
            }


        }



        private void Button_gengxin_Click(object sender, System.EventArgs e)
        {

            string sql = "update  ticketsinf set 出发站='" + this.TextBox_ldcfz.Text.Trim() + "',到达站='" + this.TextBox_ldddz.Text.Trim() + "',开车时间='" + this.Textbox_ldkcsj.Text.Trim() + "',行程='" + this.Textbox_lc.Text.Trim() + "',到达时间='" + this.Textbox_ldddsj.Text.Trim() + "' where 序号='" + this.xuhao.Text.Trim() + "'";
            this.sqlDataAdapter_ticketsinf.UpdateCommand.CommandText = sql;
            if (this.sqlConnection1.State.ToString() == "Closed")
                this.sqlConnection1.Open();

            this.sqlDataAdapter_ticketsinf.UpdateCommand.ExecuteNonQuery();
            Global.Alert(this, "更新成功!");

        }

        private void DataGrid1_ItemCommand_1(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                string xuhao = this.DataGrid1.DataKeys[e.Item.ItemIndex].ToString();
                this.xianshildxx(xuhao);

            }
        }

        private void Button_czldxx_Click(object sender, System.EventArgs e)
        {
            this.dataSet_ticketsinf.Clear();
            this.DataGrid1.DataBind();
            this.DataGrid1.Visible = false;
            this.Textbox_xgcc.Text = "";
        }

        private void Button_chongzhi_Click(object sender, System.EventArgs e)
        {
            this.TextBox_ldcc.Text = "";
            this.TextBox_ldcfz.Text = "";
            this.Textbox_ldddsj.Text = "";
            this.TextBox_ldddz.Text = "";
            this.Textbox_lc.Text = "";
            this.Textbox_ldkcsj.Text = "";
            this.Button_bjzj.Enabled = true;
            this.Button_bjgx.Enabled = true;
        }

        private void DataGrid1_PageIndexChanged_1(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            this.sqlDataAdapter_ticketsinf.Fill(this.dataSet_ticketsinf);
            this.DataGrid1.CurrentPageIndex = e.NewPageIndex;
            this.DataGrid1.DataBind();
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
            Response.Redirect("chaxun.aspx");
        }

        private void Button_yhgl_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("yonghuguanlizhujiemian.aspx");
        }

        private void Linkbutton_xwgl_Click(object sender, System.EventArgs e)
        {

            string canshu = "checi=123";
            string msg;
            msg = "<script language='javascript'>";
            msg += "window.open ('xinwenguanli.aspx?" + canshu + "','新闻','height=500,width=750,top=50,left=50,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')";
            msg += "</script>";
            this.RegisterStartupScript("新闻", msg);
        }

        private void Linkbutton_xxfk_Click(object sender, System.EventArgs e)
        {
            string canshu = "checi=123";
            string msg;
            msg = "<script language='javascript'>";
            msg += "window.open ('guanliliuyan.aspx?" + canshu + "','留言','height=500,width=720,top=50,left=50,toolbar=no,menubar=no,scrollbars=no,resizable=no,location=no,status=no')";
            msg += "</script>";
            this.RegisterStartupScript("留言", msg);
        }
    }
}
