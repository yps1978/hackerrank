# Enter your code here. Read input from STDIN. Print output to STDOUT
import sys
from collections import deque

if __name__ == '__main__':
    n = int(input())
    res = []
    for i in range(n):
        l = int(input())
        d = deque(map(int, input().split(' ')))

        q = sys.maxsize
        result = 'Yes'

        while len(d) > 0:
            if d[0] <= q and d[-1] <= q:
                if d[0] >= d[-1]:
                    q = d.popleft()
                else:
                    q = d.pop()
            elif d[0] <= q:
                q = d.popleft()
            elif d[-1] <= q:
                q = d.pop()
            else:
                result = 'No'
                break

        res.append(result)

    for i in res:
        print(i)
