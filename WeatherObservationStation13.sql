/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
select convert(decimal(19,4),sum(lat_n))
from station
where lat_n between 38.7880 and 137.2345