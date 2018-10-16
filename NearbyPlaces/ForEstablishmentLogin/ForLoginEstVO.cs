using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.ForEstablishmentLogin
{
    class ForLoginEstVO
    {
        public static int id;
        public static int establishment_user_id;
        public static string establishment_name;
        public static string good_for_emotion_of;
        public static string good_at_of;
        public static int status;
        public static string userName;
        public static string getUser()
        {
            return userName;
        }
        public static void setUser(string user)
        {
            userName = user;
        }

        public static int getEstID()
        {
            return id;
        }

        public static void setEstID(int value)
        {
            id = value;
        }
        public static int getEstUserID()
        {
            return establishment_user_id;
        }

        public static void setEstUserID(int value)
        {
            establishment_user_id = value;
        }
        public static string getEstName()
        {
            return establishment_name;
        }

        public static void setEstName(string value)
        {
            establishment_name = value;
        }
        public static string getEmotion()
        {
            return good_for_emotion_of;
        }

        public static void setEmotion(string value)
        {
            good_for_emotion_of = value;
        }
        public static string getAge()
        {
            return good_at_of;
        }

        public static void setAge(string value)
        {
            good_at_of = value;
        }
        public static int getStatus()
        {
            return status;
        }

        public static void setStatus(int value)
        {
            status = value;
        }
    }
}
