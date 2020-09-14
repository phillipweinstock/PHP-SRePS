CREATE TABLE `Category`
(
 `cat_id` int auto_increment NOT NULL ,
 `cat_desc` varchar(100) NOT NULL ,

PRIMARY KEY (`cat_id`)
);


CREATE TABLE `Item`
(
 `item_id`  int auto_increment NOT NULL ,
 `price` decimal NOT NULL ,
 `name` varchar(20) NOT NULL ,
 `cat_id` int NOT NULL ,

PRIMARY KEY (`item_id`),
KEY `fkIdx_14` (`cat_id`),
CONSTRAINT `FK_14` FOREIGN KEY `fkIdx_14` (`cat_id`) REFERENCES `Category` (`cat_id`)
);

CREATE TABLE `ItemDetail`
(
 `item_detail_id`    int auto_increment NOT NULL ,
 `quantity` int NOT NULL ,
 `item_id`  int NOT NULL ,

PRIMARY KEY (`item_detail_id`),
KEY `fkIdx_28` (`item_id`),
CONSTRAINT `FK_28` FOREIGN KEY `fkIdx_28` (`item_id`) REFERENCES `ITEM` (`item_id`)
);

CREATE TABLE `Sale`
(
 `sale_id`      int auto_increment NOT NULL ,
 `total_billed` decimal NOT NULL ,
 `item_detail_id`     int NOT NULL ,

PRIMARY KEY (`sale_id`),
KEY `fkIdx_25` (`item_detail_id`),
CONSTRAINT `FK_25` FOREIGN KEY `fkIdx_25` (`item_detail_id`) REFERENCES `ItemDetail` (`item_detail_id`)
);