using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answerDay7C_
{
    internal class Car : IMovable
    {
        private int Id;
        private string Model;
        private int Price;

        public Car()
        {
            Id = 1;
            Model = "BMW";
            Price = 50000000;
        }
        public Car(int id)
        {
            this.Id = id;
            Model = "BMW";
            Price = 50000000;
        }
        public Car(int _id, string _model){
            this.Id = _id;
            this.Model = _model;
            Price = 50000000;

        }
        public Car(int _id, string _model, int _price)
        {
            this.Id = _id;
            this.Model = _model;
            this.Price = _price;
        }
    }
}
