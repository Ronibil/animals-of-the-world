using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    class DBConnection
    {
        string strCon = @"Data Source=LAPTOP-KSNM1A8C\SQLEXPRESS;Initial Catalog=AnimalsDB;Integrated Security=True";//unique connection string
        string strCmd;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adptr;
        DataSet ds;
        DataTable dtC, dtA;
        SqlDataReader reader;
        string continent;
        int rowcounter;


        public DBConnection()
        {
            con = new SqlConnection(strCon);
            CreateAllAnimalsDT();
        }
        public DataTable CreateAllAnimalsDT()
        {
            SqlDataAdapter adptr2 = new SqlDataAdapter(" SELECT * FROM TBAnimals ", con);
            ds = new DataSet();
            adptr2.Fill(ds, "T2");
            dtA = ds.Tables["T2"];
            return dtA;
        }

        public DBConnection(string continent)
        {
            con = new SqlConnection(strCon);
            this.continent = continent;
            adptr = new SqlDataAdapter($" SELECT * FROM TBAnimals WHERE Continent = '{continent}'", con);
            ds = new DataSet();
            rowcounter = CreateAllAnimalsDT().Rows.Count + 1;
        }

        public DataTable FillTable()
        {
            ds.Clear();
            adptr.Fill(ds, "T1");
            dtC = ds.Tables["T1"];
            return dtC;// לפי היבשת 

        }

        public void UpdateToDatabase()
        {
            new SqlCommandBuilder(adptr);
            adptr.Update(dtC);
        }

        public DataTable Insert(string name, float weight, bool eats)
        {

            DataRow dr = dtC.NewRow();
            dr["ID"] = rowcounter++;
            dr["Name"] = name;
            dr["Weight"] = weight;
            dr["EatMeat"] = eats;
            dr["Continent"] = continent;
            dtC.Rows.Add(dr);
            return dtC;
        }

        public DataTable DeleteFromDT(string id)
        {

            for (int i = 0; i < dtC.Rows.Count; i++)
            {
                if (dtC.Rows[i]["ID"].ToString() == id)
                {
                    dtC.Rows[i].Delete();
                    return dtC;
                }
            }
            return dtC;
        }
        public DataTable Updatetable(string id, string name, float weight, bool eat)
        {

            for (int i = 0; i < dtC.Rows.Count; i++)
            {
                if (dtC.Rows[i].RowState != DataRowState.Deleted && dtC.Rows[i]["ID"].ToString() == id)
                {
                    dtC.Rows[i]["Name"] = name;
                    dtC.Rows[i]["Weight"] = weight;
                    dtC.Rows[i]["EatMeat"] = eat;
                }
            }
            return dtC;
        }
        public Animal[] CreateArray(Animal[] animals)
        {
            try
            {

                animals = new Animal[dtA.Rows.Count];
                for (int i = 0; i < dtA.Rows.Count; i++)
                {
                    if (dtA.Rows[i]["EatMeat"].ToString() == "False")
                    {
                        animals[i] = new VegetarianAnimals(int.Parse(dtA.Rows[i]["ID"].ToString()), dtA.Rows[i]["Name"].ToString(), float.Parse(dtA.Rows[i]["Weight"].ToString()), bool.Parse(dtA.Rows[i]["EatMeat"].ToString()), dtA.Rows[i]["Continent"].ToString());
                    }
                    else
                    {
                        animals[i] = new Animal(int.Parse(dtA.Rows[i]["ID"].ToString()), dtA.Rows[i]["Name"].ToString(), float.Parse(dtA.Rows[i]["Weight"].ToString()), bool.Parse(dtA.Rows[i]["EatMeat"].ToString()), dtA.Rows[i]["Continent"].ToString());
                    }
                }
                return animals;
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL ERR: " + ex.Message);
            }
            rowcounter = animals.Length;
            return animals;
        }

        public DataTable SortDT(bool sortByName)
        {
            try
            {
                if (sortByName)
                {
                    SqlDataAdapter adptr3 = new SqlDataAdapter($" SELECT * FROM TBAnimals WHERE Continent = '{continent}' ORDER BY Name ", con);
                    ds.Clear();
                    adptr3.Fill(ds, "T3");
                    dtC = ds.Tables["T3"];
                    return dtC;
                }
                else
                {
                    SqlDataAdapter adptr3 = new SqlDataAdapter($" SELECT * FROM TBAnimals WHERE Continent = '{continent}' ORDER BY Weight ", con);
                    ds.Clear();
                    adptr3.Fill(ds, "T1");
                    dtC = ds.Tables["T1"];
                    return dtC;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL ERR: " + ex.Message);
            }
            return dtC;
        }
        public string DataReader()
        {
            con = new SqlConnection(strCon);
            cmd = new SqlCommand($" SELECT * FROM TBAnimals WHERE Continent = '{continent}'  ", con);
            string str = "";
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    Console.WriteLine("No Items");
                }
                else while (reader.Read())
                    {
                        str += $"ID: {reader["ID"]}  |  Name: {reader["Name"]}  |  Weight: { reader["Weight"]} KG  |  Continent: { reader["Continent"]}\r\n";

                    }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL ERR: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return str;
        }

        public DataTable FilterByAbovePrice(float weight)
        {
            try
            {
                cmd = new SqlCommand("ShowbyWeight", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parPower = new SqlParameter("weight", SqlDbType.Float);
                parPower.Direction = ParameterDirection.Input;
                parPower.Value = weight;
                cmd.Parameters.Add(parPower);
                adptr = new SqlDataAdapter(cmd);
                ds.Clear();
                adptr.Fill(ds, "TBAnimals");
                dtA = ds.Tables["TBAnimals"];
                return dtA;
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL ERR : " + ex.Message);
                return null;
            }
        }
        public DataTable FilterByUnderPrice(float weight)
        {
            try
            {
                cmd = new SqlCommand("ShowbyWeightunder", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parPower = new SqlParameter("weight", SqlDbType.Float);
                parPower.Direction = ParameterDirection.Input;
                parPower.Value = weight;
                cmd.Parameters.Add(parPower);
                adptr = new SqlDataAdapter(cmd);
                ds.Clear();
                adptr.Fill(ds, "TBAnimals");
                dtC = ds.Tables["TBAnimals"];
                return dtC;
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL ERR : " + ex.Message);
                return null;
            }
        }


    }
}
