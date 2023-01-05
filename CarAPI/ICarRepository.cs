namespace CarAPI
{
    public interface ICarRepository
    {
        List<Car> GetAll();
        List<Car> GetCarsByColor(string color);
        Car AddNewCar(CarRequestModel car);
        Car UpdateCar(int id, CarRequestModel car);
        Car Delete(int id);
    }
}
