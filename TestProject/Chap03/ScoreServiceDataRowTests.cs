using TargetProject.Chap02;


namespace TestProject.Chap03
{
    [TestClass]
    public class ScoreServiceDataRowTests
    {
        private ScoreService? scoreservice;
        [TestInitialize]
        public void SetUp()
        {
            scoreservice = new();
        } 

        [DataTestMethod]
        [DataRow(80, true, DisplayName="合格点を大きく上回る場合はtrueを返す")]
        public void Return_PassOrFaled(int score, bool expected)
        {
            var result = scoreservice!.IsPassed(score);
            Assert.AreEqual(expected, result);
        }

    }
}