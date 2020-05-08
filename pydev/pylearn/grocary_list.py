
def printList(list):
    print('Your Grocery List:')
    text_length = 25
    print(' {}'.format('-' * text_length))
    print(' {}'.format('-' * 25))

    for item in list:
        print(item)


grocary_list = []

item = 'Hello'
while item!='':    
    item = input('Enter an item for your grocery list. Press <ENTER> when done: ')
    grocary_list.append(item)

printList(grocary_list)
