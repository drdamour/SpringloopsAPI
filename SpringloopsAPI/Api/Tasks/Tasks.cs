//-----------------------------------------------------------------------
// <copyright file="Issues.cs" company="TemporalCohesion.co.uk">
//     Copyright 2012 - Present Stuart Grassie
//
//     Licensed under the Apache License, Version 2.0 (the "License");
//     you may not use this file except in compliance with the License.
//     You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//     Unless required by applicable law or agreed to in writing, software
//     distributed under the License is distributed on an "AS IS" BASIS,
//     WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//     See the License for the specific language governing permissions and
//     limitations under the License.
// </copyright>
//----------------------------------------------------------------------

using LoggingExtensions.Logging;
using RestSharp;
using System;
using System.Dynamic;
namespace SpringloopsAPI.Api.Tasks
{
    public static class Issues
    {
        private static readonly ILog Log = LoggingExtensions.Logging.Log.GetLoggerFor(typeof(Issues).FullName);

        /// <summary>
        /// Get's all task summaries from a specified report
        /// </summary>
        /// <param name="client">The <see cref="SpringloopsAPIClient"/> instance to attach to.</param>
        /// <typeparam name="TTaskReportSummary">The task report summary model to serialise the JSON data into.</typeparam>
        /// <returns>A <see cref="IRestResponse{TTaskReportSummary}"/> for the issues.</returns>
        public static IRestResponse<TTaskReportSummary> GetTaskSummaries<TTaskReportSummary>(this SpringloopsAPIClient client, long ReportID) where TTaskReportSummary : new()
        {
            Log.Info(() => "Making request for the tasks.");
            var request = client.RequestFactory.CreateRequest(
                () =>
                {
                    var req = new RestRequest("tasks/{reportID}?format=json")
                    {
                        Method = Method.GET
                    };
                    req.AddUrlSegment("reportID", ReportID.ToString());
                    return req;
                }
            );

            var response = client.Execute<TTaskReportSummary>(request);

            return response;
        }


        /// <summary>
        /// Get's all data for a specified task
        /// </summary>
        /// <param name="client">The <see cref="SpringloopsAPIClient"/> instance to attach to.</param>
        /// <typeparam name="TTaskWrapper">The task wrapper model to serialise the JSON data into.</typeparam>
        /// <returns>A <see cref="IRestResponse{TTaskWrapper}"/> for the issues.</returns>
        public static IRestResponse<TTaskWrapper> GetTask<TTaskWrapper>(this SpringloopsAPIClient client, long TicketID) where TTaskWrapper : new()
        {
            Log.Info(() => "Making request for the tasks.");
            var request = client.RequestFactory.CreateRequest(
                () =>
                {
                    var req = new RestRequest("/ajax/fetch-ticket.html")
                    {
                        Method = Method.GET
                    };
                    req.AddParameter("ticketId", TicketID.ToString());
                    return req;
                }
            );

            var response = client.Execute<TTaskWrapper>(request);

            return response;
        }
        
    }
}
