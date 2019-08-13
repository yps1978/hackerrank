with cte as (
    select salary*months as earnings, employee_id
    from employee
), m as (select max(salary*months) as earnings from employee)
select cte.earnings, count(1) from cte
join m on cte.earnings=m.earnings
group by cte.earnings
