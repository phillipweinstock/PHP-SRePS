
CREATE TABLE `Category`
(
 `cat_id` int auto_increment NOT NULL ,
 `cat_name` varchar(20) NOT NULL,
 `cat_desc` varchar(100) NOT NULL ,

PRIMARY KEY (`cat_id`)
);

CREATE TABLE `Item`
(
 `item_id` int auto_increment NOT NULL ,
 `price` float NOT NULL ,
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
 `total_billed` float NOT NULL ,
 `item_detail_id`     int NOT NULL ,

PRIMARY KEY (`sale_id`),
KEY `fkIdx_25` (`item_detail_id`),
CONSTRAINT `FK_25` FOREIGN KEY `fkIdx_25` (`item_detail_id`) REFERENCES `ItemDetail` (`item_detail_id`)
);

/* Insert into database example values */
INSERT INTO CATEGORY (cat_name, cat_desc) 
VALUES ("An Item", "It is an item that can be bought");

INSERT INTO ITEM (price, name, cat_id)
VALUES (1220.90, "Car", 1);

INSERT INTO ITEMDETAIL (quantity, item_id)
VALUES (1, 1);

INSERT INTO SALE (total_billed, item_detail_id)
VALUES (1240.00, 1);