﻿using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroScenery.Common
{
    public class GMapProviderHelper
    {
        public static GMapProvider GetGMapProvider(string gmapProviderName)
        {
            switch (gmapProviderName)
            {
                case "EmptyProvider":
                    return GMapProviders.EmptyProvider;
                case "CzechTuristOldMap":
                    return GMapProviders.CzechTuristOldMap;
                case "CzechHybridOldMap":
                    return GMapProviders.CzechHybridOldMap;
                case "CzechSatelliteOldMap":
                    return GMapProviders.CzechSatelliteOldMap;
                case "CzechOldMap":
                    return GMapProviders.CzechOldMap;
                case "SpainMap":
                    return GMapProviders.SpainMap;
                case "CloudMadeMap":
                    return GMapProviders.CloudMadeMap;
                case "TurkeyMap":
                    return GMapProviders.TurkeyMap;
                case "MapBenderWMSdemoMap":
                    return GMapProviders.MapBenderWMSdemoMap;
                case "LatviaMap":
                    return GMapProviders.LatviaMap;
                case "LithuaniaTOP50Map":
                    return GMapProviders.LithuaniaTOP50Map;
                case "LithuaniaHybridOldMap":
                    return GMapProviders.LithuaniaHybridOldMap;
                case "LithuaniaHybridMap":
                    return GMapProviders.LithuaniaHybridMap;
                case "LithuaniaOrtoFotoOldMap":
                    return GMapProviders.LithuaniaOrtoFotoOldMap;
                case "LithuaniaOrtoFotoMap":
                    return GMapProviders.LithuaniaOrtoFotoMap;
                case "Lithuania3dMap":
                    return GMapProviders.Lithuania3dMap;
                case "CzechHistoryOldMap":
                    return GMapProviders.CzechHistoryOldMap;
                case "LithuaniaReliefMap":
                    return GMapProviders.LithuaniaReliefMap;
                case "CzechMap":
                    return GMapProviders.CzechMap;
                case "CzechHybridMap":
                    return GMapProviders.CzechHybridMap;
                case "SwedenMap":
                    return GMapProviders.SwedenMap;
                case "ArcGIS_DarbAE_Q2_2011_NAVTQ_Eng_V5_Map":
                    return GMapProviders.ArcGIS_DarbAE_Q2_2011_NAVTQ_Eng_V5_Map;
                case "ArcGIS_World_Topo_Map":
                    return GMapProviders.ArcGIS_World_Topo_Map;
                case "ArcGIS_World_Terrain_Base_Map":
                    return GMapProviders.ArcGIS_World_Terrain_Base_Map;
                case "ArcGIS_World_Street_Map":
                    return GMapProviders.ArcGIS_World_Street_Map;
                case "ArcGIS_World_Shaded_Relief_Map":
                    return GMapProviders.ArcGIS_World_Shaded_Relief_Map;
                case "ArcGIS_World_Physical_Map":
                    return GMapProviders.ArcGIS_World_Physical_Map;
                case "ArcGIS_Topo_US_2D_Map":
                    return GMapProviders.ArcGIS_Topo_US_2D_Map;
                case "ArcGIS_StreetMap_World_2D_Map":
                    return GMapProviders.ArcGIS_StreetMap_World_2D_Map;
                case "ArcGIS_ShadedRelief_World_2D_Map":
                    return GMapProviders.ArcGIS_ShadedRelief_World_2D_Map;
                case "ArcGIS_Imagery_World_2D_Map":
                    return GMapProviders.ArcGIS_Imagery_World_2D_Map;
                case "CzechGeographicMap":
                    return GMapProviders.CzechGeographicMap;
                case "CzechHistoryMap":
                    return GMapProviders.CzechHistoryMap;
                case "CzechTuristWinterMap":
                    return GMapProviders.CzechTuristWinterMap;
                case "CzechTuristMap":
                    return GMapProviders.CzechTuristMap;
                case "CzechSatelliteMap":
                    return GMapProviders.CzechSatelliteMap;
                case "LithuaniaMap":
                    return GMapProviders.LithuaniaMap;
                case "YandexHybridMap":
                    return GMapProviders.YandexHybridMap;
                case "GoogleMap":
                    return GMapProviders.GoogleMap;
                case "YahooHybridMap":
                    return GMapProviders.YahooHybridMap;
                case "YahooSatelliteMap":
                    return GMapProviders.YahooSatelliteMap;
                case "YahooMap":
                    return GMapProviders.YahooMap;
                case "BingOSMap":
                    return GMapProviders.BingOSMap;
                case "BingHybridMap":
                    return GMapProviders.BingHybridMap;
                case "BingSatelliteMap":
                    return GMapProviders.BingSatelliteMap;
                case "BingMap":
                    return GMapProviders.BingMap;
                case "WikiMapiaMap":
                    return GMapProviders.WikiMapiaMap;
                case "OpenSeaMapHybrid":
                    return GMapProviders.OpenSeaMapHybrid;
                case "OpenStreetMapQuestHybrid":
                    return GMapProviders.OpenStreetMapQuestHybrid;
                case "OpenStreetMapQuestSattelite":
                    return GMapProviders.OpenStreetMapQuestSattelite;
                case "OpenStreetMapQuest":
                    return GMapProviders.OpenStreetMapQuest;
                case "OpenCycleTransportMap":
                    return GMapProviders.OpenCycleTransportMap;
                case "OpenCycleLandscapeMap":
                    return GMapProviders.OpenCycleLandscapeMap;
                case "OpenCycleMap":
                    return GMapProviders.OpenCycleMap;
                case "YandexSatelliteMap":
                    return GMapProviders.YandexSatelliteMap;
                case "OpenStreet4UMap":
                    return GMapProviders.OpenStreet4UMap;
                case "GoogleSatelliteMap":
                    return GMapProviders.GoogleSatelliteMap;
                case "GoogleTerrainMap":
                    return GMapProviders.GoogleTerrainMap;
                case "YandexMap":
                    return GMapProviders.YandexMap;
                case "HereTerrainMap":
                    return GMapProviders.HereTerrainMap;
                case "HereHybridMap":
                    return GMapProviders.HereHybridMap;
                case "HereSatelliteMap":
                    return GMapProviders.HereSatelliteMap;
                case "HereMap":
                    return GMapProviders.HereMap;
                case "NearHybridMap":
                    return GMapProviders.NearHybridMap;
                case "NearSatelliteMap":
                    return GMapProviders.NearSatelliteMap;
                case "NearMap":
                    return GMapProviders.NearMap;
                case "GoogleKoreaHybridMap":
                    return GMapProviders.GoogleKoreaHybridMap;
                case "GoogleKoreaSatelliteMap":
                    return GMapProviders.GoogleKoreaSatelliteMap;
                case "GoogleKoreaMap":
                    return GMapProviders.GoogleKoreaMap;
                case "GoogleChinaTerrainMap":
                    return GMapProviders.GoogleChinaTerrainMap;
                case "GoogleChinaHybridMap":
                    return GMapProviders.GoogleChinaHybridMap;
                case "GoogleChinaSatelliteMap":
                    return GMapProviders.GoogleChinaSatelliteMap;
                case "GoogleChinaMap":
                    return GMapProviders.GoogleChinaMap;
                case "GoogleHybridMap":
                    return GMapProviders.GoogleHybridMap;
                case "OpenStreetMap":
                    return GMapProviders.OpenStreetMap;
                default:
                    return GMapProviders.GoogleHybridMap;
            }
        }
    }
}