namespace Topic_8_Library_OOP
{
    public struct Miskas
    {
        //PROPERTY
        public List<int> Medziai { get; private set; }

        //PROPERTY IR INICIALIZACIJA
        public List<int> Medziai2 { get; private set; } = new List<int>();

        public Miskas()
        {
            //PRIVALOMA INICIALIZUOTI LISTĄ!
            Medziai = new List<int>();
        }

        public void PasodintiMedi() 
        {
            Medziai.Add(1);

            Medziai2.Add(1);
        }
    }
}
