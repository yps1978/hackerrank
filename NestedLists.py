if __name__ == '__main__':
    arr=[]
    for _ in range(int(input())):
        name = input()
        score = float(input())
        arr.append([name, score])

    scores = []
    [scores.append(item[1]) for item in sorted(arr, key=lambda x: x[1]) if item[1] not in scores]

    print('\n'.join([item[0] for item in sorted(arr, key=lambda x: x[0]) if item[1] == scores[1]]))
