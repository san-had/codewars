animals = ['toad', 'lion', 'seal']

"""animals.extend(['fox','owl'])

animals.insert(2, 'ox')

print(animals)

some_animals = animals[1:4]

print('Some animals: {}'.format(some_animals))

print(animals[:2])

print('Last two: {}'.format(animals[4:6])) """

""" part_of_a_whale = 'whale'[1:3]

print(part_of_a_whale)

try:

    lion_index = animals.index('lin')

except:
    lion_index = "No lion found."

print(lion_index) """


""" for animal in animals:
    print(animal.upper())

index = 0
while index < len(animals):
    print(animals[index])
    index += 1 """

""" print(sorted(animals))
animals.sort()
print(animals)  """   

animals = ['toad', 'lion', 'seal', 'fox', 'owl', 'whale', 'elk']
for number in range(0, len(animals), 2):
    print(animals[number])





