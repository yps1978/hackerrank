# Enter your code here. Read input from STDIN. Print output to STDOUT
from collections import deque

if __name__ == '__main__':
    n = int(input())
    d = deque()
    for i in range(n):
        op = input().split()
        if len(op) == 1:
            if op[0] == 'pop':
                d.pop()
            elif op[0] == 'popleft':
                d.popleft()
        elif op[0] == 'append':
            d.append(op[1])
        elif op[0] == 'appendleft':
            d.appendleft(op[1])
    for i in d:
        print(i, end=' ')
