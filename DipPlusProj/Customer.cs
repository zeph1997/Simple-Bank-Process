using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPlusProj
{
    public class Customer
    {
        private string user;
        private string pass;
        private string names;
        private double balance;
        public Customer(string username, string password,string name, double bal)
        {
            user = username;
            pass = password;
            names = name;
            balance = bal;
        
        }
        public string getNames()
        {
            return names;
        }
        public double getBalance()
        {
            return balance;
        }
        public string getUser()
        {
            return user;
        }
        public string getPass()
        {
            return pass;
        }
        public double fromBalance(double amt)
        {
            this.balance = this.balance - amt;
            return this.balance;
        }

        public double toBalance(double amt)
        {
            this.balance = this.balance + amt;
            return this.balance;
        }

        public void setUser(String user)
        {
            this.user = user;
        }
    }
    class UEight : Customer
    {
        private string pemail;
        public UEight(string username, string password, string name, double bal, string parentemail) : base (username, password,name,bal)
        {
            pemail = parentemail;
        }
    }
    class Ncustomer : Customer
    {
        private int cardtype;
        public Ncustomer(string username, string password, string name, double bal, int ctype) : base (username, password,name,bal)
        {
            cardtype = ctype;

        }
    }
    class Highnet : Customer
    {
        private int premiumctype;
        public Highnet(string username, string password, string name, double bal, int pctype) : base(username, password,name, bal)
        {
            premiumctype = pctype;
        }
    }
}