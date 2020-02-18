#include <stdlib.h>
#include <stdio.h>

typedef struct {
	int x;
	int y;
} point;

typedef struct {
	char* brand;
	int model;
} vehicle;

typedef struct {
	char* name;
	int age;
} person;

int struct_main(void)
{
	point p;

	p.x = 25;
	p.y = 31;

	vehicle mycar;
	mycar.brand = "Ford";
	mycar.model = 2007;

	person me;
	me.name = "Sanyi";
	me.age = 54;
}