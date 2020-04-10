# Enter your code here. Read input from STDIN. Print output to STDOUT
import re

domain_regex = r'\b(http|https):\/\/(www.|ww2.)?([a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)+)\b'
domains = []
n = int(input())
for i in range(n):
    line = input()
    matches = re.findall(domain_regex, line)

    if matches:
        for match in matches:
            if match[2] not in domains:
                domains.append(match[2])

for i, e in enumerate(sorted(domains)):
    print(e, end=';' if i < len(domains) - 1 else '')
