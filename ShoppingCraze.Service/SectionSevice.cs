using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCraze.Entities;
using ShoppingCraze.Service.Interfaces;

namespace ShoppingCraze.Service
{
    public class SectionSevice : ServiceBase<Section>, ISectionService
    {
        public SectionSevice(DbContext context): base(context)
        {           
        }
    }
}
