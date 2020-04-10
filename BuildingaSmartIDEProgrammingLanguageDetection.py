# Enter your code here. Read input from STDIN. Print output to STDOUT
import re

line = ' '
text = ''

while True:
    try:
        line = input()
        if line:
            text += line
    except EOFError:
        break

if re.findall(r'class\s+\w+\s+{', text, re.M) or re.findall(r'import\s+\w+(\.\w+)*(\.\w+|\.\*);', text, re.M):
    print('Java')
elif re.findall(r'#include', text, re.M) or re.findall(r'^(?!(?:def))\w+\s+main\(', text, re.M):
    print('C')
else:
    print('Python')
