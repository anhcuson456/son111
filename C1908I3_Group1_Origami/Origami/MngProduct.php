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
    <title>Product management</title>
</head>

<body>
    <?php
    require_once "BUS\ProductBUS.php";
    require_once "BUS\TypeProductBUS.php";
    ?>
    <div class="container">
        <h3 id="lbl">Product management</h3>
        <!-- Form thêm/sửa sản phẩm -->
        <form method="post" enctype="multipart/form-data">
            <div class="row">
                <div class="col-md">
                    <div class="form-group">
                        <label for="txtprID">Product ID </label>
                        <input id="txtprID" class="form-control" type="text" name="prID" required>
                    </div>
                </div>
                <div class="col-md">
                    <div class="form-group">
                        <label for="txtprName">Origami name </label>
                        <input id="txtprName" class="form-control" type="text" name="prName">
                    </div>
                </div>
                <div class="col-md">
                    <div class="form-group">
                        <label for="cbotypePr">Type Origami</label>
                        <select id="cbotypePr" class="custom-select" name="typePrID">
                            <?php
                            $listType = TypeProductBUS::ListType();
                            if ($listType->num_rows > 0) {
                                while ($row = $listType->fetch_assoc()) {
                            ?>
                            <option value="<?php echo $row["typePrID"]; ?>"><?php echo $row["typePrName"]; ?></option>
                            <?php
                                }
                            }
                            ?>
                        </select>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md">
                    <div class="form-group">
                        <label for="txtdes">Description </label>
                        <input id="txtdes" class="form-control" type="text" name="descrip">
                    </div>
                </div>
                <div class="col-md">
                    <div class="custom-file" style="margin-top: 30px;">
                        <label for="filphoto" class="custom-file-label">Photo</label>
                        <input id="filphoto" class="custom-file-input" type="file" name="photo">
                    </div>
                </div>
                <div class="col-md">
                    <div class="custom-control custom-checkbox"  style="margin-top: 30px;">
                        <input id="chkstatus" class="custom-control-input" type="checkbox" name="stt"
                            value="true" checked>
                        <label for="chkstatus" class="custom-control-label">Action</label>
                    </div>
                </div>
            </div>
            <div class="row mt-2 mb-2">
                <div class="col-md">
                    <button id="btnAdd" class="btn btn-success" type="submit" name="add"><i class="fa fa-plus" aria-hidden="true"></i> Add </button>
                    <button id="btnRepair" class="btn btn-success" type="submit" name="repair"><i class="fa fa-check" aria-hidden="true"></i> Repair</button>
                    <button class="btn btn-danger" type="reset" onclick="this.form.submit();"><i class="fa fa-times" aria-hidden="true"></i> Cancel</button>
                    <script>
                    $("#btnAdd").show();
                    $("#btnRepair").hide();
                    </script>
                </div>
            </div>
        </form>

        <!-- Xử lí xóa sản phẩm -->
        <?php
        if (isset($_POST["delete"])) {
            ProductBUS::DeletePr($_POST["delete"]);
        }
        ?>

        <!-- Xử lí thêm sản phẩm -->
        <?php
        if (isset($_POST["add"])) {
            $prID = $_POST["prID"];
            $prName = $_POST["prName"];
            $typePrID = $_POST["typePrID"];
            $descrip = $_POST["descrip"];
            $stt = isset($_POST["stt"]) ? 1 : 0;

            // Xử lí upload ảnh minh họa
            $error = "";
            if ($_FILES["photo"]["name"] != "") {
                $photo = $prID . ".jpg";
                $path = "img/Product/" . $photo;

                // Kiểm tra file có phải là file ảnh hay không
                $check = getimagesize($_FILES["photo"]["tmp_name"]);
                if ($check == false) {
                    $error .= " The selected file is not an image file. ";
                }

                // Kiểm tra dung lượng (tính bằng byte)
                if ($_FILES["photo"]["size"] > 1024 * 1024) {
                    $error .= " File exceeds the allowed size of 1 MB. ";
                }

                // Kiểm tra phần mở rộng của file
                $extension = strtolower(pathinfo($path, PATHINFO_EXTENSION));
                if ($extension != "jpg" && $extension != "png" && $extension != "jpeg" && $extension != "gif") {
                    $error .= " Only upload JPG, JPEG, PNG and GIF files. ";
                }
            } else {
                $photo = NULL;
            }

            // Upload file 
            if ($error == "") {
                if (isset($path)) {
                    move_uploaded_file($_FILES["photo"]["tmp_name"], $path);
                }
                if (!ProductBUS::AddPr($prID, $prName, $typePrID, $photo, $descrip, $stt)) {
                    echo "<script>alert('Add products failed');</script>";
                }
            } else {
                echo "<script>alert('" . $error . "');</script>";
            }
        }
        ?>

        <!--Choose and Repair -->
        <?php
        if (isset($_POST["choose"])) {
            $sp = ProductBUS::CheckPr($_POST["choose"]);
        ?>
        <script>
        $("#txtprID").val('<?php echo $sp["prID"]; ?>');
        $("#txtprName").val('<?php echo $sp["prName"]; ?>');
        $("#cbotypePr").val('<?php echo $sp["typePrID"]; ?>');
        $("#txtdes").val('<?php echo $sp["descrip"]; ?>');
        $("#chkstatus").prop("checked", '<?php echo ($sp["stt"] == 1) ? true : false; ?>');
        $("#txtprID").prop("readonly", "true");
        $("#btnAdd").hide();
        $("#btnRepair").show();
        </script>
        <?php
        }

        if (isset($_POST["repair"])) {
            $prID = $_POST["prID"];
            $prName = $_POST["prName"];
            $typePrID = $_POST["typePrID"];
            $descrip = $_POST["descrip"];
            $stt = isset($_POST["stt"]) ? 1 : 0;

            // Xử lí upload ảnh đại diện
            $error = "";
            if ($_FILES["photo"]["name"] != "") {
                $photo = $prID . ".jpg";
                $path = "img/Product/" . $photo;

                // Kiểm tra file có phải là file ảnh hay không
                $check = getimagesize($_FILES["photo"]["tmp_name"]);
                if ($check == false) {
                    $error .= "The selected file is not an image file.  ";
                }

                // Kiểm tra dung lượng (tính bằng byte)
                if ($_FILES["photo"]["size"] > 1024 * 1024) {
                    $error .= " File exceeds the allowed size of 1 MB.";
                }

                // Kiểm tra phần mở rộng của file
                $extension = strtolower(pathinfo($path, PATHINFO_EXTENSION));
                if ($extension != "jpg" && $extension != "png" && $extension != "jpeg" && $extension != "gif") {
                    $error .= "Only upload JPG, JPEG, PNG and GIF files.";
                }
            } else {
                $photo = ProductBUS::CheckPr($prID)["photo"];
            }

            // Upload file ảnh
            if ($error == "") {
                if (isset($path)) {
                    move_uploaded_file($_FILES["photo"]["tmp_name"], $path);
                }
                if (!ProductBUS::Repair($prID, $prName, $typePrID, $descrip, $photo, $stt)) {
                    echo "<script>alert('Repair fails.');</script>";
                }
            } else {
                echo "<script>alert('" . $error . "');</script>";
            }
        }
        ?>

        <!-- Show list Origami -->
        <?php
        $result = ProductBUS::ListPr();
        if ($result->num_rows > 0) {
            $i = 1;
        ?>
        <form method="post">
            <table class="table table-light table-hover text-center">
                <thead class="thead-dark">
                    <tr>
                        <th>Photo</th>
                        <th>Origami code</th>
                        <th>Origami name</th>
                        <th>Type Origami</th>
                        <th>Description</th>
                        <th>Status</th>
                        <th colspan="2">Function</th>
                    </tr>
                </thead>
                <tbody>
                    <?php
                        while ($row = $result->fetch_assoc()) {
                        ?>
                    <tr>
                        <td><img class="img-thumbnail" style="width: 100px; height:100px"
                            src="img/Product/<?php echo $row["typePrName"]; ?>/<?php  echo $row["prName"]; ?>/<?php  echo $row["photo"]; ?>" alt=""></td>
                        <td><?php echo $row["prID"]; ?></td>
                        <td><?php echo $row["prName"]; ?></td>
                        <td><?php echo $row["typePrID"]; ?></td>
                        <td><?php echo $row["descrip"]; ?></td>
                        <td>
                            <div class="custom-control custom-checkbox">
                                <input class="custom-control-input" type="checkbox" readonly
                                    <?php if ($row["stt"] == 1) echo "checked"; ?>>
                                <label class="custom-control-label"></label>
                            </div>
                        </td>
                        <td>
                            <button class="btn btn-primary" type="submit" name="choose"
                                value="<?php echo $row["prID"]; ?>"><i class="fas fa-edit"  aria-hidden="true"></i></button>
                        </td>
                        <td>
                            <button class="btn btn-danger" type="submit" name="delete" value="<?php echo $row["prID"]; ?>"
                                onclick="return confirm('Are you sure you want to delete?');"><i class="fas fa-trash-alt" aria-hidden="true"></i></button>
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
            echo "Database has no products";
        }
        ?>
    </div>
</body>

</html>