#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the minimumSwaps function below.
def minimumSwaps(arr):
    count = 0
    refs = [0] * (len(arr) + 1)
    for i in range(len(arr)):
        refs[arr[i]] = i

    for i in range(len(arr)):
        if arr[i] != i + 1:
            j = refs[i + 1]

            refs[arr[i]] = j
            refs[arr[j]] = i

            # swap i and j
            aux = arr[i]
            arr[i] = arr[j]
            arr[j] = aux

            count += 1

    return count


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    res = minimumSwaps(arr)

    fptr.write(str(res) + '\n')

    fptr.close()
