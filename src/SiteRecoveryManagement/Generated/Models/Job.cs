// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.WindowsAzure.Management.SiteRecovery.Models;

namespace Microsoft.WindowsAzure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a Job object.
    /// </summary>
    public partial class Job : ServiceResourceBase
    {
        private string _activityId;
        
        /// <summary>
        /// Required. Activity Id.
        /// </summary>
        public string ActivityId
        {
            get { return this._activityId; }
            set { this._activityId = value; }
        }
        
        private IList<string> _allowedActions;
        
        /// <summary>
        /// Required. Allowed action.
        /// </summary>
        public IList<string> AllowedActions
        {
            get { return this._allowedActions; }
            set { this._allowedActions = value; }
        }
        
        private string _displayName;
        
        /// <summary>
        /// Required. Localized name.
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private string _endTime;
        
        /// <summary>
        /// Required. End time stamp.
        /// </summary>
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private IList<ErrorDetails> _errors;
        
        /// <summary>
        /// Required. List of errors.
        /// </summary>
        public IList<ErrorDetails> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }
        
        private string _startTime;
        
        /// <summary>
        /// Required. Start time stamp.
        /// </summary>
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Required. Current State of the job. Example: "In Progress",
        /// "Cancelled"
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private string _stateDescription;
        
        /// <summary>
        /// Required. Description of the current state. It shows the detailed
        /// state of the job.
        /// </summary>
        public string StateDescription
        {
            get { return this._stateDescription; }
            set { this._stateDescription = value; }
        }
        
        private string _targetObjectId;
        
        /// <summary>
        /// Required. Affected ObjectId.
        /// </summary>
        public string TargetObjectId
        {
            get { return this._targetObjectId; }
            set { this._targetObjectId = value; }
        }
        
        private string _targetObjectName;
        
        /// <summary>
        /// Required. Affected object name.
        /// </summary>
        public string TargetObjectName
        {
            get { return this._targetObjectName; }
            set { this._targetObjectName = value; }
        }
        
        private string _targetObjectType;
        
        /// <summary>
        /// Required. Affected ObjectT ype.
        /// </summary>
        public string TargetObjectType
        {
            get { return this._targetObjectType; }
            set { this._targetObjectType = value; }
        }
        
        private IList<AsrTask> _tasks;
        
        /// <summary>
        /// Required. Tasks of the job object.
        /// </summary>
        public IList<AsrTask> Tasks
        {
            get { return this._tasks; }
            set { this._tasks = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        public Job()
        {
            this.AllowedActions = new LazyList<string>();
            this.Errors = new LazyList<ErrorDetails>();
            this.Tasks = new LazyList<AsrTask>();
        }
    }
}
