using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Aits_PikedupBySazzad.DbContext
{
    public class AitsPikedupDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public AitsPikedupDbContext(DbContextOptions<AitsPikedupDbContext> options){}
    }
}
