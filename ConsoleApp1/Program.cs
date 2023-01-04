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

string s = "{\"Result\":\"OK\",\"Message\":\"2022-10-06 22:00 ok \",\"LessonCalendarId\":\"4022988\"}";

VoiceTubeBookingLessonPhpOutput? phpResult = System.Text.Json.JsonSerializer.Deserialize<VoiceTubeBookingLessonPhpOutput>(s);
Console.WriteLine(phpResult);
public class VoiceTubeBookingLessonPhpOutput
{
    public string Result { get; set; }
    public string Message { get; set; }
    public string LessonCalendarId { get; set; }
}