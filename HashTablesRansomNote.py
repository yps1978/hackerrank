#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the checkMagazine function below.
def checkMagazine(magazine, note):
    words_dict = {word: 0 for word in note}
    for word in note:
        words_dict[word] += 1

    words_pending = len(note)

    i = 0
    while words_pending > 0 and i < len(magazine):
        if magazine[i] in words_dict:
            if words_dict[magazine[i]] > 0:
                words_dict[magazine[i]] -= 1
                words_pending -= 1
            else:
                words_dict.pop(magazine[i])
        i += 1

    print('Yes' if words_pending <= 0 else 'No')

if __name__ == '__main__':
    mn = input().split()

    m = int(mn[0])

    n = int(mn[1])

    magazine = input().rstrip().split()

    note = input().rstrip().split()

    checkMagazine(magazine, note)
