/// <reference name="MicrosoftAjax.js" />
/// <reference path="~/JS/Verb.js" />
/// <reference path="~/JS/InfoBox.js" />
/// <reference path="~/JS/VeJavaScriptIntellisenseHelper.js" />

var map = null;



// custom property on pins that will allow us to make runtime decisions about which verbs to display.


function pageLoad() {
    var startLatLong = new VELatLong(19.2835, 73.0953);
    map = new VEMap('theMap');
    map.LoadMap(startLatLong, 17, 'r', false);



    map.ClearInfoBoxStyles();
    map.SetMapStyle(VEMapStyle.Aerial);

}

function pageUnload() {
    // I haven't thought about cleaning up yet.
}

function clearOverlay(){
map.Clear();
}


function GetPolygon_success(e) {


    var result = new Array();
    var area = "";
    result = eval(e);
    if ((result != null) && (result.length >=3)) {
        var latlongarray = new Array();
        for (var i = 0; i <= result.length - 1; i++) {
            latlongarray[i] = new VELatLong(result[i].Latitude, result[i].Longitude, 0, VEAltitudeMode.Default);
             area=result[i].Area;
        }

        var shape = new VEShape(VEShapeType.Polygon, latlongarray);
        shape.SetTitle($get('dropDownListUniqueCellID').value + "");
        shape.SetDescription("This is a range of this cell tower " + $get('dropDownListUniqueCellID').value + "<br />" + "Area of range is : " + area);
         var r = Math.ceil(Math.random()*255);
        var g = Math.ceil(Math.random()*255);
        var b = Math.ceil(Math.random()*255);
        shape.SetLineColor(new VEColor(r,g,b,0.5));
        shape.SetFillColor(new VEColor(r, g, b, 0.5));
        var icon = new VECustomIconSpecification();
        icon.CustomHTML = "<div class='PNGPushPin' style='margin-left:0px;margin-top:0px;width=500px;';><img src='celltower.png'></div>";
 

        shape.SetCustomIcon(icon);
        map.AddShape(shape);
    }
    else {
        alert("there is/are only " + result.length + " points");
    }

}


