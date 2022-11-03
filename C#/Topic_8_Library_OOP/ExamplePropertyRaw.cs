namespace Topic_8_Library_OOP
{
    public struct ExamplePropertyRaw
    {
        private int _weight;

        public int Weight
        {
            //GETTER
            get { return _weight; }
            //SETTER
            set {

                if (value < 100) 
                {
                    throw new ArgumentException("weight is too small");
                }

                _weight = value; 
            }
        }
    }
}
