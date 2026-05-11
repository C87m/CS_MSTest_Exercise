using TargetProject.Chap02;

namespace TestProject.Chap03;

[TestClass]
public class GreetingServiceDataRowTests
{
    private GreetingService? greetingservice; // 外で宣言しないとテストメソッドから見えない
    [TestInitialize]
    public void SetUp()
    {
        greetingservice = new GreetingService();
    }

    [DataTestMethod]
    [DataRow(7, "Good Morning", DisplayName ="朝の時間帯ではGood Morningを返す")]
    public void Return_Greeting_Result(int hour, string expected)
    {
        var result = greetingservice!.Greet(hour);
        Assert.AreEqual(expected, result);
    }
}
