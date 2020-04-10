/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
declare @shortestLen int,
    @longestLen int
select @shortestLen = min(len(city)),
    @longestLen = max(len(city))
from Station;
declare @shortName varchar(max),
    @longName varchar(max)
select top 1 @shortName = City from Station where @shortestLen = len(City) order by City;
select top 1 @longName = City from Station where @longestLen = len(City) order by City;
print @shortName + ' ' + convert(varchar, @shortestLen)
print @longName + ' ' + convert(varchar, @longestLen)