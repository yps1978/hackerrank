if __name__ == '__main__':
    n = int(input())
    arr = map(int, input().split())

    unique = []
    [unique.append(i) for i in arr if i not in unique]
    unique.sort()
    print (unique[-2])
