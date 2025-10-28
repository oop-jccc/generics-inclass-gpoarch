namespace GenericsTests;

public static class ArrayUtilities
{
    // TODO: Add the 'this' keyword before the parameter type to convert this method into an extension method.
    public static bool IsNullOrEmpty<T>(this T[]? array)
    {
        return array == null || array.Length == 0;
    }
}