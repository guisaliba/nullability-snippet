namespace nullability_snippet.Models;

public class MyClass(DataClass data)
{
  public string? Property_1 { get; set; } = SetsPropertyToNullIfEmpty(data.Property_1) as string;
  public DateTime? Property_2 { get; set; } = SetsPropertyToNullIfEmpty(data.Property_2) as DateTime?;

  private static object? SetsPropertyToNullIfEmpty(object property)
  {
    if (property == null)
    {
      return null;
    }

    if (property is string str && string.IsNullOrWhiteSpace(str))
    {
      return null;
    }

    if (property.GetType().IsValueType && property.Equals(Activator.CreateInstance(property.GetType())))
    {
      return null; // Handles default values for value types (e.g., DateTime.MinValue)
    }

    return property;
  }
}
