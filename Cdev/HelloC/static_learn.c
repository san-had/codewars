#include <stdio.h>
#include <stdlib.h>

int runner()
{
	static int count = 0;
	count++;
	return count;
}

void display_runner()
{
	printf("%d \n", runner());
	printf("%d \n", runner());
}

int sum(int num)
{
	static int sum = 0;
	sum += num;
	return sum;
}

void display_sum()
{
	printf("%d\n", sum(55));
	printf("%d\n", sum(45));
	printf("%d\n", sum(50));
}

int main()
{
	//display_runner();

	display_sum();

	return EXIT_SUCCESS;
}