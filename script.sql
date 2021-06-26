Build started...
Build succeeded.
ALTER DATABASE CHARACTER SET utf8mb4;
CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `Entities` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `LongString` varchar(5000) CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_Entities` PRIMARY KEY (`Id`)
) CHARACTER SET utf8mb4;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210626155013_Init', '5.0.7');

COMMIT;


