# Enter your code here. Read input from STDIN. Print output to STDOUT
import re

n = int(input())
for i in range(n):
    line = input()
    m = re.match(r'(\d+).(\d+).(\d+)', line)

    print(str.format('CountryCode={},LocalAreaCode={},Number={}', m.group(1), m.group(2), m.group(3)))
    
