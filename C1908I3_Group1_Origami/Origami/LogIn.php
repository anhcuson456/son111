<?php session_start(); ?>

<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.4.1/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.11.2/css/all.min.css">
    <link rel="stylesheet" href="css/style.css">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <script src="js/script.js"></script>
    <title>Log in</title>
</head>

<body>
    <?php require_once "BUS\AccountBUS.php"; ?>

    <?php
    if (isset($_POST["acName"])) {
        // Get User Submission Information
        $acName = $_POST["acName"];
        $pass = $_POST["pass"];

        // Check Login
        if (AccountBUS::LogIn($acName, $pass)) {
            $_SESSION["acName"] = $acName;
            $_SESSION["fullName"] = AccountBUS::CheckAc($acName)["fullName"];
            if( $acName == AccountBUS::CheckAdmin($acName)["acName"]) {
                header("Location: admin.php");
            } else {
                header("Location: Home.php");
            }

        } else {
            echo "login failed";
        }
    } else {
    ?>
    <div class="container">
        <h3 id="lblLogIn"> Log in</h3>
        <form method="post">
            <div class="form-group">
                <label for="uname">Username:</label>
                <input type="text" class="form-control" placeholder="Username*" name="acName" required>
                <div class="valid-feedback">Valid.</div>
                <div class="invalid-feedback">Please fill out this field.</div>
            </div>
            <div class="form-group">
                <label for="pwd">Password:</label>
                <input type="password" class="form-control" placeholder="Password*" name="pass" required>
                <div class="valid-feedback">Valid.</div>
                <div class="invalid-feedback">Please fill out this field.</div>
            </div>
            <p>Don't have an account ? <a href="Registration.php" class="text-primary font-italic">Registration</a> </p>
            <button type="submit" class="btn btn-primary">Submit</button>
            <button class="btn btn-danger" type="reset">Cancel </button>
        </form>
        <?php } ?>
    </div>
</body>

</html>