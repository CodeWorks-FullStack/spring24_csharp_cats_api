-- Active: 1715613933556@@127.0.0.1@3306@adaptable_shaman_540684_db
CREATE TABLE
  IF NOT EXISTS accounts (
    id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
    updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
    name varchar(255) COMMENT 'User Name',
    email varchar(255) COMMENT 'User Email',
    picture varchar(255) COMMENT 'User Picture'
  ) default charset utf8mb4 COMMENT '';

CREATE TABLE
  cats (
    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    age TINYINT UNSIGNED NOT NULL,
    hasPolydactylity BOOLEAN DEFAULT false NOT NULL,
    color VARCHAR(255) NOT NULL
  );

DROP TABLE cats;

-- CREATE
INSERT INTO
  cats (name, age, color)
VALUES
  ("Georgie", 12, "Gray");

-- CREATE MULTIPLE
INSERT INTO
  cats (name, age, color, hasPolydactylity)
VALUES
  ("Louie", 15, "Orange", false),
  ("Smokey", 10, "Striped", false),
  ("Bandit", 11, "Tan", false),
  ("Bruce", 10, "White", false);

-- READ
SELECT
  *
FROM
  cats;

-- UDPATE
UPDATE cats
SET
  name = "Louie"
WHERE
  id = 1;

-- DELETE
DELETE FROM cats
WHERE
  id = 5;