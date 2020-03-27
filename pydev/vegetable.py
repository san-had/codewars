animal = "deer"
vegetable = "spinach"
mineral = "aluminium"

print("Here is an {}, a {}, and an {}.".format(animal, vegetable, mineral))

user_input = input('Please type something and press enter: ')

print('You entered: ')
print(user_input)

user_input = input('Please type something and press enter: ')

text_length = len(user_input)

print('_' * text_length)
print('< {} >'.format(user_input))