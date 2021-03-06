<?php
namespace App\Http\Controllers;

use DB;
use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Hash;
use Validator;
use Carbon\Carbon;

class ApiController extends Controller
{
    public function establishment_registration(Request $request){
        $insert["username"] = $request->username;
        $insert["password"] = Hash::make($request->password);
        $insert["date_created"] = Carbon::now('Asia/Manila');
        $insert["status"] = 1;
        
        $insert_est["establishment_name"] = $request->est_name;
        $insert_est["location_latitude"] = $request->lat;
        $insert_est["location_longitude"] = $request->lon;
        $insert_est["good_for_emotion_of"] = $request->emotion;
        $insert_est["good_at_of"] = $request->age;
        $insert_est["status"] = 1;
        $insert_est["date_created"] = Carbon::now();
        $insert_est["est_type_id"] = $request->est_type_id;
        $insert_est["address"] = $request->address;
        
        $pass = $request->pass;
        $imageOne = $request->file('imageOne');
        if($pass == "est_registration"){
            $check = DB::table("tbl_estabalishment_user")->where("username",$insert["username"])->count();
            if($check == 0){
                if($imageOne != null){
                    $filename = $insert_est["establishment_name"] . '-' . time() . '.' . "jpg";
                    $location = public_path('images/');
                    $imageOne->move($location, $filename);
                    $insert_est["est_front_store"] = $location . $filename;
                }
                $insert_est["establishment_user_id"] = DB::table("tbl_estabalishment_user")->insertGetId($insert);
               if($insert_est["establishment_user_id"] > 0){
                    DB::table("tbl_establishment")->insert($insert_est);
                    $response["status"] = "success";
               }else{
                   $response["status"] = "fail";
               }
            }else{
                $response["status"] = "existing";
            }
        }else{
            $response["status"] = "fail";
        }
        return $response;
    }
    public function user_registration(Request $request){
        $insert["first_name"] = $request->first_name;
        $insert["last_name"] = $request->last_name;
        $insert["username"] = $request->username;
        $insert["email_address"] = $request->email;
        $insert["password"] = Hash::make($request->password);
        $insert["age"] = $request->age;
        $insert["preferred_food"] = $request->preferred_food;
        $insert["date_created"] = Carbon::now('Asia/Manila');
        $insert["status"] = 1;
        $pass = $request->pass;
        
        $check = DB::table("tbl_user")->where("username",$request->username)->count();
        if($check == 0){
            if($pass == "user_registration"){
                DB::table("tbl_user")->insert($insert);
                $response = "success";
            }else{
                $response = "fail";
            }
        }else{
            $response = "existing";
        }
        return $response;
    }
    public function login(Request $request){
        if($request->pass == "for_login"){
            if($request->for_log == "mobile_app"){
                $check = DB::table("tbl_user")->where("username",$request->username)->count();
                if($check == 1){
                    $checkPassword = DB::table("tbl_user")->where("username",$request->username)->first();
                    if(Hash::check($request->password,$checkPassword->password)){
                        $response["status"] = "sucess";
                        $response["data"] = DB::table("tbl_user")->where("username",$request->username)->get();
                    }else{
                        $response["status"]="fail";
                        $response["data"] = "";
                    }
                }
                else{
                    $response["status"] = "fail";
                    $response["data"] = "";
                }
            }else if($request->for_log == "desktop_app"){
                $check = DB::table("tbl_estabalishment_user")->where("username",$request->username)->count();
                if($check == 1){
                    $checkPassword = DB::table("tbl_estabalishment_user")->where("username",$request->username)->first();
                   if(Hash::check($request->password,$checkPassword->password)){
                        $response["status"] = "sucess";
                        $response["data"] = DB::table("tbl_establishment")->select("*","tbl_establishment.id as est_id")->join('tbl_estabalishment_user','tbl_establishment.establishment_user_id','=','tbl_estabalishment_user.id')->where("username",$request->username)->first();
                   }else{
                       $response["status"] = "fail";
                        $response["data"] = "";
                   }
                }
                else{
                    $response["status"] = "fail";
                    $response["data"] = "";
                }
            }
        }else{
            $response["status"] = "fail";
            $response["data"] = "";
        }
        return $response;
    }
    public function add_category(Request $request){
        $insert["category_name"] = $request->cat_name;
        $insert["status"] = 1;
        $insert["date_created"] = Carbon::now("Asia/Manila");
        $insert["added_by"] = $request->added_by;
        if($request->pass == "est_category"){
            $check = DB::table("tbl_menu_category")->where("category_name",$request->cat_name)->where("added_by",$request->added_by)->count();
            if($check == 0){
                $id = DB::table("tbl_menu_category")->insertGetId($insert);
                if($id > 0){
                    $response["status"] = "success";
                }else{
                    $response["status"] = "fail";
                }
            }else{
                $response["status"] = "existing";
            }
        }else{
            $response["status"] = "fail";
        }
        return json_encode($response);
    }
    public function getAllCategory(Request $request){
        $id = $request->id;
        if($request->for_process == "all_active")
        {
            if($request->pass == "est_get_category"){
                $response["status"] = "success";
                $response["data"] = DB::table("tbl_menu_category")->select("category_name")->where("added_by",$id)->where("status",1)->get();
            }else{
                $response["status"] = "fails";
                $response["data"] = "";
            }
        }else if($id != null){
             if($request->pass == "est_get_category"){
                $response["status"] = "success";
                $response["data"] = DB::table("tbl_menu_category")->select("category_name")->where("added_by",$id)->get();
            }else{
                $response["status"] = "fails";
                $response["data"] = "";
            }
        }
        else{
           if($request->pass == "est_get_category"){
                $response["status"] = "success";
                $response["data"] = DB::table("tbl_menu_category")->select("category_name")->get();
            }else{
                $response["status"] = "fails";
                $response["data"] = "";
            }
        }
        return json_encode($response);
    }
    public function add_product(Request $request){
        $check_existing = DB::table("tbl_menu_item")->where("item_name",$request->product_name)->where("establishment_id",$request->est_id)->count();
        if($check_existing == 0)
        {
            $imageOne = $request->file('imageOne');
            $filename = $request->product_name . '-' . time() . '.' . "jpg";
            $location = public_path('images/');
            $request->file('imageOne')->move($location, $filename);
      
            $insert["path"]    = $location . $filename;
            $insert["item_name"] = $request->product_name;
            $insert["price"] = $request->product_price;
            $insert["establishment_id"] = $request->est_id;
            $insert["status"] = 1;
            $insert["date_created"] = Carbon::now();
            $product_cat = $request->product_cat;
        if($request->pass == "add_product"){
          $cat_id = DB::table("tbl_menu_category")->where("category_name",$product_cat)->where("added_by",$request->est_id)->first();
          if($cat_id->id > 0){
             $insert["category_id"] = (int)$cat_id->id;
             $id = DB::table("tbl_menu_item")->insertGetId($insert);
            if($id > 0){
                $response["status"] = "success";
            }else{
                $response["status"] = "fail";
            }
            }else{
                $response["status"] = "fail";
            }
            }else{
                $response["status"] = "fail";
            }
        }else{
            $response["status"] = "existing";
        }   
       return json_encode($response);
    }
    public function get_category(Request $request){
        $est_id = $request->est_id;
        $cat_name = $request->cat_name;
        if($request->pass == "edit_category"){
            $check = DB::table("tbl_menu_category")->where("category_name",$cat_name)->where("added_by",$est_id);
            if($check->count() == 1){
                $response["status"] = "success";
                $response["data"] = $check->first();
            }else{
                $response["status"] = "fail";
                $response["data"] = "";
            }
        }
        return $response;
    }
    public function submit_edited_category(Request $request){
        $cat_id = $request->cat_id;
        $est_id = (int)$request->est_id;
        $update["category_name"] = $request->cat_name;
        $update["status"] = (int)$request->status;
        if($request->pass == "submit_edited_category"){
            DB::table("tbl_menu_category")->where("id",$cat_id)->update($update);
            $response["status"] = "success";
        }else{
            $response["status"] = "fail";
        }
        return $response;
    }
    public function submit_edited_product(Request $request){
        $item_id = $request->id;
        $cat_name = $request->cat_name;
        $item_name = $request->item_name;
        $est_id = $request->est_id;
        if($request->pass == "submit_edited_product"){
            
            $check_cat = DB::table("tbl_menu_category")->where("category_name",$cat_name)->where("added_by",$est_id)->count();
            if($check_cat == 1){
                $check_cat = DB::table("tbl_menu_category")->where("category_name",$cat_name)->where("added_by",(int)$est_id)->first();
                    $update["category_id"] = $check_cat->id;
                    $check_i_name = DB::table("tbl_menu_item")->where("item_name",$item_name)->where("establishment_id",$est_id)->count();
                if($check_i_name == 0)
                {
                    if((int)$request->upload == 1){
                        $imageOne = $request->file('imageOne');
                        $filename = $item_name . $request->id . '-' . time() . '.' . $imageOne->getClientOriginalExtension();
                            $location = public_path('images/');
                        $request->file('imageOne')->move($location, $filename);
                        $update["path"]      = $location . $filename;
                    }
                    $update["item_name"] = $request->item_name;
                    $update["price"]     = $request->price;
                    $update["status"]    = $request->status;
                    DB::table("tbl_menu_item")->where("id",$item_id)->update($update);
                    $response["status"] = "success";
                }
                else{
                    if((int)$request->upload == 1){
                        $imageOne = $request->file('imageOne');
                        $filename = $item_name . $request->id . '-' . time() . '.' . $imageOne->getClientOriginalExtension();
                            $location = public_path('images/');
                        $request->file('imageOne')->move($location, $filename);
                        $update["path"]      = $location . $filename;
                    }
                    $update["price"]     = $request->price;
                    $update["status"]    = $request->status;
                    DB::table("tbl_menu_item")->where("id",$item_id)->update($update);
                    $response["status"] = "success";
                }
            }else{
                $response["status"] = "Category Error";
            }
        }else{
            $response["status"] = "fail";
        }
        return $response;
    }
    public function get_product(Request $request){
        $item_name = $request->item_name;
        $est_id = $request->est_id;
        if($request->pass == "get_product"){
            $response["data"] = DB::table("tbl_menu_item")->select('*','tbl_menu_category.status as cat_status','tbl_menu_item.status as item_status','tbl_menu_item.id as item_id')->where("item_name",$item_name)->where("establishment_id",(int)$est_id)->join("tbl_menu_category","tbl_menu_category.id","=","tbl_menu_item.category_id")->first();
            $response["status"] = "success";
        }else{
            $response["data"] = "";
            $response["status"] = "fail";
        }
        return $response;
    }
    public function getAllProduct(Request $request){
        $id = $request->id;
        if($request->for_process == "all_active")
        {
            if($request->pass == "get_product"){
                $response["status"] = "success";
                $response["data"] = DB::table("tbl_menu_item")->select("item_name")->where("establishment_id",$id)->where("status",1)->get();
            }else{
                $response["status"] = "fails";
                $response["data"] = "";
            }
        }else{
            if($request->pass == "get_product"){
                $response["status"] = "success";
                $response["data"] = DB::table("tbl_menu_item")->select("item_name")->where("establishment_id",$id)->get();
            }else{
                $response["status"] = "fails";
                $response["data"] = "";
            }
        }
        return $response;
    }
    public function add_est_type(Request $request){
        $insert["est_type_name"] = $request->est_type_name;
        $insert["date_created"] = Carbon::now('Asia/Manila');
        $check_existing = DB::table("tbl_est_type")->where("est_type_name",$request->est_type_name)->count();
        if($request->pass == "insert_est_tpye"){
            if($check_existing == 0){
                $id = DB::table("tbl_est_type")->insertGetId($insert);
                if($id > 0){
                    $response["status"] = "success";
                }else{
                    $response["status"] = "fail";
                }
            }else{
                $response["status"] = "existing";
            }
        }else{
            $response["status"] = "fail";
        }
        return $response;
    }
    public function edit_est_type(Request $request){
        $update["est_type_name"] = $request->est_type_name;
        $update["status"] = (int)$request->status;
        $id = (int)$request->id;
        if($request->pass == "edit_est_type"){
            if($update["est_type_name"] == ""){//est_type_name not edited
                DB::table("tbl_est_type")->where("id",$id)->update(["status" => (int)$request->status]);
                $response["status"] = "success";
            }else{ 
                $count = DB::table("tbl_est_type")->where("est_type_name",$request->est_type_name)->count();
                if($count > 0){
                    $response["status"] = "existing";
                }else{
                    DB::table("tbl_est_type")->where("id",$id)->update($update);
                    $response["status"] = "success";
                }
            }
        }else{
                $response["status"] = "fail";
        }
        return $response;
    }
    public function get_all_est_type(Request $request){
        $status = $request->status;
        if($request->pass == "get_est_type"){
            if($status == "all"){
                $response["data"] = DB::table("tbl_est_type")->get();
                $response["status"] = "success";
            }else if($status == "active"){
                $response["data"] = DB::table("tbl_est_type")->where("status",1)->get();
                $response["status"] = "success";
            }else if($status = "specific"){
                $response["data"] = DB::table("tbl_est_type")->where("est_type_name",$request->est_type_name)->first();
                $response["status"] = "success";
            }
        }else{
            $response["data"] = "";
            $response["status"] = "fail";
        }
        return $response;
    }
    public function get_all_est_user(Request $request){
        if($request->pass == "get_all_est_user"){
            if($request->key == null && $request->filter == null && $request->food == null){
                $response["status"] = "success";
                $response["data"] =  DB::table("tbl_estabalishment_user")->select("*","tbl_estabalishment_user.status as user_status","tbl_establishment.status as est_status","tbl_estabalishment_user.id as est_id","tbl_establishment.id as est_id")->
                join("tbl_establishment","tbl_establishment.establishment_user_id","=","tbl_estabalishment_user.id")->
                join("tbl_est_type","tbl_est_type.id","=","tbl_establishment.est_type_id")->orderBy("tbl_establishment.id")->get();
            }else if($request->key != null && $request->filter == null && $request->food == null){
                 $response["status"] = "success";
                 $response["data"] =  DB::table("tbl_estabalishment_user")->select("*","tbl_estabalishment_user.status as user_status","tbl_establishment.status as est_status","tbl_estabalishment_user.id as est_id","tbl_establishment.id as est_id")->where("tbl_establishment.establishment_name","LIKE","%".$request->key."%")->orWhere("tbl_est_type.est_type_name",$request->key)->
                join("tbl_establishment","tbl_establishment.establishment_user_id","=","tbl_estabalishment_user.id")->
                join("tbl_est_type","tbl_est_type.id","=","tbl_establishment.est_type_id")->orderBy("tbl_establishment.id")->get();
            }else if($request->key != null && $request->filter != null && $request->food == null){
                $response["status"] = "success";
                $response["data"] =  DB::table("tbl_estabalishment_user")->select("*","tbl_estabalishment_user.status as user_status","tbl_establishment.status as est_status","tbl_estabalishment_user.id as est_id","tbl_establishment.id as est_id")->where("tbl_establishment.establishment_name",$request->key)->where("tbl_est_type.est_type_name",$request->filter)->
                join("tbl_establishment","tbl_establishment.establishment_user_id","=","tbl_estabalishment_user.id")->
                join("tbl_est_type","tbl_est_type.id","=","tbl_establishment.est_type_id")->orderBy("tbl_establishment.id")->get();
            }else if($request->key == null && $request->filter != null && $request->food == null){
                $response["status"] = "success";
                $response["data"] =  DB::table("tbl_estabalishment_user")->select("*","tbl_estabalishment_user.status as user_status","tbl_establishment.status as est_status","tbl_estabalishment_user.id as est_id","tbl_establishment.id as est_id")->where("tbl_est_type.est_type_name",$request->filter)->
                join("tbl_establishment","tbl_establishment.establishment_user_id","=","tbl_estabalishment_user.id")->
                join("tbl_est_type","tbl_est_type.id","=","tbl_establishment.est_type_id")->orderBy("tbl_establishment.id")->get();
            }else if($request->food != null && $request->filter == null && $request->key == null){ 
                $response["status"] = "success";
                $response["data"] =  DB::table("tbl_estabalishment_user")->select("*","tbl_estabalishment_user.status as user_status","tbl_establishment.status as est_status","tbl_estabalishment_user.id as est_id","tbl_establishment.id as est_id")->where("tbl_menu_item.item_name","LIKE","%".$request->food."%")->
                join("tbl_establishment","tbl_establishment.establishment_user_id","=","tbl_estabalishment_user.id")->
                join("tbl_est_type","tbl_est_type.id","=","tbl_establishment.est_type_id")->orderBy("tbl_establishment.id")->
                join("tbl_menu_item","tbl_menu_item.establishment_id","=","tbl_estabalishment_user.id")->get();
            }
            foreach($response["data"] as $key=>$value){
                // $response["rate"][$key] = $value->est_id;
                $response["rate_count"][$value->est_id] = DB::table("tbl_rating")->where("est_id",$value->est_id)->count();
                $response["rate"][$value->est_id] = DB::table("tbl_rating")->where("est_id",$value->est_id)->avg("rate");
                if($response["rate"][$value->est_id] == null){
                    $response["rate"][$value->est_id] = 0;
                }
            }
             
        }
        if($response["data"]->isEmpty()){
            $response["status"] = "fail";
        }
        return $response;
    }
    public function get_est_product(Request $request){
        $id = $request->id;
        if($request->for_process == "all_active")
        {
            if($request->pass == "get_product"){
                $response["status"] = "success";
                $response["data"] = DB::table("tbl_menu_item")->select("tbl_menu_item.*","tbl_menu_category.category_name","tbl_menu_item.status as item_status","tbl_menu_category.status as category_status")->where("tbl_menu_item.establishment_id",$id)->where("tbl_menu_item.status",1)->join("tbl_menu_category","tbl_menu_category.id","=","tbl_menu_item.category_id")->where("tbl_menu_category.added_by",$id)->orderBy("tbl_menu_category.category_name")->get();
            }else{
                $response["status"] = "fails";
                $response["data"] = "";
            }
        }
        return $response;
    }
    public function submit_edit_establishment_setting(Request $request){
        $est_id = $request->est_id;
        $update["establishment_name"]   = $request->est_name;
        $update["location_latitude"]    = $request->lat;
        $update["location_longitude"]   = $request->lon;
        $update["good_for_emotion_of"]  = $request->emotion;
        $update["good_at_of"]           = $request->age;
        $update["address"]              = $request->address;
        $est_type                       = $request->est_type;
        
        $imageOne = $request->file('imageOne');
         if($imageOne != null)
         {
            $filename = $request->est_name . '-' . time() . '.' . "jpg";
            $location = public_path('images/');
            $imageOne->move($location, $filename);
            $update["est_front_store"] = $location . $filename;
        }
        if($request->pass == "submit_edit_est")
        {
            $check = DB::table("tbl_est_type")->where("est_type_name",$est_type);
            if($check->count() == 1)
            {
                $est_type_id = DB::table("tbl_est_type")->where("est_type_name",$est_type)->first();
                $update["est_type_id"] = (int)$est_type_id->id;
                $affected = DB::table("tbl_establishment")->where("id",$est_id)->update($update);
                $response["status"] = "success";
            }else{
                $response["status"] = "fail";
            }
            
        }else
        {
            $response["status"] = "fail";
        }
        return $response;
    }
    public function change_pass(Request $request)
    {
        $est_user_id = $request->user_id;
        $update["password"] = Hash::make($request->new_password);
        $checkPassword = DB::table("tbl_estabalishment_user")->where("id",$est_user_id)->first();
        if($request->pass == "change_est_pass"){
            if(Hash::check($request->password,$checkPassword->password)){
                DB::table("tbl_estabalishment_user")->where("id",$est_user_id)->update($update);
                $response["status"] = "success";
            }else{
                $response["status"] = "not match";
            }
        }else{
            $response["status"] = "fail";
        }
        return $response;
    }
    
