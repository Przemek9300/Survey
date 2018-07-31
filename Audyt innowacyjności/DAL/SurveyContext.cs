using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audyt_innowacyjności.DAL
{
    public class SurveyContext: DbContext
    {
        public DbSet<Survey> Surveys { get; set; }

    }
}
