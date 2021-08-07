<?php require_once "connect.php";

class photoDAO {
    public static function CheckPtExist($prID)
    {
        $sql = "SELECT COUNT(*) AS amount FROM Product WHERE prID = ?";
        $dataType = "s";
        $params = array($prID);
        return ExecuteSelectQuery($sql, $dataType, $params)->fetch_assoc()["amount"] > 0;
    }


    public static function CheckPhoto($prID)
    {
        $sql = "SELECT Tpr.typePrName, Pt.photo, Pr.prName FROM Product Pr,TypeProduct Tpr,Photo Pt WHERE Pr.prID = Pt.prID and Tpr.typePrID = Pr.typePrID AND Pr.prID=?";
        $dataType = "s";
        $params = array($prID);
        return ExecuteSelectQuery($sql, $dataType, $params);
    }
}
