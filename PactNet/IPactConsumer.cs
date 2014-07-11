﻿using System;
using PactNet.Mocks.MockHttpService;

namespace PactNet
{
    public interface IPactConsumer : IDisposable
    {
        string ConsumerName { get; }
        string ProviderName { get; }
        string PactFileUri { get; }
        IPactConsumer ServiceConsumer(string consumerName);
        IPactConsumer HasPactWith(string providerName);
        IMockProviderService MockService(int port);
    }
}