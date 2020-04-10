# Enter your code here. Read input from STDIN. Print output to STDOUT
import re

sentences = []
n = int(input())
for i in range(n):
    sentences.append(input())

t = int(input())
for i in range(t):
    word_count = 0
    word = input()
    regex = r'\b{}\b'.format(word)

    for sentence in sentences:
        matches = re.findall(regex, sentence)
        word_count += len(matches)

    print(word_count)
