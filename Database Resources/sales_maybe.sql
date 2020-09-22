
CREATE TABLE Category
(
 cat_id   int auto_increment NOT NULL ,
 cat_desc varchar(100) NOT NULL ,
 cat_name varchar(20) NOT NULL ,

PRIMARY KEY (cat_id)
);

CREATE TABLE SALE
(
 sale_id int auto_increment NOT NULL,
 total_billed decimal(10, 2) NOT NULL,
 date datetime NOT NULL,
PRIMARY KEY (sale_id)
);

CREATE TABLE ITEM
(
 item_id  int auto_increment NOT NULL ,
 price decimal(10, 2) NOT NULL ,
 name varchar(45) NOT NULL ,
 cat_id int,

PRIMARY KEY (item_id),
KEY fkIdx_14 (cat_id),
CONSTRAINT FK_14 FOREIGN KEY fkIdx_14 (cat_id) REFERENCES Category (cat_id)
);

CREATE TABLE ITEMDETAIL
(
 item_detail_id    int auto_increment NOT NULL ,
 quantity int NOT NULL ,
 item_id     int NOT NULL ,
 sale_id     int NOT NULL ,

PRIMARY KEY (item_detail_id),
KEY fkIdx_28 (item_id),
CONSTRAINT FK_28 FOREIGN KEY fkIdx_28 (item_id) REFERENCES ITEM (item_id),
KEY fkIdx_37 (sale_id),
CONSTRAINT FK_37 FOREIGN KEY fkIdx_37 (sale_id) REFERENCES SALE (sale_id)
);

CREATE TABLE USERS(
     user_id int AUTO_INCREMENT PRIMARY KEY NOT NULL,
     user_name varchar(50),
     Hash varchar(25)
    );