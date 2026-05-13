using TargetProject.Chap04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Chap04
{
    [TestClass]
    public class CalculatorServiceTests
    {
        [DataTestMethod]
        [DataRow(3, 3, 1, DisplayName = "正常な割り算")]
        public void Normal_division(int x, int y, int ans)
        {
            var result = x / y;
            Assert.AreEqual(ans, result);
        }

        [DataTestMethod]
        [DataRow(100, 1, DisplayName = "xが100以上")]
        [DataRow(1, 100, DisplayName = "yが100以上")]
        [DataRow(-1, 1, DisplayName = "xがマイナス")]
        [DataRow(1, -1, DisplayName = "yがマイナス")]
        [DataRow(1, 0, DisplayName = "ゼロ除算")]
        public void Div_ShouldThrowArgumentException_WhenInvalidInput(int x, int y)
        {
            var exception = Assert.ThrowsException<ArgumentException>(
                () => calculator!.Div(x, y)); // 名前も引数もない関数がcalculator.Divを実行する
            Assert.AreEqual("100以上の値は計算できません", exception.Message);
        }
    }
}