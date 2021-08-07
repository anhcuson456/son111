<?php 
    require_once "BUS/ProductBUS.php";
    require_once "BUS/TypeProductBUS.php";
?>
<section id="portfolio">
    <div class="container wow fadeInUp">
        <div class="section-header">
            <h3 class="section-title">Some outstanding origami</h3>
            <p class="section-description">Origami is a relaxing art suitable for all ages</p>
        </div>
        <div class="row" class="col-lg-12" >
        <?php
        $result = TypeProductBUS:: ListType ();
        if ($result->num_rows > 0) {
            $i = 1;
            while ($row = $result->fetch_assoc()) {
        ?>
            <div >
                <ul id="portfolio-flters">
                    <li data-filter=".filter-<?php echo $row["typePrID"]; ?>"><?php echo $row["typePrName"];?></li>
                </ul>
            </div> 
        <?php
            }
        }
        ?>
        </div>
        <div class="row" id="portfolio-wrapper">
            <?php 
                $list = ProductBUS:: ListPr ();
                if ($list->num_rows > 0) {
                    $i = 1;

                    while ($pr = $list->fetch_assoc()) {
            ?>
            <div class="col-lg-3 col-md-6 portfolio-item filter-<?php echo $pr["typePrID"];?>">
                <a href="DetailPr.php?prID=<?php echo $pr["prID"]; ?>">
                    <img src="img/Product/<?php echo $pr["typePrName"]; ?>/<?php echo $pr["prName"];  ?>/<?php echo $pr["photo"]; ?>" width="265" height="200"  alt="">                    
                    <div class="details">
                            <h4><?php echo $pr["prName"]; ?></h4>
                            <span><?php echo $pr["typePrName"]; ?></span>
                        </div>
                    </a>
            </div>
            <?php
                }
            }
            ?>
        </div>
    </div>
</section>