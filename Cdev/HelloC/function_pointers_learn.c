#include <stdlib.h>
#include <stdio.h>

void someFunction(int arg)
{
	printf("This is someFunction being called and arg is: %d\n", arg);
	printf("Whoops leaving the function now!\n");
}

int compare(const void* left, const void* right)
{
	//return (*(int*)right - *(int*)left);  // Desc order

	return (*(int*)left - *(int*)right);   // Asc order
}

int function_pointer_learn_main(void)
{
	//void (*pf)(int);
	//pf = &someFunction;
	//printf("We're about to call someFunction() using a pointer!\n");
	//(pf)(5);
	//printf("Wow that was cool. Back to main now!\n\n");

	int (*cmp) (const void*, const void*);

	cmp = &compare;

	int iarray[] = { 1,2,3,4,5,6,7,8,9 };
	qsort(iarray, sizeof(iarray) / sizeof(*iarray), sizeof(*iarray), cmp);

	int c = 0;
	while (c < sizeof(iarray) / sizeof(*iarray))
	{
		printf("%d \t", iarray[c]);
		c++;
	}

	return EXIT_SUCCESS;
}