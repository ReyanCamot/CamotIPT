using IPT102CamotDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT102CamotDomain.Commands
{
    internal interface IDeleteMovie
    {
        Task<bool> ExecuteAsync(MovieModel model);

    }
}
