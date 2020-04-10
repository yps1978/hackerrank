/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

select name+'('+left(occupation,1)+')'
from occupations
order by 1;

with cte as (
    select count(1) as zcount, lower(occupation) as zoccupation
    from occupations
    group by occupation
)
select 'There are a total of '+convert(varchar,zcount)+' '+zoccupation+'s.'
from cte
order by zcount;