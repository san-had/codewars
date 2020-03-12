#include <stdlib.h>
#include <stdio.h>

int pointer_arithmetic_exec_main(void)
{
	int intarray[5] = { 10, 20, 30, 40, 50 };

	for (int i = 0; i < 5; i++)
	{
		printf("intarray[%d] has value %d - and address @ %p\n", i, intarray[i], &intarray[i]);
	}

	//int* intpointer = &intarray[3];
	//display_pointer(intpointer);

	//int** parray = (int*)malloc(sizeof(int) * 3);

	//for (int i = 0; i < 4; i++)
	//{
	//	parray[i] = &intarray[i];
	//	display_pointer(parray[i]);
	//}

	int* pointer = &intarray[0];

	int* parray[3];

	for (int i = 0; i < 3; i++)
	{
		parray[i] = pointer + i;
		display_pointer(parray[i]);
	}

	return EXIT_SUCCESS;
}