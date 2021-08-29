using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderDesignPatternDemo.Models;

namespace BuilderDesignPatternDemo.Services
{
    public interface IPlanDirector
    {
        void SetPlanBuilder(IPlanBuilder builder);

        void BuildBasicPlan();

        void BuildEnterprisePlan(); 
    }
}
