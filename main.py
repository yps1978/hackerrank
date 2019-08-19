import json
from os.path import exists

base_folder = "C:\\Users\YPRADO\\Documents\\py\\"

with open(base_folder + 'yaselp_data.json', 'r') as f:
    parsed_json = json.load(f)

for s in parsed_json['submissions']:
    if s['score'] == 1.0:
        extension = 'cs' if s['language'] == 'csharp' \
            else 'sql' if s['language'] == 'tsql' \
            else 'cpp' if s['language'] == 'cpp' \
            else 'js' if s['language'] == 'javascript' \
            else 'java' if s['language'] == 'java8' or s['language'] == 'java' else 'txt'
        out_file = s['challenge'].replace(' ', '').replace('\'', '').replace(':', '')
        file_location = '{}\output\{}.{}'.format(base_folder, out_file, extension)
        if not exists(file_location):
            w = open(file_location, "w+")
            w.write(s['code'])
            w.close()
