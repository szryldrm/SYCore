using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYCore.Utilities.Messages
{
    public static class GeneralMessages
    {
        public static string ERROR_MESSAGE = "SORRY, AN ERROR HAS OCCURED! DETAILS: ";

        public static string NOT_FOUND(string name)
        {
            return name + " NOT FOUND!";
        }

        public static string ADDED(string name)
        {
            return name + " ADDED SUCCESFULLY";
        }
        public static string NOT_ADDED(string name)
        {
            return name + " NOT ADDED!";
        }

        public static string DELETED(string name)
        {
            return name + " DELETED SUCCESFULLY";
        }
        public static string NOT_DELETED(string name)
        {
            return name + " NOT DELETED!";
        }

        public static string UPDATED(string name)
        {
            return name + " UPDATED SUCCESFULLY";
        }
        public static string NOT_UPDATED(string name)
        {
            return name + " NOT UPDATED!";
        }
    }
}
