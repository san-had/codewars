def get_min_max(seq):
    seq.sort()
    return (seq[0], seq[len(seq) - 1])

(min, max) = get_min_max([2,1])

print('The min number is: {}'.format(min))
print('The max number is: {}'.format(max))

