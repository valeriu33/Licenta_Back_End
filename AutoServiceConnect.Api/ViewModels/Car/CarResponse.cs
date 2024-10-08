using AutoServiceConnect.Api.ViewModels.Customer;

namespace AutoServiceConnect.Api.ViewModels.Car;

public class CarResponse
{
    public int Id { get; set; }
    public UpdateCustomerInfo Customer { get; set; }
    public string CarName { get; set; }
    public string? Brand { get; set; }
    public string Model { get; set; }
    public string? Year { get; set; }
    public string? VIN { get; set; }
    public string LicencePlace { get; set; }
    public int? Mileage { get; set; }
    public string? Color { get; set; }
    public string? EngineType { get; set; }
    public int? Rating { get; set; }
    public string? ImgUrl { get; set; }
    public decimal Price { get; set; }
    public string? Speed { get; set; }
    public string? Gps { get; set; }
    public string? SeatType { get; set; }
    public string? Automatic { get; set; }
    public string? Description { get; set; }
}