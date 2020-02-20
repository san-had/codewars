#include <stdlib.h>
#include <stdio.h>

void addone(int* n)
{
	(*n)++;
}

typedef struct {
	int x;
	int y;
} point;

void move(point* p)
{
	p->x++;
	p->y++;
}

int func_arg_main(void)
{
	int n = 0;

	printf("Before: %d\n", n);

	addone(&n);

	printf("After: %d\n", n);

	point p = { p.x = 0, p.y = 0 };

	printf("Before: x: %d  y: %d\n", p.x, p.y);

	move(&p);

	printf("After: x: %d  y: %d\n", p.x, p.y);

	return EXIT_SUCCESS;
}