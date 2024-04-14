using System;

namespace  CustomDataList
{
         class Program
    {
             static void Main(string[] args)
        {
            Students student = new Students
            {
                StudentFirstName = "Eya",
                StudentLastName = "Dellai",
                StudentNumber = "15010",
                StudentAverageScore = 3.15f
            };
            CustomDataList dataList = new CustomDataList(10);

            dataList.Add(student, "2");
            dataList.DisplayList();




        }
    }
}