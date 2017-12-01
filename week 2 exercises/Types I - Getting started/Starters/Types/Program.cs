using System;

namespace Types {
  class Program {
    static void Main(string[] args) {
      // Uncomment these calls as instructed in the exercise guide

      TestRefType();
      //TestValueType();

      //TestIntArray();
      //TestAccountArray();

    }

    #region Testing Ref Type behaviour

    private static Account ac1, ac2;
    private static void DisplayBalances() {
      Console.WriteLine("\n'ac1' has: {0}     'ac2' has: {1}", ac1.Balance, ac2.Balance);
    }
    private static void TestRefType() {
      ac1 = new Account(100.0m, "John Smith", "AC12345");
      ac2 = ac1;
      DisplayBalances();    // 1st time

      ac2.Deposit(100.0m);
      DisplayBalances();    // 2nd time

      PassAccountByValue(ac1);
      DisplayBalances();    // 3rd time

      PassAccountByReference(ref ac1);
      DisplayBalances();    // 4th time
    }
    private static void PassAccountByValue(Account ac) {
      ac.Deposit(100.0m);
    }
    private static void PassAccountByReference(ref Account ac) {
      ac = new Account("Bill Brown", "AC98765");
    }


    #endregion

    #region Testing Value Type Behaviour

    private static int num1, num2;
    private static void DisplayInts() {
      Console.WriteLine("\n'num1' is {0}    'num2' is {1} ", num1, num2);
    }
    private static void TestValueType() {
      num1 = 10;
      num2 = num1;
      DisplayInts();    // 1st time

      num2++;
      DisplayInts();    // 2nd time

      PassIntByValue(num1);
      DisplayInts();    // 3rd time

      PassIntByReference(ref num1);
      DisplayInts();    // 4th time
    }
    private static void PassIntByValue(int i) {
      i++;
    }
    private static void PassIntByReference(ref int i) {
      i++;
      i++;
      i++;
    }
    #endregion

    #region Testing int[]
    private static void TestIntArray() {
      int[] ages = { 13, 15, 17 };
      ProcessAges(ages);
      Console.WriteLine(ages[1]); // 15 or 25
    }

    private static void ProcessAges(int[] ages) {
      ages[1] += 10;
    }

    #endregion

    #region Testing Account[]

    private static void TestAccountArray() {
      Account[] accs = { new Account(100.00m, "Fred", "AC001"),
                         new Account(200.00m, "Jazz", "AC002")};
      ProcessAccounts(accs);
      Console.WriteLine(accs[0].Holder); // Fred or Jazz?
    }

    private static void ProcessAccounts(Account[] accs) {
      Account temp = accs[0];
      accs[0] = accs[1];
      accs[1] = temp;
    }

    #endregion

  }
}
