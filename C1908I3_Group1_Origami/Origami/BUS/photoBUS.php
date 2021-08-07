<?php require_once "DAO\photoDAO.php";

class photoBUS {

    public static function CheckPhoto($prID) 
    {
        // if (photoDAO::CheckPtExist($prID)) {
            return photoDAO::CheckPhoto($prID);
        // }
        // return false;
    }
    
}