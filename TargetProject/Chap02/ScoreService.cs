namespace TargetProject.Chap02;
/// <summary>
/// 点数に基づいて合格・不合格を判定するサービスクラス
/// </summary>
public class ScoreService
{
    /// <summary>
    /// 指定された点数が合格点に達しているかどうかを判定する
    /// </summary>
    /// <param name="score">
    /// 判定対象となる点数
    /// 本演習では 0～100 の範囲を想定する
    /// </param>
    /// <returns>
    /// 合格点以上の場合はtrue(合格)、合格点未満の場合はfalse(不合格)を返す
    /// </returns>
    public bool IsPassed(int score)
    {
        // 合格点の基準を定義する
        // この演習では 60 点以上を合格とする
        if (score >= 60)
        {
            // 合格条件を満たしている場合
            return true;
        }
        else
        {
            // 合格条件を満たしていない場合
            return false;
        }
    }
}