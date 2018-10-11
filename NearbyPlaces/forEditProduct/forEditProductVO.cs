using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.forEditProduct
{
    class forEditProductVO
    {
        public static int id;
        public static int status;
        public static string itemName;
        public static string path;
        public static string price;
        public static string category;

        public static int getItemId()
        {
            return id;
        }

        public static void setItemId(int value)
        {
            id = value;
        }
        public static int getStatus()
        {
            return status;
        }

        public static void setStatus(int value)
        {
            status = value;
        }
        public static string getItemName()
        {
            return itemName;
        }

        public static void setItemName(string value)
        {
            itemName = value;
        }
        public static string getPath()
        {
            return path;
        }

        public static void setPath(string value)
        {
            path = value;
        }
        public static string getPrice()
        {
            return price;
        }

        public static void setPrice(string value)
        {
            price = value;
        }
        public static string getCategory()
        {
            return category;
        }

        public static void setCategory(string value)
        {
            category = value;
        }
    }
}
