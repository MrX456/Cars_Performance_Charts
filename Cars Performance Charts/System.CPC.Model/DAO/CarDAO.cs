/*
 * Class responsible for implementation of Car table methods
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CPC.Model.Bean;
using System.CPC.Connection;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

/*
 * CPC / Model / DAO / Car
 * @author MRX
 * Version : 1.0.0
 */

namespace System.CPC.Model.DAO
{
    public class CarDAO : ICarDAO
    {
        #region - CRUD methods

        public Car Save(Car car)
        {
            try
            {
                
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    if (car.Id != 0)
                    {
                        cmd.CommandText = "UPDATE Cars SET maker = @maker, model = @model, country = @country, year = @year, engine_size = @engine_size, power = @power, torque = @torque, max_speed = @max_speed, price = @price WHERE id = @id ";
                        cmd.Parameters.AddWithValue("@id", car.Id);
                    }
                    else 
                    {
                        cmd.CommandText = "INSERT INTO Cars(maker, model, country, year, engine_size, power, torque, max_speed, price) VALUES (@maker, @model, @country, @year, @engine_size, @power, @torque, @max_speed, @price)";
                    }
                    
                    cmd.Parameters.AddWithValue("@maker", car.Maker);
                    cmd.Parameters.AddWithValue("@model", car.Model);
                    cmd.Parameters.AddWithValue("@country", car.Country);
                    cmd.Parameters.AddWithValue("@year", car.Year);
                    cmd.Parameters.AddWithValue("@engine_size", car.Engine_size);
                    cmd.Parameters.AddWithValue("@power", car.Power);
                    cmd.Parameters.AddWithValue("@torque", car.Torque);
                    cmd.Parameters.AddWithValue("@max_speed", car.Max_speed);
                    cmd.Parameters.AddWithValue("@price", car.Price);

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    return car;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public SQLiteDataReader FindCar(int id)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = "SELECT * FROM Cars WHERE id = '" + id + "'";
            cmd.CommandType = System.Data.CommandType.Text;

            Car car = new Car();

            try
            {

                cmd.Connection = ConnectionFactory.RequestConnection();

                // Ler os dados
                SQLiteDataReader reader = cmd.ExecuteReader();
                reader.Read();


                // Se retornou algum dado do banco de dados
                if (reader.HasRows)
                {
                    return reader;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public DataTable FindAll()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Cars";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    return dt;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally 
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public DataTable FindModelLike(string modelLike)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Cars WHERE model LIKE '%" + modelLike + "%'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    return dt;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public void Remove(int id)
        {
            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Cars WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        #endregion

        #region - General statistics methods

        public int TotalCars()
        {
            int cars = 0;

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM Cars";
                    cars = Convert.ToInt32(cmd.ExecuteScalar());
                }

                return cars;
            }
            catch (Exception)
            {
                return cars;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }


        public decimal SumValueTotalCars()
        {
            decimal sumPrice = 0;

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT SUM(price) FROM Cars";
                    sumPrice = Convert.ToDecimal(cmd.ExecuteScalar());
                }

                return sumPrice;
            }
            catch (Exception)
            {
                return sumPrice;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }


        public decimal AvgValueCars()
        {
            decimal average = 0;

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT AVG(price) FROM Cars";
                    average = Convert.ToDecimal(cmd.ExecuteScalar());
                }

                return average;
            }
            catch (Exception)
            {
                return average;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }


        public string ExpensivestCar()
        {
            string model = "Empty";

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT model FROM Cars ORDER BY price DESC LIMIT 1";
                    model = Convert.ToString(cmd.ExecuteScalar());
                }

                return model;
            }
            catch (Exception)
            {
                return model;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }


        public string NewestCar()
        {
            string model = "Empty";

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT (model) FROM Cars ORDER BY year DESC LIMIT 1";
                    model = Convert.ToString(cmd.ExecuteScalar());
                }

                return model;
            }
            catch (Exception)
            {
                return model;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }


        public Dictionary<string, int> TopFiveCarMakers()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            Dictionary<string, int> makers = new Dictionary<string, int>();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT (maker), COUNT(maker)  FROM Cars GROUP BY maker ORDER BY COUNT(maker) DESC LIMIT 5";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        makers.Add(row[0].ToString(), Convert.ToInt32(row[1]));
                    }

