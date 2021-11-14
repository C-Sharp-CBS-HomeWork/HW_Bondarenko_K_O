using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Task_14_1
{
    class User
    {
        private string login, name, surname;
        private int age;
        private readonly DateTime createTime;

        

        public User()
        {            
            createTime = DateTime.Now;
        }


        public string Login 
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public DateTime CreateTime
        {
            get
            {
                return createTime;
            }
        }        
    }
}
