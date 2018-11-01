using NearbyPlaces.ForEstablishmentLogin;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
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
                ForEstablishmentLogin.ForLoginEstVO.setEstID(Convert.ToInt32(status["data"]["est_id"]));
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

        public static bool establishment_registration(string username, string password, string est_name, string lat, string lon, string emotion, string age, string pass,int est_id,string storePath,string address)
        {
            HttpClient client = new HttpClient();
            string url = "http://darkened-career.000webhostapp.com/api/establishment_registration?username=" + username +
                "&password=" + password +
                "&pass=" + pass +
                "&est_name=" + est_name +
                "&lat=" + lat +
                "&lon=" + lon +
                "&emotion=" + emotion +
                "&age=" + age +
                "&est_type_id=" + est_id +
                "&address="+address;

            var result = (dynamic)null;
            if (storePath != "")
            {
                var formData = new MultipartFormDataContent();
                HttpContent pPP = new StreamContent(File.Open(storePath, FileMode.Open));
                formData.Add(pPP, "imageOne", "image123.jpg");
                result = client.PostAsync(url, formData);
            }
            else
            {
                 result = client.GetAsync(url);
            }
            var response = result.Result.Content.ReadAsStringAsync().Result;
            var status = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(response);
            string responseStatus = status["status"].ToString();
            MessageBox.Show(responseStatus);
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

        public static ArrayList getCategory(int id,string process)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            HttpResponseMessage response = client.GetAsync("api/get_category?id=" + id +
                "&pass=est_get_category&for_process="+process).Result;
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
        public static ArrayList getCategory(string process)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            HttpResponseMessage response = client.GetAsync("api/get_category?" +
                "&pass=est_get_category&for_process=" + process).Result;
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
        public static ArrayList getProduct(int id, string process)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            HttpResponseMessage response = client.GetAsync("api/get_product?id=" + id +
                "&pass=get_product&for_process=" + process).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            var status = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
            string responseStatus = status["status"].ToString();

            ArrayList product = new ArrayList();
            if (responseStatus.Equals("success"))
            {
                int length = ((JArray)status["data"]).Count;
                for (int x = 0; x < length; x++)
                {
                    product.Add(status["data"][x]["item_name"].ToString());
                }
            }
            return product;
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
       
        public static void editCategory(int id,string categoryName)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            HttpResponseMessage response = client.GetAsync("api/edit_category?est_id=" + id +
                "&pass=edit_category"+
                "&cat_name="+ categoryName).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            var status = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
            string responseStatus = status["status"].ToString();
            if (responseStatus.Equals("success"))
            {
                forEditCategory.forEditCategory.setCatId(Convert.ToInt32((status["data"]["id"])));
                forEditCategory.forEditCategory.setCategoryName(status["data"]["category_name"].ToString());
                forEditCategory.forEditCategory.setStatus(Convert.ToInt32(status["data"]["status"]));
            }
            else
            {
                MessageBox.Show("Error in retrieving Data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool submit_edited_category(int cat_id, int est_id, string cat_name, int status)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            HttpResponseMessage response = client.GetAsync("api/submit_edited_category?cat_id=" + cat_id +
                "&pass=submit_edited_category" +
                "&cat_name=" + cat_name +
                "&status="+status+
                "&est_id="+est_id).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            var status1 = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
            string responseStatus = status1["status"].ToString();
            if (responseStatus.Equals("success"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void editProduct(int id, string productName)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            HttpResponseMessage response = client.GetAsync("api/edit_product?est_id=" + id +
                "&pass=get_product" +
                "&item_name=" + productName).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            var status = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
            string responseStatus = status["status"].ToString();
            if (responseStatus.Equals("success"))
            {
                forEditProduct.forEditProductVO.setItemId(Convert.ToInt32((status["data"]["item_id"])));
                forEditProduct.forEditProductVO.setItemName(status["data"]["item_name"].ToString());
                forEditProduct.forEditProductVO.setStatus(Convert.ToInt32(status["data"]["item_status"]));
                forEditProduct.forEditProductVO.setPath(status["data"]["path"].ToString());
                forEditProduct.forEditProductVO.setPrice(status["data"]["price"].ToString());
                forEditProduct.forEditProductVO.setCategory(status["data"]["category_name"].ToString());
            }
            else
            {
                MessageBox.Show("Error in retrieving Data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool submit_edited_product(int item_id, int est_id, string cat_name, int status, string localPath, string item_name,string price,int upload)//upload 1 0-dont upload
        {
            HttpClient client = new HttpClient();
            var formData = new MultipartFormDataContent();
            if (upload == 1) { 
                HttpContent pPP = new StreamContent(File.Open(localPath, FileMode.Open));
                formData.Add(pPP, "imageOne", "image123.jpg");
            }
            string url = "http://darkened-career.000webhostapp.com/api/submit_edited_product?id=" + item_id +
                "&pass=submit_edited_product" +
                "&cat_name=" + cat_name +
                "&status=" + status +
                "&est_id=" + est_id +
                "&item_name="+item_name +
                "&price="+price+
                "&upload="+upload;
            var result = client.PostAsync(url, formData);
            var response = result.Result.Content.ReadAsStringAsync().Result;
            var status1 = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(response);
            string responseStatus = status1["status"].ToString();
            if (responseStatus.Equals("success"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool add_est_type(string est_name)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            HttpResponseMessage response = client.GetAsync("api/add_est_type?est_type_name=" + est_name +
                "&pass=insert_est_tpye").Result;
            var result = response.Content.ReadAsStringAsync().Result;
            var status = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
            string responseStatus = status["status"].ToString();
            if (responseStatus.Equals("success"))
            {
                return true;
            }
            else if(responseStatus.Equals("existing"))
            {
                MessageBox.Show("Establishment Type Already Exist", "Add Establishment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Error in Adding Establishment Type", "Add Establishment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static ArrayList get_est_type(string status1, string est_type_name)
        {
            ArrayList type = new ArrayList();
            string url = "";
            HttpClient client = new HttpClient();
            if(status1 == "all")
            {
                url = "api/get_all_est_type?pass=get_est_type&status=all";
            }
            else if(status1 == "active")
            {
                url = "api/get_all_est_type?pass=get_est_type&status=active";
            }
            else if(status1 == "specific")
            {
                url = "api/get_all_est_type?pass=get_est_type&status=specific&est_type_name=" +
                    est_type_name;
            }
            client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            HttpResponseMessage response = client.GetAsync(url).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            var status = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
            string responseStatus = status["status"].ToString();
            if(responseStatus == "success" && status1 == "specific")
            {
                forEstablishmentType.ForEstablishmentTypeVO.setEstTypeID(Convert.ToInt32(status["data"]["id"]));
                forEstablishmentType.ForEstablishmentTypeVO.setEstTypeName(status["data"]["est_type_name"].ToString());
                forEstablishmentType.ForEstablishmentTypeVO.setStatus(Convert.ToInt32(status["data"]["status"]));
            }
            else if(responseStatus == "success" && status1 == "all")
            {
                int length = ((JArray)status["data"]).Count;
                for (int x = 0; x < length; x++)
                {
                    type.Add(status["data"][x]["est_type_name"].ToString());
                }
            }
            else if(responseStatus =="success" && status1 == "active")
            {
                int length = ((JArray)status["data"]).Count;
                for (int x = 0; x < length; x++)
                {
                    type.Add(status["data"][x]["est_type_name"].ToString());
                }
            }
            return type;
        }

        public static bool submit_edited_est_type(string est_type_name,int editStatus,int id)
        {
            if(est_type_name == forEstablishmentType.ForEstablishmentTypeVO.getEstTypeName())
            {
                est_type_name = "";
            }
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            HttpResponseMessage response = client.GetAsync("api/edit_est_type?est_type_name=" + est_type_name +
                "&pass=edit_est_type" +
                "&id="+id+
                "&status="+ editStatus).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            var status = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
            string responseStatus = status["status"].ToString();
            if(responseStatus == "success")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string[,] get_all_est_user(string key,string filter)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            HttpResponseMessage response = client.GetAsync("api/get_all_est_user?pass=get_all_est_user&key=" + key + "&filter="+filter).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            var status = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
            string responseStatus = status["status"].ToString();
            string[,] est_user = null;
            if (responseStatus == "success")
            {

                int length = ((JArray)status["data"]).Count;
                est_user = new string[length, 12];
                for (int x = 0; x < length; x++)
                {
                    int i = 0;
                    est_user[x, i] = status["data"][x]["establishment_user_id"].ToString();
                    est_user[x, ++i] = status["data"][x]["username"].ToString();
                    est_user[x, ++i] = status["data"][x]["establishment_name"].ToString();
                    est_user[x, ++i] = status["data"][x]["est_type_name"].ToString();
                    est_user[x, ++i] = status["data"][x]["location_latitude"] == null ? "N/A" : status["data"][x]["location_latitude"].ToString();
                    est_user[x, ++i] = status["data"][x]["location_longitude"] == null ? "N/A" : status["data"][x]["location_longitude"].ToString();
                    est_user[x, ++i] = status["data"][x]["good_for_emotion_of"].ToString();
                    est_user[x, ++i] = status["data"][x]["good_at_of"].ToString();
                    est_user[x, ++i] = status["data"][x]["est_front_store"] == null ? "N/A" : path(status["data"][x]["est_front_store"].ToString());
                    est_user[x, ++i] = status["data"][x]["est_status"].ToString() == "1" ? "ACTIVE" : "INACTIVE";
                    est_user[x, ++i] = status["data"][x]["user_status"].ToString() == "1" ? "ACTIVE" : "INACTIVE";
                    est_user[x, ++i] = status["data"][x]["address"] == null ? "N/A" : status["data"][x]["address"].ToString();

                }
            }
            else {
                MessageBox.Show("Error Getting Registered Establishment", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                est_user = null;
            }

            return est_user;
        }

        public static bool submit_edit_est_setting(string id,string est_name,string address,string lat, string lon,string emotion,string age, string est_type,string path)
        {
            HttpClient client = new HttpClient();
            string url = "http://darkened-career.000webhostapp.com/api/submit_edit_establishment_setting?est_name=" + est_name +
                "&lat=" + lat +
                "&lon=" + lon +
                "&emotion=" + emotion +
                "&age=" + age +
                "&est_type=" + est_type +
                "&address=" + address +
                "&est_id=" + id +
                "&pass=submit_edit_est";

            var result = (dynamic)null;
            if (path != "")
            {
                var formData = new MultipartFormDataContent();
                HttpContent pPP = new StreamContent(File.Open(path, FileMode.Open));
                formData.Add(pPP, "imageOne", "image123.jpg");
                result = client.PostAsync(url, formData);
            }
            else
            {
                result = client.GetAsync(url);
            }

            var response = result.Result.Content.ReadAsStringAsync().Result;
            var status = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(response);
            string responseStatus = status["status"].ToString();
            if (responseStatus.Equals("success"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static string path(string path)
        {
            String[] separated = path.Split('/');
            path = separated[6] + "/" + separated[7];
            return "http://darkened-career.000webhostapp.com/" + path;
        }

        public static bool changePass(string password, string new_pass,string user_id)
        {
            bool resp = false;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://darkened-career.000webhostapp.com/");
            HttpResponseMessage response = client.GetAsync("api/change_pass?password=" + password +
                "&pass=change_est_pass" +
                "&new_password=" + new_pass +
                "&user_id=" + user_id).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            var status = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
            string responseStatus = status["status"].ToString();
            if (responseStatus == "success")
            {
                resp = true;
            }
            else if(responseStatus == "not match")
            {
                resp = false;
                MessageBox.Show("Your Current Password not Match", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                resp = false;
                MessageBox.Show("Change Password Failed", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return resp;
        }
    }
}
