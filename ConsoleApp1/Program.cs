using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            DataTable dataTable = new DataTable("Inventory");

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name",typeof(string));
            dataTable.Columns.Add("Count",typeof(int));

            dataTable.Rows.Add(1,"Dirt",16);
            dataTable.Rows.Add(2,"Cobblestone",64);
            dataTable.Rows.Add(3,"Wood",32);

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine
                    (
                    $"#{row["ID"],-5} - {row["Name"],-20} - {row["Count"],-3}шт."
                    );
            }

            Console.WriteLine("\n\n\n");

            DataTable Students = new DataTable("Students");
            Students.Columns.Add("ID", typeof(int));
            Students.Columns.Add("Name", typeof(string));
            Students.Columns.Add("GroupName", typeof(string));
            Students.Columns.Add("Age", typeof(int));

            Students.Rows.Add(0, "Art", "RPO", 18);
            Students.Rows.Add(1, "Danil", "RPO", 20);
            Students.Rows.Add(2, "Karen", "RPO", 17);
            Students.Rows.Add(3, "SomeOne", "RPO", 19);
            Students.Rows.Add(4, "NoOne", "RPO", 1);

            int tempAge = 0;
            int tempID = 0;
            foreach (DataRow row in Students.Rows)
            {
                Console.WriteLine
                (
                    $"#{row["ID"],-3} - {row["Name"],-10} - {row["GroupName"],-10} - {row["Age"]}"
                );

                if (tempAge < Convert.ToInt32(row["Age"]))
                {
                    tempAge = Convert.ToInt32(row["Age"]);
                    tempID = Convert.ToInt32(row["ID"]);
                }
            }
            var stud = Students.Rows[tempID];
            Console.WriteLine
                (
                "\nThe oldest student is - "
                );
            Console.WriteLine
                (
                $"#{stud["ID"],-3} - {stud["Name"],-10} - {stud["GroupName"],-10} - {stud["Age"]}"
                );

            //test
        }
    }
}