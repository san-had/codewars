#include <stdlib.h>
#include <stdio.h>

void display_pointer(int* intpointer);

int pointer_arithmetics_learn_main(void)
{
	int intarray[5] = { 10, 20, 30, 40, 50 };

	for (int i = 0; i < 5; i++)
	{
		printf("intarray[%d] has value %d - and address @ %p\n", i, intarray[i], &intarray[i]);
	}

	int* intpointer = &intarray[3];
	display_pointer(intpointer);

	intpointer++;
	display_pointer(intpointer);

	return EXIT_SUCCESS;
}

void display_pointer(int* intpointer)
{
	printf("address: %p - has value %d\n", intpointer, *intpointer);
}