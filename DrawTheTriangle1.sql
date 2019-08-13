/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
declare @i int = 0;
while (@i<20)
begin
	declare @val varchar(2000)=replicate('* ', 20 - @i)
    print rtrim(@val)
	

    set @i = @i + 1
end