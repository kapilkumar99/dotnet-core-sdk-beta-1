﻿namespace AuthorizeNet.Api.Controllers
{
    using System;
    using AuthorizeNet.Api.Contracts.V1;
    using AuthorizeNet.Api.Controllers.Bases;
    public class getAUJobSummaryController : ApiOperationBase<getAUJobSummaryRequest, getAUJobSummaryResponse> {

	    public getAUJobSummaryController(getAUJobSummaryRequest apiRequest) : base(apiRequest) {
	    }

	    override protected void ValidateRequest() {
            var request = GetApiRequest();
	    }

        protected override void BeforeExecute()
        {
            var request = GetApiRequest();
        }
    }
}