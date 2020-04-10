import numpy

l = [float(n) for n in input().split()]

numpy.set_printoptions(sign=' ')
print(numpy.array2string(numpy.floor(l)))

print(numpy.array2string(numpy.ceil(l)))

print(numpy.array2string(numpy.rint(l)))
