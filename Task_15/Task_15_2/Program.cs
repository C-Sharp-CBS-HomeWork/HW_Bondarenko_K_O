using System;

namespace Task_15_2
{
    class Program
    {
        static void Main(string[] args)
        {          
            Pupil pupil1 = new BadPupil();
            Pupil pupil2 = new ExcelentPupil();
            Pupil pupil3 = new GoodPupil();
            Pupil pupil4 = new GoodPupil();

            Console.WriteLine("4 ученика");
            ClassRoom classRoom = new ClassRoom(pupil1 , pupil2, pupil3, pupil4);            
            classRoom.CwRes();

            Console.WriteLine("");
            Console.WriteLine("2 ученика");
            ClassRoom classRoom1 = new ClassRoom(pupil1 , pupil2);
            classRoom1.CwRes();

            Console.WriteLine("");
            Console.WriteLine("3 ученика");
            ClassRoom classRoom2 = new ClassRoom(pupil1, pupil2 , pupil3);
            classRoom2.CwRes();

            Console.ReadKey();
        }
    }
}
