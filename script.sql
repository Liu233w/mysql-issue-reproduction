Build started...
Build succeeded.
ALTER DATABASE CHARACTER SET utf8mb4;
CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET utf8mb4;

START TRANSACTION;

CREATE TABLE `Entities` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `LongString` longtext CHARACTER SET utf8mb4(5000) NULL,
    CONSTRAINT `PK_Entities` PRIMARY KEY (`Id`)
);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210626155013_Init', '5.0.7');

COMMIT;

START TRANSACTION;

ALTER TABLE `Entities` MODIFY COLUMN `LongString` varchar(5000) CHARACTER SET utf8mb4 NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210626162110_Upgrade', '5.0.7');

COMMIT;


