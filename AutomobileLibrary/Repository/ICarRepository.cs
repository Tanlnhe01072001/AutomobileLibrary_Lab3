﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using AutomobileLibrary.DataAccess;
namespace AutomobileLibrary.Repository
{// kho lưu trữ của các đối tượng Car cần triển khai
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarByID(int carId);
        void InsertCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int carId);
    }
}
