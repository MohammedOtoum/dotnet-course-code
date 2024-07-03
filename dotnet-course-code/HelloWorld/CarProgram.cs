// using System;
// using DataCarEF2;
// using Models;
// using Microsoft.Data.SqlClient;

// namespace CarProgram
// {
//     internal class CarProgram
//     {
//         static void Main(string[] args)
//         {
//             DataCarEF EF = new DataCarEF();
//             Car C1 = new Car()
//             {
//                 CarName = "Toyta C-hr",
//                 CarColor = "white and black",
//                 CarPrice = 8500
//             };
//             EF.Add(C1);
//             EF.SaveChanges();
//             Console.WriteLine("done");
            
//             // linq for select in c# 
//             var context = new DataCarEF();

//             var cars = from p in context.Car select p;
//             foreach (var car in cars)
//             {
//                 Console.WriteLine($"car ID: {car.CarId}, Name: {car.CarName}, Price: {car.CarPrice}");
//             }


//         }
//     }
// }