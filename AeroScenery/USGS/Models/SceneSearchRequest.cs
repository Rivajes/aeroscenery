﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroScenery.USGS.Models
{
    public class SceneSearchRequest : USGSInventoryRequest
    {
        [JsonProperty("datasetName")]
        public string DatasetName { get; set; }

        [JsonProperty("spatialFilter")]
        public SpatialFilter SpatialFilter { get; set; }
    }
}
