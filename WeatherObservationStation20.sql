/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
with minhalf as (
    select top 50 percent lat_n
    from station
    order by lat_n
),
maxhalf as (
    select top 50 percent lat_n
    from station
    order by lat_n desc
)
select convert(decimal(19,4),(max(minhalf.lat_n) + min(maxhalf.lat_n))/2.0)
from minhalf, maxhalf;