                    return makers;

                }
            }
            catch (Exception)
            {
                return makers;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }


        public Dictionary<string, int> TopFiveCarCountries()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            Dictionary<string, int> coutries = new Dictionary<string, int>();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT (country), COUNT(country) FROM Cars GROUP BY country ORDER BY COUNT(country) DESC LIMIT 5;";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        coutries.Add(row[0].ToString(), Convert.ToInt32(row[1]));
                    }

                    return coutries;

                }
            }
            catch (Exception)
            {
                return coutries;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        #endregion

        #region - Engine statistics

        public Car BiggestEngine()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            Car car = new Car();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT model, engine_size FROM Cars ORDER BY engine_size DESC LIMIT 1";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        car.Model = row[0].ToString();
                        car.Engine_size = Convert.ToInt32(row[1]);
                    }

                    return car;
                }
            }
            catch (Exception)
            {
                return car;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public decimal AvgEngineSize()
        {
            decimal average = 0;

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT AVG(engine_size) FROM Cars";
                    average = Convert.ToDecimal(cmd.ExecuteScalar());
                }

                return average;
            }
            catch (Exception)
            {
                return average;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public Dictionary<string, int> TopFiveEngineSize()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            Dictionary<string, int> cars = new Dictionary<string, int>();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT model, engine_size FROM Cars ORDER BY engine_size DESC LIMIT 5";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        cars.Add(row[0].ToString(), Convert.ToInt32(row[1]));
                    }

                    return cars;

                }
            }
            catch (Exception)
            {
                return cars;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public Dictionary<string, int> CustomEngineSizeComparison(int[] ids)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            Dictionary<string, int> cars = new Dictionary<string, int>();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT model, engine_size FROM Cars WHERE id = " + ids[0] + " OR id = " + ids[1] + " OR id = " + ids[2] + " OR id = " + ids[3] + " OR id = " + ids[4];
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        cars.Add(row[0].ToString(), Convert.ToInt32(row[1]));
                    }

                    return cars;

                }
            }
            catch (Exception)
            {
                return cars;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        #endregion

        #region - Power statistics

        public Car PowerfulCar()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            Car car = new Car();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT model, power FROM Cars ORDER BY power DESC LIMIT 1";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        car.Model = row[0].ToString();
                        car.Power = Convert.ToInt32(row[1]);
                    }

                    return car;
                }
            }
            catch (Exception)
            {
                return car;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public decimal AvgPower()
        {
            decimal average = 0;

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT AVG(power) FROM Cars";
                    average = Convert.ToDecimal(cmd.ExecuteScalar());
                }

                return average;
            }
            catch (Exception)
            {
                return average;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public Dictionary<string, int> TopFivePower()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            Dictionary<string, int> cars = new Dictionary<string, int>();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT model, power FROM Cars ORDER BY power DESC LIMIT 5";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        cars.Add(row[0].ToString(), Convert.ToInt32(row[1]));
                    }

                    return cars;

                }
            }
            catch (Exception)
            {
                return cars;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public Dictionary<string, int> CustomPowerComparison(int[] ids)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            Dictionary<string, int> cars = new Dictionary<string, int>();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT model, power FROM Cars WHERE id = " + ids[0] + " OR id = " + ids[1] + " OR id = " + ids[2] + " OR id = " + ids[3] + " OR id = " + ids[4];
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        cars.Add(row[0].ToString(), Convert.ToInt32(row[1]));
                    }

                    return cars;

                }
            }
            catch (Exception)
            {
                return cars;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        #endregion

        #region - Torque statistics

        public Car MostTorqueCar()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            Car car = new Car();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT model, torque FROM Cars ORDER BY torque DESC LIMIT 1";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        car.Model = row[0].ToString();
                        car.Power = Convert.ToInt32(row[1]);
                    }

                    return car;
                }
            }
            catch (Exception)
            {
                return car;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public decimal AvgTorque()
        {
            decimal average = 0;

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT AVG(torque) FROM Cars";
                    average = Convert.ToDecimal(cmd.ExecuteScalar());
                }

                return average;
            }
            catch (Exception)
            {
                return average;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public Dictionary<string, int> TopFiveTorque()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            Dictionary<string, int> cars = new Dictionary<string, int>();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT model, torque FROM Cars ORDER BY torque DESC LIMIT 5";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        cars.Add(row[0].ToString(), Convert.ToInt32(row[1]));
                    }

                    return cars;

                }
            }
            catch (Exception)
            {
                return cars;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public Dictionary<string, int> CustomTorqueComparison(int[] ids)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            Dictionary<string, int> cars = new Dictionary<string, int>();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT model, torque FROM Cars WHERE id = " + ids[0] + " OR id = " + ids[1] + " OR id = " + ids[2] + " OR id = " + ids[3] + " OR id = " + ids[4];
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        cars.Add(row[0].ToString(), Convert.ToInt32(row[1]));
                    }

                    return cars;

                }
            }
            catch (Exception)
            {
                return cars;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        #endregion

        #region - Speed statistics

        public Car FastestCar()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            Car car = new Car();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT model, max_speed FROM Cars ORDER BY max_speed DESC LIMIT 1";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        car.Model = row[0].ToString();
                        car.Power = Convert.ToInt32(row[1]);
                    }

                    return car;
                }
            }
            catch (Exception)
            {
                return car;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public decimal AvgMaxSpeed()
        {
            decimal average = 0;

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT AVG(max_speed) FROM Cars";
                    average = Convert.ToDecimal(cmd.ExecuteScalar());
                }

                return average;
            }
            catch (Exception)
            {
                return average;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public Dictionary<string, int> TopFiveMaxSpeed()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            Dictionary<string, int> cars = new Dictionary<string, int>();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT model, max_speed FROM Cars ORDER BY max_speed DESC LIMIT 5";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        cars.Add(row[0].ToString(), Convert.ToInt32(row[1]));
                    }

                    return cars;

                }
            }
            catch (Exception)
            {
                return cars;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public Dictionary<string, int> CustomMaxSpeedComparison(int[] ids)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            Dictionary<string, int> cars = new Dictionary<string, int>();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT model, max_speed FROM Cars WHERE id = " + ids[0] + " OR id = " + ids[1] + " OR id = " + ids[2] + " OR id = " + ids[3] + " OR id = " + ids[4];
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        cars.Add(row[0].ToString(), Convert.ToInt32(row[1]));
                    }

                    return cars;

                }
            }
            catch (Exception)
            {
                return cars;
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        #endregion
    }
}
