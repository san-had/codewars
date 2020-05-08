people = {
    'David': 'Was a mascot in college',
    'Jeff': 'Was born in France',
    'Anna': 'Has arachnophobia'
}

for person in people:
    if person=='Jeff':
        people[person] = 'Jeff has changed'
    print('{}: {}.'.format(person,people[person]))

people['Jon'] = 'Very tricky person.'

for person in people:
    print('{}: {}.'.format(person, people[person]))