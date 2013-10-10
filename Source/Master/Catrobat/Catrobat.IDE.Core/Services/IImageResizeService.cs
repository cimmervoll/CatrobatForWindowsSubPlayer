﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catrobat.IDE.Core.Services.Data;

namespace Catrobat.IDE.Core.Services
{
    public interface IImageResizeService
    {
        PortableImage ResizeImage(PortableImage image, int maxWidthHeight);

        PortableImage ResizeImage(PortableImage image, int newWidth, int newHeight);
    }
}
