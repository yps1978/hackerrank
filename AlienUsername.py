# Enter your code here. Read input from STDIN. Print output to STDOUT
Regex_Pattern = r'^([_\.])[0-9]+[a-zA-Z]*(_{0,1})$'    # Do not delete 'r'.

import re

n=int(input())
for i in range(n):
    print ('VALID' if re.search(Regex_Pattern, input()) else 'INVALID')
