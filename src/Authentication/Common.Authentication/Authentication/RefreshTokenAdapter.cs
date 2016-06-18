﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Common.Authentication.Models;

namespace Microsoft.Azure.Common.Authentication.Authentication
{
    public class RefreshTokenAdapter : Rest.ITokenProvider
    {
        RefreshTokenProvider _provider;
        AdalConfiguration _config;
        AzureAccount _account;

        public RefreshTokenAdapter(RefreshTokenProvider provider, AzureAccount account, AdalConfiguration config)
        {
            _provider = provider;
            _account = account;
            _config = config;
        }

        public async Task<AuthenticationHeaderValue> GetAuthenticationHeaderAsync(CancellationToken cancellationToken)
        {
            // Adapt to execution environment which may or may not limit threads
            var scheduler = SynchronizationContext.Current != null
                ? TaskScheduler.FromCurrentSynchronizationContext()
                : TaskScheduler.Current;
            var task = new Task<IAccessToken>(
                () =>
                {
                    var taskToken = _provider.GetAccessTokenWithRefreshToken(_config, _account);
                    return taskToken;
                });
            task.Start(scheduler);
            var token = await task.ConfigureAwait(false);
            return new AuthenticationHeaderValue("Bearer", token.AccessToken);
        }
    }
}