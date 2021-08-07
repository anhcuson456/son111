<?php
require_once "connect.php";

class   MyOrigamiDAO
{
    public static function MOtextexist($acName, $prID) // kiểm tra sản phẩm có tồn tại hay không
    {
        $sql = "SELECT COUNT(*) AS amount FROM myproduct WHERE acName = ? AND prID = ?";
        $dataType = "ss";
        $params = array($acName, $prID);
        return ExecuteSelectQuery($sql, $dataType, $params)->fetch_assoc()["amount"] > 0;
    }

    public static function GetMyOrigamilist($acName) // lấy danh sách sản phẩm
    {
        $sql = "SELECT Mo.prID,Pr.photo,Pr.prName, Ac.acName, Tpr.typePrName FROM myproduct Mo , product Pr,account Ac,typeproduct Tpr WHERE Pr.typePrID=Tpr.typePrID AND Mo.prID = Pr.prID AND Ac.acName = Mo.acName AND Mo.acName = ?";
        $dataType = "s";
        $params = array($acName);
        return ExecuteSelectQuery($sql, $dataType, $params);
    }

    public static function AddMO($acName, $prID, $amount)
    {
        $sql = "INSERT INTO myproduct (acName, prID, amount) VALUES (?, ?, ?)";
        $dataType = "ssi";
        $params = array($acName, $prID, $amount);
        return ExecuteNonQuery($sql, $dataType, $params) > 0;
    }

    public static function FixMO($acName, $prID, $amount)
    {
        $sql = "UPDATE myproduct SET amount = ? WHERE acName = ? AND prID = ?";
        $dataType = "iss";
        $params = array($amount, $acName, $prID);
        return ExecuteNonQuery($sql, $dataType, $params) > 0;
    }

    public static function FixMO_Increasetheamount  ($acName, $prID, $amount)// sửa sản phẩm_ tăng số luọng
    {
        $sql = "UPDATE myproduct SET amount = amount + ? WHERE acName = ? AND prID = ?";
        $dataType = "iss";
        $params = array($amount, $acName, $prID);
        return ExecuteNonQuery($sql, $dataType, $params) > 0;
    }

    public static function DeleteMO($acName)
    {
        $sql = "DELETE FROM myproduct WHERE acName = ?";
        $dataType = "s";
        $params = array($acName);
        return ExecuteNonQuery($sql, $dataType, $params) > 0;
    }

    public static function DeletetheproductInMO($acName, $prID) // xóa sản phẩm trong  trang sản phẩm của tôi
    {
        $sql = "DELETE FROM myproduct WHERE acName = ? AND prID = ?";
        $dataType = "ss";
        $params = array($acName, $prID);
        return ExecuteNonQuery($sql, $dataType, $params) > 0;
    }
}