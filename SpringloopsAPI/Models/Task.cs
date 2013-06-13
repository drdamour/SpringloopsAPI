//-----------------------------------------------------------------------
// <copyright file="Issue.cs" company="TemporalCohesion.co.uk">
//     Copyright [2010] [Stuart Grassie]
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

using System.Collections.Generic;
namespace SpringloopsAPI.Models
{
    /// <summary>
    /// Maps to an issue summary
    /// </summary>
    public class Task: TaskSummary
    {
        /// <summary>
        /// Gets or sets the assignees of this task
        /// </summary>
        public virtual List<User> Assignment { get; set; }


        /// <summary>
        /// Gets or sets the labels this task is tagged with
        /// </summary>
        public virtual List<Label> TicketLabels { get; set; }

        /// <summary>
        /// Gets or sets the updates (comments) of this task
        /// </summary>
        public virtual List<TaskUpdate> Updates { get; set; }


        /// <summary>
        /// Gets or sets the added attachments) of this task
        /// </summary>
        public virtual List<Attachment> AttachmentsAdd { get; set; }


        /// <summary>
        /// Gets or sets the updated attachments of this task
        /// </summary>
        public virtual List<Attachment> AttachmentsUpdate { get; set; }

        /// <summary>
        /// Gets or sets the status of this task
        /// </summary>
        public virtual Status Status { get; set; }
    }
}
