using Oenskeportalen_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oenskeportalen_APP.Services
{
    internal interface IAbout
    {
        Task<AboutUs> getAbout();
    }
}
