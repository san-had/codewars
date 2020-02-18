#include <stdio.h>
#include <stdlib.h>

char* concat(const char* str1, const char* str2);

int main(void)
{
	//char* name = "John";

	//char name_array[] = "John Smith";

	//int* age = 25;

	//int age2 = age;

	//age2 += 3;

	//name += 1;

	////name = "Alex";

	//printf("%s\n", name);

	//printf("%d\n", age2);

	//printf("%s\n", name_array);

	//printf("%d\n", strlen(name));

	//char dest[20] = "Hello";

	//char src[20] = "World";

	//strncat(dest, src, 3);
	//printf("%s\n", dest);

	//strncat(dest, src, 20);
	//printf("%s\n", dest);

	//char* first_name = "John";

	//char last_name[] = "Doe";

	char* concatResult = concat("fire", "water");

	printf("%s\n", concatResult);

	return EXIT_SUCCESS;
}

char* concat(const char* str1, const char* str2)
{
	char* str3 = malloc(sizeof(char) * 30);
	strcpy(str3, "fire");
	strcat(str3, "-");
	char* str4 = "water";
	strcat(str3, str4);

	return str3;
}