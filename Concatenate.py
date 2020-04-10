import numpy

(n, m, p) = (int(n) for n in input().strip().split(' '))
arr_1 = []
for i in range(n):
    arr_1.append([int(n) for n in input().strip().split(' ')])

arr_2 = []
for i in range(m):
    arr_2.append([int(n) for n in input().strip().split(' ')])

print (numpy.concatenate((arr_1, arr_2), axis=0))
