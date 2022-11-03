namespace Topic_1_Generics
{
    public static class Validation
    {
        public static void Validate<T>(T param) 
        {
            if (param is null) 
            {
                throw new ArgumentNullException(nameof(T));
            }

            Console.WriteLine($"{nameof(T)} IS NOT NULL");
        }
    }
}
