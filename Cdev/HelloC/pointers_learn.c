#include <stdio.h>
#include <stdlib.h>

int pointers_main(void)
{
	char* name = "John";

	printf("%s\n", name);

	printf("%c\n", name[0]);

	int a = 1;

	int* pointer_to_a = &a;

	a += 1;

	printf("%d\n", *pointer_to_a);

	*pointer_to_a += 3;

	printf("%d\n", a);

	return EXIT_SUCCESS;
}