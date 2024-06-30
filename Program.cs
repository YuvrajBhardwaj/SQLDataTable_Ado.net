using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SQLDataTable_Ado.net
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                DataTable employees = new DataTable("employees");

                //DataColumn id = new DataColumn("id")
                //{
                //    Caption = "EMP_ID",
                //    DataType = typeof(int),
                //    AllowDBNull = false,
                //};
                //employees.Columns.Add(id);

                DataColumn id = new DataColumn("id");
                id.Caption = "EMP_ID";
                id.DataType = typeof(int);
                id.AllowDBNull = false;
                id.AutoIncrement = true;
                id.AutoIncrementSeed = 1001;
                id.AutoIncrementStep = 1;
                employees.Columns.Add(id);

                
                DataColumn name = new DataColumn("name");
                name.Caption = "EMP_NAME";
                name.DataType = typeof(string);
                name.AllowDBNull = false;
                name.MaxLength = 50;
                name.DefaultValue = "Anonymous";
                employees.Columns.Add(name);

                DataColumn gender = new DataColumn("gender");
                gender.Caption = "GENDER";
                gender.DataType = typeof(string);
                gender.AllowDBNull = false;
                gender.MaxLength = 20;
                employees.Columns.Add(gender);


                DataRow row1 = employees.NewRow();
                //row1["id"] = 1;
                row1["name"] = "Yuvraj";
                row1["gender"] = "Male";
                employees.Rows.Add(row1);

                employees.Rows.Add(null, "Pratham", "Male");
                employees.Rows.Add(null, "Shipra", "Female");

                employees.PrimaryKey = new DataColumn[] { id }; //auto increment

                foreach (DataRow row in employees.Rows)
                {
                    Console.WriteLine(row["id"] + " " + row["name"] + " " + row["gender"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            Console.ReadLine();
        }
    }
}
