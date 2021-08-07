<?php
require_once "DAO/MyOrigamiDAO.php";
require_once "DAO/connect.php";
require_once "DAO/AccountDAO.php";
require_once "DAO/ProductDAO.php";

class MyOrigamiBUS
{
    public static function MOtextexist($acName)// kiểm tra sản phẩm có tồn tại hay không
    {
        if (AccountDAO::CheckAcExist($acName)) {
            $gh = MyOrigamiDAO::GetMyOrigamilist($acName);
            while ($row = $gh->fetch_assoc()) {
                if ($row["amount"] > 0){
                }
            }   
            return true;
        }
        return false;
    }

    public static function GetMyOrigamilist($acName)// lấy danh sách sản phẩm theo tài khoản 
    {
        if (AccountDAO::CheckAcExist($acName)) {
            return MyOrigamiDAO::GetMyOrigamilist($acName);
        }
        return false;
    }

    public static function AddMO($acName, $prID, $amount)
    {
        if (AccountDAO::CheckAcExist($acName)) {
            if (MyOrigamiDAO::MOtextexist($acName, $prID)) {
                MyOrigamiDAO::FixMO_Increasetheamount($acName, $prID, $amount);
            } else {
                MyOrigamiDAO::AddMO($acName, $prID, $amount);
            }
        }
        return false;
    }

    public static function FixMO($acName, $prID, $amount)
    {
        if (AccountDAO::CheckAcExist($acName)) {
            return MyOrigamiDAO::FixMO($acName, $prID, $amount);
        }
        return false;
    }

    public static function DeleteMO($acName)
    {
        if (AccountDAO::CheckAcExist($acName)) {
            return MyOrigamiDAO::DeleteMO($acName);
        }
        return false;
    }

    public static function DeletetheproductInMO($acName, $prID) //xóa sản phẩm trong  trang sản phẩm của tôi
    {
        if (AccountDAO::CheckAcExist($acName)) {
            return MyOrigamiDAO::DeletetheproductInMO($acName, $prID);
        }
        return false;
    }
}