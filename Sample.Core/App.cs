﻿using Cirrious.MvvmCross.Application;
using Cirrious.MvvmCross.ExtensionMethods;
using Cirrious.MvvmCross.Interfaces.ServiceProvider;
using Cirrious.MvvmCross.Interfaces.ViewModels;

namespace Sample.Core
{
    public class App
        : MvxApplication
        , IMvxServiceProducer
    {
        public App()
        {
            this.RegisterServiceInstance<IMvxStartNavigation>(new StartApplicationObject());
        }
    }
}