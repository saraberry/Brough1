using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal
{
    public class User
    {
        private int userID, userZIP;
        private string userFirstName, userLastName, userAddress, userCity, userState, userPhone;

        public User()
        {

        }

        public User(int userID, string userFirstName, string userLastName, string userAddress, string userCity, string userState, int userZip, string userPhone)
        {
            this.userID = UserID;
            this.userFirstName = UserFirstName;
            this.userLastName = UserLastName;
            this.userAddress = UserAddress;
            this.userCity = UserCity;
            this.userState = UserState;
            this.userZIP = UserZip;
            this.userPhone = UserPhone;
        }

        public int UserID { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserAddress { get; set; }
        public string UserCity { get; set; }
        public string UserState { get; set; }
        public string UserPhone { get; set; }
        public int UserZip { get; set; }
    }
}