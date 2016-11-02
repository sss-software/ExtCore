﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Reflection;

namespace ExtCore.WebApplication
{
  /// <summary>
  /// Describes an assembly provider with the mechanism of getting assemblies that should be involved
  /// in the ExtCore types discovery process.
  /// </summary>
  public interface IAssemblyProvider
  {
    IEnumerable<Assembly> GetAssemblies(string path);
  }
}