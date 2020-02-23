#include <stdlib.h>
#include <stdio.h>

void dynamic_allocation(int n);

void dynamic_allocation_md_array(int rows, int columns);

void pascal_triangle(int row_num);

int main(void)
{
	char c = 'A';
	char* pc = &c;

	printf("%c\n", *pc);

	char vowels[] = { 'A', 'E', 'I', 'O', 'U' };
	char* pvowels = &vowels;

	printf("%u\n", &vowels);
	printf("%u\n", &vowels[0] + sizeof(char));
	printf("%u\n", vowels + 1);

	for (int i = 0; i < 5; i++)
	{
		printf("&vowels[%d]= %u, pvowels + %d= %u, vowels + %d= %u\n", i, &vowels[i], i, pvowels + i, i, vowels + i);
	}

	for (int i = 0; i < 5; i++)
	{
		printf("vowels[%d]= %c, *(pvowels + %d)= %c, *(vowels + %d)= %c\n", i, vowels[i], i, *(pvowels + i), i, *(vowels + i));
	}

	//dynamic_allocation(5);
	//dynamic_allocation_md_array(2, 5);

	pascal_triangle(3);

	return EXIT_SUCCESS;
}

void dynamic_allocation(int n)
{
	char* pvowels = (char*)malloc(sizeof(char) * n);

	if (pvowels == NULL)
	{
		return;
	}

	pvowels[0] = 'A';
	pvowels[1] = 'E';
	*(pvowels + 2) = 'I';
	pvowels[3] = 'O';
	*(pvowels + 4) = 'U';

	for (size_t i = 0; i < n; i++)
	{
		printf("%c ", pvowels[i]);
	}

	printf("\n");

	free(pvowels);
}

void dynamic_allocation_md_array(int rows, int columns)
{
	char** pvowels = (char**)malloc(rows * sizeof(char*));

	pvowels[0] = (char*)malloc(columns * sizeof(char));
	pvowels[1] = (char*)malloc(columns * sizeof(char));

	pvowels[0][0] = 'A';
	pvowels[0][1] = 'E';
	pvowels[0][2] = 'I';
	pvowels[0][3] = 'O';
	pvowels[0][4] = 'U';

	pvowels[1][0] = 'a';
	pvowels[1][1] = 'e';
	pvowels[1][2] = 'i';
	pvowels[1][3] = 'o';
	pvowels[1][4] = 'u';

	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			printf("%c ", pvowels[i][j]);
		}
		printf("\n");
	}

	free(pvowels[0]);
	free(pvowels[1]);

	free(pvowels);
}

void pascal_triangle(int row_num)
{
	int** triangle = (int**)malloc(sizeof(int) * row_num);

	for (int i = 0; i < row_num; i++)
	{
		triangle[i] = (int*)malloc((i + 1) * sizeof(int));
	}

	triangle[0][0] = 1;
	triangle[1][0] = 1;
	triangle[1][1] = 1;
	triangle[2][0] = 1;
	triangle[2][1] = 2;
	triangle[2][2] = 1;

	for (int i = 0; i < row_num; i++)
	{
		for (int j = 0; j <= i; j++)
		{
			printf("%d", triangle[i][j]);
		}
		printf("\n");
	}

	for (int i = 0; i < row_num; i++)
	{
		free(triangle[i]);
	}

	//free(triangle);
}