/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
select distinct City from Station where left(City,1) not in ('a','e','i','o','u');