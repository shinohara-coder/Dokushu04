using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyApp.Tests
{
    // ==========================================
    // ① テスト対象のクラス（あなたが作った本番用のプログラム）
    // ==========================================
    public class PasswordChecker
    {
        // 💡 パスワードが「8文字以上」なら true、足りなければ false を返すメソッド
        public bool IsValid(string password)
        {
            if (password == null) return false;
            return password.Length >= 8;
        }
    }

    // ==========================================
    // ② テストを実行するためのクラス
    // ==========================================
    [TestClass] // 💡 「このクラスの中にテスト用メソッドがありますよ」という目印
    public class PasswordCheckerTest
    {
        [TestMethod] // ✨ 今回の主役：これがあると、このメソッドを「個別実行」できる！
        public void パスワードが8文字以上のときは成功すること()
        {
            // 1. 準備：テストしたいクラスのインスタンスを作る
            var checker = new PasswordChecker();

            // 2. 実行：8文字のパスワード「12345678」を渡してみる
            bool result = checker.IsValid("12345678");

            // 3. 検証：結果が「true（成功）」になるはずだ！とシステムに宣言する
            Assert.IsTrue(result);
        }

        [TestMethod] // ✨ 2つ目の検証用ボタン
        public void パスワードが7文字以下のときは失敗すること()
        {
            var checker = new PasswordChecker();

            // 💡 あえて基準に足りない7文字のパスワードを渡す
            bool result = checker.IsValid("1234567");

            // 検証：結果が「false（失敗）」になるはずだ！と宣言する
            Assert.IsFalse(result);
        }
    }
}