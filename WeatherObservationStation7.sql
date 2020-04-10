/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
select distinct City from Station where right(City,1) in ('a','e','i','o','u');