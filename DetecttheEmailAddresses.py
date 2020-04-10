# Enter your code here. Read input from STDIN. Print output to STDOUT
import re

email_regex = r'\b[\w\.]+\w+@[\w\.]+\w+\b'
emails = []
n = int(input())
for i in range(n):
    email_dict = dict()
    line = input()
    matches = re.findall(email_regex, line)
    for email in matches:
        if email_dict.get(email):
            email_dict[email] += 1
        else:
            email_dict[email] = 1

    emails.extend([key for (key, value) in email_dict.items() if value == 1])

emails = list(dict.fromkeys(emails))
for i, e in enumerate(sorted(emails)):
    print(e, end=';' if i < len(emails) - 1 else '')
