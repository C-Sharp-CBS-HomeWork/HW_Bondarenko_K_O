using System;
using System.Collections.Generic;
using System.Text;

namespace Task_15_2
{
    class ClassRoom
    {
        Pupil pupil1;
        Pupil pupil2;
        Pupil pupil3;
        Pupil pupil4;
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
            this.pupil4 = pupil4;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;            
        }

        void Res(Pupil pupil)
        {
            if (pupil != null)
            {
                Console.WriteLine("-----------------");
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();                
            }
            
        }

        public void CwRes()
        {
            Res(pupil1);            
            Res(pupil2);            
            Res(pupil3);            
            Res(pupil4);           
        }

    }
}
