with open('sanyi.txt','r') as sanyi_file:
    line_number = 1
    for line in sanyi_file:
        print('{}. {}'.format(line_number, line.rstrip()))
        line_number += 1
