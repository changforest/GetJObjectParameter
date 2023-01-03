using Newtonsoft.Json.Linq;
Console.WriteLine("Hello, World!");
dynamic stuff = JObject.Parse(" {'0':'315','1':'320'}");

Console.WriteLine(stuff);
var n = stuff["0"];
Console.WriteLine(n);
var n2 = stuff["1"];
Console.WriteLine(n2);

//string name = stuff.0;
//string address = stuff.Address.City;
