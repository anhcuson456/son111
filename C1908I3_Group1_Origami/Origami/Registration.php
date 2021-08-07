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
    <title>Registration an account</title>
</head>

<body>
    <?php require_once "BUS\AccountBUS.php"; ?>

    <?php
    if (isset($_POST["acName"])) {
        // Get User Submission Information  
        $acName = $_POST["acName"];
        $pass = $_POST["pass"];
        $email = $_POST["email"];
        $phone = $_POST["phone"];
        $addr = $_POST["addr"];
        $fullName = $_POST["fullName"];
        if ($pass === $_POST["pass2"]) {
            // Account Registration
            if (AccountBUS::AddAc($acName, $pass, $email, $phone, $addr, $fullName,$adv,$stt)){
                $_SESSION["acName"] = $acName;
                $_SESSION["fullName"] = $fullName;
                header("Location:Home.php");
            } else {
                echo "<script>alert('Registration fail');</script>";
            }
        }
    } else {
    ?>
    <div class="container">
        <h3 id="lblRegistrtion">Registration an account</h3>
        <form method="post">
            <fieldset id="fldAc">
                <legend>Account information</legend>
                <div class="form-group">
                    <label for="txtAcName">Username</label>
                    <input id="txtAcName" class="form-control" type="text" name="acName" placeholder="Username*"
                        autofocus required>
                </div>
                <div class="form-group">
                    <label for="txtPass">Password</label>
                    <input id="txtPass" class="form-control" type="password" name="pass" placeholder="Password*"
                        required>
                </div>
                <div class="form-group">
                    <label for="txtPass2">Confirm Password</label>
                    <input id="txtPass2" class="form-control" type="password" name="pass2"
                        placeholder="Confirm Password*" required>
                </div>
                <div class="form-group">
                    <label for="txtEmail">Email</label>
                    <input id="txtEmail" class="form-control" type="email" name="email" placeholder="Enter your email*"
                        required>
                </div>
            </fieldset>
            <fieldset id="fldPs">
                <legend>Personal information</legend>
                <div class="form-group">
                    <label for="txtFullName">Fullname</label>
                    <input id="txtFullName" class="form-control" type="text" name="fullName"
                        placeholder="Enter your fullname*">
                </div>
                <div class="form-group">
                    <label for="txtPhone">Number phone</label>
                    <input id="txtPhone" class="form-control" type="text" name="phone" placeholder="Enter your phone*">
                </div>
                <div class="form-group">
                    <label for="txtAddr">Address</label>
                    <input id="txtAddr" class="form-control" type="text" name="addr" placeholder="Enter your address*">
                </div>
                <div class="form-group float-right">
                    <button class="btn btn-success" type="submit"><i class="fa fa-check"
                            aria-hidden="true"></i>Registration</button>
                    <button class="btn btn-danger" type="reset"><i class="fa fa-times"
                            aria-hidden="true"></i><a href="Home.php">Cancel</button>
                </div>
            </fieldset>
        </form>
        <?php } ?>
    </div>
</body>

</html>