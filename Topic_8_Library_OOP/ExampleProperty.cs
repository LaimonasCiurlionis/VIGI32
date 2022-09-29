namespace Topic_8_Library_OOP
{
    public struct ExampleProperty
    {
        //PROPERTY
        public int Weight { get; set; }
        public bool IsOld { get; private set; }
        public int Age { get; set; }

        public void SetWeight(int weight) 
        {
            Weight = weight;
        }

        public void SetIsOldByAge(int age) 
        {
            if (age > 18)
            {
                IsOld = true;
            }
            else 
            {
                IsOld = false;
            }
        }
    }
}
