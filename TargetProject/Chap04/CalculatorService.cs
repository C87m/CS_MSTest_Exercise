namespace TargetProject.Chap04;
/// <summary>
/// 計算機能を提供するサービスクラス
/// </summary>
public class CalculatorService
{
    /// <summary>
    /// 2つの整数を除算する
    /// 条件に応じて例外をスローする
    /// </summary>
    /// <param name="x">被除数</param>
    /// <param name="y">除数</param>
    /// <returns>
    /// 正常に計算できた場合の除算結果
    /// </returns>
    public int Div(int x, int y)
    {
        // 100以上の値は計算対象外とする
        if (x >= 100 || y >= 100)
        {
            throw new ArgumentException("100以上の値は計算できません");
        }

        // 負の値は計算対象外とする
        if (x < 0 || y < 0)
        {
            throw new ArgumentException("負の値は使用できません");
        }

        // 除数が 0 の場合はゼロ除算エラーとする
        if (y == 0)
        {
            throw new DivideByZeroException("0 で割ることはできません");
        }

        // 正常な除算
        return x / y;
    }
}