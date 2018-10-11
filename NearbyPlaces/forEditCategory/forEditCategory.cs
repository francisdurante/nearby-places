using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.forEditCategory
{
    class forEditCategory
    {
        public static int id;
        public static int status;
        public static string categoryName;

        public static int getCatId()
        {
            return id;
        }

        public static void setCatId(int value)
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
        public static string getCategoryName()
        {
            return categoryName;
        }

        public static void setCategoryName(string value)
        {
            categoryName = value;
        }
    }
}
