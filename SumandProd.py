import numpy

(n, m) = (int(n) for n in input().strip().split(' '))
arr = []
for i in range(n):
    arr.append([int(n) for n in input().strip().split(' ')])

print (numpy.prod(numpy.sum(arr, axis=0)))
