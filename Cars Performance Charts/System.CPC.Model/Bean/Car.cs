/*
 * Class responsible for Car instances
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * CPC / Model / Bean/ Car
 * @author MRX
 * Version : 1.0.1
 */

namespace System.CPC.Model.Bean
{
    public class Car
    {

        private int id;
        private string maker;
        private string model;
        private string country;
        private int year;
        private int power;
        private int engine_size;
        private int torque;
        private int max_speed;
        private decimal price;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Maker
        {
            get { return maker; }
            set { maker = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Engine_size
        {
            get { return engine_size; }
            set { engine_size = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public int Torque
        {
            get { return torque; }
            set { torque = value; }
        }

        public int Max_speed
        {
            get { return max_speed; }
            set { max_speed = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
