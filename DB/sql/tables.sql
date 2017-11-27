CREATE TABLE `simadmin_simlap`.`dftr_urusan`(  
  `urusan_id` VARCHAR(15) NOT NULL,
  `uid1` VARCHAR(3) NOT NULL,
  `uid2` VARCHAR(3) NOT NULL,
  `uid3` VARCHAR(3) NOT NULL,
  `urpeda` VARCHAR(70) NOT NULL,
  PRIMARY KEY (`urusan_id`)
);

CREATE TABLE `simadmin_simlap`.`dftr_unit`(
 `unit_id` VARCHAR(15) NOT NULL,
 `uid1` VARCHAR(3) NOT NULL,
 `uid2` VARCHAR(3) NOT NULL,
 `uid3` VARCHAR(3) NOT NULL,
 `uid4` VARCHAR(3) NOT NULL,
 `uid5` VARCHAR(3) NOT NULL,
 `urpeda` VARCHAR(80) NOT NULL,
 PRIMARY KEY (`unit_id`) ); 
