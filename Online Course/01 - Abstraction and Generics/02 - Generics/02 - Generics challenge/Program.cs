var park1 = new Park("Parque Nacional de Uruapan", "19.42448584640519, -102.07132194215293");
var park2 = new Park("Bosque de Chapultepec", Mappable.StringToLocation("19.419996651232207, -99.18843757603354"));
var park3 = new Park("Central Park", "40.78301941114915, -73.96549114823671");
var myFavParks = new List<Park>() { park1, park2 };

var river1 = new River("Rio Lerma", new string[] {
    "20.07819949994246, -100.82311373326736",
    "19.964657993630738, -100.26188418107172",
    "19.861137276473777, -99.97782840123666",
    "19.15351900135971, -99.49848453220967",
    "19.289070489512614, -99.52180215528686"
});

var river2 = new River("Yangtze River", new string[] {
    "32.30254420071299, 119.82746438716993",
    "31.29798078600006, 118.29167190541146",
    "30.19109958389129, 116.89203813098115",
    "29.795120518468778, 115.76132555341395"
});

var layerOfParks = new Layer<Park>();
layerOfParks.AddElement(park3);
layerOfParks.AddElements(myFavParks);

var layerOfRivers = new Layer<River>();
layerOfRivers.AddElements(new List<River>() { river1, river2 });

layerOfParks.RenderLayer();
// Renderting a list of 'Parks'.
// Name: Central Park
// 	Location { Latitude = 40.78301941114915, Longitude = -73.96549114823671 }
// Name: Parque Nacional de Uruapan
// 	Location { Latitude = 19.42448584640519, Longitude = -102.07132194215293 }
// Name: Bosque de Chapultepec
// 	Location { Latitude = 19.419996651232207, Longitude = -99.18843757603354 }
layerOfRivers.RenderLayer();
// Renderting a list of 'Rivers'.
// Name: Rio Lerma
// 	Location { Latitude = 20.07819949994246, Longitude = -100.82311373326736 }
// 	Location { Latitude = 19.964657993630738, Longitude = -100.26188418107172 }
// 	Location { Latitude = 19.861137276473777, Longitude = -99.97782840123666 }
// 	Location { Latitude = 19.15351900135971, Longitude = -99.49848453220967 }
// 	Location { Latitude = 19.289070489512614, Longitude = -99.52180215528686 }
// Name: Yangtze River
// 	Location { Latitude = 32.30254420071299, Longitude = 119.82746438716993 }
// 	Location { Latitude = 31.29798078600006, Longitude = 118.29167190541146 }
// 	Location { Latitude = 30.19109958389129, Longitude = 116.89203813098115 }
// 	Location { Latitude = 29.795120518468778, Longitude = 115.76132555341395 }
