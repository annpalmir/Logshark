﻿using System;
using System.Collections.Generic;
using Tableau.RestApi.Model;

namespace Logshark.PluginModel.Model
{
    public interface IPluginResponse
    {
        string PluginName { get; }
        bool SuccessfulExecution { get; }
        string FailureReason { get; }
        bool GeneratedNoData { get; set; }
        ICollection<string> WorkbooksOutput { get; }
        ICollection<PublishedWorkbookResult> WorkbooksPublished { get; }

        TimeSpan PluginRunTime { get; set; }

        void SetExecutionOutcome(bool isSuccessful, string failureReason = null);

        void AppendError(string errorString);

        ICollection<string> GetErrors();

        void SetResponseArgument(string key, string value);

        string GetResponseArgument(string key);

        ICollection<string> GetResponseArgumentKeys();

        bool ContainsReponseArgument(string argumentName);
    }
}