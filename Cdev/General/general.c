#include <stdlib.h>
#include <stdio.h>

unsigned short* reverse_seq(unsigned short num);

int _main_general(void)
{
	puts("Hello world!");

	unsigned short num = 10;

	unsigned short* reverse_array = reverse_seq(num);

	for (unsigned short i = 0; i < num; i++)
	{
		unsigned short item = *(reverse_array + i);
		printf("%d\n", item);
	}
	free(reverse_array);
}

unsigned short* reverse_seq(unsigned short num)
{
	if (num == 0)
	{
		return NULL;
	}

	unsigned short* reverse_array;
	reverse_array = (unsigned short*)malloc(sizeof(unsigned short) * num);

	for (int i = 0; i < num; i++)
	{
		if (reverse_array != NULL)
		{
			//reverse_array[i] = num;
			*(reverse_array + i) = num - i;
		}
	}
	return reverse_array;
}