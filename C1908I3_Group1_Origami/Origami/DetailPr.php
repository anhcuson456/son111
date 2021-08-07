<?php session_start(); ?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.4.1/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.11.2/css/all.min.css">
    <link href="css/detail.css" rel="stylesheet">
    
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.4.1/js/bootstrap.min.js"></script>
    
    <title>Detail Origami</title>
</head>

<body>
    <?php
    require_once "BUS\MyOrigamiBUS.php";
    require_once "BUS\ProductBUS.php";
    require_once "BUS\photoBUS.php";
    ?>

    <div class="container">
        <h3 id="lblTieuDe">Detail Origami</h3>
        <?php
        if (isset($_SESSION["acName"])) {
            $acName = $_SESSION["acName"];
        } else {
            echo "<script>alert('Please log in to continue.')</script>";
        }
        ?>
         <!-- Xử lí thêm sản phẩm vào giỏ hàng -->
         <?php 
        if (isset($_POST["addOr"])) {
                MyOrigamiBUS::AddMO($_SESSION["acName"], $_GET["prID"], 1);
            }
        ?> 

        <!-- Xử lí đăng xuất -->
        <?php
        if (isset($_POST["logOut"])) {
            session_destroy();
            header("Refresh: 0");
        }
        ?>

        <!-- Hiển thị lời chào -->
        <form method="post">
            <?php
            if (isset($_SESSION["fullName"])) {
            ?>
            <p>
                Hello <span class="font-weight-bold">. </span>
                <a href="MyOrigami.php" class="btn btn-primary btn-sm"><i class="fas fa-heart" aria-hidden="true"></i> <span  class="badge badge-light"></a>
                <button class="btn btn-danger btn-sm" type="submit" name="logOut"><i class="fas fa-sign-out-alt" aria-hidden="true"></i>Log out</button>
            </p>

            <?php
                if (isset($_GET["prID"])) {
                    $row = ProductBUS::CheckPr($_GET["prID"]);
            ?>
                <h2 class="font-weight-bold"><?php echo $row["prName"]; ?></h2>
                <div class="row">
                    <div class="col-md-4">
                        <img class="img-thumbnail" src="img/Product/<?php echo $row["typePrName"]; ?>/<?php echo $row["prName"]; ?>/<?php echo $row["photo"]; ?>" alt="">
                    </div>
                    <div class="col-md-8">
                        <p>Description: <?php echo $row["descrip"]; ?></p>
                        <p>Type Origami: <?php echo $row["typePrName"]; ?></p>
                        <div class="slideshow-container">
                            <?php
                            $listPt = photoBUS::CheckPhoto($_GET["prID"]);
                            if ($listPt->num_rows > 0) {
                                $i = 1;
                                while ($pt= $listPt->fetch_assoc()) {
                            ?>
                                <div class="mySlides">
                                    <div class="numbertext">Part <?php echo $i++; ?></div>
                                    <img src="img/Product/<?php echo $pt["typePrName"]; ?>/<?php echo $pt["prName"]; ?>/<?php echo $pt["photo"]; ?>" style="width:500px; height:500px;"  alt=""/>
                                </div>
                            <?php 
                                }
                            }
                            ?>
                            <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
                            <a class="next" onclick="plusSlides(1)">&#10095;</a>
                        </div>
                        <form method="post">
                            <div class="row">
                            <button style="margin-right:20px;" class="btn btn-secondary" type="submit" name="addOr"><i  class="fa fa-arrow-left" aria-hidden="true"></i><a href="Home.php">  Back</button>
                            <button class="btn btn-success" type="submit" name="addOr"><i  class="bi bi-heart-fill" aria-hidden="true"></i> Add to my Origami</button>                        </form>
                    </div>
                    </div>
                </div>
            <?php
                } else {
                    header("Location: Home.php");
                }
            } else {
            ?>
            <p>
               Hello <span class="font-weight-bold">. </span>
                <a href="Registration.php">Registration</a> | <a href="LogIn.php">Log in</a>
            </p>
            <?php
            }
            ?>
        </form>
    </div>
    <script src="js/detail.js"></script>
</body>

</html>