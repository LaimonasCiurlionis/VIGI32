namespace Topic_8_Library_OOP
{
    public struct Example
    {
        //UGLY WAY OF GETTER
        
        //FIELD
        private int weight;

        public Example(int weight)
        {
            this.weight = weight;
        }

        public int GetWeight() 
        {
            return weight;
        }
    }
}
