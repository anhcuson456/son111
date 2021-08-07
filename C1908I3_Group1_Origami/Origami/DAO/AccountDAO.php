<?php
require_once "connect.php";

class AccountDAO
{
    public static function CheckAcExist($acName)
    {
        $sql = "SELECT COUNT(*) AS amount FROM Account WHERE acName = ?";
        $dataType = "s";
        $params = array($acName);
        return ExecuteSelectQuery($sql, $dataType, $params)->fetch_assoc()["amount"] > 0;
    }

    public static function AddAc($acName, $pass, $email, $phone, $addr, $fullName, $ad, $stt)
    {
        $sql = "INSERT INTO Account (acName, pass, email, phone, addr, fullName, ad, stt) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
        $dataType = "ssssssii";
        $params = array($acName, $pass, $email, $phone, $addr, $fullName, $ad, $stt);
        return ExecuteNonQuery($sql, $dataType, $params) > 0;
    }
    
    public static function GetAcList()
    {
        $sql = "SELECT * FROM Account";
        return ExecuteSelectQuery($sql);
    }
    public static function CheckAc($acName)
    {
        $sql = "SELECT * FROM Account WHERE acName = ?";
        $dataType = "s";
        $params = array($acName);
        return ExecuteSelectQuery($sql, $dataType, $params)->fetch_assoc();
    }

    public static function CheckPass($acName)
    {
        $sql = "SELECT pass FROM Account WHERE acName = ?";
        $dataType = "s";
        $params = array($acName);
        return ExecuteSelectQuery($sql, $dataType, $params)->fetch_assoc()["pass"];
    }
    public static function EditAc($acName, $pass, $email, $phone, $addr, $fullName, $ad, $stt)
    {
        $sql = "UPDATE Account SET pass = ?, email = ?, phone = ?, addr = ?, fullName = ?, ad=?, stt =? WHERE acName = ?";
        $dataType = "sssssiis";
        $params = array($pass, $email, $phone, $addr, $fullName, $ad, $stt,$acName);
        return ExecuteNonQuery($sql, $dataType, $params) > 0;
    }

    public static function DelAc($acName)
    {
        $sql = "UPDATE Account SET stt = 0 WHERE acName = ?";
        $dataType = "s";
        $params = array($acName);
        return ExecuteNonQuery($sql, $dataType, $params) > 0;
    }

    public static function CheckAdmin($acName)
    {
        $sql = "SELECT * FROM Account WHERE ad = 1 ";
        $dataType = "s";
        $params = array($acName);
        return ExecuteSelectQuery($sql, $dataType, $params)-> fetch_assoc();
    }
}