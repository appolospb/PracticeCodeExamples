using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ScottsWebClient.ScottsServiceReference; // Req to access exposed items in WCF service

// NOTE! - Visual Studio needs to be 'Run as administrator' otherwise hosting errors will occur

namespace ScottsWebClient
{
    public partial class GUI : System.Web.UI.Page
    {
        private ScottsServiceReference.ScottsServiceClient _client;

        public GUI()
        {
            _client = new ScottsServiceReference.ScottsServiceClient("BasicHttpBinding_IScottsService"); // This tells it what endpoint to use
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Btn_GetMessage_Click(object sender, EventArgs e)
        {
            Lbl_DspMessage.Text = _client.GetMessage(TxtBox_EnterMessage.Text);
        }

        protected void Btn_GetMoney_Click(object sender, EventArgs e)
        {
            GetMoneyRequest request = new GetMoneyRequest();
            GetMoneyResponse response = new GetMoneyResponse();

            request.AnnualSalary = Convert.ToInt32(TxtBox_EnterSalary.Text);
            request.WeeklyHoursWorked = Convert.ToDecimal(TxtBox_EnterHoursWorked.Text);

            try
            {
                response = _client.GetMoney(request);

                LblDspMoney.Text = string.Format("Monthly: £{0} Weekly: £{1} Daily: £{2} Hourly: £{3}", response.Monthly.ToString(), response.Weekly.ToString(), response.Daily.ToString(), response.Hourly.ToString());
            }
            catch (Exception ex)
            {
                LblDspMoney.Text = ex.ToString();
            }
        }
    }
}