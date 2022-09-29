namespace Topic_8_Library_OOP
{
    public struct Palme
    {
        //PROPERTY
        public int Amzius { get; private set; }

        //FIELD
        private int _vaisiuKieks;
        //GETTER/SETTER
        public int VaisiuKiekis
        {
            get
            {
                _vaisiuKieks = SkaiciuotiVaisiuKieki(Amzius);
                return _vaisiuKieks;
            }
        }

        //METHOD
        public void Prideti1MenAmziaus()
        {
            if (Amzius > 12)
            {
                Amzius = 0;
            }
            else
            {
                Amzius++;
            }
        }

        private int SkaiciuotiVaisiuKieki(int amzius) 
        {
            int rezultatas = 0;

            if (Amzius >= 5 && Amzius < 12) 
            {

                rezultatas = amzius * 3;
            }

            return rezultatas;
        }
    }
}
