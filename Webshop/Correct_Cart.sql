﻿USE Webshop
ALTER TABLE Carts
ADD CONSTRAINT FK_Product FOREIGN KEY (ProductFK) REFERENCES Products(ProductID)
