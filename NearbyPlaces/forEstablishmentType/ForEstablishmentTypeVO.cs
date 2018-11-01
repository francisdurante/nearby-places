using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.forEstablishmentType
{
    class ForEstablishmentTypeVO
    {
        public static int id;
        public static int status;
        public static string estTypeName;

        public static int getEstTypeID()
        {
            return id;
        }

        public static void setEstTypeID(int value)
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
        public static string getEstTypeName()
        {
            return estTypeName;
        }

        public static void setEstTypeName(string value)
        {
            estTypeName = value;
        }
    }
}
