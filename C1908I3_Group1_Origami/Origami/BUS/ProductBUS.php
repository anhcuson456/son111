<?php
require_once "DAO\ProductDAO.php";

class ProductBUS
{
    public static function ListPr()
    {
        return ProductDAO::ListPr();
    }

    public static function AddPr($prID, $prName, $typePrID, $photo, $descrip, $stt)
    {
        if (!ProductDAO::CheckPrExist($prID)) {
            return ProductDAO::AddPr($prID, $prName, $typePrID, $photo, $descrip, $stt);
        }
        return false;
    }

    public static function Repair($prID, $prName, $typePrID, $photo, $descrip, $stt)
    {
        if (ProductDAO::CheckPrExist($prID)) {
            return ProductDAO::Repair($prID, $prName,$typePrID, $photo, $descrip, $stt);
        }
        return false;
    }

    public static function CheckPr($prID)
    {
        if (ProductDAO::CheckPrExist($prID)) {
            return ProductDAO::CheckPr($prID);
        }
        return false;
    }

    public static function DeletePr($prID)
    {
        if (ProductDAO::CheckPrExist($prID)) {
            return ProductDAO::DeletePr($prID);
        }
        return false;
    }
}