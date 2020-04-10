/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
select [Doctor], [Professor], [Singer], [Actor] from (
    select name, occupation, row_number() over (partition by occupation order by name) as rowId from occupations
) s
pivot(
    max(name)
    for occupation in ([Doctor], [Professor], [Singer], [Actor])
) p