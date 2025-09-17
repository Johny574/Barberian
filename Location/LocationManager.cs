



public static class LocationManager
{
    public static float[,] Graph;
    public static Dictionary<string, Location> Locations = new()
    {
        {"Eldrathen",
            new Location("Eldrathen" ,
            new Dictionary<string, float>() {
                    {"Solenthra", 1f},
                    {"Thalorwyn", 1f},
                    {"Cindrallis", 1f}
                }
            )
        },

        {"Solenthra",
            new Location("Solenthra" ,
            new Dictionary<string, float>() {
                    {"Eldrathan", 1f},
                    {"Thalorwyn", 1f},
                    {"Frostmere", 1f},
                    {"Velmoria", 1f}
                }
            )
        },
        {"Velmoria",
            new Location("Velmoria" ,
            new Dictionary<string, float>() {
                    {"Seastrand", 1f},
                    {"Sylvarin", 1f},
                    {"Frostmere", 1f},
                    {"Solenthra", 1f},
                }
            )
        },
        {"Seastrand",
            new Location("Seastrand" ,
            new Dictionary<string, float>() {
                    {"Velmoria", 1f},
                    {"Sylvarin", 1f},
                    {"Thornwick", 1f},
                }
            )
        },

        {"Cindrallis",
            new Location("Cindrallis" ,
            new Dictionary<string, float>() {
                    {"Eldrathen", 1f},
                    {"Thalorwyn", 1f},
                    {"Nymara", 1f},
                    {"Grimhallow", 1f},
                }
            )
        },

        {"Thalorwyn",
            new Location("Thalorwyn" ,
            new Dictionary<string, float>() {
                    {"Eldrathen", 1f},
                    {"Solenthra", 1f},
                    {"Frostmere", 1f},
                    {"Drakenshed", 1f},
                    {"Nymara", 1f},
                    {"Cindrallis", 1f},
                }
            )
        },

        {"Frostmere",
            new Location("Frostmere" ,
            new Dictionary<string, float>() {
                    {"Velmoria", 1f},
                    {"Sylvarin", 1f},
                    {"Drakenshed", 1f},
                    {"Thalorwyn", 1f},
                    {"Solenthra", 1f},
                }
            )
        },

        {"Sylvarin",
            new Location("Sylvarin" ,
            new Dictionary<string, float>() {
                    {"Seastrand", 1f},
                    {"Thornwick", 1f},
                    {"Brumblehallow", 1f},
                    {"Drakenshed", 1f},
                    {"Frostmere", 1f},
                    {"Velmoria", 1f},
                }
            )
        },

        {"Thornwick",
            new Location("Thornwick" ,
            new Dictionary<string, float>() {
                    {"Seastrand", 1f},
                    {"Sylvarin", 1f},
                    {"Brumblehallow", 1f},
                    {"Lunebrook", 1f},
                }
            )
        },

        {"Drakenshed",
            new Location("Drakenshed" ,
            new Dictionary<string, float>() {
                    {"Sylvarin", 1f},
                    {"Brumblehallow", 1f},
                    {"Aerenthal", 1f},
                    {"Thalorwyn", 1f},
                    {"Frostmere", 1f},
                }
            )
        },

        {"Brumblehallow",
            new Location("Brumblehallow" ,
            new Dictionary<string, float>() {
                    {"Ashglen", 1f},
                    {"Drakenshed", 1f},
                    {"Sylvarin", 1f},
                    {"Thornwick", 1f},
                    {"Lunebrook", 1f},
                }
            )
        },

        {"Lunebrook",
            new Location("Lunebrook" ,
            new Dictionary<string, float>() {
                    {"Thornwick", 1f},
                    {"Brumblehallow", 1f},
                    {"Dreadspire", 1f},
                    {"Nocthallow", 1f},
                    {"Ashglen", 1f},
                }
            )
        },

        {"Nymara",
            new Location("Nymara" ,
            new Dictionary<string, float>() {
                    {"Aerenthal", 1f},
                    {"Grimhallow", 1f},
                    {"Tidewatch", 1f},
                    {"Cindrallis", 1f},
                    {"Thalowryn", 1f},
                }
            )
        },

        {"Tidewatch",
            new Location("Tidewatch" ,
            new Dictionary<string, float>() {
                    {"Nymara", 1f},
                    {"Grimhallow", 1f},
                    {"Cindrallis", 1f},
                }
            )
        },

        {"Grimhallow",
            new Location("Grimhallow" ,
            new Dictionary<string, float>() {
                    {"Varnaks Reach", 1f},
                    {"Aerenthal", 1f},
                    {"Nymara", 1f},
                    {"Tidewatch", 1f},
                }
            )
        },

        { "Varnaks Reach",
            new Location("Varnaks Reach",
            new Dictionary<string, float>() {
                    {"Grimhallow", 1f},
                    {"Aerenthal", 1f},
                    {"Ashglen", 1f},
                }
            )
        },

        {"Ashglen",
            new Location("Ashglen" ,
            new Dictionary<string, float>() {
                    {"Varnaks Reach", 1f},
                    {"Aerenthal", 1f},
                    {"Brumblehallow", 1f},
                    {"Lunebrook", 1f},
                    {"Nocthallow", 1f},
                }
            )
        },

        {"Nocthallow",
            new Location("Nocthallow" ,
            new Dictionary<string, float>() {
                    {"Dreadspire", 1f},
                    {"Lunebrook", 1f},
                    {"Ashglen", 1f},
                }
            )
        },

        {"Dreadspire",
            new Location("Dreadspire" ,
            new Dictionary<string, float>() {
                    {"Nocthallow", 1f},
                    {"Lunebrook", 1f},
                }
            )
        },

        {"Aerenthal",
            new Location("Aerenthal"  ,
            new Dictionary<string, float>() {
                    {"Drakenshed", 1f},
                    {"Ashglen", 1f},
                    {"Varnaks Reach", 1f},
                    {"Grimhallow", 1f},
                    {"Nymara", 1f},
                }
            )
        }
    };

    public static void Setup()
    {
        Graph = Djikstra.CreateGraph(Locations);
        // var path = Djikstra.GetShortestPath(Graph, Locations.Keys.ToList().IndexOf("Eldrathen"), Locations.Keys.ToList().IndexOf("Velmoria"), Locations.Count);
        // for (int i = 0; i < path.Length; i++)
        // {
        //     Console.WriteLine(path[i]);
            
        // }
    }
}