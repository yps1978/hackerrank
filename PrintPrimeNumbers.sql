/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
declare @i int = 2,
	@output varchar(2000)='';

while (@i<1000)
begin
	declare @sqrt int = sqrt(@i),
		@j int = 2,
		@abort bit = 0

	while (@j <= @sqrt)
	begin
		if (@i % @j = 0 and @i <> @j)
			select @j = @sqrt, @abort = 1
		set @j = @j + 1
	end

	if (@abort = 0)
		set @output = @output + '&' + convert(varchar, @i)

    set @i = @i + 1
end
print substring(@output, 2, 100000)