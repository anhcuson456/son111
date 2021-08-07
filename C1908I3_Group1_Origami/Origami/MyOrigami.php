<?php session_start(); ?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.4.1/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.11.2/css/all.min.css">
    <link rel="stylesheet" href="style.css">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <title>My Origami</title>
</head>

<body>
    <?php
    require_once "BUS\MyOrigamiBUS.php";
    require_once "BUS\AccountBUS.php";
    ?>
    <div class="container">
        <h3 id="lblTieuDe">My Origami</h3>
        <!-- Lấy tên tài khoản đang đăng nhập -->
        <?php
        if (isset($_SESSION["acName"])) {
            $acName = $_SESSION["acName"];
        } else {
            header("Location: LogIn.php");
        }
        ?>

        <!-- Xử lí xóa 1 sản phẩm trong giỏ hàng -->
        <?php
        if (isset($_POST["Delete"])) {
            MyOrigamiBUS::DeletetheproductInMO($acName, $_POST["Delete"]);
        }
        ?>

        <!-- Xử lí xóa toàn bộ giỏ hàng -->
        <?php
        if (isset($_POST["DeleteMO"])) {
            MyOrigamiBUS::DeleteMO($acName);
        }
        ?>

        <!-- Xử lí sửa số lượng trong giỏ hàng -->
        <?php
        if (isset($_POST["prID"]) && isset($_POST["amount"])) {
            MyOrigamiBUS::FixMO($acName, $_POST["prID"], $_POST["amount"]);
        }
        ?>
        <!-- Xử lí hiển thị giỏ hàng -->
        <?php
        if (isset($_SESSION["acName"])) {
            $acName = $_SESSION["acName"];
            $result = MyOrigamiBUS::GetMyOrigamilist($acName);
            if ($result->num_rows > 0) {
                $i = 1;
        ?>
            <form method="post">
                <table class="table table-light table-hover text-center">
                    <thead class="thead-dark">
                        <tr>
                            <th>Num</th>
                            <th>Picture</th>
                            <th>Name Origami</th>
                            <th colspan="2">Function</th>
                        </tr>
                    </thead>
                    <tbody>
                    <?php
                            while ($row = $result->fetch_assoc()) {
                            ?>
                        <tr>
                        <td><?php echo $i++; ?></td>
                                    <td><img class="img-thumbnail" style="width: 75px;" src="img/Product/<?php echo $row["typePrName"]; ?>/<?php echo $row["prName"]; ?>/<?php echo $row["photo"]; ?>" alt=""></td>
                                    <td><?php echo $row["prName"]; ?></td>
                            <td>
                                <button class="btn btn-primary" type="submit" name="like"
                                    value="<?php echo $row["prID"]; ?>"><i class="far fa-heart"
                                        aria-hidden="true"></i></button>
                            </td>
                            <td>
                                <button class="btn btn-danger" type="submit" name="Delete" value="<?php echo $row["prID"]; ?>"
                                    onclick="return confirm('Are you sure you want to delete?');"><i class="fas fa-trash-alt"
                                        aria-hidden="true"></i></button>
                            </td>
                        </tr>
                        <?php
                            }
                            ?>
                    </tbody>
                    <tfoot class="thead-dark">
                        <tr>
                            <th colspan="2"><button class="btn btn-danger bth-block" type="submit" name="DeleteMO"
                                    onclick="return confirm('Are you sure delete cart?');"><i
                                        class="fas fa-trash-alt" aria-hidden="true"></i> Delete All</button>
                            </th>
                        </tr>
                    </tfoot>
                </table>
            </form>
            <form method="post">
                <?php
                    $acName = AccountBUS::CheckAc($_SESSION["acName"]);
                    ?>
                <div class="text-right">
                    <button class="btn btn-danger" type="reset"><i class="fa fa-times" aria-hidden="true"></i><a href="Home.php">Cancel</a></button>
                </div>
            </form>
        <?php
            } else {
                echo "<script>alert('No favorite origami')</script>";
            }
        }  else {
            echo "<script>alert('Sign in to continue')</script>";
        }
        ?>
    </div>
</body>

</html>