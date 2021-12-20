--sePart 1
SELECT DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where table_schema = 'techjobs' and table_name = 'jobs';

--Part 2
SELECT * FROM techjobs.employers where location = 'Saint Louis' order by Name;
--There is no St. Louis City as I imported the flat file from original project. 

--Part 3
select distinct s.Name, s.Description from skills s
join jobskills js on s.Id = js.SkillId
left join jobs j on j.Id = js.JobId
where js.jobid is not null
order by s.Name;

