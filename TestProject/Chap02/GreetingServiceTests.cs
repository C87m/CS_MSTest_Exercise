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

        // テストケース追加
    }
}