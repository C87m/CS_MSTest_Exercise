using TargetProject.Chap02;

namespace TestProject.Chap02;

[TestClass]
public class GreetingServiceTests
{
    [TestMethod("朝の時間帯ではGood Morningを返す")]
    public void Return_GoodMorning_InMorning()
    {
        GreetingService greetingservice = new();
        int hour = 7;
        var result = greetingservice.Greet(hour);
        Assert.AreEqual("Good Morning", result);
    }

    [TestMethod("昼の時間ではHelloを返す")]
    public void Return_Hello_InNoon()
    {
        GreetingService greetingservice = new();
        int hour = 12;
        var result = greetingservice.Greet(hour);
        Assert.AreEqual("Hello", result);
    }

    [TestMethod("夕方の時間帯ではGood Eveningを返す")]
    public void Return_GoodEvening_InEvening()
    {
        GreetingService greetingservice = new();
        int hour = 18;
        var result = greetingservice.Greet(hour);
        Assert.AreEqual("Good Evening", result);
    }

    [TestMethod("夜の時間帯ではGood Morningを返す")]
    public void Return_GoodNight_InNight()
    {
        GreetingService greetingservice = new();
        int hour = 21;
        var result = greetingservice.Greet(hour);
        Assert.AreEqual("Good Night", result);
    }

}