animals = []

with open('animals.txt', 'r') as file_animals:
    for line in file_animals:
        animals.append(line.rstrip())

animals.sort()

with open('animals-sorted.txt', 'w') as sorted_animals:
    for animal in animals:
        print(animal)
        sorted_animals.write('{}\n'.format(animal))

with open('animals-sorted.txt', 'r') as sorted_animals_for_read:
    for line in sorted_animals_for_read:
        print(line.rstrip())