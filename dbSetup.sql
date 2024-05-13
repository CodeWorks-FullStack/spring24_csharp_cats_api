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
    -- PRIMARY KEY denotes this as the unique identifier for each row in the table. AUTO_INCREMENT assigns the ids for us
    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    -- VARCHAR(255) denotes a string data type with a max character limit of 255
    name VARCHAR(255) NOT NULL,
    -- TINYINT UNSIGEND denotes a positive interger between 0 and 255 
    age TINYINT UNSIGNED NOT NULL,
    -- BOOLEAN denotes a TINYINT value that is either 1 or 0
    hasPolydactylity BOOLEAN DEFAULT false NOT NULL,
    color VARCHAR(255) NOT NULL
  );

-- removes table from database, you will need to do this to make changes to table after it has been created
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