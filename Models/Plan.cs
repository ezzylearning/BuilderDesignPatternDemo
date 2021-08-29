using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPatternDemo.Models
{
    public class Plan
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public List<Feature> Features { get; set; } = new List<Feature>();

        public void AddFeature(Feature feature)
        {
            Features.Add(feature);
        } 
    }
}
