using System;

//namespace hello{
class Program {
  public static void Main (string[] args) {

int a = 5;
int b = a + 2; //OK

bool test = true;

// Error. Operator '+' cannot be applied to operands of type 'int' and 'bool'.
int c = a + test;
  }
}
//}