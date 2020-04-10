/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
with cte as (
    select min(lat_n) as a, min(long_w) as b, max(lat_n) as c, max(long_w) as d
    from station
)
select convert(decimal(19,4),  abs(a - c + b - d))
from cte;