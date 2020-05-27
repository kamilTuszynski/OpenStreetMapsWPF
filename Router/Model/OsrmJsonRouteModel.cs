﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Router.Model
{
    public class OsrmJsonRouteModel
    {
        public Route[] routes { get; set; }
        public Waypoint[] waypoints { get; set; }

        [JsonProperty("trips")]
        private Route[] trips { set { routes = value; } }
    }


    public class Waypoint
    {
        public string hint { get; set; }
        public float distance { get; set; }
        public string name { get; set; }
        public float[] location { get; set; }
    }

    public class Route
    {
        public GeometryOsrm geometry { get; set; }
        public Legs[] legs { get; set; }
        public string weightName { get; set; }
        public double weight { get; set; }
        public double duration { get; set; }
        public double distance { get; set; }
    }

    public class GeometryOsrm
    {
        public string type { get; set; }
        // format: [longitude, latitude]
        public float[][] coordinates { get; set; }
    }
    
    public class Legs
    {
    }
}