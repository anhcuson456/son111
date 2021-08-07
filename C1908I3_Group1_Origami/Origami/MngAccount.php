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
    <title>Account management</title>
</head>

<body>
    <?php require_once "BUS\AccountBUS.php"; ?>
    <div class="container">
        <h3 >Account management</h3>
        <div id="divaddAc">
            <form method="post" enctype="multipart/form-data">
                <div class="row">
                    <div class="col-md">
                        <div class="form-group">
                            <label for="txtacName">User Name</label>
                            <input id="txtacName" class="form-control" type="text" name="acName" required>
                        </div>
                    </div>
                    <div class="col-md">
                        <div class="form-group">
                            <label for="txtpass">Password</label>
                            <input id="txtpass" class="form-control" type="password" name="pass" required>
                        </div>
                    </div>
                    <div class="col-md">
                        <div class="form-group">
                            <label for="txtemail">Email</label>
                            <input id="txtemail" class="form-control" type="email" name="email">
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md">
                        <div class="form-group">
                            <label for="txtphone">Phone</label>
                            <input id="txtphone" class="form-control" type="text" name="phone">
                        </div>
                    </div>
                    <div class="col-md">
                        <div class="form-group">
                            <label for="txtaddr">Address</label>
                            <input id="txtaddr" class="form-control" type="text" name="addr">
                        </div>
                    </div>
                    <div class="col-md">
                        <div class="form-group">
                            <label for="txtfn">Fullname</label>
                            <input id="txtfn" class="form-control" type="text" name="fullName">
                        </div>
                    </div>
                </div>
                <div class="row">

                    <div class="col-md">
                        <div class="custom-control custom-checkbox">
                            <input id="chkad" class="custom-control-input" type="checkbox" name="ad"
                                value="true">
                            <label for="chkad" class="custom-control-label">Admin</label>
                        </div>
                    </div>
                    <div class="col-md">
                        <div class="custom-control custom-checkbox">
                            <input id="chkstt" class="custom-control-input" type="checkbox" name="stt"
                                value="true" checked>
                            <label for="chkstt" class="custom-control-label">Status</label>
                        </div>
                    </div>
                </div>
                <div class="row mt-2 mb-2">
                    <div class="col-md">
                        <button id="btnadd" class="btn btn-success" type="submit" name="add"><i class="fa fa-plus"
                                aria-hidden="true"></i> Add</button>
                        <button id="btnedit" class="btn btn-success" type="submit" name="edit"><i class="fa fa-check"
                                aria-hidden="true"></i> Edit</button>
                        <button class="btn btn-danger" type="reset" onclick="this.form.submit();"><i class="fa fa-times"
                                aria-hidden="true"></i>  Cancel </button>
                        <script>
                        $("#btnadd").show();
                        $("#btnedit").hide();
                        </script>
                    </div>
                </div>
            </form>
        </div>

        <!-- Xử lí xóa tài khoản -->
        <?php
        if (isset($_POST["del"])) {
            AccountBUS::DelAc($_POST["del"]);
        }
        ?>

<?php
        if (isset($_POST["del"])) {
            AccountBUS::DelAc($_POST["del"]);
        }
        ?>

        <?php
        if (isset($_POST["add"])) {
            $acName = $_POST["acName"];
            $pass = $_POST["pass"];
            $email = $_POST["email"];
            $phone = $_POST["phone"];
            $addr = $_POST["addr"];
            $fullName = $_POST["fullName"];
            $ad = isset($_POST["ad"]) ? 1 : 0;
            $stt = isset($_POST["stt"]) ? 1 : 0;
            if (!AccountBUS::AddAc($acName, $pass, $email, $phone, $addr, $fullName, $ad, $stt)) {
                echo "<script>alert('Add Account Failed ');</script>";
            }
        }
        ?>

        <?php
        if (isset($_POST["click"])) {
            $ac = AccountBUS::CheckAc($_POST["click"]);
        ?>
        <script>
        $("#txtacName").val('<?php echo $ac["acName"]; ?>');
        $("#txtemail").val('<?php echo $ac["email"]; ?>');
        $("#txtphone").val('<?php echo $ac["phone"]; ?>');
        $("#txtaddr").val('<?php echo $ac["addr"]; ?>');
        $("#txtfullName").val('<?php echo $ac["fullName"]; ?>');
        $("#chkad").prop("checked", '<?php echo ($ac["ad"] == 1) ? true : false; ?>');
        $("#chkstt").prop("checked", '<?php echo ($ac["stt"] == 1) ? true : false; ?>');
        $("#txtacName").prop("readonly", "true");
        $("#btnadd").hide();
        $("#btnedit").show();
        </script>
        <?php
        }

        if (isset($_POST["edit"])) {
            $acName = $_POST["acName"];
            $pass = $_POST["pass"] == "" ? AccountBUS::CheckAc($acName)["pass"] : $_POST["pass"];
            $email = $_POST["email"];
            $phone = $_POST["phone"];
            $addr = $_POST["addr"];
            $fullName = $_POST["fullName"];
            $ad = isset($_POST["ad"]) ? 1 : 0;
            $stt = isset($_POST["stt"]) ? 1 : 0;   
            if (!AccountBUS::EditAc($acName, $pass, $email, $phone, $addr, $fullName, $ad, $stt)) {
                echo "<script>alert('Edit account failed');</script>";
            }
        }
        ?>
        <?php
        $result = AccountBUS::GetAcList();
        if ($result->num_rows > 0) {
            $i = 1;
        ?>

        <form method="post">
            <table class="table table-light table-hover text-center">
                <thead class="thead-dark">
                    <tr>
                        <th>Num</th>
                        <th>Account</th>
                        <th>Email</th>
                        <th>Phone</th>
                        <th>Address</th>
                        <th>Fullname</th>
                        <th>Admin</th>
                        <th>Status</th>
                        <th colspan="2">Action</th>
                    </tr>
                </thead>
                <tbody>
                    <?php
                        while ($row = $result->fetch_assoc()) {
                        ?>
                    <tr>
                        <td><?php echo $i++; ?></td>
                        <td><?php echo $row["acName"]; ?></td>
                        <td><?php echo $row["email"]; ?></td>
                        <td><?php echo $row["phone"]; ?></td>
                        <td><?php echo $row["addr"]; ?></td>
                        <td><?php echo $row["fullName"]; ?></td>
                        <td>
                            <div class="custom-control custom-checkbox">
                                <input class="custom-control-input" type="checkbox" readonly
                                    <?php if ($row["ad"] == 1) echo "checked"; ?>>
                                <label class="custom-control-label"></label>
                            </div>
                        </td>
                        <td>
                            <div class="custom-control custom-checkbox">
                                <input class="custom-control-input" type="checkbox" readonly
                                    <?php if ($row["stt"] == 1) echo "checked"; ?>>
                                <label class="custom-control-label"></label>
                            </div>
                        </td>
                        <td>
                            <button class="btn btn-primary" type="submit" name="click"
                                value="<?php echo $row["acName"]; ?>"><i class="fas fa-edit"
                                    aria-hidden="true"></i></button>
                        </td>
                        <td>
                            <button class="btn btn-danger" type="submit" name="del"
                                value="<?php echo $row["acName"]; ?>"
                                onclick="return confirm('Are you sure you want to delete?');"><i class="fas fa-trash-alt"
                                    aria-hidden="true"></i></button>
                        </td>
                    </tr>
                    <?php
                        }
                        ?>
                </tbody>
            </table>
        </form>
        <?php
        } else {
            echo "Account does not exit";
        }
        ?>
    </div>
</body>

</html>