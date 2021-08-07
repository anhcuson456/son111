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

    <!--==========================
    Header
  ============================-->
    <?php include 'form/header.php'; ?>
    <!--==========================
    Hero Section
  ============================-->
    <?php include 'form/sectionhero.php'; ?>
    <main id="main">
        <!--==========================
      About Us Section
    ============================-->
        <?php include 'form/sectionabout.php'; ?>
        <!--==========================
    Call To Action Section
    ============================-->
        <?php include 'form/sectioncall.php'; ?>
        <!--==========================
      portfolio Section
    ============================-->
        <?php include 'form/sectionportfolio.php'; ?>
        <!--==========================
      Contact Section
    ============================-->
        <?php include 'form/contact.php'; ?>
        <!--==========================
        Feedback Section
    ============================-->
        <?php include 'form/feedback.php'; ?>
    </main>
    <!--==========================
    Footer
  ============================-->
    <?php include 'form/footer.php'; ?>


</body>

</html>