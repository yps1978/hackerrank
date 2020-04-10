/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
select case 
when not (a+b>c and a+c>b and b+c>a and a-b<c and a-c<b and b-c<a) then 'Not A Triangle'
else case when a=b and a=c then 'Equilateral' when a=b or a=c or b=c then 'Isosceles' else 'Scalene' end end from Triangles;
