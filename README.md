# CS_MSTest_Exercise

## Coverage Gutters
```dotnet test --collect:"XPlat Code Coverage" --results-directory ./TestResults```

## ReportGenerator
```bash
reportgenerator \
  -reports:"./TestResults/<GUID>/coverage.cobertura.xml" \
  -targetdir:"./TestResults/coveragereport" \
  -reporttypes:Html
```

## Assert
Assert.AreEqual(expected, actual) 期待値と実際の値が等しいか 計算結果、戻り値の確認  
Assert.AreNotEqual(notExpected, actual) 値が等しくないこと 異なる結果になることを確認  
Assert.IsNull(actual) 値がnullかどうか null許容型の結果確認  
Assert.IsNotNull(actual) 値がnullでないこ ブジェクト生成の確認  
Assert.IsTrue(condition) 実行結果がtrueか フラグ、判定結果の確認  
Assert.IsFalse(condition) 実行結果がfalse か 条件分岐の確認  
Assert.ThrowsException<T>(action) 指定した例外が発生するか 例外処理のテスト  

## 属性
[DataTestMethod][DataRow] 同じテストを複数のデータで実行する テストコードの重複を減らせる  
[TestInitialize] 各テストの前に共通処理を実行する Arrangeがシンプルになる     
[TestCleanup] 各テストの後に後処理を実行する 後片付けを忘れにくくなる  
[ClassInitialize] テストクラス全体で1回だけ前処理を行う 重い初期化処理をまとめられる  
[ClassCleanup] テストクラス全体で1回だけ後処理を行う リソース解放を安全に行える  
[Ignore] テストを一時的に実行対象から外す 作業中でもテストを管理でき  
[TestCategory] テストを分類する テストの整理・実行制御がしやすい

## TestContext
テスト名 TestName 実行中のテストメソッド名を取得する  
テストクラス名 FullyQualifiedTestClassName 実行中のテストクラスの完全修飾名を取得する  
テスト結果 CurrentTestOutcome テストの実行結果(成功/失敗など)を取得する  
テスト実行ディレクトリ TestRunDirectory テスト実行時のルートディレクトリを取得する  
配置ディレクトリ DeploymentDirectory テスト実行用に配置されたファイルのディレクトリ  
実行時の設定情報 Properties テスト実行時に渡された設定情報を取得する  
テキストログ出力 WriteLine(string message) テスト実行中のログを出力できる