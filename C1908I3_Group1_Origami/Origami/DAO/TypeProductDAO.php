<?php
require_once "connect.php";

class TypeProductDAO
{
    public static function ListType()
    {
        $sql = "SELECT * FROM TypeProduct ";
        return ExecuteSelectQuery($sql);
    }
}