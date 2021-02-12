using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshopCar.ApplicationCore.Interfaces
{
    public interface IUriComposer
    {
        string ComposePicUri(string uriTemplate);
    }
}
