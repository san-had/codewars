distance = input('What distance are you traveling in miles?')

distance = int(distance)

if distance < 3:
    transportation = 'walking'
elif distance < 300:
    transportation = 'driving'
else:
    transportation = 'flying'

print('I suggest {} to your destination.'.format(transportation))