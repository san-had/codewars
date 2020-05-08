# hello = open('hello.py')

# print('Current position {}'.format(hello.tell()))

# hello_content = hello.read()

# print('Current position {}'.format(hello.tell()))

# print(hello.read())

# hello.seek(0)

# print('Current position {}'.format(hello.tell()))

# print(hello.read())

# hello.close()

with open('sanyi.txt', 'w') as the_file:
    the_file.write('This text will be written to the file.\n')
    the_file.write('Here is some more text.\n')

with open('sanyi.txt', 'r') as sanyi_file:
    print(sanyi_file.read())

