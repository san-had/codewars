#include <stdio.h>
#include <stdlib.h>

int strings_learn_main(void)
{
	char* name = "John";

	char name_array[] = "John Smith";

	int* age = 25;

	int age2 = age;

	age2 += 3;

	name += 1;

	//name = "Alex";

	printf("%s\n", name);

	printf("%d\n", age2);

	printf("%s\n", name_array);

	printf("%d\n", strlen(name));

	char dest[20] = "Hello";

	char src[20] = "World";

	strncat(dest, src, 3);
	printf("%s\n", dest);

	strncat(dest, src, 20);
	printf("%s\n", dest);

	char* first_name = "John";

	char last_name[] = "Doe";

	return EXIT_SUCCESS;
}