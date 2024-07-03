using System;
using System.Data;
using Dapper;
using HelloWorld.Database;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Models;

namespace Operator;
internal class Program
{
    static void Main(String[] args)
    {
        //         IConfiguration Config = new ConfigurationBuilder()
        //         .AddJsonFile("appsettings.json")
        //         .Build();
        //         dataContextDapper dapper = new dataContextDapper(Config);
        //         dataContextEF entityFrameWork = new dataContextEF(Config);

        //         DateTime rightNow = dapper.LoadDataSingle<DateTime>("SELECT GETDATE()");
        //         Console.WriteLine(rightNow);
        Computer computer = new Computer()
        {

            Motherboard = "Z690",
            HasWifi = true,
            HasLTE = false,
            ReleaseDate = DateTime.Now,
            price = 948.87m,
            VideoCard = "RTX 2060"
        };
        //         entityFrameWork.Add(computer); //بضيف الصف الي فوق او الي معطيه الاسم
        //         entityFrameWork.SaveChanges(); //

        string sql = @"INSERT INTO TutorialAppSchemaMohammd.Computer (
        Motherboard, 
        HasWifi, 
        HasLTE, 
        ReleaseDate, 
        price, 
        VideoCard
        ) 
        VALUES ('" +
                   computer.ComputerId + "','" + computer.Motherboard + "','"
                    + computer.HasWifi + "','"
                    + computer.HasLTE + "','"
                    + computer.ReleaseDate + "','"
                    + computer.price + "','"
                    + computer.VideoCard + "')";
        // 
        File.WriteAllText("log.txt", "\n" + sql + "\n");

        using StreamWriter openFile = new("log.txt", append: true);
        openFile.WriteLine("\n" + sql + "\n");
        openFile.Close();
        string text = File.ReadAllText("log.txt");
        Console.WriteLine(text);

        // Console.WriteLine(sql);
        // int result = dapper.ExecuteSqlWithRowCount(sql);
        // Console.WriteLine(result);

        //     string sqlSelect = "SELECT Computer.Motherboard, Computer.HasWifi, Computer.HasLTE, Computer.ReleaseDate, Computer.price, Computer.VideoCard FROM TutorialAppSchemaMohammd.Computer";

        //     IEnumerable<Computer> computers = dapper.LoadData<Computer>(sqlSelect);
        // IEnumerable<Computer>? computerEF = entityFrameWork.Computer?.ToList<Computer>();
        // foreach (Computer mohammed in computerEF)
        // {
        //     Console.WriteLine(computer.ComputerId + "','"+
        //                computer.Motherboard + "','"
        //                + computer.HasWifi + "','"
        //                + computer.HasLTE + "','"
        //                + computer.ReleaseDate + "','"
        //                + computer.price + "','"
        //                + computer.VideoCard);
        // }حيعطي قيم مش دقيقة 
        // if(computerEF)
        // foreach (Computer mohammed in computerEF)
        // {
        //     Console.WriteLine(mohammed.ComputerId + "','" +
        //                mohammed.Motherboard + "','"
        //                + mohammed.HasWifi + "','"
        //                + mohammed.HasLTE + "','"
        //                + mohammed.ReleaseDate + "','"
        //                + mohammed.price + "','"
        //                + mohammed.VideoCard);
        // }//اذا لفيت بالي جوا ال
        //foreach بكون ادق
        //         var context =new dataContextEF(Config);
        //         var computers=from p in context.Computer select p;
        //         foreach(var comp in computers){
        //             Console.WriteLine($"computerId={comp.ComputerId},Motherboard: {comp.Motherboard} ,CPUcores={comp.CPUcores},HasWifi:{comp.HasWifi},HasLTE:{comp.HasLTE},ReleaseDate={comp.ReleaseDate}Price={comp.price},VideoCard:{comp.VideoCard}");
        //         }
        //
    }
    // static void Main(string[] args){

    // }
}