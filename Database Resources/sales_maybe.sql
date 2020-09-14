
CREATE TABLE `CATAGORY`
(
 `CAT_ID`     int NOT NULL ,
 `CAT_D_ID_1` varchar(100) NOT NULL ,

PRIMARY KEY (`CAT_ID`)
);


CREATE TABLE `ITEM`
(
 `item_id`  int NOT NULL ,
 `price_id` decimal NOT NULL ,
 `name_id`   NOT NULL ,
 `CAT_ID`   int NOT NULL ,

PRIMARY KEY (`item_id`),
KEY `fkIdx_14` (`CAT_ID`),
CONSTRAINT `FK_14` FOREIGN KEY `fkIdx_14` (`CAT_ID`) REFERENCES `CATAGORY` (`CAT_ID`)
);



CREATE TABLE `ITEMDETAIL`
(
 `itemd_id`    int NOT NULL ,
 `quantity_id` int NOT NULL ,
 `item_id`     int NOT NULL ,

PRIMARY KEY (`itemd_id`),
KEY `fkIdx_28` (`item_id`),
CONSTRAINT `FK_28` FOREIGN KEY `fkIdx_28` (`item_id`) REFERENCES `ITEM` (`item_id`)
);



CREATE TABLE `SALE`
(
 `sale_id`      int NOT NULL ,
 `total_billed` decimal NOT NULL ,
 `itemd_id`     int NOT NULL ,

PRIMARY KEY (`sale_id`),
KEY `fkIdx_25` (`itemd_id`),
CONSTRAINT `FK_25` FOREIGN KEY `fkIdx_25` (`itemd_id`) REFERENCES `ITEMDETAIL` (`itemd_id`)
);









