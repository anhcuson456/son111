<?php
require_once "DAO\TypeProductDAO.php";

class TypeProductBUS
{
    public static function ListType()
    {
        return TypeProductDAO::ListType();
    }
}