/*
 * Interface responsible for declaration of Car table methods
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CPC.Model.Bean;
using System.Data;
using System.Data.SQLite;

/*
 * CPC / Model / DAO / ICar
 * @author MRX
 * Version : 1.0.0
 */

namespace System.CPC.Model.DAO
{
    public interface ICarDAO
    {

        Car Save(Car car);

        SQLiteDataReader FindCar(int id);

        DataTable FindAll();

        DataTable FindModelLike(string modelLike);

        void Remove(int id);

        int TotalCars();

        decimal SumValueTotalCars();

        decimal AvgValueCars();

        string ExpensivestCar();

        string NewestCar();

        Dictionary<string, int> TopFiveCarMakers();

        Dictionary<string, int> TopFiveCarCountries();

        Car BiggestEngine();

        decimal AvgEngineSize();

        Dictionary<string, int> TopFiveEngineSize();

        Dictionary<string, int> CustomEngineSizeComparison(int[] ids);

        Car PowerfulCar();

        decimal AvgPower();

        Dictionary<string, int> TopFivePower();

        Dictionary<string, int> CustomPowerComparison(int[] ids);

        Car MostTorqueCar();

        decimal AvgTorque();

        Dictionary<string, int> TopFiveTorque();

        Dictionary<string, int> CustomTorqueComparison(int[] ids);

        Car FastestCar();

        decimal AvgMaxSpeed();

        Dictionary<string, int> TopFiveMaxSpeed();

        Dictionary<string, int> CustomMaxSpeedComparison(int[] ids);

    }
}
