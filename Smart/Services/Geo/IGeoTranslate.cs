using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Services.Geo
{
    public interface IGeoTranslate
    {
        Tuple<float, float> GetLatLong(int zipCode);
    }
}
