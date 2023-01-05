namespace CarAPI
{
    public class CarRepository : ICarRepository
    {
        private readonly List<Car> _cars = new();

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetCarsByColor(string color)
        {
            return _cars.Where(c => c.Color == color).ToList();
        }

        public Car AddNewCar(CarRequestModel car)
        {
            var newCar = new Car
            {
                Id = _cars.Count == 0 ? 1 : _cars.Max(x => x.Id) + 1,
                Name = car.Name,
                Color = car.Color
            };

            _cars.Add(newCar);

            return newCar;
        }

        public Car UpdateCar(int id, CarRequestModel car)
        {
            var carToUpdate = _cars.Single(x => x.Id == id);
            carToUpdate.Name = car.Name;
            carToUpdate.Color = car.Color;

            return carToUpdate;
        }

        public Car Delete(int id)
        {
            var carToDetele = _cars.Single(x => x.Id == id);
            _cars.Remove(carToDetele);
            return carToDetele;
        }
    }
}
