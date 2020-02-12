#include <stdlib.h>
#include <stdio.h>

unsigned short* reverse_seq(unsigned short num);

int main(void)
{
	puts("Hello world!");

	unsigned short num = 10;

	//unsigned short reverse_array[10];
	unsigned short* reverse_array = reverse_seq(num);

	//unsigned short first_item = *reverse_array;

	//unsigned short second_item = *(reverse_array + 1);

	//unsigned short third_item = *(reverse_array + 2);

	//printf("%u\n", first_item);

	//printf("%u\n", first_item);

	//printf("%u\n", second_item);

	//printf("%u\n", third_item);

	//unsigned short item = *reverse_array;

	for (unsigned short i = 0; i < num; i++)
	{
		unsigned short item = *(reverse_array + i);
		printf("%u\n", item);
	}

	//for (size_t i = 0; i < sizeof(reverse_array); i++)
	//{
	//}
}

unsigned short* reverse_seq(unsigned short num)
{
	unsigned short reverse_array[10];

	for (size_t i = 0; i < num; i++)
	{
		reverse_array[i] = num;
		num--;
	}
	return reverse_array;
}