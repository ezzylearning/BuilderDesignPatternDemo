using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderDesignPatternDemo.Models;

namespace BuilderDesignPatternDemo.Services
{
    public class EnterprisePlanBuilder : IPlanBuilder
    {
        public Plan Plan { get; set; } = new Plan();

        public EnterprisePlanBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            Plan = new Plan() { Name = "Enterprise", Price = 49 };
        }

        public void BuildDiskSpaceFeature()
        {
            Plan.AddFeature(new Feature() { Title = "Disk Space", Value = "100 GB" });
        }

        public void BuildDatabaseFeature()
        {
            Plan.AddFeature(new Feature() { Title = "Database Size", Value = "300 GB" });
        }

        public void BuildBandwidthFeature()
        {
            Plan.AddFeature(new Feature() { Title = "Bandwidth", Value = "Unlimited" });
        }

        public void BuildSslFeature()
        {
            Plan.AddFeature(new Feature() { Title = "SSL", Value = "Free" });
        }

        public Plan GetPlan()
        {
            Plan result = Plan;

            this.Reset();

            return result;
        }
    }
}
