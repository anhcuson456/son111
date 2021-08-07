<?php
require_once "connect.php";

class ProductDAO
{
    public static function CheckPrExist($prID)
    {
        $sql = "SELECT COUNT(*) AS amount FROM Product WHERE prID = ?";
        $dataType = "s";
        $params = array($prID);
        return ExecuteSelectQuery($sql, $dataType, $params)->fetch_assoc()["amount"] > 0;
    }

    public static function Addpr($prID, $prName, $typePrID, $photo, $descrip, $stt)
    {
        $sql = "INSERT INTO Product (prID, prName, typePrID, photo, descrip, stt) VALUES (?, ?, ?, ?, ?, ?)";
        $dataType = "sssssi";
        $params = array($prID, $prName, $typePrID, $photo, $descrip, $stt);
        return ExecuteNonQuery($sql, $dataType, $params) > 0;
    }
    public static function ListPr()
    {  
        $sql = "SELECT Pr.*, typePrName FROM product Pr INNER JOIN typeProduct Tpr ON Pr.typePrID = Tpr.typePrID ORDER BY prID ASC";
        return ExecuteSelectQuery($sql);
    }

    public static function Repair($prID, $prName, $typePrID, $descrip, $photo, $stt)
    {
        $sql = "UPDATE Product SET prName = ?, typePrID = ?,descrip = ?, photo = ?, stt = ? WHERE prID = ?";
        $dataType = "ssssis";
        $params = array($prName, $typePrID, $descrip, $photo, $stt, $prID);
        return ExecuteNonQuery($sql, $dataType, $params) >= 0;
    }

    public static function CheckPr($prID)
    {
        $sql = "SELECT Pr.*, typePrName FROM Product Pr INNER JOIN TypeProduct Tpr ON Pr.typePrID = Tpr.typePrID WHERE prID = ?";
        $dataType = "s";
        $params = array($prID);
        return ExecuteSelectQuery($sql, $dataType, $params)->fetch_assoc();
    }

    public static function DeletePr($prID)
    {
        $sql = "UPDATE product SET stt = 0 WHERE prID = ?";
        $dataType = "s";
        $params = array($prID);
        return ExecuteNonQuery($sql, $dataType, $params) > 0;
    }
}