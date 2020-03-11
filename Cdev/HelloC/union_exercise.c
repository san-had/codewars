#include <stdlib.h>
#include <stdio.h>

union char_store {
	char chars[24];
	int ints[6];
};

int main(void)
{
	union char_store intCharacters = { { 1853169737, 1936876900, 1684955508, 1768838432, 561213039, 0} };

	printf("[");

	for (int i = 0; i < 19; i++)
	{
		printf("%c, ", intCharacters.chars[i]);
	}
	printf("%c]\n", intCharacters.chars[19]);

	printf("%s\n", intCharacters.chars);

	return EXIT_SUCCESS;
}