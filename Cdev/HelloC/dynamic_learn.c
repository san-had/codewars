#include <stdlib.h>
#include <stdio.h>

typedef struct {
	char* name;
	int age;
} person;

int dynamic_main(void)
{
	person* myperson = (person*)malloc(sizeof(person));

	if (myperson != NULL)
	{
		myperson->name = "John";
		myperson->age = 18;
	}

	printf("myperson name: %s  age: %d\n", myperson->name, myperson->age);

	free(myperson);

	return EXIT_SUCCESS;
}