namespace Topic_7_Structs_UnitTests
{
    public struct Zoo
    {
        public string name;
        public string address;
        public List<Animal> animals;

        public Zoo(string name, string address, List<Animal> animals)
        {
            this.name = name;
            this.address = address;
            this.animals = animals;
        }

        public int GetAnimalCount()
        {
            return animals.Count;
        }

        public int GetCatCount()
        {
            int count = 0;

            foreach (Animal animal in animals)
            {
                if (animal.type == "CAT")
                {
                    count++;
                }
            }

            return count;
        }

        public int GetFishCount()
        {
            int count = 0;

            foreach (Animal animal in animals)
            {
                if (animal.type == "FISH")
                {
                    count++;
                }
            }

            return count;
        }

        public int GetBirdCount()
        {
            int count = 0;

            foreach (Animal animal in animals)
            {
                if (animal.type == "BIRD")
                {
                    count++;
                }
            }

            return count;
        }

        //TUPLE
        public (int catCount, int fishCount, int birdCount) GetAnimalCountByType()
        {
            int catCount = 0;
            int fishCount = 0;
            int birdCount = 0;


            foreach (var animal in animals)
            {
                if (animal.type == "CAT")
                {
                    catCount++;
                }

                if (animal.type == "FISH")
                {
                    fishCount++;
                }

                if (animal.type == "BIRD")
                {
                    birdCount++;
                }

            }

            return (catCount, fishCount, birdCount);
        }

        public List<AnimalReport> GetAnimalCountByTypeAdvanced()
        {
            return animals
                .GroupBy(x => x.type)
                .Select(x => new AnimalReport(x.Key, x.Count()))
                .ToList();
        }
    }
}
