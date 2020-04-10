import numpy

(m, n) = (int(n) for n in input().split())
matrix = numpy.eye(m, n, k=0, dtype=int)

s = '['
for i in range(0, m):
    s += str.format('{}[', ' ' if i>0 else '')
    for j in range(0, n):
        s += str.format(' {}{}.', ' ' if j>0 else '', matrix[i][j])
    s += str.format(']{}', '\r\n' if i < m - 1 else '')
s += ']'
print (s)
