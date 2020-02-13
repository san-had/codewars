#include <stdlib.h>
#include <stdio.h>

unsigned short* reverse_seq(unsigned short num);

int main(void)
{
	puts("Hello world!");

	unsigned short num = 50;

	unsigned short* reverse_array = reverse_seq(num);

	for (unsigned short i = 0; i < num; i++)
	{
		unsigned short item = *(reverse_array + i);
		printf("%d\n", item);
	}
}

unsigned short* reverse_seq(unsigned short num)
{
	if (num == 0)
	{
		return NULL;
	}

	unsigned short length = num;

	static unsigned short* reverse_array;
	reverse_array = (unsigned short*)malloc(sizeof(unsigned short) * num);

	for (size_t i = 0; i < length; i++)
	{
		if (reverse_array != NULL)
		{
			//reverse_array[i] = num;
			*(reverse_array + i) = num;
			num--;
		}
	}
	return reverse_array;
}