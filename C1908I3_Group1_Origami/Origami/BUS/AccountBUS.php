<?php
require_once "DAO\AccountDAO.php";

class AccountBUS
{
    public static function AddAc($acName, $pass, $email, $phone, $addr, $fullName, $ad, $stt)
    {
        if (!AccountDAO::CheckAcExist($acName)) {
            return AccountDAO::AddAc($acName, $pass, $email, $phone, $addr, $fullName, $ad, $stt);
        }
        return false;
    }

    public static function CheckAc($acName)
    {
        if (AccountDAO::CheckAcExist($acName)) {
            return AccountDAO::CheckAc($acName);
        }
        return false;
    }

    public static function LogIn($acName, $pass)
    {
        if (AccountDAO::CheckAcExist($acName)) {
            return $pass == AccountDAO::CheckPass($acName);
        }
        return false;
    }
    public static function GetAcList()
    {
        return AccountDAO::GetAcList();
    }

    public static function EditAc($acName, $pass, $email, $phone, $addr, $fullName, $ad, $stt)
    {
        if (AccountDAO::CheckAcExist($acName)) {
            return AccountDAO::EditAc($acName, $pass, $email, $phone, $addr, $fullName, $ad, $stt);
        }
        return false;
    }

    public static function DelAc($acName)
    {
        if (AccountDAO::CheckAcExist($acName)) {
            return AccountDAO::DelAc($acName);
        }
        return false;
    }

    public static function CheckAdmin($acName)
    {
        if (AccountDAO::CheckAcExist($acName)) {
            return AccountDAO::CheckAdmin($acName);
        }
        return false;
    }
    
}