function drawMarketBoundary(e) {
    var cropA = "Barley : $1.50";
    var cropB = "Beans : $1.754";
    var cropC = "Corn : $0.50";
    var cropD = "Dry Peas : $0.40";
    var cropE = "Lentils : $1.23";
    var cropF = "Millet : Not Trading";
    var cropG = "Potato : $0.40";
    var cropH = "Rice : $3.00";
    var cropI = "Tomatoes : $2.30";
    var cropJ = "Watermelon : $2.30";

    var result = new Array();
    var latlongarray = new Array();
    
    latlongarray[0] = new VELatLong(19.2954, 73.0664, 0, VEAltitudeMode.Default);
   
    latlongarray = AddCircle(latlongarray[0],0.5);

    var shape = new VEShape(VEShapeType.Polygon, latlongarray);

    shape.SetTitle("Abdul Kadar Wholesale Market");

    shape.SetDescription("<iframe frameborder='0' src='http://photosynth.net/embed.aspx?cid=854187bb-87c6-4527-a5d6-8fb50c17bed9&delayLoad=true&slideShowPlaying=false' width='500' height='300'></iframe>"
                            + "<br/>" + cropA
                            + "<br/>" + cropB
                            + "<br/>" + cropC
                            + "<br/>" + cropD
                            + "<br/>" + cropE
                            + "<br/>" + cropF
                            + "<br/>" + cropG
                            + "<br/>" + cropH
                            + "<br/>" + cropI
                            + "<br/>" + cropJ);
    var r = Math.ceil(Math.random() * 255);
    var g = Math.ceil(Math.random() * 255);
    var b = Math.ceil(Math.random() * 255);
    shape.SetLineColor(new VEColor(r, g, b, 0.5));
    shape.SetFillColor(new VEColor(r, g, b, 0.5));
    var icon = new VECustomIconSpecification();
    icon.CustomHTML = "<div class='PNGPushPin' style='margin-left:0px;margin-top:0px';><img src='celltower.png'></div>";
    shape.SetCustomIcon(icon);
    map.AddShape(shape);

    map.SetCenterAndZoom(latlongarray[0], 14);


    var cropA = "Barley : $1.20";
    var cropB = "Beans : $1.30";
    var cropC = "Corn : $0.60";
    var cropD = "Dry Peas : $0.20";
    var cropE = "Lentils : $1.40";
    var cropF = "Millet : $1.50";
    var cropG = "Potato : $0.350";
    var cropH = "Rice : $3.10";
    var cropI = "Tomatoes : $2.50";
    var cropJ = "Watermelon : $2.70";

    latlongarray[0] = new VELatLong(19.2954, 73.0604, 0, VEAltitudeMode.Default);

    latlongarray = AddCircle(latlongarray[0], 0.2);

    var shape = new VEShape(VEShapeType.Polygon, latlongarray);

    shape.SetTitle("Common Farmer's Supermarket");

    shape.SetDescription("<iframe frameborder='0' src='http://photosynth.net/embed.aspx?cid=ddd3ecde-8e79-4fbb-9de2-f5bd50d8b709&delayLoad=true&slideShowPlaying=false' width='500' height='300'></iframe>"
                            + "<br/>" + cropA
                            + "<br/>" + cropB
                            + "<br/>" + cropC
                            + "<br/>" + cropD
                            + "<br/>" + cropE
                            + "<br/>" + cropF
                            + "<br/>" + cropG
                            + "<br/>" + cropH
                            + "<br/>" + cropI
                            + "<br/>" + cropJ);
    var r = Math.ceil(Math.random() * 255);
    var g = Math.ceil(Math.random() * 255);
    var b = Math.ceil(Math.random() * 255);
    shape.SetLineColor(new VEColor(r, g, b, 0.5));
    shape.SetFillColor(new VEColor(r, g, b, 0.5));
    var icon = new VECustomIconSpecification();
    icon.CustomHTML = "<div class='PNGPushPin' style='margin-left:0px;margin-top:0px';><img src='celltower.png'></div>";
    shape.SetCustomIcon(icon);
    map.AddShape(shape);
   
   
}

function AddCircle(loc, radius) {
  
        var R = 6371; // earth's mean radius in km
        var lat = (loc.Latitude * 3.14159) / 180; //rad
        var lon = (loc.Longitude * 3.14159) / 180; //rad
        var d = parseFloat(radius) / R;  // d = angular distance covered on earth's surface
        var locs = new Array();
        for (x = 0; x <= 360; (x = x + 20)) {
            var p2 = new VELatLong(0, 0)
            brng = x * Math.PI / 180; //rad
            p2.Latitude = Math.asin(Math.sin(lat) * Math.cos(d) + Math.cos(lat) * Math.sin(d) * Math.cos(brng));
            p2.Longitude = ((lon + Math.atan2(Math.sin(brng) * Math.sin(d) * Math.cos(lat), Math.cos(d) - Math.sin(lat) * Math.sin(p2.Latitude))) * 180) / Math.PI;
            p2.Latitude = (p2.Latitude * 180) / Math.PI;
            locs.push(p2);
        }
        return locs;
      
    
}

