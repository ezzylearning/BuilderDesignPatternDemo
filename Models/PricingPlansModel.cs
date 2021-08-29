using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPatternDemo.Models
{
    public class PricingPlansModel
    {
        public Plan BasicPlan { get; set; }
        public Plan EnterprisePlan { get; set; }
        public Plan CustomPlan { get; set; }
    }
}
