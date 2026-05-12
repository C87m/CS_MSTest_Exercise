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
    [DataRow(12, "Hello", DisplayName ="昼の時間帯ではHelloを返す")]
    [DataRow(18, "Good Evening", DisplayName ="夕方の時間帯ではGood Eveningを返す")]
    [DataRow(21, "Good Night", DisplayName ="夜の時間帯ではGood Nightを返す")]
    public void Return_Greeting_Result(int hour, string expected)
    {
        var result = greetingservice!.Greet(hour);
        Assert.AreEqual(expected, result);
    }
}
