<?php
$conn;

function OpenConnection()
{
    $serverName = "localhost";
    $username = "root";
    $password = "";
    $dbName = "project";
    global $conn;
    $conn = new mysqli($serverName, $username, $password, $dbName);
    $conn->set_charset("utf8mb4");
    if ($conn->connect_error) {
        error_log("Connect to $serverName/$dbName by account $username fail . error: " . $conn->connect_error);
        exit();
    }
    return $conn;
}

function ExecuteSelectQuery($sql, $dataType = null, $params = null)
{
    global $conn;
    $conn = OpenConnection();
    $stmt = $conn->prepare($sql);
    if ($dataType && $params) {
        $stmt->bind_param($dataType, ...$params);
    }
    if ($stmt->execute()) {
        $result = $stmt->get_result();
    } else {
        error_log(" The query failed . Error: " . $stmt->error);
        $result = false;
    }
    $conn->close();
    return $result;
}

function ExecuteNonQuery($sql, $dataType = null, $params = null)
{
    global $conn;
    $conn = OpenConnection();
    $stmt = $conn->prepare($sql);
    if ($dataType && $params) {
        $stmt->bind_param($dataType, ...$params);
    }
    if ($stmt->execute()) {
        $result = $stmt->affected_rows;
    } else {
        error_log(" The query failed. Error: " . $stmt->error);
        $result = false;
    }
    $conn->close();
    return $result;
}