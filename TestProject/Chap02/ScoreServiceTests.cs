using TargetProject.Chap02;

namespace TestProject.Chap02;

[TestClass]
public class ScoreServiceTests
{
    [TestMethod("合格点を大きく上回る場合はtrueを返す")]
    public void ReturnTrue_WhenOverScore_80()
    {
        ScoreService scoreservice = new();
        int score = 80;
        var result = scoreservice.IsPassed(score);
        Assert.IsTrue(result);
    }

    // テストケース
}
