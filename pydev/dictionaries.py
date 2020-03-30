contacts = {
    'David':['555-0123', '555-0000'],
     'Tom':'555-5678'
}

davids_phone = contacts['David']

#contacts['David'] = '555-0000'

print(davids_phone)

print(contacts['David'])

if 'David' in contacts.keys():
    print(contacts['David'][1])

print('555-0000' in contacts.values())

for contact in contacts

for person, phone_number in contacts.items():
    print('The number for {0} is {1}.'.format(person, phone_number))






