using Dropbox.Api;
using Dropbox.Api.Files;
using NearbyPlaces.ForEstablishmentLogin;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NearbyPlaces
{
    class ApiClass
    {
        public static bool establisment_login(string username, string password)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            HttpResponseMessage response = client.GetAsync("api/login?username=" + username + "&password=" + password + "&pass=for_login&for_log=desktop_app").Result;
            var result = response.Content.ReadAsStringAsync().Result;

            var status = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
            string responseStatus = status["status"].ToString();
            var datas = status["data"];
            if (responseStatus.Equals("sucess"))
            {
                ForEstablishmentLogin.ForLoginEstVO.setEstID(Convert.ToInt32(status["data"]["id"]));
                ForEstablishmentLogin.ForLoginEstVO.setEstUserID(Convert.ToInt32(status["data"]["establishment_user_id"]));
                ForEstablishmentLogin.ForLoginEstVO.setEstName(status["data"]["establishment_name"].ToString());
                ForEstablishmentLogin.ForLoginEstVO.setEmotion(status["data"]["good_for_emotion_of"].ToString());
                ForEstablishmentLogin.ForLoginEstVO.setAge(status["data"]["good_at_of"].ToString());
                ForEstablishmentLogin.ForLoginEstVO.setStatus(Convert.ToInt32(status["data"]["status"]));
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool establishment_registration(string username, string password, string est_name, string lat, string lon, string emotion, string age, string pass)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            HttpResponseMessage response = client.GetAsync("api/establishment_registration?username=" + username +
                "&password=" + password +
                "&pass=" + pass +
                "&est_name=" + est_name +
                "&lat=" + lat +
                "&lon=" + lon +
                "&emotion=" + emotion +
                "&age=" + age).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            var status = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
            string responseStatus = status["status"].ToString();
            if (responseStatus.Equals("success"))
            {
                return true;
            }
            else if (responseStatus.Equals("existing"))
            {
                MessageBox.Show("User Already in Database", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (responseStatus.Equals("fail"))
            {
                MessageBox.Show("Something went Wrong Please Contact Administrator", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Something went Wrong Please Contact Administrator", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool est_add_category(string categoryName, int added_by)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            HttpResponseMessage response = client.GetAsync("api/add_category?cat_name=" + categoryName +
                "&pass=est_category" +
                "&added_by=" + added_by).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            var status = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
            string responseStatus = status["status"].ToString();
            if (responseStatus.Equals("success"))
            {
                return true;
            }
            else if (responseStatus.Equals("existing"))
            {
                MessageBox.Show("Category Already in Database", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (responseStatus.Equals("fail"))
            {
                MessageBox.Show("Something went Wrong Please Contact Administrator", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Something went Wrong Please Contact Administrator", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static ArrayList getCategory(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            HttpResponseMessage response = client.GetAsync("api/get_category?id=" + id +
                "&pass=est_get_category").Result;
            var result = response.Content.ReadAsStringAsync().Result;
            var status = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
            string responseStatus = status["status"].ToString();

            ArrayList category = new ArrayList();
            if (responseStatus.Equals("success"))
            {
                int length = ((JArray)status["data"]).Count;
                for (int x = 0; x < length; x++)
                {
                    category.Add(status["data"][x]["category_name"].ToString());
                }
            }
            return category;
        }

        public static bool addProduct(string productName, string productPrice, string productPicPath,string product_cat)
        {

            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            var formData = new MultipartFormDataContent();
            HttpContent pPP = new StreamContent(File.Open(productPicPath, FileMode.Open));
            string url = "http://darkened-career.000webhostapp.com/api/add_product?product_name=" + productName + 
                "&product_price=" + productPrice +
                "&pass=add_product&product_cat=" + product_cat + 
                "&est_id="+ForLoginEstVO.getEstID();
            //HttpResponseMessage response = client.GetAsync("api/add_product?product_name=" + productName +
            //    "&pass=add_product" +
            //    "&product_price=" + productPrice +
            //    "&file=" + productPicPath).Result;
            formData.Add(pPP,"imageOne","image123.jpg");
            var result = client.PostAsync(url, formData);
            var response = result.Result.Content.ReadAsStringAsync().Result;
            var status = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(response);
            string responseStatus = status["status"].ToString();
            if (responseStatus.Equals("success"))
            {
                return true;
            }
            else if(responseStatus.Equals("fail"))
            {
                return false;
            } else if (responseStatus.Equals("existing"))
            {
                MessageBox.Show("Product Already in Database","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                MessageBox.Show(response);
                return false;
            }
        }
        public static void UploadMyFile(string localFilePath)
        {
            string url = "http://darkened-career.000webhostapp.com/";
            using (WebClient client = new WebClient())
            {
                client.UploadFile(url, localFilePath);
            }
        }

    }
}
