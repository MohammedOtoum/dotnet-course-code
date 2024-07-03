using System.Runtime.CompilerServices;

namespace Models
{

    public class Car
    {
        public int CarId { get; set; }
        public string? CarName { get; set; }
        public string? CarColor { get; set; }
        public int CarPrice { get; set; }

        public Car(){
            if (CarName==null){
                CarName=" ";
            }
            if(CarColor==null){
                CarColor=" ";
            }
        }
    }


}