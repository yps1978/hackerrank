# Enter your code here. Read input from STDIN. Print output to STDOUT
import re

n = int(input())
arr = []
for i in range(n):
    line = input()
    arr.append('VALID' if re.match(
        r'^\d+\s(C|CPP|JAVA|PYTHON|PERL|PHP|RUBY|CSHARP|HASKELL|CLOJURE|BASH|SCALA|ERLANG|CLISP|LUA|BRAINFUCK|JAVASCRIPT|GO|D|OCAML|R|PASCAL|SBCL|DART|GROOVY|OBJECTIVEC)$',
        line) else 'INVALID')
for item in arr:
    print(item)
