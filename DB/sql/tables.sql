CREATE TABLE `simadmin_simlap`.`dftr_unit`(
 `unit_id` VARCHAR(15) NOT NULL,
 `uid1` VARCHAR(3) NOT NULL,
 `uid2` VARCHAR(3) NOT NULL,
 `uid3` VARCHAR(3) NOT NULL,
 `uid4` VARCHAR(3) NOT NULL,
 `uid5` VARCHAR(3) NOT NULL,
 `urpeda` VARCHAR(80) NOT NULL,
 PRIMARY KEY (`unit_id`) ); 

CREATE TABLE `simadmin_simlap`.`dftr_progkeg`(
 `prog_id` VARCHAR(15) NOT NULL,
 `uid1` VARCHAR(3) NOT NULL,
 `uid2` VARCHAR(3) NOT NULL,
 `progkeg` VARCHAR(180) NOT NULL,
 PRIMARY KEY (`prog_id`) ); 
