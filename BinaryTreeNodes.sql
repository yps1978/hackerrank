/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

select a.n,
    case when p is null then 'Root'
        when not exists (select 1 from bst b where b.p = a.n) then 'Leaf'
        else 'Inner'
    end as result
from bst a
order by 1;