/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
select convert(int, round(
 (select avg(convert(decimal(19,2),salary)) from employees)
 -
 (select avg(convert(decimal(19,2), replace(convert(varchar(10), salary), '0', ''))) from employees)
, 2)+1
);