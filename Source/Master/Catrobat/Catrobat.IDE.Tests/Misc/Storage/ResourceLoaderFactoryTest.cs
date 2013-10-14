﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catrobat.IDE.Core.Services.Storage;

namespace Catrobat.IDE.Tests.Misc.Storage
{
  public class ResourceLoaderFactoryTest : IResourceLoaderFactory
  {
    public IResourceLoader CreateResourceLoader()
    {
      return new ResourcesTest();
    }
  }
}