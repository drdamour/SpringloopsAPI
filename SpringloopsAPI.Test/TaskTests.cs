using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SpringloopsAPI.Api.Tasks;
using SpringloopsAPI.Models;
using RestSharp;

using System.Linq;

using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace SpringloopsAPI.Test
{
    [TestClass]
    public class TaskTests
    {
        protected string Url = "";
        protected int ReportID = -1;

        [TestMethod]
        public void GetTaskSummariesTest()
        {
            var client = new SpringloopsAPI.SpringloopsAPIClient(Url).WithAuthentication(new cookieauth());
            var result = client.GetTaskSummaries<TaskReportSummary>(ReportID);

        }

        [TestMethod]
        public void GetTaskDataTest()
        {
            //long TaskID = 146878;
            long TaskID = 153722;
            var client = new SpringloopsAPI.SpringloopsAPIClient(Url).WithAuthentication(new cookieauth());
            var result = client.GetTask<TaskWrapper>(TaskID);


            var slclient = new SpringloopsAPIClient(Url).WithAuthentication(new cookieauth());



            var result2 = slclient.GetTaskSummaries<TaskReportSummary>(ReportID);
            var AllTasks = new List<Task>();
            foreach (var r in result2.Data.Tickets)
            {
                AllTasks.Add(slclient.GetTask<TaskWrapper>(r.Id).Data.Ticket);
            }

            var TasksWithAttachments = AllTasks.Where(x => x.AttachmentsUpdate.Count() > 0).ToArray();

        }

    }


    public class cookieauth : IAuthenticator
    {

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.AddCookie("SLS2_SESSIDv4", "");
        }
    }



}
