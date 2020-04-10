# Enter your code here. Read input from STDIN. Print output to STDOUT
regex_ipv4 = r'^(([01]{0,1}[0-9]{0,1}[0-9]|2[0-4][0-9]|25[0-5])\.){3}(([01]{0,1}[0-9]{0,1}[0-9]|2[0-4][0-9]|25[0-5]))$'
regex_ipv6 = r'^([0-9a-f]{1,4}:){7}[0-9a-f]{1,4}$'

import re

n = int(input())
for i in range(n):
    s=input()
    print ('IPv4' if re.search(regex_ipv4, s) else 'IPv6' if re.search(regex_ipv6, s) else 'Neither')
