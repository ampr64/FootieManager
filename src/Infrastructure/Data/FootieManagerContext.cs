using Application.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class FootieManagerContext : DbContext
    {
        public FootieManagerContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
