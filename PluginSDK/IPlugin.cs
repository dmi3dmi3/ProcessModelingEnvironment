﻿using System;
using System.Collections.Generic;

namespace PluginSDK
{
    public interface IPlugin
    {
        String Name { get; }
        List<ICommand> commands { get; }
    }
}