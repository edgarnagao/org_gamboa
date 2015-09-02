CREATE TABLE `quotation_products` (
  `Quotation_Id` int(11) NOT NULL DEFAULT '0',
  `Product_Id` int(11) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  PRIMARY KEY (`Quotation_Id`)
);

CREATE TABLE `quotation_status` (
  `status_id` int(11) NOT NULL AUTO_INCREMENT,
  `status_description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`status_id`)
);

CREATE TABLE `quotations` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `client_id` int(11) NOT NULL,
  `status_id` varchar(45) DEFAULT NULL,
  `creation_date` timestamp NULL DEFAULT NULL,
  `last_update` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
);

INSERT INTO `gamboadb`.`quotation_status`
(`status_id`,`status_description`)
VALUES (1,'NUEVA');

INSERT INTO `gamboadb`.`quotation_status`
(`status_id`,`status_description`)
VALUES (2,'EN PROGRESO');

INSERT INTO `gamboadb`.`quotation_status`
(`status_id`,`status_description`)
VALUES (3,'COMPLETADA');

