/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
with cte as (
    select max(lat_n) as maxlat_n from station where lat_n<137.2345 
)
select convert(decimal(19,4),long_w)
from station, cte
where lat_n=cte.maxlat_n;