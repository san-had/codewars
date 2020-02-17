#include <stdio.h>
#include <stdlib.h>

int divisors(int n);

void main(void)
{
	int n = 4096;

	printf("%d\n", divisors(n));

	return EXIT_SUCCESS;
}

int divisors(int n)
{
	int divisors_count = 0;
	for (int i = 1; i <= n; i++)
	{
		if (!(n % i))
		{
			divisors_count++;
		}
	}
	return divisors_count;
}