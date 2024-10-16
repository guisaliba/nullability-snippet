using nullability_snippet.Models;

namespace nullability_snippet;

class Program
{
  static void Main()
  {
    DataClass data = new()
    {
      Property_1 = "",
      Property_2 = DateTime.Today
    };

    Console.WriteLine($"data.Property_1: {data.Property_1?.GetType()}"); // System.String
    Console.WriteLine($"data.Property_2: {data.Property_2.GetType()}"); // System.String

    MyClass myClass = new(data);

    Console.WriteLine($"myClass.Property_1: {myClass.Property_1?.GetType()}"); // GetType() returns null
    Console.WriteLine($"myClass.Property_2: {myClass.Property_2?.GetType()}"); // System.DateTime
  }
}
