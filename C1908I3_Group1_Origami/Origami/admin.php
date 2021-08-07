<?php session_start();
  require_once 'BUS/AccountBUS.php'; 
  require_once 'BUS/ProductBUS.php';
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <?php include 'form/head.php'; ?>
</head>
<body>
<header id="header">
<?php
        if (isset($_POST["logOut"])) {
            session_destroy();
            header("Refresh: 0");
        }
?>
    <div class="container">

        <div id="logo" class="pull-left">
            <a href="#hero"><img src="img/logo.png" alt="" title="" /></img></a>
            <!-- Uncomment below if you prefer to use a text logo -->
            <!--<h1><a href="#hero">Regna</a></h1>-->
        </div>

        <nav id="nav-menu-container">
            <ul class="nav-menu">
                <li class="menu-active"><a href="#hero">Admin</a></li>
                <li><a href="MngProduct.php">Management Origami</a></li>
                <li><a href="MngAccount.php">Management Account</a></li>
                </li>
                <li class="menu-has-children"><a href="">User</a>
            
                <?php
                    if (isset($_SESSION["acName"])) {
                ?>
                <ul>
                <form method="post">
                    <li><button class="btn btn-sm" type="submit" name="logOut"><a><i class="fas fa-sign-out-alt" aria-hidden="true" type="submit" name="logOut">Log out </i></a></li>
                </form>
                </ul>  
                <?php
                } else {
                ?>
                    <ul>
                        <li><a href="Login.php">Sign In</a></li>
                        <li><a href="Registration.php">Registration</a></li>
                    </ul>
                <?php
                }
                ?>
            </ul>
        </nav><!-- #nav-menu-container -->
    </div>
</header><!-- #header -->
        <?php include 'form/sectionhero.php'; ?>
</body>

</html>