function drawFarms() {



drawFarmBoundary1();
  drawFarmBoundary2();
 drawFarmBoundary3();
    drawFarmBoundary4();
}
function drawFarmBoundary1() {
    var lowestTemperature= "Lowest annual temperature : 18C";
    var highestTemperature = "Highest annual temperature :24C";
    var lowestRainFall = "Lowest annual rainfall : 200mm";
    var highestRainFall = "Highest annual rainfall 300mm";
    var climateType = "Climate Type : Sub-Temperate";
    var generalWindSpeed = "Average Wind Speed = 20km/h";
    var sunlightIntensity = "Annual Intensity of sunlight = 10,000lux";
    var humidity = "Annual Humidity : 40% relative";
    var pressure = "Atmospheric pressure 101.325 kPa";

        var result = new Array();
        var latlongarray = new Array();

        latlongarray[0] = new VELatLong(19.2820, 73.0926, 0, VEAltitudeMode.Default);
        latlongarray[1] = new VELatLong(19.2817, 73.0926, 0, VEAltitudeMode.Default);
        latlongarray[2] = new VELatLong(19.2819, 73.0932, 0, VEAltitudeMode.Default);
        latlongarray[3] = new VELatLong(19.2821, 73.0932, 0, VEAltitudeMode.Default);
        
        
        
        
        var shape = new VEShape(VEShapeType.Polygon, latlongarray);
       
        shape.SetTitle("Farm");

        shape.SetDescription("<iframe frameborder='0' src='http://photosynth.net/embed.aspx?cid=33b2b1a8-c124-4624-8cab-1359ebd13755&delayLoad=true&slideShowPlaying=false' width='500' height='300'></iframe>"
                            + "<br/>" + lowestTemperature
                            + "<br/>" + highestTemperature
                            + "<br/>" + lowestRainFall
                            + "<br/>" + highestRainFall
                            + "<br/>" + climateType
                            + "<br/>" + generalWindSpeed
                            + "<br/>" + sunlightIntensity
                            + "<br/>" + humidity
                            + "<br/>" + pressure);
        
        var r = Math.ceil(Math.random() * 255);
        var g = Math.ceil(Math.random() * 255);
        var b = Math.ceil(Math.random() * 255);
        shape.SetLineColor(new VEColor(r, g, b, 0.5));
        shape.SetFillColor(new VEColor(r, g, b, 0.5));
        var icon = new VECustomIconSpecification();
        icon.CustomHTML = "<div class='PNGPushPin' style='margin-left:0px;margin-top:0px';><img src='celltower.png'></div>";


        shape.SetCustomIcon(icon);

        map.AddShape(shape);
    }
    
    function drawFarmBoundary2() {
        var lowestTemperature = "Lowest annual temperature : 18C";
        var highestTemperature = "Highest annual temperature :24C";
        var lowestRainFall = "Lowest annual rainfall : 200mm";
        var highestRainFall = "Highest annual rainfall 300mm";
        var climateType = "Climate Type : Sub-Temperate";
        var generalWindSpeed = "Average Wind Speed = 20km/h";
        var sunlightIntensity = "Annual Intensity of sunlight = 10,000lux";
        var humidity = "Annual Humidity : 40% relative";
        var pressure = "Atmospheric pressure 101.325 kPa";

        var result = new Array();
        var latlongarray = new Array();

        latlongarray[0] = new VELatLong(19.2828, 73.0926, 0, VEAltitudeMode.Default);
        latlongarray[1] = new VELatLong(19.2824, 73.0926, 0, VEAltitudeMode.Default);
        latlongarray[2] = new VELatLong(19.2824, 73.0929, 0, VEAltitudeMode.Default);
        latlongarray[3] = new VELatLong(19.2829, 73.0928, 0, VEAltitudeMode.Default);
        
        
        
        
        var shape = new VEShape(VEShapeType.Polygon, latlongarray);

        shape.SetTitle("Farm");

        shape.SetDescription("<iframe frameborder='0' src='http://photosynth.net/embed.aspx?cid=d871d474-b9af-4844-8185-9defc679330c&delayLoad=true&slideShowPlaying=false' width='500' height='300'></iframe>"
                            + "<br/>" + lowestTemperature
                            + "<br/>" + highestTemperature
                            + "<br/>" + lowestRainFall
                            + "<br/>" + highestRainFall
                            + "<br/>" + climateType
                            + "<br/>" + generalWindSpeed
                            + "<br/>" + sunlightIntensity
                            + "<br/>" + humidity
                            + "<br/>" + pressure);

        var r = Math.ceil(Math.random() * 255);
        var g = Math.ceil(Math.random() * 255);
        var b = Math.ceil(Math.random() * 255);
        shape.SetLineColor(new VEColor(r, g, b, 0.5));
        shape.SetFillColor(new VEColor(r, g, b, 0.5));
        var icon = new VECustomIconSpecification();
        icon.CustomHTML = "<div class='PNGPushPin' style='margin-left:0px;margin-top:0px';><img src='celltower.png'></div>";


        shape.SetCustomIcon(icon);

        map.AddShape(shape);




    }

    function drawFarmBoundary3() {
        var lowestTemperature = "Lowest annual temperature : 18C";
        var highestTemperature = "Highest annual temperature :24C";
        var lowestRainFall = "Lowest annual rainfall : 200mm";
        var highestRainFall = "Highest annual rainfall 300mm";
        var climateType = "Climate Type : Sub-Temperate";
        var generalWindSpeed = "Average Wind Speed = 20km/h";
        var sunlightIntensity = "Annual Intensity of sunlight = 10,000lux";
        var humidity = "Annual Humidity : 40% relative";
        var pressure = "Atmospheric pressure 101.325 kPa";

        var result = new Array();
        var latlongarray = new Array();

        latlongarray[0] = new VELatLong(19.2823, 73.0926, 0, VEAltitudeMode.Default);
        latlongarray[1] = new VELatLong(19.2821, 73.0926, 0, VEAltitudeMode.Default);
        latlongarray[2] = new VELatLong(19.2821, 73.0929, 0, VEAltitudeMode.Default);
        latlongarray[3] = new VELatLong(19.2823, 73.0929, 0, VEAltitudeMode.Default);
        

        
        var shape = new VEShape(VEShapeType.Polygon, latlongarray);

        shape.SetTitle("Farm");

        shape.SetDescription("<iframe frameborder='0' src='http://photosynth.net/embed.aspx?cid=9a226970-3f2b-4c54-8289-4a693ac8527d&delayLoad=true&slideShowPlaying=false' width='500' height='300'></iframe>"
                            + "<br/>" + lowestTemperature
                            + "<br/>" + highestTemperature
                            + "<br/>" + lowestRainFall
                            + "<br/>" + highestRainFall
                            + "<br/>" + climateType
                            + "<br/>" + generalWindSpeed
                            + "<br/>" + sunlightIntensity
                            + "<br/>" + humidity
                            + "<br/>" + pressure);

        var r = Math.ceil(Math.random() * 255);
        var g = Math.ceil(Math.random() * 255);
        var b = Math.ceil(Math.random() * 255);
        shape.SetLineColor(new VEColor(r, g, b, 0.5));
        shape.SetFillColor(new VEColor(r, g, b, 0.5));
        var icon = new VECustomIconSpecification();
        icon.CustomHTML = "<div class='PNGPushPin' style='margin-left:0px;margin-top:0px';><img src='celltower.png'></div>";


        shape.SetCustomIcon(icon);

        map.AddShape(shape);




    }

    function drawFarmBoundary4() {
        var lowestTemperature = "Lowest annual temperature : 18C";
        var highestTemperature = "Highest annual temperature :24C";
        var lowestRainFall = "Lowest annual rainfall : 200mm";
        var highestRainFall = "Highest annual rainfall 300mm";
        var climateType = "Climate Type : Sub-Temperate";
        var generalWindSpeed = "Average Wind Speed = 20km/h";
        var sunlightIntensity = "Annual Intensity of sunlight = 10,000lux";
        var humidity = "Annual Humidity : 40% relative";
        var pressure = "Atmospheric pressure 101.325 kPa";

        var result = new Array();
        var latlongarray = new Array();

        latlongarray[0] = new VELatLong(19.2828, 73.0915, 0, VEAltitudeMode.Default);
        latlongarray[1] = new VELatLong(19.2824, 73.0916, 0, VEAltitudeMode.Default);
        latlongarray[2] = new VELatLong(19.2824, 73.0925, 0, VEAltitudeMode.Default);
        latlongarray[3] = new VELatLong(19.2829, 73.0926, 0, VEAltitudeMode.Default);

        var shape = new VEShape(VEShapeType.Polygon, latlongarray);

        shape.SetTitle("Farm");

        shape.SetDescription("<iframe frameborder='0' src='http://photosynth.net/embed.aspx?cid=d413ab3c-34f8-491b-b509-fbc59a92c6d3&delayLoad=true&slideShowPlaying=false' width='500' height='300'></iframe>"
                            + "<br/>" + lowestTemperature
                            + "<br/>" + highestTemperature
                            + "<br/>" + lowestRainFall
                            + "<br/>" + highestRainFall
                            + "<br/>" + climateType
                            + "<br/>" + generalWindSpeed
                            + "<br/>" + sunlightIntensity
                            + "<br/>" + humidity
                            + "<br/>" + pressure);

        var r = Math.ceil(Math.random() * 255);
        var g = Math.ceil(Math.random() * 255);
        var b = Math.ceil(Math.random() * 255);
        shape.SetLineColor(new VEColor(r, g, b, 0.5));
        shape.SetFillColor(new VEColor(r, g, b, 0.5));
        var icon = new VECustomIconSpecification();
        icon.CustomHTML = "<div class='PNGPushPin' style='margin-left:0px;margin-top:0px';><img src='celltower.png'></div>";


        shape.SetCustomIcon(icon);

        map.AddShape(shape);




    }


