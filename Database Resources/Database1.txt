CREATE TABLE Category (
    category_id varChar(100) NOT NULL PRIMARY KEY,
    category_description varchar(100) 
    );
	
	
CREATE TABLE Item_Detail (
    item_id Int AUTO_INCREMENT PRIMARY KEY,
    name varchar(20) NOT NULL,
	price DECIMAL,
    category_id varchar(20),
    FOREIGN KEY (category_id) REFERENCES Category(category_id)
    );
	
	CREATE TABLE Item (
    item_id Int PRIMARY KEY NOT NULL,
    qty int,
    FOREIGN KEY (item_id) REFERENCES Item_Detail(item_id)
    );
	
	
	CREATE TABLE Sale (
    sale_id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    item_id INT,
    toal_amount DECIMAL,
	FOREIGN KEY (item_id) REFERENCES Item_Detail(item_id)
    );


Alter Table Item_Detail
Add sale_id INT,
Add Constraint PRIMARY KEY (sale_id);