#include <stdlib.h>
#include <assert.h>

const short FLAG_ON = 1 << 0; // 1  (0x01)
const short FLAG_MOVEMENT = 1 << 1; // 2  (0x02)
const short FLAG_TRANSPARENT = 1 << 2; // 4  (0x04)
const short FLAG_ALIVE = 1 << 3; // 8  (0x08)
const short FLAG_BROKEN = 1 << 4; // 16 (0x10)
const short FLAG_EDIBLE = 1 << 5; // 32 (0x20)

int main(void)
{
	short attributes = 0;

	printf("%d\n", FLAG_MOVEMENT);

	assert(attributes == FLAG_ON | FLAG_TRANSPARENT);

	return EXIT_SUCCESS;
}