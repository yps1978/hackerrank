if __name__ == '__main__':
    n = int(input())
    student_marks = dict()
    for _ in range(n):
        name, *line = input().split()
        scores = list(map(float, line))
        student_marks[name] = scores
    query_name = input()

    student = student_marks.get(query_name)
    avg = (student[0] + student[1] + student[2]) / 3
    print(str.format('{0:.2f}', avg))
