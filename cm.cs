public class person{

  static int calculatsum(){

    int firstNumber = 100;
    int SecondNumber =20;
    int sum = firstNumber + SecondNumber;
    return sum;
  }

  struct mystruct{
    public string Name { get; set; }
    public int Age { get; set; }
  }

public static void Main(){

  int result = calculatsum();
  System.Console.WriteLine( result);
   int result = calculatsum();
  System.Console.WriteLine( result);


  mystruct valueType = new mystruct();
  valueType.name = "ali";
  object.reftype = valueType;

  
  mystruct valueType = new mystruct();
 
}
}