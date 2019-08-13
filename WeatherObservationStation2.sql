/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
select convert(decimal(19,2),sum(lat_n), 2), convert(decimal(19,2),round(sum(long_w), 2))
from station;