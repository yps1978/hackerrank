# Enter your code here. Read input from STDIN. Print output to STDOUT
import re

n = int(input())
for i in range(n):
    line = input()
    if re.match(r'^[Hh][Ii]\s[^Dd]', line):
        print(line)
