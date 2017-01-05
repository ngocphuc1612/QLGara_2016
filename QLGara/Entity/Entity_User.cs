using System;
using System.Data;

namespace Entity
{
    public class Entity_User
    {
        #region Constructor
        public Entity_User(int id, string username, string email, string pass, int role, bool gender, DateTime dt, string fullName, string phone, string direction)
        {
            this.username = username;
            this.email = email;
            this.pass = pass;
            this.role = role;
            this.gender = gender;
            this.birthday = dt;
            this.fullName = fullName;
            this.phone = phone;
            this.direction = direction;
        }

        //Use it for update
        public void update(string email, string pass, string sdt, string direction)
        {
            this.email = email;
            this.pass = pass;
            this.phone = sdt;
            this.direction = direction;

        }

        public Entity_User(DataRow dr)
        {
            try
            {
                this.username = dr["USERNAME"].ToString();
                this.email = dr["EMAIL"].ToString();
                this.pass = dr["PASS"].ToString();
                this.role = Int32.Parse(dr["ROLE_ID"].ToString());
                this.gender = (bool)(dr["GENDER"]);
                this.birthday = (DateTime)(dr["BIRTHDAY"]);
                this.fullName = dr["FULL_NAME"].ToString();
                this.phone = dr["PHONE"].ToString();
                this.direction = dr["DIRECTION"].ToString();
                this.id = dr["USER_ID"].ToString();
            }
            catch
            {
                Console.WriteLine("Co thay doi trong sql server!");
            }
        }
        #endregion

        #region Fields
        public string id;
        private string username;
        private string email;
        private string pass;
        int role;
        private bool gender;
        private DateTime birthday;
        private string fullName;
        private string phone;
        private string direction;
        #endregion

        #region Properties
        public string Username
        {
            get
            {
                return username;
            }
             
        }

        public string Email
        {
            get
            {
                return email;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }
        }

        public int Role
        {
            get
            {
                return role;
            }
        }

        public bool Gender
        {
            get
            {
                return gender;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
        }

        public string FullName
        {
            get
            {
                return fullName;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
        }

        public string Direction
        {
            get
            {
                return direction;
            }
        }
        #endregion
    }
}
