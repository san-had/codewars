#include <stdlib.h>
#include <stdio.h>

void dynamic_allocation(int n);

int main(void)
{
	char c = 'A';
	char* pc = &c;

	printf("%c\n", *pc);

	char vowels[] = { 'A', 'E', 'I', 'O', 'U' };
	char* pvowels = &vowels;

	printf("%u\n", &vowels);
	printf("%u\n", &vowels[0] + sizeof(double));
	printf("%u\n", vowels + 1);

	for (int i = 0; i < 5; i++)
	{
		printf("&vowels[%d]= %u, pvowels + %d= %u, vowels + %d= %u\n", i, &vowels[i], i, pvowels + i, i, vowels + i);
	}

	for (int i = 0; i < 5; i++)
	{
		printf("vowels[%d]= %c, *(pvowels + %d)= %c, *(vowels + %d)= %c\n", i, vowels[i], i, *(pvowels + i), i, *(vowels + i));
	}

	dynamic_allocation(5);

	return EXIT_SUCCESS;
}

void dynamic_allocation(int n)
{
	char* pvowels = (char*)malloc(sizeof(char) * n);

	pvowels[0] = 'A';
	pvowels[1] = 'E';
	*(pvowels + 2) = 'I';
	pvowels[3] = 'O';
	*(pvowels + 4) = 'U';

	for (size_t i = 0; i < n; i++)
	{
		printf("%c ", pvowels[i]);
	}

	printf("\n");

	free(pvowels);
}