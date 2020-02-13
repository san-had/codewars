#include <stdlib.h>
#include <stdio.h>

void double_swap(double* p0, double* p1);

void double_swap_array(double a0[], double a1[]);

int pointer_main(void) {
	double d1 = 5.01;
	double d2 = 3.12;

	double_swap(&d1, &d2);

	printf("d1 = % g\nd2 = % g ", d1, d2);

	double a0[] = { 1.0, 2.3, 3.14 };

	double a1[] = { 2.8, 3.9, 5.14 };

	double_swap_array(a0, a1);

	printf("a0[0] = %g\na1[0] = %g", a0[0], a1[0]);

	double_swap(a0, a1);

	printf("a0[0] = %g\na1[0] = %g", a0[0], a1[0]);

	return EXIT_SUCCESS;
}

void double_swap(double* p0, double* p1) {
	double tmp = *p0;
	*p0 = *p1;
	*p1 = tmp;
}

void double_swap_array(double a0[10], double a1[10])
{
	double tmp = a0[0];
	a0[0] = a1[0];
	a1[0] = tmp;
}