#include <stdlib.h>
#include <stdio.h>

unsigned short* reverse_seq(unsigned short num);

int main(void)
{
	puts("Hello world!");

	unsigned short reverse_array[10];
	*reverse_array = reverse_seq(10);

	printf(" %zu", *reverse_array);

	//for (size_t i = 0; i < sizeof(reverse_array); i++)
	//{
	//}
}

unsigned short* reverse_seq(unsigned short num)
{
	unsigned short* reverse_array;
	reverse_array = (unsigned short*)malloc(sizeof(unsigned short) * num);

	for (size_t i = 0; i < num; i++)
	{
		*(reverse_array + i) = num;
		num--;
	}
	return reverse_array;
}