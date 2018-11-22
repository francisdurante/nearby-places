using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces
{
    class GlobalVO
    {
        private static int id;
        public static int getCommentID()
        {
            return id;
        }

        public static void setCommentID(int value)
        {
            id = value;
        }
    }
}
