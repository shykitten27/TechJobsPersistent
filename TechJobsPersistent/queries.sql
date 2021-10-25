--sePart 1
SELECT DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where table_schema = 'techjobs' and table_name = 'jobs';

--Part 2
SELECT * FROM techjobs.employers where location = 'Saint Louis' order by Name;

--Part 3

