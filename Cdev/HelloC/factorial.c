#include <stdlib.h>
#include <stdio.h>

int factorial(int n);

int factorial_main(void)
{
	printf("1! == %i\n", factorial(1));
	printf("2! == %i\n", factorial(2));
	printf("3! == %i\n", factorial(3));

	return EXIT_SUCCESS;
}

int factorial(int n)
{
	if (n >= 1)
	{
		return n * factorial(n - 1);
	}
	else
	{
		return 1;
	}
}