    public function face_suggestion(Request $request)
    {
        $age = $request->age;
        $emotion = $request->emotion;
        if($request->pass == "face_suggestion"){
           $response["suggestion"] =  DB::table("tbl_estabalishment_user")->select("*","tbl_estabalishment_user.status as user_status","tbl_establishment.status as est_status","tbl_estabalishment_user.id as est_id","tbl_establishment.id as est_id")->
                join("tbl_establishment","tbl_establishment.establishment_user_id","=","tbl_estabalishment_user.id")->
                join("tbl_est_type","tbl_est_type.id","=","tbl_establishment.est_type_id")->orderBy("tbl_establishment.id")->where("good_for_emotion_of",$emotion)->where("good_at_of",$age)->get();
            
            $response["other"] =  DB::table("tbl_estabalishment_user")->select("*","tbl_estabalishment_user.status as user_status","tbl_establishment.status as est_status","tbl_estabalishment_user.id as est_id","tbl_establishment.id as est_id")->
                join("tbl_establishment","tbl_establishment.establishment_user_id","=","tbl_estabalishment_user.id")->
                join("tbl_est_type","tbl_est_type.id","=","tbl_establishment.est_type_id")->orderBy("tbl_establishment.id")->where("good_for_emotion_of","!=",$emotion)->orWhere("good_at_of","!=",$age)->get();
                $response["status"] = "success";
                
            foreach($response["suggestion"] as $key=>$value){
                // $response["rate"][$key] = $value->est_id;
                $response["rate_count"][$value->est_id] = DB::table("tbl_rating")->where("est_id",$value->est_id)->count();
                $response["rate"][$value->est_id] = DB::table("tbl_rating")->where("est_id",$value->est_id)->avg("rate");
                if($response["rate"][$value->est_id] == null){
                    $response["rate"][$value->est_id] = 0;
                }
            }
                foreach($response["other"] as $key=>$value){
                // $response["rate"][$key] = $value->est_id;
                $response["rate_count"][$value->est_id] = DB::table("tbl_rating")->where("est_id",$value->est_id)->count();
                $response["rate"][$value->est_id] = DB::table("tbl_rating")->where("est_id",$value->est_id)->avg("rate");
                if($response["rate"][$value->est_id] == null){
                    $response["rate"][$value->est_id] = 0;
                }
                }
        }else{
            $response["status"] = "fail";
            $response["suggestion"] = "";
            $response["other"] = "";
        }
        return $response;
    }
}