function GetLatLong_success(e) {
//make a random color here
var randomnumber = Math.ceil(Math.random()*5);

    var result = new Array();
    result = eval(e);
    if ((result != null) &&( result.length>=1)) {
        var latlongarray = new Array();
            for (var i = 0; i <= result.length - 1; i++) {
              var thislatlong = new VELatLong(result[i].Latitude, result[i].Longitude, 0, VEAltitudeMode.Default);
              var shape = new VEShape(VEShapeType.Pushpin,thislatlong);
              shape.SetDescription("Signal Strength : " + result[i].SignalStrength + "<br />" + "Time : " + result[i].RecordTime + "<br />" + "ClientGuid : " + result[i].ClientGuid + "<br />" + "Latitude : " + result[i].Latitude + "<br />" + "Longitude : " + result[i].Longitude + "<br />" + "CellId : " + result[i].CellId + "<br />" + "SatellitesInView : " + result[i].SatellitesInView + "<br />" + "NoOfWifi : " + result[i].NoOfWifi + "<br />");
              shape.IsFavorite=true;  
              shape.SetTitle(result[i].ObservationId + "");
             
              var icon = new VECustomIconSpecification();
              icon.CustomHTML = "<div class='PNGPushPin' style='margin-left:10px;margin-top:10px';><img src='point" + randomnumber + ".png'></div>";
             // icon.Image="point" + randomnumber + ".png";
           
            
             shape.SetCustomIcon(icon);
              this._layer.AddShape(shape);
            }
    }
    else {
        alert("not enough points");
    }
}

function GetLatLongDrawLine_success(e) {
//make a random color here
var randomnumber = Math.ceil(Math.random()*5);

    var result = new Array();
    result = eval(e);
    if ((result != null) &&( result.length>=1)) {
        var latlongarray = new Array(result.length);
            for (var i = 0; i <= result.length - 1; i++) {
            
                 latlongarray[i] = new VELatLong(result[i].Latitude, result[i].Longitude, 0, VEAltitudeMode.Default);
             
            }
          var shape = new VEShape(VEShapeType.Polyline,latlongarray);
        var r = randomnumber*51;
        var g = randomnumber*51;
        var b = randomnumber*51;
        shape.SetLineColor(new VEColor(r,g,b,0.5));
          //shape.IsFavorite=true; 
          this._layer.AddShape(shape);
    }//end if (result!=null)
    else {
        alert("not enough points");
    }
}


function onFailed(e) {

alert(e.toString());
}

