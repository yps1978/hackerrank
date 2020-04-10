import numpy

line=input()
elems = [int(n) for n in line.split(' ')]

print (numpy.zeros(elems, dtype=int))
print (numpy.ones(elems, dtype=int))
