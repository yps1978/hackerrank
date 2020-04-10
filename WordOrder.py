# Enter your code here. Read input from STDIN. Print output to STDOUT
if __name__ == '__main__':
    n = int(input())
    arr = []
    for i in range(n):
        arr.append(input())

    count = {item: 1 for item in arr}
    arr.sort()
    for i in range(1, n):
        if arr[i] == arr[i - 1]:
            count[arr[i]] += 1
    lst = list(count.items())

    print(len(lst))
    for item in lst:
        print(item[1], end=' ')
